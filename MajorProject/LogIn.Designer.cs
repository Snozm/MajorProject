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
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showRepeatPasswordPictureBox).BeginInit();
            SuspendLayout();
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(233, 150);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(264, 31);
            emailTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(233, 249);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(264, 31);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // repeatPasswordTextBox
            // 
            repeatPasswordTextBox.Location = new Point(233, 344);
            repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            repeatPasswordTextBox.Size = new Size(264, 31);
            repeatPasswordTextBox.TabIndex = 2;
            repeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 112);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 3;
            label1.Text = "Enter your email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 208);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 4;
            label2.Text = "Enter your password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 304);
            label3.Name = "label3";
            label3.Size = new Size(189, 25);
            label3.TabIndex = 5;
            label3.Text = "Repeat your password";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(233, 416);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(112, 34);
            loginButton.TabIndex = 6;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(412, 416);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(112, 34);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // showPasswordPictureBox
            // 
            showPasswordPictureBox.Image = Properties.Resources.eye_outline;
            showPasswordPictureBox.Location = new Point(494, 249);
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
            showRepeatPasswordPictureBox.Location = new Point(494, 344);
            showRepeatPasswordPictureBox.Name = "showRepeatPasswordPictureBox";
            showRepeatPasswordPictureBox.Size = new Size(32, 31);
            showRepeatPasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showRepeatPasswordPictureBox.TabIndex = 9;
            showRepeatPasswordPictureBox.TabStop = false;
            showRepeatPasswordPictureBox.Click += showRepeatPasswordPictureBox_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(221, 30);
            label4.Name = "label4";
            label4.Size = new Size(315, 51);
            label4.TabIndex = 10;
            label4.Text = "Log in or Register";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 552);
            Controls.Add(label4);
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
        private Label label4;
    }
}