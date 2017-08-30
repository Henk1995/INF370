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

namespace Refund_Order
{
    public partial class RefundOrderSupp : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        SqlDataAdapter DA;
        bool valid1 = false;
        public RefundOrderSupp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM SupplierOrder", connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvSupp.DataSource = DT;
            dgvSupp.DataMember = DT.TableName;
            connectstring.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string queryA = "SELECT * FROM SupplierOrder WHERE SupplierOrderID ='" + Convert.ToInt32(txtSupplierOrderID.Text) + "'";
            SqlCommand MyCommandA = new SqlCommand(queryA, connectstring);

            SqlDataAdapter DAA = new SqlDataAdapter(MyCommandA);
            DataTable DTA = new DataTable();
            DAA.Fill(DTA);
            connectstring.Open();
            if (DTA.Rows.Count == 1)
            {

                valid1 = true;
            }
            connectstring.Close();
            if (valid1)
            {
                DataTable DT = new DataTable();
                connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM SupplierOrder WHERE SupplierOrderID ='" + Convert.ToInt32(txtSupplierOrderID.Text) + "'", connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvSupp.DataSource = DT;
                dgvSupp.DataMember = DT.TableName;
                connectstring.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailA = "";
            if (dgvSupp.SelectedRows.Count > 0)
            {
                string supplierID = dgvSupp.SelectedRows[0].Cells[4].Value + string.Empty;

                // gets the RowID from the first column in the grid
                int suppID = int.Parse(supplierID);


                MessageBox.Show("Are you sure you want to delete this instructor?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                string query2 = "SELECT SupplierEmail FROM Supplier WHERE SupplierID ='" + suppID + "'";
                SqlCommand MyCommand2 = new SqlCommand(query2, connectstring);
                SqlDataReader MyReader2;
                connectstring.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader2.Read())
                {
                    emailA = MyReader2["SupplierEmail"].ToString();
                }
                connectstring.Close();
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
                            mail.Body = "The order that was placed with reference number XXXXXXX is being returned as we are not happy with the order we insist on a full refund";
                            mail.IsBodyHtml = false;
                            client.Send(mail);
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            if (ex.InnerException != null)
                            { MessageBox.Show("InnerException is: {0}", ex.InnerException.ToString()); }

                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Suppliers UM = new Suppliers();
            UM.ShowDialog();
        }
    }
}
