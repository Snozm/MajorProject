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
            trainNameTextBox.Location = new Point(150, 103);
            trainNameTextBox.Name = "trainNameTextBox";
            trainNameTextBox.Size = new Size(177, 23);
            trainNameTextBox.TabIndex = 0;
            // 
            // DepartureCitytextBox
            // 
            DepartureCitytextBox.Location = new Point(150, 152);
            DepartureCitytextBox.Name = "DepartureCitytextBox";
            DepartureCitytextBox.Size = new Size(177, 23);
            DepartureCitytextBox.TabIndex = 1;
            // 
            // ArrivalCityTextBox
            // 
            ArrivalCityTextBox.Location = new Point(150, 202);
            ArrivalCityTextBox.Name = "ArrivalCityTextBox";
            ArrivalCityTextBox.Size = new Size(177, 23);
            ArrivalCityTextBox.TabIndex = 2;
            // 
            // DepartureTimeTextBox
            // 
            DepartureTimeTextBox.Location = new Point(150, 254);
            DepartureTimeTextBox.Name = "DepartureTimeTextBox";
            DepartureTimeTextBox.Size = new Size(177, 23);
            DepartureTimeTextBox.TabIndex = 3;
            // 
            // ArrivalTimeTextBox
            // 
            ArrivalTimeTextBox.Location = new Point(150, 306);
            ArrivalTimeTextBox.Name = "ArrivalTimeTextBox";
            ArrivalTimeTextBox.Size = new Size(177, 23);
            ArrivalTimeTextBox.TabIndex = 4;
            // 
            // CapacityTextBox
            // 
            CapacityTextBox.Location = new Point(150, 358);
            CapacityTextBox.Name = "CapacityTextBox";
            CapacityTextBox.Size = new Size(177, 23);
            CapacityTextBox.TabIndex = 5;
            CapacityTextBox.TextChanged += CapacityTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(183, 21);
            label1.Name = "label1";
            label1.Size = new Size(171, 46);
            label1.TabIndex = 6;
            label1.Text = "ADMIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(197, 71);
            label2.Name = "label2";
            label2.Size = new Size(135, 17);
            label2.TabIndex = 7;
            label2.Text = "Add a new track";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(38, 103);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 8;
            label3.Text = "Train Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(38, 154);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 9;
            label4.Text = "Departure City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(41, 204);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 10;
            label5.Text = "Arrival City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(38, 254);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 11;
            label6.Text = "Departure Time:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(41, 305);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 12;
            label7.Text = "Arrival Time:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(41, 358);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 13;
            label8.Text = "Capacity:";
            // 
            // enterTrackButton
            // 
            enterTrackButton.BackColor = Color.DarkSlateGray;
            enterTrackButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            enterTrackButton.ForeColor = SystemColors.ButtonHighlight;
            enterTrackButton.Location = new Point(9, 407);
            enterTrackButton.Name = "enterTrackButton";
            enterTrackButton.Size = new Size(512, 45);
            enterTrackButton.TabIndex = 6;
            enterTrackButton.Text = "Add Track";
            enterTrackButton.UseVisualStyleBackColor = false;
            enterTrackButton.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(357, 306);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(144, 15);
            label9.TabIndex = 15;
            label9.Text = "YYYY-MM-DD HH:MM:SS";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(357, 254);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(144, 15);
            label10.TabIndex = 16;
            label10.Text = "YYYY-MM-DD HH:MM:SS";
            label10.Click += label10_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(533, 464);
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