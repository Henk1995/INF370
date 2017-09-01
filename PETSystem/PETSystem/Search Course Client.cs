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

        PET_DBDataContext db = new PET_DBDataContext();
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

            if (SearcCCNValid == true)
            {
                var searchCCName = from Client in db.Clients
                                   where Client.ClientName.Contains(CCName)
                                 select Client;
                dgvCourseClient.DataSource = searchCCName;
                dgvCourseClient.Refresh();
            }
            else
            {
                dgvCourseClient.DataSource = null;
                var S = from Client in db.Clients select Client;
                dgvCourseClient.DataSource = S;
                dgvCourseClient.Update();
                dgvCourseClient.Refresh();
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

            if (SearcCCSNValid == true)
            {
                var searchCCSurName = from Client in db.Clients
                                      where Client.ClientSurname.Contains(CCSurname)
                                   select Client;
                dgvCourseClient.DataSource = searchCCSurName;
                dgvCourseClient.Refresh();
            }
            else
            {
                dgvCourseClient.DataSource = null;
                var S = from Client in db.Clients select Client;
                dgvCourseClient.DataSource = S;
                dgvCourseClient.Update();
                dgvCourseClient.Refresh();
            }

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Add_Course_Client ac = new Add_Course_Client();
            ac.Show();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            Update_Course_Client ucc = new Update_Course_Client();
            ucc.Show();
        }

        private void btnViewClient_Click(object sender, EventArgs e)
        {
            View_Course_Client vcc = new View_Course_Client();
            vcc.Show();
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Are you sure you want to delete this course client?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (test == DialogResult.Yes)
            {
                // LINQ query to remove selected course in dgv from the db

                MessageBox.Show("Course client has been deleted", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (test == DialogResult.No)
            {
                MessageBox.Show("Course client not deleted", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SearchCourse UM = new SearchCourse();
            UM.ShowDialog();
        }

        private void Search_Course_Client_Load(object sender, EventArgs e)
        {
            var SCC = from Client in db.Clients select Client;
            dgvCourseClient.DataSource = SCC;
            dgvCourseClient.Refresh();
        }

        private void btnRefreshDGV_Click(object sender, EventArgs e)
        {
            dgvCourseClient.DataSource = null;
            var SCC = from Client in db.Clients select Client;
            dgvCourseClient.DataSource = SCC;
            dgvCourseClient.Update();
            dgvCourseClient.Refresh();
        }
    }
}
