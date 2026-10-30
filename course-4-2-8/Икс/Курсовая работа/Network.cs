using System.Net;
using System.Net.Sockets;

namespace Checkers;

public class Network
{
    private const byte ResultMessage = 255;
    private readonly Form1 form;
    private TcpListener? tcpListener;
    private TcpClient? tcpClient;
    private CancellationTokenSource? connectionCancellation;

    public Network(Form1 form)
    {
        this.form = form;
    }

    public async Task OpenConnectionAsync(bool isHost)
    {
        if (connectionCancellation != null)
        {
            return;
        }

        if (!int.TryParse(form.txtPort.Text, out int port) || port < 1 || port > 65535)
        {
            MessageBox.Show(form, "Введите порт от 1 до 65535", "Подключение");
            return;
        }

        IPAddress? serverAddress = null;
        if (!isHost && !IPAddress.TryParse(form.txtServerIp.Text.Trim(), out serverAddress))
        {
            MessageBox.Show(form, "Введите корректный IP-адрес сервера", "Подключение");
            return;
        }

        using var cancellation = new CancellationTokenSource();
        connectionCancellation = cancellation;
        SetConnectionControls(isBusy: true);

        TcpListener? listener = null;
        TcpClient? client = null;
        string finalStatus = "Статус: Нет подключения";
        string finalHint = "Создайте игру или подключитесь к сопернику";
        bool? finalWinner = null;

        try
        {
            if (isHost)
            {
                listener = new TcpListener(IPAddress.Any, port);
                tcpListener = listener;
                listener.Start();
                form.lblConnectionStatus.Text = "Статус: Ожидание игрока";
                form.lblHint.Text = $"Ожидание подключения на порту {port}";

                client = await listener.AcceptTcpClientAsync(cancellation.Token);
                cancellation.Token.ThrowIfCancellationRequested();
                listener.Stop();
                tcpListener = null;
                tcpClient = client;
            }
            else
            {
                client = new TcpClient(serverAddress!.AddressFamily);
                tcpClient = client;
                form.lblConnectionStatus.Text = "Статус: Подключение";
                form.lblHint.Text = $"Подключение к {serverAddress}:{port}";

                using var timeout = CancellationTokenSource.CreateLinkedTokenSource(cancellation.Token);
                timeout.CancelAfter(TimeSpan.FromSeconds(10));
                await client.ConnectAsync(serverAddress, port, timeout.Token);
            }

            cancellation.Token.ThrowIfCancellationRequested();
            form.lblMyColor.Text = isHost ? "Ваш цвет: Белые" : "Ваш цвет: Чёрные";
            form.lblConnectionStatus.Text = "Статус: Подключено";
            form.StartGame(isHost);

            NetworkStream stream = client.GetStream();
            byte[] move = new byte[4];
            while (await stream.ReadAsync(move.AsMemory(0, 1), cancellation.Token) != 0)
            {
                await stream.ReadExactlyAsync(move.AsMemory(1, 3), cancellation.Token);
                cancellation.Token.ThrowIfCancellationRequested();

                if (move[0] == ResultMessage)
                {
                    finalWinner = form.GetWinner();
                    break;
                }

                if (!form.ReceiveMove(move))
                {
                    throw new IOException("Получен недопустимый ход");
                }

                bool? receivedWinner = form.GetWinner();
                if (receivedWinner != null)
                {
                    byte[] result = { ResultMessage, (byte)(receivedWinner.Value ? 1 : 0), 0, 0 };
                    await stream.WriteAsync(result.AsMemory(), cancellation.Token);
                    cancellation.Token.ThrowIfCancellationRequested();
                    finalWinner = receivedWinner;
                    break;
                }
            }

            finalHint = "Соперник отключился";
        }
        catch (OperationCanceledException)
        {
            if (!cancellation.IsCancellationRequested)
            {
                finalStatus = "Статус: Нет подключения";
                finalHint = "Сервер не ответил за 10 секунд";
            }
        }
        catch (Exception exception) when (exception is SocketException or IOException or ObjectDisposedException)
        {
            if (!cancellation.IsCancellationRequested)
            {
                finalStatus = "Статус: Ошибка соединения";
                finalHint = "Проверьте IP, порт и доступность второго игрока";
            }
        }
        finally
        {
            client?.Dispose();
            listener?.Stop();

            if (ReferenceEquals(connectionCancellation, cancellation))
            {
                connectionCancellation = null;
                tcpClient = null;
                tcpListener = null;

                if (!form.IsDisposed && !form.Disposing)
                {
                    SetConnectionControls(isBusy: false);
                    if (finalWinner != null)
                    {
                        form.lblConnectionStatus.Text = "Статус: Сессия завершена";
                        form.ShowWinner();
                    }
                    else
                    {
                        form.StopGame();
                        form.lblMyColor.Text = "Ваш цвет: -";
                        form.lblConnectionStatus.Text = finalStatus;
                        form.lblHint.Text = finalHint;
                    }
                }
            }
        }
    }

    public async Task SendMoveAsync(byte[] move)
    {
        TcpClient? client = tcpClient;
        CancellationTokenSource? cancellation = connectionCancellation;
        if (client == null || cancellation == null)
        {
            return;
        }

        try
        {
            await client.GetStream().WriteAsync(move.AsMemory(), cancellation.Token);
        }
        catch (Exception exception) when 
                (exception is SocketException 
                    or IOException 
                    or ObjectDisposedException 
                    or OperationCanceledException
                )
        {
            if (ReferenceEquals(connectionCancellation, cancellation))
            {
                CloseConnection();
                if (!form.IsDisposed && !form.Disposing)
                {
                    form.lblHint.Text = "Не удалось отправить ход, подключитесь заново";
                }
            }
        }
    }

    public void CloseConnection(bool updateControls = true)
    {
        connectionCancellation?.Cancel();
        tcpClient?.Dispose();
        tcpListener?.Stop();
        
        connectionCancellation = null;
        tcpClient = null;
        tcpListener = null;

        if (updateControls && !form.IsDisposed && !form.Disposing)
        {
            form.StopGame();
            SetConnectionControls(isBusy: false);
            
            form.lblMyColor.Text = "Ваш цвет: -";
            form.lblConnectionStatus.Text = "Статус: Нет подключения";
            form.lblHint.Text = "Создайте игру или подключитесь к сопернику";
        }
    }

    private void SetConnectionControls(bool isBusy)
    {
        form.btnHost.Enabled = !isBusy;
        form.btnConnect.Enabled = !isBusy;
        form.btnDisconnect.Enabled = isBusy;
        form.txtServerIp.Enabled = !isBusy;
        form.txtPort.Enabled = !isBusy;
    }

}
