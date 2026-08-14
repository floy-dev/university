using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;
using System;

namespace lab7
{
    public partial class Form1 : Form
    {
        private ArrayList timeList = [];

        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = timeList.Cast<Time>().ToList();

            renameDataGridColumns();
        }

        private void renameDataGridColumns()
        {
            dataGridView1.Columns[0].HeaderText = "Часы";
            dataGridView1.Columns[1].HeaderText = "Минуты";
            dataGridView1.Columns[2].HeaderText = "Секунды";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                uint hours = uint.Parse(timeHours.Text);
                uint minutes = uint.Parse(timeMinutes.Text);
                uint seconds = uint.Parse(timeSeconds.Text);

                var newTime = new Time(hours, minutes, seconds);

                timeList.Add(newTime);

                dataGridView1.DataSource = timeList.Cast<Time>().ToList();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ИТЗ-221 Дмитриев Дмитрий");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timeList = new ArrayList();

            dataGridView1.DataSource = timeList.Cast<Time>().ToList();

            panel1.Visible = true;
        }

        private void просмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timeList.Sort(new TimeComaprer());

            dataGridView1.DataSource = timeList.Cast<Time>().ToList();
        }

        private void Линейный_Click(object sender, EventArgs e)
        {
            uint hours = uint.Parse(timeHours.Text);
            uint minutes = uint.Parse(timeMinutes.Text);
            uint seconds = uint.Parse(timeSeconds.Text);

            var targetTime = new Time(hours, minutes, seconds);

            bool isTimeFound = LinearSearch(targetTime);

            if (!isTimeFound)
            {
                MessageBox.Show("Время не найдено.");
            }
        }

        private void бинарныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uint hours = uint.Parse(timeHours.Text);
            uint minutes = uint.Parse(timeMinutes.Text);
            uint seconds = uint.Parse(timeSeconds.Text);

            var targetTime = new Time(hours, minutes, seconds);

            bool isTimeFound = BinarySearch(targetTime);

            if (!isTimeFound)
            {
                MessageBox.Show("Время не найдено.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = timeList.Cast<Time>().ToList();

            button1.Visible = true;
            button2.Visible = false;
        }

        private bool LinearSearch(Time target)
        {
            ArrayList tempTimeList = [];

            foreach (Time time in timeList)
            {
                if (Time.DifferenceInSeconds(time, target) == 0)
                {
                    tempTimeList.Add(time);

                    dataGridView1.DataSource = tempTimeList.Cast<Time>().ToList();

                    button1.Visible = false;
                    button2.Visible = true;

                    return true;
                }
            }

            return false;
        }

        private bool BinarySearch(Time target)
        {
            timeList.Sort(new TimeComaprer());

            int low = 0;
            int high = timeList.Count - 1;
            ArrayList tempTimeList = [];

            while (low <= high)
            {
                int mid = (low + high) / 2;

                Time midTime = (Time)timeList[mid];

                if (Time.DifferenceInSeconds(midTime, target) == 0)
                {
                    tempTimeList.Add(midTime);

                    dataGridView1.DataSource = tempTimeList.Cast<Time>().ToList();

                    button1.Visible = false;

                    button2.Visible = true;

                    return true;
                }
                else if (midTime.ToSeconds() > target.ToSeconds())
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return false;
        }

        private void элементыСНаименьшейРазницейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Time[] timeArray = timeList.Cast<Time>().ToArray();

            if (timeArray.Length < 2)
            {
                return;
            }

            int minDiff = int.MaxValue;

            Time[] closestTimes = new Time[2];

            for (int i = 0; i < timeArray.Length; i++)
            {
                for (int j = i + 1; j < timeArray.Length; j++)
                {
                    int diff = Time.DifferenceInSeconds(timeArray[i], timeArray[j]);

                    if (diff < minDiff)
                    {
                        minDiff = diff;
                        closestTimes[0] = timeArray[i];
                        closestTimes[1] = timeArray[j];
                    }
                }
            }

            dataGridView1.DataSource = closestTimes.Cast<Time>().ToList();

            button1.Visible = false;
            button2.Visible = true;
        }

        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var timeOfDayGroups = timeList.Cast<Time>().GroupBy(time => time.GetTimeOfDay());

            if (timeOfDayGroups.Count() == 0)
            {
                return;
            }

            var maxGroup = timeOfDayGroups.OrderByDescending(group => group.Count()).First();

            MessageBox.Show($"Для времени суток '{maxGroup.Key}' максимальное количество элементов: {maxGroup.Count()}");
        }
    }
}
