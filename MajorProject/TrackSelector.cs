using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MajorProject
{

    public partial class TrackSelector : Form
    {
        DataTable resultTable = new DataTable();
        public TrackSelector()
        {
            InitializeComponent();
        }




        private void Form_2_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(StaticData.conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Tracks", con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            resultTable = new DataTable();
            adapter.Fill(resultTable);
            dataGridView.DataSource = resultTable;
        }

        private void departureTrainBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(StaticData.conString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Tracks' AND COLUMN_NAME = Departure ", con);
            DataView dv = resultTable.DefaultView;
            dv.RowFilter = $"Departure LIKE '%{departureTextBox.Text}%'";
            dataGridView.DataSource = resultTable;
            con.Open();
            if (dataGridView.Rows.Count==1)
       
            {
                MessageBox.Show("You there is no city with the given departure city");
            }
        }

        private void arrivalTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(StaticData.conString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Tracks' AND COLUMN_NAME = Arrival ", con);
            DataView dv = resultTable.DefaultView;
            dv.RowFilter = $"Arrival LIKE '%{departureTextBox.Text}%'";
            dataGridView.DataSource = resultTable;
            con.Open();

            if (dataGridView.Rows.Count == 1)
            {
                MessageBox.Show("You there is no city with the given arrival city");
            }
        }

        private void numberTicketsBox_TextChanged(object sender, EventArgs e)
        {


            int numberTick = 0;
            int.TryParse(numberTicketsBox.Text, out numberTick);
            SqlConnection con = new SqlConnection(StaticData.conString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Tracks' AND COLUMN_NAME = remaining_seats ", con);
            DataView dv = resultTable.DefaultView;
            dv.RowFilter = $"remaining_seats > {numberTick}";
            dataGridView.DataSource = resultTable;
            con.Open();

            if (dataGridView.Rows.Count == 1)

            {
                MessageBox.Show("Not enough seats");
            }

        }


    }
}

