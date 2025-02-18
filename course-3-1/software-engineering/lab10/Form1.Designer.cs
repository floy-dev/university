namespace lab10
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox1 = new TextBox();
            cursorPositionControl1 = new CursorPositionControl();
            areaConversionControl1 = new AreaConversionControl();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // cursorPositionControl1
            // 
            cursorPositionControl1.Location = new Point(12, 22);
            cursorPositionControl1.Name = "cursorPositionControl1";
            cursorPositionControl1.Size = new Size(188, 83);
            cursorPositionControl1.TabIndex = 1;
            // 
            // areaConversionControl1
            // 
            areaConversionControl1.Location = new Point(273, 12);
            areaConversionControl1.Name = "areaConversionControl1";
            areaConversionControl1.Size = new Size(618, 167);
            areaConversionControl1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 201);
            Controls.Add(areaConversionControl1);
            Controls.Add(cursorPositionControl1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Пользовательские элементы";
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox1;
        private CursorPositionControl cursorPositionControl1;
        private AreaConversionControl areaConversionControl1;
    }
}
