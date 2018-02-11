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
    public partial class Purchasing : Form
    {
        public Purchasing()
        {
            InitializeComponent();
        }

        private void AddPurchasebtn_Click(object sender, EventArgs e)
        {
            AddPurchase AddPurchaseForm = new AddPurchase();
            AddPurchaseForm.ShowDialog();
        }
    }
}
