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
        DateTime endOfTime;
        Timer t;
        public Search_Printing_Supplier()
        {
            InitializeComponent();
        }

        public static int ToUpdate;
        public static int PrinterIDToEmail;
        public static string SelectedPrinterToEmail;
        public static string PrinterName;
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
                var S = from Printer in db.Printers select Printer;
                dgvSearchPrintingSupplier.DataSource = S;
                dgvSearchPrintingSupplier.Update();
                dgvSearchPrintingSupplier.Refresh();
            }


        }


        private void btnDeletePrintSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSearchPrintingSupplier.SelectedCells.Count > 0)
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
                else
                {
                    MessageBox.Show("Please select a row");
                }
            }
            catch
            {
                MessageBox.Show("Printer canot be deleted because there are orrders assign to this printer.","Notification");
            }
        }

        private void Search_Printing_Supplier_Load(object sender, EventArgs e)
        {
            //add
            ToolTip TTSearch = new ToolTip();
            TTSearch.ToolTipTitle = "Add";
            TTSearch.UseFading = true;
            TTSearch.UseAnimation = true;
            TTSearch.IsBalloon = true;
            TTSearch.SetToolTip(btnAddPrintSupplier, "Click to add a printer.");
            //view
            ToolTip TTV = new ToolTip();
            TTV.ToolTipTitle = "View";
            TTV.UseFading = true;
            TTV.UseAnimation = true;
            TTV.IsBalloon = true;
            TTV.SetToolTip(btnViewPrintSupplier, "Click to view a printer.");
            //update
            ToolTip TTU = new ToolTip();
            TTU.ToolTipTitle = "Update";
            TTU.UseFading = true;
            TTU.UseAnimation = true;
            TTU.IsBalloon = true;
            TTU.SetToolTip(btnUpdatePrintSupplier, "Click to update a printer.");
            //delete
            ToolTip TTDD = new ToolTip();
            TTDD.ToolTipTitle = "Delete";
            TTDD.UseFading = true;
            TTDD.UseAnimation = true;
            TTDD.IsBalloon = true;
            TTDD.SetToolTip(btnDeletePrintSupplier, "Click to Delete a printer.");
            //palce order
            ToolTip TTPO = new ToolTip();
            TTPO.ToolTipTitle = "Place Order";
            TTPO.UseFading = true;
            TTPO.UseAnimation = true;
            TTPO.IsBalloon = true;
            TTPO.SetToolTip(btnPlaceOrder, "Click to Place a printer Order.");
            //recieve order
            ToolTip TTRECIEVE = new ToolTip();
            TTRECIEVE.ToolTipTitle = "Recieve Order";
            TTRECIEVE.UseFading = true;
            TTRECIEVE.UseAnimation = true;
            TTRECIEVE.IsBalloon = true;
            TTRECIEVE.SetToolTip(btnReceiveOrder, "Click to capture a printer Order.");
            //return
            ToolTip TTRET = new ToolTip();
            TTRET.ToolTipTitle = "Return Order";
            TTRET.UseFading = true;
            TTRET.UseAnimation = true;
            TTRET.IsBalloon = true;
            TTRET.SetToolTip(button2, "Click to return a printer Order.");
            //refund
            ToolTip TTREF = new ToolTip();
            TTREF.ToolTipTitle = "Refund Order";
            TTREF.UseFading = true;
            TTREF.UseAnimation = true;
            TTREF.IsBalloon = true;
            TTREF.SetToolTip(button3, "Click to Refund a printer Order.");
            //main menu
            ToolTip TTMAIN = new ToolTip();
            TTMAIN.ToolTipTitle = "Main Menu";
            TTMAIN.UseFading = true;
            TTMAIN.UseAnimation = true;
            TTMAIN.IsBalloon = true;
            TTMAIN.SetToolTip(btnMainMenu, "Click to Return to main menu.");
            //search
            ToolTip TTTTTTT = new ToolTip();
            TTTTTTT.ToolTipTitle = "Search";
            TTTTTTT.UseFading = true;
            TTTTTTT.UseAnimation = true;
            TTTTTTT.IsBalloon = true;
            TTTTTTT.SetToolTip(txtSearchPrintSupplierName, "Enter printer name to search for it.");

            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

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
        {try
            {
                this.Close();
                Update_Printing_Supplier ups = new Update_Printing_Supplier();
                ups.Show();
            }
            catch
            { }
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
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void dgvSearchPrintingSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSearchPrintingSupplier.SelectedCells.Count > 0)
            {
                Printer _Printer = (Printer)dgvSearchPrintingSupplier.CurrentRow.DataBoundItem;
                id = _Printer.PrinterID;
                ToUpdate = id;
                PrinterIDToEmail = id;
                PrinterName = _Printer.PrinterName;
                SelectedPrinterToEmail = _Printer.PrinterEmail;
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
            if (dgvSearchPrintingSupplier.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvSearchPrintingSupplier.SelectedRows[0].Index;
                ConnectString.SupplierName = dgvSearchPrintingSupplier.SelectedRows[0].Cells[1].Value + string.Empty;
                // gets the RowID from the first column in the grid
                ConnectString.SupplierID = int.Parse(dgvSearchPrintingSupplier[0, selectedIndex].Value.ToString());
                this.Close();
                Recieve_Printing_Order myform = new Recieve_Printing_Order();
                myform.Show();
            }
            else
            {
                MessageBox.Show("Please Select a row to Recieve an order");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvSearchPrintingSupplier.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvSearchPrintingSupplier.SelectedRows[0].Index;
                ConnectString.SupplierName = dgvSearchPrintingSupplier.SelectedRows[0].Cells[1].Value + string.Empty;
                // gets the RowID from the first column in the grid
                ConnectString.SupplierID = int.Parse(dgvSearchPrintingSupplier[0, selectedIndex].Value.ToString());
                this.Close();
                Return_Printing_Order myform = new Return_Printing_Order();
                myform.Show();
            }
            else
            {
                MessageBox.Show("Please Select a row to Return a order");
            }
        }

        private void dgvSearchPrintingSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvSearchPrintingSupplier.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvSearchPrintingSupplier.SelectedRows[0].Index;
                ConnectString.SupplierName = dgvSearchPrintingSupplier.SelectedRows[0].Cells[1].Value + string.Empty;
                // gets the RowID from the first column in the grid
                ConnectString.SupplierID = int.Parse(dgvSearchPrintingSupplier[0, selectedIndex].Value.ToString());
                this.Close();
                Refund_Printing_Order myform = new Refund_Printing_Order();
                myform.Show();
            }
            else
            {
                MessageBox.Show("Please Select a row to Refund a order");
            }
        }

        int stop = 0;
        int ticks = ConnectString.TimerTime * 60;

        private void timer1_Tick(object sender, EventArgs e)
        {

            stop++;

            if (stop > ticks)
            {
                t.Enabled = false;
                this.Close();
                this.Dispose(true);
                LoginF myform = new LoginF();
                myform.ShowDialog();
            }
            else {
                TimeSpan ts = endOfTime.Subtract(DateTime.Now);
                lblTimer.Text = ts.ToString();
            }
        }

        private void Search_Printing_Supplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}

