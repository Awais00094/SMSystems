namespace SMSystems
{
    partial class ExpensesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensesForm));
            this.label5 = new System.Windows.Forms.Label();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExpensesGridView = new System.Windows.Forms.DataGridView();
            this.colorbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Expenses";
            // 
            // Searchtxt
            // 
            this.Searchtxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Searchtxt.Location = new System.Drawing.Point(172, 16);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(153, 20);
            this.Searchtxt.TabIndex = 10;
            this.Searchtxt.Text = "Search Expenses";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bunifuCards3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(534, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 475);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 475);
            this.panel3.TabIndex = 32;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards3.Controls.Add(this.Addbtn);
            this.bunifuCards3.Controls.Add(this.updatebtn);
            this.bunifuCards3.Controls.Add(this.Deletebtn);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(15, 7);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(229, 179);
            this.bunifuCards3.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Searchtxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.colorbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 54);
            this.panel2.TabIndex = 13;
            // 
            // ExpensesGridView
            // 
            this.ExpensesGridView.AllowUserToAddRows = false;
            this.ExpensesGridView.AllowUserToDeleteRows = false;
            this.ExpensesGridView.AllowUserToResizeColumns = false;
            this.ExpensesGridView.AllowUserToResizeRows = false;
            this.ExpensesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ExpensesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExpensesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpensesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpensesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ExpensesGridView.EnableHeadersVisualStyles = false;
            this.ExpensesGridView.GridColor = System.Drawing.Color.SaddleBrown;
            this.ExpensesGridView.Location = new System.Drawing.Point(0, 54);
            this.ExpensesGridView.MultiSelect = false;
            this.ExpensesGridView.Name = "ExpensesGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ExpensesGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ExpensesGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.ExpensesGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpensesGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ExpensesGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            this.ExpensesGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpensesGridView.Size = new System.Drawing.Size(534, 421);
            this.ExpensesGridView.TabIndex = 34;
            this.ExpensesGridView.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // colorbtn
            // 
            this.colorbtn.FlatAppearance.BorderSize = 0;
            this.colorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorbtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.colorbtn.Image = global::SMSystems.Properties.Resources.Search_24;
            this.colorbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colorbtn.Location = new System.Drawing.Point(331, 10);
            this.colorbtn.Name = "colorbtn";
            this.colorbtn.Size = new System.Drawing.Size(100, 28);
            this.colorbtn.TabIndex = 11;
            this.colorbtn.Text = "     Search";
            this.colorbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.colorbtn.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            this.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Addbtn.Image = global::SMSystems.Properties.Resources.money__1_;
            this.Addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbtn.Location = new System.Drawing.Point(48, 17);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(139, 28);
            this.Addbtn.TabIndex = 42;
            this.Addbtn.Text = "     Insert";
            this.Addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click_1);
            // 
            // updatebtn
            // 
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.updatebtn.Image = ((System.Drawing.Image)(resources.GetObject("updatebtn.Image")));
            this.updatebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatebtn.Location = new System.Drawing.Point(48, 51);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(131, 28);
            this.updatebtn.TabIndex = 30;
            this.updatebtn.Text = "     Update";
            this.updatebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebtn.FlatAppearance.BorderSize = 0;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("Deletebtn.Image")));
            this.Deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deletebtn.Location = new System.Drawing.Point(48, 85);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(121, 28);
            this.Deletebtn.TabIndex = 13;
            this.Deletebtn.Text = "     Delete";
            this.Deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 475);
            this.Controls.Add(this.ExpensesGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpensesForm";
            this.Text = "ExpensesForm";
            this.Load += new System.EventHandler(this.ExpensesForm_Load);
            this.panel1.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Button colorbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.DataGridView ExpensesGridView;
    }
}