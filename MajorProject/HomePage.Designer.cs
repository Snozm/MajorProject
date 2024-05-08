namespace MajorProject
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label11 = new Label();
            passwordTextBox = new TextBox();
            label2 = new Label();
            emailTextBox = new TextBox();
            loginButton = new Button();
            label3 = new Label();
            registerButton = new Button();
            showPasswordPictureBox = new PictureBox();
            enterAsAdminButton = new Button();
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 35);
            label1.Name = "label1";
            label1.Size = new Size(633, 32);
            label1.TabIndex = 0;
            label1.Text = "You need to be logged in to use this app!";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(274, 167);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(157, 20);
            label11.TabIndex = 28;
            label11.Text = "Enter your password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(274, 190);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(186, 23);
            passwordTextBox.TabIndex = 27;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(274, 102);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 26;
            label2.Text = "Enter your email:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(274, 125);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(186, 23);
            emailTextBox.TabIndex = 25;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DarkSlateGray;
            loginButton.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(274, 245);
            loginButton.Margin = new Padding(2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(186, 43);
            loginButton.TabIndex = 29;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(202, 338);
            label3.Name = "label3";
            label3.Size = new Size(323, 19);
            label3.TabIndex = 30;
            label3.Text = "Don't have an account? Click here to make one:";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.DarkSlateGray;
            registerButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(758, 556);
            registerButton.Margin = new Padding(4, 5, 4, 5);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(119, 44);
            registerButton.TabIndex = 31;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // showPasswordPictureBox
            // 
            showPasswordPictureBox.Image = Properties.Resources.eye_outline;
            showPasswordPictureBox.Location = new Point(464, 190);
            showPasswordPictureBox.Margin = new Padding(2);
            showPasswordPictureBox.Name = "showPasswordPictureBox";
            showPasswordPictureBox.Size = new Size(22, 23);
            showPasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showPasswordPictureBox.TabIndex = 32;
            showPasswordPictureBox.TabStop = false;
            showPasswordPictureBox.Click += showPasswordPictureBox_Click;
            // 
            // enterAsAdminButton
            // 
            enterAsAdminButton.BackColor = Color.DarkSlateGray;
            enterAsAdminButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            enterAsAdminButton.ForeColor = Color.White;
            enterAsAdminButton.Location = new Point(274, 292);
            enterAsAdminButton.Margin = new Padding(2);
            enterAsAdminButton.Name = "enterAsAdminButton";
            enterAsAdminButton.Size = new Size(186, 37);
            enterAsAdminButton.TabIndex = 33;
            enterAsAdminButton.Text = "Enter as Admin";
            enterAsAdminButton.UseVisualStyleBackColor = false;
            enterAsAdminButton.Click += button1_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 413);
            Controls.Add(enterAsAdminButton);
            Controls.Add(showPasswordPictureBox);
            Controls.Add(registerButton);
            Controls.Add(label3);
            Controls.Add(loginButton);
            Controls.Add(label11);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(emailTextBox);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "HomePage";
            Text = "Home Page";
            Activated += HomePage_Activated;
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label11;
        private TextBox passwordTextBox;
        private Label label2;
        private TextBox emailTextBox;
        private Button loginButton;
        private Label label3;
        private Button registerButton;
        private PictureBox showPasswordPictureBox;
        private Button enterAsAdminButton;
    }
}