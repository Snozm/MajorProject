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
        this.lblName = new System.Windows.Forms.Label();
        this.lblDestination = new System.Windows.Forms.Label();
        this.lblSeat = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblName.Location = new System.Drawing.Point(35, 40);
        this.lblName.Name = "lblName";
        this.lblName.Size = new System.Drawing.Size(108, 20);
        this.lblName.TabIndex = 0;
        this.lblName.Text = "Ticket for: ?";
        // 
        // lblDestination
        // 
        this.lblDestination.AutoSize = true;
        this.lblDestination.Location = new System.Drawing.Point(35, 80);
        this.lblDestination.Name = "lblDestination";
        this.lblDestination.Size = new System.Drawing.Size(76, 13);
        this.lblDestination.TabIndex = 1;
        this.lblDestination.Text = "Destination: ?";
        // 
        // lblSeat
        // 
        this.lblSeat.AutoSize = true;
        this.lblSeat.Location = new System.Drawing.Point(35, 120);
        this.lblSeat.Name = "lblSeat";
        this.lblSeat.Size = new System.Drawing.Size(47, 13);
        this.lblSeat.TabIndex = 2;
        this.lblSeat.Text = "Seat:  ?";
        // 
        // TicketForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(284, 161);
        this.Controls.Add(this.lblSeat);
        this.Controls.Add(this.lblDestination);
        this.Controls.Add(this.lblName);
        this.Name = "TicketForm";
        this.Text = "Ticket";
        this.Load += new System.EventHandler(this.TicketForm_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblDestination;
    private System.Windows.Forms.Label lblSeat;
}
