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
    public partial class Add_Printing_Supplier : Form
    {
        public Add_Printing_Supplier()
        {
            InitializeComponent();
        }

        bool NameValid;
        bool AddressValid;
        bool EmailValid;
        bool PhoneNumberValid;
        bool BankACCValid;

        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //validation of all inputs
            string PSName = txtPrintingSupplierName.Text;
            string PSAddress = txtPrintingSupplierAddress.Text;
            string PSEmail = txtPrintingSupplierEmail.Text;
            string PSPhoneNumber = txtPrintingSupplierPhoneNumber.Text;
            string PSBankAccountNumber = txtPrintingSupplierBankAccNumber.Text;

            if (NameValid == false && AddressValid == false && BankACCValid == false && EmailValid == false && PhoneNumberValid == false)
            {
                MessageBox.Show("The information was not entered or entered incorrectly. Please re-enter the details and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (BankACCValid == false)
            {
                MessageBox.Show("The Bank Account Number was not entered. Please re-enter the Bank Account Number and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NameValid == false)
            {
                MessageBox.Show("The Name was not entered or entered incorrectly. Please re-enter the Name and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AddressValid == false)
            {
                MessageBox.Show("The Address was not entered or entered incorrectly. Please re-enter the Address and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (EmailValid == false)
            {
                MessageBox.Show("The Email was not entered or entered incorrectly. Please re-enter the Email and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PhoneNumberValid == false)
            {
                MessageBox.Show("The Phone number was not entered or entered incorrectly. Please re-enter the Phone number and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Printer mPrinter = new Printer
                {
                    PrinterName = PSName,
                    PrinterAddress = PSAddress,
                    PrinterEmail = PSEmail,
                    PrinterPhoneNumber = PSPhoneNumber,
                    PrinterBankAccNumber = Convert.ToInt32(PSBankAccountNumber),




                };

                db.Printers.InsertOnSubmit(mPrinter);
                db.SubmitChanges();


                //validation of all inputs
                txtPrintingSupplierName.Text = "";
                txtPrintingSupplierAddress.Text = "";
                txtPrintingSupplierEmail.Text = "";
                txtPrintingSupplierPhoneNumber.Text = "";
                txtPrintingSupplierBankAccNumber.Text = "";

                this.Close();

                MessageBox.Show("Added new Course Client:" + "/n Name" + PSName + "\n Surname: R " + PSAddress + "" + "/n Email: " + PSEmail + "/n Phone Number: " + PSPhoneNumber + "/n Bank Account Number: " + PSBankAccountNumber, "It Worked");
                //MessageBox.Show("ok");
            }


        }

        private void txtPrintingSupplierName_TextChanged(object sender, EventArgs e)
        {
            txtPrintingSupplierName.BackColor = Color.White;
            string PSName = txtPrintingSupplierName.Text;
            bool isString = chk.Checkstring(PSName);
            bool notEmpty = chk.CheckEmpty(PSName);

            if (isString == false)
            {
                txtPrintingSupplierName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else if (notEmpty == false)
            {
                txtPrintingSupplierName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else
            {
                txtPrintingSupplierName.BackColor = Color.White;
                NameValid = true;
            }
        }

        private void txtPrintingSupplierAddress_TextChanged(object sender, EventArgs e)
        {
            txtPrintingSupplierAddress.BackColor = Color.White;
            string PSAddress = txtPrintingSupplierAddress.Text;
            bool isString = chk.Checkstring(PSAddress);
            bool notEmpty = chk.CheckEmpty(PSAddress);

            if (isString == false)
            {
                txtPrintingSupplierAddress.BackColor = Color.FromArgb(244, 17, 17);
                AddressValid = false;
            }
            else if (notEmpty == false)
            {
                txtPrintingSupplierAddress.BackColor = Color.FromArgb(244, 17, 17);
                AddressValid = false;
            }
            else
            {
                txtPrintingSupplierAddress.BackColor = Color.White;
                AddressValid = true;
            }
        }

        private void txtPrintingSupplierEmail_TextChanged(object sender, EventArgs e)
        {
            txtPrintingSupplierEmail.BackColor = Color.White;
            string PSEmail = txtPrintingSupplierEmail.Text;
            bool isEmail = chk.CheckEmail(PSEmail);
            bool notEmpty = chk.CheckEmpty(PSEmail);

            if (isEmail == false)
            {
                txtPrintingSupplierEmail.BackColor = Color.FromArgb(244, 17, 17);
                EmailValid = false;
            }
            else if (notEmpty == false)
            {
                txtPrintingSupplierEmail.BackColor = Color.FromArgb(244, 17, 17);
                EmailValid = false;
            }
            else
            {
                txtPrintingSupplierEmail.BackColor = Color.White;
                EmailValid = true;
            }
        }

        private void txtPrintingSupplierPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string PhoneNumber = txtPrintingSupplierPhoneNumber.Text;
            txtPrintingSupplierPhoneNumber.BackColor = Color.White;
            bool isPhone = chk.CheckInt(PhoneNumber); // Chenge to validate a phone Number not int
            bool notEmpty = chk.CheckEmpty(PhoneNumber);

            if (isPhone == false)
            {
                txtPrintingSupplierPhoneNumber.BackColor = Color.FromArgb(244, 17, 17);
                PhoneNumberValid = false;
            }
            else if (notEmpty == false)
            {
                txtPrintingSupplierPhoneNumber.BackColor = Color.FromArgb(244, 17, 17);
                PhoneNumberValid = false;
            }
            else
            {
                txtPrintingSupplierPhoneNumber.BackColor = Color.White;
                PhoneNumberValid = true;
            }
        }

        private void txtPrintingSupplierBankAccNumber_TextChanged(object sender, EventArgs e)
        {
            string BankACCNumber = txtPrintingSupplierBankAccNumber.Text;
            txtPrintingSupplierBankAccNumber.BackColor = Color.White;
            bool isBankACCNumber = chk.CheckInt(BankACCNumber); // Chenge to validate a bank account number not int
            bool notEmpty = chk.CheckEmpty(BankACCNumber);

            if (isBankACCNumber == false)
            {
                txtPrintingSupplierBankAccNumber.BackColor = Color.FromArgb(244, 17, 17);
                BankACCValid = false;
            }
            else if (notEmpty == false)
            {
                txtPrintingSupplierBankAccNumber.BackColor = Color.FromArgb(244, 17, 17);
                BankACCValid = false;
            }
            else
            {
                txtPrintingSupplierBankAccNumber.BackColor = Color.White;
                BankACCValid = true;
            }
        }

        private void Add_Printing_Supplier_Load(object sender, EventArgs e)
        {

        }
    }
}
