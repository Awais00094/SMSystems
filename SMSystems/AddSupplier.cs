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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
            FillCityComboBox();
        }

        private void ClearForm()
        {
            this.CompanyNametextBox.Text = "";
            this.ContacttextBox.Text = "";
            this.NametextBox.Text = "";
           
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                long ID = -1;
                SupplierModel model = new SupplierModel();
                if (this.NametextBox.Text != null || this.NametextBox.Text != "")
                {
                    model.CityID = Convert.ToInt64(this.CitycomboBox.SelectedValue);
                    model.CompanyName = this.CompanyNametextBox.Text;
                    model.ContactNo = this.ContacttextBox.Text;
                    model.Name = this.NametextBox.Text;
                    model.dtDate = this.SupplierDTPicker.Value;
                    model.IsActive = true;
                    model.StatusID = Convert.ToInt64(SMSBL.Enum.Status.Active);
                    model.UserID = null;
                    ID = SupplierBLL.AddSupplier(model);
                    if (ID != -1)
                    {
                        MessageBox.Show("Data Added Successfully !..." + ID);
                        //FillGrid();
                        ClearForm();
                    }
                }
                else
                {
                    MessageBox.Show("Name Field Cannot be null or empty!...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurs" + ex.Message);
            }
        }
        public void FillCityComboBox()
        {
            this.CitycomboBox.DataSource = SupplierBLL.GetCitiesForCombobox();
            this.CitycomboBox.DisplayMember = "Name";
            this.CitycomboBox.ValueMember = "ID";
        }

        private void CitycomboBox_DropDown(object sender, EventArgs e)
        {
            FillCityComboBox();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void AddClosebtn_Click(object sender, EventArgs e)
        {
            try
            {
                long ID = -1;
                SupplierModel model = new SupplierModel();
                if (this.NametextBox.Text != null || this.NametextBox.Text != "")
                {
                    model.CityID = Convert.ToInt64(this.CitycomboBox.SelectedValue);
                    model.CompanyName = this.CompanyNametextBox.Text;
                    model.ContactNo = this.ContacttextBox.Text;
                    model.Name = this.NametextBox.Text;
                    model.dtDate = this.SupplierDTPicker.Value;
                    model.IsActive = true;
                    model.StatusID = Convert.ToInt64(SMSBL.Enum.Status.Active);
                    model.UserID = null;
                    ID = SupplierBLL.AddSupplier(model);
                    if (ID != -1)
                    {
                        MessageBox.Show("Data Added Successfully !..." + ID);
                        //FillGrid();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Name Field Cannot be null or empty!...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurs" + ex.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
