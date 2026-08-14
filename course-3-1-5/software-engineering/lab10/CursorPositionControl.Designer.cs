namespace lab10
{
    partial class CursorPositionControl
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
            lblPosition = new Label();
            lblCount = new Label();
            SuspendLayout();
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(3, 13);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(154, 20);
            lblPosition.TabIndex = 0;
            lblPosition.Text = "Позиция: X: 0.0, Y: 0.0";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(3, 46);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(178, 20);
            lblCount.TabIndex = 1;
            lblCount.Text = "Количество символов: 0";
            // 
            // CursorPositionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCount);
            Controls.Add(lblPosition);
            Name = "CursorPositionControl";
            Size = new Size(184, 87);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPosition;
        private Label lblCount;
    }
}
