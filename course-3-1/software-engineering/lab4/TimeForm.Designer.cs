namespace lab4
{
    partial class TimeForm
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
            button1 = new Button();
            hoursInput = new NumericUpDown();
            minutesInput = new NumericUpDown();
            label1 = new Label();
            secondsInput = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            timeLabel = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)hoursInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutesInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondsInput).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 171);
            button1.Name = "button1";
            button1.Size = new Size(156, 30);
            button1.TabIndex = 0;
            button1.Text = "Сменить цвет кнопок";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // hoursInput
            // 
            hoursInput.Location = new Point(12, 36);
            hoursInput.Name = "hoursInput";
            hoursInput.Size = new Size(81, 23);
            hoursInput.TabIndex = 1;
            // 
            // minutesInput
            // 
            minutesInput.Location = new Point(99, 36);
            minutesInput.Name = "minutesInput";
            minutesInput.Size = new Size(81, 23);
            minutesInput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Часы";
            // 
            // secondsInput
            // 
            secondsInput.Location = new Point(186, 36);
            secondsInput.Name = "secondsInput";
            secondsInput.Size = new Size(81, 23);
            secondsInput.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 16);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Минуты";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 16);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Секунды";
            // 
            // button2
            // 
            button2.Location = new Point(12, 76);
            button2.Name = "button2";
            button2.Size = new Size(156, 30);
            button2.TabIndex = 7;
            button2.Text = "Установить время";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 112);
            button3.Name = "button3";
            button3.Size = new Size(156, 30);
            button3.TabIndex = 8;
            button3.Text = "Показать время";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(174, 76);
            button4.Name = "button4";
            button4.Size = new Size(156, 30);
            button4.TabIndex = 9;
            button4.Text = "Добавить одну минуту";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(174, 112);
            button5.Name = "button5";
            button5.Size = new Size(156, 30);
            button5.TabIndex = 10;
            button5.Text = "Убавить одну минуту";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(336, 76);
            button6.Name = "button6";
            button6.Size = new Size(156, 30);
            button6.TabIndex = 11;
            button6.Text = "Добавить секунду";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timeLabel.Location = new Point(352, 36);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(140, 23);
            timeLabel.TabIndex = 12;
            timeLabel.Text = "Время: 00:00:00";
            // 
            // button7
            // 
            button7.Location = new Point(336, 112);
            button7.Name = "button7";
            button7.Size = new Size(156, 30);
            button7.TabIndex = 13;
            button7.Text = "Убавить секунду";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // TimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 219);
            Controls.Add(button7);
            Controls.Add(timeLabel);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(secondsInput);
            Controls.Add(label1);
            Controls.Add(minutesInput);
            Controls.Add(hoursInput);
            Controls.Add(button1);
            Name = "TimeForm";
            Text = "Время";
            ((System.ComponentModel.ISupportInitialize)hoursInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutesInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondsInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private NumericUpDown hoursInput;
        private NumericUpDown minutesInput;
        private Label label1;
        private NumericUpDown secondsInput;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label timeLabel;
        private Button button7;
    }
}