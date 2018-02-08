namespace SMSystems
{
    partial class UpdateSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSupplier));
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
            this.Closebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CitycomboBox
            // 
            this.CitycomboBox.FormattingEnabled = true;
            this.CitycomboBox.Location = new System.Drawing.Point(140, 194);
            this.CitycomboBox.Name = "CitycomboBox";
            this.CitycomboBox.Size = new System.Drawing.Size(144, 21);
            this.CitycomboBox.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "City";
            // 
            // SupplierDTPicker
            // 
            this.SupplierDTPicker.Location = new System.Drawing.Point(140, 160);
            this.SupplierDTPicker.Name = "SupplierDTPicker";
            this.SupplierDTPicker.Size = new System.Drawing.Size(144, 20);
            this.SupplierDTPicker.TabIndex = 53;
            this.SupplierDTPicker.DropDown += new System.EventHandler(this.CitycomboBox_DropDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Date";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(140, 58);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(144, 20);
            this.NametextBox.TabIndex = 47;
            // 
            // ContacttextBox
            // 
            this.ContacttextBox.Location = new System.Drawing.Point(140, 126);
            this.ContacttextBox.Name = "ContacttextBox";
            this.ContacttextBox.Size = new System.Drawing.Size(144, 20);
            this.ContacttextBox.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Contact No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 48;
            this.label16.Text = "Company Name";
            // 
            // CompanyNametextBox
            // 
            this.CompanyNametextBox.Location = new System.Drawing.Point(140, 92);
            this.CompanyNametextBox.Name = "CompanyNametextBox";
            this.CompanyNametextBox.Size = new System.Drawing.Size(144, 20);
            this.CompanyNametextBox.TabIndex = 49;
            // 
            // Closebtn
            // 
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Closebtn.Image = ((System.Drawing.Image)(resources.GetObject("Closebtn.Image")));
            this.Closebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Closebtn.Location = new System.Drawing.Point(140, 291);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(144, 28);
            this.Closebtn.TabIndex = 58;
            this.Closebtn.Text = "  Close";
            this.Closebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.updatebtn.Image = ((System.Drawing.Image)(resources.GetObject("updatebtn.Image")));
            this.updatebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatebtn.Location = new System.Drawing.Point(140, 255);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(148, 30);
            this.updatebtn.TabIndex = 59;
            this.updatebtn.Text = "  Update";
            this.updatebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // UpdateSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 431);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.CitycomboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SupplierDTPicker);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.ContacttextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CompanyNametextBox);
            this.Name = "UpdateSupplier";
            this.Text = "UpdateSupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.ComboBox CitycomboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker SupplierDTPicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox ContacttextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CompanyNametextBox;
        private System.Windows.Forms.Button updatebtn;
    }
}