using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace PETSystem
{
    public partial class Search_Stock : Form
    {
        DateTime endOfTime;
        Timer t;
        public Search_Stock()
        {
            InitializeComponent();
        }

        public static int StockToUpdate;
        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool SearchDValid;
        bool SearchIValid;
        int id;
        int QuantityOnHand;
        SqlDataAdapter DA;

        private void btnSearcStockDesc_Click(object sender, EventArgs e)
        {
            string stockDesc = txtSearchStockDesc.Text;
            if (SearchDValid == false)
            {
                MessageBox.Show("The stock description was not entered. Please enter the stock description that you want to search and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {

                //Search in db
                var searchDesc = from Stock in db.Stocks
                               where Stock.StockDescription == txtSearchStockDesc.Text
                               select Stock;
                dgvSearchStock.DataSource = searchDesc;

               //MessageBox.Show("Searching " + stockDesc,"It Worked");
            }
        }

        private void btnSearchStockID_Click(object sender, EventArgs e)
        {
            
          
        }

        private void txtSearchStockDesc_TextChanged(object sender, EventArgs e)
        {
            txtSearchStockDesc.BackColor = Color.White;
            string stockDesc = txtSearchStockDesc.Text;
            bool isString = chk.Checkstring(stockDesc);
            bool notEmpty = chk.CheckEmpty(stockDesc);
            bool checkForSQLInjection = chk.checkForSQLInjection(stockDesc);

            if (isString == false)
            {
                txtSearchStockDesc.BackColor = Color.FromArgb(244, 17, 17);
                SearchDValid = false;
            }
            else if (notEmpty == false)
            {
                txtSearchStockDesc.BackColor = Color.FromArgb(244, 17, 17);
                SearchDValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                txtSearchStockDesc.BackColor = Color.FromArgb(244, 17, 17);
                SearchDValid = false;
            }
            else
            {
                txtSearchStockDesc.BackColor = Color.White;
                SearchDValid = true;
            }

            if (SearchDValid == true)
            {
                //var searchDesc = from Stock in db.Stocks
                //                 where Stock.StockDescription.Contains(txtSearchStockDesc.Text)
                //                 select Stock;
                //dgvSearchStock.DataSource = searchDesc;
                //dgvSearchStock.Refresh();

                //SELECT UserTable.UserID,UserTable.Name,UserTable.Surname,UserTable.UserName,UserTable.UserPassword,UserTable.Email,PrivilegeType.PrivName FROM UserTable INNER JOIN PrivilegeType ON PrivilegeType.PrivilegeID = UserTable.PriveledgeID where Name like '%" + textBox1.Text + "%'", ConnectString.connectstring

                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT Stock.StockID, Stock.StockDescription, Stock.StockUnitPrice, Stock.StockQuantity, dbo.StockType.StockName FROM Stock INNER JOIN dbo.StockType ON StockType.StockTypeID = Stock.StockTypeID WHERE Stock.StockDescription like '%" + txtSearchStockDesc.Text + "%'" , ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvSearchStock.DataSource = DT;
                dgvSearchStock.DataMember = DT.TableName;
                ConnectString.connectstring.Close();

            }
            else
            {
                //dgvSearchStock.DataSource = null;
                //var S = from Stock in db.Stocks select Stock;
                //dgvSearchStock.DataSource = S;
                //dgvSearchStock.Update();
                //dgvSearchStock.Refresh();
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT Stock.StockID, Stock.StockDescription, Stock.StockUnitPrice, Stock.StockQuantity, dbo.StockType.StockName FROM Stock INNER JOIN dbo.StockType ON StockType.StockTypeID = Stock.StockTypeID", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvSearchStock.DataSource = DT;
                dgvSearchStock.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }



        }

        private void txtSearchStockID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnWriteoffStock_Click(object sender, EventArgs e)
        {
            if (dgvSearchStock.SelectedRows.Count > 0)
            {

                StockToUpdate = Convert.ToInt32(dgvSearchStock.SelectedRows[0].Cells[0].Value);
                this.Close();
                WriteoffStock f = new WriteoffStock();
                f.Show();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }

            
        }


        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            if (dgvSearchStock.SelectedRows.Count > 0)
            {
                bool HasQuantity;
                int StockOnHand = Convert.ToInt32(dgvSearchStock.SelectedRows[0].Cells[3].Value);


                //string GetQuantity = "Select Stock.StockQuantity from dbo.Stock Where StockID = '" + dgvSearchStock.SelectedRows[0].Cells[0].Value + "'";


                if (QuantityOnHand > 0)
                {
                    HasQuantity = true;
                }
                else
                {
                    HasQuantity = false;
                }



                if (HasQuantity == false)
                {
                    MessageBox.Show("Stock cannot be deleted because there is still stock on hand of this specific stock item", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string Query = "Delete Stock Where StockID = '" + dgvSearchStock.SelectedRows[0].Cells[0].Value + "'";
                    DialogResult answer = MessageBox.Show("Are you sure you want to Delete this StockItem?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (answer == DialogResult.Yes)
                    {
                        SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                        SqlDataReader MyReader3;
                        ConnectString.connectstring.Open();
                        MyReader3 = MyCommand3.ExecuteReader();
                        MessageBox.Show("Stock Item successfully Deleted");
                        ConnectString.connectstring.Close();
                        //Refresh DGV
                        txtSearchStockDesc.Text = "a";
                        txtSearchStockDesc.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Stock Item was not deleted");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to Delete");
            }


            //DialogResult test = MessageBox.Show("Are you sure you want to delete this stock item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (test == DialogResult.Yes)
            //{
            //    bool HasQuantity;

            //    if (QuantityOnHand > 0)
            //    {
            //        HasQuantity = true;
            //    }
            //    else
            //    {
            //        HasQuantity = false;
            //    }

            //    if (HasQuantity == true)
            //    {
            //        MessageBox.Show("Stock cannot be deleted because there is still stock on hand of this specific stock item", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        //Delete Selected
            //        var mStock = (from x in db.Stocks where x.StockID == id select x).First();
            //        db.Stocks.DeleteOnSubmit(mStock);
            //        db.SubmitChanges();

            //        //refresh DGV
            //        dgvSearchStock.DataSource = null;
            //        dgvSearchStock.DataSource = db.Stocks;

            //        MessageBox.Show("Stock item has been deleted", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else if (test == DialogResult.No)
            //{
            //    MessageBox.Show("Stock item not deleted", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            //if (dgvSearchStock.SelectedCells.Count > 0)
            //{
                //Stock _PS = (Stock)dgvSearchStock.CurrentRow.DataBoundItem;
                //int psID = _PS.StockID;
                //string psName = _PS.StockDescription;
                //int psAddr = Convert.ToInt32(_PS.StockUnitPrice);
                //int psStockType = _PS.StockTypeID;
                //int psPhone = Convert.ToInt32(_PS.StockQuantity);

                //var getTypetoView = (from StockType in db.StockTypes where StockType.StockTypeID == psStockType select StockType.StockName).FirstOrDefault();

                //string LoadStockTypeName = getTypetoView;

//                if (dgvSearchStock.SelectedRows.Count > 0)
//                {

//                    int GetStockID = Convert.ToInt32(dgvSearchStock.SelectedRows[0].Cells[0].Value);

//                DataTable DT = new DataTable();
//                ConnectString.connectstring.Open();
//                SqlCommand Fill = new SqlCommand("SELECT Stock.StockID, Stock.StockDescription, Stock.StockUnitPrice, Stock.StockQuantity, dbo.StockType.StockName FROM Stock INNER JOIN dbo.StockType ON StockType.StockTypeID = Stock.StockTypeID Where Stock.StockID like '%" + dgvSearchStock.SelectedRows[0].Cells[0].Value + "%'", ConnectString.connectstring);

//                int psID = Fill.StockID;
//                string psName = _PS.StockDescription;
//                int psAddr = Convert.ToInt32(_PS.StockUnitPrice);
//                int psStockType = _PS.StockTypeID;
//                int psPhone = Convert.ToInt32(_PS.StockQuantity);

//                MessageBox.Show(" Stock ID: \t\t" + psID + "\n Stock Name: \t" + psName + "\n Unit Price: \t" + psAddr + "\n Stock Type: \t" + LoadStockTypeName + "\n Stock Quantity: \t" + psPhone, "View Course",
//MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

//                ConnectString.connectstring.Close();


                
//            }
//                else
//                {
//                    MessageBox.Show("Please select a row");
//                }



                
            }
        

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (dgvSearchStock.SelectedRows.Count > 0)
            {

                StockToUpdate = Convert.ToInt32(dgvSearchStock.SelectedRows[0].Cells[0].Value);
                this.Close();
                UpdateStock US = new UpdateStock();
                US.Show();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }



            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Create_stock_item c = new Create_stock_item();
            c.Show();
        }

        private void Search_Stock_Load(object sender, EventArgs e)
        {
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            ////Pre loads all the data from the printing supplier table
            //var S = from Stock in db.Stocks select Stock;
            //dgvSearchStock.DataSource = S;
            //dgvSearchStock.Refresh();

            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT Stock.StockID, Stock.StockDescription, Stock.StockUnitPrice, Stock.StockQuantity, dbo.StockType.StockName FROM Stock INNER JOIN dbo.StockType ON StockType.StockTypeID = Stock.StockTypeID", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvSearchStock.DataSource = DT;
            dgvSearchStock.DataMember = DT.TableName;
            ConnectString.connectstring.Close();


        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }

        private void dgvSearchStock_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvSearchStock.SelectedCells.Count > 0)
            //{
            //    Stock _Stock = (Stock)dgvSearchStock.CurrentRow.DataBoundItem;
            //    id = _Stock.StockID;
            //    QuantityOnHand = Convert.ToInt32(_Stock.StockQuantity);
            //    StockToUpdate = id;
            //}
        }

        private void btnRefreshDGV_Click(object sender, EventArgs e)
        {
            dgvSearchStock.DataSource = null;
            var S = from Stock in db.Stocks select Stock;
            dgvSearchStock.Update();
            dgvSearchStock.DataSource = S;
            dgvSearchStock.Refresh();
        }

        private void dgvSearchStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void Search_Stock_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
