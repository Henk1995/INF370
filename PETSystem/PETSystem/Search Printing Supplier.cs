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
            //string emailA = "";
            //if (dgvSupp.SelectedRows.Count > 0)
            //{
            //    string supplierID = dgvSupp.SelectedRows[0].Cells[4].Value + string.Empty;

            //    // gets the RowID from the first column in the grid
            //    int suppID = int.Parse(supplierID);


            //    MessageBox.Show("Are you sure you want to delete this instructor?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //    string query2 = "SELECT SupplierEmail FROM Supplier WHERE SupplierID ='" + suppID + "'";
            //    SqlCommand MyCommand2 = new SqlCommand(query2, ConnectString.connectstring);
            //    SqlDataReader MyReader2;
            //    ConnectString.connectstring.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

            //    while (MyReader2.Read())
            //    {
            //        emailA = MyReader2["SupplierEmail"].ToString();
            //    }
            //    ConnectString.connectstring.Close();
            //    using (SmtpClient client = new SmtpClient())
            //    {
            //        client.Host = "smtp.gmail.com";
            //        client.UseDefaultCredentials = true;
            //        NetworkCredential netCred = new NetworkCredential("janwilkensmalan1@gmail.com", "Wilkens123");
            //        client.Credentials = netCred;
            //        client.EnableSsl = true;
            //        client.Port = 587;
            //        client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //        using (MailMessage mail = new MailMessage("janwilkensmalan1@gmail.com", emailA))
            //        {
            //            try
            //            {
            //                mail.Subject = "Return order";
            //                mail.Body = "The order that was placed with reference number XXXXXXX is being returned as we are not happy with the order we insist on a full refund";
            //                mail.IsBodyHtml = false;
            //                client.Send(mail);
            //            }

            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex);
            //                if (ex.InnerException != null)
            //                { MessageBox.Show("InnerException is: {0}", ex.InnerException.ToString()); }

            //            }
            //        }
            //    }
            }

        private void dgvSearchPrintingSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

