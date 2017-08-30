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
using PETSystem;

namespace Select_Supplier
{
    public partial class Select_Supplier : Form
    {
        int supplier = 0;
        SqlDataAdapter DA;
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        public Select_Supplier()
        {
            InitializeComponent();
        }

        private void Select_Supplier_Load(object sender, EventArgs e)
        {
            cmbSupplier.Items.Clear();


            string query1 = "SELECT SupplierName FROM Supplier ";
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand cmd = new SqlCommand(query1, connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                cmbSupplier.Items.Add(dr["SupplierName"]).ToString();
            }
            connectstring.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query4 = "SELECT SupplierID FROM Supplier WHERE SupplierName ='" + cmbSupplier.Text + "'";
            SqlCommand MyCommand4 = new SqlCommand(query4, connectstring);
            SqlDataReader MyReader4;
            connectstring.Open();
            MyReader4 = MyCommand4.ExecuteReader();     // Here our query will be executed and data saved into the database.  

            while (MyReader4.Read())
            {
                supplier = Convert.ToInt32(MyReader4["SupplierID"]);
            }
            connectstring.Close();
            
            this.Visible = false;
            Place_Order.PlaceOrder PO = new Place_Order.PlaceOrder(supplier);
            PO.ShowDialog();
        }
    }
}
