namespace Pogramming_Sample_Interface
{
    partial class BillRentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillRentForm));
            this.RentPayNoSearchBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TypeRentPayNoTextBox = new System.Windows.Forms.TextBox();
            this.SearchRentPayGroupBox = new System.Windows.Forms.GroupBox();
            this.RentBillGroupBox = new System.Windows.Forms.GroupBox();
            this.VehiclePayment = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.Label();
            this.RentAmount = new System.Windows.Forms.Label();
            this.DriverPayment = new System.Windows.Forms.Label();
            this.RentNo = new System.Windows.Forms.Label();
            this.RenPayNo = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchRentPayGroupBox.SuspendLayout();
            this.RentBillGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RentPayNoSearchBtn
            // 
            this.RentPayNoSearchBtn.BackColor = System.Drawing.Color.Lavender;
            this.RentPayNoSearchBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentPayNoSearchBtn.Location = new System.Drawing.Point(109, 131);
            this.RentPayNoSearchBtn.Name = "RentPayNoSearchBtn";
            this.RentPayNoSearchBtn.Size = new System.Drawing.Size(114, 58);
            this.RentPayNoSearchBtn.TabIndex = 2;
            this.RentPayNoSearchBtn.Text = "Search";
            this.RentPayNoSearchBtn.UseVisualStyleBackColor = false;
            this.RentPayNoSearchBtn.Click += new System.EventHandler(this.RentPayNoSearchBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(299, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Type Rent Payment Number";
            // 
            // TypeRentPayNoTextBox
            // 
            this.TypeRentPayNoTextBox.Location = new System.Drawing.Point(56, 76);
            this.TypeRentPayNoTextBox.Name = "TypeRentPayNoTextBox";
            this.TypeRentPayNoTextBox.Size = new System.Drawing.Size(232, 34);
            this.TypeRentPayNoTextBox.TabIndex = 1;
            // 
            // SearchRentPayGroupBox
            // 
            this.SearchRentPayGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchRentPayGroupBox.Controls.Add(this.RentPayNoSearchBtn);
            this.SearchRentPayGroupBox.Controls.Add(this.label9);
            this.SearchRentPayGroupBox.Controls.Add(this.TypeRentPayNoTextBox);
            this.SearchRentPayGroupBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchRentPayGroupBox.Location = new System.Drawing.Point(233, 344);
            this.SearchRentPayGroupBox.Name = "SearchRentPayGroupBox";
            this.SearchRentPayGroupBox.Size = new System.Drawing.Size(347, 199);
            this.SearchRentPayGroupBox.TabIndex = 10;
            this.SearchRentPayGroupBox.TabStop = false;
            this.SearchRentPayGroupBox.Text = "Search";
            // 
            // RentBillGroupBox
            // 
            this.RentBillGroupBox.Controls.Add(this.VehiclePayment);
            this.RentBillGroupBox.Controls.Add(this.DateTime);
            this.RentBillGroupBox.Controls.Add(this.RentAmount);
            this.RentBillGroupBox.Controls.Add(this.DriverPayment);
            this.RentBillGroupBox.Controls.Add(this.RentNo);
            this.RentBillGroupBox.Controls.Add(this.RenPayNo);
            this.RentBillGroupBox.Controls.Add(this.label26);
            this.RentBillGroupBox.Controls.Add(this.label3);
            this.RentBillGroupBox.Controls.Add(this.label2);
            this.RentBillGroupBox.Controls.Add(this.label4);
            this.RentBillGroupBox.Controls.Add(this.label5);
            this.RentBillGroupBox.Controls.Add(this.label1);
            this.RentBillGroupBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentBillGroupBox.Location = new System.Drawing.Point(156, 12);
            this.RentBillGroupBox.Name = "RentBillGroupBox";
            this.RentBillGroupBox.Size = new System.Drawing.Size(508, 324);
            this.RentBillGroupBox.TabIndex = 12;
            this.RentBillGroupBox.TabStop = false;
            this.RentBillGroupBox.Text = "Rent Bill";
            // 
            // VehiclePayment
            // 
            this.VehiclePayment.AutoSize = true;
            this.VehiclePayment.Location = new System.Drawing.Point(252, 129);
            this.VehiclePayment.Name = "VehiclePayment";
            this.VehiclePayment.Size = new System.Drawing.Size(57, 19);
            this.VehiclePayment.TabIndex = 24;
            this.VehiclePayment.Text = "............";
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.Location = new System.Drawing.Point(252, 255);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(57, 19);
            this.DateTime.TabIndex = 24;
            this.DateTime.Text = "............";
            // 
            // RentAmount
            // 
            this.RentAmount.AutoSize = true;
            this.RentAmount.Location = new System.Drawing.Point(252, 211);
            this.RentAmount.Name = "RentAmount";
            this.RentAmount.Size = new System.Drawing.Size(57, 19);
            this.RentAmount.TabIndex = 24;
            this.RentAmount.Text = "............";
            // 
            // DriverPayment
            // 
            this.DriverPayment.AutoSize = true;
            this.DriverPayment.Location = new System.Drawing.Point(252, 170);
            this.DriverPayment.Name = "DriverPayment";
            this.DriverPayment.Size = new System.Drawing.Size(57, 19);
            this.DriverPayment.TabIndex = 24;
            this.DriverPayment.Text = "............";
            // 
            // RentNo
            // 
            this.RentNo.AutoSize = true;
            this.RentNo.Location = new System.Drawing.Point(252, 84);
            this.RentNo.Name = "RentNo";
            this.RentNo.Size = new System.Drawing.Size(57, 19);
            this.RentNo.TabIndex = 24;
            this.RentNo.Text = "............";
            // 
            // RenPayNo
            // 
            this.RenPayNo.AutoSize = true;
            this.RenPayNo.Location = new System.Drawing.Point(252, 46);
            this.RenPayNo.Name = "RenPayNo";
            this.RenPayNo.Size = new System.Drawing.Size(57, 19);
            this.RenPayNo.TabIndex = 24;
            this.RenPayNo.Text = "............";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(44, 211);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 19);
            this.label26.TabIndex = 23;
            this.label26.Text = "Rent Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Driver Payment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Vehicle Payment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rent_Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date and Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Rent Payment Number:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(687, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 58);
            this.button1.TabIndex = 13;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BillRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(813, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RentBillGroupBox);
            this.Controls.Add(this.SearchRentPayGroupBox);
            this.Name = "BillRentForm";
            this.Text = "BillRent";
            this.Load += new System.EventHandler(this.BillRentForm_Load);
            this.SearchRentPayGroupBox.ResumeLayout(false);
            this.SearchRentPayGroupBox.PerformLayout();
            this.RentBillGroupBox.ResumeLayout(false);
            this.RentBillGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RentPayNoSearchBtn;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox TypeRentPayNoTextBox;
        private System.Windows.Forms.GroupBox SearchRentPayGroupBox;
        private System.Windows.Forms.GroupBox RentBillGroupBox;
        internal System.Windows.Forms.Label VehiclePayment;
        internal System.Windows.Forms.Label DateTime;
        internal System.Windows.Forms.Label RentAmount;
        internal System.Windows.Forms.Label DriverPayment;
        internal System.Windows.Forms.Label RentNo;
        internal System.Windows.Forms.Label RenPayNo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}