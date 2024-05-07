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
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(946, 48);
            label1.TabIndex = 0;
            label1.Text = "You need to be logged in to use this app!";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(392, 278);
            label11.Name = "label11";
            label11.Size = new Size(233, 30);
            label11.TabIndex = 28;
            label11.Text = "Enter your password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(392, 316);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(264, 31);
            passwordTextBox.TabIndex = 27;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(392, 170);
            label2.Name = "label2";
            label2.Size = new Size(189, 30);
            label2.TabIndex = 26;
            label2.Text = "Enter your email:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(392, 209);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(264, 31);
            emailTextBox.TabIndex = 25;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DarkSlateGray;
            loginButton.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(392, 408);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(266, 71);
            loginButton.TabIndex = 29;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(289, 564);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(461, 28);
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
            showPasswordPictureBox.Location = new Point(663, 316);
            showPasswordPictureBox.Name = "showPasswordPictureBox";
            showPasswordPictureBox.Size = new Size(31, 38);
            showPasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showPasswordPictureBox.TabIndex = 32;
            showPasswordPictureBox.TabStop = false;
            showPasswordPictureBox.Click += showPasswordPictureBox_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1143, 689);
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
            Margin = new Padding(4, 5, 4, 5);
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
    }
}