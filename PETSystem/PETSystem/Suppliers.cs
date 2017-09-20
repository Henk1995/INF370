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
       
        SqlDataAdapter DA;
        public Suppliers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Select_Supplier.Select_Supplier PO = new Select_Supplier.Select_Supplier();
            PO.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Create_Supplier.Create_Supplier PO = new Create_Supplier.Create_Supplier();
            PO.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewSupplier PO = new ViewSupplier();
            PO.Show();
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

                SqlCommand MyCommand2 = new SqlCommand(Query, ConnectString.connectstring);
                SqlDataReader MyReader2;
                ConnectString.connectstring.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                ConnectString.connectstring.Close();

                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Supplier", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvInstructor.DataSource = DT;
                dgvInstructor.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }

            else
            {
                MessageBox.Show("Please select the row that you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            ReceiveOrderSupp PO = new ReceiveOrderSupp();
            PO.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnOrderSupp PO = new ReturnOrderSupp();
            PO.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Supplier.Search_Supplier PO = new Search_Supplier.Search_Supplier();
            PO.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT Supplier.SupplierID,Supplier.SupplierName,Supplier.SupplierAddress,Supplier.SupplierEmail,Supplier.SupplierPhoneNumber,Supplier.SupplierBankAccNumber,SupplierType.SupplierTypeName FROM Supplier INNER JOIN SupplierType ON SupplierType.SupplierTypeID = Supplier.SupplierTypeID", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            this.Close();
            RefundOrderSupp PO = new RefundOrderSupp();
            PO.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dgvInstructor.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvInstructor.SelectedRows[0].Index;

                // gets the RowID from the first column in the grid
                ConnectString.SupplierID = int.Parse(dgvInstructor[0, selectedIndex].Value.ToString());
                ConnectString.SupplierName = dgvInstructor.SelectedRows[0].Cells[1].Value + string.Empty;
                ConnectString.SupplierAddress = dgvInstructor.SelectedRows[0].Cells[2].Value + string.Empty;
                ConnectString.SupplierEmail = dgvInstructor.SelectedRows[0].Cells[3].Value + string.Empty;
                ConnectString.SupplierPhoneNum = dgvInstructor.SelectedRows[0].Cells[4].Value + string.Empty;
                ConnectString.SupplierBankAccount = int.Parse(dgvInstructor[5, selectedIndex].Value.ToString());
                ConnectString.Suppliertype = dgvInstructor.SelectedRows[0].Cells[6].Value + string.Empty;
                this.Close();
                Update_Supplier.Update_Supplier um = new Update_Supplier.Update_Supplier();
                um.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select the row you want to view");
            }
        }
    }
    }

