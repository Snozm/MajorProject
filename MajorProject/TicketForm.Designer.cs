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
            lblName = new Label();
            lblDestination = new Label();
            lblSeat = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(41, 46);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Ticket for: ?";
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(41, 92);
            lblDestination.Margin = new Padding(4, 0, 4, 0);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(78, 15);
            lblDestination.TabIndex = 1;
            lblDestination.Text = "Destination: ?";
            // 
            // lblSeat
            // 
            lblSeat.AutoSize = true;
            lblSeat.Location = new Point(41, 133);
            lblSeat.Margin = new Padding(4, 0, 4, 0);
            lblSeat.Name = "lblSeat";
            lblSeat.Size = new Size(43, 15);
            lblSeat.TabIndex = 2;
            lblSeat.Text = "Seat:  ?";
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 186);
            Controls.Add(lblSeat);
            Controls.Add(lblDestination);
            Controls.Add(lblName);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TicketForm";
            Text = "Ticket";
            Load += TicketForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblSeat;
    }
}