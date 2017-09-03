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
    public partial class Search_Order : Form
    {
        public Search_Order()
        {
            InitializeComponent();
        }

        int id;
        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        public static int ToUpdate;
        bool SearchISValid;


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            Select_Instructor si = new Select_Instructor();
            si.Show();
        }

        private void Search_Order_Load(object sender, EventArgs e)
        {
            var LoadOrders = from Order in db.TableOrders select Order;
            dgvOrders.DataSource = LoadOrders;
            dgvOrders.Refresh();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }

        private void tnViewOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedCells.Count > 0)
            {
                TableOrder _TO = (TableOrder)dgvOrders.CurrentRow.DataBoundItem;
                int mOrderID = Convert.ToInt32(_TO.OrderID);
                int mOrderREF = Convert.ToInt32(_TO.Order_ReferenceNumber);
                string mOrderDesc = _TO.OrderDescription;
                string mOrderDate = _TO.OrderDate;
                int mInstructorID = Convert.ToInt32(_TO.InstructorID);

                var getInstructorName = (from Instructor in db.Instructors where Instructor.InstructorID == mInstructorID select Instructor.Name).FirstOrDefault();

                string LoadInstructorName = getInstructorName;


                MessageBox.Show(" Order ID: \t\t\t"+ mOrderID + "\n Order reference Number: \t" + mOrderREF + "\n Order Description: \t\t" + mOrderDesc + "\n Order Date: \t\t" + mOrderDate + "\n Instructor Name: \t\t" + LoadInstructorName , "View Course",
    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedCells.Count > 0)
            {
                TableOrder mOrder = (TableOrder)dgvOrders.CurrentRow.DataBoundItem;
                id = mOrder.OrderID;
                ToUpdate = id;
            }
        }

        private void btnRefreshDGV_Click(object sender, EventArgs e)
        {
            dgvOrders.DataSource = null;
            var LoadOrders = from Order in db.TableOrders select Order;
            dgvOrders.DataSource = LoadOrders;
            dgvOrders.Update();
            dgvOrders.Refresh();
        }

        private void btnReturnOder_Click(object sender, EventArgs e)
        {
            //Log return stock ( damaged stock )


        }

        private void btnLogRefund_Click(object sender, EventArgs e)
        {
            //Log refund ( money )


        }

        private void btnLogPayment_Click(object sender, EventArgs e)
        {
            //Log payment to generate receipt
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            // order invoice to instructor asking for payment
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            // generate after payment is received
        }

        private void txtSearchOrderID_TextChanged(object sender, EventArgs e)
        {
            txtSearchOrderID.BackColor = Color.White;
            string OrderID = txtSearchOrderID.Text;
            bool isInt = chk.CheckInt(OrderID);
            bool notEmpty = chk.CheckEmpty(OrderID);
            bool checkForSQLInjection = chk.checkForSQLInjection(OrderID);

            if (isInt == false)
            {
                txtSearchOrderID.BackColor = Color.FromArgb(244, 17, 17);
                SearchISValid = false;
            }
            else if (notEmpty == false)
            {
                txtSearchOrderID.BackColor = Color.FromArgb(244, 17, 17);
                SearchISValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                txtSearchOrderID.BackColor = Color.FromArgb(244, 17, 17);
                SearchISValid = false;
            }
            else
            {
                txtSearchOrderID.BackColor = Color.White;
                SearchISValid = true;
            }

            if (SearchISValid == true)
            {
                var searchDesc = from Orders in db.TableOrders
                                 where Orders.OrderID == Convert.ToInt32(txtSearchOrderID.Text)
                                 select Orders;
                dgvOrders.DataSource = searchDesc;
                dgvOrders.Refresh();
            }
            else
            {
                dgvOrders.DataSource = null;
                var S = from Orders in db.TableOrders select Orders;
                dgvOrders.DataSource = S;
                dgvOrders.Update();
                dgvOrders.Refresh();
            }


        }
    }
}
