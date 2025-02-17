namespace lab4
{
    partial class RoomForm
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
            button2 = new Button();
            button1 = new Button();
            RoomPrice = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            RoomFloor = new TextBox();
            label1 = new Label();
            RoomNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)RoomPrice).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(290, 126);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 21;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(18, 126);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // RoomPrice
            // 
            RoomPrice.Location = new Point(124, 86);
            RoomPrice.Name = "RoomPrice";
            RoomPrice.Size = new Size(241, 23);
            RoomPrice.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 86);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 16;
            label3.Text = "Цена";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 57);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 15;
            label2.Text = "Этаж";
            // 
            // RoomFloor
            // 
            RoomFloor.Location = new Point(124, 54);
            RoomFloor.Name = "RoomFloor";
            RoomFloor.Size = new Size(241, 23);
            RoomFloor.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 13;
            label1.Text = "Номер комнаты";
            // 
            // RoomNumber
            // 
            RoomNumber.Location = new Point(124, 25);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new Size(241, 23);
            RoomNumber.TabIndex = 12;
            // 
            // Room
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 174);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(RoomPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RoomFloor);
            Controls.Add(label1);
            Controls.Add(RoomNumber);
            Name = "Room";
            Text = "Апартаменты";
            ((System.ComponentModel.ISupportInitialize)RoomPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        protected internal NumericUpDown RoomPrice;
        private Label label3;
        private Label label2;
        protected internal TextBox RoomFloor;
        private Label label1;
        protected internal TextBox RoomNumber;
    }
}