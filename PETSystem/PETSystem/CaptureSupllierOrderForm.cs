using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
     

namespace PETSystem
{
    public partial class CaptureSupllierOrderForm : Form
    {
        public CaptureSupllierOrderForm()
        {
            InitializeComponent();
        }
        string referenceNumber;
        string Date;
        int totalForOrder;
        string DescriptionForOrder;
        private void button2_Click(object sender, EventArgs e)
        {
            string Query = "UPDATE SupplierOrder SET SupplierOrderRefNumber ='" + referenceNumber + "', SupplierOrderDate = '" + Date + "', SupplierOrderDescription = '" + DescriptionForOrder + "', Total = '" + totalForOrder + "' WHERE SupplierOrderID =" + result + ";";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
           

                SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                SqlDataReader MyReader3;
                ConnectString.connectstring.Open();
                MyReader3 = MyCommand3.ExecuteReader();
                MessageBox.Show("Training Course successfully updated");
                ConnectString.connectstring.Close();
                this.Close();
                this.Dispose(true);
                MaintainCourses myform = new MaintainCourses();
                myform.ShowDialog();
            
        }
        int result, CBresult = 0;
        private void CaptureSupllierOrderForm_Load(object sender, EventArgs e)
        {
            
            txtOrder.Text = "Order:";
            groupBox1.Visible = false;
            BtnCapture.Visible = false;

            //Get Order ID for OrderLine

            SqlConnection connection = new SqlConnection(ConnectString.DBC);
            connection.Open();
            SqlCommand cmdd = connection.CreateCommand();
            cmdd.CommandText =  "Select MAX(SupplierOrderID) FROM SupplierOrder";
             result = ((int)cmdd.ExecuteScalar());
            result = result+1;
            
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

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(cbProduct.Text);
            SqlConnection connection2 = new SqlConnection(ConnectString.DBC);
            connection2.Open();
            SqlCommand cmdd2 = connection2.CreateCommand();
            cmdd2.CommandText = "Select StockID FROM Stock Where StockDescription ='" + cbProduct.Text + "'";
            CBresult = ((int)cmdd2.ExecuteScalar());


            connection2.Close();
         //   MessageBox.Show(cbProduct.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            referenceNumber = txtRefNumber.Text;
            Date = txtDate.Text;

            // Add new order as placeholder for Stock line
            int stockID = cbProduct.SelectedIndex + 1;
            BtnCapture.Visible = true;

            //Add product in StockLine sodat dit 3rdNormalFormis
            ConnectString.connectstring.Open();
            string Query = "INSERT INTO SupplierOrder(SupplierID) values('" + ConnectString.SupplierID + "')";
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
            txtOrder.Text = txtOrder.Text +"Order Reference Number: "+referenceNumber+ "            Date: "+Date;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ConnectString.ActiveForm = true;
            Create_stock_item myform = new Create_stock_item();
            myform.ShowDialog();
        }

        private void cbProduct_Click(object sender, EventArgs e)
        {
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
        int UsethisforStockUpdate;
        private void button3_Click(object sender, EventArgs e)
        {
            BtnBack.Enabled = false;
            int stockID = cbProduct.SelectedIndex + 1;
            BtnCapture.Visible = true;

            //Add product in StockLine sodat dit 3rdNormalFormis
            ConnectString.connectstring.Open();
            string Query = "INSERT INTO StockLine(SupplierOrderID,SupplierID,PrinterOrderID,PrinterID,StockID,Quantity) values('" + result + "','" + ConnectString.SupplierID + "',NULL,NULL,'" + CBresult + "','" +NUPQuantity.Value  + "')";
            //This is  MySqlConnection here i have created the object and pass my connection string.  

            //This is command class which will handle the query and connection object.  
            SqlCommand MyCommand2 = new SqlCommand(Query, ConnectString.connectstring);
            SqlDataReader MyReader2;

            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            MessageBox.Show("Order Captured");
            while (MyReader2.Read())
            {
            }
            ConnectString.connectstring.Close();
          //Rich edit update
            int unitPrice;
            unitPrice = Convert.ToInt32(txtTotal.Text) / Convert.ToInt32(NUPQuantity.Value);
            txtOrder.Text = txtOrder.Text + "\nProduct: "+cbProduct.Text +"\nQuantity: "+ Convert.ToString(NUPQuantity.Value)+"\nUnit Price R.: "+unitPrice+"Total R.: "+txtTotal.Text;
            //add description en total
            DescriptionForOrder = DescriptionForOrder + cbProduct.Text+",";
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

            string QueryStock = "UPDATE Stock SET StockQuantity ='"+UsethisforStockUpdate+"' WHERE StockID ='" + CBresult+ "'";
  


            SqlCommand ComandStock = new SqlCommand(QueryStock, ConnectString.connectstring);
            SqlDataReader ReaderStock;
            ConnectString.connectstring.Open();
            ReaderStock = ComandStock.ExecuteReader();
            MessageBox.Show("Training Course successfully updated");
            ConnectString.connectstring.Close();
           

        }
    }
}
