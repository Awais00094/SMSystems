using SMSBL.BLL;
using SMSBL.Entities;
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
    public partial class SizeForm : Form
    {
        public long ID = -1;
        public List<CommonList> SearchList = new List<CommonList>();
        int pageNo = 1;
        int pages = -1;
        int pageSize = 2;
        public SizeForm()
        {
            InitializeComponent();
            getPages();
            FillGrid(pageNo-1);
            //FillGrid();

            ChangingFeildsVisibility(false);
        }

        private void getPages()
        {
            pages = CommonBLL.getSizesListCount();
            pages = pages / pageSize;
            this.PageIndicator.Text = pageNo+"/" + pages;
        }

        protected override void OnLoad(EventArgs e)
        {
            
        }
        protected void ChangingFeildsVisibility(bool state)
        {
            this.updateDescriptiontxt.Enabled = state;
            this.updateNametxt.Enabled = state;
            this.updatebtn.Enabled = state;
            this.Deletebtn.Enabled = state;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (SizeGridView.SelectedRows.Count != 0)
            {
                ChangingFeildsVisibility(true);
                ID = Convert.ToInt64(SizeGridView.SelectedRows[0].Cells[0].Value);
                this.updateNametxt.Text = SizeGridView.SelectedRows[0].Cells[1].Value.ToString();
                this.updateDescriptiontxt.Text = SizeGridView.SelectedRows[0].Cells[2].Value.ToString();

            }
            //MessageBox.Show(SizeGridView.SelectedRows[0].Cells[2].Value.ToString());
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                CommonModel model = new CommonModel();
                model.Name = this.NameAddtxt.Text;
                model.Description = this.DescriptionAddtxt.Text;
                model.TableNo = 0;  //Sizes
                if (model.Name != null || model.Name != "")
                {
                    string ID =CommonBLL.CommonDataInsert(model);
                    MessageBox.Show("Size Added Successfully !..."+ID);
                    this.NameAddtxt.Text = "";
                    this.DescriptionAddtxt.Text = "";
                    FillGrid();
                }
                else
                {
                    MessageBox.Show("Name Feild Cannot be null or empty!...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurs"+ex.Message);
            }
           
        }
        public void FillGrid()
        {
            var dt = CommonBLL.GetSizeList();
            SearchList = dt;
            this.SizeGridView.DataSource = dt;
            this.SizeGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.PageIndicator.Text = "1/" + pages;

        }
        public void FillGrid(int pageno)
        {

            var dt = CommonBLL.GetSizeList(pageno,pageSize);
            SearchList = dt;
            this.SizeGridView.DataSource = dt;
            this.SizeGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.PageIndicator.Text = pageNo + "/" + pages;


        }


        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                CommonModel model = new CommonModel();
                model.ID = ID;
                model.Name = this.updateNametxt.Text;
                model.Description = this.updateDescriptiontxt.Text;
                model.TableNo = 0;  //Sizes
                if (model.Name != null || model.Name != "")
                {
                    CommonBLL.CommonDataUpdate(model);
                    MessageBox.Show("Size Updated Successfully !..." + ID);
                    this.updateNametxt.Text = "";
                    this.updateDescriptiontxt.Text = "";
                    ChangingFeildsVisibility(false);
                    FillGrid();
                }
                else
                {
                    MessageBox.Show("Name Feild Cannot be null or empty!...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurs" + ex.Message);
            }
        }

        private void colorbtn_Click(object sender, EventArgs e)
        {
            string text = this.Searchtxt.Text;
            var SearchData = SearchList.Where(x => x.Name.StartsWith(text));
            this.SizeGridView.DataSource = SearchData;
        }

        private void SizeForm_Load(object sender, EventArgs e)
        {
            SizeGridView.ClearSelection();
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {

            FillGrid(pages-1);
            this.PageIndicator.Text = pages + "/" + pages;

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            pageNo++;
            if (pageNo <= pages)
            {
                FillGrid(pageNo-1);
            }
            else
            {
                pageNo--;
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {

            pageNo--;
            if (pageNo >= 1)
            {
                FillGrid(pageNo-1);
            }
            else
            {
                pageNo++;
            }
        }

        private void fist_Click(object sender, EventArgs e)
        {
            
            FillGrid(0);
            this.PageIndicator.Text = 1 + "/" + pages;


        }

    }
}
