namespace MajorProject
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            repeatPasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loginButton = new Button();
            registerButton = new Button();
            showPasswordPictureBox = new PictureBox();
            showRepeatPasswordPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showRepeatPasswordPictureBox).BeginInit();
            SuspendLayout();
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(90, 84);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(264, 31);
            emailTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(90, 183);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(264, 31);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // repeatPasswordTextBox
            // 
            repeatPasswordTextBox.Location = new Point(90, 278);
            repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            repeatPasswordTextBox.Size = new Size(264, 31);
            repeatPasswordTextBox.TabIndex = 2;
            repeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 46);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 3;
            label1.Text = "Enter your email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 142);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 4;
            label2.Text = "Enter your password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 238);
            label3.Name = "label3";
            label3.Size = new Size(189, 25);
            label3.TabIndex = 5;
            label3.Text = "Repeat your password";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(261, 351);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(112, 34);
            loginButton.TabIndex = 6;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(440, 351);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(112, 34);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // showPasswordPictureBox
            // 
            showPasswordPictureBox.Image = Properties.Resources.eye_outline;
            showPasswordPictureBox.Location = new Point(351, 183);
            showPasswordPictureBox.Name = "showPasswordPictureBox";
            showPasswordPictureBox.Size = new Size(32, 31);
            showPasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showPasswordPictureBox.TabIndex = 8;
            showPasswordPictureBox.TabStop = false;
            showPasswordPictureBox.Click += showPasswordPictureBox_Click;
            // 
            // showRepeatPasswordPictureBox
            // 
            showRepeatPasswordPictureBox.Image = Properties.Resources.eye_outline;
            showRepeatPasswordPictureBox.Location = new Point(351, 278);
            showRepeatPasswordPictureBox.Name = "showRepeatPasswordPictureBox";
            showRepeatPasswordPictureBox.Size = new Size(32, 31);
            showRepeatPasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showRepeatPasswordPictureBox.TabIndex = 9;
            showRepeatPasswordPictureBox.TabStop = false;
            showRepeatPasswordPictureBox.Click += showRepeatPasswordPictureBox_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showRepeatPasswordPictureBox);
            Controls.Add(showPasswordPictureBox);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(repeatPasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Name = "LogIn";
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showRepeatPasswordPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private TextBox repeatPasswordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button loginButton;
        private Button registerButton;
        private PictureBox showPasswordPictureBox;
        private PictureBox showRepeatPasswordPictureBox;
    }
}