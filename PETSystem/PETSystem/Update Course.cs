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
    public partial class Update_Course : Form
    {
        public Update_Course()
        {
            InitializeComponent();
        }

        int NewID = Maintain_Client_Courses.ToUpdate;
        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool CourseNValid;
        bool CourseCostValid;
        bool CourseDurationValid;
        


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchCourse scc = new SearchCourse();
            scc.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string CourseName = txtCourseName.Text;
            string CourseCost = txtCourseCost.Text;
            string CourseDuration = txtCourseDuration.Text;

            if (CourseNValid == false && CourseCostValid == false && CourseDurationValid == false)
            {
                MessageBox.Show("The information was not entered or entered incorrectly. Please re-enter the details and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (CourseNValid == false)
            {
                MessageBox.Show("The Course name was not entered. Please re-enter the Corse name and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CourseCostValid == false)
            {
                MessageBox.Show("The Course cost was not entered or entered incorrectly. Please re-enter the Course cost and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CourseDurationValid == false)
            {
                MessageBox.Show("The Course duration was not entered or entered incorrectly. Please re-enter the Course duration and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var mCourse = (from x in db.Courses where x.AvailableCourseID == Convert.ToInt32(NewID) select x).FirstOrDefault();


                mCourse.CourseName = CourseName;
                mCourse.CourseCost = Convert.ToInt32(CourseCost);
                mCourse.CourseDuration = Convert.ToString(CourseDuration);

                db.SubmitChanges();

                this.Close();

                MessageBox.Show("Added new course: " + CourseName + "\n Cost: R " + CourseCost + "" + "/n Running Time: " + CourseDuration, "It Worked");

                this.Close();

                Maintain_Client_Courses MCC = new Maintain_Client_Courses();
                MCC.ChangeTab(3);
                MCC.Show();

            }
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            txtCourseName.BackColor = Color.White;
            string CourseName = txtCourseName.Text;
            bool isString = chk.Checkstring(CourseName);
            bool notEmpty = chk.CheckEmpty(CourseName);
            bool checkForSQLInjection = chk.checkForSQLInjection(CourseName);

            if (isString == false)
            {
                txtCourseName.BackColor = Color.FromArgb(244, 17, 17);
                CourseNValid = false;
            }
            else if (notEmpty == false)
            {
                txtCourseName.BackColor = Color.FromArgb(244, 17, 17);
                CourseNValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                txtCourseName.BackColor = Color.FromArgb(244, 17, 17);
                CourseNValid = false;
            }
            else
            {
                txtCourseName.BackColor = Color.White;
                CourseNValid = true;
            }
        }

        private void txtCourseCost_TextChanged(object sender, EventArgs e)
        {
            string CourseCost = txtCourseCost.Text;
            txtCourseCost.BackColor = Color.White;
            bool isInt = chk.CheckInt(CourseCost);
            bool notEmpty = chk.CheckEmpty(CourseCost);
            bool checkForSQLInjection = chk.checkForSQLInjection(CourseCost);

            if (isInt == false)
            {
                txtCourseCost.BackColor = Color.FromArgb(244, 17, 17);
                CourseCostValid = false;
            }
            else if (notEmpty == false)
            {
                txtCourseCost.BackColor = Color.FromArgb(244, 17, 17);
                CourseCostValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                txtCourseCost.BackColor = Color.FromArgb(244, 17, 17);
                CourseCostValid = false;
            }
            else
            {
                txtCourseCost.BackColor = Color.White;
                CourseCostValid = true;
            }
        }

        private void txtCourseDuration_TextChanged(object sender, EventArgs e)
        {
            string CourseDuration = txtCourseDuration.Text;
            txtCourseDuration.BackColor = Color.White;
            bool isInt = chk.CheckInt(CourseDuration);
            bool notEmpty = chk.CheckEmpty(CourseDuration);
            bool checkForSQLInjection = chk.checkForSQLInjection(CourseDuration);

            if (isInt == false)
            {
                txtCourseDuration.BackColor = Color.FromArgb(244, 17, 17);
                CourseDurationValid = false;
            }
            else if (notEmpty == false)
            {
                txtCourseDuration.BackColor = Color.FromArgb(244, 17, 17);
                CourseDurationValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                txtCourseDuration.BackColor = Color.FromArgb(244, 17, 17);
                CourseDurationValid = false;
            }
            else
            {
                txtCourseDuration.BackColor = Color.White;
                CourseDurationValid = true;
            }
        }

        private void Update_Course_Load(object sender, EventArgs e)
        {
            //Load all fields from DB
            var mLoadCourse = (from x in db.Courses where x.AvailableCourseID == Convert.ToInt32(NewID) select x).FirstOrDefault();


             txtCourseName.Text = mLoadCourse.CourseName;
             txtCourseCost.Text= Convert.ToString(mLoadCourse.CourseCost);
             txtCourseDuration.Text = mLoadCourse.CourseDuration;


        }
    }
}
