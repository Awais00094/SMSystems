using SMS.BL.BLL;
using SMS.BL.Entities;
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
    public partial class InsertRec : Form
    {
        public InsertRec()
        {
            InitializeComponent();
            SizeForm objForm = new SizeForm();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();

        }
                
        private void InsertRec_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (panel1.BorderStyle == BorderStyle.FixedSingle)
            {
                //int thickness = 1;//it's up to you
                //int halfThickness = thickness / 3;
                //using (Pen p = new Pen(Color.SaddleBrown, thickness))
                //{
                //    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                //                                              halfThickness,
                //                                              panel1.ClientSize.Width - thickness,
                //                                              panel1.ClientSize.Height - thickness));
                //}
            }
        }

        private void sizebtn_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = sizebtn.Height;
            buttonIndicator.Top = sizebtn.Top;
            Container.Controls.Clear();
            SizeForm objForm = new SizeForm();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void colorbtn_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = colorbtn.Height;
            buttonIndicator.Top = colorbtn.Top;
            Container.Controls.Clear();
            ColorForm objForm = new ColorForm();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void categoriesbtn_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = categoriesbtn.Height;
            buttonIndicator.Top = categoriesbtn.Top;
            Container.Controls.Clear();
            CategoryForForm objForm = new CategoryForForm();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void shoetype_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = shoetype.Height;
            buttonIndicator.Top = shoetype.Top;
            Container.Controls.Clear();
            ShoesTypeForm objForm = new ShoesTypeForm();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void expensebtn_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = expensebtn.Height;
            buttonIndicator.Top = expensebtn.Top;
            Container.Controls.Clear();
            ExpenseTypeForm objForm = new ExpenseTypeForm();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void Companiesbtn_Click(object sender, EventArgs e)
        {
            buttonIndicator.Height = Companiesbtn.Height;
            buttonIndicator.Top = Companiesbtn.Top;
            Container.Controls.Clear();
            CompanyForm objForm = new CompanyForm();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();

        }
    }
}
