namespace MajorProject
{
    partial class Payment
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
            cardTypeComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cardNumberTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            label3 = new Label();
            lastNameTextBox = new TextBox();
            label4 = new Label();
            securityCodeTextBox = new TextBox();
            label5 = new Label();
            cityTextBox = new TextBox();
            label6 = new Label();
            phoneNumberTextBox = new TextBox();
            label7 = new Label();
            billingAddressTextBox = new TextBox();
            label8 = new Label();
            zipTextBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            expirationMonthComboBox = new ComboBox();
            expirationYearComboBox = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            countryComboBox = new ComboBox();
            payButton = new Button();
            SuspendLayout();
            // 
            // cardTypeComboBox
            // 
            cardTypeComboBox.BackColor = Color.White;
            cardTypeComboBox.FormattingEnabled = true;
            cardTypeComboBox.Items.AddRange(new object[] { "MasterCard", "Visa" });
            cardTypeComboBox.Location = new Point(86, 83);
            cardTypeComboBox.Name = "cardTypeComboBox";
            cardTypeComboBox.Size = new Size(205, 23);
            cardTypeComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 62);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 1;
            label1.Text = "Select a payment method";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(86, 113);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Card number";
            // 
            // cardNumberTextBox
            // 
            cardNumberTextBox.Location = new Point(86, 131);
            cardNumberTextBox.Name = "cardNumberTextBox";
            cardNumberTextBox.Size = new Size(205, 23);
            cardNumberTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(86, 237);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(86, 219);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "First name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(191, 237);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(191, 219);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 6;
            label4.Text = "Last name";
            // 
            // securityCodeTextBox
            // 
            securityCodeTextBox.Location = new Point(471, 131);
            securityCodeTextBox.Name = "securityCodeTextBox";
            securityCodeTextBox.Size = new Size(60, 23);
            securityCodeTextBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(471, 113);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 8;
            label5.Text = "CV";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(326, 237);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(205, 23);
            cityTextBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(326, 219);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 10;
            label6.Text = "City";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(326, 338);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(205, 23);
            phoneNumberTextBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(326, 320);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 12;
            label7.Text = "Phone number";
            // 
            // billingAddressTextBox
            // 
            billingAddressTextBox.Location = new Point(86, 288);
            billingAddressTextBox.Name = "billingAddressTextBox";
            billingAddressTextBox.Size = new Size(205, 23);
            billingAddressTextBox.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(86, 270);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 14;
            label8.Text = "Billing address";
            // 
            // zipTextBox
            // 
            zipTextBox.Location = new Point(326, 288);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(205, 23);
            zipTextBox.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(326, 269);
            label9.Name = "label9";
            label9.Size = new Size(134, 20);
            label9.TabIndex = 16;
            label9.Text = "Zip or postal code";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(69, 16);
            label10.Name = "label10";
            label10.Size = new Size(291, 32);
            label10.TabIndex = 18;
            label10.Text = "PAYMENT METHOD";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(69, 175);
            label11.Name = "label11";
            label11.Size = new Size(364, 32);
            label11.TabIndex = 19;
            label11.Text = "BILLING INFORMATION";
            // 
            // expirationMonthComboBox
            // 
            expirationMonthComboBox.FormattingEnabled = true;
            expirationMonthComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            expirationMonthComboBox.Location = new Point(326, 131);
            expirationMonthComboBox.Name = "expirationMonthComboBox";
            expirationMonthComboBox.Size = new Size(49, 23);
            expirationMonthComboBox.TabIndex = 2;
            // 
            // expirationYearComboBox
            // 
            expirationYearComboBox.FormattingEnabled = true;
            expirationYearComboBox.Items.AddRange(new object[] { "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049" });
            expirationYearComboBox.Location = new Point(381, 131);
            expirationYearComboBox.Name = "expirationYearComboBox";
            expirationYearComboBox.Size = new Size(84, 23);
            expirationYearComboBox.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(326, 113);
            label12.Name = "label12";
            label12.Size = new Size(115, 20);
            label12.TabIndex = 22;
            label12.Text = "Expiration date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(86, 321);
            label13.Name = "label13";
            label13.Size = new Size(66, 20);
            label13.TabIndex = 24;
            label13.Text = "Country";
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Items.AddRange(new object[] { "Bulgaria", "Other..." });
            countryComboBox.Location = new Point(86, 339);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(205, 23);
            countryComboBox.TabIndex = 10;
            // 
            // payButton
            // 
            payButton.BackColor = Color.DarkSlateGray;
            payButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            payButton.ForeColor = SystemColors.ButtonHighlight;
            payButton.Location = new Point(86, 390);
            payButton.Name = "payButton";
            payButton.Size = new Size(444, 41);
            payButton.TabIndex = 12;
            payButton.Text = "Continue";
            payButton.UseVisualStyleBackColor = false;
            payButton.Click += payButton_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(624, 443);
            Controls.Add(payButton);
            Controls.Add(label13);
            Controls.Add(countryComboBox);
            Controls.Add(label12);
            Controls.Add(expirationYearComboBox);
            Controls.Add(expirationMonthComboBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(zipTextBox);
            Controls.Add(label9);
            Controls.Add(billingAddressTextBox);
            Controls.Add(label8);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(label7);
            Controls.Add(cityTextBox);
            Controls.Add(label6);
            Controls.Add(securityCodeTextBox);
            Controls.Add(label5);
            Controls.Add(lastNameTextBox);
            Controls.Add(label4);
            Controls.Add(firstNameTextBox);
            Controls.Add(label3);
            Controls.Add(cardNumberTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cardTypeComboBox);
            Name = "Payment";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cardTypeComboBox;
        private Label label1;
        private Label label2;
        private TextBox cardNumberTextBox;
        private TextBox firstNameTextBox;
        private Label label3;
        private TextBox lastNameTextBox;
        private Label label4;
        private TextBox securityCodeTextBox;
        private Label label5;
        private TextBox cityTextBox;
        private Label label6;
        private TextBox phoneNumberTextBox;
        private Label label7;
        private TextBox billingAddressTextBox;
        private Label label8;
        private TextBox zipTextBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox expirationMonthComboBox;
        private ComboBox expirationYearComboBox;
        private Label label12;
        private Label label13;
        private ComboBox countryComboBox;
        private Button payButton;
    }
}