namespace Checkers;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        lblConnectionStatus = new System.Windows.Forms.Label();
        lblMyColor = new System.Windows.Forms.Label();
        lblServerIp = new System.Windows.Forms.Label();
        lblPort = new System.Windows.Forms.Label();
        txtServerIp = new System.Windows.Forms.TextBox();
        txtPort = new System.Windows.Forms.TextBox();
        grpConnection = new System.Windows.Forms.GroupBox();
        btnDisconnect = new System.Windows.Forms.Button();
        btnConnect = new System.Windows.Forms.Button();
        btnHost = new System.Windows.Forms.Button();
        grpGame = new System.Windows.Forms.GroupBox();
        lblBlackCount = new System.Windows.Forms.Label();
        lblWhiteCount = new System.Windows.Forms.Label();
        lblTurn = new System.Windows.Forms.Label();
        lblHint = new System.Windows.Forms.Label();
        pnlBoard = new System.Windows.Forms.Panel();
        btnCell77 = new System.Windows.Forms.Button();
        btnCell75 = new System.Windows.Forms.Button();
        btnCell73 = new System.Windows.Forms.Button();
        btnCell71 = new System.Windows.Forms.Button();
        btnCell66 = new System.Windows.Forms.Button();
        btnCell64 = new System.Windows.Forms.Button();
        btnCell62 = new System.Windows.Forms.Button();
        btnCell60 = new System.Windows.Forms.Button();
        btnCell57 = new System.Windows.Forms.Button();
        btnCell55 = new System.Windows.Forms.Button();
        btnCell53 = new System.Windows.Forms.Button();
        btnCell51 = new System.Windows.Forms.Button();
        btnCell47 = new System.Windows.Forms.Button();
        btnCell46 = new System.Windows.Forms.Button();
        btnCell45 = new System.Windows.Forms.Button();
        btnCell44 = new System.Windows.Forms.Button();
        btnCell43 = new System.Windows.Forms.Button();
        btnCell42 = new System.Windows.Forms.Button();
        btnCell41 = new System.Windows.Forms.Button();
        btnCell37 = new System.Windows.Forms.Button();
        btnCell36 = new System.Windows.Forms.Button();
        btnCell35 = new System.Windows.Forms.Button();
        btnCell40 = new System.Windows.Forms.Button();
        btnCell34 = new System.Windows.Forms.Button();
        btnCell33 = new System.Windows.Forms.Button();
        btnCell32 = new System.Windows.Forms.Button();
        btnCell31 = new System.Windows.Forms.Button();
        btnCell30 = new System.Windows.Forms.Button();
        btnCell26 = new System.Windows.Forms.Button();
        btnCell24 = new System.Windows.Forms.Button();
        btnCell22 = new System.Windows.Forms.Button();
        btnCell20 = new System.Windows.Forms.Button();
        btnCell17 = new System.Windows.Forms.Button();
        btnCell15 = new System.Windows.Forms.Button();
        btnCell13 = new System.Windows.Forms.Button();
        btnCell11 = new System.Windows.Forms.Button();
        btnCell06 = new System.Windows.Forms.Button();
        btnCell04 = new System.Windows.Forms.Button();
        btnCell02 = new System.Windows.Forms.Button();
        btnCell00 = new System.Windows.Forms.Button();
        btnCell07 = new System.Windows.Forms.Button();
        btnCell27 = new System.Windows.Forms.Button();
        btnCell16 = new System.Windows.Forms.Button();
        btnCell25 = new System.Windows.Forms.Button();
        btnCell05 = new System.Windows.Forms.Button();
        btnCell14 = new System.Windows.Forms.Button();
        btnCell23 = new System.Windows.Forms.Button();
        btnCell03 = new System.Windows.Forms.Button();
        btnCell12 = new System.Windows.Forms.Button();
        btnCell01 = new System.Windows.Forms.Button();
        btnCell21 = new System.Windows.Forms.Button();
        btnCell56 = new System.Windows.Forms.Button();
        btnCell54 = new System.Windows.Forms.Button();
        btnCell52 = new System.Windows.Forms.Button();
        btnCell50 = new System.Windows.Forms.Button();
        btnCell67 = new System.Windows.Forms.Button();
        btnCell76 = new System.Windows.Forms.Button();
        btnCell65 = new System.Windows.Forms.Button();
        btnCell74 = new System.Windows.Forms.Button();
        btnCell63 = new System.Windows.Forms.Button();
        btnCell72 = new System.Windows.Forms.Button();
        btnCell61 = new System.Windows.Forms.Button();
        btnCell10 = new System.Windows.Forms.Button();
        btnCell70 = new System.Windows.Forms.Button();
        grpConnection.SuspendLayout();
        grpGame.SuspendLayout();
        pnlBoard.SuspendLayout();
        SuspendLayout();
        // 
        // lblConnectionStatus
        // 
        lblConnectionStatus.Location = new System.Drawing.Point(12, 9);
        lblConnectionStatus.Name = "lblConnectionStatus";
        lblConnectionStatus.Size = new System.Drawing.Size(317, 61);
        lblConnectionStatus.TabIndex = 0;
        lblConnectionStatus.Text = "Статус: Нет подключения";
        // 
        // lblMyColor
        // 
        lblMyColor.Location = new System.Drawing.Point(1044, 9);
        lblMyColor.Name = "lblMyColor";
        lblMyColor.Size = new System.Drawing.Size(317, 61);
        lblMyColor.TabIndex = 1;
        lblMyColor.Text = "Ваш цвет: -";
        // 
        // lblServerIp
        // 
        lblServerIp.Location = new System.Drawing.Point(6, 45);
        lblServerIp.Name = "lblServerIp";
        lblServerIp.Size = new System.Drawing.Size(175, 37);
        lblServerIp.TabIndex = 2;
        lblServerIp.Text = "IP сервера";
        // 
        // lblPort
        // 
        lblPort.Location = new System.Drawing.Point(242, 45);
        lblPort.Name = "lblPort";
        lblPort.Size = new System.Drawing.Size(175, 37);
        lblPort.TabIndex = 3;
        lblPort.Text = "Порт";
        // 
        // txtServerIp
        // 
        txtServerIp.Location = new System.Drawing.Point(6, 85);
        txtServerIp.Name = "txtServerIp";
        txtServerIp.Size = new System.Drawing.Size(230, 39);
        txtServerIp.TabIndex = 4;
        txtServerIp.Text = "127.0.0.1";
        // 
        // txtPort
        // 
        txtPort.Location = new System.Drawing.Point(242, 85);
        txtPort.Name = "txtPort";
        txtPort.Size = new System.Drawing.Size(219, 39);
        txtPort.TabIndex = 5;
        txtPort.Text = "5000";
        // 
        // grpConnection
        // 
        grpConnection.Controls.Add(btnDisconnect);
        grpConnection.Controls.Add(btnConnect);
        grpConnection.Controls.Add(btnHost);
        grpConnection.Controls.Add(txtPort);
        grpConnection.Controls.Add(txtServerIp);
        grpConnection.Controls.Add(lblPort);
        grpConnection.Controls.Add(lblServerIp);
        grpConnection.Location = new System.Drawing.Point(1034, 86);
        grpConnection.Name = "grpConnection";
        grpConnection.Size = new System.Drawing.Size(477, 358);
        grpConnection.TabIndex = 2;
        grpConnection.TabStop = false;
        grpConnection.Text = "Подключение";
        // 
        // btnDisconnect
        // 
        btnDisconnect.Enabled = false;
        btnDisconnect.Location = new System.Drawing.Point(6, 284);
        btnDisconnect.Name = "btnDisconnect";
        btnDisconnect.Click += BtnDisconnect_Click;
        btnDisconnect.Size = new System.Drawing.Size(455, 59);
        btnDisconnect.TabIndex = 8;
        btnDisconnect.Text = "Отключиться";
        btnDisconnect.UseVisualStyleBackColor = true;
        // 
        // btnConnect
        // 
        btnConnect.Location = new System.Drawing.Point(6, 219);
        btnConnect.Name = "btnConnect";
        btnConnect.Click += BtnConnect_Click;
        btnConnect.Size = new System.Drawing.Size(455, 59);
        btnConnect.TabIndex = 7;
        btnConnect.Text = "Подключиться";
        btnConnect.UseVisualStyleBackColor = true;
        // 
        // btnHost
        // 
        btnHost.Location = new System.Drawing.Point(6, 154);
        btnHost.Name = "btnHost";
        btnHost.Click += BtnHost_Click;
        btnHost.Size = new System.Drawing.Size(455, 59);
        btnHost.TabIndex = 6;
        btnHost.Text = "Создать игру";
        btnHost.UseVisualStyleBackColor = true;
        // 
        // grpGame
        // 
        grpGame.Controls.Add(lblBlackCount);
        grpGame.Controls.Add(lblWhiteCount);
        grpGame.Controls.Add(lblTurn);
        grpGame.Location = new System.Drawing.Point(1034, 450);
        grpGame.Name = "grpGame";
        grpGame.Size = new System.Drawing.Size(483, 322);
        grpGame.TabIndex = 3;
        grpGame.TabStop = false;
        grpGame.Text = "Партия";
        // 
        // lblBlackCount
        // 
        lblBlackCount.Location = new System.Drawing.Point(6, 182);
        lblBlackCount.Name = "lblBlackCount";
        lblBlackCount.Size = new System.Drawing.Size(175, 37);
        lblBlackCount.TabIndex = 4;
        lblBlackCount.Text = "Черные: 12";
        // 
        // lblWhiteCount
        // 
        lblWhiteCount.Location = new System.Drawing.Point(6, 130);
        lblWhiteCount.Name = "lblWhiteCount";
        lblWhiteCount.Size = new System.Drawing.Size(175, 37);
        lblWhiteCount.TabIndex = 3;
        lblWhiteCount.Text = "Белые: 12";
        // 
        // lblTurn
        // 
        lblTurn.Location = new System.Drawing.Point(6, 73);
        lblTurn.Name = "lblTurn";
        lblTurn.Size = new System.Drawing.Size(175, 37);
        lblTurn.TabIndex = 2;
        lblTurn.Text = "Ход: -";
        // 
        // lblHint
        // 
        lblHint.Location = new System.Drawing.Point(1034, 983);
        lblHint.Name = "lblHint";
        lblHint.Size = new System.Drawing.Size(392, 78);
        lblHint.TabIndex = 4;
        lblHint.Text = "Создайте игру или подключитесь к сопернику";
        // 
        // pnlBoard
        // 
        pnlBoard.BackgroundImage = ((System.Drawing.Image)resources.GetObject("pnlBoard.BackgroundImage"));
        pnlBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        pnlBoard.Controls.Add(btnCell77);
        pnlBoard.Controls.Add(btnCell75);
        pnlBoard.Controls.Add(btnCell73);
        pnlBoard.Controls.Add(btnCell71);
        pnlBoard.Controls.Add(btnCell66);
        pnlBoard.Controls.Add(btnCell64);
        pnlBoard.Controls.Add(btnCell62);
        pnlBoard.Controls.Add(btnCell60);
        pnlBoard.Controls.Add(btnCell57);
        pnlBoard.Controls.Add(btnCell55);
        pnlBoard.Controls.Add(btnCell53);
        pnlBoard.Controls.Add(btnCell51);
        pnlBoard.Controls.Add(btnCell47);
        pnlBoard.Controls.Add(btnCell46);
        pnlBoard.Controls.Add(btnCell45);
        pnlBoard.Controls.Add(btnCell44);
        pnlBoard.Controls.Add(btnCell43);
        pnlBoard.Controls.Add(btnCell42);
        pnlBoard.Controls.Add(btnCell41);
        pnlBoard.Controls.Add(btnCell37);
        pnlBoard.Controls.Add(btnCell36);
        pnlBoard.Controls.Add(btnCell35);
        pnlBoard.Controls.Add(btnCell40);
        pnlBoard.Controls.Add(btnCell34);
        pnlBoard.Controls.Add(btnCell33);
        pnlBoard.Controls.Add(btnCell32);
        pnlBoard.Controls.Add(btnCell31);
        pnlBoard.Controls.Add(btnCell30);
        pnlBoard.Controls.Add(btnCell26);
        pnlBoard.Controls.Add(btnCell24);
        pnlBoard.Controls.Add(btnCell22);
        pnlBoard.Controls.Add(btnCell20);
        pnlBoard.Controls.Add(btnCell17);
        pnlBoard.Controls.Add(btnCell15);
        pnlBoard.Controls.Add(btnCell13);
        pnlBoard.Controls.Add(btnCell11);
        pnlBoard.Controls.Add(btnCell06);
        pnlBoard.Controls.Add(btnCell04);
        pnlBoard.Controls.Add(btnCell02);
        pnlBoard.Controls.Add(btnCell00);
        pnlBoard.Controls.Add(btnCell07);
        pnlBoard.Controls.Add(btnCell27);
        pnlBoard.Controls.Add(btnCell16);
        pnlBoard.Controls.Add(btnCell25);
        pnlBoard.Controls.Add(btnCell05);
        pnlBoard.Controls.Add(btnCell14);
        pnlBoard.Controls.Add(btnCell23);
        pnlBoard.Controls.Add(btnCell03);
        pnlBoard.Controls.Add(btnCell12);
        pnlBoard.Controls.Add(btnCell01);
        pnlBoard.Controls.Add(btnCell21);
        pnlBoard.Controls.Add(btnCell56);
        pnlBoard.Controls.Add(btnCell54);
        pnlBoard.Controls.Add(btnCell52);
        pnlBoard.Controls.Add(btnCell50);
        pnlBoard.Controls.Add(btnCell67);
        pnlBoard.Controls.Add(btnCell76);
        pnlBoard.Controls.Add(btnCell65);
        pnlBoard.Controls.Add(btnCell74);
        pnlBoard.Controls.Add(btnCell63);
        pnlBoard.Controls.Add(btnCell72);
        pnlBoard.Controls.Add(btnCell61);
        pnlBoard.Controls.Add(btnCell10);
        pnlBoard.Controls.Add(btnCell70);
        pnlBoard.Location = new System.Drawing.Point(12, 61);
        pnlBoard.MinimumSize = new System.Drawing.Size(512, 512);
        pnlBoard.Name = "pnlBoard";
        pnlBoard.Size = new System.Drawing.Size(1000, 1000);
        pnlBoard.TabIndex = 5;
        // 
        // btnCell77
        // 
        btnCell77.BackColor = System.Drawing.Color.Transparent;
        btnCell77.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell77.FlatAppearance.BorderSize = 0;
        btnCell77.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell77.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell77.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell77.Location = new System.Drawing.Point(875, 875);
        btnCell77.Name = "btnCell77";
        btnCell77.Click += btnCelClick;
        btnCell77.Size = new System.Drawing.Size(125, 125);
        btnCell77.TabIndex = 63;
        btnCell77.UseVisualStyleBackColor = false;
        // 
        // btnCell75
        // 
        btnCell75.BackColor = System.Drawing.Color.Transparent;
        btnCell75.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell75.FlatAppearance.BorderSize = 0;
        btnCell75.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell75.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell75.Location = new System.Drawing.Point(625, 875);
        btnCell75.Name = "btnCell75";
        btnCell75.Click += btnCelClick;
        btnCell75.Size = new System.Drawing.Size(125, 125);
        btnCell75.TabIndex = 62;
        btnCell75.UseVisualStyleBackColor = false;
        // 
        // btnCell73
        // 
        btnCell73.BackColor = System.Drawing.Color.Transparent;
        btnCell73.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell73.FlatAppearance.BorderSize = 0;
        btnCell73.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell73.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell73.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell73.Location = new System.Drawing.Point(375, 875);
        btnCell73.Name = "btnCell73";
        btnCell73.Click += btnCelClick;
        btnCell73.Size = new System.Drawing.Size(125, 125);
        btnCell73.TabIndex = 61;
        btnCell73.UseVisualStyleBackColor = false;
        // 
        // btnCell71
        // 
        btnCell71.BackColor = System.Drawing.Color.Transparent;
        btnCell71.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell71.FlatAppearance.BorderSize = 0;
        btnCell71.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell71.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell71.Location = new System.Drawing.Point(125, 875);
        btnCell71.Name = "btnCell71";
        btnCell71.Click += btnCelClick;
        btnCell71.Size = new System.Drawing.Size(125, 125);
        btnCell71.TabIndex = 60;
        btnCell71.UseVisualStyleBackColor = false;
        // 
        // btnCell66
        // 
        btnCell66.BackColor = System.Drawing.Color.Transparent;
        btnCell66.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell66.FlatAppearance.BorderSize = 0;
        btnCell66.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell66.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell66.Location = new System.Drawing.Point(750, 750);
        btnCell66.Name = "btnCell66";
        btnCell66.Click += btnCelClick;
        btnCell66.Size = new System.Drawing.Size(125, 125);
        btnCell66.TabIndex = 59;
        btnCell66.UseVisualStyleBackColor = false;
        // 
        // btnCell64
        // 
        btnCell64.BackColor = System.Drawing.Color.Transparent;
        btnCell64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell64.FlatAppearance.BorderSize = 0;
        btnCell64.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell64.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell64.Location = new System.Drawing.Point(500, 750);
        btnCell64.Name = "btnCell64";
        btnCell64.Click += btnCelClick;
        btnCell64.Size = new System.Drawing.Size(125, 125);
        btnCell64.TabIndex = 58;
        btnCell64.UseVisualStyleBackColor = false;
        // 
        // btnCell62
        // 
        btnCell62.BackColor = System.Drawing.Color.Transparent;
        btnCell62.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell62.FlatAppearance.BorderSize = 0;
        btnCell62.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell62.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell62.Location = new System.Drawing.Point(250, 750);
        btnCell62.Name = "btnCell62";
        btnCell62.Click += btnCelClick;
        btnCell62.Size = new System.Drawing.Size(125, 125);
        btnCell62.TabIndex = 57;
        btnCell62.UseVisualStyleBackColor = false;
        // 
        // btnCell60
        // 
        btnCell60.BackColor = System.Drawing.Color.Transparent;
        btnCell60.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell60.FlatAppearance.BorderSize = 0;
        btnCell60.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell60.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell60.Location = new System.Drawing.Point(0, 750);
        btnCell60.Name = "btnCell60";
        btnCell60.Click += btnCelClick;
        btnCell60.Size = new System.Drawing.Size(125, 125);
        btnCell60.TabIndex = 56;
        btnCell60.UseVisualStyleBackColor = false;
        // 
        // btnCell57
        // 
        btnCell57.BackColor = System.Drawing.Color.Transparent;
        btnCell57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell57.FlatAppearance.BorderSize = 0;
        btnCell57.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell57.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell57.Location = new System.Drawing.Point(875, 625);
        btnCell57.Name = "btnCell57";
        btnCell57.Click += btnCelClick;
        btnCell57.Size = new System.Drawing.Size(125, 125);
        btnCell57.TabIndex = 55;
        btnCell57.UseVisualStyleBackColor = false;
        // 
        // btnCell55
        // 
        btnCell55.BackColor = System.Drawing.Color.Transparent;
        btnCell55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell55.FlatAppearance.BorderSize = 0;
        btnCell55.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell55.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell55.Location = new System.Drawing.Point(625, 625);
        btnCell55.Name = "btnCell55";
        btnCell55.Click += btnCelClick;
        btnCell55.Size = new System.Drawing.Size(125, 125);
        btnCell55.TabIndex = 54;
        btnCell55.UseVisualStyleBackColor = false;
        // 
        // btnCell53
        // 
        btnCell53.BackColor = System.Drawing.Color.Transparent;
        btnCell53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell53.FlatAppearance.BorderSize = 0;
        btnCell53.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell53.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell53.Location = new System.Drawing.Point(375, 625);
        btnCell53.Name = "btnCell53";
        btnCell53.Click += btnCelClick;
        btnCell53.Size = new System.Drawing.Size(125, 125);
        btnCell53.TabIndex = 53;
        btnCell53.UseVisualStyleBackColor = false;
        // 
        // btnCell51
        // 
        btnCell51.BackColor = System.Drawing.Color.Transparent;
        btnCell51.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell51.FlatAppearance.BorderSize = 0;
        btnCell51.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell51.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell51.Location = new System.Drawing.Point(125, 625);
        btnCell51.Name = "btnCell51";
        btnCell51.Click += btnCelClick;
        btnCell51.Size = new System.Drawing.Size(125, 125);
        btnCell51.TabIndex = 52;
        btnCell51.UseVisualStyleBackColor = false;
        // 
        // btnCell47
        // 
        btnCell47.BackColor = System.Drawing.Color.Transparent;
        btnCell47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell47.FlatAppearance.BorderSize = 0;
        btnCell47.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell47.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell47.Location = new System.Drawing.Point(875, 500);
        btnCell47.Name = "btnCell47";
        btnCell47.Click += btnCelClick;
        btnCell47.Size = new System.Drawing.Size(125, 125);
        btnCell47.TabIndex = 51;
        btnCell47.UseVisualStyleBackColor = false;
        // 
        // btnCell46
        // 
        btnCell46.BackColor = System.Drawing.Color.Transparent;
        btnCell46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell46.FlatAppearance.BorderSize = 0;
        btnCell46.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell46.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell46.Location = new System.Drawing.Point(750, 500);
        btnCell46.Name = "btnCell46";
        btnCell46.Click += btnCelClick;
        btnCell46.Size = new System.Drawing.Size(125, 125);
        btnCell46.TabIndex = 50;
        btnCell46.UseVisualStyleBackColor = false;
        // 
        // btnCell45
        // 
        btnCell45.BackColor = System.Drawing.Color.Transparent;
        btnCell45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell45.FlatAppearance.BorderSize = 0;
        btnCell45.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell45.Location = new System.Drawing.Point(625, 500);
        btnCell45.Name = "btnCell45";
        btnCell45.Click += btnCelClick;
        btnCell45.Size = new System.Drawing.Size(125, 125);
        btnCell45.TabIndex = 49;
        btnCell45.UseVisualStyleBackColor = false;
        // 
        // btnCell44
        // 
        btnCell44.BackColor = System.Drawing.Color.Transparent;
        btnCell44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell44.FlatAppearance.BorderSize = 0;
        btnCell44.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell44.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell44.Location = new System.Drawing.Point(500, 500);
        btnCell44.Name = "btnCell44";
        btnCell44.Click += btnCelClick;
        btnCell44.Size = new System.Drawing.Size(125, 125);
        btnCell44.TabIndex = 48;
        btnCell44.UseVisualStyleBackColor = false;
        // 
        // btnCell43
        // 
        btnCell43.BackColor = System.Drawing.Color.Transparent;
        btnCell43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell43.FlatAppearance.BorderSize = 0;
        btnCell43.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell43.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell43.Location = new System.Drawing.Point(375, 500);
        btnCell43.Name = "btnCell43";
        btnCell43.Click += btnCelClick;
        btnCell43.Size = new System.Drawing.Size(125, 125);
        btnCell43.TabIndex = 47;
        btnCell43.UseVisualStyleBackColor = false;
        // 
        // btnCell42
        // 
        btnCell42.BackColor = System.Drawing.Color.Transparent;
        btnCell42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell42.FlatAppearance.BorderSize = 0;
        btnCell42.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell42.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell42.Location = new System.Drawing.Point(250, 500);
        btnCell42.Name = "btnCell42";
        btnCell42.Click += btnCelClick;
        btnCell42.Size = new System.Drawing.Size(125, 125);
        btnCell42.TabIndex = 46;
        btnCell42.UseVisualStyleBackColor = false;
        // 
        // btnCell41
        // 
        btnCell41.BackColor = System.Drawing.Color.Transparent;
        btnCell41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell41.FlatAppearance.BorderSize = 0;
        btnCell41.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell41.Location = new System.Drawing.Point(125, 500);
        btnCell41.Name = "btnCell41";
        btnCell41.Click += btnCelClick;
        btnCell41.Size = new System.Drawing.Size(125, 125);
        btnCell41.TabIndex = 45;
        btnCell41.UseVisualStyleBackColor = false;
        // 
        // btnCell37
        // 
        btnCell37.BackColor = System.Drawing.Color.Transparent;
        btnCell37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell37.FlatAppearance.BorderSize = 0;
        btnCell37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell37.Location = new System.Drawing.Point(875, 375);
        btnCell37.Name = "btnCell37";
        btnCell37.Click += btnCelClick;
        btnCell37.Size = new System.Drawing.Size(125, 125);
        btnCell37.TabIndex = 44;
        btnCell37.UseVisualStyleBackColor = false;
        // 
        // btnCell36
        // 
        btnCell36.BackColor = System.Drawing.Color.Transparent;
        btnCell36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell36.FlatAppearance.BorderSize = 0;
        btnCell36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell36.Location = new System.Drawing.Point(750, 375);
        btnCell36.Name = "btnCell36";
        btnCell36.Click += btnCelClick;
        btnCell36.Size = new System.Drawing.Size(125, 125);
        btnCell36.TabIndex = 43;
        btnCell36.UseVisualStyleBackColor = false;
        // 
        // btnCell35
        // 
        btnCell35.BackColor = System.Drawing.Color.Transparent;
        btnCell35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell35.FlatAppearance.BorderSize = 0;
        btnCell35.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell35.Location = new System.Drawing.Point(625, 375);
        btnCell35.Name = "btnCell35";
        btnCell35.Click += btnCelClick;
        btnCell35.Size = new System.Drawing.Size(125, 125);
        btnCell35.TabIndex = 42;
        btnCell35.UseVisualStyleBackColor = false;
        // 
        // btnCell40
        // 
        btnCell40.BackColor = System.Drawing.Color.Transparent;
        btnCell40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell40.FlatAppearance.BorderSize = 0;
        btnCell40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell40.Location = new System.Drawing.Point(0, 500);
        btnCell40.Name = "btnCell40";
        btnCell40.Click += btnCelClick;
        btnCell40.Size = new System.Drawing.Size(125, 125);
        btnCell40.TabIndex = 41;
        btnCell40.UseVisualStyleBackColor = false;
        // 
        // btnCell34
        // 
        btnCell34.BackColor = System.Drawing.Color.Transparent;
        btnCell34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell34.FlatAppearance.BorderSize = 0;
        btnCell34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell34.Location = new System.Drawing.Point(500, 375);
        btnCell34.Name = "btnCell34";
        btnCell34.Click += btnCelClick;
        btnCell34.Size = new System.Drawing.Size(125, 125);
        btnCell34.TabIndex = 40;
        btnCell34.UseVisualStyleBackColor = false;
        // 
        // btnCell33
        // 
        btnCell33.BackColor = System.Drawing.Color.Transparent;
        btnCell33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell33.FlatAppearance.BorderSize = 0;
        btnCell33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell33.Location = new System.Drawing.Point(375, 375);
        btnCell33.Name = "btnCell33";
        btnCell33.Click += btnCelClick;
        btnCell33.Size = new System.Drawing.Size(125, 125);
        btnCell33.TabIndex = 39;
        btnCell33.UseVisualStyleBackColor = false;
        // 
        // btnCell32
        // 
        btnCell32.BackColor = System.Drawing.Color.Transparent;
        btnCell32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell32.FlatAppearance.BorderSize = 0;
        btnCell32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell32.Location = new System.Drawing.Point(250, 375);
        btnCell32.Name = "btnCell32";
        btnCell32.Click += btnCelClick;
        btnCell32.Size = new System.Drawing.Size(125, 125);
        btnCell32.TabIndex = 38;
        btnCell32.UseVisualStyleBackColor = false;
        // 
        // btnCell31
        // 
        btnCell31.BackColor = System.Drawing.Color.Transparent;
        btnCell31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell31.FlatAppearance.BorderSize = 0;
        btnCell31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell31.Location = new System.Drawing.Point(125, 375);
        btnCell31.Name = "btnCell31";
        btnCell31.Click += btnCelClick;
        btnCell31.Size = new System.Drawing.Size(125, 125);
        btnCell31.TabIndex = 37;
        btnCell31.UseVisualStyleBackColor = false;
        // 
        // btnCell30
        // 
        btnCell30.BackColor = System.Drawing.Color.Transparent;
        btnCell30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell30.FlatAppearance.BorderSize = 0;
        btnCell30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell30.Location = new System.Drawing.Point(0, 375);
        btnCell30.Name = "btnCell30";
        btnCell30.Click += btnCelClick;
        btnCell30.Size = new System.Drawing.Size(125, 125);
        btnCell30.TabIndex = 36;
        btnCell30.UseVisualStyleBackColor = false;
        // 
        // btnCell26
        // 
        btnCell26.BackColor = System.Drawing.Color.Transparent;
        btnCell26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell26.FlatAppearance.BorderSize = 0;
        btnCell26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell26.Location = new System.Drawing.Point(750, 250);
        btnCell26.Name = "btnCell26";
        btnCell26.Click += btnCelClick;
        btnCell26.Size = new System.Drawing.Size(125, 125);
        btnCell26.TabIndex = 35;
        btnCell26.UseVisualStyleBackColor = false;
        // 
        // btnCell24
        // 
        btnCell24.BackColor = System.Drawing.Color.Transparent;
        btnCell24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell24.FlatAppearance.BorderSize = 0;
        btnCell24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell24.Location = new System.Drawing.Point(500, 250);
        btnCell24.Name = "btnCell24";
        btnCell24.Click += btnCelClick;
        btnCell24.Size = new System.Drawing.Size(125, 125);
        btnCell24.TabIndex = 34;
        btnCell24.UseVisualStyleBackColor = false;
        // 
        // btnCell22
        // 
        btnCell22.BackColor = System.Drawing.Color.Transparent;
        btnCell22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell22.FlatAppearance.BorderSize = 0;
        btnCell22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell22.Location = new System.Drawing.Point(250, 250);
        btnCell22.Name = "btnCell22";
        btnCell22.Click += btnCelClick;
        btnCell22.Size = new System.Drawing.Size(125, 125);
        btnCell22.TabIndex = 33;
        btnCell22.UseVisualStyleBackColor = false;
        // 
        // btnCell20
        // 
        btnCell20.BackColor = System.Drawing.Color.Transparent;
        btnCell20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell20.FlatAppearance.BorderSize = 0;
        btnCell20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell20.Location = new System.Drawing.Point(0, 250);
        btnCell20.Name = "btnCell20";
        btnCell20.Click += btnCelClick;
        btnCell20.Size = new System.Drawing.Size(125, 125);
        btnCell20.TabIndex = 32;
        btnCell20.UseVisualStyleBackColor = false;
        // 
        // btnCell17
        // 
        btnCell17.BackColor = System.Drawing.Color.Transparent;
        btnCell17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell17.FlatAppearance.BorderSize = 0;
        btnCell17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell17.Location = new System.Drawing.Point(875, 125);
        btnCell17.Name = "btnCell17";
        btnCell17.Click += btnCelClick;
        btnCell17.Size = new System.Drawing.Size(125, 125);
        btnCell17.TabIndex = 31;
        btnCell17.UseVisualStyleBackColor = false;
        // 
        // btnCell15
        // 
        btnCell15.BackColor = System.Drawing.Color.Transparent;
        btnCell15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell15.FlatAppearance.BorderSize = 0;
        btnCell15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell15.Location = new System.Drawing.Point(625, 125);
        btnCell15.Name = "btnCell15";
        btnCell15.Click += btnCelClick;
        btnCell15.Size = new System.Drawing.Size(125, 125);
        btnCell15.TabIndex = 30;
        btnCell15.UseVisualStyleBackColor = false;
        // 
        // btnCell13
        // 
        btnCell13.BackColor = System.Drawing.Color.Transparent;
        btnCell13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell13.FlatAppearance.BorderSize = 0;
        btnCell13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell13.Location = new System.Drawing.Point(375, 125);
        btnCell13.Name = "btnCell13";
        btnCell13.Click += btnCelClick;
        btnCell13.Size = new System.Drawing.Size(125, 125);
        btnCell13.TabIndex = 29;
        btnCell13.UseVisualStyleBackColor = false;
        // 
        // btnCell11
        // 
        btnCell11.BackColor = System.Drawing.Color.Transparent;
        btnCell11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell11.FlatAppearance.BorderSize = 0;
        btnCell11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell11.Location = new System.Drawing.Point(125, 125);
        btnCell11.Name = "btnCell11";
        btnCell11.Click += btnCelClick;
        btnCell11.Size = new System.Drawing.Size(125, 125);
        btnCell11.TabIndex = 28;
        btnCell11.UseVisualStyleBackColor = false;
        // 
        // btnCell06
        // 
        btnCell06.BackColor = System.Drawing.Color.Transparent;
        btnCell06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell06.FlatAppearance.BorderSize = 0;
        btnCell06.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell06.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell06.Location = new System.Drawing.Point(750, 0);
        btnCell06.Name = "btnCell06";
        btnCell06.Click += btnCelClick;
        btnCell06.Size = new System.Drawing.Size(125, 125);
        btnCell06.TabIndex = 27;
        btnCell06.UseVisualStyleBackColor = false;
        // 
        // btnCell04
        // 
        btnCell04.BackColor = System.Drawing.Color.Transparent;
        btnCell04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell04.FlatAppearance.BorderSize = 0;
        btnCell04.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell04.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell04.Location = new System.Drawing.Point(500, 0);
        btnCell04.Name = "btnCell04";
        btnCell04.Click += btnCelClick;
        btnCell04.Size = new System.Drawing.Size(125, 125);
        btnCell04.TabIndex = 26;
        btnCell04.UseVisualStyleBackColor = false;
        // 
        // btnCell02
        // 
        btnCell02.BackColor = System.Drawing.Color.Transparent;
        btnCell02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell02.FlatAppearance.BorderSize = 0;
        btnCell02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell02.Location = new System.Drawing.Point(250, 0);
        btnCell02.Name = "btnCell02";
        btnCell02.Click += btnCelClick;
        btnCell02.Size = new System.Drawing.Size(125, 125);
        btnCell02.TabIndex = 25;
        btnCell02.UseVisualStyleBackColor = false;
        // 
        // btnCell00
        // 
        btnCell00.BackColor = System.Drawing.Color.Transparent;
        btnCell00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell00.FlatAppearance.BorderSize = 0;
        btnCell00.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell00.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell00.Location = new System.Drawing.Point(0, 0);
        btnCell00.Name = "btnCell00";
        btnCell00.Size = new System.Drawing.Size(125, 125);
        btnCell00.TabIndex = 24;
        btnCell00.UseVisualStyleBackColor = false;
        btnCell00.Click += btnCelClick;
        // 
        // btnCell07
        // 
        btnCell07.BackColor = System.Drawing.Color.Transparent;
        btnCell07.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell07.BackgroundImage"));
        btnCell07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell07.FlatAppearance.BorderSize = 0;
        btnCell07.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell07.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell07.Location = new System.Drawing.Point(875, 0);
        btnCell07.Name = "btnCell07";
        btnCell07.Size = new System.Drawing.Size(125, 125);
        btnCell07.TabIndex = 23;
        btnCell07.UseVisualStyleBackColor = false;
        btnCell07.Click += btnCelClick;
        // 
        // btnCell27
        // 
        btnCell27.BackColor = System.Drawing.Color.Transparent;
        btnCell27.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell27.BackgroundImage"));
        btnCell27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell27.FlatAppearance.BorderSize = 0;
        btnCell27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell27.Location = new System.Drawing.Point(875, 250);
        btnCell27.Name = "btnCell27";
        btnCell27.Click += btnCelClick;
        btnCell27.Size = new System.Drawing.Size(125, 125);
        btnCell27.TabIndex = 22;
        btnCell27.UseVisualStyleBackColor = false;
        // 
        // btnCell16
        // 
        btnCell16.BackColor = System.Drawing.Color.Transparent;
        btnCell16.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell16.BackgroundImage"));
        btnCell16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell16.FlatAppearance.BorderSize = 0;
        btnCell16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell16.Location = new System.Drawing.Point(750, 125);
        btnCell16.Name = "btnCell16";
        btnCell16.Click += btnCelClick;
        btnCell16.Size = new System.Drawing.Size(125, 125);
        btnCell16.TabIndex = 21;
        btnCell16.UseVisualStyleBackColor = false;
        // 
        // btnCell25
        // 
        btnCell25.BackColor = System.Drawing.Color.Transparent;
        btnCell25.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell25.BackgroundImage"));
        btnCell25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell25.FlatAppearance.BorderSize = 0;
        btnCell25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell25.Location = new System.Drawing.Point(625, 250);
        btnCell25.Name = "btnCell25";
        btnCell25.Click += btnCelClick;
        btnCell25.Size = new System.Drawing.Size(125, 125);
        btnCell25.TabIndex = 20;
        btnCell25.UseVisualStyleBackColor = false;
        // 
        // btnCell05
        // 
        btnCell05.BackColor = System.Drawing.Color.Transparent;
        btnCell05.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell05.BackgroundImage"));
        btnCell05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell05.FlatAppearance.BorderSize = 0;
        btnCell05.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell05.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell05.Location = new System.Drawing.Point(625, 0);
        btnCell05.Name = "btnCell05";
        btnCell05.Click += btnCelClick;
        btnCell05.Size = new System.Drawing.Size(125, 125);
        btnCell05.TabIndex = 19;
        btnCell05.UseVisualStyleBackColor = false;
        // 
        // btnCell14
        // 
        btnCell14.BackColor = System.Drawing.Color.Transparent;
        btnCell14.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell14.BackgroundImage"));
        btnCell14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell14.FlatAppearance.BorderSize = 0;
        btnCell14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell14.Location = new System.Drawing.Point(500, 125);
        btnCell14.Name = "btnCell14";
        btnCell14.Click += btnCelClick;
        btnCell14.Size = new System.Drawing.Size(125, 125);
        btnCell14.TabIndex = 18;
        btnCell14.UseVisualStyleBackColor = false;
        // 
        // btnCell23
        // 
        btnCell23.BackColor = System.Drawing.Color.Transparent;
        btnCell23.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell23.BackgroundImage"));
        btnCell23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell23.FlatAppearance.BorderSize = 0;
        btnCell23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell23.Location = new System.Drawing.Point(375, 250);
        btnCell23.Name = "btnCell23";
        btnCell23.Click += btnCelClick;
        btnCell23.Size = new System.Drawing.Size(125, 125);
        btnCell23.TabIndex = 17;
        btnCell23.UseVisualStyleBackColor = false;
        // 
        // btnCell03
        // 
        btnCell03.BackColor = System.Drawing.Color.Transparent;
        btnCell03.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell03.BackgroundImage"));
        btnCell03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell03.FlatAppearance.BorderSize = 0;
        btnCell03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell03.Location = new System.Drawing.Point(375, 0);
        btnCell03.Name = "btnCell03";
        btnCell03.Click += btnCelClick;
        btnCell03.Size = new System.Drawing.Size(125, 125);
        btnCell03.TabIndex = 16;
        btnCell03.UseVisualStyleBackColor = false;
        // 
        // btnCell12
        // 
        btnCell12.BackColor = System.Drawing.Color.Transparent;
        btnCell12.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell12.BackgroundImage"));
        btnCell12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell12.FlatAppearance.BorderSize = 0;
        btnCell12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell12.Location = new System.Drawing.Point(250, 125);
        btnCell12.Name = "btnCell12";
        btnCell12.Click += btnCelClick;
        btnCell12.Size = new System.Drawing.Size(125, 125);
        btnCell12.TabIndex = 15;
        btnCell12.UseVisualStyleBackColor = false;
        // 
        // btnCell01
        // 
        btnCell01.BackColor = System.Drawing.Color.Transparent;
        btnCell01.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell01.BackgroundImage"));
        btnCell01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell01.FlatAppearance.BorderSize = 0;
        btnCell01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell01.Location = new System.Drawing.Point(125, 0);
        btnCell01.Name = "btnCell01";
        btnCell01.Click += btnCelClick;
        btnCell01.Size = new System.Drawing.Size(125, 125);
        btnCell01.TabIndex = 14;
        btnCell01.UseVisualStyleBackColor = false;
        // 
        // btnCell21
        // 
        btnCell21.BackColor = System.Drawing.Color.Transparent;
        btnCell21.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell21.BackgroundImage"));
        btnCell21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell21.FlatAppearance.BorderSize = 0;
        btnCell21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell21.Location = new System.Drawing.Point(125, 250);
        btnCell21.Name = "btnCell21";
        btnCell21.Click += btnCelClick;
        btnCell21.Size = new System.Drawing.Size(125, 125);
        btnCell21.TabIndex = 13;
        btnCell21.UseVisualStyleBackColor = false;
        // 
        // btnCell56
        // 
        btnCell56.BackColor = System.Drawing.Color.Transparent;
        btnCell56.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell56.BackgroundImage"));
        btnCell56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell56.FlatAppearance.BorderSize = 0;
        btnCell56.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell56.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell56.Location = new System.Drawing.Point(750, 625);
        btnCell56.Name = "btnCell56";
        btnCell56.Click += btnCelClick;
        btnCell56.Size = new System.Drawing.Size(125, 125);
        btnCell56.TabIndex = 12;
        btnCell56.UseVisualStyleBackColor = false;
        // 
        // btnCell54
        // 
        btnCell54.BackColor = System.Drawing.Color.Transparent;
        btnCell54.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell54.BackgroundImage"));
        btnCell54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell54.FlatAppearance.BorderSize = 0;
        btnCell54.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell54.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell54.Location = new System.Drawing.Point(500, 625);
        btnCell54.Name = "btnCell54";
        btnCell54.Click += btnCelClick;
        btnCell54.Size = new System.Drawing.Size(125, 125);
        btnCell54.TabIndex = 11;
        btnCell54.UseVisualStyleBackColor = false;
        // 
        // btnCell52
        // 
        btnCell52.BackColor = System.Drawing.Color.Transparent;
        btnCell52.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell52.BackgroundImage"));
        btnCell52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell52.FlatAppearance.BorderSize = 0;
        btnCell52.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell52.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell52.Location = new System.Drawing.Point(250, 625);
        btnCell52.Name = "btnCell52";
        btnCell52.Click += btnCelClick;
        btnCell52.Size = new System.Drawing.Size(125, 125);
        btnCell52.TabIndex = 10;
        btnCell52.UseVisualStyleBackColor = false;
        // 
        // btnCell50
        // 
        btnCell50.BackColor = System.Drawing.Color.Transparent;
        btnCell50.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell50.BackgroundImage"));
        btnCell50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell50.FlatAppearance.BorderSize = 0;
        btnCell50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell50.Location = new System.Drawing.Point(0, 625);
        btnCell50.Name = "btnCell50";
        btnCell50.Click += btnCelClick;
        btnCell50.Size = new System.Drawing.Size(125, 125);
        btnCell50.TabIndex = 9;
        btnCell50.UseVisualStyleBackColor = false;
        // 
        // btnCell67
        // 
        btnCell67.BackColor = System.Drawing.Color.Transparent;
        btnCell67.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell67.BackgroundImage"));
        btnCell67.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell67.FlatAppearance.BorderSize = 0;
        btnCell67.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell67.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell67.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell67.Location = new System.Drawing.Point(875, 750);
        btnCell67.Name = "btnCell67";
        btnCell67.Click += btnCelClick;
        btnCell67.Size = new System.Drawing.Size(125, 125);
        btnCell67.TabIndex = 8;
        btnCell67.UseVisualStyleBackColor = false;
        // 
        // btnCell76
        // 
        btnCell76.BackColor = System.Drawing.Color.Transparent;
        btnCell76.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell76.BackgroundImage"));
        btnCell76.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell76.FlatAppearance.BorderSize = 0;
        btnCell76.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell76.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell76.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell76.Location = new System.Drawing.Point(750, 875);
        btnCell76.Name = "btnCell76";
        btnCell76.Click += btnCelClick;
        btnCell76.Size = new System.Drawing.Size(125, 125);
        btnCell76.TabIndex = 7;
        btnCell76.UseVisualStyleBackColor = false;
        // 
        // btnCell65
        // 
        btnCell65.BackColor = System.Drawing.Color.Transparent;
        btnCell65.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell65.BackgroundImage"));
        btnCell65.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell65.FlatAppearance.BorderSize = 0;
        btnCell65.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell65.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell65.Location = new System.Drawing.Point(625, 750);
        btnCell65.Name = "btnCell65";
        btnCell65.Click += btnCelClick;
        btnCell65.Size = new System.Drawing.Size(125, 125);
        btnCell65.TabIndex = 6;
        btnCell65.UseVisualStyleBackColor = false;
        // 
        // btnCell74
        // 
        btnCell74.BackColor = System.Drawing.Color.Transparent;
        btnCell74.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell74.BackgroundImage"));
        btnCell74.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell74.FlatAppearance.BorderSize = 0;
        btnCell74.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell74.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell74.Location = new System.Drawing.Point(500, 875);
        btnCell74.Name = "btnCell74";
        btnCell74.Click += btnCelClick;
        btnCell74.Size = new System.Drawing.Size(125, 125);
        btnCell74.TabIndex = 5;
        btnCell74.UseVisualStyleBackColor = false;
        // 
        // btnCell63
        // 
        btnCell63.BackColor = System.Drawing.Color.Transparent;
        btnCell63.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell63.BackgroundImage"));
        btnCell63.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell63.FlatAppearance.BorderSize = 0;
        btnCell63.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell63.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell63.Location = new System.Drawing.Point(375, 750);
        btnCell63.Name = "btnCell63";
        btnCell63.Click += btnCelClick;
        btnCell63.Size = new System.Drawing.Size(125, 125);
        btnCell63.TabIndex = 4;
        btnCell63.UseVisualStyleBackColor = false;
        // 
        // btnCell72
        // 
        btnCell72.BackColor = System.Drawing.Color.Transparent;
        btnCell72.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell72.BackgroundImage"));
        btnCell72.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell72.FlatAppearance.BorderSize = 0;
        btnCell72.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell72.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell72.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell72.Location = new System.Drawing.Point(250, 875);
        btnCell72.Name = "btnCell72";
        btnCell72.Click += btnCelClick;
        btnCell72.Size = new System.Drawing.Size(125, 125);
        btnCell72.TabIndex = 3;
        btnCell72.UseVisualStyleBackColor = false;
        // 
        // btnCell61
        // 
        btnCell61.BackColor = System.Drawing.Color.Transparent;
        btnCell61.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell61.BackgroundImage"));
        btnCell61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell61.FlatAppearance.BorderSize = 0;
        btnCell61.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell61.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell61.Location = new System.Drawing.Point(125, 750);
        btnCell61.Name = "btnCell61";
        btnCell61.Click += btnCelClick;
        btnCell61.Size = new System.Drawing.Size(125, 125);
        btnCell61.TabIndex = 2;
        btnCell61.UseVisualStyleBackColor = false;
        // 
        // btnCell10
        // 
        btnCell10.BackColor = System.Drawing.Color.Transparent;
        btnCell10.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell10.BackgroundImage"));
        btnCell10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell10.FlatAppearance.BorderSize = 0;
        btnCell10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell10.Location = new System.Drawing.Point(0, 125);
        btnCell10.Name = "btnCell10";
        btnCell10.Click += btnCelClick;
        btnCell10.Size = new System.Drawing.Size(125, 125);
        btnCell10.TabIndex = 0;
        btnCell10.UseVisualStyleBackColor = false;
        // 
        // btnCell70
        // 
        btnCell70.BackColor = System.Drawing.Color.Transparent;
        btnCell70.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnCell70.BackgroundImage"));
        btnCell70.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        btnCell70.FlatAppearance.BorderSize = 0;
        btnCell70.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)160)), ((int)((byte)195)), ((int)((byte)225)));
        btnCell70.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)220)), ((int)((byte)245)));
        btnCell70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCell70.Location = new System.Drawing.Point(0, 875);
        btnCell70.Name = "btnCell70";
        btnCell70.Click += btnCelClick;
        btnCell70.Size = new System.Drawing.Size(125, 125);
        btnCell70.TabIndex = 1;
        btnCell70.UseVisualStyleBackColor = false;
        // 
        // Form1
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        ClientSize = new System.Drawing.Size(1531, 1075);
        Controls.Add(pnlBoard);
        Controls.Add(lblHint);
        Controls.Add(grpGame);
        Controls.Add(grpConnection);
        Controls.Add(lblMyColor);
        Controls.Add(lblConnectionStatus);
        Text = "Русские шашки";
        FormClosed += GameForm_FormClosed;
        grpConnection.ResumeLayout(false);
        grpConnection.PerformLayout();
        grpGame.ResumeLayout(false);
        pnlBoard.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnCell37;
    private System.Windows.Forms.Button btnCell41;
    private System.Windows.Forms.Button btnCell42;
    private System.Windows.Forms.Button btnCell43;
    private System.Windows.Forms.Button btnCell44;
    private System.Windows.Forms.Button btnCell45;
    private System.Windows.Forms.Button btnCell46;
    private System.Windows.Forms.Button btnCell47;
    private System.Windows.Forms.Button btnCell51;
    private System.Windows.Forms.Button btnCell53;
    private System.Windows.Forms.Button btnCell55;
    private System.Windows.Forms.Button btnCell57;
    private System.Windows.Forms.Button btnCell60;
    private System.Windows.Forms.Button btnCell62;
    private System.Windows.Forms.Button btnCell64;
    private System.Windows.Forms.Button btnCell66;
    private System.Windows.Forms.Button btnCell71;
    private System.Windows.Forms.Button btnCell73;
    private System.Windows.Forms.Button btnCell75;
    private System.Windows.Forms.Button btnCell77;

    private System.Windows.Forms.Button btnCell02;
    private System.Windows.Forms.Button btnCell04;
    private System.Windows.Forms.Button btnCell06;
    private System.Windows.Forms.Button btnCell11;
    private System.Windows.Forms.Button btnCell13;
    private System.Windows.Forms.Button btnCell15;
    private System.Windows.Forms.Button btnCell17;
    private System.Windows.Forms.Button btnCell20;
    private System.Windows.Forms.Button btnCell22;
    private System.Windows.Forms.Button btnCell24;
    private System.Windows.Forms.Button btnCell26;
    private System.Windows.Forms.Button btnCell30;
    private System.Windows.Forms.Button btnCell31;
    private System.Windows.Forms.Button btnCell32;
    private System.Windows.Forms.Button btnCell33;
    private System.Windows.Forms.Button btnCell34;
    private System.Windows.Forms.Button btnCell40;
    private System.Windows.Forms.Button btnCell35;
    private System.Windows.Forms.Button btnCell36;

    private System.Windows.Forms.Button btnCell61;
    private System.Windows.Forms.Button btnCell72;
    private System.Windows.Forms.Button btnCell63;
    private System.Windows.Forms.Button btnCell74;
    private System.Windows.Forms.Button btnCell65;
    private System.Windows.Forms.Button btnCell76;
    private System.Windows.Forms.Button btnCell67;
    private System.Windows.Forms.Button btnCell50;
    private System.Windows.Forms.Button btnCell52;
    private System.Windows.Forms.Button btnCell54;
    private System.Windows.Forms.Button btnCell56;
    private System.Windows.Forms.Button btnCell21;
    private System.Windows.Forms.Button btnCell01;
    private System.Windows.Forms.Button btnCell12;
    private System.Windows.Forms.Button btnCell03;
    private System.Windows.Forms.Button btnCell23;
    private System.Windows.Forms.Button btnCell14;
    private System.Windows.Forms.Button btnCell05;
    private System.Windows.Forms.Button btnCell25;
    private System.Windows.Forms.Button btnCell16;
    private System.Windows.Forms.Button btnCell27;
    private System.Windows.Forms.Button btnCell07;
    private System.Windows.Forms.Button btnCell00;

    private System.Windows.Forms.Button btnCell10;
    private System.Windows.Forms.Button btnCell70;

    internal System.Windows.Forms.Panel pnlBoard;

    private System.Windows.Forms.GroupBox grpGame;
    internal System.Windows.Forms.Label lblWhiteCount;
    internal System.Windows.Forms.Label lblTurn;
    internal System.Windows.Forms.Label lblBlackCount;
    internal System.Windows.Forms.Label lblHint;

    internal System.Windows.Forms.Label lblConnectionStatus;
    internal System.Windows.Forms.Label lblMyColor;
    private System.Windows.Forms.Label lblServerIp;
    private System.Windows.Forms.Label lblPort;
    internal System.Windows.Forms.TextBox txtServerIp;
    internal System.Windows.Forms.TextBox txtPort;
    private System.Windows.Forms.GroupBox grpConnection;
    internal System.Windows.Forms.Button btnHost;
    internal System.Windows.Forms.Button btnConnect;
    internal System.Windows.Forms.Button btnDisconnect;

    #endregion
}
