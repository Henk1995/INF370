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

namespace PETSystem
{
    public partial class PlaceSupplierOrder : Form
    {

        DateTime endOfTime;
        Timer t;
        public PlaceSupplierOrder()
        {
            InitializeComponent();
        }

        private void PlaceSupplierOrder_Load(object sender, EventArgs e)
        {
            //TT
            //Place orer
            ToolTip TTP = new ToolTip();
            TTP.ToolTipTitle = "Place order";
            TTP.UseFading = true;
            TTP.UseAnimation = true;
            TTP.IsBalloon = true;
            TTP.SetToolTip(button1, "Click here to e-mail above text to the supplier and place an order.");
            //back
            ToolTip TTB = new ToolTip();
            TTB.ToolTipTitle = "Back";
            TTB.UseFading = true;
            TTB.UseAnimation = true;
            TTB.IsBalloon = true;
            TTB.SetToolTip(button2, "Click here to Return to previous screen.");

            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            label1.Text = "Supplier ID: " + Convert.ToString(ConnectString.SupplierID) + " \nSupplier Name: " + ConnectString.SupplierName;
            txtEmail.Text = "Good day.\n\nI would like to place an order for :";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Stuur email
            string Email = "";
            string query2 = "SELECT SupplierEmail FROM Supplier WHERE SupplierID ='" + ConnectString.SupplierID + "'";
            SqlCommand MyCommand2 = new SqlCommand(query2, ConnectString.connectstring);
            SqlDataReader MyReader2;
            ConnectString.connectstring.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

            while (MyReader2.Read())
            {
                Email = MyReader2["SupplierEmail"].ToString();
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
                using (MailMessage mail = new MailMessage("janwilkensmalan1@gmail.com", Email))
                {
                    try
                    {
                        mail.Subject = "Order Placement";
                        mail.Body = txtEmail.Text;
                        mail.IsBodyHtml = false;
                        client.Send(mail);
                        MessageBox.Show("Order has been placed to Supplier: " + ConnectString.SupplierName + "\nReturning to Supplier Menu", "Notification");
                        Suppliers myform = new Suppliers();
                        this.Dispose(true);
                        this.Close();
                        myform.ShowDialog();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Suppliers myform = new Suppliers();
            myform.ShowDialog();
        }

        int stop = 0;
        int ticks = ConnectString.TimerTime * 60;

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
            else {
                TimeSpan ts = endOfTime.Subtract(DateTime.Now);
                lblTimer.Text = ts.ToString();
            }
        }

        private void PlaceSupplierOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
