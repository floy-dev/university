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

            comboBox2.Text = "Напечатать все страницы";
            comboBox2.SelectedValue = "Напечатать все страницы";

            comboBox3.Text = "Односторонняя печать";
            comboBox3.SelectedValue = "Односторонняя печать";

            comboBox4.Text = "Разобрать по копиям";
            comboBox4.SelectedValue = "Разобрать по копиям";

            comboBox5.Text = "Книжная оринтация";
            comboBox5.SelectedValue = "Книжная оринтация";

            comboBox6.Text = "А4";
            comboBox6.SelectedValue = "А4";

            comboBox7.Text = "Настраиваемые поля";
            comboBox7.SelectedValue = "Настраиваемые поля";

            comboBox8.Text = "1 страница на листе";
            comboBox8.SelectedValue = "1 страница на листе";
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
