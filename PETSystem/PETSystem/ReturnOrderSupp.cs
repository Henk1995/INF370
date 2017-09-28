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

namespace Return_Order
{
    public partial class ReturnOrderSupp : Form
    {
       
        SqlDataAdapter DA;
        bool valid1 = false;
        bool valid3 = false;
        ErrorHandle EH = new ErrorHandle();
        public ReturnOrderSupp()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT SupplierOrder.SupplierOrderID,SupplierOrder.SupplierOrderRefNumber,SupplierOrder.SupplierOrderDate,SupplierOrder.SupplierOrderDescription from SupplierOrder Where SupplierOrder.SupplierID = '" + ConnectString.SupplierID+"'", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvSuppOrder.DataSource = DT;
            dgvSuppOrder.DataMember = DT.TableName;
            ConnectString.connectstring.Close();

            //Indicate Supplier deails on labeles
            lblSupplierDetails.Text = "Supplier ID:" + ConnectString.SupplierID + "\nSupplier Name: " + ConnectString.SupplierName;
            // Add items to combobox
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            string emailA = "";
            if (dgvSuppOrder.SelectedRows.Count > 0)
            {
                string supplierID = Convert.ToString(ConnectString.SupplierID);
                string RefID = dgvSuppOrder.SelectedRows[0].Cells[1].Value + string.Empty;
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
                            mail.Body = "The order that was placed with reference number"  + RefID +" is being returned as we are not happy with the order no refund required";
                            mail.IsBodyHtml = false;
                            client.Send(mail);
                            MessageBox.Show("Supplier notified via email that Order with \nReference number: " + RefID + "\nIs being returned", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            //Remove from supplierOrder
                            int SelectIDForDelete =  dgvSuppOrder.SelectedRows[0].Index;
                            string Queryy = "Delete * From SupplierOrder Where SupplierOrderID ='"+SelectIDForDelete+"'";
                            //This is  MySqlConnection here i have created the object and pass my connection string.  


                            SqlCommand MyCommandz = new SqlCommand(Queryy, ConnectString.connectstring);
                            SqlDataReader MyReaderz;
                            ConnectString.connectstring.Open();
                            MyReaderz = MyCommandz.ExecuteReader();
                          //  MessageBox.Show("Stock quantity has been updated.");
                            ConnectString.connectstring.Close();
                            
                            //Remove From StockLine
                            string Queryyy = "Delete * From StockLine Where SupplierOrderID ='" + SelectIDForDelete + "'";
                            //This is  MySqlConnection here i have created the object and pass my connection string.  


                            SqlCommand MyCommandzz = new SqlCommand(Queryyy, ConnectString.connectstring);
                            SqlDataReader MyReaderzz;
                            ConnectString.connectstring.Open();
                            MyReaderzz = MyCommandzz.ExecuteReader();
                           // MessageBox.Show("Stock quantity has been updated.");
                            ConnectString.connectstring.Close();

                            //Remove quantity from stock


                     
                            string QueryStock = "UPDATE Stock SET StockQuantity ='" + UsethisforStockUpdate + "',StockUnitPrice = '" + unitPrice + "' WHERE StockID ='" + CBresult + "'";
                            //This is  MySqlConnection here i have created the object and pass my connection string.  


                            SqlCommand MyCommandzzz = new SqlCommand(Queryyy, ConnectString.connectstring);
                            SqlDataReader MyReaderzzz;
                            ConnectString.connectstring.Open();
                            MyReaderzzz = MyCommandzzz.ExecuteReader();
                            

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
                        }
                      }
				  }*/

            int OrderID = dgvSuppOrder.SelectedRows[0].Index;
            int quantitySum;
            SqlConnection connfromQuantity = new SqlConnection(ConnectString.DBC);
            connfromQuantity.Open();
            SqlCommand cmdStock = connfromQuantity.CreateCommand();
            cmdStock.CommandText = "Select SUM(Quantity) FROM StockLine Where SupplierOrderID ='" + OrderID + "'";
            quantitySum = ((int)cmdStock.ExecuteScalar());


            connfromQuantity.Close();
            MessageBox.Show(quantitySum.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Suppliers UM = new Suppliers();
            UM.Show();
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
                dgvSuppOrder.DataSource = DT;
                dgvSuppOrder.DataMember = DT.TableName;
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
                dgvSuppOrder.DataSource = DT;
                dgvSuppOrder.DataMember = DT.TableName;
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
                dgvSuppOrder.DataSource = DT;
                dgvSuppOrder.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
            
        }
    }
}
