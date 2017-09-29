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
    public partial class CaptureReceivePrinterOrderForm : Form
    {
        public CaptureReceivePrinterOrderForm()
        {
            InitializeComponent();
        }

        string referenceNumber;
        string Date;
        int totalForOrder;
        string DescriptionForOrder;
        int result, CBresult = 0;

        private void CaptureReceivePrinterOrderForm_Load(object sender, EventArgs e)
        {

            txtOrder.Text = "Order:";
            groupBox1.Visible = false;
            BtnCapture.Visible = false;

            //Get Order ID for OrderLine

            SqlConnection connection = new SqlConnection(ConnectString.DBC);
            connection.Open();
            SqlCommand cmdd = connection.CreateCommand();
            cmdd.CommandText = "Select MAX(SupplierOrderID) FROM SupplierOrder";
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
    }
}
