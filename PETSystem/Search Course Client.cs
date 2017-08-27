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
    public partial class Search_Course_Client : Form
    {
        public Search_Course_Client()
        {
            InitializeComponent();
        }

        ErrorHandle chk = new ErrorHandle();
        bool SearcCCNValid;
        bool SearcCCSNValid;

        private void btnSearcCCName_Click(object sender, EventArgs e)
        {
            string CourseClienName = txtSearchCCName.Text;
            if (SearcCCNValid == false)
            {
                MessageBox.Show("The Client name was not entered. Please enter the Client name that you want to search and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //Search in db
                MessageBox.Show("Searching " + CourseClienName, "It Worked");
            }
        }

        private void txtSearchCCName_TextChanged(object sender, EventArgs e)
        {
            txtSearchCCName.BackColor = Color.White;
            string CCName = txtSearchCCName.Text;
            bool isString = chk.Checkstring(CCName);
            bool notEmpty = chk.CheckEmpty(CCName);

            if (isString == false)
            {
                txtSearchCCName.BackColor = Color.FromArgb(244, 17, 17);
                SearcCCNValid = false;
            }
            else if (notEmpty == false)
            {
                txtSearchCCName.BackColor = Color.FromArgb(244, 17, 17);
                SearcCCNValid = false;
            }
            else
            {
                txtSearchCCName.BackColor = Color.White;
                SearcCCNValid = true;
            }
        }

        private void btnSearchCCSurname_Click(object sender, EventArgs e)
        {
            string CourseClientSurname = txtSearcCCSurname.Text;
            if (SearcCCSNValid == false)
            {

                MessageBox.Show("The Client surname was not entered. Please enter the Client surname that you want to search and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Search in DB
                MessageBox.Show("Searching " + CourseClientSurname, "It Worked");
            }
        }

        private void txtSearcCCSurname_TextChanged(object sender, EventArgs e)
        {
            txtSearcCCSurname.BackColor = Color.White;
            string CCSurname = txtSearcCCSurname.Text;
            bool isString = chk.Checkstring(CCSurname);
            bool notEmpty = chk.CheckEmpty(CCSurname);

            if (isString == false)
            {
                txtSearcCCSurname.BackColor = Color.FromArgb(244, 17, 17);
                SearcCCSNValid = false;
            }
            else if (notEmpty == false)
            {
                txtSearcCCSurname.BackColor = Color.FromArgb(244, 17, 17);
                SearcCCSNValid = false;
            }
            else
            {
                txtSearcCCSurname.BackColor = Color.White;
                SearcCCSNValid = true;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Add_Course_Client ac = new Add_Course_Client();
            ac.Show();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {

        }

        private void btnViewClient_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {

        }
    }
}
