namespace MajorProject
{
    partial class UserBookingInformation
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            travelerInformationLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(39, 119);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(144, 32);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(43, 177);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(140, 32);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // travelerInformationLabel
            // 
            travelerInformationLabel.AutoSize = true;
            travelerInformationLabel.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point);
            travelerInformationLabel.Location = new Point(143, 35);
            travelerInformationLabel.Name = "travelerInformationLabel";
            travelerInformationLabel.Size = new Size(348, 34);
            travelerInformationLabel.TabIndex = 2;
            travelerInformationLabel.Text = "Traveler Information";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(221, 119);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(308, 31);
            firstNameTextBox.TabIndex = 3;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(221, 177);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(308, 31);
            lastNameTextBox.TabIndex = 4;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.CadetBlue;
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.ForeColor = SystemColors.ButtonHighlight;
            saveButton.Location = new Point(221, 234);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(308, 49);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // UserBookingInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(628, 307);
            Controls.Add(saveButton);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(travelerInformationLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "UserBookingInformation";
            Text = "UserBookingInformation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label travelerInformationLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Button saveButton;
    }
}