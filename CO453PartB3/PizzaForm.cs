using System;
using System.Windows.Forms;

namespace CO453PartB3
{
    public partial class PizzaForm : Form
    {
        private decimal cost = 0;
        private CheckBox[] toppings = new CheckBox[4];

        public PizzaForm()
        {
            InitializeComponent();
            toppings[0] = checkBox1;
            toppings[1] = checkBox2;
            toppings[2] = checkBox3;
            toppings[3] = checkBox4;
        }

        private void CalculateCost(object sender, EventArgs e)
        {
            cost = 0;

            if (largeRadioButton.Checked)
            {
                cost += 5.00m;
            }
            else if(mediumRadioButton.Checked)
            {
                cost += 4.00m;
            }
            else //small
            {
                cost += 3.00m;
            }
            
            foreach(CheckBox topping in toppings)
            {
                if (topping.Checked)
                {
                    cost += 2.50m;
                }
            }
            costLabel.Text = cost.ToString("c");
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}