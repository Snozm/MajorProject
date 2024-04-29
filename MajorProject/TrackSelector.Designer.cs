namespace MajorProject
{
    partial class TrackSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackSelector));
            dataGridView = new DataGridView();
            departureTextBox = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            arrivalTextBox = new TextBox();
            label3 = new Label();
            numberTicketsBox = new TextBox();
            label4 = new Label();
            closeTabButton = new Button();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(46, 423);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(1421, 885);
            dataGridView.TabIndex = 0;
            // 
            // departureTextBox
            // 
            departureTextBox.Location = new Point(150, 345);
            departureTextBox.Name = "departureTextBox";
            departureTextBox.Size = new Size(286, 31);
            departureTextBox.TabIndex = 1;
            departureTextBox.TextChanged += departureTrainBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(150, 297);
            label1.Name = "label1";
            label1.Size = new Size(234, 41);
            label1.TabIndex = 3;
            label1.Text = "Departure City:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(1564, 554);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(927, 583);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // arrivalTextBox
            // 
            arrivalTextBox.Location = new Point(604, 345);
            arrivalTextBox.Name = "arrivalTextBox";
            arrivalTextBox.Size = new Size(285, 31);
            arrivalTextBox.TabIndex = 6;
            arrivalTextBox.TextChanged += arrivalTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(604, 297);
            label3.Name = "label3";
            label3.Size = new Size(121, 41);
            label3.TabIndex = 7;
            label3.Text = "Arrival:";
            // 
            // numberTicketsBox
            // 
            numberTicketsBox.Location = new Point(1033, 345);
            numberTicketsBox.Name = "numberTicketsBox";
            numberTicketsBox.Size = new Size(287, 31);
            numberTicketsBox.TabIndex = 8;
            numberTicketsBox.TextChanged += numberTicketsBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1033, 297);
            label4.Name = "label4";
            label4.Size = new Size(287, 41);
            label4.TabIndex = 9;
            label4.Text = "Number of Tickets:";
            // 
            // closeTabButton
            // 
            closeTabButton.BackColor = Color.DarkSlateGray;
            closeTabButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            closeTabButton.ForeColor = SystemColors.ButtonHighlight;
            closeTabButton.Location = new Point(1564, 1241);
            closeTabButton.Name = "closeTabButton";
            closeTabButton.Size = new Size(941, 67);
            closeTabButton.TabIndex = 11;
            closeTabButton.Text = "Close tab";
            closeTabButton.UseVisualStyleBackColor = false;
            closeTabButton.Click += closeTabButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(424, 174);
            label2.Name = "label2";
            label2.Size = new Size(1807, 34);
            label2.TabIndex = 12;
            label2.Text = "Enter the departure, the destination and the number of tickets you want to ride. Then input the given ID into the other form.\r\n";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1564, 489);
            label5.Name = "label5";
            label5.Size = new Size(301, 41);
            label5.TabIndex = 13;
            label5.Text = "Map of the stations:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1130, 47);
            label6.Name = "label6";
            label6.Size = new Size(421, 67);
            label6.TabIndex = 14;
            label6.Text = "Track Finder";
            // 
            // TrackSelector
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(2563, 1371);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(closeTabButton);
            Controls.Add(label4);
            Controls.Add(numberTicketsBox);
            Controls.Add(label3);
            Controls.Add(arrivalTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(departureTextBox);
            Controls.Add(dataGridView);
            Name = "TrackSelector";
            Text = "TrackSelector";
            Load += Form_2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private TextBox departureTextBox;
        private TextBox Filter_TextBox;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox arrivalTextBox;
        private Label label3;
        private TextBox numberTicketsBox;
        private Label label4;
        private Button button1;
        private Button closeTabButton;
        private Label label2;
        private Label label5;
        private Label label6;
    }
}