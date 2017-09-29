using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace PETSystem
{
    public partial class Maintain_Client_Courses : Form
    {
        public Maintain_Client_Courses()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool NameValid;
        bool VenueValid;
        bool DateValid;
        int id;
        public static int ToUpdate;

        private void Maintain_Client_Courses_Load(object sender, EventArgs e)
        {
            AddCoursePanel.Visible = false;
            MSMain.Visible = true;
            MaintainTCPanel.Visible = false;
            dgvMaintainClientCourses.Visible = false;
            btnSave.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnSubmitCouseDetails_Click(object sender, EventArgs e)
        {
            // get values from form
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

                MessageBox.Show("Course Instance Added");

                AddCoursePanel.Visible = false;
                MSMain.Visible = true;
                MaintainTCPanel.Visible = false;
                dgvMaintainClientCourses.Visible = false;
                btnSave.Visible = false;
                btnDelete.Visible = false;

                txtVenue.Clear();
                txtStartDate.Clear();

            }

        }

        private void btnSubmitNewCourseName_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (AddCoursePanel.Visible || MaintainTCPanel.Visible)
            {
                AddCoursePanel.Visible = false;
                MSMain.Visible = true;
                MaintainTCPanel.Visible = false;
                dgvMaintainClientCourses.Visible = false;
                btnSave.Visible = false;
                btnDelete.Visible = false;
            }
            else if (MSMain.Visible)
            {
                this.Close();
                Client_Course_Menu UM = new Client_Course_Menu();
                UM.Show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateClientCourseDetails UCCD = new UpdateClientCourseDetails();
            UCCD.Show();
            this.Close();
        }

        private void addTrainingCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCoursePanel.Visible = true;
            MSMain.Visible = false;


            //Load CoursNames to CB
            var LoadCoursNamestoCB = from Course in db.Courses select Course.CourseName;
            cmbCourseName.DataSource = LoadCoursNamestoCB;

            //Load Instructor Names to CB
            var LoadInstructorstoCB = from Instructor in db.Instructors select Instructor.Name;
            cbInstructors.DataSource = LoadInstructorstoCB;

        }

        private void maintainTrainingCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            MaintainTCPanel.Visible = true;
            dgvMaintainClientCourses.Visible = true;
            btnSave.Visible = true;
            MSMain.Visible = false;

            var mLoadInstances = from x in db.CourseInstances select x;

            //dgvMaintainClientCourses.AutoGenerateColumns = false;
            dgvMaintainClientCourses.DataSource = mLoadInstances;
            dgvMaintainClientCourses.Refresh();
        }

        private void addTrainingCourseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchCourseName_TextChanged(object sender, EventArgs e)
        {
            txtSearchCourseName.BackColor = Color.White;
            string Name = txtSearchCourseName.Text;
            bool isString = chk.Checkstring(Name);
            bool notEmpty = chk.CheckEmpty(Name);
            bool checkForSQLInjection = chk.checkForSQLInjection(Name);

            if (isString == false)
            {
                //txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else if (notEmpty == false)
            {
                //txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                //txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else
            {
                txtSearchCourseName.BackColor = Color.White;
                NameValid = true;
            }

            if (NameValid == true)
            {
                var idToSearch = (from Courses in db.Courses where Courses.CourseName.Contains(Name) select Courses.AvailableCourseID).FirstOrDefault();

                int SearchID = Convert.ToInt32(idToSearch);

                var IDtoDisplay = from CourseInstance in db.CourseInstances
                                 where CourseInstance.AvailableCourseID == SearchID
                                 select CourseInstance;
                dgvMaintainClientCourses.DataSource = IDtoDisplay;
            }
            else
            {
                var SC = from CourseInstance in db.CourseInstances select CourseInstance;
                dgvMaintainClientCourses.DataSource = SC;
                dgvMaintainClientCourses.Update();
                dgvMaintainClientCourses.Refresh();
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

        private void dgvMaintainClientCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMaintainClientCourses.SelectedCells.Count > 0)
            {
                //    int selectedIndex = dgvSearchCourse.SelectedRows[0].Index;

                //    // gets the RowID from the first column in the grid
                //    ToUpdate = int.Parse(dgvSearchCourse[0, selectedIndex].Value.ToString());

                CourseInstance _CourseInstance = (CourseInstance)dgvMaintainClientCourses.CurrentRow.DataBoundItem;
                id = _CourseInstance.AvailableCourseID;
                ToUpdate = id;


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Are you sure you want to delete this course?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (test == DialogResult.Yes)
            {
                //Delete Selected
                var mCourse = (from x in db.CourseInstances where x.AvailableCourseID == id select x).First();
                db.CourseInstances.DeleteOnSubmit(mCourse);
                db.SubmitChanges();

                //refresh DGV
                dgvMaintainClientCourses.DataSource = null;
                dgvMaintainClientCourses.DataSource = db.CourseInstances;

                MessageBox.Show("Course has been deleted", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (test == DialogResult.No)
            {
                MessageBox.Show("Course not deleted", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
