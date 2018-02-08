using SMS.BL;
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
    public partial class UpdateSupplier : Form
    {
        long SupplierID = -1;
        public UpdateSupplier(long ID )
        {
            InitializeComponent();
            SupplierID = ID;
            FillCityComboBox();
            filllForm(ID);
            
        }
        protected void filllForm(long id)
        {
            try
            {
                Supplier supplier = new Supplier();               
                supplier = SupplierBLL.GetSupplierByID(id);
                if (supplier != null)
                {

                    this.NametextBox.Text = supplier.Name;
                    this.CompanyNametextBox.Text = supplier.CompanyName;
                    this.CitycomboBox.SelectedValue = supplier.CityID;               
                    this.ContacttextBox.Text = supplier.ContactNo;              
                }
                else
                    MessageBox.Show("No Supplier Found For Update!...");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception Occurs!..." + ex.Message);
            }
        }
        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {              
                SupplierModel model = new SupplierModel();
                if (this.NametextBox.Text != null || this.NametextBox.Text != "")
                {
                    model.ID = SupplierID;
                    model.CityID = Convert.ToInt64(this.CitycomboBox.SelectedValue);
                    model.CompanyName = this.CompanyNametextBox.Text;
                    model.ContactNo = this.ContacttextBox.Text;
                    model.Name = this.NametextBox.Text;
                    model.dtDate = this.SupplierDTPicker.Value;
                    model.IsActive = true;
                    model.StatusID = Convert.ToInt64(SMS.BL.Enum.Status.Active);
                    model.UserID = null;

                    if (SupplierBLL.UpdateSupplier(model))
                    {
                        MessageBox.Show("Data Updated Successfully !...");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data not Updated!...");
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
        private void CitycomboBox_DropDown(object sender, EventArgs e)
        {
            FillCityComboBox();
        }
        public void FillCityComboBox()
        {
            this.CitycomboBox.DataSource = SupplierBLL.GetCitiesForCombobox();
            this.CitycomboBox.DisplayMember = "Name";
            this.CitycomboBox.ValueMember = "ID";
        }
    }
}
