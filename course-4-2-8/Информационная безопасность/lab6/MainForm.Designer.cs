#nullable disable

namespace Lab6;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor
    /// </summary>
    private void InitializeComponent()
    {
        tabMain = new System.Windows.Forms.TabControl();
        tabRsa = new System.Windows.Forms.TabPage();
        grpRsaPrimeGeneration = new System.Windows.Forms.GroupBox();
        lblRsaBitCount = new System.Windows.Forms.Label();
        nudRsaBitCount = new System.Windows.Forms.NumericUpDown();
        btnRsaGeneratePrimes = new System.Windows.Forms.Button();
        btnRsaLoadPrimes = new System.Windows.Forms.Button();
        btnRsaCalculateKeys = new System.Windows.Forms.Button();
        lblRsaFirstPrime = new System.Windows.Forms.Label();
        txtRsaFirstPrime = new System.Windows.Forms.TextBox();
        lblRsaSecondPrime = new System.Windows.Forms.Label();
        txtRsaSecondPrime = new System.Windows.Forms.TextBox();
        lblRsaPublicExponent = new System.Windows.Forms.Label();
        txtRsaPublicExponent = new System.Windows.Forms.TextBox();
        lblRsaModulus = new System.Windows.Forms.Label();
        txtRsaModulus = new System.Windows.Forms.TextBox();
        lblRsaPrivateExponent = new System.Windows.Forms.Label();
        txtRsaPrivateExponent = new System.Windows.Forms.TextBox();
        grpRsaKeyFiles = new System.Windows.Forms.GroupBox();
        btnRsaSavePublicKey = new System.Windows.Forms.Button();
        btnRsaLoadPublicKey = new System.Windows.Forms.Button();
        btnRsaSavePrivateKey = new System.Windows.Forms.Button();
        btnRsaLoadPrivateKey = new System.Windows.Forms.Button();
        grpRsaDemo = new System.Windows.Forms.GroupBox();
        lblRsaMessage = new System.Windows.Forms.Label();
        txtRsaMessage = new System.Windows.Forms.TextBox();
        lblRsaEncryptedMessage = new System.Windows.Forms.Label();
        txtRsaEncryptedMessage = new System.Windows.Forms.TextBox();
        lblRsaRestoredMessage = new System.Windows.Forms.Label();
        txtRsaRestoredMessage = new System.Windows.Forms.TextBox();
        btnRsaEncrypt = new System.Windows.Forms.Button();
        btnRsaDecrypt = new System.Windows.Forms.Button();
        tabAes = new System.Windows.Forms.TabPage();
        grpAesParameters = new System.Windows.Forms.GroupBox();
        lblAesKey = new System.Windows.Forms.Label();
        txtAesKey = new System.Windows.Forms.TextBox();
        btnAesGenerateKey = new System.Windows.Forms.Button();
        lblAesIv = new System.Windows.Forms.Label();
        txtAesIv = new System.Windows.Forms.TextBox();
        btnAesGenerateIv = new System.Windows.Forms.Button();
        grpAesOperation = new System.Windows.Forms.GroupBox();
        lblAesPlaintext = new System.Windows.Forms.Label();
        txtAesPlaintext = new System.Windows.Forms.TextBox();
        btnAesEncrypt = new System.Windows.Forms.Button();
        btnAesDecrypt = new System.Windows.Forms.Button();
        lblAesCiphertext = new System.Windows.Forms.Label();
        txtAesCiphertext = new System.Windows.Forms.TextBox();
        lblAesRestoredText = new System.Windows.Forms.Label();
        txtAesRestoredText = new System.Windows.Forms.TextBox();
        tabHybrid = new System.Windows.Forms.TabPage();
        grpHybridParameters = new System.Windows.Forms.GroupBox();
        lblHybridAesKey = new System.Windows.Forms.Label();
        txtHybridAesKey = new System.Windows.Forms.TextBox();
        btnHybridGenerateAesKey = new System.Windows.Forms.Button();
        grpHybridOperation = new System.Windows.Forms.GroupBox();
        lblHybridPlaintext = new System.Windows.Forms.Label();
        txtHybridPlaintext = new System.Windows.Forms.TextBox();
        btnHybridEncrypt = new System.Windows.Forms.Button();
        btnHybridSaveEncrypted = new System.Windows.Forms.Button();
        btnHybridOpenEncrypted = new System.Windows.Forms.Button();
        btnHybridDecrypt = new System.Windows.Forms.Button();
        btnHybridSaveRestored = new System.Windows.Forms.Button();
        lblHybridRestoredText = new System.Windows.Forms.Label();
        txtHybridRestoredText = new System.Windows.Forms.TextBox();
        tabMain.SuspendLayout();
        tabRsa.SuspendLayout();
        grpRsaPrimeGeneration.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudRsaBitCount).BeginInit();
        grpRsaKeyFiles.SuspendLayout();
        grpRsaDemo.SuspendLayout();
        tabAes.SuspendLayout();
        grpAesParameters.SuspendLayout();
        grpAesOperation.SuspendLayout();
        tabHybrid.SuspendLayout();
        grpHybridParameters.SuspendLayout();
        grpHybridOperation.SuspendLayout();
        SuspendLayout();
        // 
        // tabMain
        // 
        tabMain.Controls.Add(tabRsa);
        tabMain.Controls.Add(tabAes);
        tabMain.Controls.Add(tabHybrid);
        tabMain.Location = new System.Drawing.Point(12, 12);
        tabMain.Name = "tabMain";
        tabMain.Padding = new System.Drawing.Point(14, 6);
        tabMain.SelectedIndex = 0;
        tabMain.Size = new System.Drawing.Size(1223, 878);
        tabMain.TabIndex = 0;
        // 
        // tabRsa
        // 
        tabRsa.Controls.Add(grpRsaPrimeGeneration);
        tabRsa.Controls.Add(grpRsaKeyFiles);
        tabRsa.Controls.Add(grpRsaDemo);
        tabRsa.Location = new System.Drawing.Point(8, 50);
        tabRsa.Name = "tabRsa";
        tabRsa.Padding = new System.Windows.Forms.Padding(3);
        tabRsa.Size = new System.Drawing.Size(1207, 820);
        tabRsa.TabIndex = 0;
        tabRsa.Text = "RSA";
        tabRsa.UseVisualStyleBackColor = true;
        // 
        // grpRsaPrimeGeneration
        // 
        grpRsaPrimeGeneration.Controls.Add(lblRsaBitCount);
        grpRsaPrimeGeneration.Controls.Add(nudRsaBitCount);
        grpRsaPrimeGeneration.Controls.Add(btnRsaGeneratePrimes);
        grpRsaPrimeGeneration.Controls.Add(btnRsaLoadPrimes);
        grpRsaPrimeGeneration.Controls.Add(btnRsaCalculateKeys);
        grpRsaPrimeGeneration.Controls.Add(lblRsaFirstPrime);
        grpRsaPrimeGeneration.Controls.Add(txtRsaFirstPrime);
        grpRsaPrimeGeneration.Controls.Add(lblRsaSecondPrime);
        grpRsaPrimeGeneration.Controls.Add(txtRsaSecondPrime);
        grpRsaPrimeGeneration.Controls.Add(lblRsaPublicExponent);
        grpRsaPrimeGeneration.Controls.Add(txtRsaPublicExponent);
        grpRsaPrimeGeneration.Controls.Add(lblRsaModulus);
        grpRsaPrimeGeneration.Controls.Add(txtRsaModulus);
        grpRsaPrimeGeneration.Controls.Add(lblRsaPrivateExponent);
        grpRsaPrimeGeneration.Controls.Add(txtRsaPrivateExponent);
        grpRsaPrimeGeneration.Location = new System.Drawing.Point(16, 16);
        grpRsaPrimeGeneration.Name = "grpRsaPrimeGeneration";
        grpRsaPrimeGeneration.Size = new System.Drawing.Size(1175, 300);
        grpRsaPrimeGeneration.TabIndex = 0;
        grpRsaPrimeGeneration.TabStop = false;
        grpRsaPrimeGeneration.Text = "Формирование ключей RSA";
        // 
        // lblRsaBitCount
        // 
        lblRsaBitCount.AutoSize = true;
        lblRsaBitCount.Location = new System.Drawing.Point(24, 45);
        lblRsaBitCount.Name = "lblRsaBitCount";
        lblRsaBitCount.Size = new System.Drawing.Size(150, 32);
        lblRsaBitCount.TabIndex = 0;
        lblRsaBitCount.Text = "Разрядность";
        // 
        // nudRsaBitCount
        // 
        nudRsaBitCount.Location = new System.Drawing.Point(175, 40);
        nudRsaBitCount.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
        nudRsaBitCount.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
        nudRsaBitCount.Name = "nudRsaBitCount";
        nudRsaBitCount.Size = new System.Drawing.Size(120, 39);
        nudRsaBitCount.TabIndex = 1;
        nudRsaBitCount.Value = new decimal(new int[] { 80, 0, 0, 0 });
        // 
        // btnRsaGeneratePrimes
        // 
        btnRsaGeneratePrimes.Location = new System.Drawing.Point(325, 35);
        btnRsaGeneratePrimes.Name = "btnRsaGeneratePrimes";
        btnRsaGeneratePrimes.Size = new System.Drawing.Size(263, 48);
        btnRsaGeneratePrimes.TabIndex = 2;
        btnRsaGeneratePrimes.Text = "Сгенерировать p и q";
        btnRsaGeneratePrimes.UseVisualStyleBackColor = true;
        btnRsaGeneratePrimes.Click += BtnRsaGeneratePrimes_Click;
        // 
        // btnRsaLoadPrimes
        // 
        btnRsaLoadPrimes.Location = new System.Drawing.Point(610, 37);
        btnRsaLoadPrimes.Name = "btnRsaLoadPrimes";
        btnRsaLoadPrimes.Size = new System.Drawing.Size(235, 48);
        btnRsaLoadPrimes.TabIndex = 3;
        btnRsaLoadPrimes.Text = "Загрузить p и q";
        btnRsaLoadPrimes.UseVisualStyleBackColor = true;
        btnRsaLoadPrimes.Click += BtnRsaLoadPrimes_Click;
        // 
        // btnRsaCalculateKeys
        // 
        btnRsaCalculateKeys.Location = new System.Drawing.Point(878, 34);
        btnRsaCalculateKeys.Name = "btnRsaCalculateKeys";
        btnRsaCalculateKeys.Size = new System.Drawing.Size(250, 48);
        btnRsaCalculateKeys.TabIndex = 4;
        btnRsaCalculateKeys.Text = "Рассчитать ключи";
        btnRsaCalculateKeys.UseVisualStyleBackColor = true;
        btnRsaCalculateKeys.Click += BtnRsaCalculateKeys_Click;
        // 
        // lblRsaFirstPrime
        // 
        lblRsaFirstPrime.AutoSize = true;
        lblRsaFirstPrime.Location = new System.Drawing.Point(24, 112);
        lblRsaFirstPrime.Name = "lblRsaFirstPrime";
        lblRsaFirstPrime.Size = new System.Drawing.Size(28, 32);
        lblRsaFirstPrime.TabIndex = 5;
        lblRsaFirstPrime.Text = "p";
        // 
        // txtRsaFirstPrime
        // 
        txtRsaFirstPrime.Location = new System.Drawing.Point(70, 107);
        txtRsaFirstPrime.Name = "txtRsaFirstPrime";
        txtRsaFirstPrime.Size = new System.Drawing.Size(500, 39);
        txtRsaFirstPrime.TabIndex = 6;
        txtRsaFirstPrime.Text = "61";
        // 
        // lblRsaSecondPrime
        // 
        lblRsaSecondPrime.AutoSize = true;
        lblRsaSecondPrime.Location = new System.Drawing.Point(610, 112);
        lblRsaSecondPrime.Name = "lblRsaSecondPrime";
        lblRsaSecondPrime.Size = new System.Drawing.Size(28, 32);
        lblRsaSecondPrime.TabIndex = 7;
        lblRsaSecondPrime.Text = "q";
        // 
        // txtRsaSecondPrime
        // 
        txtRsaSecondPrime.Location = new System.Drawing.Point(660, 107);
        txtRsaSecondPrime.Name = "txtRsaSecondPrime";
        txtRsaSecondPrime.Size = new System.Drawing.Size(490, 39);
        txtRsaSecondPrime.TabIndex = 8;
        txtRsaSecondPrime.Text = "53";
        // 
        // lblRsaPublicExponent
        // 
        lblRsaPublicExponent.AutoSize = true;
        lblRsaPublicExponent.Location = new System.Drawing.Point(24, 172);
        lblRsaPublicExponent.Name = "lblRsaPublicExponent";
        lblRsaPublicExponent.Size = new System.Drawing.Size(139, 32);
        lblRsaPublicExponent.TabIndex = 9;
        lblRsaPublicExponent.Text = "Открытая e";
        // 
        // txtRsaPublicExponent
        // 
        txtRsaPublicExponent.Location = new System.Drawing.Point(210, 167);
        txtRsaPublicExponent.Name = "txtRsaPublicExponent";
        txtRsaPublicExponent.Size = new System.Drawing.Size(360, 39);
        txtRsaPublicExponent.TabIndex = 10;
        txtRsaPublicExponent.Text = "17";
        // 
        // lblRsaModulus
        // 
        lblRsaModulus.AutoSize = true;
        lblRsaModulus.Location = new System.Drawing.Point(610, 172);
        lblRsaModulus.Name = "lblRsaModulus";
        lblRsaModulus.Size = new System.Drawing.Size(28, 32);
        lblRsaModulus.TabIndex = 11;
        lblRsaModulus.Text = "n";
        // 
        // txtRsaModulus
        // 
        txtRsaModulus.Location = new System.Drawing.Point(660, 167);
        txtRsaModulus.Name = "txtRsaModulus";
        txtRsaModulus.ReadOnly = true;
        txtRsaModulus.Size = new System.Drawing.Size(490, 39);
        txtRsaModulus.TabIndex = 12;
        txtRsaModulus.Text = "3233";
        // 
        // lblRsaPrivateExponent
        // 
        lblRsaPrivateExponent.AutoSize = true;
        lblRsaPrivateExponent.Location = new System.Drawing.Point(24, 232);
        lblRsaPrivateExponent.Name = "lblRsaPrivateExponent";
        lblRsaPrivateExponent.Size = new System.Drawing.Size(137, 32);
        lblRsaPrivateExponent.TabIndex = 13;
        lblRsaPrivateExponent.Text = "Закрытая d";
        // 
        // txtRsaPrivateExponent
        // 
        txtRsaPrivateExponent.Location = new System.Drawing.Point(210, 227);
        txtRsaPrivateExponent.Name = "txtRsaPrivateExponent";
        txtRsaPrivateExponent.ReadOnly = true;
        txtRsaPrivateExponent.Size = new System.Drawing.Size(940, 39);
        txtRsaPrivateExponent.TabIndex = 14;
        txtRsaPrivateExponent.Text = "2753";
        // 
        // grpRsaKeyFiles
        // 
        grpRsaKeyFiles.Controls.Add(btnRsaSavePublicKey);
        grpRsaKeyFiles.Controls.Add(btnRsaLoadPublicKey);
        grpRsaKeyFiles.Controls.Add(btnRsaSavePrivateKey);
        grpRsaKeyFiles.Controls.Add(btnRsaLoadPrivateKey);
        grpRsaKeyFiles.Location = new System.Drawing.Point(16, 330);
        grpRsaKeyFiles.Name = "grpRsaKeyFiles";
        grpRsaKeyFiles.Size = new System.Drawing.Size(1175, 120);
        grpRsaKeyFiles.TabIndex = 1;
        grpRsaKeyFiles.TabStop = false;
        grpRsaKeyFiles.Text = "Работа с ключами";
        // 
        // btnRsaSavePublicKey
        // 
        btnRsaSavePublicKey.Location = new System.Drawing.Point(24, 45);
        btnRsaSavePublicKey.Name = "btnRsaSavePublicKey";
        btnRsaSavePublicKey.Size = new System.Drawing.Size(270, 48);
        btnRsaSavePublicKey.TabIndex = 0;
        btnRsaSavePublicKey.Text = "Сохранить открытый";
        btnRsaSavePublicKey.UseVisualStyleBackColor = true;
        btnRsaSavePublicKey.Click += BtnRsaSavePublicKey_Click;
        // 
        // btnRsaLoadPublicKey
        // 
        btnRsaLoadPublicKey.Location = new System.Drawing.Point(300, 45);
        btnRsaLoadPublicKey.Name = "btnRsaLoadPublicKey";
        btnRsaLoadPublicKey.Size = new System.Drawing.Size(260, 48);
        btnRsaLoadPublicKey.TabIndex = 1;
        btnRsaLoadPublicKey.Text = "Загрузить открытый";
        btnRsaLoadPublicKey.UseVisualStyleBackColor = true;
        btnRsaLoadPublicKey.Click += BtnRsaLoadPublicKey_Click;
        // 
        // btnRsaSavePrivateKey
        // 
        btnRsaSavePrivateKey.Location = new System.Drawing.Point(576, 45);
        btnRsaSavePrivateKey.Name = "btnRsaSavePrivateKey";
        btnRsaSavePrivateKey.Size = new System.Drawing.Size(260, 48);
        btnRsaSavePrivateKey.TabIndex = 2;
        btnRsaSavePrivateKey.Text = "Сохранить закрытый";
        btnRsaSavePrivateKey.UseVisualStyleBackColor = true;
        btnRsaSavePrivateKey.Click += BtnRsaSavePrivateKey_Click;
        // 
        // btnRsaLoadPrivateKey
        // 
        btnRsaLoadPrivateKey.Location = new System.Drawing.Point(852, 45);
        btnRsaLoadPrivateKey.Name = "btnRsaLoadPrivateKey";
        btnRsaLoadPrivateKey.Size = new System.Drawing.Size(290, 48);
        btnRsaLoadPrivateKey.TabIndex = 3;
        btnRsaLoadPrivateKey.Text = "Загрузить закрытый";
        btnRsaLoadPrivateKey.UseVisualStyleBackColor = true;
        btnRsaLoadPrivateKey.Click += BtnRsaLoadPrivateKey_Click;
        // 
        // grpRsaDemo
        // 
        grpRsaDemo.Controls.Add(lblRsaMessage);
        grpRsaDemo.Controls.Add(txtRsaMessage);
        grpRsaDemo.Controls.Add(lblRsaEncryptedMessage);
        grpRsaDemo.Controls.Add(txtRsaEncryptedMessage);
        grpRsaDemo.Controls.Add(lblRsaRestoredMessage);
        grpRsaDemo.Controls.Add(txtRsaRestoredMessage);
        grpRsaDemo.Controls.Add(btnRsaEncrypt);
        grpRsaDemo.Controls.Add(btnRsaDecrypt);
        grpRsaDemo.Location = new System.Drawing.Point(16, 465);
        grpRsaDemo.Name = "grpRsaDemo";
        grpRsaDemo.Size = new System.Drawing.Size(1175, 325);
        grpRsaDemo.TabIndex = 2;
        grpRsaDemo.TabStop = false;
        grpRsaDemo.Text = "Проверка шифрования RSA";
        // 
        // lblRsaMessage
        // 
        lblRsaMessage.AutoSize = true;
        lblRsaMessage.Location = new System.Drawing.Point(24, 48);
        lblRsaMessage.Name = "lblRsaMessage";
        lblRsaMessage.Size = new System.Drawing.Size(174, 32);
        lblRsaMessage.TabIndex = 0;
        lblRsaMessage.Text = "Сообщение M";
        // 
        // txtRsaMessage
        // 
        txtRsaMessage.Location = new System.Drawing.Point(225, 43);
        txtRsaMessage.Name = "txtRsaMessage";
        txtRsaMessage.Size = new System.Drawing.Size(925, 39);
        txtRsaMessage.TabIndex = 1;
        txtRsaMessage.Text = "65";
        // 
        // lblRsaEncryptedMessage
        // 
        lblRsaEncryptedMessage.AutoSize = true;
        lblRsaEncryptedMessage.Location = new System.Drawing.Point(24, 108);
        lblRsaEncryptedMessage.Name = "lblRsaEncryptedMessage";
        lblRsaEncryptedMessage.Size = new System.Drawing.Size(173, 32);
        lblRsaEncryptedMessage.TabIndex = 2;
        lblRsaEncryptedMessage.Text = "Шифротекст C";
        // 
        // txtRsaEncryptedMessage
        // 
        txtRsaEncryptedMessage.Location = new System.Drawing.Point(225, 103);
        txtRsaEncryptedMessage.Name = "txtRsaEncryptedMessage";
        txtRsaEncryptedMessage.Size = new System.Drawing.Size(925, 39);
        txtRsaEncryptedMessage.TabIndex = 3;
        // 
        // lblRsaRestoredMessage
        // 
        lblRsaRestoredMessage.AutoSize = true;
        lblRsaRestoredMessage.Location = new System.Drawing.Point(24, 168);
        lblRsaRestoredMessage.Name = "lblRsaRestoredMessage";
        lblRsaRestoredMessage.Size = new System.Drawing.Size(155, 32);
        lblRsaRestoredMessage.TabIndex = 4;
        lblRsaRestoredMessage.Text = "Результат M\'";
        // 
        // txtRsaRestoredMessage
        // 
        txtRsaRestoredMessage.Location = new System.Drawing.Point(225, 163);
        txtRsaRestoredMessage.Name = "txtRsaRestoredMessage";
        txtRsaRestoredMessage.ReadOnly = true;
        txtRsaRestoredMessage.Size = new System.Drawing.Size(925, 39);
        txtRsaRestoredMessage.TabIndex = 5;
        // 
        // btnRsaEncrypt
        // 
        btnRsaEncrypt.Location = new System.Drawing.Point(225, 220);
        btnRsaEncrypt.Name = "btnRsaEncrypt";
        btnRsaEncrypt.Size = new System.Drawing.Size(220, 48);
        btnRsaEncrypt.TabIndex = 6;
        btnRsaEncrypt.Text = "Зашифровать";
        btnRsaEncrypt.UseVisualStyleBackColor = true;
        btnRsaEncrypt.Click += BtnRsaEncrypt_Click;
        // 
        // btnRsaDecrypt
        // 
        btnRsaDecrypt.Location = new System.Drawing.Point(465, 220);
        btnRsaDecrypt.Name = "btnRsaDecrypt";
        btnRsaDecrypt.Size = new System.Drawing.Size(220, 48);
        btnRsaDecrypt.TabIndex = 7;
        btnRsaDecrypt.Text = "Расшифровать";
        btnRsaDecrypt.UseVisualStyleBackColor = true;
        btnRsaDecrypt.Click += BtnRsaDecrypt_Click;
        // 
        // tabAes
        // 
        tabAes.Controls.Add(grpAesParameters);
        tabAes.Controls.Add(grpAesOperation);
        tabAes.Location = new System.Drawing.Point(8, 50);
        tabAes.Name = "tabAes";
        tabAes.Padding = new System.Windows.Forms.Padding(3);
        tabAes.Size = new System.Drawing.Size(1207, 820);
        tabAes.TabIndex = 1;
        tabAes.Text = "AES-128";
        tabAes.UseVisualStyleBackColor = true;
        // 
        // grpAesParameters
        // 
        grpAesParameters.Controls.Add(lblAesKey);
        grpAesParameters.Controls.Add(txtAesKey);
        grpAesParameters.Controls.Add(btnAesGenerateKey);
        grpAesParameters.Controls.Add(lblAesIv);
        grpAesParameters.Controls.Add(txtAesIv);
        grpAesParameters.Controls.Add(btnAesGenerateIv);
        grpAesParameters.Location = new System.Drawing.Point(16, 16);
        grpAesParameters.Name = "grpAesParameters";
        grpAesParameters.Size = new System.Drawing.Size(1175, 155);
        grpAesParameters.TabIndex = 0;
        grpAesParameters.TabStop = false;
        grpAesParameters.Text = "Параметры AES-128 CFB";
        // 
        // lblAesKey
        // 
        lblAesKey.AutoSize = true;
        lblAesKey.Location = new System.Drawing.Point(24, 45);
        lblAesKey.Name = "lblAesKey";
        lblAesKey.Size = new System.Drawing.Size(130, 32);
        lblAesKey.TabIndex = 0;
        lblAesKey.Text = "Ключ, HEX";
        // 
        // txtAesKey
        // 
        txtAesKey.Location = new System.Drawing.Point(180, 40);
        txtAesKey.Name = "txtAesKey";
        txtAesKey.Size = new System.Drawing.Size(700, 39);
        txtAesKey.TabIndex = 1;
        txtAesKey.Text = "2B7E151628AED2A6ABF7158809CF4F3C";
        // 
        // btnAesGenerateKey
        // 
        btnAesGenerateKey.Location = new System.Drawing.Point(900, 35);
        btnAesGenerateKey.Name = "btnAesGenerateKey";
        btnAesGenerateKey.Size = new System.Drawing.Size(269, 48);
        btnAesGenerateKey.TabIndex = 2;
        btnAesGenerateKey.Text = "Сгенерировать ключ";
        btnAesGenerateKey.UseVisualStyleBackColor = true;
        btnAesGenerateKey.Click += BtnAesGenerateKey_Click;
        // 
        // lblAesIv
        // 
        lblAesIv.AutoSize = true;
        lblAesIv.Location = new System.Drawing.Point(24, 105);
        lblAesIv.Name = "lblAesIv";
        lblAesIv.Size = new System.Drawing.Size(90, 32);
        lblAesIv.TabIndex = 3;
        lblAesIv.Text = "IV, HEX";
        // 
        // txtAesIv
        // 
        txtAesIv.Location = new System.Drawing.Point(180, 100);
        txtAesIv.Name = "txtAesIv";
        txtAesIv.Size = new System.Drawing.Size(700, 39);
        txtAesIv.TabIndex = 4;
        txtAesIv.Text = "000102030405060708090A0B0C0D0E0F";
        // 
        // btnAesGenerateIv
        // 
        btnAesGenerateIv.Location = new System.Drawing.Point(900, 95);
        btnAesGenerateIv.Name = "btnAesGenerateIv";
        btnAesGenerateIv.Size = new System.Drawing.Size(245, 48);
        btnAesGenerateIv.TabIndex = 5;
        btnAesGenerateIv.Text = "Сгенерировать IV";
        btnAesGenerateIv.UseVisualStyleBackColor = true;
        btnAesGenerateIv.Click += BtnAesGenerateIv_Click;
        // 
        // grpAesOperation
        // 
        grpAesOperation.Controls.Add(lblAesPlaintext);
        grpAesOperation.Controls.Add(txtAesPlaintext);
        grpAesOperation.Controls.Add(btnAesEncrypt);
        grpAesOperation.Controls.Add(btnAesDecrypt);
        grpAesOperation.Controls.Add(lblAesCiphertext);
        grpAesOperation.Controls.Add(txtAesCiphertext);
        grpAesOperation.Controls.Add(lblAesRestoredText);
        grpAesOperation.Controls.Add(txtAesRestoredText);
        grpAesOperation.Location = new System.Drawing.Point(16, 185);
        grpAesOperation.Name = "grpAesOperation";
        grpAesOperation.Size = new System.Drawing.Size(1175, 605);
        grpAesOperation.TabIndex = 1;
        grpAesOperation.TabStop = false;
        grpAesOperation.Text = "Шифрование текста";
        // 
        // lblAesPlaintext
        // 
        lblAesPlaintext.AutoSize = true;
        lblAesPlaintext.Location = new System.Drawing.Point(24, 42);
        lblAesPlaintext.Name = "lblAesPlaintext";
        lblAesPlaintext.Size = new System.Drawing.Size(189, 32);
        lblAesPlaintext.TabIndex = 0;
        lblAesPlaintext.Text = "Исходный текст";
        // 
        // txtAesPlaintext
        // 
        txtAesPlaintext.Location = new System.Drawing.Point(24, 75);
        txtAesPlaintext.Multiline = true;
        txtAesPlaintext.Name = "txtAesPlaintext";
        txtAesPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtAesPlaintext.Size = new System.Drawing.Size(1125, 125);
        txtAesPlaintext.TabIndex = 1;
        txtAesPlaintext.Text = "Секретные данные";
        // 
        // btnAesEncrypt
        // 
        btnAesEncrypt.Location = new System.Drawing.Point(24, 215);
        btnAesEncrypt.Name = "btnAesEncrypt";
        btnAesEncrypt.Size = new System.Drawing.Size(220, 48);
        btnAesEncrypt.TabIndex = 2;
        btnAesEncrypt.Text = "Зашифровать";
        btnAesEncrypt.UseVisualStyleBackColor = true;
        btnAesEncrypt.Click += BtnAesEncrypt_Click;
        // 
        // btnAesDecrypt
        // 
        btnAesDecrypt.Location = new System.Drawing.Point(260, 215);
        btnAesDecrypt.Name = "btnAesDecrypt";
        btnAesDecrypt.Size = new System.Drawing.Size(220, 48);
        btnAesDecrypt.TabIndex = 3;
        btnAesDecrypt.Text = "Расшифровать";
        btnAesDecrypt.UseVisualStyleBackColor = true;
        btnAesDecrypt.Click += BtnAesDecrypt_Click;
        // 
        // lblAesCiphertext
        // 
        lblAesCiphertext.AutoSize = true;
        lblAesCiphertext.Location = new System.Drawing.Point(24, 282);
        lblAesCiphertext.Name = "lblAesCiphertext";
        lblAesCiphertext.Size = new System.Drawing.Size(206, 32);
        lblAesCiphertext.TabIndex = 4;
        lblAesCiphertext.Text = "Шифротекст, HEX";
        // 
        // txtAesCiphertext
        // 
        txtAesCiphertext.Location = new System.Drawing.Point(24, 315);
        txtAesCiphertext.Multiline = true;
        txtAesCiphertext.Name = "txtAesCiphertext";
        txtAesCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtAesCiphertext.Size = new System.Drawing.Size(1125, 105);
        txtAesCiphertext.TabIndex = 5;
        // 
        // lblAesRestoredText
        // 
        lblAesRestoredText.AutoSize = true;
        lblAesRestoredText.Location = new System.Drawing.Point(24, 442);
        lblAesRestoredText.Name = "lblAesRestoredText";
        lblAesRestoredText.Size = new System.Drawing.Size(275, 32);
        lblAesRestoredText.TabIndex = 6;
        lblAesRestoredText.Text = "Восстановленный текст";
        // 
        // txtAesRestoredText
        // 
        txtAesRestoredText.Location = new System.Drawing.Point(24, 475);
        txtAesRestoredText.Multiline = true;
        txtAesRestoredText.Name = "txtAesRestoredText";
        txtAesRestoredText.ReadOnly = true;
        txtAesRestoredText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtAesRestoredText.Size = new System.Drawing.Size(1125, 100);
        txtAesRestoredText.TabIndex = 7;
        // 
        // tabHybrid
        // 
        tabHybrid.Controls.Add(grpHybridParameters);
        tabHybrid.Controls.Add(grpHybridOperation);
        tabHybrid.Location = new System.Drawing.Point(8, 50);
        tabHybrid.Name = "tabHybrid";
        tabHybrid.Padding = new System.Windows.Forms.Padding(3);
        tabHybrid.Size = new System.Drawing.Size(1207, 820);
        tabHybrid.TabIndex = 2;
        tabHybrid.Text = "Комбинированное шифрование";
        tabHybrid.UseVisualStyleBackColor = true;
        // 
        // grpHybridParameters
        // 
        grpHybridParameters.Controls.Add(lblHybridAesKey);
        grpHybridParameters.Controls.Add(txtHybridAesKey);
        grpHybridParameters.Controls.Add(btnHybridGenerateAesKey);
        grpHybridParameters.Location = new System.Drawing.Point(16, 16);
        grpHybridParameters.Name = "grpHybridParameters";
        grpHybridParameters.Size = new System.Drawing.Size(1175, 170);
        grpHybridParameters.TabIndex = 0;
        grpHybridParameters.TabStop = false;
        grpHybridParameters.Text = "Ключи алгоритмов";
        // 
        // lblHybridAesKey
        // 
        lblHybridAesKey.AutoSize = true;
        lblHybridAesKey.Location = new System.Drawing.Point(4, 78);
        lblHybridAesKey.Name = "lblHybridAesKey";
        lblHybridAesKey.Size = new System.Drawing.Size(130, 32);
        lblHybridAesKey.TabIndex = 1;
        lblHybridAesKey.Text = "Ключ, HEX";
        // 
        // txtHybridAesKey
        // 
        txtHybridAesKey.Location = new System.Drawing.Point(160, 73);
        txtHybridAesKey.Name = "txtHybridAesKey";
        txtHybridAesKey.Size = new System.Drawing.Size(700, 39);
        txtHybridAesKey.TabIndex = 2;
        txtHybridAesKey.Text = "2B7E151628AED2A6ABF7158809CF4F3C";
        // 
        // btnHybridGenerateAesKey
        // 
        btnHybridGenerateAesKey.Location = new System.Drawing.Point(880, 68);
        btnHybridGenerateAesKey.Name = "btnHybridGenerateAesKey";
        btnHybridGenerateAesKey.Size = new System.Drawing.Size(269, 48);
        btnHybridGenerateAesKey.TabIndex = 3;
        btnHybridGenerateAesKey.Text = "Сгенерировать ключ";
        btnHybridGenerateAesKey.UseVisualStyleBackColor = true;
        btnHybridGenerateAesKey.Click += BtnHybridGenerateAesKey_Click;
        // 
        // grpHybridOperation
        // 
        grpHybridOperation.Controls.Add(lblHybridPlaintext);
        grpHybridOperation.Controls.Add(txtHybridPlaintext);
        grpHybridOperation.Controls.Add(btnHybridEncrypt);
        grpHybridOperation.Controls.Add(btnHybridSaveEncrypted);
        grpHybridOperation.Controls.Add(btnHybridOpenEncrypted);
        grpHybridOperation.Controls.Add(btnHybridDecrypt);
        grpHybridOperation.Controls.Add(btnHybridSaveRestored);
        grpHybridOperation.Controls.Add(lblHybridRestoredText);
        grpHybridOperation.Controls.Add(txtHybridRestoredText);
        grpHybridOperation.Location = new System.Drawing.Point(16, 200);
        grpHybridOperation.Name = "grpHybridOperation";
        grpHybridOperation.Size = new System.Drawing.Size(1175, 590);
        grpHybridOperation.TabIndex = 1;
        grpHybridOperation.TabStop = false;
        grpHybridOperation.Text = "Шифрование";
        // 
        // lblHybridPlaintext
        // 
        lblHybridPlaintext.AutoSize = true;
        lblHybridPlaintext.Location = new System.Drawing.Point(24, 42);
        lblHybridPlaintext.Name = "lblHybridPlaintext";
        lblHybridPlaintext.Size = new System.Drawing.Size(189, 32);
        lblHybridPlaintext.TabIndex = 0;
        lblHybridPlaintext.Text = "Исходный текст";
        // 
        // txtHybridPlaintext
        // 
        txtHybridPlaintext.Location = new System.Drawing.Point(24, 75);
        txtHybridPlaintext.Multiline = true;
        txtHybridPlaintext.Name = "txtHybridPlaintext";
        txtHybridPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtHybridPlaintext.Size = new System.Drawing.Size(1125, 145);
        txtHybridPlaintext.TabIndex = 1;
        txtHybridPlaintext.Text = "Секретный текст";
        // 
        // btnHybridEncrypt
        // 
        btnHybridEncrypt.Location = new System.Drawing.Point(24, 240);
        btnHybridEncrypt.Name = "btnHybridEncrypt";
        btnHybridEncrypt.Size = new System.Drawing.Size(220, 48);
        btnHybridEncrypt.TabIndex = 2;
        btnHybridEncrypt.Text = "Зашифровать";
        btnHybridEncrypt.UseVisualStyleBackColor = true;
        btnHybridEncrypt.Click += BtnHybridEncrypt_Click;
        // 
        // btnHybridSaveEncrypted
        // 
        btnHybridSaveEncrypted.Location = new System.Drawing.Point(260, 240);
        btnHybridSaveEncrypted.Name = "btnHybridSaveEncrypted";
        btnHybridSaveEncrypted.Size = new System.Drawing.Size(255, 48);
        btnHybridSaveEncrypted.TabIndex = 3;
        btnHybridSaveEncrypted.Text = "Сохранить";
        btnHybridSaveEncrypted.UseVisualStyleBackColor = true;
        btnHybridSaveEncrypted.Click += BtnHybridSaveEncrypted_Click;
        // 
        // btnHybridOpenEncrypted
        //
        btnHybridOpenEncrypted.Location = new System.Drawing.Point(530, 240);
        btnHybridOpenEncrypted.Name = "btnHybridOpenEncrypted";
        btnHybridOpenEncrypted.Size = new System.Drawing.Size(250, 48);
        btnHybridOpenEncrypted.TabIndex = 4;
        btnHybridOpenEncrypted.Text = "Открыть файлы";
        btnHybridOpenEncrypted.UseVisualStyleBackColor = true;
        btnHybridOpenEncrypted.Click += BtnHybridOpenEncrypted_Click;
        //
        // btnHybridDecrypt
        // 
        btnHybridDecrypt.Location = new System.Drawing.Point(800, 240);
        btnHybridDecrypt.Name = "btnHybridDecrypt";
        btnHybridDecrypt.Size = new System.Drawing.Size(220, 48);
        btnHybridDecrypt.TabIndex = 5;
        btnHybridDecrypt.Text = "Расшифровать";
        btnHybridDecrypt.UseVisualStyleBackColor = true;
        btnHybridDecrypt.Click += BtnHybridDecrypt_Click;
        // 
        // btnHybridSaveRestored
        // 
        btnHybridSaveRestored.Location = new System.Drawing.Point(24, 487);
        btnHybridSaveRestored.Name = "btnHybridSaveRestored";
        btnHybridSaveRestored.Size = new System.Drawing.Size(350, 48);
        btnHybridSaveRestored.TabIndex = 8;
        btnHybridSaveRestored.Text = "Сохранить текст";
        btnHybridSaveRestored.UseVisualStyleBackColor = true;
        btnHybridSaveRestored.Click += BtnHybridSaveRestored_Click;
        // 
        // lblHybridRestoredText
        // 
        lblHybridRestoredText.AutoSize = true;
        lblHybridRestoredText.Location = new System.Drawing.Point(24, 312);
        lblHybridRestoredText.Name = "lblHybridRestoredText";
        lblHybridRestoredText.Size = new System.Drawing.Size(275, 32);
        lblHybridRestoredText.TabIndex = 6;
        lblHybridRestoredText.Text = "Восстановленный текст";
        // 
        // txtHybridRestoredText
        // 
        txtHybridRestoredText.Location = new System.Drawing.Point(24, 345);
        txtHybridRestoredText.Multiline = true;
        txtHybridRestoredText.Name = "txtHybridRestoredText";
        txtHybridRestoredText.ReadOnly = true;
        txtHybridRestoredText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtHybridRestoredText.Size = new System.Drawing.Size(1125, 125);
        txtHybridRestoredText.TabIndex = 7;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1247, 902);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Лабораторная работа №6 - RSA и комбинированное шифрование";
        Controls.Add(tabMain);
        tabMain.ResumeLayout(false);
        tabRsa.ResumeLayout(false);
        grpRsaPrimeGeneration.ResumeLayout(false);
        grpRsaPrimeGeneration.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudRsaBitCount).EndInit();
        grpRsaKeyFiles.ResumeLayout(false);
        grpRsaDemo.ResumeLayout(false);
        grpRsaDemo.PerformLayout();
        tabAes.ResumeLayout(false);
        grpAesParameters.ResumeLayout(false);
        grpAesParameters.PerformLayout();
        grpAesOperation.ResumeLayout(false);
        grpAesOperation.PerformLayout();
        tabHybrid.ResumeLayout(false);
        grpHybridParameters.ResumeLayout(false);
        grpHybridParameters.PerformLayout();
        grpHybridOperation.ResumeLayout(false);
        grpHybridOperation.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabMain;
    private TabPage tabRsa;
    private GroupBox grpRsaPrimeGeneration;
    private Label lblRsaBitCount;
    private NumericUpDown nudRsaBitCount;
    private System.Windows.Forms.Button btnRsaGeneratePrimes;
    private System.Windows.Forms.Button btnRsaLoadPrimes;
    private System.Windows.Forms.Button btnRsaCalculateKeys;
    private Label lblRsaFirstPrime;
    private TextBox txtRsaFirstPrime;
    private Label lblRsaSecondPrime;
    private TextBox txtRsaSecondPrime;
    private Label lblRsaPublicExponent;
    private TextBox txtRsaPublicExponent;
    private Label lblRsaModulus;
    private TextBox txtRsaModulus;
    private Label lblRsaPrivateExponent;
    private TextBox txtRsaPrivateExponent;
    private GroupBox grpRsaKeyFiles;
    private System.Windows.Forms.Button btnRsaSavePublicKey;
    private Button btnRsaLoadPublicKey;
    private Button btnRsaSavePrivateKey;
    private Button btnRsaLoadPrivateKey;
    private System.Windows.Forms.GroupBox grpRsaDemo;
    private Label lblRsaMessage;
    private TextBox txtRsaMessage;
    private Label lblRsaEncryptedMessage;
    private TextBox txtRsaEncryptedMessage;
    private Label lblRsaRestoredMessage;
    private TextBox txtRsaRestoredMessage;
    private Button btnRsaEncrypt;
    private Button btnRsaDecrypt;
    private TabPage tabAes;
    private GroupBox grpAesParameters;
    private Label lblAesKey;
    private TextBox txtAesKey;
    private System.Windows.Forms.Button btnAesGenerateKey;
    private Label lblAesIv;
    private TextBox txtAesIv;
    private Button btnAesGenerateIv;
    private GroupBox grpAesOperation;
    private Label lblAesPlaintext;
    private System.Windows.Forms.TextBox txtAesPlaintext;
    private Button btnAesEncrypt;
    private Button btnAesDecrypt;
    private Label lblAesCiphertext;
    private TextBox txtAesCiphertext;
    private Label lblAesRestoredText;
    private TextBox txtAesRestoredText;
    private TabPage tabHybrid;
    private System.Windows.Forms.GroupBox grpHybridParameters;
    private System.Windows.Forms.Label lblHybridAesKey;
    private System.Windows.Forms.TextBox txtHybridAesKey;
    private System.Windows.Forms.Button btnHybridGenerateAesKey;
    private System.Windows.Forms.GroupBox grpHybridOperation;
    private Label lblHybridPlaintext;
    private System.Windows.Forms.TextBox txtHybridPlaintext;
    private System.Windows.Forms.Button btnHybridEncrypt;
    private System.Windows.Forms.Button btnHybridSaveEncrypted;
    private System.Windows.Forms.Button btnHybridOpenEncrypted;
    private System.Windows.Forms.Button btnHybridDecrypt;
    private System.Windows.Forms.Button btnHybridSaveRestored;
    private Label lblHybridRestoredText;
    private TextBox txtHybridRestoredText;
}
