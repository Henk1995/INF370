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

        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool NameValid;

        // Moet desc validate word? kan maybe oopgelos word?


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string StockType = txtStockTypeName.Text;



            if (NameValid == false)
            {
                MessageBox.Show("The stock type was not entered. Please re-enter the stock type and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                StockType mStock = new StockType
                {
                    StockName = txtStockTypeName.Text

                };

                db.StockTypes.InsertOnSubmit(mStock);
                db.SubmitChanges();

                txtStockTypeName.Text = "";


                this.Close();

                MessageBox.Show("Added " + StockType + " " + "as a new stock type.", "It Worked");


            }
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
