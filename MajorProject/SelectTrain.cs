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
        string selectedClass = "";
        int numberTickets = 0;
        int remainingSeats = 0;
        int trackID = 0;
        public SelectTrain()
        {
            InitializeComponent();
            selectedClass = firstClassRadioButton.Text;
        }

        private void trackIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(trackIDTextBox.Text))
            {
                invalidTrackID();
                return;
            }

            if (!int.TryParse(trackIDTextBox.Text, out trackID))
            {
                invalidTrackIDMessage();
                return;
            }

            SqlConnection con = new SqlConnection(StaticData.conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tracks WHERE Track_ID=@id", con);
            cmd.Parameters.AddWithValue("@id", trackIDTextBox.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                con.Close();
                invalidTrackIDMessage();
                return;
            }

            reader.Read();
            remainingSeats = reader.GetInt32(7);
            reader.Close();

            con.Close();

            numberOfTicketsTextBox.Enabled = true;
            classGroupBox.Enabled = true;
            selectTrackLabel.Visible = false;
            selectTrackLabel2.Visible = false;
        }
        private void invalidTrackIDMessage()
        {
            MessageBox.Show("Please enter a valid track ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            invalidTrackID();
        }
        private void invalidTrackID()
        {
            trackIDTextBox.Clear();
            trackIDTextBox.Focus();
            numberOfTicketsTextBox.Clear();
            firstClassRadioButton.Checked = false;
            secondClassRadioButton.Checked = false;
            economyClassRadioButton.Checked = false;
            numberOfTicketsTextBox.Enabled = false;
            classGroupBox.Enabled = false;
            selectedClass = "";
            numberTickets = 0;
            selectTrackLabel.Visible = true;
            selectTrackLabel2.Visible = true;
        }
        private void numberOfTicketsTextBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(numberOfTicketsTextBox.Text))
            {
                return;
            }

            if (!int.TryParse(numberOfTicketsTextBox.Text, out numberTickets))
            {

                MessageBox.Show("Please enter a valid positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberOfTicketsTextBox.Clear();
                return;
            }      
            
            if (remainingSeats < numberTickets)
            {
                MessageBox.Show("You selected more tickets than there are seats left!");
                numberTickets = 0;
                numberOfTicketsTextBox.Text = ""; 
                numberOfTicketsTextBox.Focus();

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
            else
            {
                selectedClass = economyClassRadioButton.Text;

            }
        }
        private void bookTicketsButton_Click(object sender, EventArgs e)
        {

            if(numberTickets == 0 || selectedClass == "")
            {
                MessageBox.Show("Please enter the number of tickets and select a class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int newRemainingSeats = remainingSeats - numberTickets;

            SqlConnection con = new SqlConnection(StaticData.conString);
            con.Open();       
            SqlCommand cmd = new SqlCommand("UPDATE Tracks SET remaining_seats = @newRemainingSeats WHERE Track_ID=@id", con);
            cmd.Parameters.AddWithValue("@id", trackID);
            cmd.Parameters.AddWithValue("@newRemainingSeats", newRemainingSeats);
            con.Close();

            UserBookingInformation form = new UserBookingInformation(trackID, selectedClass, numberTickets);
            form.Show();
        }
    }
}

