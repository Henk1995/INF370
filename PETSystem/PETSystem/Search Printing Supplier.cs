using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

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

        private void txtSearchPrintSupplierName_TextChanged(object sender, EventArgs e)
        {
            txtSearchPrintSupplierName.BackColor = Color.White;
            string PrintSupplierName = txtSearchPrintSupplierName.Text;
            bool isString = chk.Checkstring(PrintSupplierName);
            bool notEmpty = chk.CheckEmpty(PrintSupplierName);
            bool checkForSQLInjection = chk.checkForSQLInjection(PrintSupplierName);

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
            else if (checkForSQLInjection == false)
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
            this.Close();
            Add_Printing_Supplier aps = new Add_Printing_Supplier();
            aps.Show();
        }

        private void btnUpdatePrintSupplier_Click(object sender, EventArgs e)
        {
            this.Close();
            Update_Printing_Supplier ups = new Update_Printing_Supplier();
            ups.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
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

                MessageBox.Show(" Printing Supplier: \t" + psName + "\n Address: \t\t" + psAddr + "\n Email Address: \t" + psEmail + "\n Phone Number: \t" + psPhone + "\n Bank Details: \t" + psBACC, "View Course",
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

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            Place_Printing_Order ppo = new Place_Printing_Order();
            ppo.Show();
        }

        private void btnReceiveOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Stock sc = new Search_Stock();
            sc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            PrinterOrderReturn por = new PrinterOrderReturn();
            por.Show();
        }

        private void dgvSearchPrintingSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            PrinterOrderReturn poreturn = new PrinterOrderReturn();
            poreturn.Show();
        }
    }
}

