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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DepTime = DepartureTimeTextBox.Text;
            string ArrTime = ArrivalTimeTextBox.Text;

            bool DepTimeCheck = CheckFormat(DepTime);
            bool ArrTimeCheck = CheckFormat(ArrTime);
            if (trainNameTextBox.Text == "" | DepartureCitytextBox.Text == "" | ArrivalCityTextBox.Text == "" | DepartureTimeTextBox.Text == "" | ArrivalTimeTextBox.Text == "" |  CapacityTextBox.Text == "")
            {
                MessageBox.Show("You didn't enter something in");
            }
           else if (DepTimeCheck & ArrTimeCheck)
            {
                Int32.TryParse(CapacityTextBox.Text, out int capacity);
                string query = "INSERT INTO Tracks VALUES (@TrainName, @Dep, @Arr, @DepTime,@ArrTime, @Capacity, @Remaining_Seats)";

                SqlConnection connection = new SqlConnection(StaticData.conString);

                connection.Open();

                SqlCommand addTrack = new SqlCommand(query, connection);


                addTrack.Parameters.Clear();
                addTrack.Parameters.AddWithValue("@TrainName", trainNameTextBox.Text);
                addTrack.Parameters.AddWithValue("@Dep", DepartureCitytextBox.Text);
                addTrack.Parameters.AddWithValue("@Arr", ArrivalCityTextBox.Text);
                addTrack.Parameters.AddWithValue("@DepTime", DepartureTimeTextBox.Text);
                addTrack.Parameters.AddWithValue("@ArrTime", ArrivalTimeTextBox.Text);
                addTrack.Parameters.AddWithValue("@Capacity", capacity);
                addTrack.Parameters.AddWithValue("@Remaining_Seats", capacity);
                addTrack.ExecuteNonQuery();



                SqlCommand getId = new SqlCommand("Select max(Track_ID) from Tracks", connection);
                int latestId = Convert.ToInt32(getId.ExecuteScalar());
                MessageBox.Show($"{latestId}");

                string addingcostsquery = "Insert into Costs values (@ID, 'first class', '19.19'), (@ID, 'second class','14.99'), (@ID, 'third class', '9.99')";
                SqlCommand addCosts = new SqlCommand(addingcostsquery, connection);
                addCosts.Parameters.AddWithValue("@ID", latestId);
                addCosts.ExecuteNonQuery();



                MessageBox.Show("Record added succesfully");
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
        static bool CheckFormat(string input)
        {
            // Check length of the string
            if (input.Length != 19)
            {
                return false;
            }

            // Check positions of dashes and colons
            if (input[4] != '-' || input[7] != '-' || input[10] != ' ' || input[13] != ':' || input[16] != ':')
            {
                return false;
            }

            // Check if each character in positions 0-3, 5-6, 8-9, 11-12, 14-15, 17-18 are digits
            for (int i = 0; i < input.Length; i++)
            {
                if ((i < 4 || (i > 4 && i < 7) || (i > 7 && i < 10) || (i > 10 && i < 13) || (i > 13 && i < 16) || (i > 16 && i < 19)) && !char.IsDigit(input[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}


