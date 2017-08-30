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
    public partial class UpdateStock : Form
    {

        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool stockDValid;
        bool unitPValid;
        int NewID = Search_Stock.ToUpdate;
        int getTypeID;


        public UpdateStock()
        {
            InitializeComponent();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string stockDesc = txtName.Text;
            string UnitPrice = txtPrice.Text;
            //add cb box items


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
                var mSomeone = (from x in db.Stocks where x.StockID == Convert.ToInt32(NewID) select x).FirstOrDefault();


                mSomeone.StockDescription = stockDesc;
                mSomeone.StockUnitPrice = Convert.ToInt32(UnitPrice);
                //mSomeone.StockTypeID = Convert.ToInt32(cbStockType.Text);
               
                db.SubmitChanges();

                txtName.Text = "";
                txtPrice.Text = "";


                this.Close();

                MessageBox.Show("Updated " + stockDesc + " and R " + UnitPrice + " " + "as the new info was entered.", "It Worked");
                //MessageBox.Show("ok");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
            string stockDesc = txtName.Text;
            bool isString = chk.Checkstring(stockDesc);
            bool notEmpty = chk.CheckEmpty(stockDesc);

            if (isString == false)
            {
                txtName.BackColor = Color.FromArgb(244, 17, 17);
                stockDValid = false;
            }
            else if (notEmpty == false)
            {
                txtName.BackColor = Color.FromArgb(244, 17, 17);
                stockDValid = false;
            }
            else
            {
                txtName.BackColor = Color.White;
                stockDValid = true;
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
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

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            var mStockload = (from a in db.Stocks where a.StockID == NewID select new
            {
                a.StockID,
                a.StockDescription,
                a.StockUnitPrice,
                a.StockTypeID,
            }).ToList();

            foreach (var item in mStockload)
            {
                lblStockID.Text = Convert.ToString(item.StockID);
                txtName.Text = item.StockDescription;
                txtPrice.Text = Convert.ToString(item.StockUnitPrice);
                getTypeID = item.StockTypeID;
            }

            var mStockTypeload = (from x in db.StockTypes
                                  where x.StockTypeID == getTypeID
                                  select new
                                  {
                                      x.StockTypeID,
                                      x.StockName
                                  }).ToList();

            foreach (var Typevalue in mStockTypeload)
            {
                cbStockType.SelectedItem = Typevalue.StockName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
