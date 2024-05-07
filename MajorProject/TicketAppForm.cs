using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            LoadTicketInformation();
        }

        private void LoadTicketInformation()
        {
            string connectionString = "YourConnectionStringHere";

            string query = "SELECT * FROM Tickets";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();
                            string destination = reader["Destination"].ToString();
                            string seat = reader["Seat"].ToString();

                            lblName.Text = firstName + " " + lastName;
                            lblDestination.Text = "Destination: " + destination;
                            lblSeat.Text = "Seat: " + seat;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tickets found.");
                    }

                    reader.Close();
                }
            }
        }
    }
}
