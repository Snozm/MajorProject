using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


        int numberTickets = 0;
        int remainingSeats = 0;

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

                if (!int.TryParse(numberOfTicketsTextBox.Text, out int numberTickets))
                {

                    MessageBox.Show("Please enter a valid positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numberOfTicketsTextBox.Clear();
                }
                else
                {

                    if (numberTickets <= 0)
                    {

                        MessageBox.Show("Please enter a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        numberOfTicketsTextBox.Clear();
                    }
                    else
                    {
                        

                        int.TryParse(numberOfTicketsTextBox.Text, out numberTickets);
                        SqlConnection con = new SqlConnection(StaticData.conString);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT remaining_seats from Tracks where Track_id=@id", con);
                        cmd.Parameters.AddWithValue("@id", trackIDTextBox.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();

                            remainingSeats = reader.GetInt32(0);

                            reader.Close();

                        }

                        if (remainingSeats >= numberTickets)
                        {
                            MessageBox.Show($"Valid number of tickets, you select {numberTickets} tickets from {remainingSeats} seats left");
                        }
                        else
                        {
                            MessageBox.Show("You selected more tickets than there are seats left!");
                            numberTickets = 0;
                            remainingSeats = 0;
                            numberOfTicketsTextBox.Text = String.Empty; 
                            numberOfTicketsTextBox.Focus();

                        }


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
            selectedClass = firstClassRadioButton.Text;
        }

        private void secondClassRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedClass = secondClassRadioButton.Text;

        }

        private void economyClassRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedClass = economyClassRadioButton.Text;

        }
        private void bookTicketsButton_Click(object sender, EventArgs e)
        {

            int.TryParse(numberOfTicketsTextBox.Text, out numberTickets);

         /*   SqlConnection con = new SqlConnection(StaticData.conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT remaining_seats from Tracks where Track_id=@id", con);
            cmd.Parameters.AddWithValue("@id", trackIDTextBox.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();

                remainingSeats = reader.GetInt32(0);

                reader.Close();

            }
            MessageBox.Show($"{remainingSeats}");
            MessageBox.Show($"{numberTickets}");
            int true_remaining_Seats = remainingSeats - numberTickets;
            MessageBox.Show($"{true_remaining_Seats}");
          
            SqlCommand cmd1 = new SqlCommand("UPDATE Tracks set remaining_seats = @true_remaining_seats where Track_id=@id", con);
            cmd.Parameters.AddWithValue("@id", trackIDTextBox.Text);
            cmd.Parameters.AddWithValue("@true_remaining_seats", true_remaining_Seats);
            con.Close(); */

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

