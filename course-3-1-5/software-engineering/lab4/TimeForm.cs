using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab4.Utils;

namespace lab4
{
    public partial class TimeForm : Form
    {
        Time time;

        public TimeForm()
        {
            InitializeComponent();

            Time time = new Time(0, 0, 0);
            this.time = time;

            timeLabel.Text = time.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.LightGreen;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hours = (int)hoursInput.Value;
            int minutes = (int)minutesInput.Value;
            int seconds = (int)secondsInput.Value;

            try
            {
                time.Hours = Convert.ToUInt32(hours);
                time.Minutes = Convert.ToUInt32(minutes);
                time.Seconds = Convert.ToUInt32(seconds);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            timeLabel.Text = time.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            time += 60;

            timeLabel.Text = time.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            time -= 60;

            timeLabel.Text = time.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            time++;

            timeLabel.Text = time.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            time--;

            timeLabel.Text = time.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayTimeForm form = new DisplayTimeForm();

            form.Show();

            form.TimeToDisplay = time;
        }
    }
}
