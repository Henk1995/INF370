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

namespace PETSystem
{
    public partial class Place_Instructor_Order : Form
    {
        string DescriptionForOrder;
        int result, CBresult = 0;
        DateTime endOfTime;
        Timer t;
        public Place_Instructor_Order()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();
        int InstructorOrderID = Select_Instructor.InstructorIDForOrder;
        int CurrentlyLoggedInUserID = LoginF.UserIDthatLoggedIn;


        int RefNum = 0;
        ErrorHandle EH = new ErrorHandle();
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        double OrderT = 0;
        string OrderDesc = "";
        string OrderDate = "";
        int SuppID = 0;
        string ReturnEmail;



        private void Place_Instructor_Order_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            //populate combobox
            cbProduct.Items.Clear();
            string query = "SELECT StockDescription FROM Stock ";
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query, ConnectString.connectstring);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);

            foreach (DataRow dr in DT.Rows)
            {
                cbProduct.Items.Add(dr["StockDescription"]).ToString();
            }
            ConnectString.connectstring.Close();
            //Select index in combobox
            cbProduct.SelectedIndex = 0;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Select_Instructor si = new Select_Instructor();
            si.Show();
        }

        private void btnARN_Click(object sender, EventArgs e)
        {
            

        }

        private void txtReferenceNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
         
        }

     

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAddI_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
          
        }

        private void btnARN_Click_1(object sender, EventArgs e)
        {
          

        }

        private void btnAddI_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnPO_Click_1(object sender, EventArgs e)
        {
           



               
               
            }               

        private void txtDescription_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtDate_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
           
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

        private void Place_Instructor_Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
        int referenceNumber;
        string Date;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Buttons visables
            btnBack.Visible = false;
            btnEnter.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            referenceNumber = Convert.ToInt32(txtRefNumber.Text);
            Date = txtDate.Text;

            // Add new order as placeholder for order 
            int stockID = cbProduct.SelectedIndex + 1;
            BtnCapture.Visible = true;

            //Add product in StockLine sodat dit 3rdNormalFormis
            ConnectString.connectstring.Open();
            string Query = "INSERT INTO TableOrder(UserID,InstructorID,Order_ReferenceNumber,OrderDate) values('"+ConnectString.UserIDforOrders+"','" + ConnectString.InstructorID + "','"+referenceNumber+"','"+Date+"')";
            //This is  MySqlConnection here i have created the object and pass my connection string.  

            //This is command class which will handle the query and connection object.  
            SqlCommand MyCommand2 = new SqlCommand(Query, ConnectString.connectstring);
            SqlDataReader MyReader2;

            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            MessageBox.Show("Reference number and date Captured");
            while (MyReader2.Read())
            {
            }
            ConnectString.connectstring.Close();
            // txtOrder.Clear();
            txtOrder.Text = txtOrder.Text + "Order Reference Number: " + referenceNumber + "            Date: " + Date;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }
        int OrderID;

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            string Query = "UPDATE TableOrder SET OrderDescription = '" + DescriptionForOrder + "', Total = '"+Total+"' WHERE OrderID =" + OrderID + ";";
            //This is  MySqlConnection here i have created the object and pass my connection string.  


            SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
            SqlDataReader MyReader3;
            ConnectString.connectstring.Open();
            MyReader3 = MyCommand3.ExecuteReader();
            MessageBox.Show("Order captured and stock quantity updated successfully.");
            ConnectString.connectstring.Close();
            
            //Email
            string emailA = "";
            string query2 = "SELECT Email FROM Instructor WHERE InstructorID ='" + ConnectString.InstructorID + "'";
            SqlCommand MyCommand2 = new SqlCommand(query2, ConnectString.connectstring);
            SqlDataReader MyReader2;
            ConnectString.connectstring.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

            while (MyReader2.Read())
            {
                emailA = MyReader2["Email"].ToString();
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
                        mail.Subject = "Order Placed";
                        mail.Body = "We have successfully placed your order with reference number: "+referenceNumber+"\n\n Thank you for your support!";
                        mail.IsBodyHtml = false;
                        client.Send(mail);
                        MessageBox.Show("Instructor notified via email that Order with \nReference number: " + referenceNumber + "\nIs has been placed", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    }
                    catch
                    {
                        MessageBox.Show("Email could not be sent at this time");
                    }
                }
            }
            this.Close();
            this.Dispose(true);
            Search_Order myform = new Search_Order();
            myform.ShowDialog();
        }
        int nitPrice = 0;
        float Total;
        private void button3_Click(object sender, EventArgs e)
        {//Get unit Price
           
            string querya = "SELECT StockUnitPrice FROM Stock Where Stock.StockDescription ='" + cbProduct.Text + "'";
            SqlCommand MyCommanda = new SqlCommand(querya, ConnectString.connectstring);
            SqlDataReader MyReadera;
            ConnectString.connectstring.Open();
            MyReadera = MyCommanda.ExecuteReader();     // Here our query will be executed and data saved into the database.  

            while (MyReadera.Read())
            {
                nitPrice = Convert.ToInt32(MyReadera["StockUnitPrice"]);
            }
            ConnectString.connectstring.Close();



            // Get Order ID
            SqlConnection connectionz = new SqlConnection(ConnectString.DBC);
            connectionz.Open();
            SqlCommand cmddz = connectionz.CreateCommand();
            cmddz.CommandText = "Select  MAX(OrderID) FROM TableOrder";
            OrderID = ((int)cmddz.ExecuteScalar());


            connectionz.Close();

            //  get stock id
            SqlConnection connection2 = new SqlConnection(ConnectString.DBC);
            connection2.Open();
            SqlCommand cmdd2 = connection2.CreateCommand();
            cmdd2.CommandText = "Select StockID FROM Stock Where StockDescription ='" + cbProduct.Text + "'";
            CBresult = ((int)cmdd2.ExecuteScalar());


            connection2.Close();
            //variables vir orderline
            int quantityorder = Convert.ToInt32(NUPQuantity.Value);
            //Add product in StockLine sodat dit 3rdNormalFormis
            ConnectString.connectstring.Open();
            string Query = "INSERT INTO OrderLine(OrderID,StockID,Quantity) values('"+OrderID+"','"+CBresult+"','"+quantityorder+"')";
            //This is  MySqlConnection here i have created the object and pass my connection string.  

            //This is command class which will handle the query and connection object.  
            SqlCommand MyCommand2 = new SqlCommand(Query, ConnectString.connectstring);
            SqlDataReader MyReader2;

            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            MessageBox.Show("Products added to total order.");
            while (MyReader2.Read())
            {
            }
            ConnectString.connectstring.Close();


            // Update TExtbox
            txtOrder.Text = txtOrder.Text + "\nItem Ordered: " + cbProduct.Text + " Quantity: " +Convert.ToString(NUPQuantity.Value);
            DescriptionForOrder = DescriptionForOrder + cbProduct.Text + ",";
            Total = Total + (nitPrice* Convert.ToInt32(NUPQuantity.Value));
            //Get Current Quantity of stock
            int UsethisforStockUpdate;
            SqlConnection ConQuantity = new SqlConnection(ConnectString.DBC);
            ConQuantity.Open();
            SqlCommand cmdQuantity = ConQuantity.CreateCommand();
            cmdQuantity.CommandText = "Select StockQuantity FROM Stock  Where StockDescription ='" + cbProduct.Text + "'";
            UsethisforStockUpdate = ((int)cmdQuantity.ExecuteScalar());
            UsethisforStockUpdate = UsethisforStockUpdate - Convert.ToInt32(NUPQuantity.Value);

            ConQuantity.Close();

            // Add to stock 

            string QueryStock = "UPDATE Stock SET StockQuantity ='" + UsethisforStockUpdate + "' WHERE StockID ='" + CBresult + "'";



            SqlCommand ComandStock = new SqlCommand(QueryStock, ConnectString.connectstring);
            SqlDataReader ReaderStock;
            ConnectString.connectstring.Open();
            ReaderStock = ComandStock.ExecuteReader();
            // MessageBox.Show("Training Course successfully updated");
            ConnectString.connectstring.Close();

        }
    }
}
