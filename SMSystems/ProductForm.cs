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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        
        private void Sizecombobox_DropDown(object sender, EventArgs e)
        {
            this.Sizecombobox.DataSource = ProductBLL.GetSizeDataForCombobox();
            this.Sizecombobox.DisplayMember = "Name";
            this.Sizecombobox.ValueMember = "ID";
        }

        private void CompanycomboBox_DropDown(object sender, EventArgs e)
        {
            this.CompanycomboBox.DataSource = ProductBLL.GetCompanyDataForCombobox();
            this.CompanycomboBox.DisplayMember = "Name";
            this.CompanycomboBox.ValueMember = "ID";
        }

        private void ColorcomboBox_DropDown(object sender, EventArgs e)
        {
            this.ColorcomboBox.DataSource = ProductBLL.GetColorDataForCombobox();
            this.ColorcomboBox.DisplayMember = "Name";
            this.ColorcomboBox.ValueMember = "ID";
        }

        private void CategoryForcomboBox_DropDown(object sender, EventArgs e)
        {
            this.CategoryForcomboBox.DataSource = ProductBLL.GetCategoryForDataForCombobox();
            this.CategoryForcomboBox.DisplayMember = "Name";
            this.CategoryForcomboBox.ValueMember = "ID";
        }

        private void ShoeTypecomboBox_DropDown(object sender, EventArgs e)
        {
            this.ShoeTypecomboBox.DataSource = ProductBLL.GetShoeTypesDataForCombobox();
            this.ShoeTypecomboBox.DisplayMember = "Name";
            this.ShoeTypecomboBox.ValueMember = "ID";
        }
        public void FillComboBoxes()
        {
            this.Sizecombobox.DataSource = ProductBLL.GetSizeDataForCombobox();
            this.Sizecombobox.DisplayMember = "Name";
            this.Sizecombobox.ValueMember = "ID";

            this.ColorcomboBox.DataSource = ProductBLL.GetColorDataForCombobox();
            this.ColorcomboBox.DisplayMember = "Name";
            this.ColorcomboBox.ValueMember = "ID";

            this.CategoryForcomboBox.DataSource = ProductBLL.GetCategoryForDataForCombobox();
            this.CategoryForcomboBox.DisplayMember = "Name";
            this.CategoryForcomboBox.ValueMember = "ID";

            this.CompanycomboBox.DataSource = ProductBLL.GetCompanyDataForCombobox();
            this.CompanycomboBox.DisplayMember = "Name";
            this.CompanycomboBox.ValueMember = "ID";

            this.ShoeTypecomboBox.DataSource = ProductBLL.GetShoeTypesDataForCombobox();
            this.ShoeTypecomboBox.DisplayMember = "Name";
            this.ShoeTypecomboBox.ValueMember = "ID";

        }

     
        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ArticalNotxt.Text != null || this.ArticalNotxt.Text != "")
                {
                    long ID = InsertData();
                    if (ID != -1)
                    {
                        MessageBox.Show("Product Added Successfully !..." + ID);
                        ClearForm();
                    }
                }
                else
                {
                    MessageBox.Show("Artical No Field Cannot be null or empty!...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurs" + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAndClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ArticalNotxt.Text != null || this.ArticalNotxt.Text != "")
                {
                    long ID = InsertData();
                    if (ID != -1)
                    {
                        MessageBox.Show("Product Added Successfully !..." + ID);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Artical No Field Cannot be null or empty!...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurs" + ex.Message);
            }

        }
        private void ClearForm()
        {
            this.ArticalNotxt.Text = "";
            this.salePricetxt.Text = "";
            this.MinDiscounttxt.Text = "";
            this.maxDiscounttxt.Text = "";
        }
        private long InsertData()
        {
            ProductModel model = new ProductModel();
            model.ArticalNo = this.ArticalNotxt.Text;
            model.SizeID = Convert.ToInt64(this.Sizecombobox.SelectedValue);
            model.CategoryForID = Convert.ToInt64(this.CategoryForcomboBox.SelectedValue);
            model.ColorID = Convert.ToInt64(this.ColorcomboBox.SelectedValue);
            model.CompanyID = Convert.ToInt64(this.CompanycomboBox.SelectedValue);
            model.CategoryID = Convert.ToInt64(this.ShoeTypecomboBox.SelectedValue);
            model.dtDate = this.ProductdTPicker.Value;
            model.MinDiscount = Convert.ToDecimal(this.MinDiscounttxt.Text);
            model.MaxDiscount = Convert.ToDecimal(this.maxDiscounttxt.Text);
            model.SalePrice = Convert.ToDecimal(this.salePricetxt.Text);
            model.ShowForShop = this.showforShopcheckBox.Checked;

            return ProductBLL.AddProduct(model);
        }

        private void salePricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateDecimal(sender, e);
        }

        private void MinDiscounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateDecimal(sender, e);
        }

        private void maxDiscounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateDecimal(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
