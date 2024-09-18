using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dec2Hex
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertToHex()
        {
            int decValue = Convert.ToInt32(ToConvert.Text);
            string hexValue = decValue.ToString("X");
            Converted.Text = hexValue;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ConvertToHex();
        }

        private void ToConvert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ConvertToHex();
            }
            e.Handled = !char.IsNumber(e.KeyChar);
        }
    }
}


