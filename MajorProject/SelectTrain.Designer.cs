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
            selectTrackLabel = new Label();
            selectTrackLabel2 = new Label();
            classGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // classGroupBox
            // 
            classGroupBox.BackColor = Color.CadetBlue;
            classGroupBox.Controls.Add(economyClassRadioButton);
            classGroupBox.Controls.Add(secondClassRadioButton);
            classGroupBox.Controls.Add(firstClassRadioButton);
            classGroupBox.Enabled = false;
            classGroupBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            classGroupBox.ForeColor = SystemColors.InfoText;
            classGroupBox.Location = new Point(11, 305);
            classGroupBox.Name = "classGroupBox";
            classGroupBox.Size = new Size(767, 93);
            classGroupBox.TabIndex = 0;
            classGroupBox.TabStop = false;
            classGroupBox.Text = "Class";
            // 
            // economyClassRadioButton
            // 
            economyClassRadioButton.AutoSize = true;
            economyClassRadioButton.Location = new Point(547, 38);
            economyClassRadioButton.Name = "economyClassRadioButton";
            economyClassRadioButton.Size = new Size(190, 34);
            economyClassRadioButton.TabIndex = 2;
            economyClassRadioButton.TabStop = true;
            economyClassRadioButton.Text = "Economy Class";
            economyClassRadioButton.UseVisualStyleBackColor = true;
            economyClassRadioButton.CheckedChanged += economyClassRadioButton_CheckedChanged;
            // 
            // secondClassRadioButton
            // 
            secondClassRadioButton.AutoSize = true;
            secondClassRadioButton.Location = new Point(296, 38);
            secondClassRadioButton.Name = "secondClassRadioButton";
            secondClassRadioButton.Size = new Size(136, 34);
            secondClassRadioButton.TabIndex = 1;
            secondClassRadioButton.TabStop = true;
            secondClassRadioButton.Text = "2nd Class";
            secondClassRadioButton.UseVisualStyleBackColor = true;
            secondClassRadioButton.CheckedChanged += secondClassRadioButton_CheckedChanged;
            // 
            // firstClassRadioButton
            // 
            firstClassRadioButton.AutoSize = true;
            firstClassRadioButton.Location = new Point(26, 38);
            firstClassRadioButton.Name = "firstClassRadioButton";
            firstClassRadioButton.Size = new Size(128, 34);
            firstClassRadioButton.TabIndex = 0;
            firstClassRadioButton.TabStop = true;
            firstClassRadioButton.Text = "1st Class";
            firstClassRadioButton.UseVisualStyleBackColor = true;
            firstClassRadioButton.CheckedChanged += firstClassRadioButton_CheckedChanged;
            // 
            // numberOfTicketsLabel
            // 
            numberOfTicketsLabel.AutoSize = true;
            numberOfTicketsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numberOfTicketsLabel.Location = new Point(11, 205);
            numberOfTicketsLabel.Name = "numberOfTicketsLabel";
            numberOfTicketsLabel.Size = new Size(232, 32);
            numberOfTicketsLabel.TabIndex = 1;
            numberOfTicketsLabel.Text = "Number of Tickets:";
            // 
            // numberOfTicketsTextBox
            // 
            numberOfTicketsTextBox.Enabled = false;
            numberOfTicketsTextBox.Location = new Point(264, 208);
            numberOfTicketsTextBox.Name = "numberOfTicketsTextBox";
            numberOfTicketsTextBox.Size = new Size(150, 31);
            numberOfTicketsTextBox.TabIndex = 2;
            numberOfTicketsTextBox.TextChanged += numberOfTicketsTextBox_TextChanged;
            // 
            // trackIDTextBox
            // 
            trackIDTextBox.Location = new Point(264, 137);
            trackIDTextBox.Name = "trackIDTextBox";
            trackIDTextBox.Size = new Size(150, 31);
            trackIDTextBox.TabIndex = 3;
            trackIDTextBox.TextChanged += trackIDTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 137);
            label1.Name = "label1";
            label1.Size = new Size(114, 32);
            label1.TabIndex = 4;
            label1.Text = "Track ID:";
            // 
            // bookLabel
            // 
            bookLabel.AutoSize = true;
            bookLabel.Font = new Font("Verdana", 20F, FontStyle.Bold, GraphicsUnit.Point);
            bookLabel.Location = new Point(146, 37);
            bookLabel.Name = "bookLabel";
            bookLabel.Size = new Size(513, 48);
            bookLabel.TabIndex = 5;
            bookLabel.Text = "BOOK TRAIN TICKETS";
            // 
            // searchTracksButton
            // 
            searchTracksButton.BackColor = Color.DarkSlateGray;
            searchTracksButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchTracksButton.ForeColor = SystemColors.ButtonHighlight;
            searchTracksButton.Location = new Point(517, 133);
            searchTracksButton.Name = "searchTracksButton";
            searchTracksButton.Size = new Size(183, 102);
            searchTracksButton.TabIndex = 7;
            searchTracksButton.Text = "Search Tracks";
            searchTracksButton.UseVisualStyleBackColor = false;
            searchTracksButton.Click += searchTracksButton_Click;
            // 
            // bookTicketsButton
            // 
            bookTicketsButton.BackColor = Color.DarkSlateGray;
            bookTicketsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookTicketsButton.ForeColor = SystemColors.ButtonHighlight;
            bookTicketsButton.Location = new Point(3, 448);
            bookTicketsButton.Name = "bookTicketsButton";
            bookTicketsButton.Size = new Size(776, 57);
            bookTicketsButton.TabIndex = 8;
            bookTicketsButton.Text = "Book Tickets";
            bookTicketsButton.UseVisualStyleBackColor = false;
            bookTicketsButton.Click += bookTicketsButton_Click;
            // 
            // selectTrackLabel
            // 
            selectTrackLabel.AutoSize = true;
            selectTrackLabel.Location = new Point(268, 254);
            selectTrackLabel.Margin = new Padding(4, 0, 4, 0);
            selectTrackLabel.Name = "selectTrackLabel";
            selectTrackLabel.Size = new Size(141, 25);
            selectTrackLabel.TabIndex = 9;
            selectTrackLabel.Text = "Select track first!";
            // 
            // selectTrackLabel2
            // 
            selectTrackLabel2.AutoSize = true;
            selectTrackLabel2.Location = new Point(321, 412);
            selectTrackLabel2.Margin = new Padding(4, 0, 4, 0);
            selectTrackLabel2.Name = "selectTrackLabel2";
            selectTrackLabel2.Size = new Size(141, 25);
            selectTrackLabel2.TabIndex = 10;
            selectTrackLabel2.Text = "Select track first!";
            // 
            // SelectTrain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 529);
            Controls.Add(selectTrackLabel2);
            Controls.Add(selectTrackLabel);
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
            Load += SelectTrain_Load;
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
        private Label selectTrackLabel;
        private Label selectTrackLabel2;
    }
}