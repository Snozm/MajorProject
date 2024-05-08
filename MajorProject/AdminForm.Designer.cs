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
            SuspendLayout();
            // 
            // trainNameTextBox
            // 
            trainNameTextBox.Location = new Point(103, 98);
            trainNameTextBox.Name = "trainNameTextBox";
            trainNameTextBox.Size = new Size(177, 23);
            trainNameTextBox.TabIndex = 0;
            // 
            // DepartureCitytextBox
            // 
            DepartureCitytextBox.Location = new Point(103, 150);
            DepartureCitytextBox.Name = "DepartureCitytextBox";
            DepartureCitytextBox.Size = new Size(177, 23);
            DepartureCitytextBox.TabIndex = 1;
            // 
            // ArrivalCityTextBox
            // 
            ArrivalCityTextBox.Location = new Point(103, 199);
            ArrivalCityTextBox.Name = "ArrivalCityTextBox";
            ArrivalCityTextBox.Size = new Size(177, 23);
            ArrivalCityTextBox.TabIndex = 2;
            // 
            // DepartureTimeTextBox
            // 
            DepartureTimeTextBox.Location = new Point(101, 243);
            DepartureTimeTextBox.Name = "DepartureTimeTextBox";
            DepartureTimeTextBox.Size = new Size(177, 23);
            DepartureTimeTextBox.TabIndex = 3;
            // 
            // ArrivalTimeTextBox
            // 
            ArrivalTimeTextBox.Location = new Point(101, 294);
            ArrivalTimeTextBox.Name = "ArrivalTimeTextBox";
            ArrivalTimeTextBox.Size = new Size(177, 23);
            ArrivalTimeTextBox.TabIndex = 4;
            // 
            // CapacityTextBox
            // 
            CapacityTextBox.Location = new Point(101, 341);
            CapacityTextBox.Name = "CapacityTextBox";
            CapacityTextBox.Size = new Size(177, 23);
            CapacityTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 4);
            label1.Name = "label1";
            label1.Size = new Size(203, 72);
            label1.TabIndex = 6;
            label1.Text = "Admin ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 49);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 7;
            label2.Text = "Enter a new track";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Train Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 9;
            label4.Text = "Departure City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 202);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 10;
            label5.Text = "Arrival City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 251);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 11;
            label6.Text = "Departure Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 297);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 12;
            label7.Text = "Arrival Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 341);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 13;
            label8.Text = "Capacity";
            // 
            // enterTrackButton
            // 
            enterTrackButton.Location = new Point(77, 386);
            enterTrackButton.Name = "enterTrackButton";
            enterTrackButton.Size = new Size(226, 52);
            enterTrackButton.TabIndex = 14;
            enterTrackButton.Text = " Enter the track";
            enterTrackButton.UseVisualStyleBackColor = true;
            enterTrackButton.Click += button1_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 450);
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
    }
}