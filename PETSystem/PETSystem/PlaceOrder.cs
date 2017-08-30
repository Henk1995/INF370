using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PETSystem;
using System.Data.SqlClient;

namespace Place_Order
{
    public partial class PlaceOrder : Form
    {
        SqlDataAdapter DA;
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
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
      

        public PlaceOrder()
        {
            InitializeComponent();
        }
        public PlaceOrder(int supplierID)
        {
            InitializeComponent();
            SuppID = supplierID;
        }

        private void button3_Click(object sender, EventArgs e)
        {




            if (valid1 && valid2 && valid3 && valid4)
            {
                MessageBox.Show("Are you sure you want to place this new order", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                DataTable DT = new DataTable();


                string Query = "INSERT INTO SupplierOrder (SupplierOrderRefNumber,SupplierOrderDate,SupplierOrderDescription,SupplierID) VALUES ('" + RefNum + "','" + this.txtDate.Text + "','" + OrderDesc + "','" + SuppID + "');";
                SqlCommand MyCommand3 = new SqlCommand(Query, connectstring);
                SqlDataReader MyReader3;
                connectstring.Open();
                MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader3.Read())
                {
                }
                connectstring.Close();

                MessageBox.Show("Are you sure you want to place this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            txtDate.Visible = false;
            txtDescription.Visible = false;
            txtUnitprice.Visible = false;
            nudQuantity.Visible = false;
            lblDate.Visible = false;
            lblDescription.Visible = false;
            lblNum.Visible = false;
            lblUnitPrice.Visible = false;
            btnAddI.Visible = false;
            btnPO.Visible = false;
            rtbOrder.Text = rtbOrder.Text + "Quantity\t Order Description \t Date\t total\n";

        }

        private void btnARN_Click(object sender, EventArgs e)
        {
            valid1=EH.CheckEmpty(txtReferenceNum.Text);
            valid1 = EH.CheckInt(txtReferenceNum.Text);
            if (valid1)
            {
                RefNum = Convert.ToInt32( txtReferenceNum.Text);
                txtDate.Visible = true;
                txtDescription.Visible = true;
                txtUnitprice.Visible = true;
                nudQuantity.Visible = true;
                lblDate.Visible = true;
                lblDescription.Visible = true;
                lblNum.Visible = true;
                lblUnitPrice.Visible = true;
                btnAddI.Visible = true;
                btnPO.Visible = true;
                btnARN.Visible = false;
                lblRef.Visible = false;
                txtReferenceNum.Visible = false;

            }
            else
            {

                MessageBox.Show("Information provided is invalid please submit valid information");
            }
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

        private void txtUnitprice_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.Checkfloat(txtUnitprice.Text);
            if (!valid3)
            {
                txtUnitprice.BackColor = Color.Red;
            }
            else
            {
                txtUnitprice.BackColor = Color.White;
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

        private void btnAddI_Click(object sender, EventArgs e)
        {
            if(valid1&&valid2&&valid3&&valid4)
            {
                OrderT = OrderT + (Convert.ToDouble(txtUnitprice.Text) * Convert.ToDouble(nudQuantity.Value));
                double total = Convert.ToDouble(txtUnitprice.Text) * Convert.ToDouble(nudQuantity.Value);
                if (OrderDesc=="")
                {
                    OrderDesc = txtDescription.Text;

                }
                else
                {
                    OrderDesc = OrderDesc + "," + txtDescription.Text;
                }

                rtbOrder.Text = rtbOrder.Text + nudQuantity.Value + "x\t" + txtDescription.Text + "\t" + txtDate.Text + "\t R" + total+"\n";
            }
        }
    }
}
