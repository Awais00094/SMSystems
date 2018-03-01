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
    public partial class ShoppingForm : Form
    {
        List<ShoppingProductDetailItem> productList = new List<ShoppingProductDetailItem>();
        Product product = new Product();
        long SelectedProductItemID = -1;
        int TotalQuantity = 0;
        decimal TotalShoppingValue = 0;
        decimal NetValue = 0;
        decimal TotalDiscountValue = 0;

        public ShoppingForm()
        {
            InitializeComponent();
            SetDataForShoppingFeilds();
            this.ArticalNotxt.Text = "100-1";
            GetArticalNoDetails("100-1");
            //this.AddShoppingbtn.Enabled = false;
        }
        public void DiscountComboBox()
        {

            //this.discountcombo.Ite
        }
        public void SetDataForShoppingFeilds()
        {
            this.CustomerNametxt.Text = "Walking Customer";
            this.CustomerNumbertxt.Text = "xxxx xxxxxxx";
            this.Quantitytxt.Text = "1";
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
        void SetTextBoxData(Product product)
        {
            this.sizetxt.Text = product.Size.Name;
            this.colortxt.Text = product.Color.Name;
            this.companytxt.Text = product.Company.Name;
            this.salepricetxt.Text = product.SalePrice.ToString();
            this.shoetypetxt.Text = product.ProductCategory.Name;
            this.CategoryFortxt.Text = product.CategoriesFor.Name;
            int ProductStock = ReportBLL.GetProductStockByProductID(product.ID);
            this.TotalStock.Text = ProductStock + " Pairs";
        }

        private void ArticalNotxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ArticalNo = this.ArticalNotxt.Text;
                GetArticalNoDetails(ArticalNo);
            }
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
        private void ProdGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ProdGridView.SelectedRows.Count != 0)
            {

                SelectedProductItemID = Convert.ToInt64(ProdGridView.SelectedRows[0].Cells[0].Value);
            }
        }

        private void calculateSum()
        {
            if (productList.Count > 0)
            {
                TotalShoppingValue = productList.Sum(x => x.RetailPrice);
                TotalQuantity = productList.Sum(x => x.Quantity);
                TotalDiscountValue = productList.Sum(x => x.DiscountPrice);
                NetValue = productList.Sum(x => x.NetPrice);
                this.TShoppingValuetxt.Text = TotalShoppingValue.ToString();
                this.TotalQuantitytxt.Text = TotalQuantity.ToString();
                this.netTotalValuetxt.Text = NetValue.ToString();
                this.TDiscountValuetxt.Text = TotalDiscountValue.ToString();

            }
            else
            {
                this.TotalQuantitytxt.Text = "0";
                this.TShoppingValuetxt.Text = "0.0";

            }
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            ShoppingProductDetailItem item = new ShoppingProductDetailItem();
            if (this.Quantitytxt.Text == "" || this.Quantitytxt.Text == null)
            {
                MessageBox.Show("Fill the Quantity!... ");
            }
            else
            {
                if (product.ID != 0)
                {
                    item = productList.Where(x => x.ID == product.ID).FirstOrDefault();
                    if (item != null)
                    {
                        item.Quantity += Convert.ToInt32(this.Quantitytxt.Text);
                        item.TotalPrice += (item.RetailPrice * item.Quantity);
                        item.NetPrice += ((item.RetailPrice * item.Quantity) - (item.DiscountPrice * item.Quantity));     
                    }
                    else
                    {
                        item = new ShoppingProductDetailItem();
                        item.ArticalNo = product.ArticalNo;
                        item.ID = product.ID;
                        item.Quantity = Convert.ToInt32(this.Quantitytxt.Text);
                        item.RetailPrice = product.SalePrice.GetValueOrDefault();
                        int DiscountType = 0;
                        if (DiscountType == 0)
                        {
                            item.DiscountPrice = product.MinDiscount.Value;
                        }
                        else if (DiscountType == 1)
                        {
                            item.DiscountPrice = product.MaxDiscount.Value;
                        }

                        item.TotalPrice = item.RetailPrice * item.Quantity;
                        item.NetPrice = (item.RetailPrice * item.Quantity) - (item.DiscountPrice * item.Quantity);
                        productList.Add(item);
                    }
                    //MessageBox.Show("Product is Added to List... ");
                    FillGrid();
                    EmptyFeilds();

                }
                else
                {
                    MessageBox.Show("Please Select Valid Artical No !... ");
                }
            }
        }
        void EmptyFeilds()
        {
            this.Quantitytxt.Text = "1";
            //this.WSalePricetxt.Text = "";

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
        private void calculateNetAmount(decimal TShoppingPrice, decimal TDiscountValue)
        {
            decimal NetTotalAmount = TShoppingPrice - TDiscountValue;
            this.netTotalValuetxt.Text = NetTotalAmount.ToString();
        }

        private void AddShoppingbtn_Click(object sender, EventArgs e)
        {
            long? ShoppingID = -1;
            DateTime ShoppingDate = this.dtpicker.Value;
            int TotalPairsQuantity = Convert.ToInt32(this.TotalQuantitytxt.Text);
            decimal TotalDiscountValue = Convert.ToDecimal(this.TDiscountValuetxt.Text);
            DataTable ShoppingDetailDT = new DataTable();
            string CustomerName = this.CustomerNametxt.Text;
            string CustomerNumber = this.CustomerNumbertxt.Text;
            ShoppingDetailDT = CreateDataColumns(ShoppingDetailDT);
            for (int i = 0; i < productList.Count(); i++)
            {
                ShoppingDetailDT.Rows.Add(ShoppingDetailDT.NewRow());
                ShoppingDetailDT.Rows[i]["ProductID"] = productList[i].ID;
                ShoppingDetailDT.Rows[i]["TotalPairs"] = productList[i].Quantity;
                ShoppingDetailDT.Rows[i]["TotalDiscountPrice"] = productList[i].DiscountPrice* productList[i].Quantity;
                ShoppingDetailDT.Rows[i]["TotalSalePrice"] = productList[i].Quantity* productList[i].RetailPrice;
            }

            try
            {
                SMSError Er = ShoppingBLL.CreateShopping(ShoppingID: ref ShoppingID,
                                                         ShoppingDate: ShoppingDate,
                                                         TotalPairsQuantity: TotalPairsQuantity,
                                                         TotalDiscountPrice: TotalDiscountValue,
                                                         TotalSalePrice: TotalShoppingValue,
                                                         CustomerName: CustomerName,
                                                         CustomerNumber:CustomerNumber,
                                                         utblShoppingDetail: ShoppingDetailDT,
                                                         ReturnedShoppingID:null,
                                                         UserID: null
                                                            );
                if (Er == SMSError.SUCCESS)
                {

                }
                else if (Er != SMSError.SUCCESS)
                {
                    MessageBox.Show("Shopping Not Successfull" + Er);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Shopping Not Successfull!.." + ex.Message);
            }
        }
        protected DataTable CreateDataColumns(DataTable dt)
        {
            dt.Columns.Add("ProductID");
            dt.Columns.Add("TotalPairs");
            dt.Columns.Add("TotalDiscountPrice");
            dt.Columns.Add("TotalSalePrice");
            return dt;
        }

        private void SearchArticalBtn_Click(object sender, EventArgs e)
        {
            string ArticalNo = this.ArticalNotxt.Text;
            GetArticalNoDetails(ArticalNo);
        }
    }
}
