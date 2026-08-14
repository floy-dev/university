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
    public partial class AreaConversionControl : UserControl
    {
        public AreaConversionControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = ConvertArea(Convert.ToDouble(comboBoxUnit1.getInputValue()), comboBoxUnit1.getUnit(), comboBoxUnit2.getUnit());

            comboBoxUnit2.setInputValue(Convert.ToString(value));
        }

        public double ConvertArea(double value, string fromUnit, string toUnit)
        {
            double factor = 1;

            if (fromUnit == "м²" && toUnit == "км²")
            {
                factor = 0.000001;
            }
            else if (fromUnit == "м²" && toUnit == "акры")
            {
                factor = 0.000247105;
            }
            else if (fromUnit == "акры" && toUnit == "м²")
            {
                factor = 4046.86;
            }
            else if (fromUnit == "акры" && toUnit == "км²")
            {
                factor = 0.00404686;
            }
            else if (fromUnit == "км²" && toUnit == "акры")
            {
                factor = 247.105;
            }
            else if (fromUnit == "км²" && toUnit == "м²")
            {
                factor = 1000000;
            }

            return value * factor;
        }
    }
}
