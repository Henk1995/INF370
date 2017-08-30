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
    public partial class Create_stock_item : Form
    {
        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool stockDValid;
        bool unitPValid;


        public Create_stock_item()
        {
            InitializeComponent();
        }
        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            txtDesc.BackColor = Color.White;
            string stockDesc = txtDesc.Text;
            bool isString = chk.Checkstring(stockDesc);
            bool notEmpty = chk.CheckEmpty(stockDesc);

            if (isString == false)
            {
                txtDesc.BackColor = Color.FromArgb(244, 17, 17);
                stockDValid = false;
            }
            else if (notEmpty == false)
            {
                txtDesc.BackColor = Color.FromArgb(244, 17, 17);
                stockDValid = false;
            }
            else
            {
                txtDesc.BackColor = Color.White;
                stockDValid = true;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtPrice.BackColor = Color.White;
            string UnitPrice = txtPrice.Text;
            bool isInt = chk.CheckInt(UnitPrice);
            bool notEmpty = chk.CheckEmpty(UnitPrice);

            if (isInt == false)
            {
                txtPrice.BackColor = Color.FromArgb(244, 17, 17);
                unitPValid = false;
            }
            else if (notEmpty == false)
            {
                txtPrice.BackColor = Color.FromArgb(244, 17, 17);
                unitPValid = false;
            }
            else
            {
                txtPrice.BackColor = Color.White;
                unitPValid = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string UnitPrice = txtPrice.Text;
            string stockDesc = txtDesc.Text;

            if (stockDValid == false && unitPValid == false)
            {
                MessageBox.Show("The Stock description and Price was not entered or entered incorrectly. Please re-enter the details and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (stockDValid == false)
            {
                MessageBox.Show("The stock description was not entered. Please re-enter the stock description and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (unitPValid == false)
            {
                MessageBox.Show("The Price was not entered or entered incorrectly. Please re-enter the Unit Price and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Stock mStock = new Stock
                {
                    StockDescription = txtDesc.Text,
                    StockUnitPrice = Convert.ToInt32(txtPrice.Text),
                   // StockType = Convert.ToInt32(cbType.SelectedValue)


                };

                db.Stocks.InsertOnSubmit(mStock);
                db.SubmitChanges();

                txtDesc.Text = "";
                txtPrice.Text = "";
               

                this.Close();

                MessageBox.Show("Added " + stockDesc + "\n Searching R " + UnitPrice + "", "It Worked");
               //MessageBox.Show("ok");
            }
        }

        private void Create_stock_item_Load(object sender, EventArgs e)
        {
            var mStockTypeID = (
                  from a in db.StockTypes
                  select a.StockName)
                   .ToList();

            cbType.DataSource = mStockTypeID;

            //var list = (from p in db.StockTypes
            //            select new
            //            {
            //                p.StockName,
            //                p.StockTypeID
            //            }).ToList();
            //cbType.DataSource = list;
            //cbType.SelectedItem = list[0];

        }

        private void btnAddStockType_Click(object sender, EventArgs e)
        {
            AddNewStockType f = new AddNewStockType();
            f.Show();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
