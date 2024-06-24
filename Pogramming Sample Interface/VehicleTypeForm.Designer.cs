namespace Pogramming_Sample_Interface
{
    partial class VehicleTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleTypeForm));
            this.VehicleTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearTextBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.VehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.PerMonthTextBox = new System.Windows.Forms.TextBox();
            this.PerWeekBox = new System.Windows.Forms.TextBox();
            this.PerDayTextBox = new System.Windows.Forms.TextBox();
            this.VehicleTyIDTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchVehTyGroupBox = new System.Windows.Forms.GroupBox();
            this.VechicleSearchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeVehicleTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.VehicleTypeGridView = new System.Windows.Forms.DataGridView();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.VehicleTypeGroupBox.SuspendLayout();
            this.SearchVehTyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VehicleTypeGroupBox
            // 
            this.VehicleTypeGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.VehicleTypeGroupBox.Controls.Add(this.ClearTextBtn);
            this.VehicleTypeGroupBox.Controls.Add(this.DeleteBtn);
            this.VehicleTypeGroupBox.Controls.Add(this.UpdateBtn);
            this.VehicleTypeGroupBox.Controls.Add(this.SaveBtn);
            this.VehicleTypeGroupBox.Controls.Add(this.VehicleNameTextBox);
            this.VehicleTypeGroupBox.Controls.Add(this.PerMonthTextBox);
            this.VehicleTypeGroupBox.Controls.Add(this.PerWeekBox);
            this.VehicleTypeGroupBox.Controls.Add(this.PerDayTextBox);
            this.VehicleTypeGroupBox.Controls.Add(this.VehicleTyIDTextBox);
            this.VehicleTypeGroupBox.Controls.Add(this.label6);
            this.VehicleTypeGroupBox.Controls.Add(this.label5);
            this.VehicleTypeGroupBox.Controls.Add(this.label3);
            this.VehicleTypeGroupBox.Controls.Add(this.label2);
            this.VehicleTypeGroupBox.Controls.Add(this.label1);
            this.VehicleTypeGroupBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleTypeGroupBox.Location = new System.Drawing.Point(44, 65);
            this.VehicleTypeGroupBox.Name = "VehicleTypeGroupBox";
            this.VehicleTypeGroupBox.Size = new System.Drawing.Size(861, 364);
            this.VehicleTypeGroupBox.TabIndex = 3;
            this.VehicleTypeGroupBox.TabStop = false;
            this.VehicleTypeGroupBox.Text = "Vehicle Type";
            // 
            // ClearTextBtn
            // 
            this.ClearTextBtn.BackColor = System.Drawing.Color.Lavender;
            this.ClearTextBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearTextBtn.Location = new System.Drawing.Point(611, 275);
            this.ClearTextBtn.Name = "ClearTextBtn";
            this.ClearTextBtn.Size = new System.Drawing.Size(227, 68);
            this.ClearTextBtn.TabIndex = 8;
            this.ClearTextBtn.Text = "Clear Text Box";
            this.ClearTextBtn.UseVisualStyleBackColor = false;
            this.ClearTextBtn.Click += new System.EventHandler(this.ClearTextBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Lavender;
            this.DeleteBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(463, 275);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(120, 68);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Lavender;
            this.UpdateBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(303, 275);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(133, 69);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Lavender;
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(138, 276);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(135, 68);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // VehicleNameTextBox
            // 
            this.VehicleNameTextBox.Location = new System.Drawing.Point(364, 216);
            this.VehicleNameTextBox.Name = "VehicleNameTextBox";
            this.VehicleNameTextBox.Size = new System.Drawing.Size(219, 34);
            this.VehicleNameTextBox.TabIndex = 1;
            this.VehicleNameTextBox.TextChanged += new System.EventHandler(this.VehicleNameTextBox_TextChanged);
            // 
            // PerMonthTextBox
            // 
            this.PerMonthTextBox.Location = new System.Drawing.Point(364, 169);
            this.PerMonthTextBox.Name = "PerMonthTextBox";
            this.PerMonthTextBox.Size = new System.Drawing.Size(219, 34);
            this.PerMonthTextBox.TabIndex = 1;
            this.PerMonthTextBox.TextChanged += new System.EventHandler(this.PerMonthTextBox_TextChanged);
            // 
            // PerWeekBox
            // 
            this.PerWeekBox.Location = new System.Drawing.Point(364, 125);
            this.PerWeekBox.Name = "PerWeekBox";
            this.PerWeekBox.Size = new System.Drawing.Size(219, 34);
            this.PerWeekBox.TabIndex = 1;
            this.PerWeekBox.TextChanged += new System.EventHandler(this.PerWeekBox_TextChanged);
            // 
            // PerDayTextBox
            // 
            this.PerDayTextBox.Location = new System.Drawing.Point(364, 84);
            this.PerDayTextBox.Name = "PerDayTextBox";
            this.PerDayTextBox.Size = new System.Drawing.Size(219, 34);
            this.PerDayTextBox.TabIndex = 1;
            this.PerDayTextBox.TextChanged += new System.EventHandler(this.PerDayTextBox_TextChanged);
            // 
            // VehicleTyIDTextBox
            // 
            this.VehicleTyIDTextBox.Location = new System.Drawing.Point(364, 39);
            this.VehicleTyIDTextBox.Name = "VehicleTyIDTextBox";
            this.VehicleTyIDTextBox.Size = new System.Drawing.Size(219, 34);
            this.VehicleTyIDTextBox.TabIndex = 1;
            this.VehicleTyIDTextBox.TextChanged += new System.EventHandler(this.VehicleTyIDTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vehicle Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Per Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Per Week:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Per Day:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Type ID:";
            // 
            // SearchVehTyGroupBox
            // 
            this.SearchVehTyGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchVehTyGroupBox.Controls.Add(this.VechicleSearchBtn);
            this.SearchVehTyGroupBox.Controls.Add(this.label4);
            this.SearchVehTyGroupBox.Controls.Add(this.TypeVehicleTypeIDTextBox);
            this.SearchVehTyGroupBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchVehTyGroupBox.Location = new System.Drawing.Point(932, 77);
            this.SearchVehTyGroupBox.Name = "SearchVehTyGroupBox";
            this.SearchVehTyGroupBox.Size = new System.Drawing.Size(441, 265);
            this.SearchVehTyGroupBox.TabIndex = 7;
            this.SearchVehTyGroupBox.TabStop = false;
            this.SearchVehTyGroupBox.Text = "Search";
            // 
            // VechicleSearchBtn
            // 
            this.VechicleSearchBtn.BackColor = System.Drawing.Color.Lavender;
            this.VechicleSearchBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VechicleSearchBtn.Location = new System.Drawing.Point(190, 170);
            this.VechicleSearchBtn.Name = "VechicleSearchBtn";
            this.VechicleSearchBtn.Size = new System.Drawing.Size(114, 58);
            this.VechicleSearchBtn.TabIndex = 2;
            this.VechicleSearchBtn.Text = "Search";
            this.VechicleSearchBtn.UseVisualStyleBackColor = false;
            this.VechicleSearchBtn.Click += new System.EventHandler(this.VechicleSearchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type Vehicle Type ID";
            // 
            // TypeVehicleTypeIDTextBox
            // 
            this.TypeVehicleTypeIDTextBox.Location = new System.Drawing.Point(125, 116);
            this.TypeVehicleTypeIDTextBox.Name = "TypeVehicleTypeIDTextBox";
            this.TypeVehicleTypeIDTextBox.Size = new System.Drawing.Size(228, 34);
            this.TypeVehicleTypeIDTextBox.TabIndex = 1;
            // 
            // VehicleTypeGridView
            // 
            this.VehicleTypeGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.VehicleTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleTypeGridView.Location = new System.Drawing.Point(44, 447);
            this.VehicleTypeGridView.Name = "VehicleTypeGridView";
            this.VehicleTypeGridView.RowHeadersWidth = 51;
            this.VehicleTypeGridView.RowTemplate.Height = 24;
            this.VehicleTypeGridView.Size = new System.Drawing.Size(861, 283);
            this.VehicleTypeGridView.TabIndex = 8;
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.BackColor = System.Drawing.Color.Lavender;
            this.MainMenuBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuBtn.Location = new System.Drawing.Point(1065, 642);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(209, 63);
            this.MainMenuBtn.TabIndex = 11;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = false;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // VehicleTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1473, 742);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.VehicleTypeGridView);
            this.Controls.Add(this.SearchVehTyGroupBox);
            this.Controls.Add(this.VehicleTypeGroupBox);
            this.Name = "VehicleTypeForm";
            this.Text = "VehicleTypeForm";
            this.Load += new System.EventHandler(this.VehicleTypeForm_Load);
            this.VehicleTypeGroupBox.ResumeLayout(false);
            this.VehicleTypeGroupBox.PerformLayout();
            this.SearchVehTyGroupBox.ResumeLayout(false);
            this.SearchVehTyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleTypeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox VehicleTypeGroupBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearTextBtn;
        private System.Windows.Forms.GroupBox SearchVehTyGroupBox;
        private System.Windows.Forms.Button VechicleSearchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView VehicleTypeGridView;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox TypeVehicleTypeIDTextBox;
        internal System.Windows.Forms.TextBox PerMonthTextBox;
        internal System.Windows.Forms.TextBox PerWeekBox;
        internal System.Windows.Forms.TextBox PerDayTextBox;
        internal System.Windows.Forms.TextBox VehicleNameTextBox;
        internal System.Windows.Forms.TextBox VehicleTyIDTextBox;
    }
}