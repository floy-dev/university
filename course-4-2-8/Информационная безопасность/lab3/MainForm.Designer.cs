namespace Lab3;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tabMain = new System.Windows.Forms.TabControl();
        tabAesBlock = new System.Windows.Forms.TabPage();
        grpAesBlockParameters = new System.Windows.Forms.GroupBox();
        lblAesBlockKey = new System.Windows.Forms.Label();
        txtAesBlockKey = new System.Windows.Forms.TextBox();
        lblAesBlockKeyFormat = new System.Windows.Forms.Label();
        cmbAesBlockKeyFormat = new System.Windows.Forms.ComboBox();
        lblAesBlockInputFormat = new System.Windows.Forms.Label();
        cmbAesBlockInputFormat = new System.Windows.Forms.ComboBox();
        lblAesBlockOutputFormat = new System.Windows.Forms.Label();
        cmbAesBlockOutputFormat = new System.Windows.Forms.ComboBox();
        btnGenerateAesBlockKey = new System.Windows.Forms.Button();
        splitAesBlockEditors = new System.Windows.Forms.SplitContainer();
        grpAesBlockInput = new System.Windows.Forms.GroupBox();
        txtAesBlockInput = new System.Windows.Forms.TextBox();
        grpAesBlockResult = new System.Windows.Forms.GroupBox();
        txtAesBlockResult = new System.Windows.Forms.TextBox();
        btnAesBlockEncrypt = new System.Windows.Forms.Button();
        btnAesBlockDecrypt = new System.Windows.Forms.Button();
        btnUseAesBlockResult = new System.Windows.Forms.Button();
        tabPadding = new System.Windows.Forms.TabPage();
        grpPaddingParameters = new System.Windows.Forms.GroupBox();
        lblPaddingInputFormat = new System.Windows.Forms.Label();
        cmbPaddingInputFormat = new System.Windows.Forms.ComboBox();
        lblPaddingOutputFormat = new System.Windows.Forms.Label();
        cmbPaddingOutputFormat = new System.Windows.Forms.ComboBox();
        splitPaddingEditors = new System.Windows.Forms.SplitContainer();
        grpPaddingInput = new System.Windows.Forms.GroupBox();
        txtPaddingInput = new System.Windows.Forms.TextBox();
        grpPaddingResult = new System.Windows.Forms.GroupBox();
        txtPaddingResult = new System.Windows.Forms.TextBox();
        btnAddPadding = new System.Windows.Forms.Button();
        btnRemovePadding = new System.Windows.Forms.Button();
        btnUsePaddingResult = new System.Windows.Forms.Button();
        tabEcb = new System.Windows.Forms.TabPage();
        grpEcbParameters = new System.Windows.Forms.GroupBox();
        lblEcbKey = new System.Windows.Forms.Label();
        txtEcbKey = new System.Windows.Forms.TextBox();
        lblEcbKeyFormat = new System.Windows.Forms.Label();
        cmbEcbKeyFormat = new System.Windows.Forms.ComboBox();
        lblEcbInputFormat = new System.Windows.Forms.Label();
        cmbEcbInputFormat = new System.Windows.Forms.ComboBox();
        lblEcbOutputFormat = new System.Windows.Forms.Label();
        cmbEcbOutputFormat = new System.Windows.Forms.ComboBox();
        btnGenerateEcbKey = new System.Windows.Forms.Button();
        lblEcbInputPath = new System.Windows.Forms.Label();
        txtEcbInputPath = new System.Windows.Forms.TextBox();
        splitEcbEditors = new System.Windows.Forms.SplitContainer();
        grpEcbInput = new System.Windows.Forms.GroupBox();
        txtEcbInput = new System.Windows.Forms.TextBox();
        grpEcbResult = new System.Windows.Forms.GroupBox();
        txtEcbResult = new System.Windows.Forms.TextBox();
        btnEcbEncrypt = new System.Windows.Forms.Button();
        btnEcbDecrypt = new System.Windows.Forms.Button();
        btnUseEcbResult = new System.Windows.Forms.Button();
        btnOpenEcbInput = new System.Windows.Forms.Button();
        btnSaveEcbResult = new System.Windows.Forms.Button();
        tabCfb = new System.Windows.Forms.TabPage();
        grpCfbParameters = new System.Windows.Forms.GroupBox();
        lblCfbKey = new System.Windows.Forms.Label();
        txtCfbKey = new System.Windows.Forms.TextBox();
        lblCfbKeyFormat = new System.Windows.Forms.Label();
        cmbCfbKeyFormat = new System.Windows.Forms.ComboBox();
        btnGenerateCfbKey = new System.Windows.Forms.Button();
        lblCfbInitializationVector = new System.Windows.Forms.Label();
        txtCfbInitializationVector = new System.Windows.Forms.TextBox();
        lblCfbVectorFormat = new System.Windows.Forms.Label();
        cmbCfbVectorFormat = new System.Windows.Forms.ComboBox();
        btnGenerateCfbVector = new System.Windows.Forms.Button();
        lblCfbInputFormat = new System.Windows.Forms.Label();
        cmbCfbInputFormat = new System.Windows.Forms.ComboBox();
        lblCfbOutputFormat = new System.Windows.Forms.Label();
        cmbCfbOutputFormat = new System.Windows.Forms.ComboBox();
        lblCfbInputPath = new System.Windows.Forms.Label();
        txtCfbInputPath = new System.Windows.Forms.TextBox();
        splitCfbEditors = new System.Windows.Forms.SplitContainer();
        grpCfbInput = new System.Windows.Forms.GroupBox();
        txtCfbInput = new System.Windows.Forms.TextBox();
        grpCfbResult = new System.Windows.Forms.GroupBox();
        txtCfbResult = new System.Windows.Forms.TextBox();
        btnCfbEncrypt = new System.Windows.Forms.Button();
        btnCfbDecrypt = new System.Windows.Forms.Button();
        btnUseCfbResult = new System.Windows.Forms.Button();
        btnOpenCfbInput = new System.Windows.Forms.Button();
        btnSaveCfbResult = new System.Windows.Forms.Button();
        tabMain.SuspendLayout();
        tabAesBlock.SuspendLayout();
        grpAesBlockParameters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitAesBlockEditors).BeginInit();
        splitAesBlockEditors.Panel1.SuspendLayout();
        splitAesBlockEditors.Panel2.SuspendLayout();
        splitAesBlockEditors.SuspendLayout();
        grpAesBlockInput.SuspendLayout();
        grpAesBlockResult.SuspendLayout();
        tabPadding.SuspendLayout();
        grpPaddingParameters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitPaddingEditors).BeginInit();
        splitPaddingEditors.Panel1.SuspendLayout();
        splitPaddingEditors.Panel2.SuspendLayout();
        splitPaddingEditors.SuspendLayout();
        grpPaddingInput.SuspendLayout();
        grpPaddingResult.SuspendLayout();
        tabEcb.SuspendLayout();
        grpEcbParameters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitEcbEditors).BeginInit();
        splitEcbEditors.Panel1.SuspendLayout();
        splitEcbEditors.Panel2.SuspendLayout();
        splitEcbEditors.SuspendLayout();
        grpEcbInput.SuspendLayout();
        grpEcbResult.SuspendLayout();
        tabCfb.SuspendLayout();
        grpCfbParameters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitCfbEditors).BeginInit();
        splitCfbEditors.Panel1.SuspendLayout();
        splitCfbEditors.Panel2.SuspendLayout();
        splitCfbEditors.SuspendLayout();
        grpCfbInput.SuspendLayout();
        grpCfbResult.SuspendLayout();
        SuspendLayout();
        // 
        // tabMain
        // 
        tabMain.Controls.Add(tabAesBlock);
        tabMain.Controls.Add(tabPadding);
        tabMain.Controls.Add(tabEcb);
        tabMain.Controls.Add(tabCfb);
        tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tabMain.Location = new System.Drawing.Point(12, 12);
        tabMain.Name = "tabMain";
        tabMain.SelectedIndex = 0;
        tabMain.Size = new System.Drawing.Size(1223, 878);
        tabMain.TabIndex = 0;
        // 
        // tabAesBlock
        // 
        tabAesBlock.Controls.Add(grpAesBlockParameters);
        tabAesBlock.Controls.Add(splitAesBlockEditors);
        tabAesBlock.Controls.Add(btnAesBlockEncrypt);
        tabAesBlock.Controls.Add(btnAesBlockDecrypt);
        tabAesBlock.Controls.Add(btnUseAesBlockResult);
        tabAesBlock.Location = new System.Drawing.Point(8, 46);
        tabAesBlock.Name = "tabAesBlock";
        tabAesBlock.Padding = new System.Windows.Forms.Padding(12);
        tabAesBlock.Size = new System.Drawing.Size(1207, 824);
        tabAesBlock.TabIndex = 0;
        tabAesBlock.Text = "AES-блок";
        tabAesBlock.UseVisualStyleBackColor = true;
        // 
        // grpAesBlockParameters
        // 
        grpAesBlockParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        grpAesBlockParameters.Controls.Add(lblAesBlockKey);
        grpAesBlockParameters.Controls.Add(txtAesBlockKey);
        grpAesBlockParameters.Controls.Add(lblAesBlockKeyFormat);
        grpAesBlockParameters.Controls.Add(cmbAesBlockKeyFormat);
        grpAesBlockParameters.Controls.Add(lblAesBlockInputFormat);
        grpAesBlockParameters.Controls.Add(cmbAesBlockInputFormat);
        grpAesBlockParameters.Controls.Add(lblAesBlockOutputFormat);
        grpAesBlockParameters.Controls.Add(cmbAesBlockOutputFormat);
        grpAesBlockParameters.Controls.Add(btnGenerateAesBlockKey);
        grpAesBlockParameters.Location = new System.Drawing.Point(12, 12);
        grpAesBlockParameters.Name = "grpAesBlockParameters";
        grpAesBlockParameters.Size = new System.Drawing.Size(1183, 160);
        grpAesBlockParameters.TabIndex = 0;
        grpAesBlockParameters.TabStop = false;
        grpAesBlockParameters.Text = "Параметры блока";
        // 
        // lblAesBlockKey
        // 
        lblAesBlockKey.AutoSize = true;
        lblAesBlockKey.Location = new System.Drawing.Point(16, 36);
        lblAesBlockKey.Name = "lblAesBlockKey";
        lblAesBlockKey.Size = new System.Drawing.Size(206, 32);
        lblAesBlockKey.TabIndex = 0;
        lblAesBlockKey.Text = "Ключ (16 байтов)";
        // 
        // txtAesBlockKey
        // 
        txtAesBlockKey.Location = new System.Drawing.Point(16, 71);
        txtAesBlockKey.Name = "txtAesBlockKey";
        txtAesBlockKey.Size = new System.Drawing.Size(400, 39);
        txtAesBlockKey.TabIndex = 1;
        txtAesBlockKey.Text = "2B7E151628AED2A6ABF7158809CF4F3C";
        // 
        // lblAesBlockKeyFormat
        // 
        lblAesBlockKeyFormat.AutoSize = true;
        lblAesBlockKeyFormat.Location = new System.Drawing.Point(440, 36);
        lblAesBlockKeyFormat.Name = "lblAesBlockKeyFormat";
        lblAesBlockKeyFormat.Size = new System.Drawing.Size(176, 32);
        lblAesBlockKeyFormat.TabIndex = 2;
        lblAesBlockKeyFormat.Text = "Формат ключа";
        // 
        // cmbAesBlockKeyFormat
        // 
        cmbAesBlockKeyFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbAesBlockKeyFormat.FormattingEnabled = true;
        cmbAesBlockKeyFormat.Items.AddRange(new object[] { "UTF-8", "HEX" });
        cmbAesBlockKeyFormat.Location = new System.Drawing.Point(440, 71);
        cmbAesBlockKeyFormat.Name = "cmbAesBlockKeyFormat";
        cmbAesBlockKeyFormat.Size = new System.Drawing.Size(150, 40);
        cmbAesBlockKeyFormat.TabIndex = 3;
        // 
        // lblAesBlockInputFormat
        // 
        lblAesBlockInputFormat.AutoSize = true;
        lblAesBlockInputFormat.Location = new System.Drawing.Point(620, 36);
        lblAesBlockInputFormat.Name = "lblAesBlockInputFormat";
        lblAesBlockInputFormat.Size = new System.Drawing.Size(168, 32);
        lblAesBlockInputFormat.TabIndex = 4;
        lblAesBlockInputFormat.Text = "Формат входа";
        // 
        // cmbAesBlockInputFormat
        // 
        cmbAesBlockInputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbAesBlockInputFormat.FormattingEnabled = true;
        cmbAesBlockInputFormat.Items.AddRange(new object[] { "UTF-8", "HEX" });
        cmbAesBlockInputFormat.Location = new System.Drawing.Point(620, 71);
        cmbAesBlockInputFormat.Name = "cmbAesBlockInputFormat";
        cmbAesBlockInputFormat.Size = new System.Drawing.Size(150, 40);
        cmbAesBlockInputFormat.TabIndex = 5;
        // 
        // lblAesBlockOutputFormat
        // 
        lblAesBlockOutputFormat.AutoSize = true;
        lblAesBlockOutputFormat.Location = new System.Drawing.Point(800, 36);
        lblAesBlockOutputFormat.Name = "lblAesBlockOutputFormat";
        lblAesBlockOutputFormat.Size = new System.Drawing.Size(224, 32);
        lblAesBlockOutputFormat.TabIndex = 6;
        lblAesBlockOutputFormat.Text = "Формат результата";
        // 
        // cmbAesBlockOutputFormat
        // 
        cmbAesBlockOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbAesBlockOutputFormat.FormattingEnabled = true;
        cmbAesBlockOutputFormat.Items.AddRange(new object[] { "UTF-8", "HEX" });
        cmbAesBlockOutputFormat.Location = new System.Drawing.Point(800, 71);
        cmbAesBlockOutputFormat.Name = "cmbAesBlockOutputFormat";
        cmbAesBlockOutputFormat.Size = new System.Drawing.Size(175, 40);
        cmbAesBlockOutputFormat.TabIndex = 7;
        // 
        // btnGenerateAesBlockKey
        // 
        btnGenerateAesBlockKey.Location = new System.Drawing.Point(995, 71);
        btnGenerateAesBlockKey.Name = "btnGenerateAesBlockKey";
        btnGenerateAesBlockKey.Size = new System.Drawing.Size(188, 50);
        btnGenerateAesBlockKey.TabIndex = 8;
        btnGenerateAesBlockKey.Text = "Создать ключ";
        btnGenerateAesBlockKey.UseVisualStyleBackColor = true;
        // 
        // splitAesBlockEditors
        // 
        splitAesBlockEditors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        splitAesBlockEditors.Location = new System.Drawing.Point(12, 184);
        splitAesBlockEditors.Name = "splitAesBlockEditors";
        // 
        // splitAesBlockEditors.Panel1
        // 
        splitAesBlockEditors.Panel1.Controls.Add(grpAesBlockInput);
        // 
        // splitAesBlockEditors.Panel2
        // 
        splitAesBlockEditors.Panel2.Controls.Add(grpAesBlockResult);
        splitAesBlockEditors.Size = new System.Drawing.Size(1183, 559);
        splitAesBlockEditors.SplitterDistance = 584;
        splitAesBlockEditors.TabIndex = 1;
        // 
        // grpAesBlockInput
        // 
        grpAesBlockInput.Controls.Add(txtAesBlockInput);
        grpAesBlockInput.Dock = System.Windows.Forms.DockStyle.Fill;
        grpAesBlockInput.Location = new System.Drawing.Point(0, 0);
        grpAesBlockInput.Name = "grpAesBlockInput";
        grpAesBlockInput.Padding = new System.Windows.Forms.Padding(8);
        grpAesBlockInput.Size = new System.Drawing.Size(584, 559);
        grpAesBlockInput.TabIndex = 0;
        grpAesBlockInput.TabStop = false;
        grpAesBlockInput.Text = "Исходный блок (ровно 16 байтов)";
        // 
        // txtAesBlockInput
        // 
        txtAesBlockInput.Dock = System.Windows.Forms.DockStyle.Fill;
        txtAesBlockInput.Font = new System.Drawing.Font("Consolas", 10F);
        txtAesBlockInput.Location = new System.Drawing.Point(8, 40);
        txtAesBlockInput.Multiline = true;
        txtAesBlockInput.Name = "txtAesBlockInput";
        txtAesBlockInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        txtAesBlockInput.Size = new System.Drawing.Size(568, 511);
        txtAesBlockInput.TabIndex = 0;
        txtAesBlockInput.Text = "6BC1BEE22E409F96E93D7E117393172A";
        txtAesBlockInput.WordWrap = false;
        // 
        // grpAesBlockResult
        // 
        grpAesBlockResult.Controls.Add(txtAesBlockResult);
        grpAesBlockResult.Dock = System.Windows.Forms.DockStyle.Fill;
        grpAesBlockResult.Location = new System.Drawing.Point(0, 0);
        grpAesBlockResult.Name = "grpAesBlockResult";
        grpAesBlockResult.Padding = new System.Windows.Forms.Padding(8);
        grpAesBlockResult.Size = new System.Drawing.Size(595, 559);
        grpAesBlockResult.TabIndex = 0;
        grpAesBlockResult.TabStop = false;
        grpAesBlockResult.Text = "Результат";
        // 
        // txtAesBlockResult
        // 
        txtAesBlockResult.Dock = System.Windows.Forms.DockStyle.Fill;
        txtAesBlockResult.Font = new System.Drawing.Font("Consolas", 10F);
        txtAesBlockResult.Location = new System.Drawing.Point(8, 40);
        txtAesBlockResult.Multiline = true;
        txtAesBlockResult.Name = "txtAesBlockResult";
        txtAesBlockResult.ReadOnly = true;
        txtAesBlockResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        txtAesBlockResult.Size = new System.Drawing.Size(579, 511);
        txtAesBlockResult.TabIndex = 0;
        txtAesBlockResult.WordWrap = false;
        // 
        // btnAesBlockEncrypt
        // 
        btnAesBlockEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnAesBlockEncrypt.Location = new System.Drawing.Point(12, 755);
        btnAesBlockEncrypt.Name = "btnAesBlockEncrypt";
        btnAesBlockEncrypt.Size = new System.Drawing.Size(225, 55);
        btnAesBlockEncrypt.TabIndex = 2;
        btnAesBlockEncrypt.Text = "Зашифровать";
        btnAesBlockEncrypt.UseVisualStyleBackColor = true;
        // 
        // btnAesBlockDecrypt
        // 
        btnAesBlockDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnAesBlockDecrypt.Location = new System.Drawing.Point(245, 755);
        btnAesBlockDecrypt.Name = "btnAesBlockDecrypt";
        btnAesBlockDecrypt.Size = new System.Drawing.Size(230, 55);
        btnAesBlockDecrypt.TabIndex = 3;
        btnAesBlockDecrypt.Text = "Расшифровать";
        btnAesBlockDecrypt.UseVisualStyleBackColor = true;
        // 
        // btnUseAesBlockResult
        // 
        btnUseAesBlockResult.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnUseAesBlockResult.Location = new System.Drawing.Point(932, 754);
        btnUseAesBlockResult.Name = "btnUseAesBlockResult";
        btnUseAesBlockResult.Size = new System.Drawing.Size(245, 55);
        btnUseAesBlockResult.TabIndex = 4;
        btnUseAesBlockResult.Text = "Результат во вход";
        btnUseAesBlockResult.UseVisualStyleBackColor = true;
        // 
        // tabPadding
        // 
        tabPadding.Controls.Add(grpPaddingParameters);
        tabPadding.Controls.Add(splitPaddingEditors);
        tabPadding.Controls.Add(btnAddPadding);
        tabPadding.Controls.Add(btnRemovePadding);
        tabPadding.Controls.Add(btnUsePaddingResult);
        tabPadding.Location = new System.Drawing.Point(8, 46);
        tabPadding.Name = "tabPadding";
        tabPadding.Padding = new System.Windows.Forms.Padding(12);
        tabPadding.Size = new System.Drawing.Size(1207, 824);
        tabPadding.TabIndex = 1;
        tabPadding.Text = "ISO/IEC 7816-4";
        tabPadding.UseVisualStyleBackColor = true;
        // 
        // grpPaddingParameters
        // 
        grpPaddingParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        grpPaddingParameters.Controls.Add(lblPaddingInputFormat);
        grpPaddingParameters.Controls.Add(cmbPaddingInputFormat);
        grpPaddingParameters.Controls.Add(lblPaddingOutputFormat);
        grpPaddingParameters.Controls.Add(cmbPaddingOutputFormat);
        grpPaddingParameters.Location = new System.Drawing.Point(12, 12);
        grpPaddingParameters.Name = "grpPaddingParameters";
        grpPaddingParameters.Size = new System.Drawing.Size(1183, 108);
        grpPaddingParameters.TabIndex = 0;
        grpPaddingParameters.TabStop = false;
        grpPaddingParameters.Text = "ISO/IEC 7816-4: байт 80, затем нулевые байты";
        // 
        // lblPaddingInputFormat
        // 
        lblPaddingInputFormat.AutoSize = true;
        lblPaddingInputFormat.Location = new System.Drawing.Point(16, 39);
        lblPaddingInputFormat.Name = "lblPaddingInputFormat";
        lblPaddingInputFormat.Size = new System.Drawing.Size(168, 32);
        lblPaddingInputFormat.TabIndex = 0;
        lblPaddingInputFormat.Text = "Формат входа";
        // 
        // cmbPaddingInputFormat
        // 
        cmbPaddingInputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbPaddingInputFormat.FormattingEnabled = true;
        cmbPaddingInputFormat.Items.AddRange(new object[] { "UTF-8", "HEX" });
        cmbPaddingInputFormat.Location = new System.Drawing.Point(200, 34);
        cmbPaddingInputFormat.Name = "cmbPaddingInputFormat";
        cmbPaddingInputFormat.Size = new System.Drawing.Size(150, 40);
        cmbPaddingInputFormat.TabIndex = 1;
        // 
        // lblPaddingOutputFormat
        // 
        lblPaddingOutputFormat.AutoSize = true;
        lblPaddingOutputFormat.Location = new System.Drawing.Point(390, 39);
        lblPaddingOutputFormat.Name = "lblPaddingOutputFormat";
        lblPaddingOutputFormat.Size = new System.Drawing.Size(224, 32);
        lblPaddingOutputFormat.TabIndex = 2;
        lblPaddingOutputFormat.Text = "Формат результата";
        // 
        // cmbPaddingOutputFormat
        // 
        cmbPaddingOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbPaddingOutputFormat.FormattingEnabled = true;
        cmbPaddingOutputFormat.Items.AddRange(new object[] { "UTF-8", "HEX" });
        cmbPaddingOutputFormat.Location = new System.Drawing.Point(630, 34);
        cmbPaddingOutputFormat.Name = "cmbPaddingOutputFormat";
        cmbPaddingOutputFormat.Size = new System.Drawing.Size(175, 40);
        cmbPaddingOutputFormat.TabIndex = 3;
        // 
        // splitPaddingEditors
        // 
        splitPaddingEditors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        splitPaddingEditors.Location = new System.Drawing.Point(12, 114);
        splitPaddingEditors.Name = "splitPaddingEditors";
        // 
        // splitPaddingEditors.Panel1
        // 
        splitPaddingEditors.Panel1.Controls.Add(grpPaddingInput);
        // 
        // splitPaddingEditors.Panel2
        // 
        splitPaddingEditors.Panel2.Controls.Add(grpPaddingResult);
        splitPaddingEditors.Size = new System.Drawing.Size(1183, 629);
        splitPaddingEditors.SplitterDistance = 584;
        splitPaddingEditors.TabIndex = 1;
        // 
        // grpPaddingInput
        // 
        grpPaddingInput.Controls.Add(txtPaddingInput);
        grpPaddingInput.Dock = System.Windows.Forms.DockStyle.Fill;
        grpPaddingInput.Location = new System.Drawing.Point(0, 0);
        grpPaddingInput.Name = "grpPaddingInput";
        grpPaddingInput.Padding = new System.Windows.Forms.Padding(8);
        grpPaddingInput.Size = new System.Drawing.Size(584, 629);
        grpPaddingInput.TabIndex = 0;
        grpPaddingInput.TabStop = false;
        grpPaddingInput.Text = "Исходные данные";
        // 
        // txtPaddingInput
        // 
        txtPaddingInput.Dock = System.Windows.Forms.DockStyle.Fill;
        txtPaddingInput.Font = new System.Drawing.Font("Consolas", 10F);
        txtPaddingInput.Location = new System.Drawing.Point(8, 40);
        txtPaddingInput.Multiline = true;
        txtPaddingInput.Name = "txtPaddingInput";
        txtPaddingInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        txtPaddingInput.Size = new System.Drawing.Size(568, 581);
        txtPaddingInput.TabIndex = 0;
        txtPaddingInput.Text = "Пример дополнения";
        txtPaddingInput.WordWrap = false;
        // 
        // grpPaddingResult
        // 
        grpPaddingResult.Controls.Add(txtPaddingResult);
        grpPaddingResult.Dock = System.Windows.Forms.DockStyle.Fill;
        grpPaddingResult.Location = new System.Drawing.Point(0, 0);
        grpPaddingResult.Name = "grpPaddingResult";
        grpPaddingResult.Padding = new System.Windows.Forms.Padding(8);
        grpPaddingResult.Size = new System.Drawing.Size(595, 629);
        grpPaddingResult.TabIndex = 0;
        grpPaddingResult.TabStop = false;
        grpPaddingResult.Text = "Результат";
        // 
        // txtPaddingResult
        // 
        txtPaddingResult.Dock = System.Windows.Forms.DockStyle.Fill;
        txtPaddingResult.Font = new System.Drawing.Font("Consolas", 10F);
        txtPaddingResult.Location = new System.Drawing.Point(8, 40);
        txtPaddingResult.Multiline = true;
        txtPaddingResult.Name = "txtPaddingResult";
        txtPaddingResult.ReadOnly = true;
        txtPaddingResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        txtPaddingResult.Size = new System.Drawing.Size(579, 581);
        txtPaddingResult.TabIndex = 0;
        txtPaddingResult.WordWrap = false;
        // 
        // btnAddPadding
        // 
        btnAddPadding.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnAddPadding.Location = new System.Drawing.Point(12, 755);
        btnAddPadding.Name = "btnAddPadding";
        btnAddPadding.Size = new System.Drawing.Size(287, 55);
        btnAddPadding.TabIndex = 2;
        btnAddPadding.Text = "Добавить дополнение";
        btnAddPadding.UseVisualStyleBackColor = true;
        // 
        // btnRemovePadding
        // 
        btnRemovePadding.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnRemovePadding.Location = new System.Drawing.Point(305, 755);
        btnRemovePadding.Name = "btnRemovePadding";
        btnRemovePadding.Size = new System.Drawing.Size(270, 55);
        btnRemovePadding.TabIndex = 3;
        btnRemovePadding.Text = "Удалить дополнение";
        btnRemovePadding.UseVisualStyleBackColor = true;
        // 
        // btnUsePaddingResult
        // 
        btnUsePaddingResult.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnUsePaddingResult.Location = new System.Drawing.Point(932, 755);
        btnUsePaddingResult.Name = "btnUsePaddingResult";
        btnUsePaddingResult.Size = new System.Drawing.Size(263, 55);
        btnUsePaddingResult.TabIndex = 4;
        btnUsePaddingResult.Text = "Результат во вход";
        btnUsePaddingResult.UseVisualStyleBackColor = true;
        // 
        // tabEcb
        // 
        tabEcb.Controls.Add(grpEcbParameters);
        tabEcb.Controls.Add(splitEcbEditors);
        tabEcb.Controls.Add(btnEcbEncrypt);
        tabEcb.Controls.Add(btnEcbDecrypt);
        tabEcb.Controls.Add(btnUseEcbResult);
        tabEcb.Controls.Add(btnOpenEcbInput);
        tabEcb.Controls.Add(btnSaveEcbResult);
        tabEcb.Location = new System.Drawing.Point(8, 46);
        tabEcb.Name = "tabEcb";
        tabEcb.Padding = new System.Windows.Forms.Padding(12);
        tabEcb.Size = new System.Drawing.Size(1207, 824);
        tabEcb.TabIndex = 2;
        tabEcb.Text = "AES-данные";
        tabEcb.UseVisualStyleBackColor = true;
        // 
        // grpEcbParameters
        // 
        grpEcbParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        grpEcbParameters.Controls.Add(lblEcbKey);
        grpEcbParameters.Controls.Add(txtEcbKey);
        grpEcbParameters.Controls.Add(lblEcbKeyFormat);
        grpEcbParameters.Controls.Add(cmbEcbKeyFormat);
        grpEcbParameters.Controls.Add(lblEcbInputFormat);
        grpEcbParameters.Controls.Add(cmbEcbInputFormat);
        grpEcbParameters.Controls.Add(lblEcbOutputFormat);
        grpEcbParameters.Controls.Add(cmbEcbOutputFormat);
        grpEcbParameters.Controls.Add(btnGenerateEcbKey);
        grpEcbParameters.Controls.Add(lblEcbInputPath);
        grpEcbParameters.Controls.Add(txtEcbInputPath);
        grpEcbParameters.Location = new System.Drawing.Point(12, 12);
        grpEcbParameters.Name = "grpEcbParameters";
        grpEcbParameters.Size = new System.Drawing.Size(1183, 195);
        grpEcbParameters.TabIndex = 0;
        grpEcbParameters.TabStop = false;
        grpEcbParameters.Text = "Параметры AES-128 ECB с дополнением ISO/IEC 7816-4";
        // 
        // lblEcbKey
        // 
        lblEcbKey.AutoSize = true;
        lblEcbKey.Location = new System.Drawing.Point(16, 34);
        lblEcbKey.Name = "lblEcbKey";
        lblEcbKey.Size = new System.Drawing.Size(206, 32);
        lblEcbKey.TabIndex = 0;
        lblEcbKey.Text = "Ключ (16 байтов)";
        // 
        // txtEcbKey
        // 
        txtEcbKey.Location = new System.Drawing.Point(16, 69);
        txtEcbKey.Name = "txtEcbKey";
        txtEcbKey.Size = new System.Drawing.Size(400, 39);
        txtEcbKey.TabIndex = 1;
        txtEcbKey.Text = "2B7E151628AED2A6ABF7158809CF4F3C";
        // 
        // lblEcbKeyFormat
        // 
        lblEcbKeyFormat.AutoSize = true;
        lblEcbKeyFormat.Location = new System.Drawing.Point(440, 34);
        lblEcbKeyFormat.Name = "lblEcbKeyFormat";
        lblEcbKeyFormat.Size = new System.Drawing.Size(176, 32);
        lblEcbKeyFormat.TabIndex = 2;
        lblEcbKeyFormat.Text = "Формат ключа";
        // 
        // cmbEcbKeyFormat
        // 
        cmbEcbKeyFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbEcbKeyFormat.FormattingEnabled = true;
        cmbEcbKeyFormat.Items.AddRange(new object[] { "UTF-8", "HEX" });
        cmbEcbKeyFormat.Location = new System.Drawing.Point(440, 69);
        cmbEcbKeyFormat.Name = "cmbEcbKeyFormat";
        cmbEcbKeyFormat.Size = new System.Drawing.Size(150, 40);
        cmbEcbKeyFormat.TabIndex = 3;
        // 
        // lblEcbInputFormat
        // 
        lblEcbInputFormat.AutoSize = true;
        lblEcbInputFormat.Location = new System.Drawing.Point(620, 34);
        lblEcbInputFormat.Name = "lblEcbInputFormat";
        lblEcbInputFormat.Size = new System.Drawing.Size(168, 32);
        lblEcbInputFormat.TabIndex = 4;
        lblEcbInputFormat.Text = "Формат входа";
        // 
        // cmbEcbInputFormat
        // 
        cmbEcbInputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbEcbInputFormat.FormattingEnabled = true;
        cmbEcbInputFormat.Items.AddRange(new object[] { "UTF-8", "HEX" });
        cmbEcbInputFormat.Location = new System.Drawing.Point(620, 69);
        cmbEcbInputFormat.Name = "cmbEcbInputFormat";
        cmbEcbInputFormat.Size = new System.Drawing.Size(150, 40);
        cmbEcbInputFormat.TabIndex = 5;
        // 
        // lblEcbOutputFormat
        // 
        lblEcbOutputFormat.AutoSize = true;
        lblEcbOutputFormat.Location = new System.Drawing.Point(800, 34);
        lblEcbOutputFormat.Name = "lblEcbOutputFormat";
        lblEcbOutputFormat.Size = new System.Drawing.Size(224, 32);
        lblEcbOutputFormat.TabIndex = 6;
        lblEcbOutputFormat.Text = "Формат результата";
        // 
        // cmbEcbOutputFormat
        // 
        cmbEcbOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbEcbOutputFormat.FormattingEnabled = true;
        cmbEcbOutputFormat.Items.AddRange(new object[] { "UTF-8", "HEX" });
        cmbEcbOutputFormat.Location = new System.Drawing.Point(800, 69);
        cmbEcbOutputFormat.Name = "cmbEcbOutputFormat";
        cmbEcbOutputFormat.Size = new System.Drawing.Size(175, 40);
        cmbEcbOutputFormat.TabIndex = 7;
        // 
        // btnGenerateEcbKey
        // 
        btnGenerateEcbKey.Location = new System.Drawing.Point(995, 62);
        btnGenerateEcbKey.Name = "btnGenerateEcbKey";
        btnGenerateEcbKey.Size = new System.Drawing.Size(185, 50);
        btnGenerateEcbKey.TabIndex = 8;
        btnGenerateEcbKey.Text = "Создать ключ";
        btnGenerateEcbKey.UseVisualStyleBackColor = true;
        // 
        // lblEcbInputPath
        // 
        lblEcbInputPath.AutoSize = true;
        lblEcbInputPath.Location = new System.Drawing.Point(16, 141);
        lblEcbInputPath.Name = "lblEcbInputPath";
        lblEcbInputPath.Size = new System.Drawing.Size(70, 32);
        lblEcbInputPath.TabIndex = 9;
        lblEcbInputPath.Text = "Файл";
        // 
        // txtEcbInputPath
        // 
        txtEcbInputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtEcbInputPath.Location = new System.Drawing.Point(100, 136);
        txtEcbInputPath.Name = "txtEcbInputPath";
        txtEcbInputPath.ReadOnly = true;
        txtEcbInputPath.Size = new System.Drawing.Size(1065, 39);
        txtEcbInputPath.TabIndex = 10;
        txtEcbInputPath.Text = "Файл не выбран";
        // 
        // splitEcbEditors
        // 
        splitEcbEditors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        splitEcbEditors.Location = new System.Drawing.Point(12, 204);
        splitEcbEditors.Name = "splitEcbEditors";
        // 
        // splitEcbEditors.Panel1
        // 
        splitEcbEditors.Panel1.Controls.Add(grpEcbInput);
        // 
        // splitEcbEditors.Panel2
        // 
        splitEcbEditors.Panel2.Controls.Add(grpEcbResult);
        splitEcbEditors.Size = new System.Drawing.Size(1183, 539);
        splitEcbEditors.SplitterDistance = 584;
        splitEcbEditors.TabIndex = 1;
        // 
        // grpEcbInput
        // 
        grpEcbInput.Controls.Add(txtEcbInput);
        grpEcbInput.Dock = System.Windows.Forms.DockStyle.Fill;
        grpEcbInput.Location = new System.Drawing.Point(0, 0);
        grpEcbInput.Name = "grpEcbInput";
        grpEcbInput.Padding = new System.Windows.Forms.Padding(8);
        grpEcbInput.Size = new System.Drawing.Size(584, 539);
        grpEcbInput.TabIndex = 0;
        grpEcbInput.TabStop = false;
        grpEcbInput.Text = "Исходные данные";
        // 
        // txtEcbInput
        // 
        txtEcbInput.Dock = System.Windows.Forms.DockStyle.Fill;
        txtEcbInput.Font = new System.Drawing.Font("Consolas", 10F);
        txtEcbInput.Location = new System.Drawing.Point(8, 40);
        txtEcbInput.Multiline = true;
        txtEcbInput.Name = "txtEcbInput";
        txtEcbInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        txtEcbInput.Size = new System.Drawing.Size(568, 491);
        txtEcbInput.TabIndex = 0;
        txtEcbInput.Text = "Произвольные данные для AES-128";
        txtEcbInput.WordWrap = false;
        // 
        // grpEcbResult
        // 
        grpEcbResult.Controls.Add(txtEcbResult);
        grpEcbResult.Dock = System.Windows.Forms.DockStyle.Fill;
        grpEcbResult.Location = new System.Drawing.Point(0, 0);
        grpEcbResult.Name = "grpEcbResult";
        grpEcbResult.Padding = new System.Windows.Forms.Padding(8);
        grpEcbResult.Size = new System.Drawing.Size(595, 539);
        grpEcbResult.TabIndex = 0;
        grpEcbResult.TabStop = false;
        grpEcbResult.Text = "Результат";
        // 
        // txtEcbResult
        // 
        txtEcbResult.Dock = System.Windows.Forms.DockStyle.Fill;
        txtEcbResult.Font = new System.Drawing.Font("Consolas", 10F);
        txtEcbResult.Location = new System.Drawing.Point(8, 40);
        txtEcbResult.Multiline = true;
        txtEcbResult.Name = "txtEcbResult";
        txtEcbResult.ReadOnly = true;
        txtEcbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        txtEcbResult.Size = new System.Drawing.Size(579, 491);
        txtEcbResult.TabIndex = 0;
        txtEcbResult.WordWrap = false;
        // 
        // btnEcbEncrypt
        // 
        btnEcbEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnEcbEncrypt.Location = new System.Drawing.Point(12, 755);
        btnEcbEncrypt.Name = "btnEcbEncrypt";
        btnEcbEncrypt.Size = new System.Drawing.Size(180, 55);
        btnEcbEncrypt.TabIndex = 2;
        btnEcbEncrypt.Text = "Зашифровать";
        btnEcbEncrypt.UseVisualStyleBackColor = true;
        // 
        // btnEcbDecrypt
        // 
        btnEcbDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnEcbDecrypt.Location = new System.Drawing.Point(200, 755);
        btnEcbDecrypt.Name = "btnEcbDecrypt";
        btnEcbDecrypt.Size = new System.Drawing.Size(190, 55);
        btnEcbDecrypt.TabIndex = 3;
        btnEcbDecrypt.Text = "Расшифровать";
        btnEcbDecrypt.UseVisualStyleBackColor = true;
        // 
        // btnUseEcbResult
        // 
        btnUseEcbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnUseEcbResult.Location = new System.Drawing.Point(950, 755);
        btnUseEcbResult.Name = "btnUseEcbResult";
        btnUseEcbResult.Size = new System.Drawing.Size(245, 55);
        btnUseEcbResult.TabIndex = 6;
        btnUseEcbResult.Text = "Результат во вход";
        btnUseEcbResult.UseVisualStyleBackColor = true;
        // 
        // btnOpenEcbInput
        // 
        btnOpenEcbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnOpenEcbInput.Location = new System.Drawing.Point(406, 755);
        btnOpenEcbInput.Name = "btnOpenEcbInput";
        btnOpenEcbInput.Size = new System.Drawing.Size(180, 55);
        btnOpenEcbInput.TabIndex = 4;
        btnOpenEcbInput.Text = "Открыть файл";
        btnOpenEcbInput.UseVisualStyleBackColor = true;
        // 
        // btnSaveEcbResult
        // 
        btnSaveEcbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnSaveEcbResult.Location = new System.Drawing.Point(594, 755);
        btnSaveEcbResult.Name = "btnSaveEcbResult";
        btnSaveEcbResult.Size = new System.Drawing.Size(220, 55);
        btnSaveEcbResult.TabIndex = 5;
        btnSaveEcbResult.Text = "Сохранить байты";
        btnSaveEcbResult.UseVisualStyleBackColor = true;
        // 
        // tabCfb
        // 
        tabCfb.Controls.Add(grpCfbParameters);
        tabCfb.Controls.Add(splitCfbEditors);
        tabCfb.Controls.Add(btnCfbEncrypt);
        tabCfb.Controls.Add(btnCfbDecrypt);
        tabCfb.Controls.Add(btnUseCfbResult);
        tabCfb.Controls.Add(btnOpenCfbInput);
        tabCfb.Controls.Add(btnSaveCfbResult);
        tabCfb.Location = new System.Drawing.Point(8, 46);
        tabCfb.Name = "tabCfb";
        tabCfb.Padding = new System.Windows.Forms.Padding(12);
        tabCfb.Size = new System.Drawing.Size(1207, 824);
        tabCfb.TabIndex = 3;
        tabCfb.Text = "CFB-128";
        tabCfb.UseVisualStyleBackColor = true;
        // 
        // grpCfbParameters
        // 
        grpCfbParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        grpCfbParameters.Controls.Add(lblCfbKey);
        grpCfbParameters.Controls.Add(txtCfbKey);
        grpCfbParameters.Controls.Add(lblCfbKeyFormat);
        grpCfbParameters.Controls.Add(cmbCfbKeyFormat);
        grpCfbParameters.Controls.Add(btnGenerateCfbKey);
        grpCfbParameters.Controls.Add(lblCfbInitializationVector);
        grpCfbParameters.Controls.Add(txtCfbInitializationVector);
        grpCfbParameters.Controls.Add(lblCfbVectorFormat);
        grpCfbParameters.Controls.Add(cmbCfbVectorFormat);
        grpCfbParameters.Controls.Add(btnGenerateCfbVector);
        grpCfbParameters.Controls.Add(lblCfbInputFormat);
        grpCfbParameters.Controls.Add(cmbCfbInputFormat);
        grpCfbParameters.Controls.Add(lblCfbOutputFormat);
        grpCfbParameters.Controls.Add(cmbCfbOutputFormat);
        grpCfbParameters.Controls.Add(lblCfbInputPath);
        grpCfbParameters.Controls.Add(txtCfbInputPath);
        grpCfbParameters.Location = new System.Drawing.Point(12, 12);
        grpCfbParameters.Name = "grpCfbParameters";
        grpCfbParameters.Size = new System.Drawing.Size(1183, 246);
        grpCfbParameters.TabIndex = 0;
        grpCfbParameters.TabStop = false;
        grpCfbParameters.Text = "Параметры CFB-128 с дополнением ISO/IEC 7816-4";
        // 
        // lblCfbKey
        // 
        lblCfbKey.AutoSize = true;
        lblCfbKey.Location = new System.Drawing.Point(16, 40);
        lblCfbKey.Name = "lblCfbKey";
        lblCfbKey.Size = new System.Drawing.Size(206, 32);
        lblCfbKey.TabIndex = 0;
        lblCfbKey.Text = "Ключ (16 байтов)";
        // 
        // txtCfbKey
        // 
        txtCfbKey.Location = new System.Drawing.Point(230, 37);
        txtCfbKey.Name = "txtCfbKey";
        txtCfbKey.Size = new System.Drawing.Size(400, 39);
        txtCfbKey.TabIndex = 1;
        txtCfbKey.Text = "2B7E151628AED2A6ABF7158809CF4F3C";
        // 
        // lblCfbKeyFormat
        // 
        lblCfbKeyFormat.AutoSize = true;
        lblCfbKeyFormat.Location = new System.Drawing.Point(650, 40);
        lblCfbKeyFormat.Name = "lblCfbKeyFormat";
        lblCfbKeyFormat.Size = new System.Drawing.Size(98, 32);
        lblCfbKeyFormat.TabIndex = 2;
        lblCfbKeyFormat.Text = "Формат";
        // 
        // cmbCfbKeyFormat
        // 
        cmbCfbKeyFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbCfbKeyFormat.FormattingEnabled = true;
        cmbCfbKeyFormat.Items.AddRange(new object[] { "UTF-8", "HEX" });
        cmbCfbKeyFormat.Location = new System.Drawing.Point(820, 36);
        cmbCfbKeyFormat.Name = "cmbCfbKeyFormat";
        cmbCfbKeyFormat.Size = new System.Drawing.Size(150, 40);
        cmbCfbKeyFormat.TabIndex = 3;
        // 
        // btnGenerateCfbKey
        // 
        btnGenerateCfbKey.Location = new System.Drawing.Point(977, 31);
        btnGenerateCfbKey.Name = "btnGenerateCfbKey";
        btnGenerateCfbKey.Size = new System.Drawing.Size(188, 50);
        btnGenerateCfbKey.TabIndex = 4;
        btnGenerateCfbKey.Text = "Создать ключ";
        btnGenerateCfbKey.UseVisualStyleBackColor = true;
        // 
        // lblCfbInitializationVector
        // 
        lblCfbInitializationVector.AutoSize = true;
        lblCfbInitializationVector.Location = new System.Drawing.Point(16, 96);
        lblCfbInitializationVector.Name = "lblCfbInitializationVector";
        lblCfbInitializationVector.Size = new System.Drawing.Size(166, 32);
        lblCfbInitializationVector.TabIndex = 5;
        lblCfbInitializationVector.Text = "IV (16 байтов)";
        // 
        // txtCfbInitializationVector
        // 
        txtCfbInitializationVector.Location = new System.Drawing.Point(230, 90);
        txtCfbInitializationVector.Name = "txtCfbInitializationVector";
        txtCfbInitializationVector.Size = new System.Drawing.Size(400, 39);
        txtCfbInitializationVector.TabIndex = 6;
        txtCfbInitializationVector.Text = "101112131415161718191A1B1C1D1E1F";
        // 
        // lblCfbVectorFormat
        // 
        lblCfbVectorFormat.AutoSize = true;
        lblCfbVectorFormat.Location = new System.Drawing.Point(650, 96);
        lblCfbVectorFormat.Name = "lblCfbVectorFormat";
        lblCfbVectorFormat.Size = new System.Drawing.Size(98, 32);
        lblCfbVectorFormat.TabIndex = 7;
        lblCfbVectorFormat.Text = "Формат";
        // 
        // cmbCfbVectorFormat
        // 
        cmbCfbVectorFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbCfbVectorFormat.FormattingEnabled = true;
        cmbCfbVectorFormat.Items.AddRange(new object[] { "UTF-8", "HEX" });
        cmbCfbVectorFormat.Location = new System.Drawing.Point(820, 89);
        cmbCfbVectorFormat.Name = "cmbCfbVectorFormat";
        cmbCfbVectorFormat.Size = new System.Drawing.Size(150, 40);
        cmbCfbVectorFormat.TabIndex = 8;
        // 
        // btnGenerateCfbVector
        // 
        btnGenerateCfbVector.Location = new System.Drawing.Point(995, 85);
        btnGenerateCfbVector.Name = "btnGenerateCfbVector";
        btnGenerateCfbVector.Size = new System.Drawing.Size(170, 50);
        btnGenerateCfbVector.TabIndex = 9;
        btnGenerateCfbVector.Text = "Создать IV";
        btnGenerateCfbVector.UseVisualStyleBackColor = true;
        // 
        // lblCfbInputFormat
        // 
        lblCfbInputFormat.AutoSize = true;
        lblCfbInputFormat.Location = new System.Drawing.Point(16, 152);
        lblCfbInputFormat.Name = "lblCfbInputFormat";
        lblCfbInputFormat.Size = new System.Drawing.Size(168, 32);
        lblCfbInputFormat.TabIndex = 10;
        lblCfbInputFormat.Text = "Формат входа";
        // 
        // cmbCfbInputFormat
        // 
        cmbCfbInputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbCfbInputFormat.FormattingEnabled = true;
        cmbCfbInputFormat.Items.AddRange(new object[] { "UTF-8", "HEX" });
        cmbCfbInputFormat.Location = new System.Drawing.Point(200, 147);
        cmbCfbInputFormat.Name = "cmbCfbInputFormat";
        cmbCfbInputFormat.Size = new System.Drawing.Size(150, 40);
        cmbCfbInputFormat.TabIndex = 11;
        // 
        // lblCfbOutputFormat
        // 
        lblCfbOutputFormat.AutoSize = true;
        lblCfbOutputFormat.Location = new System.Drawing.Point(390, 152);
        lblCfbOutputFormat.Name = "lblCfbOutputFormat";
        lblCfbOutputFormat.Size = new System.Drawing.Size(224, 32);
        lblCfbOutputFormat.TabIndex = 12;
        lblCfbOutputFormat.Text = "Формат результата";
        // 
        // cmbCfbOutputFormat
        // 
        cmbCfbOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbCfbOutputFormat.FormattingEnabled = true;
        cmbCfbOutputFormat.Items.AddRange(new object[] { "UTF-8", "HEX" });
        cmbCfbOutputFormat.Location = new System.Drawing.Point(630, 147);
        cmbCfbOutputFormat.Name = "cmbCfbOutputFormat";
        cmbCfbOutputFormat.Size = new System.Drawing.Size(175, 40);
        cmbCfbOutputFormat.TabIndex = 13;
        // 
        // lblCfbInputPath
        // 
        lblCfbInputPath.AutoSize = true;
        lblCfbInputPath.Location = new System.Drawing.Point(16, 205);
        lblCfbInputPath.Name = "lblCfbInputPath";
        lblCfbInputPath.Size = new System.Drawing.Size(70, 32);
        lblCfbInputPath.TabIndex = 14;
        lblCfbInputPath.Text = "Файл";
        // 
        // txtCfbInputPath
        // 
        txtCfbInputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtCfbInputPath.Location = new System.Drawing.Point(100, 200);
        txtCfbInputPath.Name = "txtCfbInputPath";
        txtCfbInputPath.ReadOnly = true;
        txtCfbInputPath.Size = new System.Drawing.Size(1065, 39);
        txtCfbInputPath.TabIndex = 15;
        txtCfbInputPath.Text = "Файл не выбран";
        // 
        // splitCfbEditors
        // 
        splitCfbEditors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        splitCfbEditors.Location = new System.Drawing.Point(12, 254);
        splitCfbEditors.Name = "splitCfbEditors";
        // 
        // splitCfbEditors.Panel1
        // 
        splitCfbEditors.Panel1.Controls.Add(grpCfbInput);
        // 
        // splitCfbEditors.Panel2
        // 
        splitCfbEditors.Panel2.Controls.Add(grpCfbResult);
        splitCfbEditors.Size = new System.Drawing.Size(1183, 489);
        splitCfbEditors.SplitterDistance = 584;
        splitCfbEditors.TabIndex = 1;
        // 
        // grpCfbInput
        // 
        grpCfbInput.Controls.Add(txtCfbInput);
        grpCfbInput.Dock = System.Windows.Forms.DockStyle.Fill;
        grpCfbInput.Location = new System.Drawing.Point(0, 0);
        grpCfbInput.Name = "grpCfbInput";
        grpCfbInput.Padding = new System.Windows.Forms.Padding(8);
        grpCfbInput.Size = new System.Drawing.Size(584, 489);
        grpCfbInput.TabIndex = 0;
        grpCfbInput.TabStop = false;
        grpCfbInput.Text = "Исходные данные";
        // 
        // txtCfbInput
        // 
        txtCfbInput.Dock = System.Windows.Forms.DockStyle.Fill;
        txtCfbInput.Font = new System.Drawing.Font("Consolas", 10F);
        txtCfbInput.Location = new System.Drawing.Point(8, 40);
        txtCfbInput.Multiline = true;
        txtCfbInput.Name = "txtCfbInput";
        txtCfbInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        txtCfbInput.Size = new System.Drawing.Size(568, 441);
        txtCfbInput.TabIndex = 0;
        txtCfbInput.Text = "Данные для режима CFB-128";
        txtCfbInput.WordWrap = false;
        // 
        // grpCfbResult
        // 
        grpCfbResult.Controls.Add(txtCfbResult);
        grpCfbResult.Dock = System.Windows.Forms.DockStyle.Fill;
        grpCfbResult.Location = new System.Drawing.Point(0, 0);
        grpCfbResult.Name = "grpCfbResult";
        grpCfbResult.Padding = new System.Windows.Forms.Padding(8);
        grpCfbResult.Size = new System.Drawing.Size(595, 489);
        grpCfbResult.TabIndex = 0;
        grpCfbResult.TabStop = false;
        grpCfbResult.Text = "Результат";
        // 
        // txtCfbResult
        // 
        txtCfbResult.Dock = System.Windows.Forms.DockStyle.Fill;
        txtCfbResult.Font = new System.Drawing.Font("Consolas", 10F);
        txtCfbResult.Location = new System.Drawing.Point(8, 40);
        txtCfbResult.Multiline = true;
        txtCfbResult.Name = "txtCfbResult";
        txtCfbResult.ReadOnly = true;
        txtCfbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        txtCfbResult.Size = new System.Drawing.Size(579, 441);
        txtCfbResult.TabIndex = 0;
        txtCfbResult.WordWrap = false;
        // 
        // btnCfbEncrypt
        // 
        btnCfbEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnCfbEncrypt.Location = new System.Drawing.Point(12, 755);
        btnCfbEncrypt.Name = "btnCfbEncrypt";
        btnCfbEncrypt.Size = new System.Drawing.Size(180, 55);
        btnCfbEncrypt.TabIndex = 2;
        btnCfbEncrypt.Text = "Зашифровать";
        btnCfbEncrypt.UseVisualStyleBackColor = true;
        // 
        // btnCfbDecrypt
        // 
        btnCfbDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnCfbDecrypt.Location = new System.Drawing.Point(200, 755);
        btnCfbDecrypt.Name = "btnCfbDecrypt";
        btnCfbDecrypt.Size = new System.Drawing.Size(190, 55);
        btnCfbDecrypt.TabIndex = 3;
        btnCfbDecrypt.Text = "Расшифровать";
        btnCfbDecrypt.UseVisualStyleBackColor = true;
        // 
        // btnUseCfbResult
        // 
        btnUseCfbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnUseCfbResult.Location = new System.Drawing.Point(950, 755);
        btnUseCfbResult.Name = "btnUseCfbResult";
        btnUseCfbResult.Size = new System.Drawing.Size(245, 55);
        btnUseCfbResult.TabIndex = 6;
        btnUseCfbResult.Text = "Результат во вход";
        btnUseCfbResult.UseVisualStyleBackColor = true;
        // 
        // btnOpenCfbInput
        // 
        btnOpenCfbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnOpenCfbInput.Location = new System.Drawing.Point(408, 755);
        btnOpenCfbInput.Name = "btnOpenCfbInput";
        btnOpenCfbInput.Size = new System.Drawing.Size(180, 55);
        btnOpenCfbInput.TabIndex = 4;
        btnOpenCfbInput.Text = "Открыть файл";
        btnOpenCfbInput.UseVisualStyleBackColor = true;
        // 
        // btnSaveCfbResult
        // 
        btnSaveCfbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnSaveCfbResult.Location = new System.Drawing.Point(596, 755);
        btnSaveCfbResult.Name = "btnSaveCfbResult";
        btnSaveCfbResult.Size = new System.Drawing.Size(220, 55);
        btnSaveCfbResult.TabIndex = 5;
        btnSaveCfbResult.Text = "Сохранить байты";
        btnSaveCfbResult.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1247, 902);
        Controls.Add(tabMain);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Margin = new System.Windows.Forms.Padding(5);
        MinimumSize = new System.Drawing.Size(960, 640);
        Padding = new System.Windows.Forms.Padding(12);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Лабораторная работа №3 — AES-128";
        tabMain.ResumeLayout(false);
        tabAesBlock.ResumeLayout(false);
        grpAesBlockParameters.ResumeLayout(false);
        grpAesBlockParameters.PerformLayout();
        splitAesBlockEditors.Panel1.ResumeLayout(false);
        splitAesBlockEditors.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitAesBlockEditors).EndInit();
        splitAesBlockEditors.ResumeLayout(false);
        grpAesBlockInput.ResumeLayout(false);
        grpAesBlockInput.PerformLayout();
        grpAesBlockResult.ResumeLayout(false);
        grpAesBlockResult.PerformLayout();
        tabPadding.ResumeLayout(false);
        grpPaddingParameters.ResumeLayout(false);
        grpPaddingParameters.PerformLayout();
        splitPaddingEditors.Panel1.ResumeLayout(false);
        splitPaddingEditors.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitPaddingEditors).EndInit();
        splitPaddingEditors.ResumeLayout(false);
        grpPaddingInput.ResumeLayout(false);
        grpPaddingInput.PerformLayout();
        grpPaddingResult.ResumeLayout(false);
        grpPaddingResult.PerformLayout();
        tabEcb.ResumeLayout(false);
        grpEcbParameters.ResumeLayout(false);
        grpEcbParameters.PerformLayout();
        splitEcbEditors.Panel1.ResumeLayout(false);
        splitEcbEditors.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitEcbEditors).EndInit();
        splitEcbEditors.ResumeLayout(false);
        grpEcbInput.ResumeLayout(false);
        grpEcbInput.PerformLayout();
        grpEcbResult.ResumeLayout(false);
        grpEcbResult.PerformLayout();
        tabCfb.ResumeLayout(false);
        grpCfbParameters.ResumeLayout(false);
        grpCfbParameters.PerformLayout();
        splitCfbEditors.Panel1.ResumeLayout(false);
        splitCfbEditors.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitCfbEditors).EndInit();
        splitCfbEditors.ResumeLayout(false);
        grpCfbInput.ResumeLayout(false);
        grpCfbInput.PerformLayout();
        grpCfbResult.ResumeLayout(false);
        grpCfbResult.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TabControl tabMain;
    private TabPage tabAesBlock;
    private System.Windows.Forms.GroupBox grpAesBlockParameters;
    private System.Windows.Forms.Label lblAesBlockKey;
    private System.Windows.Forms.TextBox txtAesBlockKey;
    private System.Windows.Forms.Label lblAesBlockKeyFormat;
    private System.Windows.Forms.ComboBox cmbAesBlockKeyFormat;
    private System.Windows.Forms.Label lblAesBlockInputFormat;
    private System.Windows.Forms.ComboBox cmbAesBlockInputFormat;
    private System.Windows.Forms.Label lblAesBlockOutputFormat;
    private System.Windows.Forms.ComboBox cmbAesBlockOutputFormat;
    private System.Windows.Forms.Button btnGenerateAesBlockKey;
    private System.Windows.Forms.SplitContainer splitAesBlockEditors;
    private System.Windows.Forms.GroupBox grpAesBlockInput;
    private System.Windows.Forms.TextBox txtAesBlockInput;
    private System.Windows.Forms.GroupBox grpAesBlockResult;
    private System.Windows.Forms.TextBox txtAesBlockResult;
    private System.Windows.Forms.Button btnAesBlockEncrypt;
    private System.Windows.Forms.Button btnAesBlockDecrypt;
    private System.Windows.Forms.Button btnUseAesBlockResult;
    private System.Windows.Forms.TabPage tabPadding;
    private System.Windows.Forms.GroupBox grpPaddingParameters;
    private System.Windows.Forms.Label lblPaddingInputFormat;
    private System.Windows.Forms.ComboBox cmbPaddingInputFormat;
    private System.Windows.Forms.Label lblPaddingOutputFormat;
    private System.Windows.Forms.ComboBox cmbPaddingOutputFormat;
    private System.Windows.Forms.SplitContainer splitPaddingEditors;
    private System.Windows.Forms.GroupBox grpPaddingInput;
    private System.Windows.Forms.TextBox txtPaddingInput;
    private System.Windows.Forms.GroupBox grpPaddingResult;
    private System.Windows.Forms.TextBox txtPaddingResult;
    private System.Windows.Forms.Button btnAddPadding;
    private System.Windows.Forms.Button btnRemovePadding;
    private System.Windows.Forms.Button btnUsePaddingResult;
    private TabPage tabEcb;
    private System.Windows.Forms.GroupBox grpEcbParameters;
    private System.Windows.Forms.Label lblEcbKey;
    private System.Windows.Forms.TextBox txtEcbKey;
    private System.Windows.Forms.Label lblEcbKeyFormat;
    private System.Windows.Forms.ComboBox cmbEcbKeyFormat;
    private System.Windows.Forms.Label lblEcbInputFormat;
    private System.Windows.Forms.ComboBox cmbEcbInputFormat;
    private System.Windows.Forms.Label lblEcbOutputFormat;
    private System.Windows.Forms.ComboBox cmbEcbOutputFormat;
    private System.Windows.Forms.Button btnGenerateEcbKey;
    private System.Windows.Forms.Label lblEcbInputPath;
    private System.Windows.Forms.TextBox txtEcbInputPath;
    private System.Windows.Forms.SplitContainer splitEcbEditors;
    private System.Windows.Forms.GroupBox grpEcbInput;
    private System.Windows.Forms.TextBox txtEcbInput;
    private System.Windows.Forms.GroupBox grpEcbResult;
    private System.Windows.Forms.TextBox txtEcbResult;
    private System.Windows.Forms.Button btnEcbEncrypt;
    private System.Windows.Forms.Button btnEcbDecrypt;
    private System.Windows.Forms.Button btnUseEcbResult;
    private System.Windows.Forms.Button btnOpenEcbInput;
    private System.Windows.Forms.Button btnSaveEcbResult;
    private TabPage tabCfb;
    private System.Windows.Forms.GroupBox grpCfbParameters;
    private System.Windows.Forms.Label lblCfbKey;
    private System.Windows.Forms.TextBox txtCfbKey;
    private System.Windows.Forms.Label lblCfbKeyFormat;
    private System.Windows.Forms.ComboBox cmbCfbKeyFormat;
    private System.Windows.Forms.Button btnGenerateCfbKey;
    private System.Windows.Forms.Label lblCfbInitializationVector;
    private System.Windows.Forms.TextBox txtCfbInitializationVector;
    private System.Windows.Forms.Label lblCfbVectorFormat;
    private System.Windows.Forms.ComboBox cmbCfbVectorFormat;
    private System.Windows.Forms.Button btnGenerateCfbVector;
    private System.Windows.Forms.Label lblCfbInputFormat;
    private System.Windows.Forms.ComboBox cmbCfbInputFormat;
    private System.Windows.Forms.Label lblCfbOutputFormat;
    private System.Windows.Forms.ComboBox cmbCfbOutputFormat;
    private System.Windows.Forms.Label lblCfbInputPath;
    private System.Windows.Forms.TextBox txtCfbInputPath;
    private System.Windows.Forms.SplitContainer splitCfbEditors;
    private System.Windows.Forms.GroupBox grpCfbInput;
    private System.Windows.Forms.TextBox txtCfbInput;
    private System.Windows.Forms.GroupBox grpCfbResult;
    private System.Windows.Forms.TextBox txtCfbResult;
    private System.Windows.Forms.Button btnCfbEncrypt;
    private System.Windows.Forms.Button btnCfbDecrypt;
    private System.Windows.Forms.Button btnUseCfbResult;
    private System.Windows.Forms.Button btnOpenCfbInput;
    private System.Windows.Forms.Button btnSaveCfbResult;
}
