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


        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool SearchDValid;
        bool SearchIValid;
        


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

                MessageBox.Show("Searching " + stockDesc,"It Worked");
            }
        }

        private void btnSearchStockID_Click(object sender, EventArgs e)
        {
            
            string stockID = txtSearchStockID.Text;
            if (SearchIValid == false)
            {
                
                MessageBox.Show("The stock ID was not entered. Please enter the stock ID that you want to search and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                //Search in DB

                var searchID = from Stock in db.Stocks
                               where Stock.StockID == Convert.ToInt32(txtSearchStockID.Text)
                               select Stock;
                dgvSearchStock.DataSource = searchID;

                //MessageBox.Show("Searching " + stockID, "It Worked");
            }
        }

        private void txtSearchStockDesc_TextChanged(object sender, EventArgs e)
        {
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
        }

        private void txtSearchStockID_TextChanged(object sender, EventArgs e)
        {
            string stockID = txtSearchStockID.Text;
            txtSearchStockID.BackColor = Color.White;
            bool isInt = chk.CheckInt(stockID);
            bool notEmpty = chk.CheckEmpty(stockID);

            if (isInt == false)
            {
                txtSearchStockID.BackColor = Color.FromArgb(244, 17, 17);
                SearchIValid = false;
            }
            else if (notEmpty == false)
            {
                txtSearchStockID.BackColor = Color.FromArgb(244, 17, 17);
                SearchIValid = false;
            }
            else
            {
                txtSearchStockID.BackColor = Color.White;
                SearchIValid = true;
            }
        }

        private void btnWriteoffStock_Click(object sender, EventArgs e)
        {
            WriteoffStock f = new WriteoffStock();
            f.Show();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            AddStock a = new AddStock();
            a.ShowDialog();
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Are you sure you want to delete this stock item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (test == DialogResult.Yes)
            {
                MessageBox.Show("Stock item has been deleted", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (test == DialogResult.No)
            {
                MessageBox.Show("Stock item not deleted", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            ViewStock f = new ViewStock();
            f.Show();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            UpdateStock f = new UpdateStock();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_stock_item c = new Create_stock_item();
            c.ShowDialog();
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
            this.Visible = false;
            MainMenuF UM = new MainMenuF();
            UM.ShowDialog();
        }
    }
}
