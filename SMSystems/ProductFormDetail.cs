using SMSBL.BLL;
using System;
using System.Windows.Forms;

namespace SMSystems
{
    public partial class ProductFormDetail : Form
    {
        long ID = -1;
        public ProductFormDetail()
        {
            InitializeComponent();
            ChangingFeildsVisibility(false);
            FillGrid();
        }
        private void ProductFormDetail_Load(object sender, EventArgs e)
        {
            ProductGridView.ClearSelection();
        }
        public void FillGrid()
        {
            var dt = ProductBLL.GetProductList();
            this.ProductGridView.DataSource = dt;
            this.ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        protected void ChangingFeildsVisibility(bool state)
        {
            this.updatebtn.Enabled = state;
            this.deletebtn.Enabled = state;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.ShowDialog();
            FillGrid();
        }

        private void ProductGridView_SelectionChanged(object sender, EventArgs e)
        {
          
            if (ProductGridView.SelectedRows.Count != 0)
            {
                ChangingFeildsVisibility(true);
                ID = Convert.ToInt64(ProductGridView.SelectedRows[0].Cells[0].Value);
                ChangingFeildsVisibility(true);
            }
            
            //MessageBox.Show(SizeGridView.SelectedRows[0].Cells[2].Value.ToString());
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            UpdateProductForm form = new UpdateProductForm(ID);
            form.ShowDialog();
            FillGrid();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
