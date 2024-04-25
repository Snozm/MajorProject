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
        public UserBookingInformation(int trackID, string classN)
        {
            track = trackID;
            classSeat = classN;
            InitializeComponent();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

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

            

            // SQL query to insert data into the database
            string query = "INSERT INTO UserBooking (Tr_ID, Holder_FirstName, Holder_LastName, specifics) VALUES (@TrackID, @FirstName, @LastName, @ClassSeat)";

            try
            {
                using (SqlConnection connection = new SqlConnection(StaticData.conString))
                {
                    // Open the connection
                    connection.Open();

                    // Create command with parameters
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@ClassSeat", classSeat);
                        command.Parameters.AddWithValue("@TrackID", track);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data saved successfully.");
                            // Optionally, you can clear the textboxes after saving
                            firstNameTextBox.Clear();
                            lastNameTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
