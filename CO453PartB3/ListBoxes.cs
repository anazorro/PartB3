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
    public partial class ListBoxes : Form
    {
        private decimal totalCost;
        private decimal starterCost;
        private decimal mainCost;
        private decimal dessertCost;

        List<string> Starter = new List<string>();

        public ListBoxes()
        {
            InitializeComponent();

        }

 
        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

 
        private void listMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(listMain.SelectedIndex) //what is the chosen item from listMain?
            {
                case 0: mainCost = 12.50m; break;
                case 1: mainCost = 7.50m; break;
                case 2: mainCost = 8.00m; break;
                case 3: mainCost = 7.25m; break;
            }

            CalculateTotalCost();
        }

        private void quitButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex) //what is the chosen item from listMain?
            {
                case 0: starterCost = 12.50m; break;
                case 1: starterCost = 7.50m; break;
                case 2: starterCost = 8.00m; break;
            }

            CalculateTotalCost();
        }

        private void CalculateTotalCost()
        {
            totalCost = starterCost + mainCost + dessertCost; //calculate total
            costLabel.Text = totalCost.ToString("c"); //display total
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0 : dessertCost = 6.00m; break;
                case 1 : dessertCost = 5.00m; break;
            }

            CalculateTotalCost();
        }
    }
}
