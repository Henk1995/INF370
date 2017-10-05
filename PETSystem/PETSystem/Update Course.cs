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
    public partial class Update_Course : Form
    {
        public Update_Course()
        {
            InitializeComponent();
        }
        DateTime endOfTime;
        Timer t;

        int NewID = Maintain_Client_Courses.ToUpdate;
        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool CourseNValid;
        bool CourseCostValid;
        bool CourseDurationValid;
        


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Maintain_Client_Courses scc = new Maintain_Client_Courses();
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
            //Coursename
            ToolTip TTNAME = new ToolTip();
            TTNAME.ToolTipTitle = "Name";
            TTNAME.UseFading = true;
            TTNAME.UseAnimation = true;
            TTNAME.IsBalloon = true;
            TTNAME.SetToolTip(txtCourseName, "Enter  course name here.");
            //CourseCost
            ToolTip TTC = new ToolTip();
            TTC.ToolTipTitle = "Cost";
            TTC.UseFading = true;
            TTC.UseAnimation = true;
            TTC.IsBalloon = true;
            TTC.SetToolTip(txtCourseCost, "Enter  course cost here.");
            //CourseDuration
            ToolTip TTD = new ToolTip();
            TTD.ToolTipTitle = "Duration";
            TTD.UseFading = true;
            TTD.UseAnimation = true;
            TTD.IsBalloon = true;
            TTD.SetToolTip(txtCourseDuration, "Enter  course duration here.");
            //Update
            ToolTip TTUPS = new ToolTip();
            TTUPS.ToolTipTitle = "Update";
            TTUPS.UseFading = true;
            TTUPS.UseAnimation = true;
            TTUPS.IsBalloon = true;
            TTUPS.SetToolTip(btnSave, "Click to update course.");
            //Cancel
            ToolTip TTCAN = new ToolTip();
            TTCAN.ToolTipTitle = "Cancel";
            TTCAN.UseFading = true;
            TTCAN.UseAnimation = true;
            TTCAN.IsBalloon = true;
            TTCAN.SetToolTip(btnCancel, "Click to cancel update.");
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            //Load all fields from DB
            var mLoadCourse = (from x in db.Courses where x.AvailableCourseID == Convert.ToInt32(NewID) select x).FirstOrDefault();


             txtCourseName.Text = mLoadCourse.CourseName;
             txtCourseCost.Text= Convert.ToString(mLoadCourse.CourseCost);
             txtCourseDuration.Text = mLoadCourse.CourseDuration;


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

        private void Update_Course_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
