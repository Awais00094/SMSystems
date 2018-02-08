namespace SMSystems
{
    partial class AddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplier));
            this.CitycomboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SupplierDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.ContacttextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CompanyNametextBox = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.AddClosebtn = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CitycomboBox
            // 
            this.CitycomboBox.FormattingEnabled = true;
            this.CitycomboBox.Location = new System.Drawing.Point(127, 184);
            this.CitycomboBox.Name = "CitycomboBox";
            this.CitycomboBox.Size = new System.Drawing.Size(144, 21);
            this.CitycomboBox.TabIndex = 40;
            this.CitycomboBox.DropDown += new System.EventHandler(this.CitycomboBox_DropDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "City";
            // 
            // SupplierDTPicker
            // 
            this.SupplierDTPicker.Location = new System.Drawing.Point(127, 150);
            this.SupplierDTPicker.Name = "SupplierDTPicker";
            this.SupplierDTPicker.Size = new System.Drawing.Size(144, 20);
            this.SupplierDTPicker.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Date";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(127, 48);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(144, 20);
            this.NametextBox.TabIndex = 32;
            // 
            // ContacttextBox
            // 
            this.ContacttextBox.Location = new System.Drawing.Point(127, 116);
            this.ContacttextBox.Name = "ContacttextBox";
            this.ContacttextBox.Size = new System.Drawing.Size(144, 20);
            this.ContacttextBox.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Contact No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Company Name";
            // 
            // CompanyNametextBox
            // 
            this.CompanyNametextBox.Location = new System.Drawing.Point(127, 82);
            this.CompanyNametextBox.Name = "CompanyNametextBox";
            this.CompanyNametextBox.Size = new System.Drawing.Size(144, 20);
            this.CompanyNametextBox.TabIndex = 34;
            // 
            // Addbtn
            // 
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Addbtn.Image = ((System.Drawing.Image)(resources.GetObject("Addbtn.Image")));
            this.Addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbtn.Location = new System.Drawing.Point(127, 222);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(144, 28);
            this.Addbtn.TabIndex = 43;
            this.Addbtn.Text = "  Insert And New";
            this.Addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // AddClosebtn
            // 
            this.AddClosebtn.FlatAppearance.BorderSize = 0;
            this.AddClosebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClosebtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClosebtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AddClosebtn.Image = ((System.Drawing.Image)(resources.GetObject("AddClosebtn.Image")));
            this.AddClosebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddClosebtn.Location = new System.Drawing.Point(127, 267);
            this.AddClosebtn.Name = "AddClosebtn";
            this.AddClosebtn.Size = new System.Drawing.Size(144, 28);
            this.AddClosebtn.TabIndex = 44;
            this.AddClosebtn.Text = "  Insert And Close";
            this.AddClosebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddClosebtn.UseVisualStyleBackColor = true;
            this.AddClosebtn.Click += new System.EventHandler(this.AddClosebtn_Click);
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(127, 318);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(144, 28);
            this.Close.TabIndex = 45;
            this.Close.Text = "  Close";
            this.Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 372);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.AddClosebtn);
            this.Controls.Add(this.CitycomboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.SupplierDTPicker);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.ContacttextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CompanyNametextBox);
            this.Name = "AddSupplier";
            this.Text = "AddSupplier";
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CitycomboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.DateTimePicker SupplierDTPicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox ContacttextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CompanyNametextBox;
        private System.Windows.Forms.Button AddClosebtn;
        private System.Windows.Forms.Button Close;
    }
}