using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlagColorFinder
{
    public partial class welcomeScreen : Form
    {
        public static int smallNum = 0;
        the_ocde the_Ocde = new the_ocde();
        SoundPlayer splat = new SoundPlayer(@"C:\Users\user\source\repos\FlagColorFinder\FlagColorFinder\lancer-splat.wav");
        int howMany = 1;
        public welcomeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            startButton.Visible = false;
            alphabetical.Visible = true;
            reverseAlphabetical.Visible = true;
            bigSmall.Visible = true;
            smallBig.Visible = true;
            colorNameLabel.Visible = true;
            colorValueLabel.Visible = true;
            colorOrder.Visible = true;
            reverseColorOrder.Visible = true;
            comboBox.Visible = true;
            smallestNumInput.Visible = true;
            smallLabel.Visible = true;
            // Replace "your_sound_file.wav" with the actual path to your .wav file
            splat.Play();
        }
        private void welcomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void alphabetical_Click(object sender, EventArgs e)
        {
            splat.Play();
            string[] label = [""];
            if (howMany == 1)
            {
                label = the_Ocde.Sorter(0);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
            }
            if (howMany == 2)
            {
                label = the_Ocde.DoubleSorter(0);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
            }
        }
        private void reverseAlphabetical_Click(object sender, EventArgs e)
        {
            splat.Play();
            string[] label = [""];
            if (howMany == 1)
            {
                label = the_Ocde.Sorter(1);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
            }
            if (howMany == 2)
            {
                label = the_Ocde.DoubleSorter(1);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
            }
        }

        private void smallBig_Click(object sender, EventArgs e)
        {
            splat.Play();
            string[] label = [""];
            if (howMany == 1)
            {
                label = the_Ocde.Sorter(2);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
            }
            if (howMany == 2)
            {
                label = the_Ocde.DoubleSorter(2);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
            }
        }

        private void bigSmall_Click(object sender, EventArgs e)
        {
            splat.Play();
            string[] label = [""];
            if (howMany == 1)
            {
                label = the_Ocde.Sorter(3);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
            }
            if (howMany == 2)
            {
                label = the_Ocde.DoubleSorter(3);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void colorOrder_Click(object sender, EventArgs e)
        {
            splat.Play();
            string[] label = [""];
            if (howMany == 1)
            {
                label = the_Ocde.Sorter(4);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
            }
            if (howMany == 2)
            {
                label = the_Ocde.DoubleSorter(4);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
            }
        }

        private void reverseColor_Click(object sender, EventArgs e)
        {
            splat.Play();
            string[] label = [""];
            if (howMany == 1)
            {
                label = the_Ocde.Sorter(5);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
            }
            if (howMany == 2)
            {
                label = the_Ocde.DoubleSorter(5);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            splat.Play();
            string[] label = [""];
            if (comboBox.SelectedIndex == 0)
            {
                howMany = 1;
                label = the_Ocde.Sorter(2);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
                vScrollBar1.Visible = false;
            }
            if (comboBox.SelectedIndex == 1)
            {
                howMany = 2;
                label = the_Ocde.DoubleSorter(2);
                colorNameLabel.Text = label[0];
                colorValueLabel.Text = label[1];
                vScrollBar1.Visible = true;
            }
        }

        int scrollPos = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (smallestNumInput.Text != null)
                if (int.TryParse(smallestNumInput.Text, out smallNum))
                {
                    splat.Play();

                    string[] label = [""];
                    if (comboBox.SelectedIndex == 0)
                    {
                        howMany = 1;
                        label = the_Ocde.Sorter(2);
                        colorNameLabel.Text = label[0];
                        colorValueLabel.Text = label[1];
                        vScrollBar1.Visible = false;
                    }
                    if (comboBox.SelectedIndex == 1)
                    {
                        howMany = 2;
                        label = the_Ocde.DoubleSorter(2);
                        colorNameLabel.Text = label[0];
                        colorValueLabel.Text = label[1];
                        vScrollBar1.Visible = true;
                    }

                    string[] numOfVals = the_Ocde.DoubleSorter(2);
                    scrollPos = 0;
                    vScrollBar1.Value = scrollPos;
                    if (smallNum <= 28)
                    {
                        colorNameLabel.Location = new Point(274, 25);
                        colorValueLabel.Location = new Point(395, 25);
                        vScrollBar1.Maximum = (int)((double)(numOfVals[1].Length) * (numOfVals[1].Length) * 1/150);
                    }
                    else
                    {
                        vScrollBar1.Maximum = 0;
                    }
                }
        }

        int yPos = 0;
        int factor;
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            factor = -6;
            yPos = colorNameLabel.Location.Y + (factor * e.NewValue - factor * e.OldValue);
            colorNameLabel.Location = new Point(274, yPos);
            colorValueLabel.Location = new Point(395, yPos);
        }
    }
}
