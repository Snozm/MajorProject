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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace MajorProject
{
    public partial class Payment : Form
    {
        int track;
        string classSeat;
        string[] firstNames;
        string[] lastNames;
        int totalTickets;
        UserInfo user;
        public Payment(UserInfo userInfo, int trackID, string classN, string[] first, string[] last, int tickets)
        {
            user = userInfo;
            InitializeComponent();
            this.Text = user.username;
            track = trackID;
            classSeat = classN;
            firstNames = first;
            lastNames = last;
            totalTickets = tickets;
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();
            if (!validateCardNumber())
            {
                errors.Add("Invalid card number");
            }
            if (!validateExpirationDate())
            {
                errors.Add("Invalid expiration date");
            }
            if (!validateSecurityCode())
            {
                errors.Add("Invalid security code");
            }
            if (!validateName())
            {
                errors.Add("Invalid name");
            }
            if (!validateCity())
            {
                errors.Add("Invalid city");
            }
            if (!validateAddress())
            {
                errors.Add("Invalid address");
            }
            if (!validateZipCode())
            {
                errors.Add("Invalid zip code");
            }
            if (!validateCountry())
            {
                errors.Add("Invalid country");
            }
            if (!validatePhoneNumber())
            {
                errors.Add("Invalid phone number");
            }
            if (errors.Count > 0)
            {
                string message = "Please fix the following issues:\n";
                for (int i = 0; i < errors.Count; i++)
                {
                    message += errors[i] + "\n";
                }
                MessageBox.Show(message);
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
                        SqlCommand cmd = new SqlCommand("SELECT Arrival FROM Tracks WHERE Track_ID = @trackID", connection);
                        cmd.Parameters.AddWithValue("@trackID", track);
                        string destination = (string)cmd.ExecuteScalar();
                        for (int i = 0; i < totalTickets; i++)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@FirstName", firstNames[i]);
                            command.Parameters.AddWithValue("@LastName", lastNames[i]);
                            command.Parameters.AddWithValue("@ClassSeat", classSeat);
                            command.Parameters.AddWithValue("@TrackID", track);

                            command.ExecuteNonQuery();
                            TicketForm form = new TicketForm(firstNames[i], lastNames[i], destination);
                            form.Show();
                        }

                        cmd = new SqlCommand("UPDATE Tracks SET remaining_seats = ((SELECT remaining_seats FROM Tracks WHERE Track_ID=@trackID) - @totalTickets) WHERE Track_ID = @trackID", connection);
                        cmd.Parameters.AddWithValue("@trackID", track);
                        cmd.Parameters.AddWithValue("@totalTickets", totalTickets);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("SELECT Cost FROM Costs WHERE Track_ID = @trackID AND Specifics = @class", connection);
                        cmd.Parameters.AddWithValue("@trackID", track);
                        cmd.Parameters.AddWithValue("@class", classSeat);
                        double totalPrice = (double)cmd.ExecuteScalar() * totalTickets;
                        MessageBox.Show($"Names have been successfully recorded. Total: {totalPrice}");
                        this.Close();
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private bool validateCardNumber()
        {
            if (!Int64.TryParse(cardNumberTextBox.Text, out long a) || cardNumberTextBox.Text.Length != 16)
            {
                return false;
            }
            return true;
        }
        private bool validateExpirationDate()
        {
            if (expirationMonthComboBox.SelectedIndex == -1 || expirationYearComboBox.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private bool validateSecurityCode()
        {
            if (!int.TryParse(securityCodeTextBox.Text, out int a) || securityCodeTextBox.Text.Length != 3)
            {
                return false;
            }
            return true;
        }

        private bool validateName()
        {
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool validateCity()
        {
            if (cityTextBox.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool validateAddress()
        {
            if (billingAddressTextBox.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool validateZipCode()
        {
            if (!int.TryParse(zipTextBox.Text, out int a) || zipTextBox.Text.Length > 5 || zipTextBox.Text.Length < 4)
            {
                return false;
            }
            return true;
        }

        private bool validateCountry()
        {
            if(countryComboBox.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }
        private bool validatePhoneNumber()
        {
            if(!Int64.TryParse(phoneNumberTextBox.Text, out long a) || phoneNumberTextBox.Text.Length != 10)
            {
                return false;
            }
            return true;
        }
    }
}
