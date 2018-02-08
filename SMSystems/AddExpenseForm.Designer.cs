namespace SMSystems
{
    partial class AddExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpenseForm));
            this.AddExpensedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.AddExpenseTypeCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DescriptionAddtxt = new System.Windows.Forms.TextBox();
            this.AddAmounttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addAClose = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddExpensedateTimePicker
            // 
            this.AddExpensedateTimePicker.Location = new System.Drawing.Point(90, 69);
            this.AddExpensedateTimePicker.Name = "AddExpensedateTimePicker";
            this.AddExpensedateTimePicker.Size = new System.Drawing.Size(153, 20);
            this.AddExpensedateTimePicker.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Date";
            // 
            // AddExpenseTypeCombo
            // 
            this.AddExpenseTypeCombo.FormattingEnabled = true;
            this.AddExpenseTypeCombo.Location = new System.Drawing.Point(90, 35);
            this.AddExpenseTypeCombo.Name = "AddExpenseTypeCombo";
            this.AddExpenseTypeCombo.Size = new System.Drawing.Size(153, 21);
            this.AddExpenseTypeCombo.TabIndex = 43;
            this.AddExpenseTypeCombo.DropDown += new System.EventHandler(this.ExpenseTypeCombo_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "ExpenseType";
            // 
            // Addbtn
            // 
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Addbtn.Image = ((System.Drawing.Image)(resources.GetObject("Addbtn.Image")));
            this.Addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbtn.Location = new System.Drawing.Point(90, 170);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(139, 28);
            this.Addbtn.TabIndex = 41;
            this.Addbtn.Text = "     Add && New";
            this.Addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(52, -1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(177, 21);
            this.bunifuCustomLabel1.TabIndex = 40;
            this.bunifuCustomLabel1.Text = "Add New Expense ";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionAddtxt
            // 
            this.DescriptionAddtxt.Location = new System.Drawing.Point(90, 133);
            this.DescriptionAddtxt.Name = "DescriptionAddtxt";
            this.DescriptionAddtxt.Size = new System.Drawing.Size(153, 20);
            this.DescriptionAddtxt.TabIndex = 39;
            // 
            // AddAmounttxt
            // 
            this.AddAmounttxt.Location = new System.Drawing.Point(90, 104);
            this.AddAmounttxt.Name = "AddAmounttxt";
            this.AddAmounttxt.Size = new System.Drawing.Size(153, 20);
            this.AddAmounttxt.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Amount";
            // 
            // addAClose
            // 
            this.addAClose.FlatAppearance.BorderSize = 0;
            this.addAClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAClose.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAClose.ForeColor = System.Drawing.Color.SaddleBrown;
            this.addAClose.Image = ((System.Drawing.Image)(resources.GetObject("addAClose.Image")));
            this.addAClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAClose.Location = new System.Drawing.Point(90, 204);
            this.addAClose.Name = "addAClose";
            this.addAClose.Size = new System.Drawing.Size(139, 28);
            this.addAClose.TabIndex = 46;
            this.addAClose.Text = "     Add && Close";
            this.addAClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addAClose.UseVisualStyleBackColor = true;
            this.addAClose.Click += new System.EventHandler(this.addAClose_Click);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.SaddleBrown;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(90, 238);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(139, 28);
            this.close.TabIndex = 47;
            this.close.Text = "     Close";
            this.close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.close);
            this.Controls.Add(this.addAClose);
            this.Controls.Add(this.AddExpensedateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddExpenseTypeCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.DescriptionAddtxt);
            this.Controls.Add(this.AddAmounttxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddExpenseForm";
            this.Text = "AddExpenseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker AddExpensedateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AddExpenseTypeCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Addbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox DescriptionAddtxt;
        private System.Windows.Forms.TextBox AddAmounttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addAClose;
        private System.Windows.Forms.Button close;
    }
}