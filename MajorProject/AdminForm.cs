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

            Int32.TryParse(CapacityTextBox.Text, out int capacity);
            string query = "INSERT INTO TracksVALUES (@TrainName, @Dep, @Arr, @DepTime,@ArrTime, @Capacity, @Remaining_Seats)";

            SqlConnection connection = new SqlConnection(StaticData.conString);
                
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@TrainName",trainNameTextBox.Text );
                            command.Parameters.AddWithValue("@Dep",DepartureCitytextBox.Text) ;
                            command.Parameters.AddWithValue("@Arr", ArrivalCityTextBox.Text) ;
                            command.Parameters.AddWithValue("@DepTime",DepartureTimeTextBox.Text);
                            command.Parameters.AddWithValue("@ArrTime", ArrivalTimeTextBox.Text);
                command.Parameters.AddWithValue("@Capacity", capacity);
                command.Parameters.AddWithValue("@Remaining_Seats", capacity);



                command.ExecuteNonQuery();
                        

                       
                    }
                }
            }
    }

