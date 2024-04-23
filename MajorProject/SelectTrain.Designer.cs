namespace MajorProject
{
    partial class SelectTrain
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
            classGroupBox = new GroupBox();
            economyClassRadioButton = new RadioButton();
            secondClassRadioButton = new RadioButton();
            firstClassRadioButton = new RadioButton();
            numberOfTicketsLabel = new Label();
            numberOfTicketsTextBox = new TextBox();
            trackIDTextBox = new TextBox();
            label1 = new Label();
            bookLabel = new Label();
            searchTracksButton = new Button();
            bookTicketsButton = new Button();
            classGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // classGroupBox
            // 
            classGroupBox.Controls.Add(economyClassRadioButton);
            classGroupBox.Controls.Add(secondClassRadioButton);
            classGroupBox.Controls.Add(firstClassRadioButton);
            classGroupBox.Location = new Point(33, 276);
            classGroupBox.Name = "classGroupBox";
            classGroupBox.Size = new Size(732, 83);
            classGroupBox.TabIndex = 0;
            classGroupBox.TabStop = false;
            classGroupBox.Text = "Class";
            // 
            // economyClassRadioButton
            // 
            economyClassRadioButton.AutoSize = true;
            economyClassRadioButton.Location = new Point(547, 39);
            economyClassRadioButton.Name = "economyClassRadioButton";
            economyClassRadioButton.Size = new Size(156, 29);
            economyClassRadioButton.TabIndex = 2;
            economyClassRadioButton.TabStop = true;
            economyClassRadioButton.Text = "Economy Class";
            economyClassRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondClassRadioButton
            // 
            secondClassRadioButton.AutoSize = true;
            secondClassRadioButton.Location = new Point(300, 39);
            secondClassRadioButton.Name = "secondClassRadioButton";
            secondClassRadioButton.Size = new Size(113, 29);
            secondClassRadioButton.TabIndex = 1;
            secondClassRadioButton.TabStop = true;
            secondClassRadioButton.Text = "2nd Class";
            secondClassRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstClassRadioButton
            // 
            firstClassRadioButton.AutoSize = true;
            firstClassRadioButton.Location = new Point(25, 39);
            firstClassRadioButton.Name = "firstClassRadioButton";
            firstClassRadioButton.Size = new Size(106, 29);
            firstClassRadioButton.TabIndex = 0;
            firstClassRadioButton.TabStop = true;
            firstClassRadioButton.Text = "1st Class";
            firstClassRadioButton.UseVisualStyleBackColor = true;
            // 
            // numberOfTicketsLabel
            // 
            numberOfTicketsLabel.AutoSize = true;
            numberOfTicketsLabel.Location = new Point(33, 205);
            numberOfTicketsLabel.Name = "numberOfTicketsLabel";
            numberOfTicketsLabel.Size = new Size(161, 25);
            numberOfTicketsLabel.TabIndex = 1;
            numberOfTicketsLabel.Text = "Number of Tickets:";
            // 
            // numberOfTicketsTextBox
            // 
            numberOfTicketsTextBox.Location = new Point(224, 205);
            numberOfTicketsTextBox.Name = "numberOfTicketsTextBox";
            numberOfTicketsTextBox.Size = new Size(150, 31);
            numberOfTicketsTextBox.TabIndex = 2;
            // 
            // trackIDTextBox
            // 
            trackIDTextBox.Location = new Point(224, 134);
            trackIDTextBox.Name = "trackIDTextBox";
            trackIDTextBox.Size = new Size(150, 31);
            trackIDTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 134);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 4;
            label1.Text = "Track ID:";
            label1.Click += label1_Click;
            // 
            // bookLabel
            // 
            bookLabel.AutoSize = true;
            bookLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            bookLabel.Location = new Point(261, 34);
            bookLabel.Name = "bookLabel";
            bookLabel.Size = new Size(257, 38);
            bookLabel.TabIndex = 5;
            bookLabel.Text = "Book Train Tickets";
            // 
            // searchTracksButton
            // 
            searchTracksButton.Location = new Point(517, 134);
            searchTracksButton.Name = "searchTracksButton";
            searchTracksButton.Size = new Size(183, 102);
            searchTracksButton.TabIndex = 7;
            searchTracksButton.Text = "Search Tracks";
            searchTracksButton.UseVisualStyleBackColor = true;
            // 
            // bookTicketsButton
            // 
            bookTicketsButton.Location = new Point(312, 431);
            bookTicketsButton.Name = "bookTicketsButton";
            bookTicketsButton.Size = new Size(171, 87);
            bookTicketsButton.TabIndex = 8;
            bookTicketsButton.Text = "Book Tickets";
            bookTicketsButton.UseVisualStyleBackColor = true;
            bookTicketsButton.Click += bookTicketsButton_Click;
            // 
            // SelectTrain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 566);
            Controls.Add(bookTicketsButton);
            Controls.Add(searchTracksButton);
            Controls.Add(bookLabel);
            Controls.Add(label1);
            Controls.Add(trackIDTextBox);
            Controls.Add(numberOfTicketsTextBox);
            Controls.Add(numberOfTicketsLabel);
            Controls.Add(classGroupBox);
            Name = "SelectTrain";
            Text = "SelectTrain";
            classGroupBox.ResumeLayout(false);
            classGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox classGroupBox;
        private RadioButton economyClassRadioButton;
        private RadioButton secondClassRadioButton;
        private RadioButton firstClassRadioButton;
        private Label numberOfTicketsLabel;
        private TextBox numberOfTicketsTextBox;
        private TextBox trackIDTextBox;
        private Label label1;
        private Label bookLabel;
        private Button searchTracksButton;
        private Button bookTicketsButton;
    }
}