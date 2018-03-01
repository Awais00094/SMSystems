namespace SMSystems
{
    partial class AddSupplierPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplierPayment));
            this.SupplierDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SupplierCombobox = new System.Windows.Forms.ComboBox();
            this.AmountPaytextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalRemainingAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SupplierDTPicker
            // 
            this.SupplierDTPicker.Location = new System.Drawing.Point(121, 65);
            this.SupplierDTPicker.Name = "SupplierDTPicker";
            this.SupplierDTPicker.Size = new System.Drawing.Size(144, 20);
            this.SupplierDTPicker.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Supplier";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Date";
            // 
            // SupplierCombobox
            // 
            this.SupplierCombobox.FormattingEnabled = true;
            this.SupplierCombobox.Location = new System.Drawing.Point(121, 32);
            this.SupplierCombobox.Name = "SupplierCombobox";
            this.SupplierCombobox.Size = new System.Drawing.Size(144, 21);
            this.SupplierCombobox.TabIndex = 58;
            this.SupplierCombobox.DropDown += new System.EventHandler(this.SupplierCombobox_DropDown);
            this.SupplierCombobox.SelectedIndexChanged += new System.EventHandler(this.SupplierCombobox_SelectedIndexChanged);
            // 
            // AmountPaytextBox
            // 
            this.AmountPaytextBox.Location = new System.Drawing.Point(121, 144);
            this.AmountPaytextBox.Name = "AmountPaytextBox";
            this.AmountPaytextBox.Size = new System.Drawing.Size(144, 20);
            this.AmountPaytextBox.TabIndex = 60;
            this.AmountPaytextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountPaytextBox_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Amount Pay";
            // 
            // lblTotalRemainingAmount
            // 
            this.lblTotalRemainingAmount.AutoSize = true;
            this.lblTotalRemainingAmount.Location = new System.Drawing.Point(118, 113);
            this.lblTotalRemainingAmount.Name = "lblTotalRemainingAmount";
            this.lblTotalRemainingAmount.Size = new System.Drawing.Size(22, 13);
            this.lblTotalRemainingAmount.TabIndex = 61;
            this.lblTotalRemainingAmount.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Remaining Amount";
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(70, 253);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(144, 28);
            this.Close.TabIndex = 65;
            this.Close.Text = "  Close";
            this.Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Addbtn.Image = ((System.Drawing.Image)(resources.GetObject("Addbtn.Image")));
            this.Addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbtn.Location = new System.Drawing.Point(70, 207);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(144, 28);
            this.Addbtn.TabIndex = 63;
            this.Addbtn.Text = "  Insert";
            this.Addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // AddSupplierPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 307);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalRemainingAmount);
            this.Controls.Add(this.AmountPaytextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SupplierCombobox);
            this.Controls.Add(this.SupplierDTPicker);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Name = "AddSupplierPayment";
            this.Text = "AddSupplierPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SupplierDTPicker;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox SupplierCombobox;
        private System.Windows.Forms.TextBox AmountPaytextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalRemainingAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Addbtn;
    }
}