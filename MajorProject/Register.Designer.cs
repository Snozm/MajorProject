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
            emailTextBox.Location = new Point(40, 155);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(186, 23);
            emailTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(40, 271);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(186, 23);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // repeatPasswordTextBox
            // 
            repeatPasswordTextBox.Location = new Point(40, 328);
            repeatPasswordTextBox.Margin = new Padding(2);
            repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            repeatPasswordTextBox.Size = new Size(186, 23);
            repeatPasswordTextBox.TabIndex = 3;
            repeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 132);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter your email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 247);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter your password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 304);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 5;
            label3.Text = "Repeat your password";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.DarkSlateGray;
            registerButton.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.ForeColor = SystemColors.ButtonHighlight;
            registerButton.Location = new Point(356, 342);
            registerButton.Margin = new Padding(2);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(186, 50);
            registerButton.TabIndex = 8;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // showPasswordPictureBox
            // 
            showPasswordPictureBox.Image = Properties.Resources.eye_outline;
            showPasswordPictureBox.Location = new Point(230, 271);
            showPasswordPictureBox.Margin = new Padding(2);
            showPasswordPictureBox.Name = "showPasswordPictureBox";
            showPasswordPictureBox.Size = new Size(22, 23);
            showPasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showPasswordPictureBox.TabIndex = 8;
            showPasswordPictureBox.TabStop = false;
            showPasswordPictureBox.Click += showPasswordPictureBox_Click;
            // 
            // showRepeatPasswordPictureBox
            // 
            showRepeatPasswordPictureBox.Image = Properties.Resources.eye_outline;
            showRepeatPasswordPictureBox.Location = new Point(230, 328);
            showRepeatPasswordPictureBox.Margin = new Padding(2);
            showRepeatPasswordPictureBox.Name = "showRepeatPasswordPictureBox";
            showRepeatPasswordPictureBox.Size = new Size(22, 23);
            showRepeatPasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showRepeatPasswordPictureBox.TabIndex = 9;
            showRepeatPasswordPictureBox.TabStop = false;
            showRepeatPasswordPictureBox.Click += showRepeatPasswordPictureBox_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(248, 17);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(564, 67);
            label4.TabIndex = 10;
            label4.Text = "CREATE PROFILE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 83);
            label5.Name = "label5";
            label5.Size = new Size(164, 28);
            label5.TabIndex = 11;
            label5.Text = "Account details:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(356, 83);
            label6.Name = "label6";
            label6.Size = new Size(158, 28);
            label6.TabIndex = 18;
            label6.Text = "Pesonal details:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(356, 247);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 17;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(356, 190);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(154, 20);
            label8.TabIndex = 16;
            label8.Text = "Enter your last name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(356, 132);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(158, 20);
            label9.TabIndex = 15;
            label9.Text = "Enter your first name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(356, 214);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(186, 23);
            lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(356, 155);
            firstNameTextBox.Margin = new Padding(2);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(186, 23);
            firstNameTextBox.TabIndex = 4;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            genderComboBox.Location = new Point(356, 271);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(186, 23);
            genderComboBox.TabIndex = 6;
            // 
            // avatarPictureBox
            // 
            avatarPictureBox.Location = new Point(643, 132);
            avatarPictureBox.Name = "avatarPictureBox";
            avatarPictureBox.Size = new Size(224, 210);
            avatarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            avatarPictureBox.TabIndex = 20;
            avatarPictureBox.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(625, 83);
            label10.Name = "label10";
            label10.Size = new Size(243, 28);
            label10.TabIndex = 21;
            label10.Text = "Upload a profile picture:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(40, 190);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(155, 20);
            label11.TabIndex = 24;
            label11.Text = "Enter your username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(40, 214);
            usernameTextBox.Margin = new Padding(2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(186, 23);
            usernameTextBox.TabIndex = 1;
            // 
            // selectImageButton
            // 
            selectImageButton.BackColor = Color.DarkSlateGray;
            selectImageButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            selectImageButton.ForeColor = SystemColors.ButtonHighlight;
            selectImageButton.Location = new Point(656, 210);
            selectImageButton.Name = "selectImageButton";
            selectImageButton.Size = new Size(199, 52);
            selectImageButton.TabIndex = 7;
            selectImageButton.Text = "Select Image";
            selectImageButton.UseVisualStyleBackColor = false;
            selectImageButton.Click += selectImageButton_Click;
            // 
            // changeImageButton
            // 
            changeImageButton.BackColor = Color.DarkSlateGray;
            changeImageButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            changeImageButton.ForeColor = SystemColors.ButtonHighlight;
            changeImageButton.Location = new Point(700, 369);
            changeImageButton.Name = "changeImageButton";
            changeImageButton.Size = new Size(104, 23);
            changeImageButton.TabIndex = 9;
            changeImageButton.Text = "Change Image";
            changeImageButton.UseVisualStyleBackColor = false;
            changeImageButton.Visible = false;
            changeImageButton.Click += changeImageButton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(897, 421);
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
            Margin = new Padding(2);
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