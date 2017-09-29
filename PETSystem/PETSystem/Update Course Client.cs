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
    public partial class Update_Course_Client : Form
    {
        public Update_Course_Client()
        {
            InitializeComponent();
        }

        int LoadtitleID;
        int LoadGenderID;


        bool NameValid;
        bool SurnameValid;
        bool EmailValid;
        bool PhoneNumberValid;

        int NewID = Search_Course_Client.ToUpdate;

        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Course_Client scc = new Search_Course_Client();
            scc.Show();
        }

        private void btnUpdateCourseClient_Click(object sender, EventArgs e)
        {
            //validation of all inputs
            int title = cbTitle.SelectedIndex + 1;
            string Name = txtName.Text;
            string Surname = txtSurname.Text;
            string Gender = cbGender.SelectedText;
            string Email = txtEmail.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            int GenID = Convert.ToInt32(cbGender.SelectedIndex + 1);



            if (NameValid == false && SurnameValid == false&& EmailValid == false && PhoneNumberValid == false)
            {
                MessageBox.Show("The information was not entered or entered incorrectly. Please re-enter the details and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (NameValid == false)
            {
                MessageBox.Show("The Name was not entered or entered incorrectly. Please re-enter the Name and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (SurnameValid == false)
            {
                MessageBox.Show("The Surname was not entered or entered incorrectly. Please re-enter the Surname and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var mClient = (from x in db.Clients where x.ClientID == Convert.ToInt32(NewID) select x).FirstOrDefault();
                mClient.TitleID = title;
                mClient.ClientName = txtName.Text;
                mClient.ClientSurname = txtSurname.Text;
                mClient.ClientEmail = txtEmail.Text;
                mClient.GenderID = GenID;
                mClient.ClientPhoneNumber = txtPhoneNumber.Text;

                db.SubmitChanges();


                this.Close();
                var getGender = (from x in db.Genders where x.GenderID == mClient.GenderID select x.GenderName).FirstOrDefault();

                string gen = Convert.ToString(getGender);



                MessageBox.Show("Added new Course Client:" + "\n Name" + title + " " + Name + "\n Surname: R " + Surname + "" + "\n Gender: " + gen + "\n Email: " + Email + "\n Phone Number: " + PhoneNumber, "It Worked");
                //MessageBox.Show("ok");

                Search_Course_Client scc = new Search_Course_Client();
                scc.Show();
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
            string Name = txtName.Text;
            bool isString = chk.Checkstring(Name);
            bool notEmpty = chk.CheckEmpty(Name);
            bool checkForSQLInjection = chk.checkForSQLInjection(Name);

            if (isString == false)
            {
                txtName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else if (notEmpty == false)
            {
                txtName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                txtName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else
            {
                txtName.BackColor = Color.White;
                NameValid = true;
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            txtSurname.BackColor = Color.White;
            string Surname = txtSurname.Text;
            bool isString = chk.Checkstring(Surname);
            bool notEmpty = chk.CheckEmpty(Surname);
            bool checkForSQLInjection = chk.checkForSQLInjection(Surname);

            if (isString == false)
            {
                txtSurname.BackColor = Color.FromArgb(244, 17, 17);
                SurnameValid = false;
            }
            else if (notEmpty == false)
            {
                txtSurname.BackColor = Color.FromArgb(244, 17, 17);
                SurnameValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                txtSurname.BackColor = Color.FromArgb(244, 17, 17);
                SurnameValid = false;
            }
            else
            {
                txtSurname.BackColor = Color.White;
                SurnameValid = true;
            }
        }


        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
            string Email = txtEmail.Text;
            bool isEmail = chk.CheckEmail(Email);
            bool notEmpty = chk.CheckEmpty(Email);
            bool checkForSQLInjection = chk.checkForSQLInjection(Email);

            if (isEmail == false)
            {
                txtEmail.BackColor = Color.FromArgb(244, 17, 17);
                EmailValid = false;
            }
            else if (notEmpty == false)
            {
                txtEmail.BackColor = Color.FromArgb(244, 17, 17);
                EmailValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                txtEmail.BackColor = Color.FromArgb(244, 17, 17);
                EmailValid = false;
            }
            else
            {
                txtEmail.BackColor = Color.White;
                EmailValid = true;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string PhoneNumber = txtPhoneNumber.Text;
            txtPhoneNumber.BackColor = Color.White;
            bool isPhone = chk.CheckInt(PhoneNumber); // Chenge to validate a phone Number not int
            bool notEmpty = chk.CheckEmpty(PhoneNumber);
            bool checkForSQLInjection = chk.checkForSQLInjection(PhoneNumber);

            if (isPhone == false)
            {
                txtPhoneNumber.BackColor = Color.FromArgb(244, 17, 17);
                PhoneNumberValid = false;
            }
            else if (notEmpty == false)
            {
                txtPhoneNumber.BackColor = Color.FromArgb(244, 17, 17);
                PhoneNumberValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                txtPhoneNumber.BackColor = Color.FromArgb(244, 17, 17);
                PhoneNumberValid = false;
            }
            else
            {
                txtPhoneNumber.BackColor = Color.White;
                PhoneNumberValid = true;
            }
        }

        private void Update_Course_Client_Load(object sender, EventArgs e)
        {
            var mClientGenderID = (
                  from a in db.Genders
                  select a.GenderName)
                   .ToList();

            cbGender.DataSource = mClientGenderID;


            var mClientTitleID = (
                  from a in db.Titles
                  select a.TitleName)
                   .ToList();

            cbTitle.DataSource = mClientTitleID;

            var mLoadCourseClientDetails = (from x in db.Clients where x.ClientID == Convert.ToInt32(NewID) select x).FirstOrDefault();


            txtName.Text = mLoadCourseClientDetails.ClientName;
            txtSurname.Text = mLoadCourseClientDetails.ClientSurname;
            txtEmail.Text = mLoadCourseClientDetails.ClientEmail;
            txtPhoneNumber.Text = mLoadCourseClientDetails.ClientPhoneNumber;
            LoadtitleID = mLoadCourseClientDetails.TitleID;
            LoadGenderID = mLoadCourseClientDetails.GenderID;

            



        }
    }
}
