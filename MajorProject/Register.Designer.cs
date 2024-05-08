namespace MajorProject
{
    partial class Register
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
            registerButton = new Button();
            showPasswordPictureBox = new PictureBox();
            showRepeatPasswordPictureBox = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            genderComboBox = new ComboBox();
            avatarPictureBox = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            usernameTextBox = new TextBox();
            selectImageButton = new Button();
            changeImageButton = new Button();
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showRepeatPasswordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).BeginInit();
            SuspendLayout();
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = SystemColors.ButtonHighlight;
            emailTextBox.Location = new Point(57, 258);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(264, 31);
            emailTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(57, 452);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(264, 31);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // repeatPasswordTextBox
            // 
            repeatPasswordTextBox.Location = new Point(57, 547);
            repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            repeatPasswordTextBox.Size = new Size(264, 31);
            repeatPasswordTextBox.TabIndex = 2;
            repeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 220);
            label1.Name = "label1";
            label1.Size = new Size(183, 30);
            label1.TabIndex = 3;
            label1.Text = "Enter your email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 412);
            label2.Name = "label2";
            label2.Size = new Size(227, 30);
            label2.TabIndex = 4;
            label2.Text = "Enter your password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 507);
            label3.Name = "label3";
            label3.Size = new Size(244, 30);
            label3.TabIndex = 5;
            label3.Text = "Repeat your password";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.DarkSlateGray;
            registerButton.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.ForeColor = SystemColors.ButtonHighlight;
            registerButton.Location = new Point(509, 570);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(266, 83);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // showPasswordPictureBox
            // 
            showPasswordPictureBox.Image = Properties.Resources.eye_outline;
            showPasswordPictureBox.Location = new Point(329, 452);
            showPasswordPictureBox.Name = "showPasswordPictureBox";
            showPasswordPictureBox.Size = new Size(31, 38);
            showPasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showPasswordPictureBox.TabIndex = 8;
            showPasswordPictureBox.TabStop = false;
            showPasswordPictureBox.Click += showPasswordPictureBox_Click;
            // 
            // showRepeatPasswordPictureBox
            // 
            showRepeatPasswordPictureBox.Image = Properties.Resources.eye_outline;
            showRepeatPasswordPictureBox.Location = new Point(329, 547);
            showRepeatPasswordPictureBox.Name = "showRepeatPasswordPictureBox";
            showRepeatPasswordPictureBox.Size = new Size(31, 38);
            showRepeatPasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showRepeatPasswordPictureBox.TabIndex = 9;
            showRepeatPasswordPictureBox.TabStop = false;
            showRepeatPasswordPictureBox.Click += showRepeatPasswordPictureBox_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(355, 28);
            label4.Name = "label4";
            label4.Size = new Size(564, 67);
            label4.TabIndex = 10;
            label4.Text = "CREATE PROFILE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(57, 138);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(243, 41);
            label5.TabIndex = 11;
            label5.Text = "Account details:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(509, 138);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(235, 41);
            label6.TabIndex = 18;
            label6.Text = "Pesonal details:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(509, 412);
            label7.Name = "label7";
            label7.Size = new Size(89, 30);
            label7.TabIndex = 17;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(509, 317);
            label8.Name = "label8";
            label8.Size = new Size(227, 30);
            label8.TabIndex = 16;
            label8.Text = "Enter your last name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(509, 220);
            label9.Name = "label9";
            label9.Size = new Size(232, 30);
            label9.TabIndex = 15;
            label9.Text = "Enter your first name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(509, 357);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(264, 31);
            lastNameTextBox.TabIndex = 13;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(509, 258);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(264, 31);
            firstNameTextBox.TabIndex = 12;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            genderComboBox.Location = new Point(509, 452);
            genderComboBox.Margin = new Padding(4, 5, 4, 5);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(264, 33);
            genderComboBox.TabIndex = 19;
            // 
            // avatarPictureBox
            // 
            avatarPictureBox.Location = new Point(919, 220);
            avatarPictureBox.Margin = new Padding(4, 5, 4, 5);
            avatarPictureBox.Name = "avatarPictureBox";
            avatarPictureBox.Size = new Size(320, 350);
            avatarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            avatarPictureBox.TabIndex = 20;
            avatarPictureBox.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(893, 138);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(364, 41);
            label10.TabIndex = 21;
            label10.Text = "Upload a profile picture:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(57, 317);
            label11.Name = "label11";
            label11.Size = new Size(228, 30);
            label11.TabIndex = 24;
            label11.Text = "Enter your username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(57, 357);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(264, 31);
            usernameTextBox.TabIndex = 23;
            // 
            // selectImageButton
            // 
            selectImageButton.BackColor = Color.DarkSlateGray;
            selectImageButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            selectImageButton.ForeColor = SystemColors.ButtonHighlight;
            selectImageButton.Location = new Point(937, 350);
            selectImageButton.Margin = new Padding(4, 5, 4, 5);
            selectImageButton.Name = "selectImageButton";
            selectImageButton.Size = new Size(284, 87);
            selectImageButton.TabIndex = 25;
            selectImageButton.Text = "Select Image";
            selectImageButton.UseVisualStyleBackColor = false;
            selectImageButton.Click += selectImageButton_Click;
            // 
            // changeImageButton
            // 
            changeImageButton.BackColor = Color.DarkSlateGray;
            changeImageButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            changeImageButton.ForeColor = SystemColors.ButtonHighlight;
            changeImageButton.Location = new Point(1000, 615);
            changeImageButton.Margin = new Padding(4, 5, 4, 5);
            changeImageButton.Name = "changeImageButton";
            changeImageButton.Size = new Size(149, 38);
            changeImageButton.TabIndex = 26;
            changeImageButton.Text = "Change Image";
            changeImageButton.UseVisualStyleBackColor = false;
            changeImageButton.Visible = false;
            changeImageButton.Click += changeImageButton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1281, 702);
            Controls.Add(changeImageButton);
            Controls.Add(selectImageButton);
            Controls.Add(label11);
            Controls.Add(usernameTextBox);
            Controls.Add(label10);
            Controls.Add(avatarPictureBox);
            Controls.Add(genderComboBox);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(showRepeatPasswordPictureBox);
            Controls.Add(showPasswordPictureBox);
            Controls.Add(registerButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(repeatPasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Name = "Register";
            Text = "Register";
            FormClosing += Register_FormClosing;
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showRepeatPasswordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).EndInit();
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
        private Button registerButton;
        private PictureBox showPasswordPictureBox;
        private PictureBox showRepeatPasswordPictureBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private ComboBox genderComboBox;
        private PictureBox avatarPictureBox;
        private Label label10;
        private Label label11;
        private TextBox usernameTextBox;
        private Button selectImageButton;
        private Button changeImageButton;
    }
}