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
    public partial class SearchCourse : Form
    {
        //test upload
        public SearchCourse()
        {
            InitializeComponent();
        }

        public static int ToUpdate;
        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool SearchCIsValid;
        int id;

        private void btnSearcCourseName_Click(object sender, EventArgs e)
        {
            string CourseName = txtSearchCourseName.Text;
            if (SearchCIsValid == false)
            {
                MessageBox.Show("The Course Name was not entered. Please enter the Course Name that you want to search and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Search in db



                MessageBox.Show("Searching " + CourseName, "It Worked");
            }
        }

        private void txtSearchCourseName_TextChanged(object sender, EventArgs e)
        {
            txtSearchCourseName.BackColor = Color.White;
            string stockDesc = txtSearchCourseName.Text;
            bool isString = chk.Checkstring(stockDesc);
            bool notEmpty = chk.CheckEmpty(stockDesc);

            if (isString == false)
            {
                txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                SearchCIsValid = false;
            }
            else if (notEmpty == false)
            {
                txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                SearchCIsValid = false;
            }
            else
            {
                txtSearchCourseName.BackColor = Color.White;
                SearchCIsValid = true;
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Create_Course c = new Create_Course();
            c.Show();
            dgvSearchCourse.Refresh();

        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Are you sure you want to delete this course?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (test == DialogResult.Yes)
            {
                //Delete Selected
                var mCourse = (from x in db.Courses where x.AvailableCourseID == id select x).First();
                db.Courses.DeleteOnSubmit(mCourse);
                db.SubmitChanges();

                //refresh DGV
                dgvSearchCourse.DataSource = null;
                dgvSearchCourse.DataSource = db.Courses;

                MessageBox.Show("Course has been deleted", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (test == DialogResult.No)
            {


                MessageBox.Show("Course not deleted", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            //View_Course vc = new View_Course();
            //vc.Show();

            

            if (dgvSearchCourse.SelectedCells.Count > 0)
            {
                Course _Course = (Course)dgvSearchCourse.CurrentRow.DataBoundItem;
                string CName = _Course.CourseName;
                int CID = _Course.AvailableCourseID;
                int CCost = Convert.ToInt32(_Course.CourseCost);
                int CDuration = Convert.ToInt32(_Course.CourseDuration);

                MessageBox.Show(" Course Name: " + CName + "\n Course ID: " + CID + "\n Course Duration: " + CDuration, "View Course", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            Update_Course uc = new Update_Course();
            uc.Show();
        }

        private void btnSearchCourseClient_Click(object sender, EventArgs e)
        {
            Search_Course_Client scc = new Search_Course_Client();
            scc.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenuF UM = new MainMenuF();
            UM.ShowDialog();
        }

        private void SearchCourse_Load(object sender, EventArgs e)
        {
            //Pre loads all the data from the printing supplier table
            var SC = from Course in db.Courses select Course;
            dgvSearchCourse.DataSource = SC;
            dgvSearchCourse.Refresh();
        }

        private void dgvSearchCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSearchCourse_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSearchCourse.SelectedCells.Count > 0)
            {
                Course _Course = (Course)dgvSearchCourse.CurrentRow.DataBoundItem;
                id = _Course.AvailableCourseID;
                ToUpdate = id;
            }
        }

        private void btnRefreshDGV_Click(object sender, EventArgs e)
        {
            dgvSearchCourse.DataSource = null;
            var SC = from Course in db.Courses select Course;
            dgvSearchCourse.DataSource = SC;
            dgvSearchCourse.Update();
            dgvSearchCourse.Refresh();
        }
    }
}

