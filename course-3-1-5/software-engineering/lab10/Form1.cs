using System.Numerics;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int totalCharacters = textBox1.Text.Length;

            cursorPositionControl1.UpdateCursorCharacters(totalCharacters);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            var vector = new Vector2(e.Location.X, e.Location.Y);

            cursorPositionControl1.UpdateCursorPosition(vector);
        }
    }
}
