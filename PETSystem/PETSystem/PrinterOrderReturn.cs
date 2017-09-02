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
    public partial class PrinterOrderReturn : Form
    {
        public PrinterOrderReturn()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool searchISValid;
        int SelectedRefNum;
        string ReturnEmail;
        int SelectedPrinterID;
        string OrderDate;
        string OrderDesc;
        int EmailReferenceNumber;


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Printing_Supplier sps = new Search_Printing_Supplier();
            sps.Show();
        }

        private void PrinterOrderReturn_Load(object sender, EventArgs e)
        {
            var LoadOrders = from PrinterOrder in db.PrinterOrders select PrinterOrder;
            dgvPrinterOrder.DataSource = LoadOrders;
            dgvPrinterOrder.Update();
        }

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
                var searchDesc = (from PrinterOrder in db.PrinterOrders
                                 where PrinterOrder.PrinterOrderID == Convert.ToInt32(ReturnOrderID)
                                 select PrinterOrder).FirstOrDefault();
                dgvPrinterOrder.DataSource = searchDesc;
                dgvPrinterOrder.Refresh();
            }
            else
            {
                dgvPrinterOrder.DataSource = null;
                var LoadOrders = from PrinterOrder in db.PrinterOrders select PrinterOrder;
                dgvPrinterOrder.DataSource = LoadOrders;
                dgvPrinterOrder.Update();
                dgvPrinterOrder.Refresh();
            }


        }

        private void btnReturnOrder_Click(object sender, EventArgs e)
        {

            var mgetOrderDetails = (from a in db.PrinterOrders
                                    where a.PrinterOrderID == SelectedRefNum && a.PrinterID == SelectedPrinterID
                                    select new
                                    {
                                        a.PrintOrderDescription,
                                        a.PrintOrderDate,
                                        a.PrinterOrderRefNumber,
                                    }).ToList();

            foreach (var item in mgetOrderDetails)
            {
                OrderDesc = Convert.ToString(item.PrintOrderDescription);
                OrderDate= item.PrintOrderDate;
                EmailReferenceNumber = Convert.ToInt32(item.PrinterOrderRefNumber);
            }

            var getEmail = (from x in db.Printers where x.PrinterID == SelectedPrinterID select x.PrinterEmail).FirstOrDefault();

            ReturnEmail = getEmail;

                using (SmtpClient client = new SmtpClient())
                {
                    client.Host = "smtp.gmail.com";
                    client.UseDefaultCredentials = true;
                    NetworkCredential netCred = new NetworkCredential("petsystemtest@gmail.com", "JJSRHsystem");
                    client.Credentials = netCred;
                    client.EnableSsl = true;
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    using (MailMessage mail = new MailMessage("petsystemtest@gmail.com", ReturnEmail))
                    {
                        mail.Subject = "Returning Order";
                        mail.Body = "The order that was placed on " + OrderDate + "with reference number " + EmailReferenceNumber + " is being returned as the order was damaged. \n The order description: \n" + OrderDesc;
                        mail.IsBodyHtml = false;
                        client.Send(mail);
                        MessageBox.Show("Message was sent");

                        this.Close();
                        Search_Printing_Supplier sps = new Search_Printing_Supplier();
                        sps.Show();
                    }
            }
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {

        }

        private void dgvPrinterOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrinterOrder.SelectedCells.Count > 0)
            {
                PrinterOrder _Printer = (PrinterOrder)dgvPrinterOrder.CurrentRow.DataBoundItem;
                SelectedPrinterID = _Printer.PrinterID;
                SelectedRefNum = Convert.ToInt32(_Printer.PrinterOrderRefNumber);
            }
        }

        private void dgvPrinterOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
