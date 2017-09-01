using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETSystem
{
    public partial class Search_Stock : Form
    {
        public Search_Stock()
        {
            InitializeComponent();
        }

        public static int ToUpdate;
        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool SearchDValid;
        bool SearchIValid;
        int id;


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
            
            //string stockID = txtSearchStockID.Text;
            //if (SearchIValid == false)
            //{
                
            //    MessageBox.Show("The stock ID was not entered. Please enter the stock ID that you want to search and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            //}
            //else
            //{
            //    //Search in DB

            //    var searchID = from Stock in db.Stocks
            //                   where Stock.StockID == Convert.ToInt32(txtSearchStockID.Text)
            //                   select Stock;
            //    dgvSearchStock.DataSource = searchID;

            //    //MessageBox.Show("Searching " + stockID, "It Worked");
            //}
        }

        private void txtSearchStockDesc_TextChanged(object sender, EventArgs e)
        {
            //txtSearchStockID.Clear();
            txtSearchStockDesc.BackColor = Color.White;
            string stockDesc = txtSearchStockDesc.Text;
            bool isString = chk.Checkstring(stockDesc);
            bool notEmpty = chk.CheckEmpty(stockDesc);

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
            else
            {
                txtSearchStockDesc.BackColor = Color.White;
                SearchDValid = true;
            }

            if (SearchDValid == true)
            {
                var searchDesc = from Stock in db.Stocks
                                 where Stock.StockDescription.Contains(txtSearchStockDesc.Text)
                                 select Stock;
                dgvSearchStock.DataSource = searchDesc;
                dgvSearchStock.Refresh();
            }
            else
            {
                dgvSearchStock.DataSource = null;
                var S = from Stock in db.Stocks select Stock;
                dgvSearchStock.DataSource = S;
                dgvSearchStock.Update();
                dgvSearchStock.Refresh();
            }



        }

        private void txtSearchStockID_TextChanged(object sender, EventArgs e)
        {
           // txtSearchStockDesc.Clear();


            //string stockID = txtSearchStockID.Text;
            //txtSearchStockID.BackColor = Color.White;
            //bool isInt = chk.CheckInt(stockID);
            //bool notEmpty = chk.CheckEmpty(stockID);

            //if (isInt == false)
            //{
            //    txtSearchStockID.BackColor = Color.FromArgb(244, 17, 17);
            //    SearchIValid = false;
            //}
            //else if (notEmpty == false)
            //{
            //    txtSearchStockID.BackColor = Color.FromArgb(244, 17, 17);
            //    SearchIValid = false;
            //}
            //else
            //{
            //    txtSearchStockID.BackColor = Color.White;
            //    SearchIValid = true;
            //}

            //if (SearchDValid == true)
            //{
            //    var searchID = from Stock in db.Stocks
            //                   where Stock.StockID == Convert.ToInt32(txtSearchStockID.Text)
            //                   select Stock;
            //    dgvSearchStock.DataSource = searchID;
            //    dgvSearchStock.Update();
            //    dgvSearchStock.Refresh();
            //}
            //else
            //{
            //    dgvSearchStock.DataSource = null;
            //    var S = from Stock in db.Stocks select Stock;
            //    dgvSearchStock.DataSource = S;
            //    dgvSearchStock.Update();
            //    dgvSearchStock.Refresh();
            //}
            
        }

        private void btnWriteoffStock_Click(object sender, EventArgs e)
        {
            this.Close();
            WriteoffStock f = new WriteoffStock();
            f.Show();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            this.Close();
            AddStock a = new AddStock();
            a.ShowDialog();
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Are you sure you want to delete this stock item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (test == DialogResult.Yes)
            {

                //Delete Selected
                var mStock = (from x in db.Stocks where x.StockID == id select x).First();
                db.Stocks.DeleteOnSubmit(mStock);
                db.SubmitChanges();

                //refresh DGV
                dgvSearchStock.DataSource = null;
                dgvSearchStock.DataSource = db.Stocks;

                MessageBox.Show("Stock item has been deleted", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (test == DialogResult.No)
            {
                MessageBox.Show("Stock item not deleted", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            //ViewStock f = new ViewStock();
            //f.Show();

            if (dgvSearchStock.SelectedCells.Count > 0)
            {
                Stock _PS = (Stock)dgvSearchStock.CurrentRow.DataBoundItem;
                int psID = _PS.StockID;
                string psName = _PS.StockDescription;
                int psAddr = Convert.ToInt32(_PS.StockUnitPrice);
                int psEmail = _PS.StockTypeID;
                int psPhone = Convert.ToInt32(_PS.StockQuantity);
                
                MessageBox.Show("Stock ID: " + psID + "\n Stock Name: " + psName + "\n Unit Price: " + psAddr + "\n Stock Type: " + psEmail + "\n Stock Quantity: " + psPhone, "View Course",
    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdateStock f = new UpdateStock();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Create_stock_item c = new Create_stock_item();
            c.Show();
        }

        private void Search_Stock_Load(object sender, EventArgs e)
        {
            //Pre loads all the data from the printing supplier table
            var S = from Stock in db.Stocks select Stock;
            dgvSearchStock.DataSource = S;
            dgvSearchStock.Refresh();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }

        private void dgvSearchStock_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSearchStock.SelectedCells.Count > 0)
            {
                Stock _Stock = (Stock)dgvSearchStock.CurrentRow.DataBoundItem;
                id = _Stock.StockID;
                ToUpdate = id;
            }
        }

        private void btnRefreshDGV_Click(object sender, EventArgs e)
        {
            dgvSearchStock.DataSource = null;
            var S = from Stock in db.Stocks select Stock;
            dgvSearchStock.Update();
            dgvSearchStock.DataSource = S;
            dgvSearchStock.Refresh();
        }
    }
}
