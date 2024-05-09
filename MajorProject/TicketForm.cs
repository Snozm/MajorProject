using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MajorProject
{
    public partial class TicketForm : Form
    {
        string firstName;
        string lastName;
        string destination;
        public TicketForm(string firstN, string lastN, string arrival)
        {
            InitializeComponent();
            firstName = firstN;
            lastName = lastN;
            destination = arrival;
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            lblName.Text = firstName + " " + lastName;
            lblDestination.Text = destination;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 50)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
