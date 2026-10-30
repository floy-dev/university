using Checkers.Entity;

namespace Checkers;

public class Game
{
    private readonly Form1 form;
    private readonly Image? whiteImage;
    private readonly Image? blackImage;
    
    private Button? selectedChecker;
    private Button? capturingChecker;
    private readonly HashSet<Button> capturedCheckers = new();
    
    private bool gameStarted;
    private bool isWhitePlayer;
    private bool isWhiteTurn = true;
    private bool? winnerIsWhite;

    public bool? WinnerIsWhite => winnerIsWhite;

    public Game(Form1 form)
    {
        this.form = form;
        
        whiteImage = form.pnlBoard.Controls["btnCell70"]!.BackgroundImage;
        blackImage = form.pnlBoard.Controls["btnCell01"]!.BackgroundImage;
        
        InitializeCheckers();
        
        form.pnlBoard.Enabled = false;
    }

    public void ClearSelection()
    {
        selectedChecker = capturingChecker;
    }

    public void StartGame(bool isWhite)
    {
        isWhitePlayer = isWhite;
        isWhiteTurn = true;
        winnerIsWhite = null;
        
        selectedChecker = null;
        capturingChecker = null;
        capturedCheckers.Clear();
        
        InitializeCheckers();
        
        gameStarted = true;
        form.pnlBoard.Enabled = true;
        
        UpdateCounts();
        UpdateTurn();
    }

    public void StopGame()
    {
        gameStarted = false;
        winnerIsWhite = null;
        
        selectedChecker = null;
        capturingChecker = null;
        capturedCheckers.Clear();
        
        form.pnlBoard.Enabled = false;
        form.lblTurn.Text = "Ход: -";
    }

    public void ShowWinner()
    {
        string winner = winnerIsWhite == true ? "Победили белые" : "Победили чёрные";
        string result = winnerIsWhite == isWhitePlayer ? "Вы победили" : "Вы проиграли";
        form.lblTurn.Text = "Партия окончена";
        form.lblHint.Text = winner;
        MessageBox.Show(form, $"{winner}\n{result}", "Результат партии");
    }

    private void InitializeCheckers()
    {
        foreach (Button button in form.pnlBoard.Controls.OfType<Button>())
        {
            int row = button.Top / 125;
            int column = button.Left / 125;
            button.Tag = null;
            button.BackgroundImage = null;
            button.Text = "";

            if ((row + column) % 2 == 0)
            {
                continue;
            }

            if (row < 3)
            {
                button.Tag = new Checker(isWhite: false, isQueen: false);
                button.BackgroundImage = blackImage;
            }
            else if (row > 4)
            {
                button.Tag = new Checker(isWhite: true, isQueen: false);
                button.BackgroundImage = whiteImage;
            }
        }
    }

    public byte[]? SelectCell(Button cell)
    {
        if (!gameStarted || isWhiteTurn != isWhitePlayer)
        {
            return null;
        }

        if (cell.Tag is Checker checker && checker.IsWhite == isWhitePlayer)
        {
            if (capturingChecker != null && cell != capturingChecker)
            {
                return null;
            }

            if (capturingChecker == null && HasAnyCapture(isWhiteTurn) && !HasCapture(cell))
            {
                selectedChecker = null;
                return null;
            }

            selectedChecker = cell;
            return null;
        }

        if (selectedChecker == null || cell.Tag != null || !canMoveChecker(selectedChecker, cell))
        {
            selectedChecker = capturingChecker;
            return null;
        }

        byte[] move =
        {
            (byte)(selectedChecker.Top / 125),
            (byte)(selectedChecker.Left / 125),
            (byte)(cell.Top / 125),
            (byte)(cell.Left / 125)
        };

        MoveChecker(selectedChecker, cell);
        return move;
    }

    public bool ReceiveMove(byte[] move)
    {
        if (!gameStarted || isWhiteTurn == isWhitePlayer || move.Length != 4 || move.Max() > 7)
        {
            return false;
        }

        Button from = (Button)form.pnlBoard.Controls[$"btnCell{move[0]}{move[1]}"]!;
        Button to = (Button)form.pnlBoard.Controls[$"btnCell{move[2]}{move[3]}"]!;

        if (from.Tag is not Checker checker || checker.IsWhite != isWhiteTurn ||
            to.Tag != null || !canMoveChecker(from, to))
        {
            return false;
        }

        MoveChecker(from, to);
        return true;
    }

    private void MoveChecker(Button from, Button to)
    {
        Button? capturedChecker = GetCapturedChecker(from, to);
        if (capturedChecker != null)
        {
            capturedCheckers.Add(capturedChecker);
        }

        Checker checker = (Checker)from.Tag!;
        to.BackgroundImage = from.BackgroundImage;
        to.Tag = from.Tag;
        from.BackgroundImage = null;
        from.Tag = null;
        from.Text = "";

        int row = to.Top / 125;
        if ((checker.IsWhite && row == 0) || (!checker.IsWhite && row == 7))
        {
            checker.IsQueen = true;
        }

        to.Text = checker.IsQueen ? "Д" : "";
        to.ForeColor = checker.IsWhite ? Color.Black : Color.White;

        if (capturedChecker != null && HasCapture(to))
        {
            capturingChecker = to;
            selectedChecker = to;
            UpdateTurn();
            return;
        }

        foreach (Button captured in capturedCheckers)
        {
            captured.Tag = null;
            captured.BackgroundImage = null;
            captured.Text = "";
        }

        capturedCheckers.Clear();
        capturingChecker = null;
        selectedChecker = null;
        isWhiteTurn = !isWhiteTurn;
        UpdateCounts();

        if (!HasCheckers(isWhiteTurn))
        {
            winnerIsWhite = !isWhiteTurn;
            gameStarted = false;
            form.pnlBoard.Enabled = false;
            form.lblTurn.Text = "Партия окончена";
            form.lblHint.Text = "Завершение сессии";
            return;
        }

        UpdateTurn();
    }

    private bool canMoveChecker(Button selectedChecker, Button emptyCell)
    {
        if (capturingChecker != null && selectedChecker != capturingChecker)
        {
            return false;
        }

        if (CanCapture(selectedChecker, emptyCell))
        {
            return true;
        }

        if (capturingChecker != null || HasAnyCapture(isWhiteTurn))
        {
            return false;
        }

        return CanMoveNormally(selectedChecker, emptyCell);
    }

    private bool CanMoveNormally(Button selectedChecker, Button emptyCell)
    {
        int selectedCheckerRow = selectedChecker.Top / 125;
        int selectedCheckerColumn = selectedChecker.Left / 125;
        
        int emptyCellRow = emptyCell.Top / 125;
        int emptyCellColumn = emptyCell.Left / 125;

        int rowDistance = emptyCellRow - selectedCheckerRow;
        int columnDistance = emptyCellColumn - selectedCheckerColumn;
        Checker checker = (Checker)selectedChecker.Tag!;

        if (!checker.IsQueen)
        {
            int direction = checker.IsWhite ? -1 : 1;
            return rowDistance == direction && Math.Abs(columnDistance) == 1;
        }

        if (rowDistance == 0 || Math.Abs(rowDistance) != Math.Abs(columnDistance))
        {
            return false;
        }

        int rowStep = Math.Sign(rowDistance);
        int columnStep = Math.Sign(columnDistance);
        for (int row = selectedCheckerRow + rowStep, column = selectedCheckerColumn + columnStep;
             row != emptyCellRow; 
             row += rowStep, column += columnStep
        ) {
            if (GetCell(row, column)!.Tag != null)
            {
                return false;
            }
        }

        return true;
    }

    private bool CanCapture(Button from, Button to)
    {
        return GetCapturedChecker(from, to) != null;
    }

    private Button? GetCapturedChecker(Button from, Button to)
    {
        if (from.Tag is not Checker checker || to.Tag != null)
        {
            return null;
        }

        int fromRow = from.Top / 125;
        int fromColumn = from.Left / 125;
        int toRow = to.Top / 125;
        int toColumn = to.Left / 125;

        int rowDistance = toRow - fromRow;
        int columnDistance = toColumn - fromColumn;

        if (Math.Abs(rowDistance) < 2 || Math.Abs(rowDistance) != Math.Abs(columnDistance))
        {
            return null;
        }

        if (!checker.IsQueen && Math.Abs(rowDistance) != 2)
        {
            return null;
        }

        Button? captured = null;
        int rowStep = Math.Sign(rowDistance);
        int columnStep = Math.Sign(columnDistance);
        for (int row = fromRow + rowStep, column = fromColumn + columnStep;
             row != toRow; row += rowStep, column += columnStep)
        {
            Button cell = GetCell(row, column)!;
            if (cell.Tag is Checker opponent)
            {
                if (opponent.IsWhite == checker.IsWhite || captured != null || capturedCheckers.Contains(cell))
                {
                    return null;
                }

                captured = cell;
            }
        }

        return captured;
    }

    private bool HasCapture(Button from)
    {
        foreach (Button to in form.pnlBoard.Controls.OfType<Button>())
        {
            if (CanCapture(from, to))
            {
                return true;
            }
        }

        return false;
    }

    private bool HasAnyCapture(bool isWhite)
    {
        foreach (Button cell in form.pnlBoard.Controls.OfType<Button>())
        {
            if (cell.Tag is Checker checker && checker.IsWhite == isWhite && HasCapture(cell))
            {
                return true;
            }
        }

        return false;
    }

    private bool HasCheckers(bool isWhite)
    {
        foreach (Button cell in form.pnlBoard.Controls.OfType<Button>())
        {
            if (cell.Tag is Checker checker && checker.IsWhite == isWhite)
            {
                return true;
            }
        }

        return false;
    }

    private Button? GetCell(int row, int column)
    {
        if (row < 0 || row > 7 || column < 0 || column > 7)
        {
            return null;
        }

        return (Button)form.pnlBoard.Controls[$"btnCell{row}{column}"]!;
    }
    
    private void UpdateTurn()
    {
        form.lblTurn.Text = isWhiteTurn ? "Ход: Белые" : "Ход: Чёрные";
        if (isWhiteTurn != isWhitePlayer)
        {
            form.lblHint.Text = capturingChecker != null
                ? "Соперник продолжает взятие"
                : "Ожидание хода соперника";
        }
        else if (capturingChecker != null)
        {
            form.lblHint.Text = "Продолжите взятие той же шашкой";
        }
        else
        {
            form.lblHint.Text = HasAnyCapture(isWhiteTurn) ? "Ваш ход: взятие обязательно" : "Ваш ход";
        }
    }

    private void UpdateCounts()
    {
        int whiteCount = 0;
        int blackCount = 0;

        foreach (Button cell in form.pnlBoard.Controls.OfType<Button>())
        {
            if (cell.Tag is Checker checker)
            {
                if (checker.IsWhite)
                {
                    whiteCount++;
                }
                else
                {
                    blackCount++;
                }
            }
        }

        form.lblWhiteCount.Text = $"Белые: {whiteCount}";
        form.lblBlackCount.Text = $"Черные: {blackCount}";
    }
}
