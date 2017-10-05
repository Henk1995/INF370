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

namespace PETSystem
{
    public partial class Recieve_Printing_Order : Form
    {
        DateTime endOfTime;
        Timer t;
        public Recieve_Printing_Order()
        {
            InitializeComponent();
        }
        string referenceNumber;
        string Date;
        int totalForOrder;
        string DescriptionForOrder;
        int result, CBresult = 0;




        int UsethisforStockUpdate;
        int stop = 0;
        int ticks = ConnectString.TimerTime * 60;
        private void Recieve_Printing_Order_Load(object sender, EventArgs e)
        {
            //refnumber
            ToolTip TTREF = new ToolTip();
            TTREF.ToolTipTitle = "Reference Number";
            TTREF.UseFading = true;
            TTREF.UseAnimation = true;
            TTREF.IsBalloon = true;
            TTREF.SetToolTip(txtRefNumber, "Enter the print order's reference number here.");
            //date
            ToolTip TDTATE = new ToolTip();
            TDTATE.ToolTipTitle = "Date";
            TDTATE.UseFading = true;
            TDTATE.UseAnimation = true;
            TDTATE.IsBalloon = true;
            TDTATE.SetToolTip(txtDate, "Enter the print order's date number here.");
            //Product 
            ToolTip TTPROD = new ToolTip();
            TTPROD.ToolTipTitle = "Product";
            TTPROD.UseFading = true;
            TTPROD.UseAnimation = true;
            TTPROD.IsBalloon = true;
            TTPROD.SetToolTip(cbProduct, "Select product here.");
            //quantity
            ToolTip TTQUAT = new ToolTip();
            TTQUAT.ToolTipTitle = "Quantity";
            TTQUAT.UseFading = true;
            TTQUAT.UseAnimation = true;
            TTQUAT.IsBalloon = true;
            TTQUAT.SetToolTip(NUPQuantity, "Select the quantity here.");
            //total
            ToolTip TTTOTAL = new ToolTip();
            TTTOTAL.ToolTipTitle = "Total";
            TTTOTAL.UseFading = true;
            TTTOTAL.UseAnimation = true;
            TTTOTAL.IsBalloon = true;
            TTTOTAL.SetToolTip(txtTotal, "Enter the total for the product line here.");
            //add
            ToolTip TTADD = new ToolTip();
            TTADD.ToolTipTitle = "Add";
            TTADD.UseFading = true;
            TTADD.UseAnimation = true;
            TTADD.IsBalloon = true;
            TTADD.SetToolTip(button3, "Click here to add information to order line.");
            //capture
            ToolTip TTCAP = new ToolTip();
            TTCAP.ToolTipTitle = "Capture";
            TTCAP.UseFading = true;
            TTCAP.UseAnimation = true;
            TTCAP.IsBalloon = true;
            TTCAP.SetToolTip(button3, "Click here to capture the total order.");
            //back
            ToolTip TTBACK = new ToolTip();
            TTBACK.ToolTipTitle = "Back";
            TTBACK.UseFading = true;
            TTBACK.UseAnimation = true;
            TTBACK.IsBalloon = true;
            TTBACK.SetToolTip(BtnBack, "Click here to return to previous screen.");
            //enter
            ToolTip TTENDt = new ToolTip();
            TTENDt.ToolTipTitle = "Enter";
            TTENDt.UseFading = true;
            TTENDt.UseAnimation = true;
            TTENDt.IsBalloon = true;
            TTENDt.SetToolTip(btnEnter, "Click here to capture date and reference number.");

            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            txtOrder.Text = "Order:";
            groupBox1.Visible = false;
            BtnCapture.Visible = false;

            //Get Order ID for OrderLine

            SqlConnection connection = new SqlConnection(ConnectString.DBC);
            connection.Open();
            SqlCommand cmdd = connection.CreateCommand();
            cmdd.CommandText = "Select MAX(PrinterOrderID) FROM PrinterOrder";
            result = ((int)cmdd.ExecuteScalar());
            result = result + 1;

            connection.Close();

            //Get Stock ID



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

        private void label4_Click(object sender, EventArgs e)
        {
            ConnectString.ActiveForm = true;
            Create_stock_item myform = new Create_stock_item();
            myform.ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            BtnBack.Visible = false;
            btnEnter.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            referenceNumber = txtRefNumber.Text;
            Date = txtDate.Text;

            // Add new order as placeholder for Stock line
            int stockID = cbProduct.SelectedIndex + 1;
            BtnCapture.Visible = true;

            //Add product in StockLine sodat dit 3rdNormalFormis
            ConnectString.connectstring.Open();
            string Query = "INSERT INTO PrinterOrder(PrinterID) values('" + ConnectString.SupplierID + "')";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //  get stock id
                SqlConnection connection2 = new SqlConnection(ConnectString.DBC);
                connection2.Open();
                SqlCommand cmdd2 = connection2.CreateCommand();
                cmdd2.CommandText = "Select StockID FROM Stock Where StockDescription ='" + cbProduct.Text + "'";
                CBresult = ((int)cmdd2.ExecuteScalar());


                connection2.Close();
                // MessageBox.Show(Convert.ToString(CBresult));



                BtnBack.Enabled = false;
                int stockID = cbProduct.SelectedIndex + 1;
                BtnCapture.Visible = true;

                //Add product in StockLine sodat dit 3rdNormalFormis
                ConnectString.connectstring.Open();
                string Query = "INSERT INTO StockLine(SupplierOrderID,SupplierID,PrinterOrderID,PrinterID,StockID,Quantity) values('" + result + "','" + ConnectString.SupplierID + "',NULL,NULL,'" + CBresult + "','" + NUPQuantity.Value + "')";
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
                //Rich edit update
                int unitPrice;
                unitPrice = Convert.ToInt32(txtTotal.Text) / Convert.ToInt32(NUPQuantity.Value);
                txtOrder.Text = txtOrder.Text + "\nProduct: " + cbProduct.Text + "\nQuantity: " + Convert.ToString(NUPQuantity.Value) + "\nUnit Price R.: " + unitPrice + "Total R.: " + txtTotal.Text;
                //add description en total
                DescriptionForOrder = DescriptionForOrder + cbProduct.Text + ",";
                totalForOrder = totalForOrder + Convert.ToInt32(txtTotal.Text);

                //Get Current Quantity of stock

                SqlConnection ConQuantity = new SqlConnection(ConnectString.DBC);
                ConQuantity.Open();
                SqlCommand cmdQuantity = ConQuantity.CreateCommand();
                cmdQuantity.CommandText = "Select StockQuantity FROM Stock  Where StockDescription ='" + cbProduct.Text + "'";
                UsethisforStockUpdate = ((int)cmdQuantity.ExecuteScalar());
                UsethisforStockUpdate = UsethisforStockUpdate + Convert.ToInt32(NUPQuantity.Value);

                ConQuantity.Close();

                // Add to stock 

                string QueryStock = "UPDATE Stock SET StockQuantity ='" + UsethisforStockUpdate + "',StockUnitPrice = '" + unitPrice + "' WHERE StockID ='" + CBresult + "'";



                SqlCommand ComandStock = new SqlCommand(QueryStock, ConnectString.connectstring);
                SqlDataReader ReaderStock;
                ConnectString.connectstring.Open();
                ReaderStock = ComandStock.ExecuteReader();
                // MessageBox.Show("Training Course successfully updated");
                ConnectString.connectstring.Close();
            }
            catch {
                MessageBox.Show("Error occured returning to previous screen");
                ConnectString.connectstring.Close();
                Search_Printing_Supplier vv = new Search_Printing_Supplier();
                vv.ShowDialog();
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Search_Printing_Supplier myform = new Search_Printing_Supplier();
            myform.ShowDialog();
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "UPDATE PrinterOrder SET PrinterOrderRefNumber ='" + referenceNumber + "', PrintOrderDate = '" + Date + "', PrintOrderDescription = '" + DescriptionForOrder + "', Quantity = '" + totalForOrder + "' WHERE PrinterOrderID =" + result + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  


                SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                SqlDataReader MyReader3;
                ConnectString.connectstring.Open();
                MyReader3 = MyCommand3.ExecuteReader();
                MessageBox.Show("Printer Order captured and stock quantity updated successfully.");
                ConnectString.connectstring.Close();
                this.Close();
                this.Dispose(true);
                Search_Printing_Supplier myform = new Search_Printing_Supplier();
                myform.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error occured returning to previous screen");
                ConnectString.connectstring.Close();
                Search_Printing_Supplier ww = new Search_Printing_Supplier();
                ww.ShowDialog();
            }
        }
    }
}
