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
            cancelButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(27, 71);
            firstNameLabel.Margin = new Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(96, 21);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(27, 106);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(94, 21);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // travelerInformationLabel
            // 
            travelerInformationLabel.AutoSize = true;
            travelerInformationLabel.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point);
            travelerInformationLabel.Location = new Point(65, 17);
            travelerInformationLabel.Margin = new Padding(2, 0, 2, 0);
            travelerInformationLabel.Name = "travelerInformationLabel";
            travelerInformationLabel.Size = new Size(297, 23);
            travelerInformationLabel.TabIndex = 2;
            travelerInformationLabel.Text = "TRAVELLER INFORMATION";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(155, 71);
            firstNameTextBox.Margin = new Padding(2);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(217, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(155, 106);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(217, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.DarkSlateGray;
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.ForeColor = SystemColors.ButtonHighlight;
            saveButton.Location = new Point(155, 140);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(97, 29);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.DarkSlateGray;
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.ForeColor = SystemColors.ButtonHighlight;
            cancelButton.Location = new Point(275, 140);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(97, 29);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // UserBookingInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(440, 184);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(travelerInformationLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Margin = new Padding(2);
            Name = "UserBookingInformation";
            Text = "UserBookingInformation";
            Load += UserBookingInformation_Load;
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
        private Button cancelButton;
    }
}