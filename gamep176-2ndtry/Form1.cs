using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamep176_2ndtry
{
    public partial class Form1 : Form
    {
        Stats stats = new Stats();
        Random random = new Random();
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Add a random key to to the ListBox
            listBox1.Items.Add((Keys)random.Next(65, 91));  // 65,91 for A to Z
            if(listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();
                DialogResult dr = MessageBox.Show("Play again",
                      RateGame(), MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        {
                            Restart();
                            break;
                        }
                    case DialogResult.No: break;
                }

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user pressed a key that´s in the ListBox, remove it 
            // and then make the game a little faster

            if(listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyProgressBar1.Value = 800 - timer1.Interval;

                // the user hit the right key, so update the stats with true
                stats.Update(true);
            }
            else
            {
                // the user pressed the incorrect key, so update stats
                stats.Update(false);
            }

            // update the stats
            correctLabel1.Text = "Correct: "+ stats.Correct;
            missedLabel1.Text = "Missed: " + stats.Missed;
            totalLabel1.Text = "Total: " + stats.Total;
            accuracyLabel1.Text = "Accuracy: " + stats.Accuracy + "%";

        }

        private void Restart()
        {
            listBox1.Items.Clear();   // remove all items from list to start again
            stats.ResetStats();   
            timer1.Interval = 800; // initialising timer to initial value of 800msec
            timer1.Start();    // and starts           
        }

        private string RateGame()
        {
            // Returns a string with a rate of the game based on performance 

            string rate;
            if (stats.Accuracy < 50)
                rate = "You need to improve";
            else if (stats.Accuracy >= 50 && stats.Accuracy <= 75)
                rate = "Good accuracy well  done";
            else if (stats.Accuracy > 75 && stats.Accuracy < 95)
                rate = "Very good accuracy!";
            else rate = "You are a master!";

           return rate;
        }
    }

    class Stats
    {
        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public int Accuracy = 0;

        public void Update(bool correctKey)
        {
            Total++;
            if(!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }
            Accuracy = 100 * Correct / (Correct + Missed);
        }
        public void ResetStats()
        {
            Total = 0;
            Missed = 0;
            Correct = 0;
            Accuracy = 0;
        }
    }
}
