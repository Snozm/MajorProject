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
    
    public partial class Form_2 : Form
    {
        DataTable resultTable = new DataTable();
        public Form_2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form_2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC17\SQLEXPRESS;Initial Catalog=RailwaysProject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Tracks", con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
             resultTable = new DataTable();
            adapter.Fill(resultTable);
            dataGridView.DataSource = resultTable;
        }

        private void departureTextBox_Leave(object sender, EventArgs e)
        {
           
            using (SqlConnection con = new SqlConnection((@"Data Source = LAB108PC17\SQLEXPRESS; Initial Catalog = LoginHash; Integrated Security = True")))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Login' AND COLUMN_NAME = Departure ", con);
                DataView dv = resultTable.DefaultView;
                dv.RowFilter = $"Departure LIKE '%{departureTextBox.Text}%'";
                dataGridView.DataSource = resultTable;
                con.Open();
            }
           
        }
    }
    }
}
