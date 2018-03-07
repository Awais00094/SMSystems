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
            this.AddExpensedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddExpenseTypeCombo = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DescriptionAddtxt = new System.Windows.Forms.TextBox();
            this.AddAmounttxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.addAClose = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddExpensedateTimePicker
            // 
            this.AddExpensedateTimePicker.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.AddExpensedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AddExpensedateTimePicker.Location = new System.Drawing.Point(119, 87);
            this.AddExpensedateTimePicker.Name = "AddExpensedateTimePicker";
            this.AddExpensedateTimePicker.Size = new System.Drawing.Size(153, 20);
            this.AddExpensedateTimePicker.TabIndex = 45;
            // 
            // AddExpenseTypeCombo
            // 
            this.AddExpenseTypeCombo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AddExpenseTypeCombo.FormattingEnabled = true;
            this.AddExpenseTypeCombo.Location = new System.Drawing.Point(119, 54);
            this.AddExpenseTypeCombo.Name = "AddExpenseTypeCombo";
            this.AddExpenseTypeCombo.Size = new System.Drawing.Size(153, 21);
            this.AddExpenseTypeCombo.TabIndex = 43;
            this.AddExpenseTypeCombo.DropDown += new System.EventHandler(this.ExpenseTypeCombo_DropDown);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(82, 4);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(177, 21);
            this.bunifuCustomLabel1.TabIndex = 40;
            this.bunifuCustomLabel1.Text = "Add New Expense ";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionAddtxt
            // 
            this.DescriptionAddtxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.DescriptionAddtxt.Location = new System.Drawing.Point(119, 153);
            this.DescriptionAddtxt.Name = "DescriptionAddtxt";
            this.DescriptionAddtxt.Size = new System.Drawing.Size(153, 20);
            this.DescriptionAddtxt.TabIndex = 39;
            // 
            // AddAmounttxt
            // 
            this.AddAmounttxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AddAmounttxt.Location = new System.Drawing.Point(119, 120);
            this.AddAmounttxt.Name = "AddAmounttxt";
            this.AddAmounttxt.Size = new System.Drawing.Size(153, 20);
            this.AddAmounttxt.TabIndex = 38;
            this.AddAmounttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddAmounttxt_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 29);
            this.panel1.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(35, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Expense Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(35, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(35, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(35, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 52;
            this.label7.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(339, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 295);
            this.panel2.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 295);
            this.panel3.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 323);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(338, 1);
            this.panel4.TabIndex = 55;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::SMSystems.Properties.Resources.Cross_24__1_;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(304, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(33, 27);
            this.button8.TabIndex = 41;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.SaddleBrown;
            this.close.Image = global::SMSystems.Properties.Resources.close;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(119, 260);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(139, 32);
            this.close.TabIndex = 47;
            this.close.Text = " Close";
            this.close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // addAClose
            // 
            this.addAClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAClose.FlatAppearance.BorderSize = 0;
            this.addAClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAClose.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAClose.ForeColor = System.Drawing.Color.SaddleBrown;
            this.addAClose.Image = global::SMSystems.Properties.Resources.money__1_;
            this.addAClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAClose.Location = new System.Drawing.Point(119, 226);
            this.addAClose.Name = "addAClose";
            this.addAClose.Size = new System.Drawing.Size(139, 28);
            this.addAClose.TabIndex = 46;
            this.addAClose.Text = " Add && Close";
            this.addAClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addAClose.UseVisualStyleBackColor = true;
            this.addAClose.Click += new System.EventHandler(this.addAClose_Click);
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
            this.Addbtn.Location = new System.Drawing.Point(119, 192);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(140, 28);
            this.Addbtn.TabIndex = 41;
            this.Addbtn.Text = " Add && New";
            this.Addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 324);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.addAClose);
            this.Controls.Add(this.AddExpensedateTimePicker);
            this.Controls.Add(this.AddExpenseTypeCombo);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.DescriptionAddtxt);
            this.Controls.Add(this.AddAmounttxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddExpenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExpenseForm";
            this.Load += new System.EventHandler(this.AddExpenseForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker AddExpensedateTimePicker;
        private System.Windows.Forms.ComboBox AddExpenseTypeCombo;
        private System.Windows.Forms.Button Addbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox DescriptionAddtxt;
        private System.Windows.Forms.TextBox AddAmounttxt;
        private System.Windows.Forms.Button addAClose;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button8;
    }
}