using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (dgvInstructor.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvInstructor.SelectedRows[0].Index;
                ConnectString.SupplierName = dgvInstructor.SelectedRows[0].Cells[1].Value + string.Empty;
                // gets the RowID from the first column in the grid
                ConnectString.SupplierID = int.Parse(dgvInstructor[0, selectedIndex].Value.ToString());
                this.Close();
                this.Dispose(true);
                PlaceSupplierOrder myform = new PlaceSupplierOrder();
                myform.Show();
            }
            else
            {
                MessageBox.Show("Please select the row you want to view");
            }

            
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
            try
            {
                if (dgvInstructor.SelectedRows.Count > 0)
                {
                    string Query = "Delete Supplier Where SupplierID = '" + dgvInstructor.SelectedRows[0].Cells[0].Value + "'";
                    DialogResult answer = MessageBox.Show("Are you sure you want to Delete this Supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (answer == DialogResult.Yes)
                    {
                        SqlCommand MyCommandZ = new SqlCommand(Query, ConnectString.connectstring);
                        SqlDataReader MyReaderZ;
                        ConnectString.connectstring.Open();
                        MyReaderZ = MyCommandZ.ExecuteReader();
                        MessageBox.Show("Supplier  successfully removed");
                        ConnectString.connectstring.Close();
                        //Refresh DGV
                        txtRefresh.Text = "a";
                        txtRefresh.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Supplier was not deleted");
                        ConnectString.connectstring.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to Delete");
                    ConnectString.connectstring.Close();
                }
            }
            catch { MessageBox.Show("This Supplier has current orders and can not be deleted until the corresponding order is removed");
                ConnectString.connectstring.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvInstructor.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvInstructor.SelectedRows[0].Index;
                ConnectString.SupplierName = dgvInstructor.SelectedRows[0].Cells[1].Value + string.Empty;
                // gets the RowID from the first column in the grid
                ConnectString.SupplierID = int.Parse(dgvInstructor[0, selectedIndex].Value.ToString());
                this.Close();
                this.Dispose(true);
                CaptureSupllierOrderForm PO = new CaptureSupllierOrderForm();
                PO.Show();
            }
            else{
                MessageBox.Show("Please Select a row to recieve an order from");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dgvInstructor.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvInstructor.SelectedRows[0].Index;
                ConnectString.SupplierName = dgvInstructor.SelectedRows[0].Cells[1].Value + string.Empty;
                // gets the RowID from the first column in the grid
                ConnectString.SupplierID = int.Parse(dgvInstructor[0, selectedIndex].Value.ToString());
                this.Close();
                this.Dispose(true);
                ReturnOrderSupp PO = new ReturnOrderSupp();
                PO.Show();
            }
            else {
                MessageBox.Show("Please Select a row to return a order to");
            }
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
            //Maak refresh textbox invis
          //  txtRefresh.Visible = false;

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

        private void txtRefresh_TextChanged(object sender, EventArgs e)
        {
            
                DataTable DTX = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand FillX = new SqlCommand("SELECT Supplier.SupplierID,Supplier.SupplierName,Supplier.SupplierAddress,Supplier.SupplierEmail,Supplier.SupplierPhoneNumber,Supplier.SupplierBankAccNumber,SupplierType.SupplierTypeName FROM Supplier INNER JOIN SupplierType ON SupplierType.SupplierTypeID = Supplier.SupplierTypeID WHERE Supplier.SupplierName like '%" + txtRefresh.Text + "%'", ConnectString.connectstring);
                SqlDataAdapter DAX = new SqlDataAdapter(FillX);
                DAX.Fill(DTX);
                dgvInstructor.DataSource = DTX;
                dgvInstructor.DataMember = DTX.TableName;
                txtRefresh.BackColor = Color.White;
                ConnectString.connectstring.Close();
            
          
        }
    }
    }

