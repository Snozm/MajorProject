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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 49);
            label1.Name = "label1";
            label1.Size = new Size(637, 46);
            label1.TabIndex = 0;
            label1.Text = "You need to be logged in to use this app!";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(287, 184);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(114, 15);
            label11.TabIndex = 28;
            label11.Text = "Enter your password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(287, 207);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(186, 23);
            passwordTextBox.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 125);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 26;
            label2.Text = "Enter your email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(287, 148);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(186, 23);
            emailTextBox.TabIndex = 25;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(287, 255);
            loginButton.Margin = new Padding(2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(186, 50);
            loginButton.TabIndex = 29;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 356);
            label3.Name = "label3";
            label3.Size = new Size(258, 15);
            label3.TabIndex = 30;
            label3.Text = "Don't have an account? Click here to make one:";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(479, 352);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 31;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registerButton);
            Controls.Add(label3);
            Controls.Add(loginButton);
            Controls.Add(label11);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(emailTextBox);
            Controls.Add(label1);
            Name = "HomePage";
            Text = "Home Page";
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
    }
}