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
    public partial class TipsterForm : Form
    {
        private decimal bill;
        private ResultsForm resultsForm = new ResultsForm();
        private int noPeople;
        private int tip; //percentage

        public TipsterForm()
        {
            InitializeComponent();
        }

        private void QuitForm(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateAmount(object sender, EventArgs e)
        {
            bill = GetBill();

            noPeople = Convert.ToInt16(peopleNumericUpDown.Value);

            

            

            if (noneRadioButton.Checked)
            {
                tip = 0;
            }
            else if(normalRadioButton.Checked)
            {
                tip = 10;
            }
            else if (generousRadioButton.Checked)
            {
                tip = 15;
            }
            else if (madRadioButton.Checked)
            {
                tip = 20;
            }

            resultsForm.noPeople = noPeople;
            bill = bill + tip;
            resultsForm.bill = bill;
            

            decimal pay = bill / noPeople;

            resultsForm.paysTextBox.Text = pay.ToString("c");

            

            resultsForm.totalBillTextBox.Text = bill.ToString("c");
            resultsForm.peopleTextBox.Text = noPeople.ToString();

            resultsForm.Show();
            
        }

        private decimal GetBill()
        {
            try
            {
                bill = Convert.ToDecimal(billTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number","Invalid amount");
                bill = 0;
            }
            
            return bill;

            
        }
    }
}
