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
    public partial class AddSupplierPayment : Form
    {
        public AddSupplierPayment()
        {
            InitializeComponent();
            FillSupplierComboBox();
            long SupplierID = Convert.ToInt64(this.SupplierCombobox.SelectedValue);
            getSupplierRemainingAmount(SupplierID);
        }
        void FillSupplierComboBox()
        {
            var dt = PurchaseBLL.GetSupplierComboboxForPayment();
            this.SupplierCombobox.DataSource=dt;
            this.SupplierCombobox.DisplayMember = "Name";
            this.SupplierCombobox.ValueMember = "ID";
        }
        void getSupplierRemainingAmount(long SupplierID)
        {
            decimal TotalRemainingAmount = SupplierBLL.GetSupplierTotalRemainingAmount(SupplierID);
            if (TotalRemainingAmount != -1)
            {
                this.lblTotalRemainingAmount.Text = TotalRemainingAmount.ToString();
            }
            else
            {
                this.lblTotalRemainingAmount.Text = "0.0";
                MessageBox.Show("No Purchase Record Found For this Supplier !...");  
            }
        }
        private void SupplierCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplierCombobox.SelectedIndex != 0)
            {
                long SupplierID = Convert.ToInt64(this.SupplierCombobox.SelectedValue);
                getSupplierRemainingAmount(SupplierID);
            }
        }

        private void SupplierCombobox_DropDown(object sender, EventArgs e)
        {
            FillSupplierComboBox();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(AmountPaytextBox.Text) > Convert.ToDecimal(this.lblTotalRemainingAmount.Text))
                {
                    MessageBox.Show("You cant pay that much Amount to this supplier !...");
                }
                else
                {
                    long ID = -1;
                    SupplierPaymentModel model = new SupplierPaymentModel();
                    model.SupplierID = Convert.ToInt64(this.SupplierCombobox.SelectedValue);
                    model.RemainingAmount = Convert.ToDecimal(this.lblTotalRemainingAmount.Text);
                    model.dtDate = this.SupplierDTPicker.Value;
                    model.AmoutPay = Convert.ToDecimal(AmountPaytextBox.Text);
                    ID = SupplierBLL.AddSupplierPayment(model);
                    if (ID != -1)
                    {
                        MessageBox.Show("Supplier Payment Added Successfully !...");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Supplier Payment Failed !...");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurs:" + ex.Message);
            }
        }

        private void AmountPaytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateDecimal(sender, e);
        }
    }
}
