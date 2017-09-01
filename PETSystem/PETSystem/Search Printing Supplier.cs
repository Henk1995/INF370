﻿using System;
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

        public static int ToUpdate;
        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool SearchPSNameValid;
        bool SearchPSIDValid;
        int id;

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
                var searchName = from Printer in db.Printers
                                     where Printer.PrinterName == txtSearchPrintSupplierName.Text
                                     select Printer;
                dgvSearchPrintingSupplier.DataSource = searchName;

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

                var searchID = from Printer in db.Printers
                                 where Printer.PrinterID == Convert.ToInt32(txtSearchPrintSupplierID.Text)
                                 select Printer;
                dgvSearchPrintingSupplier.DataSource = searchID;

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

            if (SearchPSNameValid == true)
            {
                var searchDesc = from Printer in db.Printers
                                 where Printer.PrinterName.Contains(txtSearchPrintSupplierName.Text)
                                 select Printer;
                dgvSearchPrintingSupplier.DataSource = searchDesc;
                dgvSearchPrintingSupplier.Refresh();
            }
            else
            {
                dgvSearchPrintingSupplier.DataSource = null;
                var S = from Stock in db.Stocks select Stock;
                dgvSearchPrintingSupplier.DataSource = S;
                dgvSearchPrintingSupplier.Update();
                dgvSearchPrintingSupplier.Refresh();
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

            if (SearchPSNameValid == true)
            {
                var searchID = from Printer in db.Printers
                               where Printer.PrinterID == Convert.ToInt32(txtSearchPrintSupplierID.Text)
                               select Printer;
                dgvSearchPrintingSupplier.DataSource = searchID;
            }
            else
            {
                dgvSearchPrintingSupplier.DataSource = null;
                var S = from Stock in db.Stocks select Stock;
                dgvSearchPrintingSupplier.DataSource = S;
                dgvSearchPrintingSupplier.Update();
                dgvSearchPrintingSupplier.Refresh();
            }

        }

        private void btnDeletePrintSupplier_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Are you sure you want to delete this Printing Supplier?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (test == DialogResult.Yes)
            {

                //Delete Selected
                var mPS = (from x in db.Printers where x.PrinterID == id select x).First();
                db.Printers.DeleteOnSubmit(mPS);
                db.SubmitChanges();

                //refresh DGV
                dgvSearchPrintingSupplier.DataSource = null;
                dgvSearchPrintingSupplier.DataSource = db.Printers;

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
            var PS = from Printer in db.Printers select Printer;
            dgvSearchPrintingSupplier.DataSource = PS;
            dgvSearchPrintingSupplier.Refresh();
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

        private void btnViewPrintSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSearchPrintingSupplier.SelectedCells.Count > 0)
            {
                Printer _PS = (Printer)dgvSearchPrintingSupplier.CurrentRow.DataBoundItem;
                string psName = _PS.PrinterName;
                string psAddr = _PS.PrinterAddress;
                string psEmail = _PS.PrinterEmail;
                int psPhone = Convert.ToInt32(_PS.PrinterPhoneNumber);
                int psBACC = Convert.ToInt32(_PS.PrinterBankAccNumber);

                MessageBox.Show(" Printing Supplier: " + psName + "\n Address: " + psAddr + "\n Email Address: " + psEmail + "\n Phone Number: " + psPhone + "\n Bank Details: " + psBACC, "View Course",
    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dgvSearchPrintingSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSearchPrintingSupplier.SelectedCells.Count > 0)
            {
                Printer _Printer = (Printer)dgvSearchPrintingSupplier.CurrentRow.DataBoundItem;
                id = _Printer.PrinterID;
                ToUpdate = id;
            }
        }

        private void btnRefreshDGV_Click(object sender, EventArgs e)
        {
            dgvSearchPrintingSupplier.DataSource = null;
            var PS = from Printer in db.Printers select Printer;
            dgvSearchPrintingSupplier.DataSource = PS;
            dgvSearchPrintingSupplier.Update();
            dgvSearchPrintingSupplier.Refresh();
        }
    }
}
