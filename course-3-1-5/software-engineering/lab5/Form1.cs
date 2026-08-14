using System.Drawing.Drawing2D;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float total = 0;
            var values = new List<float>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var cellValue = dataGridView1.Rows[i].Cells[0].Value;

                if (cellValue == null)
                {
                    continue;
                }

                if (float.TryParse(cellValue.ToString(), out float value))
                {
                    values.Add(value);
                    total += value;
                }
            }

            DrawChart(values, total);
        }

        private void DrawChart(List<float> values, float total)
        {
            Graphics graphic = panel1.CreateGraphics();

            graphic.Clear(Color.White);

            float startAngle = 0;
            int radius = Math.Min(panel1.Width, panel1.Height) / 2 - 20;
            PointF center = new PointF(panel1.Width / 2, panel1.Height / 2);

            int borderWidth = 1;
            int innerRadius = radius / 2;

            HatchBrush[] brushes = new HatchBrush[]
            {
                new HatchBrush(HatchStyle.Percent90, Color.White, Color.Black),
                new HatchBrush(HatchStyle.Wave, Color.Black, Color.White),
                new HatchBrush(HatchStyle.Percent90, Color.White, Color.White),
            };

            Pen borderPen = new Pen(Color.Black, 1);

            graphic.FillEllipse(Brushes.Black, center.X - radius, center.Y - radius, radius * 2, radius * 2);

            for (int i = 0; i < values.Count; i++)
            {
                float endAngle = (values[i] / total) * 360;

                // график
                graphic.FillPie(brushes[i], center.X - radius, center.Y - radius, radius * 2, radius * 2, startAngle, endAngle);
                // обводка
                graphic.DrawPie(borderPen, center.X - radius, center.Y - radius, radius * 2, radius * 2, startAngle, endAngle);

                startAngle += endAngle;
            }

            graphic.FillEllipse(Brushes.Black, center.X - innerRadius - borderWidth, center.Y - innerRadius - borderWidth, innerRadius * 2 + (borderWidth * 2), innerRadius * 2 + (borderWidth * 2));
            graphic.FillEllipse(Brushes.White, center.X - innerRadius, center.Y - innerRadius, innerRadius * 2, innerRadius * 2);
        }
    }
}
