namespace MajorProject
{
    partial class TicketForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            lblName = new Label();
            lblDestination = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Blackadder ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.SaddleBrown;
            lblName.Location = new Point(264, 110);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(97, 41);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.BackColor = Color.Transparent;
            lblDestination.Font = new Font("Blackadder ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDestination.ForeColor = Color.SaddleBrown;
            lblDestination.Location = new Point(264, 155);
            lblDestination.Margin = new Padding(6, 0, 6, 0);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(155, 41);
            lblDestination.TabIndex = 1;
            lblDestination.Text = "Destination:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Old English Text MT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(99, 41);
            label1.Name = "label1";
            label1.Size = new Size(282, 57);
            label1.TabIndex = 3;
            label1.Text = "Train Ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Blackadder ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(99, 113);
            label2.Name = "label2";
            label2.Size = new Size(92, 41);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Blackadder ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(99, 157);
            label3.Name = "label3";
            label3.Size = new Size(155, 41);
            label3.TabIndex = 5;
            label3.Text = "Destination:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.unnamed;
            pictureBox1.Location = new Point(389, 212);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(881, 342);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDestination);
            Controls.Add(lblName);
            Margin = new Padding(6, 7, 6, 7);
            Name = "TicketForm";
            Text = "Ticket";
            Load += TicketForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblDestination;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}