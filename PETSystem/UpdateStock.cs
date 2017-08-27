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

        public UpdateStock()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string UnitPrice = txtName.Text;
            string stockDesc = txtSurname.Text;
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

                //Stock mStock = new Stock
                //{
                //    StockID = Convert.ToInt32(label1.Text),
                //    StockDescription = txtDesc.Text,
                //    StockUnitPrice = Convert.ToInt32(txtPrice.Text),
                //   // StockType = cbType.SelectedValue,


                //};

                //db.Stocks.InsertOnSubmit(mStock);
                //db.SubmitChanges();

                txtName.Text = "";
                txtSurname.Text = "";


                this.Close();

                MessageBox.Show("Updated " + stockDesc + "and R " + UnitPrice + "" + "as the new info was entered.", "It Worked");
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
            txtSurname.BackColor = Color.White;
            string UnitPrice = txtSurname.Text;
            bool isInt = chk.CheckInt(UnitPrice);
            bool notEmpty = chk.CheckEmpty(UnitPrice);

            if (isInt == false)
            {
                txtSurname.BackColor = Color.FromArgb(244, 17, 17);
                unitPValid = false;
            }
            else if (notEmpty == false)
            {
                txtSurname.BackColor = Color.FromArgb(244, 17, 17);
                unitPValid = false;
            }
            else
            {
                txtSurname.BackColor = Color.White;
                unitPValid = true;
            }
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            //Load all fields from db
        }
    }
}
