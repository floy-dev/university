#nullable disable

namespace Lab4;

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

    private void InitializeComponent()
    {
        tabMain = new TabControl();
        tabDeterministic = new TabPage();
        grpDeterministicParameters = new GroupBox();
        lblDeterministicNumber = new Label();
        txtDeterministicNumber = new TextBox();
        lblDeterministicMethod = new Label();
        cmbDeterministicMethod = new ComboBox();
        btnDeterministicCheck = new Button();
        btnDeterministicClear = new Button();
        grpDeterministicResult = new GroupBox();
        txtDeterministicResult = new TextBox();
        tabProbabilistic = new TabPage();
        grpProbabilisticParameters = new GroupBox();
        lblProbabilisticNumber = new Label();
        txtProbabilisticNumber = new TextBox();
        lblProbabilisticMethod = new Label();
        cmbProbabilisticMethod = new ComboBox();
        lblProbabilisticIterations = new Label();
        nudProbabilisticIterations = new NumericUpDown();
        btnProbabilisticCheck = new Button();
        btnProbabilisticClear = new Button();
        grpProbabilisticResult = new GroupBox();
        txtProbabilisticResult = new TextBox();
        tabPrimeGeneration = new TabPage();
        grpGenerationParameters = new GroupBox();
        lblPrimeBitCount = new Label();
        nudPrimeBitCount = new NumericUpDown();
        lblGenerationIterations = new Label();
        nudGenerationIterations = new NumericUpDown();
        btnGeneratePrime = new Button();
        btnGenerationClear = new Button();
        grpGenerationResult = new GroupBox();
        txtGeneratedPrime = new TextBox();
        tabMain.SuspendLayout();
        tabDeterministic.SuspendLayout();
        grpDeterministicParameters.SuspendLayout();
        grpDeterministicResult.SuspendLayout();
        tabProbabilistic.SuspendLayout();
        grpProbabilisticParameters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudProbabilisticIterations).BeginInit();
        grpProbabilisticResult.SuspendLayout();
        tabPrimeGeneration.SuspendLayout();
        grpGenerationParameters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudPrimeBitCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudGenerationIterations).BeginInit();
        grpGenerationResult.SuspendLayout();
        SuspendLayout();
        // 
        // tabMain
        // 
        tabMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabMain.Controls.Add(tabDeterministic);
        tabMain.Controls.Add(tabProbabilistic);
        tabMain.Controls.Add(tabPrimeGeneration);
        tabMain.Location = new Point(12, 12);
        tabMain.Name = "tabMain";
        tabMain.SelectedIndex = 0;
        tabMain.Size = new Size(1076, 696);
        tabMain.TabIndex = 0;
        // 
        // tabDeterministic
        // 
        tabDeterministic.Controls.Add(grpDeterministicParameters);
        tabDeterministic.Controls.Add(grpDeterministicResult);
        tabDeterministic.Location = new Point(4, 29);
        tabDeterministic.Name = "tabDeterministic";
        tabDeterministic.Padding = new Padding(3);
        tabDeterministic.Size = new Size(1068, 663);
        tabDeterministic.TabIndex = 0;
        tabDeterministic.Text = "Детерминированные тесты";
        tabDeterministic.UseVisualStyleBackColor = true;
        // 
        // grpDeterministicParameters
        // 
        grpDeterministicParameters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        grpDeterministicParameters.Controls.Add(lblDeterministicNumber);
        grpDeterministicParameters.Controls.Add(txtDeterministicNumber);
        grpDeterministicParameters.Controls.Add(lblDeterministicMethod);
        grpDeterministicParameters.Controls.Add(cmbDeterministicMethod);
        grpDeterministicParameters.Controls.Add(btnDeterministicCheck);
        grpDeterministicParameters.Controls.Add(btnDeterministicClear);
        grpDeterministicParameters.Location = new Point(16, 16);
        grpDeterministicParameters.Name = "grpDeterministicParameters";
        grpDeterministicParameters.Size = new Size(1036, 138);
        grpDeterministicParameters.TabIndex = 0;
        grpDeterministicParameters.TabStop = false;
        grpDeterministicParameters.Text = "Параметры проверки";
        // 
        // lblDeterministicNumber
        // 
        lblDeterministicNumber.AutoSize = true;
        lblDeterministicNumber.Location = new Point(18, 28);
        lblDeterministicNumber.Name = "lblDeterministicNumber";
        lblDeterministicNumber.Size = new Size(146, 20);
        lblDeterministicNumber.TabIndex = 0;
        lblDeterministicNumber.Text = "Проверяемое число";
        // 
        // txtDeterministicNumber
        // 
        txtDeterministicNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtDeterministicNumber.Location = new Point(18, 51);
        txtDeterministicNumber.Name = "txtDeterministicNumber";
        txtDeterministicNumber.Size = new Size(650, 27);
        txtDeterministicNumber.TabIndex = 1;
        txtDeterministicNumber.Text = "561";
        // 
        // lblDeterministicMethod
        // 
        lblDeterministicMethod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblDeterministicMethod.AutoSize = true;
        lblDeterministicMethod.Location = new Point(686, 28);
        lblDeterministicMethod.Name = "lblDeterministicMethod";
        lblDeterministicMethod.Size = new Size(126, 20);
        lblDeterministicMethod.TabIndex = 2;
        lblDeterministicMethod.Text = "Метод проверки";
        // 
        // cmbDeterministicMethod
        // 
        cmbDeterministicMethod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbDeterministicMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDeterministicMethod.FormattingEnabled = true;
        cmbDeterministicMethod.Items.AddRange(new object[] { "Перебор делителей", "Решето Эратосфена" });
        cmbDeterministicMethod.Location = new Point(686, 50);
        cmbDeterministicMethod.Name = "cmbDeterministicMethod";
        cmbDeterministicMethod.Size = new Size(330, 28);
        cmbDeterministicMethod.TabIndex = 3;
        cmbDeterministicMethod.SelectedIndex = 0;
        // 
        // btnDeterministicCheck
        // 
        btnDeterministicCheck.Location = new Point(18, 91);
        btnDeterministicCheck.Name = "btnDeterministicCheck";
        btnDeterministicCheck.Size = new Size(180, 38);
        btnDeterministicCheck.TabIndex = 4;
        btnDeterministicCheck.Text = "Проверить число";
        btnDeterministicCheck.UseVisualStyleBackColor = true;
        btnDeterministicCheck.Click += btnDeterministicCheck_Click;
        // 
        // btnDeterministicClear
        // 
        btnDeterministicClear.Location = new Point(208, 91);
        btnDeterministicClear.Name = "btnDeterministicClear";
        btnDeterministicClear.Size = new Size(150, 38);
        btnDeterministicClear.TabIndex = 5;
        btnDeterministicClear.Text = "Очистить";
        btnDeterministicClear.UseVisualStyleBackColor = true;
        btnDeterministicClear.Click += btnDeterministicClear_Click;
        // 
        // grpDeterministicResult
        // 
        grpDeterministicResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grpDeterministicResult.Controls.Add(txtDeterministicResult);
        grpDeterministicResult.Location = new Point(16, 166);
        grpDeterministicResult.Name = "grpDeterministicResult";
        grpDeterministicResult.Size = new Size(1036, 476);
        grpDeterministicResult.TabIndex = 1;
        grpDeterministicResult.TabStop = false;
        grpDeterministicResult.Text = "Результат";
        // 
        // txtDeterministicResult
        // 
        txtDeterministicResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtDeterministicResult.Location = new Point(12, 27);
        txtDeterministicResult.Multiline = true;
        txtDeterministicResult.Name = "txtDeterministicResult";
        txtDeterministicResult.ReadOnly = true;
        txtDeterministicResult.ScrollBars = ScrollBars.Vertical;
        txtDeterministicResult.Size = new Size(1012, 435);
        txtDeterministicResult.TabIndex = 0;
        // 
        // tabProbabilistic
        // 
        tabProbabilistic.Controls.Add(grpProbabilisticParameters);
        tabProbabilistic.Controls.Add(grpProbabilisticResult);
        tabProbabilistic.Location = new Point(4, 29);
        tabProbabilistic.Name = "tabProbabilistic";
        tabProbabilistic.Padding = new Padding(3);
        tabProbabilistic.Size = new Size(1068, 663);
        tabProbabilistic.TabIndex = 1;
        tabProbabilistic.Text = "Вероятностные тесты";
        tabProbabilistic.UseVisualStyleBackColor = true;
        // 
        // grpProbabilisticParameters
        // 
        grpProbabilisticParameters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        grpProbabilisticParameters.Controls.Add(lblProbabilisticNumber);
        grpProbabilisticParameters.Controls.Add(txtProbabilisticNumber);
        grpProbabilisticParameters.Controls.Add(lblProbabilisticMethod);
        grpProbabilisticParameters.Controls.Add(cmbProbabilisticMethod);
        grpProbabilisticParameters.Controls.Add(lblProbabilisticIterations);
        grpProbabilisticParameters.Controls.Add(nudProbabilisticIterations);
        grpProbabilisticParameters.Controls.Add(btnProbabilisticCheck);
        grpProbabilisticParameters.Controls.Add(btnProbabilisticClear);
        grpProbabilisticParameters.Location = new Point(16, 16);
        grpProbabilisticParameters.Name = "grpProbabilisticParameters";
        grpProbabilisticParameters.Size = new Size(1036, 138);
        grpProbabilisticParameters.TabIndex = 0;
        grpProbabilisticParameters.TabStop = false;
        grpProbabilisticParameters.Text = "Параметры проверки";
        // 
        // lblProbabilisticNumber
        // 
        lblProbabilisticNumber.AutoSize = true;
        lblProbabilisticNumber.Location = new Point(18, 28);
        lblProbabilisticNumber.Name = "lblProbabilisticNumber";
        lblProbabilisticNumber.Size = new Size(146, 20);
        lblProbabilisticNumber.TabIndex = 0;
        lblProbabilisticNumber.Text = "Проверяемое число";
        // 
        // txtProbabilisticNumber
        // 
        txtProbabilisticNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtProbabilisticNumber.Location = new Point(18, 51);
        txtProbabilisticNumber.Name = "txtProbabilisticNumber";
        txtProbabilisticNumber.Size = new Size(450, 27);
        txtProbabilisticNumber.TabIndex = 1;
        txtProbabilisticNumber.Text = "561";
        // 
        // lblProbabilisticMethod
        // 
        lblProbabilisticMethod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblProbabilisticMethod.AutoSize = true;
        lblProbabilisticMethod.Location = new Point(486, 28);
        lblProbabilisticMethod.Name = "lblProbabilisticMethod";
        lblProbabilisticMethod.Size = new Size(126, 20);
        lblProbabilisticMethod.TabIndex = 2;
        lblProbabilisticMethod.Text = "Метод проверки";
        // 
        // cmbProbabilisticMethod
        // 
        cmbProbabilisticMethod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbProbabilisticMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbProbabilisticMethod.FormattingEnabled = true;
        cmbProbabilisticMethod.Items.AddRange(new object[] { "Случайный общий делитель", "Тест Ферма", "Тест Рабина-Миллера", "Тест Соловея-Штрассена" });
        cmbProbabilisticMethod.Location = new Point(486, 50);
        cmbProbabilisticMethod.Name = "cmbProbabilisticMethod";
        cmbProbabilisticMethod.Size = new Size(320, 28);
        cmbProbabilisticMethod.TabIndex = 3;
        cmbProbabilisticMethod.SelectedIndex = 2;
        // 
        // lblProbabilisticIterations
        // 
        lblProbabilisticIterations.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblProbabilisticIterations.AutoSize = true;
        lblProbabilisticIterations.Location = new Point(824, 28);
        lblProbabilisticIterations.Name = "lblProbabilisticIterations";
        lblProbabilisticIterations.Size = new Size(154, 20);
        lblProbabilisticIterations.TabIndex = 4;
        lblProbabilisticIterations.Text = "Количество итераций";
        // 
        // nudProbabilisticIterations
        // 
        nudProbabilisticIterations.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        nudProbabilisticIterations.Location = new Point(824, 51);
        nudProbabilisticIterations.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nudProbabilisticIterations.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudProbabilisticIterations.Name = "nudProbabilisticIterations";
        nudProbabilisticIterations.Size = new Size(192, 27);
        nudProbabilisticIterations.TabIndex = 5;
        nudProbabilisticIterations.Value = new decimal(new int[] { 16, 0, 0, 0 });
        // 
        // btnProbabilisticCheck
        // 
        btnProbabilisticCheck.Location = new Point(18, 91);
        btnProbabilisticCheck.Name = "btnProbabilisticCheck";
        btnProbabilisticCheck.Size = new Size(180, 38);
        btnProbabilisticCheck.TabIndex = 6;
        btnProbabilisticCheck.Text = "Проверить число";
        btnProbabilisticCheck.UseVisualStyleBackColor = true;
        btnProbabilisticCheck.Click += btnProbabilisticCheck_Click;
        // 
        // btnProbabilisticClear
        // 
        btnProbabilisticClear.Location = new Point(208, 91);
        btnProbabilisticClear.Name = "btnProbabilisticClear";
        btnProbabilisticClear.Size = new Size(150, 38);
        btnProbabilisticClear.TabIndex = 7;
        btnProbabilisticClear.Text = "Очистить";
        btnProbabilisticClear.UseVisualStyleBackColor = true;
        btnProbabilisticClear.Click += btnProbabilisticClear_Click;
        // 
        // grpProbabilisticResult
        // 
        grpProbabilisticResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grpProbabilisticResult.Controls.Add(txtProbabilisticResult);
        grpProbabilisticResult.Location = new Point(16, 166);
        grpProbabilisticResult.Name = "grpProbabilisticResult";
        grpProbabilisticResult.Size = new Size(1036, 476);
        grpProbabilisticResult.TabIndex = 1;
        grpProbabilisticResult.TabStop = false;
        grpProbabilisticResult.Text = "Результат";
        // 
        // txtProbabilisticResult
        // 
        txtProbabilisticResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtProbabilisticResult.Location = new Point(12, 27);
        txtProbabilisticResult.Multiline = true;
        txtProbabilisticResult.Name = "txtProbabilisticResult";
        txtProbabilisticResult.ReadOnly = true;
        txtProbabilisticResult.ScrollBars = ScrollBars.Vertical;
        txtProbabilisticResult.Size = new Size(1012, 435);
        txtProbabilisticResult.TabIndex = 0;
        // 
        // tabPrimeGeneration
        // 
        tabPrimeGeneration.Controls.Add(grpGenerationParameters);
        tabPrimeGeneration.Controls.Add(grpGenerationResult);
        tabPrimeGeneration.Location = new Point(4, 29);
        tabPrimeGeneration.Name = "tabPrimeGeneration";
        tabPrimeGeneration.Padding = new Padding(3);
        tabPrimeGeneration.Size = new Size(1068, 663);
        tabPrimeGeneration.TabIndex = 2;
        tabPrimeGeneration.Text = "Генерация простого числа";
        tabPrimeGeneration.UseVisualStyleBackColor = true;
        // 
        // grpGenerationParameters
        // 
        grpGenerationParameters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        grpGenerationParameters.Controls.Add(lblPrimeBitCount);
        grpGenerationParameters.Controls.Add(nudPrimeBitCount);
        grpGenerationParameters.Controls.Add(lblGenerationIterations);
        grpGenerationParameters.Controls.Add(nudGenerationIterations);
        grpGenerationParameters.Controls.Add(btnGeneratePrime);
        grpGenerationParameters.Controls.Add(btnGenerationClear);
        grpGenerationParameters.Location = new Point(16, 16);
        grpGenerationParameters.Name = "grpGenerationParameters";
        grpGenerationParameters.Size = new Size(1036, 138);
        grpGenerationParameters.TabIndex = 0;
        grpGenerationParameters.TabStop = false;
        grpGenerationParameters.Text = "Параметры генерации";
        // 
        // lblPrimeBitCount
        // 
        lblPrimeBitCount.AutoSize = true;
        lblPrimeBitCount.Location = new Point(18, 28);
        lblPrimeBitCount.Name = "lblPrimeBitCount";
        lblPrimeBitCount.Size = new Size(131, 20);
        lblPrimeBitCount.TabIndex = 0;
        lblPrimeBitCount.Text = "Разрядность, бит";
        // 
        // nudPrimeBitCount
        // 
        nudPrimeBitCount.Location = new Point(18, 51);
        nudPrimeBitCount.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
        nudPrimeBitCount.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
        nudPrimeBitCount.Name = "nudPrimeBitCount";
        nudPrimeBitCount.Size = new Size(200, 27);
        nudPrimeBitCount.TabIndex = 1;
        nudPrimeBitCount.Value = new decimal(new int[] { 160, 0, 0, 0 });
        // 
        // lblGenerationIterations
        // 
        lblGenerationIterations.AutoSize = true;
        lblGenerationIterations.Location = new Point(238, 28);
        lblGenerationIterations.Name = "lblGenerationIterations";
        lblGenerationIterations.Size = new Size(154, 20);
        lblGenerationIterations.TabIndex = 2;
        lblGenerationIterations.Text = "Количество итераций";
        // 
        // nudGenerationIterations
        // 
        nudGenerationIterations.Location = new Point(238, 51);
        nudGenerationIterations.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nudGenerationIterations.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudGenerationIterations.Name = "nudGenerationIterations";
        nudGenerationIterations.Size = new Size(200, 27);
        nudGenerationIterations.TabIndex = 3;
        nudGenerationIterations.Value = new decimal(new int[] { 16, 0, 0, 0 });
        // 
        // btnGeneratePrime
        // 
        btnGeneratePrime.Location = new Point(18, 91);
        btnGeneratePrime.Name = "btnGeneratePrime";
        btnGeneratePrime.Size = new Size(240, 38);
        btnGeneratePrime.TabIndex = 4;
        btnGeneratePrime.Text = "Сгенерировать число";
        btnGeneratePrime.UseVisualStyleBackColor = true;
        btnGeneratePrime.Click += btnGeneratePrime_Click;
        // 
        // btnGenerationClear
        // 
        btnGenerationClear.Location = new Point(268, 91);
        btnGenerationClear.Name = "btnGenerationClear";
        btnGenerationClear.Size = new Size(150, 38);
        btnGenerationClear.TabIndex = 5;
        btnGenerationClear.Text = "Очистить";
        btnGenerationClear.UseVisualStyleBackColor = true;
        btnGenerationClear.Click += btnGenerationClear_Click;
        // 
        // grpGenerationResult
        // 
        grpGenerationResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grpGenerationResult.Controls.Add(txtGeneratedPrime);
        grpGenerationResult.Location = new Point(16, 166);
        grpGenerationResult.Name = "grpGenerationResult";
        grpGenerationResult.Size = new Size(1036, 476);
        grpGenerationResult.TabIndex = 1;
        grpGenerationResult.TabStop = false;
        grpGenerationResult.Text = "Сгенерированное число";
        // 
        // txtGeneratedPrime
        // 
        txtGeneratedPrime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtGeneratedPrime.Location = new Point(12, 27);
        txtGeneratedPrime.Multiline = true;
        txtGeneratedPrime.Name = "txtGeneratedPrime";
        txtGeneratedPrime.ReadOnly = true;
        txtGeneratedPrime.ScrollBars = ScrollBars.Vertical;
        txtGeneratedPrime.Size = new Size(1012, 435);
        txtGeneratedPrime.TabIndex = 0;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 720);
        Controls.Add(tabMain);
        MinimumSize = new Size(960, 640);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Лабораторная работа №4 - Простые числа";
        tabMain.ResumeLayout(false);
        tabDeterministic.ResumeLayout(false);
        grpDeterministicParameters.ResumeLayout(false);
        grpDeterministicParameters.PerformLayout();
        grpDeterministicResult.ResumeLayout(false);
        grpDeterministicResult.PerformLayout();
        tabProbabilistic.ResumeLayout(false);
        grpProbabilisticParameters.ResumeLayout(false);
        grpProbabilisticParameters.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudProbabilisticIterations).EndInit();
        grpProbabilisticResult.ResumeLayout(false);
        grpProbabilisticResult.PerformLayout();
        tabPrimeGeneration.ResumeLayout(false);
        grpGenerationParameters.ResumeLayout(false);
        grpGenerationParameters.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudPrimeBitCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudGenerationIterations).EndInit();
        grpGenerationResult.ResumeLayout(false);
        grpGenerationResult.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabMain;
    private TabPage tabDeterministic;
    private GroupBox grpDeterministicParameters;
    private Label lblDeterministicNumber;
    private TextBox txtDeterministicNumber;
    private Label lblDeterministicMethod;
    private ComboBox cmbDeterministicMethod;
    private Button btnDeterministicCheck;
    private Button btnDeterministicClear;
    private GroupBox grpDeterministicResult;
    private TextBox txtDeterministicResult;
    private TabPage tabProbabilistic;
    private GroupBox grpProbabilisticParameters;
    private Label lblProbabilisticNumber;
    private TextBox txtProbabilisticNumber;
    private Label lblProbabilisticMethod;
    private ComboBox cmbProbabilisticMethod;
    private Label lblProbabilisticIterations;
    private NumericUpDown nudProbabilisticIterations;
    private Button btnProbabilisticCheck;
    private Button btnProbabilisticClear;
    private GroupBox grpProbabilisticResult;
    private TextBox txtProbabilisticResult;
    private TabPage tabPrimeGeneration;
    private GroupBox grpGenerationParameters;
    private Label lblPrimeBitCount;
    private NumericUpDown nudPrimeBitCount;
    private Label lblGenerationIterations;
    private NumericUpDown nudGenerationIterations;
    private Button btnGeneratePrime;
    private Button btnGenerationClear;
    private GroupBox grpGenerationResult;
    private TextBox txtGeneratedPrime;
}
