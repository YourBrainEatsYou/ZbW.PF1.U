using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01
{
    public partial class Exercise01 : Form
    {
        private int count = 0; 
        
        public Exercise01()
        {
            InitializeComponent();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            count += 1;
            SetLabelContent("+");
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            count -= 0;
            SetLabelContent("-");
        }

        private void SetLabelContent(string value)
        {
            LblOutput.Text = value;
        }
    }
}
