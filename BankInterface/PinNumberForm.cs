using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankInterface
{
    public partial class PinNumberForm : Form
    {
        public PinNumberForm()
        {
            InitializeComponent();
        }

        private void pinPad1_Click(object sender, EventArgs e)
        {
            pinNumberBox.AppendText("1");
        }

        private void pinPad2_Click(object sender, EventArgs e)
        {
            pinNumberBox.AppendText("2");
        }

        private void pinPad3_Click(object sender, EventArgs e)
        {
            pinNumberBox.AppendText("3");
        }

        private void pinPad4_Click(object sender, EventArgs e)
        {
            pinNumberBox.AppendText("4");
        }

        private void pinPad5_Click(object sender, EventArgs e)
        {
            pinNumberBox.AppendText("5");
        }

        private void pinPad6_Click(object sender, EventArgs e)
        {
            pinNumberBox.AppendText("6");
        }

        private void pinPad7_Click(object sender, EventArgs e)
        {
            pinNumberBox.AppendText("7");
        }

        private void pinPad8_Click(object sender, EventArgs e)
        {
            pinNumberBox.AppendText("8");
        }

        private void pinPad9_Click(object sender, EventArgs e)
        {
            pinNumberBox.AppendText("9");
        }

        private void pinPad0_Click(object sender, EventArgs e)
        {
            pinNumberBox.AppendText("0");
        }

        private void pinPadOK_Click(object sender, EventArgs e)
        {
            if (String.Equals(pinNumberBox.Text, "1234", StringComparison.Ordinal))
            {
                MessageBox.Show("Valid PIN");
            }

            else
            {
                MessageBox.Show("Invalid PIN");
            }
        }

        private void pinPadClear_Click(object sender, EventArgs e)
        {
            pinNumberBox.Text = "";
        }

        private void pinBackspace_Click(object sender, EventArgs e)
        {
            if(pinNumberBox.Text.Length >0)
            pinNumberBox.Text = pinNumberBox.Text.Remove((pinNumberBox.Text.Length - 1), 1); //removes one char from end of pin text box
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
