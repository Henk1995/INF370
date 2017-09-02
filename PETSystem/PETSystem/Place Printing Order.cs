using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETSystem
{
    public partial class Place_Printing_Order : Form
    {
        public Place_Printing_Order()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();
        int LoadPrintingfSupplierID = Search_Printing_Supplier.ToUpdate;

        int RefNum = 0;
        ErrorHandle EH = new ErrorHandle();
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        double OrderT = 0;
        string OrderDesc = "";
        string Date = "";
        int SuppID = 0;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Printing_Supplier sps = new Search_Printing_Supplier();
            sps.Show();
        }

        private void btnARN_Click(object sender, EventArgs e)
        {
            valid1 = EH.CheckEmpty(txtReferenceNum.Text);
            valid1 = EH.CheckInt(txtReferenceNum.Text);
            if (valid1)
            {
                RefNum = Convert.ToInt32(txtReferenceNum.Text);
                txtDate.Visible = true;
                txtDescription.Visible = true;
                lblDate.Visible = true;
                lblDescription.Visible = true;
                btnAddI.Visible = true;
                btnPO.Visible = true;
                btnARN.Visible = false;
                lblRef.Visible = false;
                txtReferenceNum.Visible = false;
                txtQuantity.Visible = true;
                lblQuantity.Visible = true;

            }
            else
            {

                MessageBox.Show("Information provided is invalid please submit valid information");
            }
        }

        private void Place_Printing_Order_Load(object sender, EventArgs e)
        {
            txtDate.Visible = false;
            txtDescription.Visible = false;
            lblDate.Visible = false;
            lblDescription.Visible = false;
            btnAddI.Visible = false;
            btnPO.Visible = false;
            txtQuantity.Visible = false;
            lblQuantity.Visible = false;
            rtbOrder.Text = rtbOrder.Text + "x\t Quantity\t Order Description \t Date\n";
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            if (valid1 && valid2 && valid3 && valid4)
            {
                MessageBox.Show("Are you sure you want to place this new order", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                //Add order to Database

                PrinterOrder mPrinterOrder = new PrinterOrder
                {
                    PrinterOrderRefNumber = Convert.ToInt32(txtReferenceNum.Text),
                    PrintOrderDate = txtDate.Text,
                    PrintOrderDescription = txtDescription.Text,
                    PrinterID = LoadPrintingfSupplierID,

                };

                db.PrinterOrders.InsertOnSubmit(mPrinterOrder);
                db.SubmitChanges();

                this.Close();
                Search_Printing_Supplier sps = new Search_Printing_Supplier();
                sps.Show();

                this.Close();
            }
        }

        private void btnAddI_Click(object sender, EventArgs e)
        {
            if (valid1 && valid2 && valid3 && valid4)
            {
                if (OrderDesc == "")
                {
                    OrderDesc = txtDescription.Text;
                }
                else
                {
                    OrderDesc = OrderDesc + "," + txtDescription.Text;
                }

                rtbOrder.Text = rtbOrder.Text + "x\t" + txtQuantity.Text + "\t" + txtDescription.Text + "\t" + txtDate.Text + "\n";
            }
        }

        private void txtReferenceNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            valid2 = EH.Checkstring(txtDescription.Text);
            if (!valid2)
            {
                txtDescription.BackColor = Color.Red;
            }
            else
            {
                txtDescription.BackColor = Color.White;
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            valid4 = EH.CheckDate(txtDate.Text);
            if (!valid4)
            {
                txtDate.BackColor = Color.Red;
            }
            else
            {
                txtDate.BackColor = Color.White;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.Checkfloat(txtQuantity.Text);
            if (!valid3)
            {
                txtQuantity.BackColor = Color.Red;
            }
            else
            {
                txtQuantity.BackColor = Color.White;
            }
        }
    }
}
