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
            Container.Controls.Clear();
            Payments objForm = new Payments();
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
            Container.Controls.Clear();
            InsertRec objForm = new InsertRec();
            objForm.TopLevel = false;
            Container.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

    }
}
