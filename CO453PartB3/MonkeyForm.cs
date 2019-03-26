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
    public partial class MonkeyForm : Form
    {
        private int x;
        private int y;

        private int hits, misses;

        private Random generator = new Random();

        public MonkeyForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameTimer.Start();

            hits = 0;
            misses = 0;
            DisplayResults();
        }

        private void DisplayResults()
        {
            hitsLabel.Text = hits.ToString("Hits = 0");
            missLabel.Text = misses.ToString("Miss = 0");
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// (pictureBox1_Click
        /// If the Picture box is clicked then the monkey has been
        /// hit (PictureBoxk.Click)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HitMonkey(object sender, EventArgs e)
        {
            if (gameTimer.Enabled)
            {
                hits++;
                DisplayResults();
            }
        }
        /// <summary>
        /// Mouse Down to GetXY
        /// Get x and y coordinates of the mouse when down
        /// on the PictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetXY(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            xyLabel.Text = String.Format("XY = ({0},{1})", x, y);
        }
        /// <summary>
        /// If the panel is clicked on then the player has missed
        /// the monkey (Panel.Click)
        /// </summary>
        private void MissMonkey(object sender, EventArgs e)
        {
            if (gameTimer.Enabled)
            {
                misses++;
                DisplayResults();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            x = generator.Next(gamePanel.Width - pictureBox1.Width);
            y = generator.Next(gamePanel.Height - pictureBox1.Height);

            pictureBox1.Left = x;
            pictureBox1.Top = y;

            Refresh();
        }
    }
}
