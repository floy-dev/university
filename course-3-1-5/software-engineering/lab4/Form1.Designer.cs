namespace lab4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            comboBox8 = new ComboBox();
            comboBox7 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            comboBox1 = new ComboBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            textBox2 = new TextBox();
            panel2 = new Panel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(linkLabel2);
            splitContainer1.Panel1.Controls.Add(comboBox8);
            splitContainer1.Panel1.Controls.Add(comboBox7);
            splitContainer1.Panel1.Controls.Add(comboBox6);
            splitContainer1.Panel1.Controls.Add(comboBox5);
            splitContainer1.Panel1.Controls.Add(comboBox4);
            splitContainer1.Panel1.Controls.Add(comboBox3);
            splitContainer1.Panel1.Controls.Add(pictureBox3);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            splitContainer1.Panel1.Controls.Add(comboBox2);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(linkLabel1);
            splitContainer1.Panel1.Controls.Add(comboBox1);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(numericUpDown1);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1243, 848);
            splitContainer1.SplitterDistance = 303;
            splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(37, 800);
            button1.Name = "button1";
            button1.Size = new Size(100, 36);
            button1.TabIndex = 21;
            button1.Text = "Время";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabel2.Location = new Point(144, 627);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(128, 15);
            linkLabel2.TabIndex = 20;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Параметры страницы";
            // 
            // comboBox8
            // 
            comboBox8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "1 страница на листе", "2 страницы на листе", "4 страницы на листе", "6 страниц на листе", "8 страниц на листе", "16 страниц на листе" });
            comboBox8.Location = new Point(37, 588);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(232, 33);
            comboBox8.TabIndex = 19;
            comboBox8.Text = "1 страница на листе";
            // 
            // comboBox7
            // 
            comboBox7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Настраиваемые поля", "Обычные", "Узкие", "Средние", "Широкие", "Зеркальные" });
            comboBox7.Location = new Point(37, 544);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(232, 33);
            comboBox7.TabIndex = 18;
            comboBox7.Text = "Настраиваемые поля";
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "А4", "A5", "A3", "B4 (JIS)", "B5 (JIS)", "Letter", "Legal", "Statement", "Executive", "11 x 17" });
            comboBox6.Location = new Point(37, 500);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(232, 33);
            comboBox6.TabIndex = 17;
            comboBox6.Text = "А4";
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Книжная оринтация", "Альбомная ориентация" });
            comboBox5.Location = new Point(37, 456);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(232, 33);
            comboBox5.TabIndex = 16;
            comboBox5.Text = "Книжная оринтация";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Разобрать по копиям", "Не разбирать по копиям" });
            comboBox4.Location = new Point(37, 413);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(232, 33);
            comboBox4.TabIndex = 15;
            comboBox4.Text = "Разобрать по копиям";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Односторонняя печать", "Двусторонняя печать (относительно дальнего края)", "Двусторонняя печать (относительно ближнего края)" });
            comboBox3.Location = new Point(37, 369);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(232, 33);
            comboBox3.TabIndex = 14;
            comboBox3.Text = "Односторонняя печать";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(253, 341);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 14);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 336);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 339);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 11;
            label6.Text = "Страницы:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(253, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 14);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Напечатать все страницы", "Напечатать выделенный фрагмент", "Напечатать текущую страницу", "Настраевамая печать" });
            comboBox2.Location = new Point(37, 295);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(232, 33);
            comboBox2.TabIndex = 8;
            comboBox2.Text = "Напечатать все страницы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.SteelBlue;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(37, 262);
            label4.Name = "label4";
            label4.Size = new Size(131, 32);
            label4.TabIndex = 7;
            label4.Text = "Параметры";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.UseCompatibleTextRendering = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabel1.Location = new Point(159, 227);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Свойства принтера";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "HP LaserJet 1300", "HP LaserJet 2300", "HP LaserFull 2000" });
            comboBox1.Location = new Point(37, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 33);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "HP LaserJet 1300";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.SteelBlue;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(38, 155);
            label3.Name = "label3";
            label3.Size = new Size(101, 32);
            label3.TabIndex = 4;
            label3.Text = "Принтер";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.UseCompatibleTextRendering = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(209, 43);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(60, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 45);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Копии:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(37, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 100);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 39);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(23, 71);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 0;
            label1.Text = "Печать";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Window;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(125, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(685, 770);
            panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(0, 0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(683, 768);
            textBox2.TabIndex = 0;
            textBox2.Text = resources.GetString("textBox2.Text");
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Location = new Point(0, 9);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 828);
            panel2.TabIndex = 0;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 848);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Печать";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Panel panel2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private LinkLabel linkLabel1;
        private Label label4;
        private PictureBox pictureBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private Label label6;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private LinkLabel linkLabel2;
        private Panel panel3;
        private TextBox textBox2;
        private Button button1;
    }
}
