using lab4.Context;

namespace lab4;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        dataGridView1 = new DataGridView();
        idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        roomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        visitorBindingSource = new BindingSource(components);
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)visitorBindingSource).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, roomDataGridViewTextBoxColumn });
        dataGridView1.DataSource = visitorBindingSource;
        dataGridView1.Location = new Point(20, 12);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(543, 290);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // idDataGridViewTextBoxColumn
        // 
        idDataGridViewTextBoxColumn.DataPropertyName = "Id";
        idDataGridViewTextBoxColumn.HeaderText = "Id";
        idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
        // 
        // nameDataGridViewTextBoxColumn
        // 
        nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
        nameDataGridViewTextBoxColumn.HeaderText = "Имя";
        nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
        // 
        // phoneDataGridViewTextBoxColumn
        // 
        phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
        phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
        phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
        // 
        // ageDataGridViewTextBoxColumn
        // 
        ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
        ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
        ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
        // 
        // roomDataGridViewTextBoxColumn
        // 
        roomDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
        roomDataGridViewTextBoxColumn.HeaderText = "Комната";
        roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
        // 
        // visitorBindingSource
        // 
        visitorBindingSource.DataSource = typeof(Entity.Visitor);
        // 
        // button1
        // 
        button1.Location = new Point(20, 322);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 1;
        button1.Text = "Добавить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(248, 322);
        button2.Name = "button2";
        button2.Size = new Size(75, 23);
        button2.TabIndex = 2;
        button2.Text = "Изменить";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(488, 322);
        button3.Name = "button3";
        button3.Size = new Size(75, 23);
        button3.TabIndex = 3;
        button3.Text = "Удалить";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new Point(207, 359);
        button4.Name = "button4";
        button4.Size = new Size(160, 23);
        button4.TabIndex = 4;
        button4.Text = "Добавить номер";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(575, 394);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(dataGridView1);
        Name = "Form1";
        Text = "Список посетителей";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)visitorBindingSource).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.DataGridView dataGridView1;

#endregion
    private BindingSource visitorBindingSource;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
}