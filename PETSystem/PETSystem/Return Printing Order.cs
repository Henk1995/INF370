using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using PETSystem;

namespace PETSystem
{
    public partial class Return_Printing_Order : Form
    {
        int stop = 0;
        int ticks = ConnectString.TimerTime * 60;
        DateTime endOfTime;
        Timer t;
        SqlDataAdapter DA;
        bool valid1 = false;
        bool valid3 = false;
        ErrorHandle EH = new ErrorHandle();
        int antwoord;
        string x;
        public Return_Printing_Order()
        {
            InitializeComponent();
        }

        private void Return_Printing_Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'refIntegrityExportDataSet.PrinterOrder' table. You can move, or remove it, as needed.
           // this.printerOrderTableAdapter.Fill(this.refIntegrityExportDataSet.PrinterOrder);

            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT PrinterOrder.PrinterOrderID,PrinterOrder.PrinterOrderRefNumber,PrinterOrder.PrintOrderDate,PrinterOrder.PrintOrderDescription from PrinterOrder Where PrinterOrder.PrinterID = '" + ConnectString.SupplierID + "'", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvSuppOrder.DataSource = DT;
            dgvSuppOrder.DataMember = DT.TableName;
            ConnectString.connectstring.Close();

            //Indicate Supplier deails on labeles
            lblSupplierDetails.Text = "Printer ID:" + ConnectString.SupplierID + "\n Printer Name: " + ConnectString.SupplierName;
            // Add items to combobox
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Printing_Supplier UM = new Search_Printing_Supplier();
            UM.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stop++;

            if (stop > ticks)
            {
                t.Enabled = false;
                this.Close();
                this.Dispose(true);
                LoginF myform = new LoginF();
                myform.ShowDialog();
            }
            else
            {
                TimeSpan ts = endOfTime.Subtract(DateTime.Now);
                lblTimer.Text = ts.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string emailA = "";
                if (dgvSuppOrder.SelectedRows.Count > 0)
                {
                    string supplierID = Convert.ToString(ConnectString.SupplierID);
                    string RefID = dgvSuppOrder.SelectedRows[0].Cells[1].Value + string.Empty;
                    // gets the RowID from the first column in the grid
                    int suppID = int.Parse(supplierID);



                    string query2 = "SELECT PrinterEmail FROM Printer WHERE PrinterID ='" + suppID + "'";
                    SqlCommand MyCommand2 = new SqlCommand(query2, ConnectString.connectstring);
                    SqlDataReader MyReader2;
                    ConnectString.connectstring.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader2.Read())
                    {
                        emailA = MyReader2["PrinterEmail"].ToString();
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
                                mail.Body = "The order that was placed with reference number" + RefID + " is being returned as we are not happy with the order no refund required";
                                mail.IsBodyHtml = false;
                                client.Send(mail);
                                MessageBox.Show("Supplier notified via email that Order with \nReference number: " + RefID + "\nIs being returned", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                //Remove from supplierOrder
                                string SelectIDForDelete = dgvSuppOrder.SelectedRows[0].Cells[0].Value + string.Empty;

                                string Queryyz = "Delete  From PrinterOrder Where PrinterOrderID ='" + SelectIDForDelete + "'";
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
                            string a = dgvSuppOrder.SelectedRows[0].Cells[0].Value + string.Empty;
                            // Kry Count van Order Line
                            int CountOfOrders;
                            SqlConnection cnnCount = new SqlConnection(ConnectString.DBC);
                            cnnCount.Open();
                            SqlCommand cmdCount = cnnCount.CreateCommand();
                            cmdCount.CommandText = "Select COUNT(PrinterOrderID) from StockLine Where PrinterOrderID = '" + a + "'";
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


                            string Queryyy = "Delete TOP (1) From StockLine Where PrinterOrderID = '" + a + "' ";
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

                                lekkercmd.CommandText = "Select Quantity from StockLine Where PrinterOrderID = '" + a + "'";
                                cmdStocktable.CommandText = "Select StockID FROM StockLine Where PrinterOrderID = '" + a + "'";
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

                            string Queryyyz = "Delete TOP (1) From PrinterOrder Where PrinterOrderID = '" + a + "' ";
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
            catch
            {
                
            }
        }

        private void txtSupplierOrderID_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                txtSupplierOrderID.BackColor = Color.White;
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT PrinterOrder.PrinterOrderRefNumber,PrinterOrder.PrintOrderDate,PrinterOrder.PrintOrderDescription from PrinterOrder Where PrinterOrder.PrinterID = '" + ConnectString.SupplierID + "' AND PrinterOrderRefNumber Like '%" + txtSupplierOrderID.Text + "%'", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvSuppOrder.DataSource = DT;
                dgvSuppOrder.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                txtSupplierOrderID.BackColor = Color.White;
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT PrinterOrder.PrinterOrderRefNumber,PrinterOrder.PrintOrderDate,PrinterOrder.PrintOrderDescription from PrinterOrder Where PrinterOrder.PrinterID Where PrinterOrder.PrinterID = '" + ConnectString.SupplierID + "' AND PrintOrderDate Like '%" + txtSupplierOrderID.Text + "%'", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvSuppOrder.DataSource = DT;
                dgvSuppOrder.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
            else
            {
                txtSupplierOrderID.BackColor = Color.White;
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT PrinterOrder.PrinterOrderRefNumber,PrinterOrder.PrintOrderDate,PrinterOrder.PrintOrderDescription from PrinterOrder Where PrinterOrder.PrinterID Where PrinterOrder.PrinterID = '" + ConnectString.SupplierID + "' AND PrintOrderDescription Like '%" + txtSupplierOrderID.Text + "%'", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvSuppOrder.DataSource = DT;
                dgvSuppOrder.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Search_Printing_Supplier mm = new Search_Printing_Supplier();
            mm.ShowDialog();
        }
    }
}
