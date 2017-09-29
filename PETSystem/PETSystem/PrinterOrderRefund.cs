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
using System.Data.SqlClient;
using PETSystem;

namespace PETSystem
{
    public partial class PrinterOrderRefund : Form
    {
        public PrinterOrderRefund()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool searchISValid;
        SqlDataAdapter DA;
        bool valid1 = false;
        bool valid3 = false;
        ErrorHandle EH = new ErrorHandle();
        int antwoord;
        string x;

        int printeridload = Search_Printing_Supplier.PrinterIDToEmail;

        //selected item in dgv
        int SelectedPrinterID;
        int SelectedRefNum;

        // get all the order details for email body
        string OrderDesc;
        string OrderDate;
        int EmailReferenceNumber;
        string ReturnEmail;


        private void PrinterOrderRefund_Load(object sender, EventArgs e)
        {
            //var LoadOrders = from PrinterOrder in db.PrinterOrders select PrinterOrder;
            //dgvSupp.DataSource = LoadOrders;
            //dgvSupp.Update();

            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT SupplierOrder.SupplierOrderID,SupplierOrder.SupplierOrderRefNumber,SupplierOrder.SupplierOrderDate,SupplierOrder.SupplierOrderDescription from SupplierOrder Where SupplierOrder.SupplierID = '" + ConnectString.SupplierID + "'", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvSupp.DataSource = DT;
            dgvSupp.DataMember = DT.TableName;
            ConnectString.connectstring.Close();

            //Indicate Supplier deails on labeles
            label1.Text = "Supplier ID:" + ConnectString.SupplierID + "\nSupplier Name: " + ConnectString.SupplierName;
            // Add items to combobox
            comboBox1.SelectedIndex = 0;

        }

        private void txtPrinterOrderID_TextChanged(object sender, EventArgs e)
        {
            txtSupplierOrderID.BackColor = Color.White;
            string ReturnOrderID = txtSupplierOrderID.Text;
            bool isInt = chk.CheckInt(ReturnOrderID);
            bool notEmpty = chk.CheckEmpty(ReturnOrderID);

            if (isInt == false)
            {
                //txtSupplierOrderID.BackColor = Color.FromArgb(244, 17, 17);
                searchISValid = false;
            }
            else if (notEmpty == false)
            {
                //txtSupplierOrderID.BackColor = Color.FromArgb(244, 17, 17);
                searchISValid = false;
            }
            else
            {
                //txtSupplierOrderID.BackColor = Color.White;
                searchISValid = true;
            }

            if (searchISValid == true)
            {
                var searchDesc = (from PrinterOrder in db.PrinterOrders
                                  where PrinterOrder.PrinterOrderID == Convert.ToInt32(ReturnOrderID)
                                  select PrinterOrder).FirstOrDefault();
                dgvSupp.DataSource = searchDesc;
                dgvSupp.Refresh();
            }
            else
            {
                dgvSupp.DataSource = null;
                var LoadOrders = from PrinterOrder in db.PrinterOrders select PrinterOrder;
                dgvSupp.DataSource = LoadOrders;
                dgvSupp.Update();
                dgvSupp.Refresh();
            }
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {

        }

        private void dgvPrinterOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSupp.SelectedCells.Count > 0)
            {
                PrinterOrder _Printer = (PrinterOrder)dgvSupp.CurrentRow.DataBoundItem;
                SelectedPrinterID = _Printer.PrinterID;
                SelectedRefNum = Convert.ToInt32(_Printer.PrinterOrderRefNumber);
            }

            //get order details for email body
            var mgetOrderDetails = (from a in db.PrinterOrders
                                    where a.PrinterOrderRefNumber == SelectedRefNum && a.PrinterID == SelectedPrinterID
                                    select new
                                    {
                                        a.PrintOrderDescription,
                                        a.PrintOrderDate,
                                        a.PrinterOrderRefNumber,
                                    }).ToList();

            foreach (var item in mgetOrderDetails)
            {
                OrderDesc = Convert.ToString(item.PrintOrderDescription);
                OrderDate = item.PrintOrderDate;
                EmailReferenceNumber = Convert.ToInt32(item.PrinterOrderRefNumber);
            }

            var getEmail = (from x in db.Printers where x.PrinterID == printeridload select x.PrinterEmail).FirstOrDefault();

            ReturnEmail = getEmail;

        }

        private void btnReturnOrder_Click(object sender, EventArgs e)
        {

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
                    mail.Subject = "Request to Refund order";
                    mail.Body = "The order that was placed on " + OrderDate + " with reference number " + EmailReferenceNumber + " is being returned as the order was damaged. \n The order description: \n" + OrderDesc + " \n Please Refund our payment in full";
                    mail.IsBodyHtml = false;
                    client.Send(mail);
                    MessageBox.Show("Message was sent");

                    this.Close();
                    Search_Printing_Supplier sps = new Search_Printing_Supplier();
                    sps.Show();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Order so = new Search_Order();
            so.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Printing_Supplier sps = new Search_Printing_Supplier();
            sps.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailA = "";
            if (dgvSupp.SelectedRows.Count > 0)
            {
                string supplierID = Convert.ToString(ConnectString.SupplierID);
                string RefID = dgvSupp.SelectedRows[0].Cells[1].Value + string.Empty;
                // gets the RowID from the first column in the grid
                int suppID = int.Parse(supplierID);

                string query2 = "SELECT SupplierEmail FROM Supplier WHERE SupplierID ='" + suppID + "'";
                SqlCommand MyCommand2 = new SqlCommand(query2, ConnectString.connectstring);
                SqlDataReader MyReader2;
                ConnectString.connectstring.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader2.Read())
                {
                    emailA = MyReader2["SupplierEmail"].ToString();
                }
                ConnectString.connectstring.Close();
                using (SmtpClient client = new SmtpClient())
                {
                    client.Host = "smtp.gmail.com";
                    client.UseDefaultCredentials = true;
                    NetworkCredential netCred = new NetworkCredential("janwilkensmalan1@gmail.com", "Wilkens123");
                    client.Credentials = netCred;
                    client.EnableSsl = true;
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    using (MailMessage mail = new MailMessage("janwilkensmalan1@gmail.com", emailA))
                    {
                        try
                        {
                            mail.Subject = "Return order";
                            mail.Body = "The order that was placed with reference number" + RefID + " is being returned as we are not happy with the order we kindly ask for a refund on the purchase";
                            mail.IsBodyHtml = false;
                            client.Send(mail);
                            MessageBox.Show("Supplier notified via email that Order with \nReference number: " + RefID + "\nIs being returned", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            //Remove from supplierOrder
                            string SelectIDForDelete = dgvSupp.SelectedRows[0].Cells[0].Value + string.Empty;

                            string Queryyz = "Delete  From SupplierOrder Where SupplierOrderID ='" + SelectIDForDelete + "'";
                            //This is  MySqlConnection here i have created the object and pass my connection string.  

                            SqlCommand MyCommandz = new SqlCommand(Queryyz, ConnectString.connectstring);
                            SqlDataReader MyReaderz;
                            ConnectString.connectstring.Open();
                            MyReaderz = MyCommandz.ExecuteReader();
                            //  MessageBox.Show("Stock quantity has been updated.");
                            ConnectString.connectstring.Close();
                            //Remove From StockLine
                            //Remove quantity from stock
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            if (ex.InnerException != null)
                            {
                                MessageBox.Show("InnerException is: {0}", ex.InnerException.ToString());
                                MessageBox.Show("Email was not sent please select the order that you want to return in the table.", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            }
                        }
                        ConnectString.connectstring.Close();
                        //OrderID
                        string a = dgvSupp.SelectedRows[0].Cells[0].Value + string.Empty;
                        // Kry Count van Order Line
                        int CountOfOrders;
                        SqlConnection cnnCount = new SqlConnection(ConnectString.DBC);
                        cnnCount.Open();
                        SqlCommand cmdCount = cnnCount.CreateCommand();
                        cmdCount.CommandText = "Select COUNT(SupplierOrderID) from StockLine Where SupplierOrderID = '" + a + "'";
                        CountOfOrders = ((int)cmdCount.ExecuteScalar());


                        cnnCount.Close();
                        //Stocktype in stockline table
                        SqlConnection connStcokTable = new SqlConnection(ConnectString.DBC);
                        connStcokTable.Open();
                        SqlCommand cmdStocktable = connStcokTable.CreateCommand();

                        //Kry stock quantity in stock table
                        SqlConnection convirMinus = new SqlConnection(ConnectString.DBC);
                        convirMinus.Open();
                        SqlCommand cmdvirMinus = convirMinus.CreateCommand();

                        //toets

                        // Update stock quantity String
                        SqlConnection connNou = new SqlConnection(ConnectString.DBC);

                        SqlDataReader ReaderStock;
                        connNou.Open();
                        ConnectString.connectstring.Open();

                        // MessageBox.Show("Training Course successfully updated");
                        // ConnectString.connectstring.Close();

                        //Stockline stock ID connection
                        //  get stock id

                        // int SelectIDForDelete = dgvSuppOrder.SelectedRows[0].Index;

                        string Queryyy = "Delete TOP (1) From StockLine Where SupplierOrderID = '" + a + "' ";
                        //This is  MySqlConnection here i have created the object and pass my connection string.  

                        SqlCommand MyCommandzz = new SqlCommand(Queryyy, ConnectString.connectstring);
                        SqlDataReader MyReaderzz;

                        int quantitySum;


                        SqlConnection lekercon = new SqlConnection(ConnectString.DBC);
                        lekercon.Open();

                        //Kry all die data 1 vir 1

                        for (int i = 0; i < CountOfOrders; i++)
                        {
                            //  MessageBox.Show("a");
                            SqlCommand lekkercmd = lekercon.CreateCommand();

                            lekkercmd.CommandText = "Select Quantity from StockLine Where SupplierOrderID = '" + a + "'";
                            cmdStocktable.CommandText = "Select StockID FROM StockLine Where SupplierOrderID = '" + a + "'";
                            x = a;
                            //int gebruikvirMinus = Convert.ToInt32(x);
                            x = ((int)cmdStocktable.ExecuteScalar()).ToString();
                            string z = a;
                            z = ((int)lekkercmd.ExecuteScalar()).ToString();
                            // MessageBox.Show(gebruikvirMinus.ToString());
                            cmdvirMinus.CommandText = "Select StockQuantity FROM Stock Where StockID = '" + x + "'";
                            string y = x;
                            y = ((int)cmdvirMinus.ExecuteScalar()).ToString();

                            //Maak som om stock te update

                            antwoord = Convert.ToInt32(y) - Convert.ToInt32(z);
                            MyReaderzz = MyCommandzz.ExecuteReader();
                            MyReaderzz.Close();
                            string QueryStock = "UPDATE Stock SET StockQuantity ='" + antwoord + "'WHERE StockID ='" + x + "'";
                            SqlCommand ComandStock = new SqlCommand(QueryStock, connNou);
                            ReaderStock = ComandStock.ExecuteReader();


                            ReaderStock.Close();

                        }
                        lekercon.Close();
                        ConnectString.connectstring.Close();
                        connStcokTable.Close();
                        convirMinus.Close();
                        connNou.Close();

                        string Queryyyz = "Delete TOP (1) From SupplierOrder Where SupplierOrderID = '" + a + "' ";
                        //This is  MySqlConnection here i have created the object and pass my connection string.  

                        SqlCommand MyCommandzzz = new SqlCommand(Queryyyz, ConnectString.connectstring);
                        SqlDataReader MyReaderzzz;
                        ConnectString.connectstring.Open();
                        MyReaderzzz = MyCommandzzz.ExecuteReader();
                        ConnectString.connectstring.Close();

                        MessageBox.Show("Stock Quantity has been updated and order has been removed");
                        txtSupplierOrderID.Text = "a";
                        txtSupplierOrderID.Text = "";
                    }
                }

            }
        }

        private void txtSupplierOrderID_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                txtSupplierOrderID.BackColor = Color.White;
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT SupplierOrder.SupplierOrderRefNumber,SupplierOrder.SupplierOrderDate,SupplierOrder.SupplierOrderDescription from SupplierOrder Where SupplierOrder.SupplierID = '" + ConnectString.SupplierID + "' AND SupplierOrderRefNumber Like '%" + txtSupplierOrderID.Text + "%'", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvSupp.DataSource = DT;
                dgvSupp.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                txtSupplierOrderID.BackColor = Color.White;
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT SupplierOrder.SupplierOrderRefNumber,SupplierOrder.SupplierOrderDate,SupplierOrder.SupplierOrderDescription from SupplierOrder Where SupplierOrder.SupplierID = '" + ConnectString.SupplierID + "' AND SupplierOrderDate Like '%" + txtSupplierOrderID.Text + "%'", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvSupp.DataSource = DT;
                dgvSupp.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
            else
            {
                txtSupplierOrderID.BackColor = Color.White;
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT SupplierOrder.SupplierOrderRefNumber,SupplierOrder.SupplierOrderDate,SupplierOrder.SupplierOrderDescription from SupplierOrder Where SupplierOrder.SupplierID = '" + ConnectString.SupplierID + "' AND SupplierOrderDescription Like '%" + txtSupplierOrderID.Text + "%'", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvSupp.DataSource = DT;
                dgvSupp.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
        }
    }
}
