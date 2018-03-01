namespace SMSystems
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.AddSupplierPayment = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.SupplierGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Searchtxt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.colorbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 54);
            this.panel2.TabIndex = 14;
            // 
            // Searchtxt
            // 
            this.Searchtxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Searchtxt.Location = new System.Drawing.Point(140, 16);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(181, 20);
            this.Searchtxt.TabIndex = 10;
            this.Searchtxt.Text = "Search Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Suppliers";
            // 
            // colorbtn
            // 
            this.colorbtn.FlatAppearance.BorderSize = 0;
            this.colorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorbtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.colorbtn.Image = global::SMSystems.Properties.Resources.Search_24;
            this.colorbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colorbtn.Location = new System.Drawing.Point(326, 9);
            this.colorbtn.Name = "colorbtn";
            this.colorbtn.Size = new System.Drawing.Size(100, 28);
            this.colorbtn.TabIndex = 11;
            this.colorbtn.Text = "     Search";
            this.colorbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.colorbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bunifuCards3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(623, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 726);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 726);
            this.panel3.TabIndex = 33;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards3.Controls.Add(this.AddSupplierPayment);
            this.bunifuCards3.Controls.Add(this.Addbtn);
            this.bunifuCards3.Controls.Add(this.updatebtn);
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards3.Controls.Add(this.Deletebtn);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(23, 179);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(243, 204);
            this.bunifuCards3.TabIndex = 32;
            // 
            // AddSupplierPayment
            // 
            this.AddSupplierPayment.FlatAppearance.BorderSize = 0;
            this.AddSupplierPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSupplierPayment.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupplierPayment.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AddSupplierPayment.Image = ((System.Drawing.Image)(resources.GetObject("AddSupplierPayment.Image")));
            this.AddSupplierPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddSupplierPayment.Location = new System.Drawing.Point(43, 53);
            this.AddSupplierPayment.Name = "AddSupplierPayment";
            this.AddSupplierPayment.Size = new System.Drawing.Size(156, 32);
            this.AddSupplierPayment.TabIndex = 47;
            this.AddSupplierPayment.Text = "     Add Payments";
            this.AddSupplierPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddSupplierPayment.UseVisualStyleBackColor = true;
            this.AddSupplierPayment.Click += new System.EventHandler(this.AddSupplierPayment_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Addbtn.Image = ((System.Drawing.Image)(resources.GetObject("Addbtn.Image")));
            this.Addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbtn.Location = new System.Drawing.Point(43, 91);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(156, 32);
            this.Addbtn.TabIndex = 46;
            this.Addbtn.Text = "     Insert";
            this.Addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.updatebtn.Image = ((System.Drawing.Image)(resources.GetObject("updatebtn.Image")));
            this.updatebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatebtn.Location = new System.Drawing.Point(43, 130);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(156, 30);
            this.updatebtn.TabIndex = 31;
            this.updatebtn.Text = "     Update";
            this.updatebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click_1);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(60, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(116, 21);
            this.bunifuCustomLabel2.TabIndex = 30;
            this.bunifuCustomLabel2.Text = "Action";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deletebtn
            // 
            this.Deletebtn.FlatAppearance.BorderSize = 0;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("Deletebtn.Image")));
            this.Deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deletebtn.Location = new System.Drawing.Point(43, 165);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(156, 28);
            this.Deletebtn.TabIndex = 13;
            this.Deletebtn.Text = "     Delete";
            this.Deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // SupplierGridView
            // 
            this.SupplierGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SupplierGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SupplierGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SupplierGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierGridView.Location = new System.Drawing.Point(0, 54);
            this.SupplierGridView.Name = "SupplierGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SupplierGridView.Size = new System.Drawing.Size(623, 726);
            this.SupplierGridView.TabIndex = 16;
            this.SupplierGridView.SelectionChanged += new System.EventHandler(this.SupplierGridView_SelectionChanged);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 780);
            this.ControlBox = false;
            this.Controls.Add(this.SupplierGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button colorbtn;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView SupplierGridView;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button AddSupplierPayment;
    }
}