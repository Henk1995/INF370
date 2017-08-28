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
    public partial class AddNewStockType : Form
    {
        public AddNewStockType()
        {
            InitializeComponent();
        }

        ErrorHandle chk = new ErrorHandle();
        bool NameValid;
        bool DescIsEmpty;

        // Moet desc validate word? kan maybe oopgelos word?


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string StockType = txtStockTypeName.Text;
            string TypeDesc = txtStockTypeDesc.Text;
            //add cb box items


            if (NameValid == false)
            {
                MessageBox.Show("The stock type was not entered. Please re-enter the stock type and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DescIsEmpty == false)
            {
                
                DialogResult test = MessageBox.Show("No description was entered? Leave it Empty?", "An Error Has Occured", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (test == DialogResult.Yes)
                {
                    AddNewStockTypeToDB(); //do the things specified in method below
                }
                
            }
            else
            {
                AddNewStockTypeToDB(); //do the things specified in method below

            }
        }

        private void AddNewStockTypeToDB()
        {
            string StockType = txtStockTypeName.Text;
            string TypeDesc = txtStockTypeDesc.Text;
            //add cb box items

            //Stock mStock = new Stock
            //{
            //    StockID = Convert.ToInt32(label1.Text),
            //    StockDescription = txtDesc.Text,
            //    StockUnitPrice = Convert.ToInt32(txtPrice.Text),
            //   // StockType = cbType.SelectedValue,


            //};

            //db.Stocks.InsertOnSubmit(mStock);
            //db.SubmitChanges();

            txtStockTypeName.Text = "";
            txtStockTypeDesc.Text = "";


            this.Close();

            MessageBox.Show("Added " + StockType + "" + "as a new stock type.", "It Worked");
            //MessageBox.Show("ok");
        }

        private void txtStockTypeName_TextChanged(object sender, EventArgs e)
        {
            txtStockTypeName.BackColor = Color.White;
            string stockDesc = txtStockTypeName.Text;
            bool isString = chk.Checkstring(stockDesc);
            bool notEmpty = chk.CheckEmpty(stockDesc);

            if (isString == false)
            {
                txtStockTypeName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else if (notEmpty == false)
            {
                txtStockTypeName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else
            {
                txtStockTypeName.BackColor = Color.White;
                NameValid = true;
            }
        }
    }
}
