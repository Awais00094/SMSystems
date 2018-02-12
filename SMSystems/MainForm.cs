using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSystems
{
    public partial class MainForm : Form
    {
        Button OldButton;
        public MainForm()
        {
            InitializeComponent();
            buttonIndicator.Height = button1.Height;
            Home objForm = new Home();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = button1.Height;
            buttonIndicator.Top = button1.Top;
            changeButtonBorder(button1);

            Container.Controls.Clear();
            Home objForm = new Home(1);
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = button6.Height;
            buttonIndicator.Top = button6.Top;
            changeButtonBorder(button6);

            Container.Controls.Clear();
            Stock objForm = new Stock();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = button5.Height;
            buttonIndicator.Top = button5.Top;
            changeButtonBorder(button5);

            Container.Controls.Clear();
            ExpensesForm objForm = new ExpensesForm();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = button11.Height;
            buttonIndicator.Top = button11.Top;
            changeButtonBorder(button11);

            Container.Controls.Clear();
            InsertRec objForm = new InsertRec();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = button2.Height;
            buttonIndicator.Top = button2.Top;
            changeButtonBorder(button2);

            Container.Controls.Clear();
            SupplierForm objForm = new SupplierForm();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = button3.Height;
            buttonIndicator.Top = button3.Top;
            changeButtonBorder(button3);

            Container.Controls.Clear();
            ProductFormDetail objForm = new ProductFormDetail();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void PurchasesBtn_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = PurchasesBtn.Height;
            buttonIndicator.Top = PurchasesBtn.Top;
            changeButtonBorder(PurchasesBtn);

            Container.Controls.Clear();
            Purchasing objForm = new Purchasing();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }
        public void changeButtonBorder(Button newButton)
        {
            if (OldButton != null)
            {
                OldButton.FlatAppearance.BorderColor = Color.White;
                OldButton.FlatAppearance.BorderSize = 0;
                newButton.FlatAppearance.BorderColor = Color.White;
                newButton.FlatAppearance.BorderSize = 1;
                OldButton = newButton;

            }
            else
            {
                newButton.FlatAppearance.BorderColor = Color.White;
                newButton.FlatAppearance.BorderSize = 1;
                OldButton = newButton;
            }
        }
    }
}
