namespace lab4
{
    public partial class Form1 : Form
    {
        Bitmap memoryImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "HP LaserJet 1300";
            comboBox1.SelectedValue = "HP LaserJet 1300";

            comboBox2.Text = "���������� ��� ��������";
            comboBox2.SelectedValue = "���������� ��� ��������";

            comboBox3.Text = "������������� ������";
            comboBox3.SelectedValue = "������������� ������";

            comboBox4.Text = "��������� �� ������";
            comboBox4.SelectedValue = "��������� �� ������";

            comboBox5.Text = "������� ���������";
            comboBox5.SelectedValue = "������� ���������";

            comboBox6.Text = "�4";
            comboBox6.SelectedValue = "�4";

            comboBox7.Text = "������������� ����";
            comboBox7.SelectedValue = "������������� ����";

            comboBox8.Text = "1 �������� �� �����";
            comboBox8.SelectedValue = "1 �������� �� �����";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeForm timeForm = new TimeForm();

            timeForm.Show();
        }
    }
}
