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

namespace MajorProject
{
    public partial class UserBookingInformation : Form
    {
        int track;
        string classSeat;
        int ticketNo = 1;
        int totalTickets;
        string[] firstNames;
        string[] lastNames;
        public UserBookingInformation(int trackID, string classN, int tickets)
        {
            track = trackID;
            classSeat = classN;
            InitializeComponent();
            travelerInformationLabel.Text += $" {ticketNo}";
            totalTickets = tickets;
            firstNames = new string[totalTickets];
            lastNames = new string[totalTickets];
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            // Validate input (optional)
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter both first name and last name.");
                return;
            }

            firstNames[ticketNo - 1] = firstName;
            lastNames[ticketNo - 1] = lastName;
            ticketNo++;
            if (ticketNo <= totalTickets)
            {
                travelerInformationLabel.Text = $"Traveler Information {ticketNo}";
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                return;
            }

            string query = "INSERT INTO Tickets (Tr_ID, Holder_FirstName, Holder_LastName, specifics) VALUES (@TrackID, @FirstName, @LastName, @ClassSeat)";

            try
            {
                using (SqlConnection connection = new SqlConnection(StaticData.conString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        for (int i = 0; i < totalTickets; i++)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@FirstName", firstNames[i]);
                            command.Parameters.AddWithValue("@LastName", lastNames[i]);
                            command.Parameters.AddWithValue("@ClassSeat", classSeat);
                            command.Parameters.AddWithValue("@TrackID", track);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Names have been successfully recorded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
