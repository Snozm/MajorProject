namespace MajorProject
{
    partial class Form_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_2));
            dataGridView1 = new DataGridView();
            departureTextBox = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            arrivalTextBox = new TextBox();
            label3 = new Label();
            trainTextBox = new TextBox();
            label4 = new Label();
            button2 = new Button();
            label2 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1058, 885);
            dataGridView1.TabIndex = 0;
            // 
            // departureTextBox
            // 
            departureTextBox.Location = new Point(46, 193);
            departureTextBox.Name = "departureTextBox";
            departureTextBox.Size = new Size(262, 31);
            departureTextBox.TabIndex = 1;
            departureTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 145);
            label1.Name = "label1";
            label1.Size = new Size(210, 41);
            label1.TabIndex = 3;
            label1.Text = "Departure City";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.x2sxnv1ogieb1__1_;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(1172, 243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(916, 885);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // arrivalTextBox
            // 
            arrivalTextBox.Location = new Point(346, 193);
            arrivalTextBox.Name = "arrivalTextBox";
            arrivalTextBox.Size = new Size(285, 31);
            arrivalTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(346, 145);
            label3.Name = "label3";
            label3.Size = new Size(100, 41);
            label3.TabIndex = 7;
            label3.Text = "Arrival";
            label3.Click += label3_Click;
            // 
            // trainTextBox
            // 
            trainTextBox.Location = new Point(647, 193);
            trainTextBox.Name = "trainTextBox";
            trainTextBox.Size = new Size(205, 31);
            trainTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(647, 145);
            label4.Name = "label4";
            label4.Size = new Size(80, 41);
            label4.TabIndex = 9;
            label4.Text = "Train";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(871, 162);
            button2.Name = "button2";
            button2.Size = new Size(197, 66);
            button2.TabIndex = 11;
            button2.Text = "Close tab";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 46);
            label2.Name = "label2";
            label2.Size = new Size(2017, 51);
            label2.TabIndex = 12;
            label2.Text = "Enter the departure, the destinatiuon and the type of train you want to ride. Then input the given ID into the other form";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1185, 193);
            label5.Name = "label5";
            label5.Size = new Size(282, 41);
            label5.TabIndex = 13;
            label5.Text = "Map of the stations:";
            // 
            // Form_2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 200, 234);
            ClientSize = new Size(2124, 1149);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(trainTextBox);
            Controls.Add(label3);
            Controls.Add(arrivalTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(departureTextBox);
            Controls.Add(dataGridView1);
            Name = "Form_2";
            Text = "Form_2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox departureTextBox;
        private TextBox Filter_TextBox;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox arrivalTextBox;
        private Label label3;
        private TextBox trainTextBox;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label5;
    }
}