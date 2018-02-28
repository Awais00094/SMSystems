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
    public partial class MainForm : Form
    {
        Button OldButton;
        Form containerForm;
        BackgroundWorker m_oWorker;

        public MainForm()
        {
            InitializeComponent();
            m_oWorker = new BackgroundWorker();
            m_oWorker.DoWork += new DoWorkEventHandler(m_oWorker_DoWork);
            m_oWorker.ProgressChanged += new ProgressChangedEventHandler(m_oWorker_ProgressChanged);
            m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_oWorker_RunWorkerCompleted);
            m_oWorker.WorkerReportsProgress = true;
            m_oWorker.WorkerSupportsCancellation = true;

            buttonIndicator.Height = HomeBtn.Height;
            changeButtonBorder(HomeBtn);
            this.LoadingPanel.Visible = true;
            if (!m_oWorker.IsBusy)
            { m_oWorker.RunWorkerAsync("homeForm"); }

        }
        void m_oWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //If it was cancelled midway
            if (e.Cancelled)
            {
                lblStatus.Text = "Task Cancelled.";
            }
            else if (e.Error != null)
            {
                lblStatus.Text = "Error while performing background operation.";
            }
            else
            {
                this.Invoke(
                    (Action)(() =>
                    {
                        containerForm.Show();
                    }));
                LoadingPanel.Visible = false;
            }
        }
        void m_oWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Here you play with the main UI thread
            progressBar1.Value = e.ProgressPercentage;
            lblStatus.Text = "Loading from......" + progressBar1.Value.ToString() + "%";
        }
        void m_oWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //NOTE : Never play with the UI thread here...
            string formName = (string)e.Argument;
            //time consuming operation
            m_oWorker.ReportProgress(10);
            if (formName.Equals("expenseForm"))
            {

                containerForm = new ExpensesForm();
                doProgress();

            }
            else if (formName.Equals("homeForm"))
            {
                containerForm = new Home();
                doProgress();

            }
            else if (formName.Equals("stockForm"))
            {
                containerForm = new Stock();
                doProgress();
            }
            else if (formName.Equals("categoriesForm"))
            {
                containerForm = new InsertRec(this);
                doProgress();
            }
            else if (formName.Equals("supplierForm"))
            {
                containerForm = new SupplierForm();
                doProgress();
            }
            else if (formName.Equals("productsForm"))
            {
                containerForm = new ProductFormDetail();
                doProgress();
            }
            else if (formName.Equals("purchaseForm"))
            {
                containerForm = new PurchaseForm();
                doProgress();
            }
            


            m_oWorker.ReportProgress(100);
            Thread.Sleep(300);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            LoadingPanel.Visible = true;
            buttonIndicator.Height = HomeBtn.Height;
            buttonIndicator.Top = HomeBtn.Top;
            changeButtonBorder(HomeBtn);
            Container.Controls.Clear();
            if (!m_oWorker.IsBusy)
            {
                m_oWorker.RunWorkerAsync("homeForm");
            }

        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            LoadingPanel.Visible = true;
            buttonIndicator.Height = StockBtn.Height;
            buttonIndicator.Top = StockBtn.Top;
            changeButtonBorder(StockBtn);
            Container.Controls.Clear();
            if (!m_oWorker.IsBusy)
            { m_oWorker.RunWorkerAsync("stockForm"); }
        }

        private void ExpensesBtn_Click(object sender, EventArgs e)
        {

            LoadingPanel.Visible = true;
            buttonIndicator.Height = ExpensesBtn.Height;
            buttonIndicator.Top = ExpensesBtn.Top;
            changeButtonBorder(ExpensesBtn);
            Container.Controls.Clear();
            string formName = "expenseForm";
            if (!m_oWorker.IsBusy)
            { m_oWorker.RunWorkerAsync(formName); }
        }




        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CategoriesBtn_Click(object sender, EventArgs e)
        {
            LoadingPanel.Visible = true;
            buttonIndicator.Height = CategoriesBtn.Height;
            buttonIndicator.Top = CategoriesBtn.Top;
            changeButtonBorder(CategoriesBtn);
            Container.Controls.Clear();
            if (!m_oWorker.IsBusy)
            {
                m_oWorker.RunWorkerAsync("categoriesForm");
            }

        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            LoadingPanel.Visible = true;
            buttonIndicator.Height = SupplierBtn.Height;
            buttonIndicator.Top = SupplierBtn.Top;
            changeButtonBorder(SupplierBtn);
            Container.Controls.Clear();
            if (!m_oWorker.IsBusy)
            { m_oWorker.RunWorkerAsync("supplierForm"); }
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            LoadingPanel.Visible = true;
            buttonIndicator.Height = ProductsBtn.Height;
            buttonIndicator.Top = ProductsBtn.Top;
            changeButtonBorder(ProductsBtn);
            Container.Controls.Clear();
            if (!m_oWorker.IsBusy)
            { m_oWorker.RunWorkerAsync("productsForm"); }
        }

        private void PurchaseBtn_Click(object sender, EventArgs e)
        {
            LoadingPanel.Visible = true;
            buttonIndicator.Height = PurchaseBtn.Height;
            buttonIndicator.Top = PurchaseBtn.Top;
            changeButtonBorder(PurchaseBtn);
            Container.Controls.Clear();
            if (!m_oWorker.IsBusy)
            { m_oWorker.RunWorkerAsync("purchaseForm"); }
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
    }

}

