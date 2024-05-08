using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MajorProject
{
    public partial class Register : Form
    {
        byte[] pictureData;
        private string email;
        private string password;
        public Register()
        {
            InitializeComponent();
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

        private void showRepeatPasswordPictureBox_Click(object sender, EventArgs e)
        {
            if (repeatPasswordTextBox.UseSystemPasswordChar)
            {
                repeatPasswordTextBox.UseSystemPasswordChar = false;
                showRepeatPasswordPictureBox.Image = Properties.Resources.eye_crossed_out;
            }
            else
            {
                repeatPasswordTextBox.UseSystemPasswordChar = true;
                showRepeatPasswordPictureBox.Image = Properties.Resources.eye_outline;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "" || passwordTextBox.Text == "" || repeatPasswordTextBox.Text == "" || usernameTextBox.Text == "" || firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || genderComboBox.SelectedItem == null || selectImageButton.Visible == true)
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!emailTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Invalid email entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (passwordTextBox.Text.Length < 8)
            {
                MessageBox.Show("Password needs to be at least 8 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&?*])[A-Za-z0-9!@#$%_&?*]{8,}$";
            if (!Regex.IsMatch(passwordTextBox.Text, pattern))
            {
                MessageBox.Show("Password needs more special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(passwordTextBox.Text == repeatPasswordTextBox.Text))
            {
                MessageBox.Show("Passwords don't match");
                return;
            }

            string salt = DateTime.Now.ToString();
            string hash = StaticData.hashPassword($"{passwordTextBox.Text}{salt}");
            SqlConnection con = new SqlConnection(StaticData.conString);
            con.Open();
            SqlCommand EmailCheckingCommand = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email=@email", con);
            EmailCheckingCommand.Parameters.AddWithValue("@email", usernameTextBox.Text);
            if (Convert.ToInt32(EmailCheckingCommand.ExecuteScalar()) != 0)
            {
                MessageBox.Show("User already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES(@email, @username, @hash, @date, 0)", con);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("@hash", hash);
            cmd.Parameters.AddWithValue("@date", salt);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("INSERT INTO UserProfiles VALUES(@email, @picture, @firstname, @lastname, @gender)", con);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@picture", pictureData);
            cmd.Parameters.AddWithValue("@firstname", firstNameTextBox.Text);
            cmd.Parameters.AddWithValue("@lastname", lastNameTextBox.Text);
            cmd.Parameters.AddWithValue("@gender", genderComboBox.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User was added!");
            email = emailTextBox.Text;
            password = passwordTextBox.Text;
            this.Close();
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void LoadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string picturePath = openFileDialog.FileName;
                    Image selectedPicture = Image.FromFile(picturePath);
                    pictureData = StaticData.ImageToByteArray(selectedPicture);
                    avatarPictureBox.Image = selectedPicture;
                    selectImageButton.Visible = false;
                    changeImageButton.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error uploading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void changeImageButton_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomePage.email = email;
            HomePage.password = password;
        }
    }
}
