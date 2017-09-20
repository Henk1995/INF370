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
        private void button2_Click(object sender, EventArgs e)
        {
            ConnectString.connectstring.Open();
            string Query = "INSERT INTO SupplierOrder(SupplierOrderRefNumber,SupplierOrderDate,SupplierOrderDescription,SupplierID,Total) values('" + this.txtRefNumber.Text + "','" + this.txtDate.Text + "','" + this.cbProduct.Text +"','"+ConnectString.SupplierID+"','"+Convert.ToUInt32(this.txtTotal.Text)+"')";
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
            MessageBox.Show(cbProduct.Text);
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
            MessageBox.Show("Order Captured");
            while (MyReader2.Read())
            {
            }
            ConnectString.connectstring.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
        }
    }
}
