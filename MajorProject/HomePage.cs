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

        string adminemail = "admin@admin.com";
        string adminpassword = "ilovecookies";

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
                UserInfo.email = email;

                query = "SELECT * FROM UserProfiles WHERE Email=@email";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);
                UserInfo.picture = StaticData.ByteArrayToImage((byte[])table.Rows[0]["Picture"]);
                UserInfo.firstName = table.Rows[0]["Firstname"].ToString();
                UserInfo.lastName = table.Rows[0]["Lastname"].ToString();
                UserInfo.gender = table.Rows[0]["Sex"].ToString();

                query = "SELECT * FROM Users WHERE Email=@email";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                table = new DataTable();
                adapter.Fill(table);
                UserInfo.username = table.Rows[0]["Username"].ToString();

                SelectTrain myForm = new SelectTrain();
                myForm.Show();
                this.Hide();
                return;
            }
            MessageBox.Show("Wrong username or password entered");
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((emailTextBox.Text == adminemail) && (passwordTextBox.Text == adminpassword))
            {
                AdminForm adm = new AdminForm();
                adm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Admin details");
            }
        }
    }
}