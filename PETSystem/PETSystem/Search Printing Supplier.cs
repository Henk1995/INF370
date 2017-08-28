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
    public partial class Search_Printing_Supplier : Form
    {
        public Search_Printing_Supplier()
        {
            InitializeComponent();
        }

        ErrorHandle chk = new ErrorHandle();
        bool SearchPSNameValid;
        bool SearchPSIDValid;

        private void btnSearchPrintSupplierName_Click(object sender, EventArgs e)
        {
            string PrintSupplierName = txtSearchPrintSupplierName.Text;
            if (SearchPSNameValid == false)
            {
                MessageBox.Show("The stock description was not entered. Please enter the stock description that you want to search and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //Search in db
                MessageBox.Show("Searching " + PrintSupplierName, "It Worked");
            }
        }

        private void btnSearchPrintSupplierID_Click(object sender, EventArgs e)
        {
            string PrintSupplierID = txtSearchPrintSupplierID.Text;
            if (SearchPSIDValid == false)
            {

                MessageBox.Show("The stock ID was not entered. Please enter the stock ID that you want to search and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Search in DB
                MessageBox.Show("Searching " + PrintSupplierID, "It Worked");
            }
        }

        private void txtSearchPrintSupplierName_TextChanged(object sender, EventArgs e)
        {
            txtSearchPrintSupplierName.BackColor = Color.White;
            string PrintSupplierName = txtSearchPrintSupplierName.Text;
            bool isString = chk.Checkstring(PrintSupplierName);
            bool notEmpty = chk.CheckEmpty(PrintSupplierName);

            if (isString == false)
            {
                txtSearchPrintSupplierName.BackColor = Color.FromArgb(244, 17, 17);
                SearchPSNameValid = false;
            }
            else if (notEmpty == false)
            {
                txtSearchPrintSupplierName.BackColor = Color.FromArgb(244, 17, 17);
                SearchPSNameValid = false;
            }
            else
            {
                txtSearchPrintSupplierName.BackColor = Color.White;
                SearchPSNameValid = true;
            }
        }

        private void txtSearchPrintSupplierID_TextChanged(object sender, EventArgs e)
        {
            string PrintSupplierID = txtSearchPrintSupplierID.Text;
            txtSearchPrintSupplierID.BackColor = Color.White;
            bool isInt = chk.CheckInt(PrintSupplierID);
            bool notEmpty = chk.CheckEmpty(PrintSupplierID);

            if (isInt == false)
            {
                txtSearchPrintSupplierID.BackColor = Color.FromArgb(244, 17, 17);
                SearchPSIDValid = false;
            }
            else if (notEmpty == false)
            {
                txtSearchPrintSupplierID.BackColor = Color.FromArgb(244, 17, 17);
                SearchPSIDValid = false;
            }
            else
            {
                txtSearchPrintSupplierID.BackColor = Color.White;
                SearchPSIDValid = true;
            }
        }

        private void btnDeletePrintSupplier_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Are you sure you want to delete this Printing Supplier?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (test == DialogResult.Yes)
            {
                MessageBox.Show("Printing Supplier has been deleted", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (test == DialogResult.No)
            {
                MessageBox.Show("Printing Supplier not deleted", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Search_Printing_Supplier_Load(object sender, EventArgs e)
        {
            //Pre loads all the data from the printing supplier table
            //PET_DBDataContext db = new PET_DBDataContext();
            //var Stock = from STOCKS in db.Stocks select STOCKS;
            //dgvSearchStock.DataSource = Stock;
            //dgvSearchStock.Refresh();
        }

        private void btnAddPrintSupplier_Click(object sender, EventArgs e)
        {
            Add_Printing_Supplier aps = new Add_Printing_Supplier();
            aps.Show();
        }

        private void btnUpdatePrintSupplier_Click(object sender, EventArgs e)
        {
            Update_Printing_Supplier ups = new Update_Printing_Supplier();
            ups.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenuF UM = new MainMenuF();
            UM.ShowDialog();
        }
    }
}
