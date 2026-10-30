namespace lab1;

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
        tabMain = new System.Windows.Forms.TabControl();
        tabAffine = new System.Windows.Forms.TabPage();
        btnClearAffine = new System.Windows.Forms.Button();
        btnDecryptAffine = new System.Windows.Forms.Button();
        btnEncryptAffine = new System.Windows.Forms.Button();
        grpAffineResult = new System.Windows.Forms.GroupBox();
        btnSaveAffineResult = new System.Windows.Forms.Button();
        txtAffineResult = new System.Windows.Forms.TextBox();
        grpAffineInput = new System.Windows.Forms.GroupBox();
        btnOpenAffineInput = new System.Windows.Forms.Button();
        txtAffineInputPath = new System.Windows.Forms.TextBox();
        txtAffineInput = new System.Windows.Forms.TextBox();
        grpAffineParameters = new System.Windows.Forms.GroupBox();
        nudAffineB = new System.Windows.Forms.NumericUpDown();
        lblAffineB = new System.Windows.Forms.Label();
        nudAffineA = new System.Windows.Forms.NumericUpDown();
        lblAffineA = new System.Windows.Forms.Label();
        tabVigenere = new System.Windows.Forms.TabPage();
        btnClearVigenere = new System.Windows.Forms.Button();
        btnDecryptVigenere = new System.Windows.Forms.Button();
        btnEncryptVigenere = new System.Windows.Forms.Button();
        grpVigenereResult = new System.Windows.Forms.GroupBox();
        btnSaveVigenereResult = new System.Windows.Forms.Button();
        txtVigenereResult = new System.Windows.Forms.TextBox();
        grpVigenereInput = new System.Windows.Forms.GroupBox();
        btnOpenVigenereInput = new System.Windows.Forms.Button();
        txtVigenereInputPath = new System.Windows.Forms.TextBox();
        txtVigenereInput = new System.Windows.Forms.TextBox();
        grpVigenereParameters = new System.Windows.Forms.GroupBox();
        txtVigenereKey = new System.Windows.Forms.TextBox();
        lblVigenereKey = new System.Windows.Forms.Label();
        tabNato = new System.Windows.Forms.TabPage();
        btnClearNato = new System.Windows.Forms.Button();
        btnDecodeNato = new System.Windows.Forms.Button();
        btnEncodeNato = new System.Windows.Forms.Button();
        grpNatoResult = new System.Windows.Forms.GroupBox();
        btnSaveNatoResult = new System.Windows.Forms.Button();
        txtNatoResult = new System.Windows.Forms.TextBox();
        grpNatoInput = new System.Windows.Forms.GroupBox();
        btnOpenNatoInput = new System.Windows.Forms.Button();
        txtNatoInputPath = new System.Windows.Forms.TextBox();
        txtNatoInput = new System.Windows.Forms.TextBox();
        tabRotor = new System.Windows.Forms.TabPage();
        btnClearRotor = new System.Windows.Forms.Button();
        btnDecryptRotor = new System.Windows.Forms.Button();
        btnEncryptRotor = new System.Windows.Forms.Button();
        grpRotorResult = new System.Windows.Forms.GroupBox();
        btnSaveRotorResult = new System.Windows.Forms.Button();
        txtRotorResult = new System.Windows.Forms.TextBox();
        grpRotorInput = new System.Windows.Forms.GroupBox();
        btnOpenRotorInput = new System.Windows.Forms.Button();
        txtRotorInputPath = new System.Windows.Forms.TextBox();
        txtRotorInput = new System.Windows.Forms.TextBox();
        grpRotorParameters = new System.Windows.Forms.GroupBox();
        nudRotorStep = new System.Windows.Forms.NumericUpDown();
        lblRotorStep = new System.Windows.Forms.Label();
        nudRotorStartPosition = new System.Windows.Forms.NumericUpDown();
        lblRotorStartPosition = new System.Windows.Forms.Label();
        txtRotorPermutation = new System.Windows.Forms.TextBox();
        lblRotorPermutation = new System.Windows.Forms.Label();
        tabCryptoanalysis = new System.Windows.Forms.TabPage();
        grpAffineFrequencyAnalysis = new System.Windows.Forms.GroupBox();
        txtFrequencyAnalysisResult = new System.Windows.Forms.TextBox();
        btnCalculateFrequencies = new System.Windows.Forms.Button();
        grpRotorKnownPlaintextAttack = new System.Windows.Forms.GroupBox();
        lblMaxRotorShift = new System.Windows.Forms.Label();
        txtKnownCiphertext = new System.Windows.Forms.TextBox();
        lblKnownCiphertext = new System.Windows.Forms.Label();
        txtKnownPlaintext = new System.Windows.Forms.TextBox();
        lblKnownPlaintext = new System.Windows.Forms.Label();
        nudMaxRotorShift = new System.Windows.Forms.NumericUpDown();
        btnFindRotorState = new System.Windows.Forms.Button();
        txtRotorAttackResult = new System.Windows.Forms.TextBox();
        grpAffineBruteForce = new System.Windows.Forms.GroupBox();
        btnBruteForceAffine = new System.Windows.Forms.Button();
        btnLoadAffineCiphertext = new System.Windows.Forms.Button();
        txtAffineBruteForceResult = new System.Windows.Forms.TextBox();
        ofdAffineInput = new System.Windows.Forms.OpenFileDialog();
        sfdAffineResult = new System.Windows.Forms.SaveFileDialog();
        ofdVigenereInput = new System.Windows.Forms.OpenFileDialog();
        sfdVigenereResult = new System.Windows.Forms.SaveFileDialog();
        ofdNatoInput = new System.Windows.Forms.OpenFileDialog();
        sfdNatoResult = new System.Windows.Forms.SaveFileDialog();
        ofdRotorInput = new System.Windows.Forms.OpenFileDialog();
        sfdRotorResult = new System.Windows.Forms.SaveFileDialog();
        ofdFrequencySource = new System.Windows.Forms.OpenFileDialog();
        tabMain.SuspendLayout();
        tabAffine.SuspendLayout();
        grpAffineResult.SuspendLayout();
        grpAffineInput.SuspendLayout();
        grpAffineParameters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudAffineB).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudAffineA).BeginInit();
        tabVigenere.SuspendLayout();
        grpVigenereResult.SuspendLayout();
        grpVigenereInput.SuspendLayout();
        grpVigenereParameters.SuspendLayout();
        tabNato.SuspendLayout();
        grpNatoResult.SuspendLayout();
        grpNatoInput.SuspendLayout();
        tabRotor.SuspendLayout();
        grpRotorResult.SuspendLayout();
        grpRotorInput.SuspendLayout();
        grpRotorParameters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudRotorStep).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudRotorStartPosition).BeginInit();
        tabCryptoanalysis.SuspendLayout();
        grpAffineFrequencyAnalysis.SuspendLayout();
        grpRotorKnownPlaintextAttack.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudMaxRotorShift).BeginInit();
        grpAffineBruteForce.SuspendLayout();
        SuspendLayout();
        // 
        // tabMain
        // 
        tabMain.Controls.Add(tabAffine);
        tabMain.Controls.Add(tabVigenere);
        tabMain.Controls.Add(tabNato);
        tabMain.Controls.Add(tabRotor);
        tabMain.Controls.Add(tabCryptoanalysis);
        tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tabMain.Location = new System.Drawing.Point(0, 0);
        tabMain.Name = "tabMain";
        tabMain.SelectedIndex = 0;
        tabMain.Size = new System.Drawing.Size(1255, 943);
        tabMain.TabIndex = 0;
        // 
        // tabAffine
        // 
        tabAffine.Controls.Add(btnClearAffine);
        tabAffine.Controls.Add(btnDecryptAffine);
        tabAffine.Controls.Add(btnEncryptAffine);
        tabAffine.Controls.Add(grpAffineResult);
        tabAffine.Controls.Add(grpAffineInput);
        tabAffine.Controls.Add(grpAffineParameters);
        tabAffine.Location = new System.Drawing.Point(8, 46);
        tabAffine.Name = "tabAffine";
        tabAffine.Padding = new System.Windows.Forms.Padding(3);
        tabAffine.Size = new System.Drawing.Size(1239, 889);
        tabAffine.TabIndex = 0;
        tabAffine.Text = "Аффинный";
        tabAffine.UseVisualStyleBackColor = true;
        // 
        // btnClearAffine
        // 
        btnClearAffine.Location = new System.Drawing.Point(779, 793);
        btnClearAffine.Name = "btnClearAffine";
        btnClearAffine.Size = new System.Drawing.Size(318, 65);
        btnClearAffine.TabIndex = 5;
        btnClearAffine.Text = "Очистить";
        btnClearAffine.UseVisualStyleBackColor = true;
        // 
        // btnDecryptAffine
        // 
        btnDecryptAffine.Location = new System.Drawing.Point(455, 793);
        btnDecryptAffine.Name = "btnDecryptAffine";
        btnDecryptAffine.Size = new System.Drawing.Size(318, 65);
        btnDecryptAffine.TabIndex = 4;
        btnDecryptAffine.Text = "Дешифровать";
        btnDecryptAffine.UseVisualStyleBackColor = true;
        // 
        // btnEncryptAffine
        // 
        btnEncryptAffine.Location = new System.Drawing.Point(131, 793);
        btnEncryptAffine.Name = "btnEncryptAffine";
        btnEncryptAffine.Size = new System.Drawing.Size(318, 65);
        btnEncryptAffine.TabIndex = 3;
        btnEncryptAffine.Text = "Зашифровать";
        btnEncryptAffine.UseVisualStyleBackColor = true;
        // 
        // grpAffineResult
        // 
        grpAffineResult.Controls.Add(btnSaveAffineResult);
        grpAffineResult.Controls.Add(txtAffineResult);
        grpAffineResult.Dock = System.Windows.Forms.DockStyle.Right;
        grpAffineResult.Location = new System.Drawing.Point(616, 160);
        grpAffineResult.MaximumSize = new System.Drawing.Size(620, 600);
        grpAffineResult.Name = "grpAffineResult";
        grpAffineResult.Size = new System.Drawing.Size(620, 600);
        grpAffineResult.TabIndex = 2;
        grpAffineResult.TabStop = false;
        grpAffineResult.Text = "Результат";
        // 
        // btnSaveAffineResult
        // 
        btnSaveAffineResult.Location = new System.Drawing.Point(23, 443);
        btnSaveAffineResult.Name = "btnSaveAffineResult";
        btnSaveAffineResult.Size = new System.Drawing.Size(574, 47);
        btnSaveAffineResult.TabIndex = 3;
        btnSaveAffineResult.Text = "Сохранить...";
        btnSaveAffineResult.UseVisualStyleBackColor = true;
        // 
        // txtAffineResult
        // 
        txtAffineResult.Location = new System.Drawing.Point(23, 54);
        txtAffineResult.Multiline = true;
        txtAffineResult.Name = "txtAffineResult";
        txtAffineResult.ReadOnly = true;
        txtAffineResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtAffineResult.Size = new System.Drawing.Size(574, 375);
        txtAffineResult.TabIndex = 1;
        // 
        // grpAffineInput
        // 
        grpAffineInput.Controls.Add(btnOpenAffineInput);
        grpAffineInput.Controls.Add(txtAffineInputPath);
        grpAffineInput.Controls.Add(txtAffineInput);
        grpAffineInput.Dock = System.Windows.Forms.DockStyle.Left;
        grpAffineInput.Location = new System.Drawing.Point(3, 160);
        grpAffineInput.MaximumSize = new System.Drawing.Size(600, 600);
        grpAffineInput.Name = "grpAffineInput";
        grpAffineInput.Size = new System.Drawing.Size(600, 600);
        grpAffineInput.TabIndex = 1;
        grpAffineInput.TabStop = false;
        grpAffineInput.Text = "Исходный текст";
        // 
        // btnOpenAffineInput
        // 
        btnOpenAffineInput.Location = new System.Drawing.Point(22, 492);
        btnOpenAffineInput.Name = "btnOpenAffineInput";
        btnOpenAffineInput.Size = new System.Drawing.Size(578, 47);
        btnOpenAffineInput.TabIndex = 2;
        btnOpenAffineInput.Text = "Открыть...";
        btnOpenAffineInput.UseVisualStyleBackColor = true;
        // 
        // txtAffineInputPath
        // 
        txtAffineInputPath.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtAffineInputPath.Location = new System.Drawing.Point(17, 443);
        txtAffineInputPath.Name = "txtAffineInputPath";
        txtAffineInputPath.ReadOnly = true;
        txtAffineInputPath.Size = new System.Drawing.Size(579, 43);
        txtAffineInputPath.TabIndex = 1;
        txtAffineInputPath.Text = "Файл не выбран";
        // 
        // txtAffineInput
        // 
        txtAffineInput.Location = new System.Drawing.Point(17, 54);
        txtAffineInput.Multiline = true;
        txtAffineInput.Name = "txtAffineInput";
        txtAffineInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtAffineInput.Size = new System.Drawing.Size(577, 375);
        txtAffineInput.TabIndex = 0;
        // 
        // grpAffineParameters
        // 
        grpAffineParameters.Controls.Add(nudAffineB);
        grpAffineParameters.Controls.Add(lblAffineB);
        grpAffineParameters.Controls.Add(nudAffineA);
        grpAffineParameters.Controls.Add(lblAffineA);
        grpAffineParameters.Dock = System.Windows.Forms.DockStyle.Top;
        grpAffineParameters.Location = new System.Drawing.Point(3, 3);
        grpAffineParameters.Name = "grpAffineParameters";
        grpAffineParameters.Size = new System.Drawing.Size(1233, 157);
        grpAffineParameters.TabIndex = 0;
        grpAffineParameters.TabStop = false;
        grpAffineParameters.Text = "Аффинный шифр: параметры";
        // 
        // nudAffineB
        // 
        nudAffineB.Location = new System.Drawing.Point(776, 68);
        nudAffineB.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        nudAffineB.Name = "nudAffineB";
        nudAffineB.Size = new System.Drawing.Size(181, 39);
        nudAffineB.TabIndex = 3;
        nudAffineB.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // lblAffineB
        // 
        lblAffineB.Location = new System.Drawing.Point(641, 67);
        lblAffineB.Margin = new System.Windows.Forms.Padding(0);
        lblAffineB.Name = "lblAffineB";
        lblAffineB.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        lblAffineB.Size = new System.Drawing.Size(136, 40);
        lblAffineB.TabIndex = 2;
        lblAffineB.Text = "Сдвиг b:";
        // 
        // nudAffineA
        // 
        nudAffineA.Location = new System.Drawing.Point(430, 68);
        nudAffineA.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        nudAffineA.Name = "nudAffineA";
        nudAffineA.Size = new System.Drawing.Size(181, 39);
        nudAffineA.TabIndex = 1;
        nudAffineA.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // lblAffineA
        // 
        lblAffineA.Location = new System.Drawing.Point(232, 67);
        lblAffineA.Margin = new System.Windows.Forms.Padding(0);
        lblAffineA.Name = "lblAffineA";
        lblAffineA.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        lblAffineA.Size = new System.Drawing.Size(199, 40);
        lblAffineA.TabIndex = 0;
        lblAffineA.Text = "Множитель a:";
        // 
        // tabVigenere
        // 
        tabVigenere.Controls.Add(btnClearVigenere);
        tabVigenere.Controls.Add(btnDecryptVigenere);
        tabVigenere.Controls.Add(btnEncryptVigenere);
        tabVigenere.Controls.Add(grpVigenereResult);
        tabVigenere.Controls.Add(grpVigenereInput);
        tabVigenere.Controls.Add(grpVigenereParameters);
        tabVigenere.Location = new System.Drawing.Point(8, 46);
        tabVigenere.Name = "tabVigenere";
        tabVigenere.Padding = new System.Windows.Forms.Padding(3);
        tabVigenere.Size = new System.Drawing.Size(1239, 889);
        tabVigenere.TabIndex = 1;
        tabVigenere.Text = "Виженера";
        tabVigenere.UseVisualStyleBackColor = true;
        // 
        // btnClearVigenere
        // 
        btnClearVigenere.Location = new System.Drawing.Point(779, 807);
        btnClearVigenere.Name = "btnClearVigenere";
        btnClearVigenere.Size = new System.Drawing.Size(318, 65);
        btnClearVigenere.TabIndex = 11;
        btnClearVigenere.Text = "Очистить";
        btnClearVigenere.UseVisualStyleBackColor = true;
        // 
        // btnDecryptVigenere
        // 
        btnDecryptVigenere.Location = new System.Drawing.Point(455, 807);
        btnDecryptVigenere.Name = "btnDecryptVigenere";
        btnDecryptVigenere.Size = new System.Drawing.Size(318, 65);
        btnDecryptVigenere.TabIndex = 10;
        btnDecryptVigenere.Text = "Дешифровать";
        btnDecryptVigenere.UseVisualStyleBackColor = true;
        // 
        // btnEncryptVigenere
        // 
        btnEncryptVigenere.Location = new System.Drawing.Point(131, 807);
        btnEncryptVigenere.Name = "btnEncryptVigenere";
        btnEncryptVigenere.Size = new System.Drawing.Size(318, 65);
        btnEncryptVigenere.TabIndex = 9;
        btnEncryptVigenere.Text = "Зашифровать";
        btnEncryptVigenere.UseVisualStyleBackColor = true;
        // 
        // grpVigenereResult
        // 
        grpVigenereResult.Controls.Add(btnSaveVigenereResult);
        grpVigenereResult.Controls.Add(txtVigenereResult);
        grpVigenereResult.Dock = System.Windows.Forms.DockStyle.Right;
        grpVigenereResult.Location = new System.Drawing.Point(616, 160);
        grpVigenereResult.MaximumSize = new System.Drawing.Size(620, 600);
        grpVigenereResult.Name = "grpVigenereResult";
        grpVigenereResult.Size = new System.Drawing.Size(620, 600);
        grpVigenereResult.TabIndex = 8;
        grpVigenereResult.TabStop = false;
        grpVigenereResult.Text = "Результат";
        // 
        // btnSaveVigenereResult
        // 
        btnSaveVigenereResult.Location = new System.Drawing.Point(23, 443);
        btnSaveVigenereResult.Name = "btnSaveVigenereResult";
        btnSaveVigenereResult.Size = new System.Drawing.Size(574, 47);
        btnSaveVigenereResult.TabIndex = 3;
        btnSaveVigenereResult.Text = "Сохранить...";
        btnSaveVigenereResult.UseVisualStyleBackColor = true;
        // 
        // txtVigenereResult
        // 
        txtVigenereResult.Location = new System.Drawing.Point(23, 54);
        txtVigenereResult.Multiline = true;
        txtVigenereResult.Name = "txtVigenereResult";
        txtVigenereResult.ReadOnly = true;
        txtVigenereResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtVigenereResult.Size = new System.Drawing.Size(574, 375);
        txtVigenereResult.TabIndex = 1;
        // 
        // grpVigenereInput
        // 
        grpVigenereInput.Controls.Add(btnOpenVigenereInput);
        grpVigenereInput.Controls.Add(txtVigenereInputPath);
        grpVigenereInput.Controls.Add(txtVigenereInput);
        grpVigenereInput.Dock = System.Windows.Forms.DockStyle.Left;
        grpVigenereInput.Location = new System.Drawing.Point(3, 160);
        grpVigenereInput.MaximumSize = new System.Drawing.Size(600, 600);
        grpVigenereInput.Name = "grpVigenereInput";
        grpVigenereInput.Size = new System.Drawing.Size(600, 600);
        grpVigenereInput.TabIndex = 7;
        grpVigenereInput.TabStop = false;
        grpVigenereInput.Text = "Исходный текст";
        // 
        // btnOpenVigenereInput
        // 
        btnOpenVigenereInput.Location = new System.Drawing.Point(22, 492);
        btnOpenVigenereInput.Name = "btnOpenVigenereInput";
        btnOpenVigenereInput.Size = new System.Drawing.Size(578, 47);
        btnOpenVigenereInput.TabIndex = 2;
        btnOpenVigenereInput.Text = "Открыть...";
        btnOpenVigenereInput.UseVisualStyleBackColor = true;
        // 
        // txtVigenereInputPath
        // 
        txtVigenereInputPath.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtVigenereInputPath.Location = new System.Drawing.Point(17, 443);
        txtVigenereInputPath.Name = "txtVigenereInputPath";
        txtVigenereInputPath.ReadOnly = true;
        txtVigenereInputPath.Size = new System.Drawing.Size(579, 43);
        txtVigenereInputPath.TabIndex = 1;
        txtVigenereInputPath.Text = "Файл не выбран";
        // 
        // txtVigenereInput
        // 
        txtVigenereInput.Location = new System.Drawing.Point(17, 54);
        txtVigenereInput.Multiline = true;
        txtVigenereInput.Name = "txtVigenereInput";
        txtVigenereInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtVigenereInput.Size = new System.Drawing.Size(577, 375);
        txtVigenereInput.TabIndex = 0;
        // 
        // grpVigenereParameters
        // 
        grpVigenereParameters.Controls.Add(txtVigenereKey);
        grpVigenereParameters.Controls.Add(lblVigenereKey);
        grpVigenereParameters.Dock = System.Windows.Forms.DockStyle.Top;
        grpVigenereParameters.Location = new System.Drawing.Point(3, 3);
        grpVigenereParameters.Name = "grpVigenereParameters";
        grpVigenereParameters.Size = new System.Drawing.Size(1233, 157);
        grpVigenereParameters.TabIndex = 6;
        grpVigenereParameters.TabStop = false;
        grpVigenereParameters.Text = "Шифр Виженера: параметры";
        // 
        // txtVigenereKey
        // 
        txtVigenereKey.Location = new System.Drawing.Point(302, 68);
        txtVigenereKey.Name = "txtVigenereKey";
        txtVigenereKey.Size = new System.Drawing.Size(729, 39);
        txtVigenereKey.TabIndex = 1;
        // 
        // lblVigenereKey
        // 
        lblVigenereKey.Location = new System.Drawing.Point(81, 67);
        lblVigenereKey.Margin = new System.Windows.Forms.Padding(0);
        lblVigenereKey.Name = "lblVigenereKey";
        lblVigenereKey.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        lblVigenereKey.Size = new System.Drawing.Size(218, 40);
        lblVigenereKey.TabIndex = 0;
        lblVigenereKey.Text = "Ключевое слово:";
        // 
        // tabNato
        // 
        tabNato.Controls.Add(btnClearNato);
        tabNato.Controls.Add(btnDecodeNato);
        tabNato.Controls.Add(btnEncodeNato);
        tabNato.Controls.Add(grpNatoResult);
        tabNato.Controls.Add(grpNatoInput);
        tabNato.Location = new System.Drawing.Point(8, 46);
        tabNato.Name = "tabNato";
        tabNato.Size = new System.Drawing.Size(1239, 889);
        tabNato.TabIndex = 2;
        tabNato.Text = "НАТО";
        tabNato.UseVisualStyleBackColor = true;
        // 
        // btnClearNato
        // 
        btnClearNato.Location = new System.Drawing.Point(777, 634);
        btnClearNato.Name = "btnClearNato";
        btnClearNato.Size = new System.Drawing.Size(318, 65);
        btnClearNato.TabIndex = 14;
        btnClearNato.Text = "Очистить";
        btnClearNato.UseVisualStyleBackColor = true;
        // 
        // btnDecodeNato
        // 
        btnDecodeNato.Location = new System.Drawing.Point(453, 634);
        btnDecodeNato.Name = "btnDecodeNato";
        btnDecodeNato.Size = new System.Drawing.Size(318, 65);
        btnDecodeNato.TabIndex = 13;
        btnDecodeNato.Text = "Дешифровать";
        btnDecodeNato.UseVisualStyleBackColor = true;
        // 
        // btnEncodeNato
        // 
        btnEncodeNato.Location = new System.Drawing.Point(129, 634);
        btnEncodeNato.Name = "btnEncodeNato";
        btnEncodeNato.Size = new System.Drawing.Size(318, 65);
        btnEncodeNato.TabIndex = 12;
        btnEncodeNato.Text = "Зашифровать";
        btnEncodeNato.UseVisualStyleBackColor = true;
        // 
        // grpNatoResult
        // 
        grpNatoResult.Controls.Add(btnSaveNatoResult);
        grpNatoResult.Controls.Add(txtNatoResult);
        grpNatoResult.Dock = System.Windows.Forms.DockStyle.Right;
        grpNatoResult.Location = new System.Drawing.Point(619, 0);
        grpNatoResult.MaximumSize = new System.Drawing.Size(620, 600);
        grpNatoResult.Name = "grpNatoResult";
        grpNatoResult.Size = new System.Drawing.Size(620, 600);
        grpNatoResult.TabIndex = 9;
        grpNatoResult.TabStop = false;
        grpNatoResult.Text = "Результат";
        // 
        // btnSaveNatoResult
        // 
        btnSaveNatoResult.Location = new System.Drawing.Point(23, 443);
        btnSaveNatoResult.Name = "btnSaveNatoResult";
        btnSaveNatoResult.Size = new System.Drawing.Size(574, 47);
        btnSaveNatoResult.TabIndex = 3;
        btnSaveNatoResult.Text = "Сохранить...";
        btnSaveNatoResult.UseVisualStyleBackColor = true;
        // 
        // txtNatoResult
        // 
        txtNatoResult.Location = new System.Drawing.Point(23, 54);
        txtNatoResult.Multiline = true;
        txtNatoResult.Name = "txtNatoResult";
        txtNatoResult.ReadOnly = true;
        txtNatoResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtNatoResult.Size = new System.Drawing.Size(574, 375);
        txtNatoResult.TabIndex = 1;
        // 
        // grpNatoInput
        // 
        grpNatoInput.Controls.Add(btnOpenNatoInput);
        grpNatoInput.Controls.Add(txtNatoInputPath);
        grpNatoInput.Controls.Add(txtNatoInput);
        grpNatoInput.Dock = System.Windows.Forms.DockStyle.Left;
        grpNatoInput.Location = new System.Drawing.Point(0, 0);
        grpNatoInput.MaximumSize = new System.Drawing.Size(600, 600);
        grpNatoInput.Name = "grpNatoInput";
        grpNatoInput.Size = new System.Drawing.Size(600, 600);
        grpNatoInput.TabIndex = 8;
        grpNatoInput.TabStop = false;
        grpNatoInput.Text = "Исходный текст";
        // 
        // btnOpenNatoInput
        // 
        btnOpenNatoInput.Location = new System.Drawing.Point(22, 492);
        btnOpenNatoInput.Name = "btnOpenNatoInput";
        btnOpenNatoInput.Size = new System.Drawing.Size(578, 47);
        btnOpenNatoInput.TabIndex = 2;
        btnOpenNatoInput.Text = "Открыть...";
        btnOpenNatoInput.UseVisualStyleBackColor = true;
        // 
        // txtNatoInputPath
        // 
        txtNatoInputPath.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtNatoInputPath.Location = new System.Drawing.Point(17, 443);
        txtNatoInputPath.Name = "txtNatoInputPath";
        txtNatoInputPath.ReadOnly = true;
        txtNatoInputPath.Size = new System.Drawing.Size(579, 43);
        txtNatoInputPath.TabIndex = 1;
        txtNatoInputPath.Text = "Файл не выбран";
        // 
        // txtNatoInput
        // 
        txtNatoInput.Location = new System.Drawing.Point(17, 54);
        txtNatoInput.Multiline = true;
        txtNatoInput.Name = "txtNatoInput";
        txtNatoInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtNatoInput.Size = new System.Drawing.Size(577, 375);
        txtNatoInput.TabIndex = 0;
        // 
        // tabRotor
        // 
        tabRotor.Controls.Add(btnClearRotor);
        tabRotor.Controls.Add(btnDecryptRotor);
        tabRotor.Controls.Add(btnEncryptRotor);
        tabRotor.Controls.Add(grpRotorResult);
        tabRotor.Controls.Add(grpRotorInput);
        tabRotor.Controls.Add(grpRotorParameters);
        tabRotor.Location = new System.Drawing.Point(8, 46);
        tabRotor.Name = "tabRotor";
        tabRotor.Size = new System.Drawing.Size(1239, 889);
        tabRotor.TabIndex = 3;
        tabRotor.Text = "Роторный";
        tabRotor.UseVisualStyleBackColor = true;
        // 
        // btnClearRotor
        // 
        btnClearRotor.Location = new System.Drawing.Point(779, 808);
        btnClearRotor.Name = "btnClearRotor";
        btnClearRotor.Size = new System.Drawing.Size(318, 65);
        btnClearRotor.TabIndex = 11;
        btnClearRotor.Text = "Очистить";
        btnClearRotor.UseVisualStyleBackColor = true;
        // 
        // btnDecryptRotor
        // 
        btnDecryptRotor.Location = new System.Drawing.Point(455, 808);
        btnDecryptRotor.Name = "btnDecryptRotor";
        btnDecryptRotor.Size = new System.Drawing.Size(318, 65);
        btnDecryptRotor.TabIndex = 10;
        btnDecryptRotor.Text = "Дешифровать";
        btnDecryptRotor.UseVisualStyleBackColor = true;
        // 
        // btnEncryptRotor
        // 
        btnEncryptRotor.Location = new System.Drawing.Point(131, 808);
        btnEncryptRotor.Name = "btnEncryptRotor";
        btnEncryptRotor.Size = new System.Drawing.Size(318, 65);
        btnEncryptRotor.TabIndex = 9;
        btnEncryptRotor.Text = "Зашифровать";
        btnEncryptRotor.UseVisualStyleBackColor = true;
        // 
        // grpRotorResult
        // 
        grpRotorResult.Controls.Add(btnSaveRotorResult);
        grpRotorResult.Controls.Add(txtRotorResult);
        grpRotorResult.Dock = System.Windows.Forms.DockStyle.Right;
        grpRotorResult.Location = new System.Drawing.Point(619, 157);
        grpRotorResult.MaximumSize = new System.Drawing.Size(620, 600);
        grpRotorResult.Name = "grpRotorResult";
        grpRotorResult.Size = new System.Drawing.Size(620, 600);
        grpRotorResult.TabIndex = 8;
        grpRotorResult.TabStop = false;
        grpRotorResult.Text = "Результат";
        // 
        // btnSaveRotorResult
        // 
        btnSaveRotorResult.Location = new System.Drawing.Point(23, 443);
        btnSaveRotorResult.Name = "btnSaveRotorResult";
        btnSaveRotorResult.Size = new System.Drawing.Size(574, 47);
        btnSaveRotorResult.TabIndex = 3;
        btnSaveRotorResult.Text = "Сохранить...";
        btnSaveRotorResult.UseVisualStyleBackColor = true;
        // 
        // txtRotorResult
        // 
        txtRotorResult.Location = new System.Drawing.Point(23, 54);
        txtRotorResult.Multiline = true;
        txtRotorResult.Name = "txtRotorResult";
        txtRotorResult.ReadOnly = true;
        txtRotorResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtRotorResult.Size = new System.Drawing.Size(574, 375);
        txtRotorResult.TabIndex = 1;
        // 
        // grpRotorInput
        // 
        grpRotorInput.Controls.Add(btnOpenRotorInput);
        grpRotorInput.Controls.Add(txtRotorInputPath);
        grpRotorInput.Controls.Add(txtRotorInput);
        grpRotorInput.Dock = System.Windows.Forms.DockStyle.Left;
        grpRotorInput.Location = new System.Drawing.Point(0, 157);
        grpRotorInput.MaximumSize = new System.Drawing.Size(600, 600);
        grpRotorInput.Name = "grpRotorInput";
        grpRotorInput.Size = new System.Drawing.Size(600, 600);
        grpRotorInput.TabIndex = 7;
        grpRotorInput.TabStop = false;
        grpRotorInput.Text = "Исходный текст";
        // 
        // btnOpenRotorInput
        // 
        btnOpenRotorInput.Location = new System.Drawing.Point(22, 492);
        btnOpenRotorInput.Name = "btnOpenRotorInput";
        btnOpenRotorInput.Size = new System.Drawing.Size(578, 47);
        btnOpenRotorInput.TabIndex = 2;
        btnOpenRotorInput.Text = "Открыть...";
        btnOpenRotorInput.UseVisualStyleBackColor = true;
        // 
        // txtRotorInputPath
        // 
        txtRotorInputPath.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtRotorInputPath.Location = new System.Drawing.Point(17, 443);
        txtRotorInputPath.Name = "txtRotorInputPath";
        txtRotorInputPath.ReadOnly = true;
        txtRotorInputPath.Size = new System.Drawing.Size(579, 43);
        txtRotorInputPath.TabIndex = 1;
        txtRotorInputPath.Text = "Файл не выбран";
        // 
        // txtRotorInput
        // 
        txtRotorInput.Location = new System.Drawing.Point(17, 54);
        txtRotorInput.Multiline = true;
        txtRotorInput.Name = "txtRotorInput";
        txtRotorInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtRotorInput.Size = new System.Drawing.Size(577, 375);
        txtRotorInput.TabIndex = 0;
        // 
        // grpRotorParameters
        // 
        grpRotorParameters.Controls.Add(nudRotorStep);
        grpRotorParameters.Controls.Add(lblRotorStep);
        grpRotorParameters.Controls.Add(nudRotorStartPosition);
        grpRotorParameters.Controls.Add(lblRotorStartPosition);
        grpRotorParameters.Controls.Add(txtRotorPermutation);
        grpRotorParameters.Controls.Add(lblRotorPermutation);
        grpRotorParameters.Dock = System.Windows.Forms.DockStyle.Top;
        grpRotorParameters.Location = new System.Drawing.Point(0, 0);
        grpRotorParameters.Name = "grpRotorParameters";
        grpRotorParameters.Size = new System.Drawing.Size(1239, 157);
        grpRotorParameters.TabIndex = 6;
        grpRotorParameters.TabStop = false;
        grpRotorParameters.Text = "Роторный шифр: параметры";
        // 
        // nudRotorStep
        // 
        nudRotorStep.Location = new System.Drawing.Point(783, 96);
        nudRotorStep.Maximum = new decimal(new int[] { 35, 0, 0, 0 });
        nudRotorStep.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudRotorStep.Name = "nudRotorStep";
        nudRotorStep.Size = new System.Drawing.Size(181, 39);
        nudRotorStep.TabIndex = 3;
        nudRotorStep.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblRotorStep
        // 
        lblRotorStep.Location = new System.Drawing.Point(615, 95);
        lblRotorStep.Margin = new System.Windows.Forms.Padding(0);
        lblRotorStep.Name = "lblRotorStep";
        lblRotorStep.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        lblRotorStep.Size = new System.Drawing.Size(165, 40);
        lblRotorStep.TabIndex = 2;
        lblRotorStep.Text = "Шаг ротора:";
        // 
        // nudRotorStartPosition
        // 
        nudRotorStartPosition.Location = new System.Drawing.Point(418, 96);
        nudRotorStartPosition.Maximum = new decimal(new int[] { 35, 0, 0, 0 });
        nudRotorStartPosition.Name = "nudRotorStartPosition";
        nudRotorStartPosition.Size = new System.Drawing.Size(181, 39);
        nudRotorStartPosition.TabIndex = 1;
        // 
        // lblRotorStartPosition
        // 
        lblRotorStartPosition.Location = new System.Drawing.Point(157, 95);
        lblRotorStartPosition.Margin = new System.Windows.Forms.Padding(0);
        lblRotorStartPosition.Name = "lblRotorStartPosition";
        lblRotorStartPosition.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        lblRotorStartPosition.Size = new System.Drawing.Size(258, 40);
        lblRotorStartPosition.TabIndex = 0;
        lblRotorStartPosition.Text = "Начальная позиция:";
        // 
        // txtRotorPermutation
        // 
        txtRotorPermutation.Location = new System.Drawing.Point(418, 45);
        txtRotorPermutation.Name = "txtRotorPermutation";
        txtRotorPermutation.Size = new System.Drawing.Size(646, 39);
        txtRotorPermutation.TabIndex = 5;
        txtRotorPermutation.Text = "ёйцукенгшщзхъфывапролджэячсмитьбю_,.";
        // 
        // lblRotorPermutation
        // 
        lblRotorPermutation.Location = new System.Drawing.Point(195, 48);
        lblRotorPermutation.Name = "lblRotorPermutation";
        lblRotorPermutation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        lblRotorPermutation.Size = new System.Drawing.Size(196, 40);
        lblRotorPermutation.TabIndex = 4;
        lblRotorPermutation.Text = "Перестановка:";
        // 
        // tabCryptoanalysis
        // 
        tabCryptoanalysis.Controls.Add(grpAffineFrequencyAnalysis);
        tabCryptoanalysis.Controls.Add(grpRotorKnownPlaintextAttack);
        tabCryptoanalysis.Controls.Add(grpAffineBruteForce);
        tabCryptoanalysis.Location = new System.Drawing.Point(8, 46);
        tabCryptoanalysis.Name = "tabCryptoanalysis";
        tabCryptoanalysis.Size = new System.Drawing.Size(1239, 889);
        tabCryptoanalysis.TabIndex = 4;
        tabCryptoanalysis.Text = "Криптоанализ";
        tabCryptoanalysis.UseVisualStyleBackColor = true;
        // 
        // grpAffineFrequencyAnalysis
        // 
        grpAffineFrequencyAnalysis.Controls.Add(txtFrequencyAnalysisResult);
        grpAffineFrequencyAnalysis.Controls.Add(btnCalculateFrequencies);
        grpAffineFrequencyAnalysis.Location = new System.Drawing.Point(3, 456);
        grpAffineFrequencyAnalysis.Name = "grpAffineFrequencyAnalysis";
        grpAffineFrequencyAnalysis.Size = new System.Drawing.Size(1232, 429);
        grpAffineFrequencyAnalysis.TabIndex = 10;
        grpAffineFrequencyAnalysis.TabStop = false;
        grpAffineFrequencyAnalysis.Text = "Частотный криптоанализ аффинного шифра";
        // 
        // txtFrequencyAnalysisResult
        // 
        txtFrequencyAnalysisResult.Location = new System.Drawing.Point(12, 128);
        txtFrequencyAnalysisResult.Multiline = true;
        txtFrequencyAnalysisResult.Name = "txtFrequencyAnalysisResult";
        txtFrequencyAnalysisResult.Size = new System.Drawing.Size(1213, 286);
        txtFrequencyAnalysisResult.TabIndex = 8;
        // 
        // btnCalculateFrequencies
        // 
        btnCalculateFrequencies.Location = new System.Drawing.Point(12, 58);
        btnCalculateFrequencies.Name = "btnCalculateFrequencies";
        btnCalculateFrequencies.Size = new System.Drawing.Size(359, 47);
        btnCalculateFrequencies.TabIndex = 5;
        btnCalculateFrequencies.Text = "Рассчитать частоты";
        btnCalculateFrequencies.UseVisualStyleBackColor = true;
        // 
        // grpRotorKnownPlaintextAttack
        // 
        grpRotorKnownPlaintextAttack.Controls.Add(lblMaxRotorShift);
        grpRotorKnownPlaintextAttack.Controls.Add(txtKnownCiphertext);
        grpRotorKnownPlaintextAttack.Controls.Add(lblKnownCiphertext);
        grpRotorKnownPlaintextAttack.Controls.Add(txtKnownPlaintext);
        grpRotorKnownPlaintextAttack.Controls.Add(lblKnownPlaintext);
        grpRotorKnownPlaintextAttack.Controls.Add(nudMaxRotorShift);
        grpRotorKnownPlaintextAttack.Controls.Add(btnFindRotorState);
        grpRotorKnownPlaintextAttack.Controls.Add(txtRotorAttackResult);
        grpRotorKnownPlaintextAttack.Dock = System.Windows.Forms.DockStyle.Right;
        grpRotorKnownPlaintextAttack.Location = new System.Drawing.Point(619, 0);
        grpRotorKnownPlaintextAttack.MaximumSize = new System.Drawing.Size(620, 450);
        grpRotorKnownPlaintextAttack.Name = "grpRotorKnownPlaintextAttack";
        grpRotorKnownPlaintextAttack.Size = new System.Drawing.Size(620, 450);
        grpRotorKnownPlaintextAttack.TabIndex = 9;
        grpRotorKnownPlaintextAttack.TabStop = false;
        grpRotorKnownPlaintextAttack.Text = "Атака на роторный шифр";
        // 
        // lblMaxRotorShift
        // 
        lblMaxRotorShift.Location = new System.Drawing.Point(-10, 156);
        lblMaxRotorShift.Margin = new System.Windows.Forms.Padding(0);
        lblMaxRotorShift.Name = "lblMaxRotorShift";
        lblMaxRotorShift.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        lblMaxRotorShift.Size = new System.Drawing.Size(283, 40);
        lblMaxRotorShift.TabIndex = 9;
        lblMaxRotorShift.Text = "Максимальный сдвиг";
        lblMaxRotorShift.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // txtKnownCiphertext
        // 
        txtKnownCiphertext.Location = new System.Drawing.Point(280, 106);
        txtKnownCiphertext.Name = "txtKnownCiphertext";
        txtKnownCiphertext.Size = new System.Drawing.Size(329, 39);
        txtKnownCiphertext.TabIndex = 8;
        // 
        // lblKnownCiphertext
        // 
        lblKnownCiphertext.Location = new System.Drawing.Point(-6, 105);
        lblKnownCiphertext.Margin = new System.Windows.Forms.Padding(0);
        lblKnownCiphertext.Name = "lblKnownCiphertext";
        lblKnownCiphertext.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        lblKnownCiphertext.Size = new System.Drawing.Size(283, 40);
        lblKnownCiphertext.TabIndex = 7;
        lblKnownCiphertext.Text = "Фрагмент шифртекста:";
        lblKnownCiphertext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // txtKnownPlaintext
        // 
        txtKnownPlaintext.Location = new System.Drawing.Point(265, 55);
        txtKnownPlaintext.Name = "txtKnownPlaintext";
        txtKnownPlaintext.Size = new System.Drawing.Size(344, 39);
        txtKnownPlaintext.TabIndex = 6;
        // 
        // lblKnownPlaintext
        // 
        lblKnownPlaintext.Location = new System.Drawing.Point(0, 54);
        lblKnownPlaintext.Margin = new System.Windows.Forms.Padding(0);
        lblKnownPlaintext.Name = "lblKnownPlaintext";
        lblKnownPlaintext.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        lblKnownPlaintext.Size = new System.Drawing.Size(257, 40);
        lblKnownPlaintext.TabIndex = 5;
        lblKnownPlaintext.Text = "Открытый фрагмент:";
        // 
        // nudMaxRotorShift
        // 
        nudMaxRotorShift.Location = new System.Drawing.Point(18, 196);
        nudMaxRotorShift.Name = "nudMaxRotorShift";
        nudMaxRotorShift.Size = new System.Drawing.Size(323, 39);
        nudMaxRotorShift.TabIndex = 4;
        // 
        // btnFindRotorState
        // 
        btnFindRotorState.Location = new System.Drawing.Point(359, 191);
        btnFindRotorState.Name = "btnFindRotorState";
        btnFindRotorState.Size = new System.Drawing.Size(250, 47);
        btnFindRotorState.TabIndex = 3;
        btnFindRotorState.Text = "Найти";
        btnFindRotorState.UseVisualStyleBackColor = true;
        // 
        // txtRotorAttackResult
        // 
        txtRotorAttackResult.Location = new System.Drawing.Point(18, 254);
        txtRotorAttackResult.Multiline = true;
        txtRotorAttackResult.Name = "txtRotorAttackResult";
        txtRotorAttackResult.Size = new System.Drawing.Size(591, 175);
        txtRotorAttackResult.TabIndex = 1;
        // 
        // grpAffineBruteForce
        // 
        grpAffineBruteForce.Controls.Add(btnBruteForceAffine);
        grpAffineBruteForce.Controls.Add(btnLoadAffineCiphertext);
        grpAffineBruteForce.Controls.Add(txtAffineBruteForceResult);
        grpAffineBruteForce.Dock = System.Windows.Forms.DockStyle.Left;
        grpAffineBruteForce.Location = new System.Drawing.Point(0, 0);
        grpAffineBruteForce.MaximumSize = new System.Drawing.Size(600, 450);
        grpAffineBruteForce.Name = "grpAffineBruteForce";
        grpAffineBruteForce.Size = new System.Drawing.Size(600, 450);
        grpAffineBruteForce.TabIndex = 8;
        grpAffineBruteForce.TabStop = false;
        grpAffineBruteForce.Text = "Перебор ключей аффинного шифра";
        // 
        // btnBruteForceAffine
        // 
        btnBruteForceAffine.Location = new System.Drawing.Point(15, 318);
        btnBruteForceAffine.Name = "btnBruteForceAffine";
        btnBruteForceAffine.Size = new System.Drawing.Size(574, 47);
        btnBruteForceAffine.TabIndex = 4;
        btnBruteForceAffine.Text = "Перебрать ключи";
        btnBruteForceAffine.UseVisualStyleBackColor = true;
        // 
        // btnLoadAffineCiphertext
        // 
        btnLoadAffineCiphertext.Location = new System.Drawing.Point(15, 382);
        btnLoadAffineCiphertext.Name = "btnLoadAffineCiphertext";
        btnLoadAffineCiphertext.Size = new System.Drawing.Size(574, 47);
        btnLoadAffineCiphertext.TabIndex = 2;
        btnLoadAffineCiphertext.Text = "Открыть...";
        btnLoadAffineCiphertext.UseVisualStyleBackColor = true;
        // 
        // txtAffineBruteForceResult
        // 
        txtAffineBruteForceResult.Location = new System.Drawing.Point(15, 54);
        txtAffineBruteForceResult.Multiline = true;
        txtAffineBruteForceResult.Name = "txtAffineBruteForceResult";
        txtAffineBruteForceResult.Size = new System.Drawing.Size(574, 244);
        txtAffineBruteForceResult.TabIndex = 0;
        // 
        // ofdAffineInput
        // 
        ofdAffineInput.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        // 
        // sfdAffineResult
        // 
        sfdAffineResult.FileName = "result.txt";
        sfdAffineResult.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        // 
        // ofdVigenereInput
        // 
        ofdVigenereInput.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        // 
        // sfdVigenereResult
        // 
        sfdVigenereResult.FileName = "vigenere-result.txt";
        sfdVigenereResult.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        // 
        // ofdNatoInput
        // 
        ofdNatoInput.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        // 
        // sfdNatoResult
        // 
        sfdNatoResult.FileName = "nato-result.txt";
        sfdNatoResult.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        // 
        // ofdRotorInput
        // 
        ofdRotorInput.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        // 
        // sfdRotorResult
        // 
        sfdRotorResult.FileName = "rotor-result.txt";
        sfdRotorResult.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1255, 943);
        Controls.Add(tabMain);
        Text = "Лабораторная работа №1";
        tabMain.ResumeLayout(false);
        tabAffine.ResumeLayout(false);
        grpAffineResult.ResumeLayout(false);
        grpAffineResult.PerformLayout();
        grpAffineInput.ResumeLayout(false);
        grpAffineInput.PerformLayout();
        grpAffineParameters.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nudAffineB).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudAffineA).EndInit();
        tabVigenere.ResumeLayout(false);
        grpVigenereResult.ResumeLayout(false);
        grpVigenereResult.PerformLayout();
        grpVigenereInput.ResumeLayout(false);
        grpVigenereInput.PerformLayout();
        grpVigenereParameters.ResumeLayout(false);
        grpVigenereParameters.PerformLayout();
        tabNato.ResumeLayout(false);
        grpNatoResult.ResumeLayout(false);
        grpNatoResult.PerformLayout();
        grpNatoInput.ResumeLayout(false);
        grpNatoInput.PerformLayout();
        tabRotor.ResumeLayout(false);
        grpRotorResult.ResumeLayout(false);
        grpRotorResult.PerformLayout();
        grpRotorInput.ResumeLayout(false);
        grpRotorInput.PerformLayout();
        grpRotorParameters.ResumeLayout(false);
        grpRotorParameters.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudRotorStep).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudRotorStartPosition).EndInit();
        tabCryptoanalysis.ResumeLayout(false);
        grpAffineFrequencyAnalysis.ResumeLayout(false);
        grpAffineFrequencyAnalysis.PerformLayout();
        grpRotorKnownPlaintextAttack.ResumeLayout(false);
        grpRotorKnownPlaintextAttack.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudMaxRotorShift).EndInit();
        grpAffineBruteForce.ResumeLayout(false);
        grpAffineBruteForce.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.OpenFileDialog ofdFrequencySource;

    private System.Windows.Forms.TextBox txtFrequencyAnalysisResult;

    private System.Windows.Forms.Button btnCalculateFrequencies;

    private System.Windows.Forms.GroupBox grpAffineFrequencyAnalysis;

    private System.Windows.Forms.Label lblMaxRotorShift;

    private System.Windows.Forms.TextBox txtKnownCiphertext;

    private System.Windows.Forms.Label lblKnownCiphertext;

    private System.Windows.Forms.TextBox txtKnownPlaintext;
    private System.Windows.Forms.Label lblKnownPlaintext;

    private System.Windows.Forms.NumericUpDown nudMaxRotorShift;

    private System.Windows.Forms.Button btnBruteForceAffine;

    private System.Windows.Forms.OpenFileDialog ofdVigenereInput;
    private System.Windows.Forms.SaveFileDialog sfdVigenereResult;
    private System.Windows.Forms.OpenFileDialog ofdNatoInput;
    private System.Windows.Forms.SaveFileDialog sfdNatoResult;
    private System.Windows.Forms.OpenFileDialog ofdRotorInput;
    private System.Windows.Forms.SaveFileDialog sfdRotorResult;

    private System.Windows.Forms.GroupBox grpAffineBruteForce;
    private System.Windows.Forms.Button btnLoadAffineCiphertext;
    private System.Windows.Forms.TextBox txtAffineBruteForceResult;
    private System.Windows.Forms.GroupBox grpRotorKnownPlaintextAttack;
    private System.Windows.Forms.Button btnFindRotorState;
    private System.Windows.Forms.TextBox txtRotorAttackResult;

    private System.Windows.Forms.Button btnClearRotor;
    private System.Windows.Forms.Button btnDecryptRotor;
    private System.Windows.Forms.Button btnEncryptRotor;
    private System.Windows.Forms.GroupBox grpRotorResult;
    private System.Windows.Forms.Button btnSaveRotorResult;
    private System.Windows.Forms.TextBox txtRotorResult;
    private System.Windows.Forms.GroupBox grpRotorInput;
    private System.Windows.Forms.Button btnOpenRotorInput;
    private System.Windows.Forms.TextBox txtRotorInputPath;
    private System.Windows.Forms.TextBox txtRotorInput;
    private System.Windows.Forms.GroupBox grpRotorParameters;
    private System.Windows.Forms.NumericUpDown nudRotorStep;
    private System.Windows.Forms.Label lblRotorStep;
    private System.Windows.Forms.NumericUpDown nudRotorStartPosition;
    private System.Windows.Forms.Label lblRotorStartPosition;
    private System.Windows.Forms.TextBox txtRotorPermutation;
    private System.Windows.Forms.Label lblRotorPermutation;

    private System.Windows.Forms.GroupBox grpNatoInput;
    private System.Windows.Forms.Button btnOpenNatoInput;
    private System.Windows.Forms.TextBox txtNatoInputPath;
    private System.Windows.Forms.TextBox txtNatoInput;
    private System.Windows.Forms.GroupBox grpNatoResult;
    private System.Windows.Forms.Button btnSaveNatoResult;
    private System.Windows.Forms.TextBox txtNatoResult;
    private System.Windows.Forms.Button btnClearNato;
    private System.Windows.Forms.Button btnDecodeNato;
    private System.Windows.Forms.Button btnEncodeNato;

    private System.Windows.Forms.TextBox txtVigenereKey;

    private System.Windows.Forms.Button btnClearVigenere;
    private System.Windows.Forms.Button btnDecryptVigenere;
    private System.Windows.Forms.Button btnEncryptVigenere;
    private System.Windows.Forms.GroupBox grpVigenereResult;
    private System.Windows.Forms.Button btnSaveVigenereResult;
    private System.Windows.Forms.TextBox txtVigenereResult;
    private System.Windows.Forms.GroupBox grpVigenereInput;
    private System.Windows.Forms.Button btnOpenVigenereInput;
    private System.Windows.Forms.TextBox txtVigenereInputPath;
    private System.Windows.Forms.TextBox txtVigenereInput;
    private System.Windows.Forms.GroupBox grpVigenereParameters;
    private System.Windows.Forms.Label lblVigenereKey;

    private System.Windows.Forms.Button btnClearAffine;

    private System.Windows.Forms.Button btnDecryptAffine;

    private System.Windows.Forms.Button btnEncryptAffine;

    private System.Windows.Forms.Button btnSaveAffineResult;

    private System.Windows.Forms.TextBox txtAffineResult;

    private System.Windows.Forms.Button btnOpenAffineInput;

    private System.Windows.Forms.TextBox txtAffineInputPath;

    private System.Windows.Forms.OpenFileDialog ofdAffineInput;
    private System.Windows.Forms.SaveFileDialog sfdAffineResult;

    private System.Windows.Forms.TextBox txtAffineInput;

    private System.Windows.Forms.GroupBox grpAffineResult;

    private System.Windows.Forms.GroupBox grpAffineInput;

    private System.Windows.Forms.NumericUpDown nudAffineB;

    private System.Windows.Forms.Label lblAffineB;

    private System.Windows.Forms.NumericUpDown nudAffineA;

    private System.Windows.Forms.Label lblAffineA;

    private System.Windows.Forms.GroupBox grpAffineParameters;

    private System.Windows.Forms.TabPage tabCryptoanalysis;

    private System.Windows.Forms.TabPage tabRotor;

    private System.Windows.Forms.TabPage tabNato;

    private System.Windows.Forms.TabControl tabMain;
    private System.Windows.Forms.TabPage tabAffine;
    private System.Windows.Forms.TabPage tabVigenere;

    #endregion
}
