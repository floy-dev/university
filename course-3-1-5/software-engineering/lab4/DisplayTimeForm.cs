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
    public partial class DisplayTimeForm : Form
    {
        private Time? timeToDisplay = null;


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Time TimeToDisplay
        {
            set
            {
                timeToDisplay = value;

                displayTime.Text = timeToDisplay.ToString();
            }
        }

        public DisplayTimeForm()
        {
            InitializeComponent();
        }
    }
}
