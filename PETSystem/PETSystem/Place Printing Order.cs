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
    public partial class Place_Printing_Order : Form
    {
        public Place_Printing_Order()
        {
            InitializeComponent();
        }

        int PrinterID = Search_Printing_Supplier.ToUpdate;
        string PrinterName = Search_Printing_Supplier.PrinterName;
        string PrinterEmail = Search_Printing_Supplier.SelectedPrinterToEmail;

        private void Place_Printing_Order_Load(object sender, EventArgs e)
        {
            label1.Text = "Printer ID: " + PrinterID + " \nPrinter Name: " + PrinterName;
            txtEmail.Text = "Good day.\n\nI would like to place an order for :";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Printing_Supplier SPS = new Search_Printing_Supplier();
            SPS.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Stuur email
            using (SmtpClient client = new SmtpClient())
            {
                client.Host = "smtp.gmail.com";
                client.UseDefaultCredentials = true;
                NetworkCredential netCred = new NetworkCredential("janwilkensmalan1@gmail.com", "Wilkens123");
                client.Credentials = netCred;
                client.EnableSsl = true;
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                using (MailMessage mail = new MailMessage("janwilkensmalan1@gmail.com", PrinterEmail))
                {
                    try
                    {
                        mail.Subject = "Order Placement";
                        mail.Body = txtEmail.Text;
                        mail.IsBodyHtml = false;
                        client.Send(mail);
                        MessageBox.Show("Order has been placed to Supplier: " + ConnectString.SupplierName + "\nReturning to Supplier Menu", "Notification");
                        Search_Printing_Supplier myform = new Search_Printing_Supplier();
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
    }
}
