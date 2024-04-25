using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MajorProject
{
    public partial class SelectTrain : Form
    {
        string selectedClass;
        public SelectTrain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void trackIDTextBox_TextChanged(object sender, EventArgs e)
        {
            int trackID;
            if (!int.TryParse(trackIDTextBox.Text, out trackID) || trackID <= 0)
            {
                MessageBox.Show("Please enter a positive integer for the track ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trackIDTextBox.Focus();
            }
        }
        private void numberOfTicketsTextBox_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(numberOfTicketsTextBox.Text))
            {

                if (!int.TryParse(numberOfTicketsTextBox.Text, out int number))
                {

                    MessageBox.Show("Please enter a valid positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numberOfTicketsTextBox.Clear();
                }
                else
                {

                    if (number <= 0)
                    {

                        MessageBox.Show("Please enter a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        numberOfTicketsTextBox.Clear();
                    }
                }
            }
        }

        private void searchTracksButton_Click(object sender, EventArgs e)
        {
            TrackSelector form = new TrackSelector();
            form.Show();

        }

        private void classGroupBox_Enter(object sender, EventArgs e)
        {
            if (firstClassRadioButton.Checked)
            {
                selectedClass = firstClassRadioButton.Text;

            }
            else if (secondClassRadioButton.Checked)
            {
                selectedClass = secondClassRadioButton.Text;

            }
            else if (economyClassRadioButton.Checked)
            {
                selectedClass = economyClassRadioButton.Text;

            }
        }

        private void firstClassRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void secondClassRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void economyClassRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void bookTicketsButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(numberOfTicketsTextBox.Text))
            {

                if (int.TryParse(numberOfTicketsTextBox.Text, out int numberOfTickets) && numberOfTickets > 0)
                {

                    for (int i = 0; i < numberOfTickets; i++)
                    {

                        UserBookingInformation form = new UserBookingInformation(Convert.ToInt32(trackIDTextBox.Text), selectedClass);


                        form.Show();
                    }
                }
                else
                {

                    MessageBox.Show("Please enter a valid positive integer for the number of tickets.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter the number of tickets.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bookLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

