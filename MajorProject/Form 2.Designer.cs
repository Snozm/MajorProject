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
            Column_TextBox = new TextBox();
            Filter_TextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
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
            dataGridView1.Size = new Size(993, 885);
            dataGridView1.TabIndex = 0;
            // 
            // Column_TextBox
            // 
            Column_TextBox.Location = new Point(64, 184);
            Column_TextBox.Name = "Column_TextBox";
            Column_TextBox.Size = new Size(417, 31);
            Column_TextBox.TabIndex = 1;
            Column_TextBox.TextChanged += textBox1_TextChanged;
            // 
            // Filter_TextBox
            // 
            Filter_TextBox.Location = new Point(549, 184);
            Filter_TextBox.Name = "Filter_TextBox";
            Filter_TextBox.Size = new Size(246, 31);
            Filter_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 133);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 3;
            label1.Text = "Choose column";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(581, 133);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 4;
            label2.Text = "Choose row";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.x2sxnv1ogieb1__1_;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(1074, 243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(916, 885);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form_2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(2031, 1149);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Filter_TextBox);
            Controls.Add(Column_TextBox);
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
        private TextBox Column_TextBox;
        private TextBox Filter_TextBox;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}