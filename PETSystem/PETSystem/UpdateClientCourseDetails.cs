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
    public partial class UpdateClientCourseDetails : Form
    {
        public UpdateClientCourseDetails()
        {
            InitializeComponent();
        }
        DateTime endOfTime;
        Timer t;
        int AvailableCourseID = Maintain_Client_Courses.CourseInstanceToUpdate;
        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();

        bool NameValid;
        bool VenueValid;
        bool DateValid;

        private void UpdateClientCourseDetails_Load(object sender, EventArgs e)
        {
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            //Load CoursNames to CB
            var LoadCoursNamestoCB = from Course in db.Courses select Course.CourseName;
            cmbCourseName.DataSource = LoadCoursNamestoCB;

            //Load Instructor Names to CB
            var LoadInstructorstoCB = from Instructor in db.Instructors select Instructor.Name;
            cbInstructors.DataSource = LoadInstructorstoCB;


            //Load all fields from DB
            var mLoadCoursInstance = (from x in db.CourseInstances where x.AvailableCourseID == Convert.ToInt32(AvailableCourseID) select x).FirstOrDefault();


            txtStartDate.Text = mLoadCoursInstance.StartDate;
            txtVenue.Text = mLoadCoursInstance.CourseVenu;
            int TimeslotID = Convert.ToInt32(mLoadCoursInstance.TimeSlot);
            int InstructorID = mLoadCoursInstance.InstructorID;

            //select current Instructor
            var GetselectedInstName = (from Instructors in db.Instructors where Instructors.InstructorID == InstructorID select Instructors.Name).FirstOrDefault();
            cbInstructors.SelectedText = GetselectedInstName;

            //Select Current Course
            var GetSelectedCourse = (from Courses in db.Courses where Courses.AvailableCourseID == AvailableCourseID select Courses.CourseName).FirstOrDefault();
            cmbCourseName.SelectedText = GetSelectedCourse;

            //get Timeslot Info
            var GetTSDay = (from TS in db.TimeSlots where TS.TimeSlotID == TimeslotID select TS.TimeslotDay).FirstOrDefault();
            var GetTSTime = (from TS in db.TimeSlots where TS.TimeSlotID == TimeslotID select TS.TimeslotTime).FirstOrDefault();

            cbTimeslotDay.SelectedItem = GetTSDay;
            cbTimeSlotTime.SelectedItem = GetTSTime;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Maintain_Client_Courses MCC = new Maintain_Client_Courses();
            MCC.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string NewSelectedCourseName = cmbCourseName.Text;
            string NewSelectedInstructor = cbInstructors.Text;
            string NewStartDate = txtStartDate.Text;
            string DayOfWeek = cbTimeslotDay.Text;
            string Time = cbTimeSlotTime.Text;
            string NewVenue = txtVenue.Text;



            if (VenueValid == false && DateValid == false)
            {
                MessageBox.Show("The information was not entered or entered incorrectly. Please re-enter the details and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStartDate.BackColor = Color.FromArgb(244, 17, 17);
                txtVenue.BackColor = Color.FromArgb(244, 17, 17);
            }
            else if (DateValid == false)
            {
                MessageBox.Show("The Date was not entered or entered incorrectly. Please re-enter the Date and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStartDate.BackColor = Color.FromArgb(244, 17, 17);
            }
            else if (VenueValid == false)
            {
                MessageBox.Show("The Venue was not entered or entered incorrectly. Please re-enter the Venue and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVenue.BackColor = Color.FromArgb(244, 17, 17);
            }
            else
            {
                txtStartDate.BackColor = Color.White;
                txtVenue.BackColor = Color.White;

                //Get Course id
                var mLoadCourseID = (from x in db.Courses where x.CourseName == NewSelectedCourseName select x).FirstOrDefault();

                int CourseID = mLoadCourseID.AvailableCourseID;

                //Get inst id
                var mLoadInstID = (from x in db.Instructors where x.Name == NewSelectedInstructor select x).FirstOrDefault();

                int InstID = mLoadInstID.InstructorID;

                //Get TimeslotID
                var mGetTSID = (from x in db.TimeSlots where x.TimeslotDay == DayOfWeek && x.TimeslotTime == Time select x).FirstOrDefault();

                int TimeslotID = mGetTSID.TimeSlotID;

                CourseInstance mInstance = new CourseInstance
                {

                    AvailableCourseID = CourseID,
                    InstructorID = InstID,
                    TimeSlot = TimeslotID,
                    CourseVenu = NewVenue,
                    StartDate = NewStartDate

                };

                db.CourseInstances.InsertOnSubmit(mInstance);
                db.SubmitChanges();

                MessageBox.Show("Course Instance Updated");

                this.Close();
                
                Maintain_Client_Courses MCC = new Maintain_Client_Courses();
                MCC.ChangeTab(1);
                MCC.Show();

            }
        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {
            txtStartDate.BackColor = Color.White;
            string date = txtStartDate.Text;
            bool isString = chk.CheckDate(date);
            bool notEmpty = chk.CheckEmpty(date);
            bool checkForSQLInjection = chk.checkForSQLInjection(date);

            if (isString == false)
            {
                //txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                DateValid = false;
            }
            else if (notEmpty == false)
            {
                //txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                DateValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                //txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                DateValid = false;
            }
            else
            {
                txtStartDate.BackColor = Color.White;
                DateValid = true;
            }
        }

        private void txtVenue_TextChanged(object sender, EventArgs e)
        {
            txtVenue.BackColor = Color.White;
            string Name = txtVenue.Text;
            bool isString = chk.Checkstring(Name);
            bool notEmpty = chk.CheckEmpty(Name);
            bool checkForSQLInjection = chk.checkForSQLInjection(Name);

            if (isString == false)
            {
                //txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                VenueValid = false;
            }
            else if (notEmpty == false)
            {
                //txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                VenueValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                //txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                VenueValid = false;
            }
            else
            {
                txtVenue.BackColor = Color.White;
                VenueValid = true;
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

        private void UpdateClientCourseDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
