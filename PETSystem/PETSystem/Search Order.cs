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
    public partial class Search_Order : Form
    {
        int antwoord;
        string x;
        DateTime endOfTime;
        Timer t;
        public Search_Order()
        {
            InitializeComponent();
        }

        int id;
        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        public static int ToUpdate;
        bool SearchISValid;


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            Select_Instructor si = new Select_Instructor();
            si.Show();
        }
        SqlDataAdapter DA;
        private void Search_Order_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT TableOrder.OrderID,TableOrder.Order_ReferenceNumber,Instructor.Name AS 'Instructor',TableOrder.OrderDescription,TableOrder.OrderDate,TableOrder.Total FROM TableOrder INNER JOIN Instructor ON Instructor.InstructorID = TableOrder.InstructorID", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvOrders.DataSource = DT;
            dgvOrders.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }

        private void tnViewOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedCells.Count > 0)
            {
                string OrderID;
                string OrderRefNumber, InstructorName, OrderDesc, Date, Total;

                // ConnectString.InstructorID = int.Parse(dgvOrders[0, selectedIndex].Value.ToString());
                OrderID = dgvOrders.SelectedRows[0].Cells[0].Value + string.Empty;
                OrderRefNumber = dgvOrders.SelectedRows[0].Cells[1].Value + string.Empty;
                InstructorName = dgvOrders.SelectedRows[0].Cells[2].Value + string.Empty;
                OrderDesc = dgvOrders.SelectedRows[0].Cells[3].Value + string.Empty;
                Date = dgvOrders.SelectedRows[0].Cells[4].Value + string.Empty;
                Total = dgvOrders.SelectedRows[0].Cells[5].Value + string.Empty;
                MessageBox.Show("Order ID: " + OrderID + "\nOrder Reference Number: " + OrderRefNumber + "\nInstructor Name: " + InstructorName + "\nOrder Description: " + OrderDesc + "\nOrder Date: " + Date + "\nOrder Total:R " + Total, "Notification");

                // MessageBox.Show(" Order ID: \t\t\t" + mOrderID + "\n Order reference Number: \t" + mOrderREF + "\n Order Description: \t\t" + mOrderDesc + "\n Order Date: \t\t" + mOrderDate + "\n Instructor Name: \t\t" + LoadInstructorName, "View Course",
                // MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Please Select a row to View");
            }
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnRefreshDGV_Click(object sender, EventArgs e)
        {
            dgvOrders.DataSource = null;
            var LoadOrders = from Order in db.TableOrders select Order;
            dgvOrders.DataSource = LoadOrders;
            dgvOrders.Update();
            dgvOrders.Refresh();
        }

        //private void btnReturnOder_Click(object sender, EventArgs e)
        //{
        //    //Log return stock ( damaged stock )


        //}

        //private void btnLogRefund_Click(object sender, EventArgs e)
        //{
        //    //Log refund ( money )


        //}

        //private void btnLogPayment_Click(object sender, EventArgs e)
        //{
        //    //Log payment to generate receipt


        //}

        //private void btnGenerateInvoice_Click(object sender, EventArgs e)
        //{
        //    // order invoice to instructor asking for payment
        //}

        //private void btnGenerateReceipt_Click(object sender, EventArgs e)
        //{
        //    // generate after payment is received
        //}

        private void txtSearchOrderID_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DataTable DTT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Filll = new SqlCommand("SELECT TableOrder.OrderID,TableOrder.Order_ReferenceNumber,Instructor.Name AS 'Instructor',TableOrder.OrderDescription,TableOrder.OrderDate FROM TableOrder INNER JOIN Instructor ON Instructor.InstructorID = TableOrder.InstructorID WHERE TableOrder.Order_ReferenceNumber Like '%" + txtSearchOrderID.Text + "%' ", ConnectString.connectstring);
                DA = new SqlDataAdapter(Filll);
                DA.Fill(DTT);
                dgvOrders.DataSource = DTT;
                dgvOrders.DataMember = DTT.TableName;
                ConnectString.connectstring.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DataTable DTTT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fillll = new SqlCommand("SELECT TableOrder.OrderID,TableOrder.Order_ReferenceNumber,Instructor.Name AS 'Instructor',TableOrder.OrderDescription,TableOrder.OrderDate FROM TableOrder INNER JOIN Instructor ON Instructor.InstructorID = TableOrder.InstructorID WHERE Instructor.Name Like '%" + txtSearchOrderID.Text + "%' ", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fillll);
                DA.Fill(DTTT);
                dgvOrders.DataSource = DTTT;
                dgvOrders.DataMember = DTTT.TableName;
                ConnectString.connectstring.Close();
            }
            else
            {
                DataTable DTTTT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Filllll = new SqlCommand("SELECT TableOrder.OrderID,TableOrder.Order_ReferenceNumber,Instructor.Name AS 'Instructor',TableOrder.OrderDescription,TableOrder.OrderDate FROM TableOrder INNER JOIN Instructor ON Instructor.InstructorID = TableOrder.InstructorID WHERE TableOrder.OrderDate Like '%" + txtSearchOrderID.Text + "%' ", ConnectString.connectstring);
                DA = new SqlDataAdapter(Filllll);
                DA.Fill(DTTTT);
                dgvOrders.DataSource = DTTTT;
                dgvOrders.DataMember = DTTTT.TableName;
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

        private void Search_Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }

        private void btnLogPayment_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedCells.Count > 0)
            {


                // ConnectString.InstructorID = int.Parse(dgvOrders[0, selectedIndex].Value.ToString());
                ConnectString.PaymentOrderID = dgvOrders.SelectedRows[0].Cells[0].Value + string.Empty;
                ConnectString.PaymentRefNumber = dgvOrders.SelectedRows[0].Cells[1].Value + string.Empty;
                ConnectString.PaymentinstructorName = dgvOrders.SelectedRows[0].Cells[2].Value + string.Empty;
                // OrderDesc = dgvOrders.SelectedRows[0].Cells[3].Value + string.Empty;
                // Date = dgvOrders.SelectedRows[0].Cells[4].Value + string.Empty;
                ConnectString.PaymentCost = dgvOrders.SelectedRows[0].Cells[5].Value + string.Empty;

                this.Close();
                this.Dispose(true);
                PaymentForm myform = new PaymentForm();
                myform.ShowDialog();
                // MessageBox.Show(" Order ID: \t\t\t" + mOrderID + "\n Order reference Number: \t" + mOrderREF + "\n Order Description: \t\t" + mOrderDesc + "\n Order Date: \t\t" + mOrderDate + "\n Instructor Name: \t\t" + LoadInstructorName, "View Course",
                // MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Please Select a row to View");
            }
        }

        private void btnReturnOder_Click(object sender, EventArgs e)
        {

        }


        private void btnLogRefund_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedCells.Count > 0)
            {
                //orderID
                string a = dgvOrders.SelectedRows[0].Cells[0].Value + string.Empty;
                // Kry Count van Order Line
                int CountOfOrders;
                SqlConnection cnnCount = new SqlConnection(ConnectString.DBC);
                cnnCount.Open();
                SqlCommand cmdCount = cnnCount.CreateCommand();
                cmdCount.CommandText = "Select COUNT(OrderID) from TableOrder Where OrderID = '" + a + "'";
                CountOfOrders = ((int)cmdCount.ExecuteScalar());

                cnnCount.Close();
                ConnectString.connectstring.Close();

                //Stocktype in stockline table
                SqlConnection connStcokTable = new SqlConnection(ConnectString.DBC);
                connStcokTable.Open();
                SqlCommand cmdStocktable = connStcokTable.CreateCommand();

                //Kry stock quantity in stock table
                SqlConnection convirMinus = new SqlConnection(ConnectString.DBC);
                convirMinus.Open();
                SqlCommand cmdvirMinus = convirMinus.CreateCommand();


                //toets

                // Update stock quantity String






                SqlConnection connNou = new SqlConnection(ConnectString.DBC);

                SqlDataReader ReaderStock;
                connNou.Open();
                ConnectString.connectstring.Open();

                // MessageBox.Show("Training Course successfully updated");
                // ConnectString.connectstring.Close();



                //Stockline stock ID connection
                //  get stock id


                // int SelectIDForDelete = dgvSuppOrder.SelectedRows[0].Index;


                string Queryyy = "Delete TOP (1) From OrderLine Where OrderID = '" + a + "' ";
                //This is  MySqlConnection here i have created the object and pass my connection string.  


                SqlCommand MyCommandzz = new SqlCommand(Queryyy, ConnectString.connectstring);
                SqlDataReader MyReaderzz;



                int quantitySum;


                SqlConnection lekercon = new SqlConnection(ConnectString.DBC);
                lekercon.Open();

                //Kry all die data 1 vir 1

                for (int i = 0; i < CountOfOrders; i++)
                {
                    //  MessageBox.Show("a");
                    SqlCommand lekkercmd = lekercon.CreateCommand();

                    lekkercmd.CommandText = "Select Quantity from OrderLine Where OrderID = '" + a + "'";
                    cmdStocktable.CommandText = "Select StockID FROM OrderLine Where OrderID = '" + a + "'";
                    x = a;
                    //int gebruikvirMinus = Convert.ToInt32(x);
                    x = ((int)cmdStocktable.ExecuteScalar()).ToString();
                    string z = a;
                    z = ((int)lekkercmd.ExecuteScalar()).ToString();
                    // MessageBox.Show(gebruikvirMinus.ToString());
                    cmdvirMinus.CommandText = "Select StockQuantity FROM Stock Where StockID = '" + x + "'";
                    string y = x;
                    y = ((int)cmdvirMinus.ExecuteScalar()).ToString();

                    //Maak som om stock te update

                    antwoord = Convert.ToInt32(y) + Convert.ToInt32(z);
                    MyReaderzz = MyCommandzz.ExecuteReader();
                    MyReaderzz.Close();
                    string QueryStock = "UPDATE Stock SET StockQuantity ='" + antwoord + "'WHERE StockID ='" + x + "'";
                    SqlCommand ComandStock = new SqlCommand(QueryStock, connNou);
                    ReaderStock = ComandStock.ExecuteReader();


                    ReaderStock.Close();

                }
                lekercon.Close();
                ConnectString.connectstring.Close();
                connStcokTable.Close();
                convirMinus.Close();
                connNou.Close();

                string Queryyyz = "Delete TOP (1) From TableOrder Where OrderID = '" + a + "' ";
                //This is  MySqlConnection here i have created the object and pass my connection string.  


                SqlCommand MyCommandzzz = new SqlCommand(Queryyyz, ConnectString.connectstring);
                SqlDataReader MyReaderzzz;
                ConnectString.connectstring.Open();
                MyReaderzzz = MyCommandzzz.ExecuteReader();
                ConnectString.connectstring.Close();

                MessageBox.Show("Stock Quantity has been updated and order has been removed");
                txtSearchOrderID.Text = "a";
                txtSearchOrderID.Text = "";

                //Remove Payment
                try
                {
                    string Queryyyzz = "Delete  From Payment Where OrderID = '" + a + "' ";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  


                    SqlCommand MyCommandzzzz = new SqlCommand(Queryyyzz, ConnectString.connectstring);
                    SqlDataReader MyReaderzzzz;
                    ConnectString.connectstring.Open();
                    MyReaderzzzz = MyCommandzzzz.ExecuteReader();
                    ConnectString.connectstring.Close();
                  //  MessageBox.Show("Payment removed", "notification");
                }
                catch
                {
                    MessageBox.Show("Payment was not removed as there was not payment made", "notification");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row to refund");
            }
        }



        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {

        }

    }
}