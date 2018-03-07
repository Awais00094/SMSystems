using SMSBL.BLL;
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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            fillGrid();
        }
        private void StockForm_Load(object sender, EventArgs e)
        {
            StockGridView.ClearSelection();
        }
        void fillGrid()
        {
            var list = ReportBLL.GetProductStockList();
            this.StockGridView.DataSource = list;
            this.StockGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void colorbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
