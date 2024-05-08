namespace MajorProject
{
    partial class AdminForm
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
            trainNameTextBox = new TextBox();
            DepartureCitytextBox = new TextBox();
            ArrivalCityTextBox = new TextBox();
            DepartureTimeTextBox = new TextBox();
            ArrivalTimeTextBox = new TextBox();
            CapacityTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            enterTrackButton = new Button();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // trainNameTextBox
            // 
            trainNameTextBox.Location = new Point(214, 172);
            trainNameTextBox.Margin = new Padding(4, 5, 4, 5);
            trainNameTextBox.Name = "trainNameTextBox";
            trainNameTextBox.Size = new Size(251, 31);
            trainNameTextBox.TabIndex = 0;
            // 
            // DepartureCitytextBox
            // 
            DepartureCitytextBox.Location = new Point(214, 253);
            DepartureCitytextBox.Margin = new Padding(4, 5, 4, 5);
            DepartureCitytextBox.Name = "DepartureCitytextBox";
            DepartureCitytextBox.Size = new Size(251, 31);
            DepartureCitytextBox.TabIndex = 1;
            // 
            // ArrivalCityTextBox
            // 
            ArrivalCityTextBox.Location = new Point(214, 337);
            ArrivalCityTextBox.Margin = new Padding(4, 5, 4, 5);
            ArrivalCityTextBox.Name = "ArrivalCityTextBox";
            ArrivalCityTextBox.Size = new Size(251, 31);
            ArrivalCityTextBox.TabIndex = 2;
            // 
            // DepartureTimeTextBox
            // 
            DepartureTimeTextBox.Location = new Point(214, 423);
            DepartureTimeTextBox.Margin = new Padding(4, 5, 4, 5);
            DepartureTimeTextBox.Name = "DepartureTimeTextBox";
            DepartureTimeTextBox.Size = new Size(251, 31);
            DepartureTimeTextBox.TabIndex = 3;
            // 
            // ArrivalTimeTextBox
            // 
            ArrivalTimeTextBox.Location = new Point(214, 510);
            ArrivalTimeTextBox.Margin = new Padding(4, 5, 4, 5);
            ArrivalTimeTextBox.Name = "ArrivalTimeTextBox";
            ArrivalTimeTextBox.Size = new Size(251, 31);
            ArrivalTimeTextBox.TabIndex = 4;
            // 
            // CapacityTextBox
            // 
            CapacityTextBox.Location = new Point(214, 596);
            CapacityTextBox.Margin = new Padding(4, 5, 4, 5);
            CapacityTextBox.Name = "CapacityTextBox";
            CapacityTextBox.Size = new Size(251, 31);
            CapacityTextBox.TabIndex = 5;
            CapacityTextBox.TextChanged += CapacityTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(261, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 67);
            label1.TabIndex = 6;
            label1.Text = "ADMIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(281, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 7;
            label2.Text = "Add a new track";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(55, 172);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 8;
            label3.Text = "Train Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(55, 256);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 9;
            label4.Text = "Departure City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(58, 340);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 10;
            label5.Text = "Arrival City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(55, 423);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(151, 25);
            label6.TabIndex = 11;
            label6.Text = "Departure Time:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(58, 508);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 25);
            label7.TabIndex = 12;
            label7.Text = "Arrival Time:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(58, 596);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 13;
            label8.Text = "Capacity:";
            // 
            // enterTrackButton
            // 
            enterTrackButton.BackColor = Color.DarkSlateGray;
            enterTrackButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            enterTrackButton.ForeColor = SystemColors.ButtonHighlight;
            enterTrackButton.Location = new Point(13, 679);
            enterTrackButton.Margin = new Padding(4, 5, 4, 5);
            enterTrackButton.Name = "enterTrackButton";
            enterTrackButton.Size = new Size(721, 54);
            enterTrackButton.TabIndex = 14;
            enterTrackButton.Text = "Add Track";
            enterTrackButton.UseVisualStyleBackColor = false;
            enterTrackButton.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(510, 510);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(215, 25);
            label9.TabIndex = 15;
            label9.Text = "YYYY-MM-DD HH:MM:SS";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(510, 423);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(215, 25);
            label10.TabIndex = 16;
            label10.Text = "YYYY-MM-DD HH:MM:SS";
            label10.Click += label10_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(761, 774);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(enterTrackButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CapacityTextBox);
            Controls.Add(ArrivalTimeTextBox);
            Controls.Add(DepartureTimeTextBox);
            Controls.Add(ArrivalCityTextBox);
            Controls.Add(DepartureCitytextBox);
            Controls.Add(trainNameTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox trainNameTextBox;
        private TextBox DepartureCitytextBox;
        private TextBox ArrivalCityTextBox;
        private TextBox DepartureTimeTextBox;
        private TextBox ArrivalTimeTextBox;
        private TextBox CapacityTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button enterTrackButton;
        private Label label9;
        private Label label10;
    }
}