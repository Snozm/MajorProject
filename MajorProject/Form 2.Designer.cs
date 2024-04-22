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
            ColumnTextBox = new TextBox();
            Filter_TextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
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
            // ColumnTextBox
            // 
            ColumnTextBox.Location = new Point(46, 193);
            ColumnTextBox.Name = "ColumnTextBox";
            ColumnTextBox.Size = new Size(262, 31);
            ColumnTextBox.TabIndex = 1;
            ColumnTextBox.TextChanged += textBox1_TextChanged;
            // 
            // Filter_TextBox
            // 
            Filter_TextBox.Location = new Point(858, 193);
            Filter_TextBox.Name = "Filter_TextBox";
            Filter_TextBox.Size = new Size(246, 31);
            Filter_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 156);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 3;
            label1.Text = "Departure City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(858, 156);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 4;
            label2.Text = "TicketType";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.x2sxnv1ogieb1__1_;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(1553, 225);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(916, 885);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(346, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 31);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 156);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 7;
            label3.Text = "Arrival";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(647, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 31);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(657, 155);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 9;
            label4.Text = "Train";
            // 
            // Form_2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(2500, 1149);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Filter_TextBox);
            Controls.Add(ColumnTextBox);
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
        private TextBox ColumnTextBox;
        private TextBox Filter_TextBox;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
    }
}