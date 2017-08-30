using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Place_Order;
using Return_Order;
using Refund_Order;
using Receive_Order;
using Search_Supplier;
using Select_Supplier;
using Create_Supplier;
using View_Supplier;
using Update_Supplier;
using Delete_Supplier;
using System.Data.SqlClient;

namespace PETSystem
{
    public partial class Suppliers : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        SqlDataAdapter DA;
        public Suppliers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Select_Supplier.Select_Supplier PO = new Select_Supplier.Select_Supplier();
            PO.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Create_Supplier.Create_Supplier PO = new Create_Supplier.Create_Supplier();
            PO.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ViewSupplier PO = new ViewSupplier();
            PO.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Update_Supplier.Update_Supplier PO = new Update_Supplier.Update_Supplier();
            PO.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //Delete_Supplier.Delete_Supplier PO = new Delete_Supplier.Delete_Supplier();
            //PO.ShowDialog();
            if (dgvInstructor.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvInstructor.SelectedRows[0].Index;

                // gets the RowID from the first column in the grid
                int rowID = int.Parse(dgvInstructor[0, selectedIndex].Value.ToString());


                 MessageBox.Show("Are you sure you want to delete this instructor?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                string Query = "DELETE FROM Supplier WHERE SupplierID='" + rowID + "';";

                SqlCommand MyCommand2 = new SqlCommand(Query, connectstring);
                SqlDataReader MyReader2;
                connectstring.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                connectstring.Close();

                DataTable DT = new DataTable();
                connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Supplier", connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvInstructor.DataSource = DT;
                dgvInstructor.DataMember = DT.TableName;
                connectstring.Close();
            }

            else
            {
                MessageBox.Show("Please select the row that you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ReceiveOrderSupp PO = new ReceiveOrderSupp();
            PO.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           ReturnOrderSupp PO = new ReturnOrderSupp();
            PO.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Search_Supplier.Search_Supplier PO = new Search_Supplier.Search_Supplier();
            PO.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenuF UM = new MainMenuF();
            UM.ShowDialog();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Supplier", connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            connectstring.Close();
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RefundOrderSupp PO = new RefundOrderSupp();
            PO.ShowDialog();
        }
    }
}
