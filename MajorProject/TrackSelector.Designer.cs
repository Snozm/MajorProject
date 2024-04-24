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
            dataGridView = new DataGridView();
            departureTextBox = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            arrivalTextBox = new TextBox();
            label3 = new Label();
            trainTextBox = new TextBox();
            label4 = new Label();
            closeTabButton = new Button();
            label2 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(32, 146);
            dataGridView.Margin = new Padding(2, 2, 2, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(741, 531);
            dataGridView.TabIndex = 0;
            // 
            // departureTextBox
            // 
            departureTextBox.Location = new Point(32, 116);
            departureTextBox.Margin = new Padding(2, 2, 2, 2);
            departureTextBox.Name = "departureTextBox";
            departureTextBox.Size = new Size(185, 23);
            departureTextBox.TabIndex = 1;
            departureTextBox.TextChanged += textBox1_TextChanged;
            departureTextBox.Leave += departureTextBox_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 3;
            label1.Text = "Departure City";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.x2sxnv1ogieb1__1_;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(820, 146);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(641, 531);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // arrivalTextBox
            // 
            arrivalTextBox.Location = new Point(242, 116);
            arrivalTextBox.Margin = new Padding(2, 2, 2, 2);
            arrivalTextBox.Name = "arrivalTextBox";
            arrivalTextBox.Size = new Size(201, 23);
            arrivalTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(242, 87);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 7;
            label3.Text = "Arrival";
            label3.Click += label3_Click;
            // 
            // trainTextBox
            // 
            trainTextBox.Location = new Point(453, 116);
            trainTextBox.Margin = new Padding(2, 2, 2, 2);
            trainTextBox.Name = "trainTextBox";
            trainTextBox.Size = new Size(145, 23);
            trainTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(440, 81);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 9;
            label4.Text = "Number of Tickets";
            label4.Click += label4_Click;
            // 
            // closeTabButton
            // 
            closeTabButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            closeTabButton.Location = new Point(635, 102);
            closeTabButton.Margin = new Padding(2, 2, 2, 2);
            closeTabButton.Name = "closeTabButton";
            closeTabButton.Size = new Size(138, 40);
            closeTabButton.TabIndex = 11;
            closeTabButton.Text = "Close tab";
            closeTabButton.UseVisualStyleBackColor = true;
            closeTabButton.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 28);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(1397, 35);
            label2.TabIndex = 12;
            label2.Text = "Enter the departure, the destination and the number of tickets you want to ride. Then input the given ID into the other form";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(830, 116);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(185, 28);
            label5.TabIndex = 13;
            label5.Text = "Map of the stations:";
            // 
            // TrackDesigner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 200, 234);
            ClientSize = new Size(1347, 637);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(closeTabButton);
            Controls.Add(label4);
            Controls.Add(trainTextBox);
            Controls.Add(label3);
            Controls.Add(arrivalTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(departureTextBox);
            Controls.Add(dataGridView);
            Margin = new Padding(2, 2, 2, 2);
            Name = "TrackDesigner";
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
        private TextBox trainTextBox;
        private Label label4;
        private Button button1;
        private Button closeTabButton;
        private Label label2;
        private Label label5;
    }
}