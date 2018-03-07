namespace SMSystems
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorbtn = new System.Windows.Forms.Button();
            this.StockGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockGridView)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(970, 54);
            this.panel2.TabIndex = 17;
            // 
            // Searchtxt
            // 
            this.Searchtxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Searchtxt.Location = new System.Drawing.Point(463, 15);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(181, 20);
            this.Searchtxt.TabIndex = 10;
            this.Searchtxt.Text = "Search Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stock";
            // 
            // colorbtn
            // 
            this.colorbtn.FlatAppearance.BorderSize = 0;
            this.colorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorbtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.colorbtn.Image = global::SMSystems.Properties.Resources.Search_24;
            this.colorbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colorbtn.Location = new System.Drawing.Point(687, 9);
            this.colorbtn.Name = "colorbtn";
            this.colorbtn.Size = new System.Drawing.Size(100, 28);
            this.colorbtn.TabIndex = 11;
            this.colorbtn.Text = "     Search";
            this.colorbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.colorbtn.UseVisualStyleBackColor = true;
            this.colorbtn.Click += new System.EventHandler(this.colorbtn_Click);
            // 
            // StockGridView
            // 
            this.StockGridView.AllowUserToAddRows = false;
            this.StockGridView.AllowUserToDeleteRows = false;
            this.StockGridView.AllowUserToResizeColumns = false;
            this.StockGridView.AllowUserToResizeRows = false;
            this.StockGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.StockGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StockGridView.EnableHeadersVisualStyles = false;
            this.StockGridView.GridColor = System.Drawing.Color.SaddleBrown;
            this.StockGridView.Location = new System.Drawing.Point(0, 54);
            this.StockGridView.MultiSelect = false;
            this.StockGridView.Name = "StockGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StockGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StockGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.StockGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.StockGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            this.StockGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockGridView.Size = new System.Drawing.Size(970, 460);
            this.StockGridView.TabIndex = 34;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 514);
            this.Controls.Add(this.StockGridView);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button colorbtn;
        private System.Windows.Forms.DataGridView StockGridView;
    }
}