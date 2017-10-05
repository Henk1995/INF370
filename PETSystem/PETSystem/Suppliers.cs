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
        DateTime endOfTime;
        Timer t;
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
            //Search Field
            ToolTip TTFIeld = new ToolTip();
            TTFIeld.ToolTipTitle = "Search Field";
            TTFIeld.UseFading = true;
            TTFIeld.UseAnimation = true;
            TTFIeld.IsBalloon = true;
            TTFIeld.SetToolTip(comboBox1, "Select a field to search.");
            //SearchText
            ToolTip TTSearchte = new ToolTip();
            TTSearchte.ToolTipTitle = "Search Text";
            TTSearchte.UseFading = true;
            TTSearchte.UseAnimation = true;
            TTSearchte.IsBalloon = true;
            TTSearchte.SetToolTip(txtRefresh, "Enter text to search for.");
            //Place Order
            ToolTip TTPalce = new ToolTip();
            TTPalce.ToolTipTitle = "Place Order";
            TTPalce.UseFading = true;
            TTPalce.UseAnimation = true;
            TTPalce.IsBalloon = true;
            TTPalce.SetToolTip(button1, "Select a supplier from the list and\n click here to place an order.");
            //Create Supplier
            ToolTip TTcreate = new ToolTip();
            TTcreate.ToolTipTitle = "Create Suppleir";
            TTcreate.UseFading = true;
            TTcreate.UseAnimation = true;
            TTcreate.IsBalloon = true;
            TTcreate.SetToolTip(button2, "Click here if you want to add a new supplier to the system.");
            //Update Supplier
            ToolTip TtUp = new ToolTip();
            TtUp.ToolTipTitle = "Update Suppleir";
            TtUp.UseFading = true;
            TtUp.UseAnimation = true;
            TtUp.IsBalloon = true;
            TtUp.SetToolTip(button4, "Select a supplier from the list and/click here to update.");
            //Delete Supplier
            ToolTip TTDelete = new ToolTip();
            TTDelete.ToolTipTitle = "Delete Suppleir";
            TTDelete.UseFading = true;
            TTDelete.UseAnimation = true;
            TTDelete.IsBalloon = true;
            TTDelete.SetToolTip(button5, "Select a supplier from the list and/click here to delete.");
            //Recieve ORder
            ToolTip TTrevieve = new ToolTip();
            TTrevieve.ToolTipTitle = "Recieve order";
            TTrevieve.UseFading = true;
            TTrevieve.UseAnimation = true;
            TTrevieve.IsBalloon = true;
            TTrevieve.SetToolTip(button6, "Select a supplier from the list and/click here to log the recieved order.");
            //Return Order
            ToolTip TTreturn = new ToolTip();
            TTreturn.ToolTipTitle = "Return Order";
            TTreturn.UseFading = true;
            TTreturn.UseAnimation = true;
            TTreturn.IsBalloon = true;
            TTreturn.SetToolTip(button9, "Select a supplier from the list and/click here to return a order that has been recieved.");
            //Refund Order
            ToolTip TTrefund = new ToolTip();
            TTrefund.ToolTipTitle = "Refund Order";
            TTrefund.UseFading = true;
            TTrefund.UseAnimation = true;
            TTrefund.IsBalloon = true;
            TTrefund.SetToolTip(btnRefund, "Select a supplier from the list and/click here to refund a order that has been recieved.");
            //Back
            ToolTip TtBack = new ToolTip();
            TtBack.ToolTipTitle = "Back";
            TtBack.UseFading = true;
            TtBack.UseAnimation = true;
            TtBack.IsBalloon = true;
            TtBack.SetToolTip(button8, "Click here to retun to previous screen");

            comboBox1.SelectedIndex = 0;
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            //Maak refresh textbox invis
            //  txtRefresh.Visible = false;

            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT Supplier.SupplierID,Supplier.SupplierName AS 'Name',Supplier.SupplierAddress AS 'Address',Supplier.SupplierEmail AS 'Email',Supplier.SupplierPhoneNumber AS 'Phone number',Supplier.SupplierBankAccNumber AS 'Bank Account Number',SupplierType.SupplierTypeName AS 'Type' FROM Supplier INNER JOIN SupplierType ON SupplierType.SupplierTypeID = Supplier.SupplierTypeID", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (dgvInstructor.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvInstructor.SelectedRows[0].Index;
                ConnectString.SupplierName = dgvInstructor.SelectedRows[0].Cells[1].Value + string.Empty;
                // gets the RowID from the first column in the grid
                ConnectString.SupplierID = int.Parse(dgvInstructor[0, selectedIndex].Value.ToString());
                this.Close();
                this.Dispose(true);
                RefundOrderSupp PO = new RefundOrderSupp();
                PO.Show();
            }
            else {
                MessageBox.Show("Please Select a row to return a order to");
            }
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
            if (comboBox1.SelectedIndex == 0)
            {
                ConnectString.connectstring.Close();
                DataTable DTX = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand FillX = new SqlCommand("SELECT Supplier.SupplierID,Supplier.SupplierName AS 'Name',Supplier.SupplierAddress AS 'Address',Supplier.SupplierEmail AS 'Email',Supplier.SupplierPhoneNumber AS 'Phone number',Supplier.SupplierBankAccNumber AS 'Bank Account Number',SupplierType.SupplierTypeName AS 'Type' FROM Supplier INNER JOIN SupplierType ON SupplierType.SupplierTypeID = Supplier.SupplierTypeID WHERE Supplier.SupplierName like '%" + txtRefresh.Text + "%'", ConnectString.connectstring);
                SqlDataAdapter DAX = new SqlDataAdapter(FillX);
                DAX.Fill(DTX);
                dgvInstructor.DataSource = DTX;
                dgvInstructor.DataMember = DTX.TableName;
                txtRefresh.BackColor = Color.White;
                ConnectString.connectstring.Close();
            }
            else
            {
                ConnectString.connectstring.Close();
                DataTable DTX = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand FillX = new SqlCommand("SELECT Supplier.SupplierID,Supplier.SupplierName AS 'Name',Supplier.SupplierAddress AS 'Address',Supplier.SupplierEmail AS 'Email',Supplier.SupplierPhoneNumber AS 'Phone number',Supplier.SupplierBankAccNumber AS 'Bank Account Number',SupplierType.SupplierTypeName AS 'Type' FROM Supplier INNER JOIN SupplierType ON SupplierType.SupplierTypeID = Supplier.SupplierTypeID WHERE Supplier.SupplierEmail like '%" + txtRefresh.Text + "%'", ConnectString.connectstring);
                SqlDataAdapter DAX = new SqlDataAdapter(FillX);
                DAX.Fill(DTX);
                dgvInstructor.DataSource = DTX;
                dgvInstructor.DataMember = DTX.TableName;
                txtRefresh.BackColor = Color.White;
                ConnectString.connectstring.Close();
            }
            
          
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

        private void Suppliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
    }

