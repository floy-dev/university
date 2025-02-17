namespace lab4
{
    partial class VisitorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            VisitorName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            VisitorPhone = new TextBox();
            label3 = new Label();
            VisitorAge = new NumericUpDown();
            listBox1 = new ListBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)VisitorAge).BeginInit();
            SuspendLayout();
            // 
            // VisitorName
            // 
            VisitorName.Location = new Point(118, 30);
            VisitorName.Name = "VisitorName";
            VisitorName.Size = new Size(241, 23);
            VisitorName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Телефон";
            // 
            // VisitorPhone
            // 
            VisitorPhone.Location = new Point(118, 59);
            VisitorPhone.Name = "VisitorPhone";
            VisitorPhone.Size = new Size(241, 23);
            VisitorPhone.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Возраст";
            // 
            // VisitorAge
            // 
            VisitorAge.Location = new Point(118, 91);
            VisitorAge.Name = "VisitorAge";
            VisitorAge.Size = new Size(241, 23);
            VisitorAge.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(118, 120);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(241, 94);
            listBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 120);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 9;
            label4.Text = "Номера";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(12, 251);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(284, 251);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // Visitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 286);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(VisitorAge);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(VisitorPhone);
            Controls.Add(label1);
            Controls.Add(VisitorName);
            Name = "Visitor";
            Text = "Посетитель";
            ((System.ComponentModel.ISupportInitialize)VisitorAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        protected internal TextBox VisitorName;
        protected internal TextBox VisitorPhone;
        protected internal NumericUpDown VisitorAge;
        protected internal ListBox listBox1;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
    }
}