namespace lab7
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
            menuStrip1 = new MenuStrip();
            коллекциияToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            просмотретьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            работаToolStripMenuItem = new ToolStripMenuItem();
            сортировкаToolStripMenuItem = new ToolStripMenuItem();
            поУбываниюToolStripMenuItem = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            Линейный = new ToolStripMenuItem();
            бинарныйToolStripMenuItem = new ToolStripMenuItem();
            элементыСНаименьшейРазницейToolStripMenuItem = new ToolStripMenuItem();
            заданиеToolStripMenuItem = new ToolStripMenuItem();
            задание1ToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            timeHours = new NumericUpDown();
            timeMinutes = new NumericUpDown();
            label2 = new Label();
            timeSeconds = new NumericUpDown();
            label3 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeSeconds).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { коллекциияToolStripMenuItem, работаToolStripMenuItem, оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(635, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // коллекциияToolStripMenuItem
            // 
            коллекциияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, просмотретьToolStripMenuItem, редактироватьToolStripMenuItem, toolStripSeparator1, сохранитьToolStripMenuItem, загрузитьToolStripMenuItem, выходToolStripMenuItem });
            коллекциияToolStripMenuItem.Name = "коллекциияToolStripMenuItem";
            коллекциияToolStripMenuItem.Size = new Size(98, 24);
            коллекциияToolStripMenuItem.Text = "Коллекция";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(194, 26);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // просмотретьToolStripMenuItem
            // 
            просмотретьToolStripMenuItem.Name = "просмотретьToolStripMenuItem";
            просмотретьToolStripMenuItem.Size = new Size(194, 26);
            просмотретьToolStripMenuItem.Text = "Просмотреть";
            просмотретьToolStripMenuItem.Click += просмотретьToolStripMenuItem_Click;
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(194, 26);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            редактироватьToolStripMenuItem.Click += редактироватьToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(191, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(194, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(194, 26);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(194, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // работаToolStripMenuItem
            // 
            работаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сортировкаToolStripMenuItem, поискToolStripMenuItem, заданиеToolStripMenuItem });
            работаToolStripMenuItem.Name = "работаToolStripMenuItem";
            работаToolStripMenuItem.Size = new Size(71, 24);
            работаToolStripMenuItem.Text = "Работа";
            // 
            // сортировкаToolStripMenuItem
            // 
            сортировкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поУбываниюToolStripMenuItem });
            сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            сортировкаToolStripMenuItem.Size = new Size(224, 26);
            сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поУбываниюToolStripMenuItem
            // 
            поУбываниюToolStripMenuItem.Name = "поУбываниюToolStripMenuItem";
            поУбываниюToolStripMenuItem.Size = new Size(189, 26);
            поУбываниюToolStripMenuItem.Text = "По убыванию";
            поУбываниюToolStripMenuItem.Click += поУбываниюToolStripMenuItem_Click;
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Линейный, бинарныйToolStripMenuItem, элементыСНаименьшейРазницейToolStripMenuItem });
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(224, 26);
            поискToolStripMenuItem.Text = "Поиск";
            // 
            // Линейный
            // 
            Линейный.Name = "Линейный";
            Линейный.Size = new Size(340, 26);
            Линейный.Text = "Линейный";
            Линейный.Click += Линейный_Click;
            // 
            // бинарныйToolStripMenuItem
            // 
            бинарныйToolStripMenuItem.Name = "бинарныйToolStripMenuItem";
            бинарныйToolStripMenuItem.Size = new Size(340, 26);
            бинарныйToolStripMenuItem.Text = "Бинарный";
            бинарныйToolStripMenuItem.Click += бинарныйToolStripMenuItem_Click;
            // 
            // элементыСНаименьшейРазницейToolStripMenuItem
            // 
            элементыСНаименьшейРазницейToolStripMenuItem.Name = "элементыСНаименьшейРазницейToolStripMenuItem";
            элементыСНаименьшейРазницейToolStripMenuItem.Size = new Size(340, 26);
            элементыСНаименьшейРазницейToolStripMenuItem.Text = "Элементы с наименьшей разницей";
            элементыСНаименьшейРазницейToolStripMenuItem.Click += элементыСНаименьшейРазницейToolStripMenuItem_Click;
            // 
            // заданиеToolStripMenuItem
            // 
            заданиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { задание1ToolStripMenuItem });
            заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            заданиеToolStripMenuItem.Size = new Size(224, 26);
            заданиеToolStripMenuItem.Text = "Задание";
            // 
            // задание1ToolStripMenuItem
            // 
            задание1ToolStripMenuItem.Name = "задание1ToolStripMenuItem";
            задание1ToolStripMenuItem.Size = new Size(224, 26);
            задание1ToolStripMenuItem.Text = "Задание 1";
            задание1ToolStripMenuItem.Click += задание1ToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(118, 24);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 68);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(609, 335);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(7, 80);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 44);
            button1.TabIndex = 3;
            button1.Text = "Добавить время";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 4;
            label1.Text = "Часы";
            // 
            // timeHours
            // 
            timeHours.Location = new Point(7, 33);
            timeHours.Name = "timeHours";
            timeHours.Size = new Size(84, 27);
            timeHours.TabIndex = 5;
            // 
            // timeMinutes
            // 
            timeMinutes.Location = new Point(111, 33);
            timeMinutes.Name = "timeMinutes";
            timeMinutes.Size = new Size(84, 27);
            timeMinutes.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 10);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Минуты";
            // 
            // timeSeconds
            // 
            timeSeconds.Location = new Point(216, 33);
            timeSeconds.Name = "timeSeconds";
            timeSeconds.Size = new Size(84, 27);
            timeSeconds.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 10);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 8;
            label3.Text = "Секунды";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(timeSeconds);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(timeHours);
            panel1.Controls.Add(timeMinutes);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 136);
            panel1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(461, 498);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(162, 44);
            button2.TabIndex = 11;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 566);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Время";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeSeconds).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem коллекциияToolStripMenuItem;
        private ToolStripMenuItem работаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private NumericUpDown timeHours;
        private NumericUpDown timeMinutes;
        private Label label2;
        private NumericUpDown timeSeconds;
        private Label label3;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem просмотретьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem сортировкаToolStripMenuItem;
        private ToolStripMenuItem поУбываниюToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem Линейный;
        private ToolStripMenuItem бинарныйToolStripMenuItem;
        private ToolStripMenuItem заданиеToolStripMenuItem;
        private ToolStripMenuItem задание1ToolStripMenuItem;
        private Panel panel1;
        private Button button2;
        private ToolStripMenuItem элементыСНаименьшейРазницейToolStripMenuItem;
    }
}
