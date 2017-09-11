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


namespace Receive_Order
{
    public partial class ReceiveOrderSupp : Form
    {
        SqlDataAdapter DA;
        bool valid1 = false;
        bool valid3 = false;
        ErrorHandle EH = new ErrorHandle();
        public ReceiveOrderSupp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voorbeeldInstruDataSet.Supplier_Order' table. You can move, or remove it, as needed.
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM SupplierOrder", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvSupp.DataSource = DT;
            dgvSupp.DataMember = DT.TableName;
            ConnectString.connectstring.Close();

        }
        /**/
        private void button3_Click(object sender, EventArgs e)
        {
		 this.Close();
            Suppliers UM = new Suppliers();
            UM.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.CheckInt(textBox1.Text);
            bool validSQl = EH.checkForSQLInjection(textBox1.Text);
            if (valid3)
            {
                valid3 = validSQl;
            }
            if (!valid3)
            {
                textBox1.BackColor = Color.Red;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valid3)
            {
                string queryA = "SELECT * FROM SupplierOrder WHERE SupplierOrderID ='" + Convert.ToInt32(textBox1.Text) + "'";
                SqlCommand MyCommandA = new SqlCommand(queryA, ConnectString.connectstring);

                SqlDataAdapter DAA = new SqlDataAdapter(MyCommandA);
                DataTable DTA = new DataTable();
                DAA.Fill(DTA);
                ConnectString.connectstring.Open();
                if (DTA.Rows.Count == 1)
                {

                    valid1 = true;
                }
            }
            ConnectString.connectstring.Close();
            if (valid1)
            {
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM SupplierOrder WHERE SupplierOrderID ='" + Convert.ToInt32(textBox1.Text) + "'", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvSupp.DataSource = DT;
                dgvSupp.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddStock UM = new AddStock();
            UM.ShowDialog();
        }
    }
}
