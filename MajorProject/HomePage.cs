using System.Data;
using System.Data.SqlClient;

namespace MajorProject
{
    public partial class HomePage : Form
    {
        public static string email;
        public static string password;
        public HomePage()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void HomePage_Activated(object sender, EventArgs e)
        {
            if (email != null && password != null)
            {
                emailTextBox.Text = email;
                passwordTextBox.Text = password;
                email = null;
                password = null;
            }
        }

        private void showPasswordPictureBox_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                showPasswordPictureBox.Image = Properties.Resources.eye_crossed_out;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                showPasswordPictureBox.Image = Properties.Resources.eye_outline;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(StaticData.conString);
            con.Open();
            string query = "SELECT salt FROM Users WHERE Email=@email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            string date = Convert.ToString(cmd.ExecuteScalar());
            query = "SELECT COUNT(*) FROM Users WHERE Email=@email AND password=@hash";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@hash", StaticData.hashPassword($"{passwordTextBox.Text}{date}"));
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 1)
            {
                TrackSelector myForm = new TrackSelector();
                myForm.Show();
                this.Hide();
                return;
            }
            MessageBox.Show("Wrong username or password entered");
        }
    }
}