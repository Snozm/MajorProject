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

    }
}