using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class comboBoxUnit : UserControl
    {
        public comboBoxUnit()
        {
            InitializeComponent();
        }

        public string getInputValue()
        {
            return textBox1.Text.ToString();
        }

        public void setInputValue(string value)
        {
            textBox1.Text = value;
        }

        public string getUnit()
        {
            return comboBox1.SelectedItem.ToString();
        }
    }
}
