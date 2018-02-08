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
    public partial class CompanyForm : Form
    {
        public long ID = -1;
        public CompanyForm()
        {
            InitializeComponent();
            FillGrid();
            ChangingFeildsVisibility(false);
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
            if (GridView.SelectedRows.Count != 0)
            {
                ChangingFeildsVisibility(true);
                ID = Convert.ToInt64(GridView.SelectedRows[0].Cells[0].Value);
                this.updateNametxt.Text = GridView.SelectedRows[0].Cells[1].Value.ToString();
                this.updateDescriptiontxt.Text = GridView.SelectedRows[0].Cells[2].Value.ToString();

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
                model.TableNo = 4;//Companies
                if (model.Name != null || model.Name != "")
                {
                    string ID =CommonBLL.CommonDataInsert(model);
                    MessageBox.Show("Company Added Successfully !..."+ID);
                    this.NameAddtxt.Text = "";
                    this.DescriptionAddtxt.Text = "";
                    FillGrid();
                }
                else
                {
                    MessageBox.Show("Name Field Cannot be null or empty!...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurs"+ex.Message);
            }
           
        }
        public void FillGrid()
        {
            var dt = CommonBLL.GetCompanyList();
            this.GridView.DataSource = dt;
            this.GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                CommonModel model = new CommonModel();
                model.ID = ID;
                model.Name = this.updateNametxt.Text;
                model.Description = this.updateDescriptiontxt.Text;
                model.TableNo = 4;//Companies
                if (model.Name != null || model.Name != "")
                {
                    CommonBLL.CommonDataUpdate(model);
                    MessageBox.Show("Company Updated Successfully !..." + ID);
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
    }
}
