using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01
{
    public partial class Exercise02 : Form
    {
        public Exercise02()
        {
            InitializeComponent();
        }

        private void SetTextlength(int length)
        {
            NumWordCount.Value = length;
            LblWordCountOutput.Text = length.ToString();

        }

        private int GetNormalizedStringLength(string textWithLineBreaks)
        {
            string cleanupString = Regex.Replace(textWithLineBreaks, @"\t|\n|\r", "");
            return cleanupString.Length;
        }

        private void TxtWordInput_TextChanged(object sender, EventArgs e)
        {
            SetTextlength(GetNormalizedStringLength(TxtWordInput.Text));
        }

        private void BtnShowResult_Click(object sender, EventArgs e)
        {
            LblWordCountOutput.Visible = true;
        }

        private void BtnClearForm_Click(object sender, EventArgs e)
        {
            LblWordCountOutput.Visible = false;
            TxtWordInput.Text = "";
        }
    }
}
