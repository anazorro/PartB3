using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453PartB3
{
    public partial class CurrencyForm : Form
    {
        private decimal pounds;

        public CurrencyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure?", "Check",  MessageBoxButtons.YesNo);

            if(answer == DialogResult.Yes)
            {
                MessageBox.Show("Masochist!", "Reply");
            }
            else
            {
                MessageBox.Show("So you don't like challeges in your life, Eh?");
            }
            Close();
        }

        private void dollarsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pounds = Convert.ToDecimal(poundsTextBox.Text);
            decimal dollars = pounds * 1.3m;
            amountTextBox.Text = dollars.ToString("$#.00");
        }
    }
}