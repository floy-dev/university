namespace lab5
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Count = new DataGridViewTextBoxColumn();
            DataGridName = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(410, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 189);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Count, DataGridName });
            dataGridView1.Location = new Point(37, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 189);
            dataGridView1.TabIndex = 1;
            // 
            // Count
            // 
            Count.HeaderText = "Количество";
            Count.Name = "Count";
            // 
            // DataGridName
            // 
            DataGridName.HeaderText = "Название";
            DataGridName.Name = "DataGridName";
            DataGridName.Width = 200;
            // 
            // button1
            // 
            button1.Location = new Point(410, 252);
            button1.Name = "button1";
            button1.Size = new Size(224, 40);
            button1.TabIndex = 2;
            button1.Text = "Отрисовать график";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 316);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "График";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn DataGridName;
    }
}
