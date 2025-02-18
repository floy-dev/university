namespace lab10
{
    partial class AreaConversionControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxUnit1 = new comboBoxUnit();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            comboBoxUnit2 = new comboBoxUnit();
            SuspendLayout();
            // 
            // comboBoxUnit1
            // 
            comboBoxUnit1.Location = new Point(248, 15);
            comboBoxUnit1.Name = "comboBoxUnit1";
            comboBoxUnit1.Size = new Size(247, 37);
            comboBoxUnit1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 23);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 1;
            label1.Text = "Начальные значения:";
            // 
            // button1
            // 
            button1.Location = new Point(15, 114);
            button1.Name = "button1";
            button1.Size = new Size(174, 29);
            button1.TabIndex = 2;
            button1.Text = "Конвертировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 66);
            label2.Name = "label2";
            label2.Size = new Size(227, 20);
            label2.TabIndex = 4;
            label2.Text = "Сконвертированные значения:";
            // 
            // comboBoxUnit2
            // 
            comboBoxUnit2.Location = new Point(248, 58);
            comboBoxUnit2.Name = "comboBoxUnit2";
            comboBoxUnit2.Size = new Size(247, 37);
            comboBoxUnit2.TabIndex = 3;
            // 
            // AreaConversionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(comboBoxUnit2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBoxUnit1);
            Name = "AreaConversionControl";
            Size = new Size(513, 161);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private comboBoxUnit comboBoxUnit1;
        private Label label1;
        private Button button1;
        private Label label2;
        private comboBoxUnit comboBoxUnit2;
    }
}
