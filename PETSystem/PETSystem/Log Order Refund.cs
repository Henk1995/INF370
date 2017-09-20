using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace PETSystem
{
    public partial class Log_Order_Refund : Form
    {
        public Log_Order_Refund()
        {
            InitializeComponent();
        }

        ErrorHandle chk = new ErrorHandle();
        PET_DBDataContext db = new PET_DBDataContext();
        bool searchISValid;
        int SelectedOrderID;
        string SelectedOrderDesc;


        private void txtPrinterOrderID_TextChanged(object sender, EventArgs e)
        {
            txtPrinterOrderID.BackColor = Color.White;
            string ReturnOrderID = txtPrinterOrderID.Text;
            bool isInt = chk.CheckInt(ReturnOrderID);
            bool notEmpty = chk.CheckEmpty(ReturnOrderID);

            if (isInt == false)
            {
                txtPrinterOrderID.BackColor = Color.FromArgb(244, 17, 17);
                searchISValid = false;
            }
            else if (notEmpty == false)
            {
                txtPrinterOrderID.BackColor = Color.FromArgb(244, 17, 17);
                searchISValid = false;
            }
            else
            {
                txtPrinterOrderID.BackColor = Color.White;
                searchISValid = true;
            }

            if (searchISValid == true)
            {
                var searchDesc = (from Order in db.TableOrders
                                  where Order.OrderID == Convert.ToInt32(ReturnOrderID)
                                  select Order).FirstOrDefault();
                dgvPrinterOrder.DataSource = searchDesc;
                dgvPrinterOrder.Refresh();
            }
            else
            {
                dgvPrinterOrder.DataSource = null;
                var LoadOrders = from Order in db.TableOrders select Order;
                dgvPrinterOrder.DataSource = LoadOrders;
                dgvPrinterOrder.Update();
                dgvPrinterOrder.Refresh();
            }
        }

        private void Log_Order_Refund_Load(object sender, EventArgs e)
        {

        }

        private void dgvPrinterOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrinterOrder.SelectedCells.Count > 0)
            {
                TableOrder _Order = (TableOrder)dgvPrinterOrder.CurrentRow.DataBoundItem;
                SelectedOrderDesc = _Order.OrderDescription;
                SelectedOrderID = Convert.ToInt32(_Order.OrderID);
            }
        }

        private void btnReturnOrder_Click(object sender, EventArgs e)
        {

           //Send Email
            
        }
    }
}
