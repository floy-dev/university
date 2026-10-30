namespace Checkers;

public partial class Form1 : Form
{
    private readonly Network network;
    private readonly Game game;
    private bool isSendingMove;

    public Form1()
    {
        InitializeComponent();
        network = new Network(this);
        game = new Game(this);
    }
    
    private async void btnCelClick(object sender, EventArgs e)
    {
        if (sender is Button cell && !isSendingMove)
        {
            byte[]? move = game.SelectCell(cell);
            if (move != null)
            {
                isSendingMove = true;
                try
                {
                    await network.SendMoveAsync(move);
                }
                finally
                {
                    isSendingMove = false;
                }
            }
        }
    }

    private async void BtnHost_Click(object? sender, EventArgs e)
    {
        game.ClearSelection();
        await network.OpenConnectionAsync(isHost: true);
    }

    private async void BtnConnect_Click(object? sender, EventArgs e)
    {
        game.ClearSelection();
        await network.OpenConnectionAsync(isHost: false);
    }

    private void BtnDisconnect_Click(object? sender, EventArgs e)
    {
        game.ClearSelection();
        network.CloseConnection();
    }

    private void GameForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        network.CloseConnection(updateControls: false);
    }
    
    internal void StartGame(bool isWhite)
    {
        game.StartGame(isWhite);
    }

    internal void StopGame()
    {
        game.StopGame();
    }

    internal bool ReceiveMove(byte[] move)
    {
        return game.ReceiveMove(move);
    }

    internal bool? GetWinner()
    {
        return game.WinnerIsWhite;
    }

    internal void ShowWinner()
    {
        game.ShowWinner();
    }
}
