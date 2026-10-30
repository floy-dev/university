#nullable disable

namespace Lab5;

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
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tabMain = new System.Windows.Forms.TabControl();
        tabPrimitiveRoots = new System.Windows.Forms.TabPage();
        grpRootSearch = new System.Windows.Forms.GroupBox();
        lblRootModulus = new System.Windows.Forms.Label();
        txtRootModulus = new System.Windows.Forms.TextBox();
        lblRootCount = new System.Windows.Forms.Label();
        nudRootCount = new System.Windows.Forms.NumericUpDown();
        btnCheckRootExistence = new System.Windows.Forms.Button();
        btnFindRoots = new System.Windows.Forms.Button();
        txtRootSearchResult = new System.Windows.Forms.TextBox();
        grpSafePrime = new System.Windows.Forms.GroupBox();
        lblSafePrimeBitCount = new System.Windows.Forms.Label();
        nudSafePrimeBitCount = new System.Windows.Forms.NumericUpDown();
        lblSafePrimeIterations = new System.Windows.Forms.Label();
        nudSafePrimeIterations = new System.Windows.Forms.NumericUpDown();
        btnGenerateSafePrime = new System.Windows.Forms.Button();
        lblSafePrimeP = new System.Windows.Forms.Label();
        txtSafePrimeP = new System.Windows.Forms.TextBox();
        lblSafePrimeN = new System.Windows.Forms.Label();
        txtSafePrimeN = new System.Windows.Forms.TextBox();
        lblSafePrimeRoot = new System.Windows.Forms.Label();
        txtSafePrimeRoot = new System.Windows.Forms.TextBox();
        lblSafePrimeStatus = new System.Windows.Forms.Label();
        txtSafePrimeStatus = new System.Windows.Forms.TextBox();
        tabDiffieHellman = new System.Windows.Forms.TabPage();
        grpDhParameters = new System.Windows.Forms.GroupBox();
        lblDhModulus = new System.Windows.Forms.Label();
        txtDhModulus = new System.Windows.Forms.TextBox();
        lblDhPrimitiveRoot = new System.Windows.Forms.Label();
        txtDhPrimitiveRoot = new System.Windows.Forms.TextBox();
        lblDhAliceSecret = new System.Windows.Forms.Label();
        txtDhAliceSecret = new System.Windows.Forms.TextBox();
        lblDhBobSecret = new System.Windows.Forms.Label();
        txtDhBobSecret = new System.Windows.Forms.TextBox();
        btnDhCalculate = new System.Windows.Forms.Button();
        grpDhResults = new System.Windows.Forms.GroupBox();
        lblDhAlicePublic = new System.Windows.Forms.Label();
        txtDhAlicePublic = new System.Windows.Forms.TextBox();
        lblDhBobPublic = new System.Windows.Forms.Label();
        txtDhBobPublic = new System.Windows.Forms.TextBox();
        lblDhAliceSharedKey = new System.Windows.Forms.Label();
        txtDhAliceSharedKey = new System.Windows.Forms.TextBox();
        lblDhBobSharedKey = new System.Windows.Forms.Label();
        txtDhBobSharedKey = new System.Windows.Forms.TextBox();
        lblDhStatus = new System.Windows.Forms.Label();
        txtDhStatus = new System.Windows.Forms.TextBox();
        tabElGamal = new System.Windows.Forms.TabPage();
        grpElGamalParameters = new System.Windows.Forms.GroupBox();
        lblElGamalModulus = new System.Windows.Forms.Label();
        txtElGamalModulus = new System.Windows.Forms.TextBox();
        lblElGamalPrimitiveRoot = new System.Windows.Forms.Label();
        txtElGamalPrimitiveRoot = new System.Windows.Forms.TextBox();
        lblElGamalSecret = new System.Windows.Forms.Label();
        txtElGamalSecret = new System.Windows.Forms.TextBox();
        lblElGamalPublicKey = new System.Windows.Forms.Label();
        txtElGamalPublicKey = new System.Windows.Forms.TextBox();
        lblElGamalSessionKey = new System.Windows.Forms.Label();
        txtElGamalSessionKey = new System.Windows.Forms.TextBox();
        btnElGamalCalculatePublicKey = new System.Windows.Forms.Button();
        btnElGamalGenerateSessionKey = new System.Windows.Forms.Button();
        grpElGamalOperation = new System.Windows.Forms.GroupBox();
        lblElGamalMessage = new System.Windows.Forms.Label();
        txtElGamalMessage = new System.Windows.Forms.TextBox();
        lblElGamalFirstComponent = new System.Windows.Forms.Label();
        txtElGamalFirstComponent = new System.Windows.Forms.TextBox();
        lblElGamalSecondComponent = new System.Windows.Forms.Label();
        txtElGamalSecondComponent = new System.Windows.Forms.TextBox();
        lblElGamalDecryptedMessage = new System.Windows.Forms.Label();
        txtElGamalDecryptedMessage = new System.Windows.Forms.TextBox();
        btnElGamalEncrypt = new System.Windows.Forms.Button();
        btnElGamalDecrypt = new System.Windows.Forms.Button();
        tabMain.SuspendLayout();
        tabPrimitiveRoots.SuspendLayout();
        grpRootSearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudRootCount).BeginInit();
        grpSafePrime.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudSafePrimeBitCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudSafePrimeIterations).BeginInit();
        tabDiffieHellman.SuspendLayout();
        grpDhParameters.SuspendLayout();
        grpDhResults.SuspendLayout();
        tabElGamal.SuspendLayout();
        grpElGamalParameters.SuspendLayout();
        grpElGamalOperation.SuspendLayout();
        SuspendLayout();
        // 
        // tabMain
        // 
        tabMain.Controls.Add(tabPrimitiveRoots);
        tabMain.Controls.Add(tabDiffieHellman);
        tabMain.Controls.Add(tabElGamal);
        tabMain.Location = new System.Drawing.Point(12, 12);
        tabMain.Name = "tabMain";
        tabMain.Padding = new System.Drawing.Point(14, 6);
        tabMain.SelectedIndex = 0;
        tabMain.Size = new System.Drawing.Size(1223, 878);
        tabMain.TabIndex = 0;
        // 
        // tabPrimitiveRoots
        // 
        tabPrimitiveRoots.Controls.Add(grpRootSearch);
        tabPrimitiveRoots.Controls.Add(grpSafePrime);
        tabPrimitiveRoots.Location = new System.Drawing.Point(8, 50);
        tabPrimitiveRoots.Name = "tabPrimitiveRoots";
        tabPrimitiveRoots.Padding = new System.Windows.Forms.Padding(3);
        tabPrimitiveRoots.Size = new System.Drawing.Size(1207, 820);
        tabPrimitiveRoots.TabIndex = 0;
        tabPrimitiveRoots.Text = "Первообразные корни";
        tabPrimitiveRoots.UseVisualStyleBackColor = true;
        // 
        // grpRootSearch
        // 
        grpRootSearch.Controls.Add(lblRootModulus);
        grpRootSearch.Controls.Add(txtRootModulus);
        grpRootSearch.Controls.Add(lblRootCount);
        grpRootSearch.Controls.Add(nudRootCount);
        grpRootSearch.Controls.Add(btnCheckRootExistence);
        grpRootSearch.Controls.Add(btnFindRoots);
        grpRootSearch.Controls.Add(txtRootSearchResult);
        grpRootSearch.Location = new System.Drawing.Point(16, 16);
        grpRootSearch.Name = "grpRootSearch";
        grpRootSearch.Size = new System.Drawing.Size(1180, 350);
        grpRootSearch.TabIndex = 0;
        grpRootSearch.TabStop = false;
        grpRootSearch.Text = "Проверка существования и поиск первых корней";
        // 
        // lblRootModulus
        // 
        lblRootModulus.AutoSize = true;
        lblRootModulus.Location = new System.Drawing.Point(24, 44);
        lblRootModulus.Name = "lblRootModulus";
        lblRootModulus.Size = new System.Drawing.Size(121, 32);
        lblRootModulus.TabIndex = 0;
        lblRootModulus.Text = "Модуль n";
        // 
        // txtRootModulus
        // 
        txtRootModulus.Location = new System.Drawing.Point(145, 40);
        txtRootModulus.Name = "txtRootModulus";
        txtRootModulus.Size = new System.Drawing.Size(310, 39);
        txtRootModulus.TabIndex = 1;
        txtRootModulus.Text = "41";
        // 
        // lblRootCount
        // 
        lblRootCount.AutoSize = true;
        lblRootCount.Location = new System.Drawing.Point(505, 44);
        lblRootCount.Name = "lblRootCount";
        lblRootCount.Size = new System.Drawing.Size(251, 32);
        lblRootCount.TabIndex = 2;
        lblRootCount.Text = "Количество корней k";
        // 
        // nudRootCount
        // 
        nudRootCount.Location = new System.Drawing.Point(773, 38);
        nudRootCount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nudRootCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudRootCount.Name = "nudRootCount";
        nudRootCount.Size = new System.Drawing.Size(145, 39);
        nudRootCount.TabIndex = 3;
        nudRootCount.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // btnCheckRootExistence
        // 
        btnCheckRootExistence.Location = new System.Drawing.Point(24, 90);
        btnCheckRootExistence.Name = "btnCheckRootExistence";
        btnCheckRootExistence.Size = new System.Drawing.Size(345, 48);
        btnCheckRootExistence.TabIndex = 4;
        btnCheckRootExistence.Text = "Проверить существование";
        btnCheckRootExistence.UseVisualStyleBackColor = true;
        // 
        // btnFindRoots
        // 
        btnFindRoots.Location = new System.Drawing.Point(434, 90);
        btnFindRoots.Name = "btnFindRoots";
        btnFindRoots.Size = new System.Drawing.Size(190, 48);
        btnFindRoots.TabIndex = 5;
        btnFindRoots.Text = "Найти корни";
        btnFindRoots.UseVisualStyleBackColor = true;
        // 
        // txtRootSearchResult
        // 
        txtRootSearchResult.Location = new System.Drawing.Point(24, 158);
        txtRootSearchResult.Multiline = true;
        txtRootSearchResult.Name = "txtRootSearchResult";
        txtRootSearchResult.ReadOnly = true;
        txtRootSearchResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtRootSearchResult.Size = new System.Drawing.Size(1130, 165);
        txtRootSearchResult.TabIndex = 6;
        // 
        // grpSafePrime
        // 
        grpSafePrime.Controls.Add(lblSafePrimeBitCount);
        grpSafePrime.Controls.Add(nudSafePrimeBitCount);
        grpSafePrime.Controls.Add(lblSafePrimeIterations);
        grpSafePrime.Controls.Add(nudSafePrimeIterations);
        grpSafePrime.Controls.Add(btnGenerateSafePrime);
        grpSafePrime.Controls.Add(lblSafePrimeP);
        grpSafePrime.Controls.Add(txtSafePrimeP);
        grpSafePrime.Controls.Add(lblSafePrimeN);
        grpSafePrime.Controls.Add(txtSafePrimeN);
        grpSafePrime.Controls.Add(lblSafePrimeRoot);
        grpSafePrime.Controls.Add(txtSafePrimeRoot);
        grpSafePrime.Controls.Add(lblSafePrimeStatus);
        grpSafePrime.Controls.Add(txtSafePrimeStatus);
        grpSafePrime.Location = new System.Drawing.Point(16, 382);
        grpSafePrime.Name = "grpSafePrime";
        grpSafePrime.Size = new System.Drawing.Size(1180, 440);
        grpSafePrime.TabIndex = 1;
        grpSafePrime.TabStop = false;
        grpSafePrime.Text = "Безопасное простое n = 2p + 1 и первообразный корень";
        // 
        // lblSafePrimeBitCount
        // 
        lblSafePrimeBitCount.AutoSize = true;
        lblSafePrimeBitCount.Location = new System.Drawing.Point(24, 43);
        lblSafePrimeBitCount.Name = "lblSafePrimeBitCount";
        lblSafePrimeBitCount.Size = new System.Drawing.Size(221, 32);
        lblSafePrimeBitCount.TabIndex = 0;
        lblSafePrimeBitCount.Text = "Разрядность n, бит";
        // 
        // nudSafePrimeBitCount
        // 
        nudSafePrimeBitCount.Location = new System.Drawing.Point(251, 41);
        nudSafePrimeBitCount.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
        nudSafePrimeBitCount.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
        nudSafePrimeBitCount.Name = "nudSafePrimeBitCount";
        nudSafePrimeBitCount.Size = new System.Drawing.Size(145, 39);
        nudSafePrimeBitCount.TabIndex = 1;
        nudSafePrimeBitCount.Value = new decimal(new int[] { 32, 0, 0, 0 });
        // 
        // lblSafePrimeIterations
        // 
        lblSafePrimeIterations.AutoSize = true;
        lblSafePrimeIterations.Location = new System.Drawing.Point(523, 46);
        lblSafePrimeIterations.Name = "lblSafePrimeIterations";
        lblSafePrimeIterations.Size = new System.Drawing.Size(257, 32);
        lblSafePrimeIterations.TabIndex = 2;
        lblSafePrimeIterations.Text = "Итерации проверки k";
        // 
        // nudSafePrimeIterations
        // 
        nudSafePrimeIterations.Location = new System.Drawing.Point(799, 46);
        nudSafePrimeIterations.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nudSafePrimeIterations.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudSafePrimeIterations.Name = "nudSafePrimeIterations";
        nudSafePrimeIterations.Size = new System.Drawing.Size(145, 39);
        nudSafePrimeIterations.TabIndex = 3;
        nudSafePrimeIterations.Value = new decimal(new int[] { 16, 0, 0, 0 });
        // 
        // btnGenerateSafePrime
        // 
        btnGenerateSafePrime.Location = new System.Drawing.Point(24, 88);
        btnGenerateSafePrime.Name = "btnGenerateSafePrime";
        btnGenerateSafePrime.Size = new System.Drawing.Size(397, 48);
        btnGenerateSafePrime.TabIndex = 4;
        btnGenerateSafePrime.Text = "Сгенерировать n, p и корень";
        btnGenerateSafePrime.UseVisualStyleBackColor = true;
        // 
        // lblSafePrimeP
        // 
        lblSafePrimeP.AutoSize = true;
        lblSafePrimeP.Location = new System.Drawing.Point(24, 165);
        lblSafePrimeP.Name = "lblSafePrimeP";
        lblSafePrimeP.Size = new System.Drawing.Size(201, 32);
        lblSafePrimeP.TabIndex = 5;
        lblSafePrimeP.Text = "Простое число p";
        // 
        // txtSafePrimeP
        // 
        txtSafePrimeP.Location = new System.Drawing.Point(270, 161);
        txtSafePrimeP.Name = "txtSafePrimeP";
        txtSafePrimeP.ReadOnly = true;
        txtSafePrimeP.Size = new System.Drawing.Size(884, 39);
        txtSafePrimeP.TabIndex = 6;
        // 
        // lblSafePrimeN
        // 
        lblSafePrimeN.AutoSize = true;
        lblSafePrimeN.Location = new System.Drawing.Point(24, 213);
        lblSafePrimeN.Name = "lblSafePrimeN";
        lblSafePrimeN.Size = new System.Drawing.Size(262, 32);
        lblSafePrimeN.TabIndex = 7;
        lblSafePrimeN.Text = "Безопасное простое n";
        // 
        // txtSafePrimeN
        // 
        txtSafePrimeN.Location = new System.Drawing.Point(330, 209);
        txtSafePrimeN.Name = "txtSafePrimeN";
        txtSafePrimeN.ReadOnly = true;
        txtSafePrimeN.Size = new System.Drawing.Size(824, 39);
        txtSafePrimeN.TabIndex = 8;
        // 
        // lblSafePrimeRoot
        // 
        lblSafePrimeRoot.AutoSize = true;
        lblSafePrimeRoot.Location = new System.Drawing.Point(24, 261);
        lblSafePrimeRoot.Name = "lblSafePrimeRoot";
        lblSafePrimeRoot.Size = new System.Drawing.Size(302, 32);
        lblSafePrimeRoot.TabIndex = 9;
        lblSafePrimeRoot.Text = "Первообразный корень g";
        // 
        // txtSafePrimeRoot
        // 
        txtSafePrimeRoot.Location = new System.Drawing.Point(408, 257);
        txtSafePrimeRoot.Name = "txtSafePrimeRoot";
        txtSafePrimeRoot.ReadOnly = true;
        txtSafePrimeRoot.Size = new System.Drawing.Size(746, 39);
        txtSafePrimeRoot.TabIndex = 10;
        // 
        // lblSafePrimeStatus
        // 
        lblSafePrimeStatus.AutoSize = true;
        lblSafePrimeStatus.Location = new System.Drawing.Point(24, 330);
        lblSafePrimeStatus.Name = "lblSafePrimeStatus";
        lblSafePrimeStatus.Size = new System.Drawing.Size(120, 32);
        lblSafePrimeStatus.TabIndex = 11;
        lblSafePrimeStatus.Text = "Результат";
        // 
        // txtSafePrimeStatus
        // 
        txtSafePrimeStatus.Location = new System.Drawing.Point(270, 310);
        txtSafePrimeStatus.Multiline = true;
        txtSafePrimeStatus.Name = "txtSafePrimeStatus";
        txtSafePrimeStatus.ReadOnly = true;
        txtSafePrimeStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtSafePrimeStatus.Size = new System.Drawing.Size(884, 100);
        txtSafePrimeStatus.TabIndex = 12;
        // 
        // tabDiffieHellman
        // 
        tabDiffieHellman.Controls.Add(grpDhParameters);
        tabDiffieHellman.Controls.Add(grpDhResults);
        tabDiffieHellman.Location = new System.Drawing.Point(8, 50);
        tabDiffieHellman.Name = "tabDiffieHellman";
        tabDiffieHellman.Padding = new System.Windows.Forms.Padding(3);
        tabDiffieHellman.Size = new System.Drawing.Size(1207, 820);
        tabDiffieHellman.TabIndex = 1;
        tabDiffieHellman.Text = "Диффи-Хеллман";
        tabDiffieHellman.UseVisualStyleBackColor = true;
        // 
        // grpDhParameters
        // 
        grpDhParameters.Controls.Add(lblDhModulus);
        grpDhParameters.Controls.Add(txtDhModulus);
        grpDhParameters.Controls.Add(lblDhPrimitiveRoot);
        grpDhParameters.Controls.Add(txtDhPrimitiveRoot);
        grpDhParameters.Controls.Add(lblDhAliceSecret);
        grpDhParameters.Controls.Add(txtDhAliceSecret);
        grpDhParameters.Controls.Add(lblDhBobSecret);
        grpDhParameters.Controls.Add(txtDhBobSecret);
        grpDhParameters.Controls.Add(btnDhCalculate);
        grpDhParameters.Location = new System.Drawing.Point(16, 16);
        grpDhParameters.Name = "grpDhParameters";
        grpDhParameters.Size = new System.Drawing.Size(1180, 235);
        grpDhParameters.TabIndex = 0;
        grpDhParameters.TabStop = false;
        grpDhParameters.Text = "Общие параметры и секреты сторон";
        // 
        // lblDhModulus
        // 
        lblDhModulus.AutoSize = true;
        lblDhModulus.Location = new System.Drawing.Point(24, 48);
        lblDhModulus.Name = "lblDhModulus";
        lblDhModulus.Size = new System.Drawing.Size(121, 32);
        lblDhModulus.TabIndex = 0;
        lblDhModulus.Text = "Модуль n";
        // 
        // txtDhModulus
        // 
        txtDhModulus.Location = new System.Drawing.Point(165, 44);
        txtDhModulus.Name = "txtDhModulus";
        txtDhModulus.Size = new System.Drawing.Size(320, 39);
        txtDhModulus.TabIndex = 1;
        txtDhModulus.Text = "23";
        // 
        // lblDhPrimitiveRoot
        // 
        lblDhPrimitiveRoot.AutoSize = true;
        lblDhPrimitiveRoot.Location = new System.Drawing.Point(570, 48);
        lblDhPrimitiveRoot.Name = "lblDhPrimitiveRoot";
        lblDhPrimitiveRoot.Size = new System.Drawing.Size(216, 32);
        lblDhPrimitiveRoot.TabIndex = 2;
        lblDhPrimitiveRoot.Text = "Первообразный g";
        // 
        // txtDhPrimitiveRoot
        // 
        txtDhPrimitiveRoot.Location = new System.Drawing.Point(790, 44);
        txtDhPrimitiveRoot.Name = "txtDhPrimitiveRoot";
        txtDhPrimitiveRoot.Size = new System.Drawing.Size(340, 39);
        txtDhPrimitiveRoot.TabIndex = 3;
        txtDhPrimitiveRoot.Text = "20";
        // 
        // lblDhAliceSecret
        // 
        lblDhAliceSecret.AutoSize = true;
        lblDhAliceSecret.Location = new System.Drawing.Point(24, 103);
        lblDhAliceSecret.Name = "lblDhAliceSecret";
        lblDhAliceSecret.Size = new System.Drawing.Size(187, 32);
        lblDhAliceSecret.TabIndex = 4;
        lblDhAliceSecret.Text = "Секрет Алисы a";
        // 
        // txtDhAliceSecret
        // 
        txtDhAliceSecret.Location = new System.Drawing.Point(229, 99);
        txtDhAliceSecret.Name = "txtDhAliceSecret";
        txtDhAliceSecret.Size = new System.Drawing.Size(256, 39);
        txtDhAliceSecret.TabIndex = 5;
        txtDhAliceSecret.Text = "14";
        // 
        // lblDhBobSecret
        // 
        lblDhBobSecret.AutoSize = true;
        lblDhBobSecret.Location = new System.Drawing.Point(570, 103);
        lblDhBobSecret.Name = "lblDhBobSecret";
        lblDhBobSecret.Size = new System.Drawing.Size(173, 32);
        lblDhBobSecret.TabIndex = 6;
        lblDhBobSecret.Text = "Секрет Боба b";
        // 
        // txtDhBobSecret
        // 
        txtDhBobSecret.Location = new System.Drawing.Point(790, 99);
        txtDhBobSecret.Name = "txtDhBobSecret";
        txtDhBobSecret.Size = new System.Drawing.Size(340, 39);
        txtDhBobSecret.TabIndex = 7;
        txtDhBobSecret.Text = "12";
        // 
        // btnDhCalculate
        // 
        btnDhCalculate.Location = new System.Drawing.Point(24, 158);
        btnDhCalculate.Name = "btnDhCalculate";
        btnDhCalculate.Size = new System.Drawing.Size(260, 48);
        btnDhCalculate.TabIndex = 8;
        btnDhCalculate.Text = "Выполнить обмен";
        btnDhCalculate.UseVisualStyleBackColor = true;
        // 
        // grpDhResults
        // 
        grpDhResults.Controls.Add(lblDhAlicePublic);
        grpDhResults.Controls.Add(txtDhAlicePublic);
        grpDhResults.Controls.Add(lblDhBobPublic);
        grpDhResults.Controls.Add(txtDhBobPublic);
        grpDhResults.Controls.Add(lblDhAliceSharedKey);
        grpDhResults.Controls.Add(txtDhAliceSharedKey);
        grpDhResults.Controls.Add(lblDhBobSharedKey);
        grpDhResults.Controls.Add(txtDhBobSharedKey);
        grpDhResults.Controls.Add(lblDhStatus);
        grpDhResults.Controls.Add(txtDhStatus);
        grpDhResults.Location = new System.Drawing.Point(16, 270);
        grpDhResults.Name = "grpDhResults";
        grpDhResults.Size = new System.Drawing.Size(1180, 552);
        grpDhResults.TabIndex = 1;
        grpDhResults.TabStop = false;
        grpDhResults.Text = "Открытые значения и общий ключ";
        // 
        // lblDhAlicePublic
        // 
        lblDhAlicePublic.AutoSize = true;
        lblDhAlicePublic.Location = new System.Drawing.Point(24, 50);
        lblDhAlicePublic.Name = "lblDhAlicePublic";
        lblDhAlicePublic.Size = new System.Drawing.Size(359, 32);
        lblDhAlicePublic.TabIndex = 0;
        lblDhAlicePublic.Text = "Алиса передаёт A = g^a mod n";
        // 
        // txtDhAlicePublic
        // 
        txtDhAlicePublic.Location = new System.Drawing.Point(398, 46);
        txtDhAlicePublic.Name = "txtDhAlicePublic";
        txtDhAlicePublic.ReadOnly = true;
        txtDhAlicePublic.Size = new System.Drawing.Size(732, 39);
        txtDhAlicePublic.TabIndex = 1;
        // 
        // lblDhBobPublic
        // 
        lblDhBobPublic.AutoSize = true;
        lblDhBobPublic.Location = new System.Drawing.Point(24, 105);
        lblDhBobPublic.Name = "lblDhBobPublic";
        lblDhBobPublic.Size = new System.Drawing.Size(337, 32);
        lblDhBobPublic.TabIndex = 2;
        lblDhBobPublic.Text = "Боб передаёт B = g^b mod n";
        // 
        // txtDhBobPublic
        // 
        txtDhBobPublic.Location = new System.Drawing.Point(398, 101);
        txtDhBobPublic.Name = "txtDhBobPublic";
        txtDhBobPublic.ReadOnly = true;
        txtDhBobPublic.Size = new System.Drawing.Size(732, 39);
        txtDhBobPublic.TabIndex = 3;
        // 
        // lblDhAliceSharedKey
        // 
        lblDhAliceSharedKey.AutoSize = true;
        lblDhAliceSharedKey.Location = new System.Drawing.Point(24, 160);
        lblDhAliceSharedKey.Name = "lblDhAliceSharedKey";
        lblDhAliceSharedKey.Size = new System.Drawing.Size(347, 32);
        lblDhAliceSharedKey.TabIndex = 4;
        lblDhAliceSharedKey.Text = "Ключ Алисы K_A = B^a mod n";
        // 
        // txtDhAliceSharedKey
        // 
        txtDhAliceSharedKey.Location = new System.Drawing.Point(398, 156);
        txtDhAliceSharedKey.Name = "txtDhAliceSharedKey";
        txtDhAliceSharedKey.ReadOnly = true;
        txtDhAliceSharedKey.Size = new System.Drawing.Size(732, 39);
        txtDhAliceSharedKey.TabIndex = 5;
        // 
        // lblDhBobSharedKey
        // 
        lblDhBobSharedKey.AutoSize = true;
        lblDhBobSharedKey.Location = new System.Drawing.Point(24, 215);
        lblDhBobSharedKey.Name = "lblDhBobSharedKey";
        lblDhBobSharedKey.Size = new System.Drawing.Size(333, 32);
        lblDhBobSharedKey.TabIndex = 6;
        lblDhBobSharedKey.Text = "Ключ Боба K_B = A^b mod n";
        // 
        // txtDhBobSharedKey
        // 
        txtDhBobSharedKey.Location = new System.Drawing.Point(398, 211);
        txtDhBobSharedKey.Name = "txtDhBobSharedKey";
        txtDhBobSharedKey.ReadOnly = true;
        txtDhBobSharedKey.Size = new System.Drawing.Size(732, 39);
        txtDhBobSharedKey.TabIndex = 7;
        // 
        // lblDhStatus
        // 
        lblDhStatus.AutoSize = true;
        lblDhStatus.Location = new System.Drawing.Point(24, 305);
        lblDhStatus.Name = "lblDhStatus";
        lblDhStatus.Size = new System.Drawing.Size(244, 32);
        lblDhStatus.TabIndex = 8;
        lblDhStatus.Text = "Результат сравнения";
        // 
        // txtDhStatus
        // 
        txtDhStatus.Location = new System.Drawing.Point(310, 280);
        txtDhStatus.Multiline = true;
        txtDhStatus.Name = "txtDhStatus";
        txtDhStatus.ReadOnly = true;
        txtDhStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtDhStatus.Size = new System.Drawing.Size(820, 220);
        txtDhStatus.TabIndex = 9;
        // 
        // tabElGamal
        // 
        tabElGamal.Controls.Add(grpElGamalParameters);
        tabElGamal.Controls.Add(grpElGamalOperation);
        tabElGamal.Location = new System.Drawing.Point(8, 50);
        tabElGamal.Name = "tabElGamal";
        tabElGamal.Padding = new System.Windows.Forms.Padding(3);
        tabElGamal.Size = new System.Drawing.Size(1207, 820);
        tabElGamal.TabIndex = 2;
        tabElGamal.Text = "Эль-Гамаль";
        tabElGamal.UseVisualStyleBackColor = true;
        // 
        // grpElGamalParameters
        // 
        grpElGamalParameters.Controls.Add(lblElGamalModulus);
        grpElGamalParameters.Controls.Add(txtElGamalModulus);
        grpElGamalParameters.Controls.Add(lblElGamalPrimitiveRoot);
        grpElGamalParameters.Controls.Add(txtElGamalPrimitiveRoot);
        grpElGamalParameters.Controls.Add(lblElGamalSecret);
        grpElGamalParameters.Controls.Add(txtElGamalSecret);
        grpElGamalParameters.Controls.Add(lblElGamalPublicKey);
        grpElGamalParameters.Controls.Add(txtElGamalPublicKey);
        grpElGamalParameters.Controls.Add(lblElGamalSessionKey);
        grpElGamalParameters.Controls.Add(txtElGamalSessionKey);
        grpElGamalParameters.Controls.Add(btnElGamalCalculatePublicKey);
        grpElGamalParameters.Controls.Add(btnElGamalGenerateSessionKey);
        grpElGamalParameters.Location = new System.Drawing.Point(16, 16);
        grpElGamalParameters.Name = "grpElGamalParameters";
        grpElGamalParameters.Size = new System.Drawing.Size(1180, 350);
        grpElGamalParameters.TabIndex = 0;
        grpElGamalParameters.TabStop = false;
        grpElGamalParameters.Text = "Параметры и ключи";
        // 
        // lblElGamalModulus
        // 
        lblElGamalModulus.AutoSize = true;
        lblElGamalModulus.Location = new System.Drawing.Point(24, 45);
        lblElGamalModulus.Name = "lblElGamalModulus";
        lblElGamalModulus.Size = new System.Drawing.Size(121, 32);
        lblElGamalModulus.TabIndex = 0;
        lblElGamalModulus.Text = "Модуль n";
        // 
        // txtElGamalModulus
        // 
        txtElGamalModulus.Location = new System.Drawing.Point(389, 45);
        txtElGamalModulus.Name = "txtElGamalModulus";
        txtElGamalModulus.Size = new System.Drawing.Size(500, 39);
        txtElGamalModulus.TabIndex = 1;
        txtElGamalModulus.Text = "467";
        // 
        // lblElGamalPrimitiveRoot
        // 
        lblElGamalPrimitiveRoot.AutoSize = true;
        lblElGamalPrimitiveRoot.Location = new System.Drawing.Point(24, 90);
        lblElGamalPrimitiveRoot.Name = "lblElGamalPrimitiveRoot";
        lblElGamalPrimitiveRoot.Size = new System.Drawing.Size(302, 32);
        lblElGamalPrimitiveRoot.TabIndex = 2;
        lblElGamalPrimitiveRoot.Text = "Первообразный корень g";
        // 
        // txtElGamalPrimitiveRoot
        // 
        txtElGamalPrimitiveRoot.Location = new System.Drawing.Point(389, 90);
        txtElGamalPrimitiveRoot.Name = "txtElGamalPrimitiveRoot";
        txtElGamalPrimitiveRoot.Size = new System.Drawing.Size(500, 39);
        txtElGamalPrimitiveRoot.TabIndex = 3;
        txtElGamalPrimitiveRoot.Text = "2";
        // 
        // lblElGamalSecret
        // 
        lblElGamalSecret.AutoSize = true;
        lblElGamalSecret.Location = new System.Drawing.Point(24, 135);
        lblElGamalSecret.Name = "lblElGamalSecret";
        lblElGamalSecret.Size = new System.Drawing.Size(206, 32);
        lblElGamalSecret.TabIndex = 4;
        lblElGamalSecret.Text = "Закрытый ключ s";
        // 
        // txtElGamalSecret
        // 
        txtElGamalSecret.Location = new System.Drawing.Point(389, 135);
        txtElGamalSecret.Name = "txtElGamalSecret";
        txtElGamalSecret.Size = new System.Drawing.Size(500, 39);
        txtElGamalSecret.TabIndex = 5;
        txtElGamalSecret.Text = "127";
        // 
        // lblElGamalPublicKey
        // 
        lblElGamalPublicKey.AutoSize = true;
        lblElGamalPublicKey.Location = new System.Drawing.Point(24, 180);
        lblElGamalPublicKey.Name = "lblElGamalPublicKey";
        lblElGamalPublicKey.Size = new System.Drawing.Size(359, 32);
        lblElGamalPublicKey.TabIndex = 6;
        lblElGamalPublicKey.Text = "Открытый ключ S = g^s mod n";
        // 
        // txtElGamalPublicKey
        // 
        txtElGamalPublicKey.Location = new System.Drawing.Point(389, 180);
        txtElGamalPublicKey.Name = "txtElGamalPublicKey";
        txtElGamalPublicKey.ReadOnly = true;
        txtElGamalPublicKey.Size = new System.Drawing.Size(500, 39);
        txtElGamalPublicKey.TabIndex = 7;
        // 
        // lblElGamalSessionKey
        // 
        lblElGamalSessionKey.AutoSize = true;
        lblElGamalSessionKey.Location = new System.Drawing.Point(24, 225);
        lblElGamalSessionKey.Name = "lblElGamalSessionKey";
        lblElGamalSessionKey.Size = new System.Drawing.Size(236, 32);
        lblElGamalSessionKey.TabIndex = 8;
        lblElGamalSessionKey.Text = "Сессионный ключ k";
        // 
        // txtElGamalSessionKey
        // 
        txtElGamalSessionKey.Location = new System.Drawing.Point(389, 226);
        txtElGamalSessionKey.Name = "txtElGamalSessionKey";
        txtElGamalSessionKey.Size = new System.Drawing.Size(500, 39);
        txtElGamalSessionKey.TabIndex = 9;
        txtElGamalSessionKey.Text = "53";
        // 
        // btnElGamalCalculatePublicKey
        // 
        btnElGamalCalculatePublicKey.Location = new System.Drawing.Point(24, 278);
        btnElGamalCalculatePublicKey.Name = "btnElGamalCalculatePublicKey";
        btnElGamalCalculatePublicKey.Size = new System.Drawing.Size(406, 48);
        btnElGamalCalculatePublicKey.TabIndex = 10;
        btnElGamalCalculatePublicKey.Text = "Вычислить открытый ключ";
        btnElGamalCalculatePublicKey.UseVisualStyleBackColor = true;
        // 
        // btnElGamalGenerateSessionKey
        // 
        btnElGamalGenerateSessionKey.Location = new System.Drawing.Point(436, 278);
        btnElGamalGenerateSessionKey.Name = "btnElGamalGenerateSessionKey";
        btnElGamalGenerateSessionKey.Size = new System.Drawing.Size(220, 48);
        btnElGamalGenerateSessionKey.TabIndex = 11;
        btnElGamalGenerateSessionKey.Text = "Сгенерировать k";
        btnElGamalGenerateSessionKey.UseVisualStyleBackColor = true;
        // 
        // grpElGamalOperation
        // 
        grpElGamalOperation.Controls.Add(lblElGamalMessage);
        grpElGamalOperation.Controls.Add(txtElGamalMessage);
        grpElGamalOperation.Controls.Add(lblElGamalFirstComponent);
        grpElGamalOperation.Controls.Add(txtElGamalFirstComponent);
        grpElGamalOperation.Controls.Add(lblElGamalSecondComponent);
        grpElGamalOperation.Controls.Add(txtElGamalSecondComponent);
        grpElGamalOperation.Controls.Add(lblElGamalDecryptedMessage);
        grpElGamalOperation.Controls.Add(txtElGamalDecryptedMessage);
        grpElGamalOperation.Controls.Add(btnElGamalEncrypt);
        grpElGamalOperation.Controls.Add(btnElGamalDecrypt);
        grpElGamalOperation.Location = new System.Drawing.Point(16, 382);
        grpElGamalOperation.Name = "grpElGamalOperation";
        grpElGamalOperation.Size = new System.Drawing.Size(1180, 440);
        grpElGamalOperation.TabIndex = 1;
        grpElGamalOperation.TabStop = false;
        grpElGamalOperation.Text = "Шифрование и дешифрование числа";
        // 
        // lblElGamalMessage
        // 
        lblElGamalMessage.AutoSize = true;
        lblElGamalMessage.Location = new System.Drawing.Point(24, 50);
        lblElGamalMessage.Name = "lblElGamalMessage";
        lblElGamalMessage.Size = new System.Drawing.Size(285, 32);
        lblElGamalMessage.TabIndex = 0;
        lblElGamalMessage.Text = "Исходное сообщение M";
        // 
        // txtElGamalMessage
        // 
        txtElGamalMessage.Location = new System.Drawing.Point(436, 46);
        txtElGamalMessage.Name = "txtElGamalMessage";
        txtElGamalMessage.Size = new System.Drawing.Size(694, 39);
        txtElGamalMessage.TabIndex = 1;
        txtElGamalMessage.Text = "123";
        // 
        // lblElGamalFirstComponent
        // 
        lblElGamalFirstComponent.AutoSize = true;
        lblElGamalFirstComponent.Location = new System.Drawing.Point(24, 105);
        lblElGamalFirstComponent.Name = "lblElGamalFirstComponent";
        lblElGamalFirstComponent.Size = new System.Drawing.Size(308, 32);
        lblElGamalFirstComponent.TabIndex = 2;
        lblElGamalFirstComponent.Text = "Компонент u = g^k mod n";
        // 
        // txtElGamalFirstComponent
        // 
        txtElGamalFirstComponent.Location = new System.Drawing.Point(436, 101);
        txtElGamalFirstComponent.Name = "txtElGamalFirstComponent";
        txtElGamalFirstComponent.Size = new System.Drawing.Size(694, 39);
        txtElGamalFirstComponent.TabIndex = 3;
        txtElGamalFirstComponent.Text = "399";
        // 
        // lblElGamalSecondComponent
        // 
        lblElGamalSecondComponent.AutoSize = true;
        lblElGamalSecondComponent.Location = new System.Drawing.Point(24, 160);
        lblElGamalSecondComponent.Name = "lblElGamalSecondComponent";
        lblElGamalSecondComponent.Size = new System.Drawing.Size(357, 32);
        lblElGamalSecondComponent.TabIndex = 4;
        lblElGamalSecondComponent.Text = "Компонент v = S^k × M mod n";
        // 
        // txtElGamalSecondComponent
        // 
        txtElGamalSecondComponent.Location = new System.Drawing.Point(436, 156);
        txtElGamalSecondComponent.Name = "txtElGamalSecondComponent";
        txtElGamalSecondComponent.Size = new System.Drawing.Size(694, 39);
        txtElGamalSecondComponent.TabIndex = 5;
        txtElGamalSecondComponent.Text = "136";
        // 
        // lblElGamalDecryptedMessage
        // 
        lblElGamalDecryptedMessage.AutoSize = true;
        lblElGamalDecryptedMessage.Location = new System.Drawing.Point(24, 215);
        lblElGamalDecryptedMessage.Name = "lblElGamalDecryptedMessage";
        lblElGamalDecryptedMessage.Size = new System.Drawing.Size(371, 32);
        lblElGamalDecryptedMessage.TabIndex = 6;
        lblElGamalDecryptedMessage.Text = "Восстановленное сообщение M";
        // 
        // txtElGamalDecryptedMessage
        // 
        txtElGamalDecryptedMessage.Location = new System.Drawing.Point(436, 211);
        txtElGamalDecryptedMessage.Name = "txtElGamalDecryptedMessage";
        txtElGamalDecryptedMessage.ReadOnly = true;
        txtElGamalDecryptedMessage.Size = new System.Drawing.Size(694, 39);
        txtElGamalDecryptedMessage.TabIndex = 7;
        // 
        // btnElGamalEncrypt
        // 
        btnElGamalEncrypt.Location = new System.Drawing.Point(24, 285);
        btnElGamalEncrypt.Name = "btnElGamalEncrypt";
        btnElGamalEncrypt.Size = new System.Drawing.Size(190, 48);
        btnElGamalEncrypt.TabIndex = 8;
        btnElGamalEncrypt.Text = "Зашифровать";
        btnElGamalEncrypt.UseVisualStyleBackColor = true;
        // 
        // btnElGamalDecrypt
        // 
        btnElGamalDecrypt.Location = new System.Drawing.Point(230, 285);
        btnElGamalDecrypt.Name = "btnElGamalDecrypt";
        btnElGamalDecrypt.Size = new System.Drawing.Size(200, 48);
        btnElGamalDecrypt.TabIndex = 9;
        btnElGamalDecrypt.Text = "Расшифровать";
        btnElGamalDecrypt.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1247, 902);
        Controls.Add(tabMain);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Лабораторная работа №5 - Диффи-Хеллман и Эль-Гамаль";
        tabMain.ResumeLayout(false);
        tabPrimitiveRoots.ResumeLayout(false);
        grpRootSearch.ResumeLayout(false);
        grpRootSearch.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudRootCount).EndInit();
        grpSafePrime.ResumeLayout(false);
        grpSafePrime.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudSafePrimeBitCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudSafePrimeIterations).EndInit();
        tabDiffieHellman.ResumeLayout(false);
        grpDhParameters.ResumeLayout(false);
        grpDhParameters.PerformLayout();
        grpDhResults.ResumeLayout(false);
        grpDhResults.PerformLayout();
        tabElGamal.ResumeLayout(false);
        grpElGamalParameters.ResumeLayout(false);
        grpElGamalParameters.PerformLayout();
        grpElGamalOperation.ResumeLayout(false);
        grpElGamalOperation.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabMain;
    private TabPage tabPrimitiveRoots;
    private GroupBox grpRootSearch;
    private Label lblRootModulus;
    private TextBox txtRootModulus;
    private Label lblRootCount;
    private System.Windows.Forms.NumericUpDown nudRootCount;
    private System.Windows.Forms.Button btnCheckRootExistence;
    private System.Windows.Forms.Button btnFindRoots;
    private TextBox txtRootSearchResult;
    private GroupBox grpSafePrime;
    private System.Windows.Forms.Label lblSafePrimeBitCount;
    private System.Windows.Forms.NumericUpDown nudSafePrimeBitCount;
    private System.Windows.Forms.Label lblSafePrimeIterations;
    private System.Windows.Forms.NumericUpDown nudSafePrimeIterations;
    private System.Windows.Forms.Button btnGenerateSafePrime;
    private Label lblSafePrimeP;
    private TextBox txtSafePrimeP;
    private Label lblSafePrimeN;
    private System.Windows.Forms.TextBox txtSafePrimeN;
    private Label lblSafePrimeRoot;
    private System.Windows.Forms.TextBox txtSafePrimeRoot;
    private Label lblSafePrimeStatus;
    private TextBox txtSafePrimeStatus;
    private TabPage tabDiffieHellman;
    private GroupBox grpDhParameters;
    private Label lblDhModulus;
    private TextBox txtDhModulus;
    private Label lblDhPrimitiveRoot;
    private TextBox txtDhPrimitiveRoot;
    private Label lblDhAliceSecret;
    private System.Windows.Forms.TextBox txtDhAliceSecret;
    private Label lblDhBobSecret;
    private TextBox txtDhBobSecret;
    private Button btnDhCalculate;
    private GroupBox grpDhResults;
    private Label lblDhAlicePublic;
    private System.Windows.Forms.TextBox txtDhAlicePublic;
    private Label lblDhBobPublic;
    private System.Windows.Forms.TextBox txtDhBobPublic;
    private Label lblDhAliceSharedKey;
    private System.Windows.Forms.TextBox txtDhAliceSharedKey;
    private Label lblDhBobSharedKey;
    private System.Windows.Forms.TextBox txtDhBobSharedKey;
    private Label lblDhStatus;
    private TextBox txtDhStatus;
    private TabPage tabElGamal;
    private GroupBox grpElGamalParameters;
    private Label lblElGamalModulus;
    private System.Windows.Forms.TextBox txtElGamalModulus;
    private Label lblElGamalPrimitiveRoot;
    private System.Windows.Forms.TextBox txtElGamalPrimitiveRoot;
    private Label lblElGamalSecret;
    private System.Windows.Forms.TextBox txtElGamalSecret;
    private Label lblElGamalPublicKey;
    private System.Windows.Forms.TextBox txtElGamalPublicKey;
    private Label lblElGamalSessionKey;
    private System.Windows.Forms.TextBox txtElGamalSessionKey;
    private System.Windows.Forms.Button btnElGamalCalculatePublicKey;
    private System.Windows.Forms.Button btnElGamalGenerateSessionKey;
    private GroupBox grpElGamalOperation;
    private Label lblElGamalMessage;
    private System.Windows.Forms.TextBox txtElGamalMessage;
    private Label lblElGamalFirstComponent;
    private System.Windows.Forms.TextBox txtElGamalFirstComponent;
    private Label lblElGamalSecondComponent;
    private System.Windows.Forms.TextBox txtElGamalSecondComponent;
    private Label lblElGamalDecryptedMessage;
    private System.Windows.Forms.TextBox txtElGamalDecryptedMessage;
    private Button btnElGamalEncrypt;
    private Button btnElGamalDecrypt;
}
