using SMS.BL;
using SMS.BL.BLL;
using SMS.BL.Entities;
using SMS.BL.Enum;
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
    public partial class PurchaseForm : Form
    {
        List<PurchaseProductDetailItem> productList = new List<PurchaseProductDetailItem>();
        Product product = new Product();
        long SelectedProductItemID = -1;
        int TotalQuantity = 0;
        decimal TotalPurchaseValue = 0;

        public PurchaseForm()
        {
            InitializeComponent();
            FillSupplierComboBox();
            this.ArticalNotxt.Text = "100-1";
            GetArticalNoDetails("100-1");
            this.AddPurchasebtn.Enabled = false;
        }
        void SetTextBoxData(Product product)
        {
            this.sizetxt.Text = product.Size.Name;
            this.colortxt.Text = product.Color.Name;
            this.companytxt.Text = product.Company.Name;
            this.salepricetxt.Text = product.SalePrice.ToString();
            this.shoetypetxt.Text = product.ProductCategory.Name;
            this.CategoryFortxt.Text = product.CategoriesFor.Name;
        }
        void EmptyTextBoxData()
        {
            this.sizetxt.Text = "";
            this.colortxt.Text = "";
            this.companytxt.Text = "";
            this.salepricetxt.Text = "";
            this.shoetypetxt.Text = "";
            this.CategoryFortxt.Text = "";
        }
        void EmptyFeilds()
        {
            this.Quantitytxt.Text = "";
            this.WSalePricetxt.Text = "";

        }
        public void FillGrid()
        {
            if (productList.Count > 0)
            {
                calculateSum();
                this.ProdGridView.DataSource = null;

                this.ProdGridView.DataSource = productList;

                this.ProdGridView.Columns["ID"].Visible = false;
                this.ProdGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
            }
            else
            {
                calculateSum();
                this.ProdGridView.DataSource = null;

            }
        }
        private void GetArticalNoDetails(string ArticalNo)
        {
            if (!ArticalNo.Equals(""))
            {
                product = ProductBLL.GetProductByArticalNo(ArticalNo);
                if (product == null)
                {
                    MessageBox.Show("Artical No not Found Please Add Product First... ");
                }
                else
                {
                    SetTextBoxData(product);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Artical No ! It Cant be Null... ");
            }
        }
        private void calculateSum()
        {
            if (productList.Count > 0)
            {
                TotalPurchaseValue = productList.Sum(x => x.TotalValue);
                TotalQuantity = productList.Sum(x => x.Quantity);

                this.TotalQuantitytxt.Text = TotalQuantity.ToString();
                this.TPurchaseValuetxt.Text = TotalPurchaseValue.ToString();
            }
            else
            {
                this.TotalQuantitytxt.Text = "0";
                this.TPurchaseValuetxt.Text = "0.0";

            }
        }
        private void calculateNetAmount(decimal TPurchasePrice, decimal TDiscountValue)
        {
            decimal NetTotalAmount = TPurchasePrice - TDiscountValue;
            this.netTotalValuetxt.Text = NetTotalAmount.ToString();
        }
        public void FillSupplierComboBox()
        {
            this.supplierCombobox.DataSource = PurchaseBLL.GetSupplierCombobox();
            this.supplierCombobox.DisplayMember = "Name";
            this.supplierCombobox.ValueMember = "ID";
        }
        private void ProdGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ProdGridView.SelectedRows.Count != 0)
            {

                SelectedProductItemID = Convert.ToInt64(ProdGridView.SelectedRows[0].Cells[0].Value);
                //string a = ProdGridView.SelectedRows[0].Cells[1].Value.ToString();
                //this.updateDescriptiontxt.Text = ProdGridView.SelectedRows[0].Cells[2].Value.ToString();

            }
        }
        private void AddPurchasebtn_Click(object sender, EventArgs e)
        {
            long? PurchaseID = -1;
            long? SupplierID = Convert.ToInt64(this.supplierCombobox.SelectedValue);
            DateTime PurchaseDate = this.dtpicker.Value;
            int TotalPairsQuantity = Convert.ToInt32(this.TotalQuantitytxt.Text);
            decimal TotalPurchaseValue = Convert.ToDecimal(this.TPurchaseValuetxt.Text);
            decimal TotalDiscountValue = Convert.ToDecimal(this.TDiscountValuetxt.Text);
            decimal TotalPaidValue = Convert.ToDecimal(this.totalPaidValuetxt.Text);
            string PurchaseInvoiceNo = this.PurchaseInvoiceNotxt.Text;
            DataTable PurchaseDetailDT = new DataTable();
            PurchaseDetailDT = CreateDataColumns(PurchaseDetailDT);
            for (int i = 0; i < productList.Count(); i++)
            {
                PurchaseDetailDT.Rows.Add(PurchaseDetailDT.NewRow());
                PurchaseDetailDT.Rows[i]["ProductID"] = productList[i].ID;
                PurchaseDetailDT.Rows[i]["TotalPairs"] = productList[i].Quantity;
                PurchaseDetailDT.Rows[i]["WSalePairPrice"] = productList[i].WSalePrice;
                PurchaseDetailDT.Rows[i]["TotalPurchasePrice"] = productList[i].TotalValue;
            }

            try
            {
                SMSError Er = PurchaseBLL.CreatePurchase(PurchaseID: ref PurchaseID,
                                                         SupplierID: SupplierID,
                                                         PurchaseDate: PurchaseDate,
                                                         TotalPairsQuantity: TotalPairsQuantity,
                                                         TotalPurchaseValue: TotalPurchaseValue,
                                                         TotalDiscountValue: TotalDiscountValue,
                                                         TotalPaidValue: TotalPaidValue,
                                                         PurchaseInvoiceNo: PurchaseInvoiceNo,
                                                         utblPurchaseDetail: PurchaseDetailDT,
                                                         UserID: null
                                                            );
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void TDiscountValuetxt_Leave(object sender, EventArgs e)
        {
            if (!this.TDiscountValuetxt.Text.Equals(""))
            {
                calculateNetAmount(TotalPurchaseValue, Convert.ToDecimal(this.TDiscountValuetxt.Text));
            }
        }
        private void supplierCombobox_DropDown(object sender, EventArgs e)
        {
            FillSupplierComboBox();
        }
        protected DataTable CreateDataColumns(DataTable dt)
        {
            dt.Columns.Add("ProductID");
            dt.Columns.Add("TotalPairs");
            dt.Columns.Add("WSalePairPrice");
            dt.Columns.Add("TotalPurchasePrice");
            return dt;
        }

        private void totalPaidValuetxt_Leave(object sender, EventArgs e)
        {
            this.AddPurchasebtn.Enabled = true;
        }

        private void SearchArticalBtn_Click(object sender, EventArgs e)
        {
            string ArticalNo = this.ArticalNotxt.Text;
            GetArticalNoDetails(ArticalNo);
        }

        private void ArticalNotxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string ArticalNo = this.ArticalNotxt.Text;
                GetArticalNoDetails(ArticalNo);
            }
        }


        private void AddProduct_Click_1(object sender, EventArgs e)
        {
            PurchaseProductDetailItem item = new PurchaseProductDetailItem();
            if (product.ID != 0)
            {
                item.ArticalNo = product.ArticalNo;
                item.ID = product.ID;
                item.Quantity = Convert.ToInt32(this.Quantitytxt.Text);
                item.RetailPrice = product.SalePrice.GetValueOrDefault();
                item.WSalePrice = Convert.ToDecimal(this.WSalePricetxt.Text);
                item.TotalValue = Convert.ToDecimal(this.WSalePricetxt.Text) * Convert.ToInt32(this.Quantitytxt.Text);
                productList.Add(item);


                //MessageBox.Show("Product is Added to List... ");
                FillGrid();
                EmptyFeilds();

            }
            else { MessageBox.Show("Please Select Valid Artical No !... "); }

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (SelectedProductItemID == -1)
            {
                MessageBox.Show("No Product is Selected From the Grid!... ");
            }
            productList.Remove(productList.Where(x => x.ID == SelectedProductItemID).FirstOrDefault());
            SelectedProductItemID = -1;
            FillGrid();

        }

        private void TDiscountValuetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateDecimal(sender,e);
        }

        private void Quantitytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateInt(sender, e);
        }

        private void WSalePricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateDecimal(sender, e);

        }
        
    }
}
