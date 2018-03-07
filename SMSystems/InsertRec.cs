using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSystems
{
    public partial class InsertRec : Form
    {
        Button OldButton;
        Form containerForm;
        BackgroundWorker m_oWorker;
        MainForm mainForm = null;

        public InsertRec(MainForm callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
            m_oWorker = new BackgroundWorker();
            m_oWorker.DoWork += new DoWorkEventHandler(m_oWorker_DoWork);
            m_oWorker.ProgressChanged += new ProgressChangedEventHandler(m_oWorker_ProgressChanged);
            m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_oWorker_RunWorkerCompleted);
            m_oWorker.WorkerReportsProgress = true;
            m_oWorker.WorkerSupportsCancellation = true;

        }

        void m_oWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //If it was cancelled midway
            if (e.Cancelled)
            {
                this.mainForm.lblStatus.Text = "Task Cancelled.";
            }
            else if (e.Error != null)
            {
                this.mainForm.lblStatus.Text = "Error while performing background operation.";
            }
            else
            {
                this.Invoke(
                    (Action)(() =>
                    {
                        containerForm.Show();
                    }));
                this.mainForm.LoadingPanel.Visible = false;
            }
        }
        void m_oWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Here you play with the main UI thread
            this.mainForm.progressBar1.Value = e.ProgressPercentage;
            this.mainForm.lblStatus.Text = "Loading from......" + this.mainForm.progressBar1.Value.ToString() + "%";
        }
        void m_oWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //NOTE : Never play with the UI thread here...
            string formName = (string)e.Argument;
            //time consuming operation
            m_oWorker.ReportProgress(10);
            if (formName.Equals("sizeForm"))
            {
                containerForm = new SizeForm();
                doProgress();
            }
            else if (formName.Equals("colorForm"))
            {
                containerForm = new ColorForm();
                doProgress();
            }
            else if (formName.Equals("categoriesForm"))
            {
                containerForm = new CategoryForForm();
                doProgress();
            }
            else if (formName.Equals("shoeTypeForm"))
            {
                containerForm = new ShoesTypeForm();
                doProgress();
            }
            else if (formName.Equals("expenseForm"))
            {
                containerForm = new ExpenseTypeForm();
                doProgress();
            }
            else if (formName.Equals("companiesForm"))
            {
                containerForm = new CompanyForm();
                doProgress();
            }





            m_oWorker.ReportProgress(100);
            Thread.Sleep(300);
        }

        private void InsertRec_Load(object sender, EventArgs e)
        {
            buttonIndicator.Height = sizebtn.Height;
            changeButtonBorder(sizebtn);
            this.Invoke(
                (Action)(() =>
                {

                    this.mainForm.LoadingPanel.Visible = true;
                }));

            m_oWorker.RunWorkerAsync("sizeForm");
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
            this.mainForm.LoadingPanel.Visible = true;
            buttonIndicator.Height = sizebtn.Height;
            changeButtonBorder(sizebtn);
            buttonIndicator.Top = sizebtn.Top;
            Container.Controls.Clear();
            if (!m_oWorker.IsBusy)
            { m_oWorker.RunWorkerAsync("sizeForm"); }

        }

        private void colorbtn_Click(object sender, EventArgs e)
        {
            this.mainForm.LoadingPanel.Visible = true;
            buttonIndicator.Height = colorbtn.Height;
            changeButtonBorder(colorbtn);
            buttonIndicator.Top = colorbtn.Top;
            Container.Controls.Clear();
            if (!m_oWorker.IsBusy)
            { m_oWorker.RunWorkerAsync("colorForm"); }
        }

        private void categoriesbtn_Click(object sender, EventArgs e)
        {
            this.mainForm.LoadingPanel.Visible = true;
            buttonIndicator.Height = categoriesbtn.Height;
            changeButtonBorder(categoriesbtn);
            buttonIndicator.Top = categoriesbtn.Top;
            Container.Controls.Clear();
            if (!m_oWorker.IsBusy)
            { m_oWorker.RunWorkerAsync("categoriesForm"); }
        }

        private void shoetype_Click(object sender, EventArgs e)
        {
            this.mainForm.LoadingPanel.Visible = true;
            buttonIndicator.Height = shoetype.Height;
            changeButtonBorder(shoetype);
            buttonIndicator.Top = shoetype.Top;
            Container.Controls.Clear();
            if (!m_oWorker.IsBusy)
            { m_oWorker.RunWorkerAsync("shoeTypeForm"); }

        }

        private void expensebtn_Click(object sender, EventArgs e)
        {
            this.mainForm.LoadingPanel.Visible = true;
            buttonIndicator.Height = expensebtn.Height;
            changeButtonBorder(expensebtn);
            buttonIndicator.Top = expensebtn.Top;
            Container.Controls.Clear();
            if (!m_oWorker.IsBusy)
            { m_oWorker.RunWorkerAsync("expenseForm"); }

        }

        private void Companiesbtn_Click(object sender, EventArgs e)
        {
            this.mainForm.LoadingPanel.Visible = true;
            buttonIndicator.Height = Companiesbtn.Height;
            changeButtonBorder(Companiesbtn);
            buttonIndicator.Top = Companiesbtn.Top;
            Container.Controls.Clear();
            if (!m_oWorker.IsBusy)
            { m_oWorker.RunWorkerAsync("companiesForm"); }

        }
        public void doProgress()
        {

            m_oWorker.ReportProgress(40);
            containerForm.TopLevel = false;
            this.Invoke(
                (Action)(() =>
                {
                    Container.Controls.Add(containerForm);
                }));
            m_oWorker.ReportProgress(60);
            this.Invoke(
                (Action)(() =>
                {
                    containerForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                }));
            m_oWorker.ReportProgress(80);
            containerForm.Dock = DockStyle.Fill;
        }
        public void changeButtonBorder(Button newButton)
        {
            if (OldButton != null)
            {
                OldButton.FlatAppearance.BorderColor = Color.White;
                OldButton.FlatAppearance.BorderSize = 0;
                newButton.FlatAppearance.BorderColor = Color.SaddleBrown;
                newButton.FlatAppearance.CheckedBackColor = Color.White;
                newButton.FlatAppearance.BorderSize = 1;

                OldButton = newButton;

            }
            else
            {
                newButton.FlatAppearance.BorderColor = Color.SaddleBrown;
                newButton.FlatAppearance.BorderSize = 1;
                newButton.FlatAppearance.CheckedBackColor = Color.White;
                OldButton = newButton;
            }
        }
    }
}
