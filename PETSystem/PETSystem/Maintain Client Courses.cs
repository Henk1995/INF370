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

        public void ChangeTab(int tabIndex)
        {
            tabControl1.SelectedIndex = tabIndex;
        }


        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();

        //Maintain Client Course
        bool NameValid;
        bool VenueValid;
        bool DateValid;
        int id;
        public static int ToUpdate;
        public static int CourseInstanceToUpdate;

        //Add Client Course
        bool CourseNValid;
        bool CourseCostValid;
        bool CourseDurationValid;

        //Maintain Course Type
        bool SearchCIsValid;

        //Course Client
        bool SearcCCNValid;
        bool SearcCCSNValid;
        public static int CourseClientToUpdate;

        private void Maintain_Client_Courses_Load(object sender, EventArgs e)
        {
            //Load course client details
            var SCC = from Client in db.Clients select Client;
            dgvCourseClient.DataSource = SCC;
            dgvCourseClient.Columns[0].Visible = false;
            dgvCourseClient.Columns[5].Visible = false;
            dgvCourseClient.Columns[6].Visible = false;
            dgvCourseClient.Columns[7].Visible = false;
            dgvCourseClient.Columns[8].Visible = false;
            dgvCourseClient.Refresh();

            //Pre loads all the data from the printing supplier table
            var SC = from Course in db.Courses select Course;
            dgvSearchCourse.DataSource = SC;
            dgvSearchCourse.Columns[0].Visible = false;
            dgvSearchCourse.Columns[4].Visible = false;
            dgvSearchCourse.Columns[5].Visible = false;
            dgvSearchCourse.Refresh();


            //Load CoursNames to CB
            var LoadCoursNamestoCB = from Course in db.Courses select Course.CourseName;
            cmbCourseName.DataSource = LoadCoursNamestoCB;

            //Load Instructor Names to CB
            var LoadInstructorstoCB = from Instructor in db.Instructors select Instructor.Name;
            cbInstructors.DataSource = LoadInstructorstoCB;


            var mLoadInstances = from x in db.CourseInstances select x;

            //dgvMaintainClientCourses.AutoGenerateColumns = false;
            dgvMaintainClientCourses.DataSource = mLoadInstances;
            dgvMaintainClientCourses.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
            Client_Course_Menu UM = new Client_Course_Menu();
            UM.Show();

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


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            UpdateClientCourseDetails UCCD = new UpdateClientCourseDetails();
            UCCD.Show();
            this.Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
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

        private void txtSearchCourseName_TextChanged_1(object sender, EventArgs e)
        {
            txtSearchCourseName.BackColor = Color.White;
            string Name = txtSearchCourseName.Text;
            bool isString = chk.CheckInt(Name);
            bool notEmpty = chk.CheckEmpty(Name);
            bool checkForSQLInjection = chk.checkForSQLInjection(Name);

            if (isString == false)
            {
                txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else if (notEmpty == false)
            {
                txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else
            {
                txtSearchCourseName.BackColor = Color.White;
                NameValid = true;
            }

            if (NameValid == true)
            {
                //var idToSearch = (from Courses in db.Courses where Courses.CourseName.Contains(Name) select Courses.AvailableCourseID).FirstOrDefault();

                //int SearchID = Convert.ToInt32(idToSearch);

                int x = Convert.ToInt32(txtSearchCourseName.Text);

                var IDtoDisplay = from CourseInstance in db.CourseInstances
                                  where CourseInstance.AvailableCourseID == x
                                  select CourseInstance;

                dgvMaintainClientCourses.DataSource = null;
                dgvMaintainClientCourses.DataSource = IDtoDisplay;
                dgvMaintainClientCourses.Update();
                dgvMaintainClientCourses.Refresh();
            }
            else
            {
                var SC = from CourseInstance in db.CourseInstances select CourseInstance;
                dgvMaintainClientCourses.DataSource = SC;
                dgvMaintainClientCourses.Update();
                dgvMaintainClientCourses.Refresh();
            }
        }

        private void btnSubmitCouseDetails_Click_1(object sender, EventArgs e)
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

                txtVenue.Clear();
                txtStartDate.Clear();

            }
        }

        private void dgvMaintainClientCourses_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvMaintainClientCourses.SelectedCells.Count > 0)
            {
                CourseInstance _CourseInstance = (CourseInstance)dgvMaintainClientCourses.CurrentRow.DataBoundItem;
                id = _CourseInstance.AvailableCourseID;
                CourseInstanceToUpdate = id;


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCourseCost.Clear();
            txtCourseDuration.Clear();
            txtCourseName.Clear();

            MessageBox.Show("No Course types were added");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CourseName = txtCourseName.Text;
            string CourseCost = txtCourseCost.Text;
            string CourseDuration = txtCourseDuration.Text;

            if (CourseNValid == false && CourseCostValid == false && CourseDurationValid == false)
            {
                MessageBox.Show("The information was not entered or entered incorrectly. Please re-enter the details and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCourseName.BackColor = Color.FromArgb(244, 17, 17);
                txtCourseCost.BackColor = Color.FromArgb(244, 17, 17);
                txtCourseDuration.BackColor = Color.FromArgb(244, 17, 17);
            }
            else if (CourseNValid == false)
            {
                txtCourseName.BackColor = Color.FromArgb(244, 17, 17);
                MessageBox.Show("The Course name was not entered. Please re-enter the Corse name and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CourseCostValid == false)
            {
                txtCourseCost.BackColor = Color.FromArgb(244, 17, 17);
                MessageBox.Show("The Course cost was not entered or entered incorrectly. Please re-enter the Course cost and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CourseDurationValid == false)
            {
                txtCourseDuration.BackColor = Color.FromArgb(244, 17, 17);
                MessageBox.Show("The Course duration was not entered or entered incorrectly. Please re-enter the Course duration and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Course mCourse = new Course
                {
                    CourseName = txtCourseName.Text,
                    CourseCost = Convert.ToInt32(txtCourseCost.Text),
                    CourseDuration = txtCourseDuration.Text



                };

                db.Courses.InsertOnSubmit(mCourse);
                db.SubmitChanges();

                txtCourseName.Text = "";
                txtCourseCost.Text = "";
                txtCourseDuration.Text = "";

                MessageBox.Show("Added new course: " + CourseName + "\n Cost: R " + CourseCost + "" + "/n Running Time: " + CourseDuration, "It Worked");

                dgvSearchCourse.DataSource = null;

                var SC = from Course in db.Courses select Course;


                dgvSearchCourse.DataSource = SC;
                dgvSearchCourse.Columns[0].Visible = false;
                dgvSearchCourse.Columns[4].Visible = false;
                dgvSearchCourse.Columns[5].Visible = false;
                dgvSearchCourse.Refresh();
            }
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            txtCourseName.BackColor = Color.White;
            string CourseName = txtCourseName.Text;
            bool isString = chk.Checkstring(CourseName);
            bool notEmpty = chk.CheckEmpty(CourseName);

            if (isString == false)
            {
                CourseNValid = false;
            }
            else if (notEmpty == false)
            {
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

            if (isInt == false)
            {
                CourseCostValid = false;
            }
            else if (notEmpty == false)
            {
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

            if (isInt == false)
            {
                //txtCourseDuration.BackColor = Color.FromArgb(244, 17, 17);
                CourseDurationValid = false;
            }
            else if (notEmpty == false)
            {
                CourseDurationValid = false;
            }
            else
            {
                txtCourseDuration.BackColor = Color.White;
                CourseDurationValid = true;
            }
        }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
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
            this.Close();
            Update_Course uc = new Update_Course();
            uc.Show();
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

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {

            DialogResult test = MessageBox.Show("Are you sure you want to delete this course?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (test == DialogResult.Yes)
            {
                bool doesItExistAlready = (from Instance in db.CourseInstances
                                           where Instance.AvailableCourseID == id
                                           select Instance).Any();

                if (doesItExistAlready == false)
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
                else
                {
                    MessageBox.Show("Cannot Course as thereare active courses running of this course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (test == DialogResult.No)
            {


                MessageBox.Show("Course not deleted", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtSearchCourseName.BackColor = Color.White;
            string CourseName = txtSearchCourseName.Text;
            bool isString = chk.Checkstring(CourseName);
            bool notEmpty = chk.CheckEmpty(CourseName);
            bool checkForSQLInjection = chk.checkForSQLInjection(CourseName);

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
            else if (checkForSQLInjection == false)
            {
                txtSearchCourseName.BackColor = Color.FromArgb(244, 17, 17);
                SearchCIsValid = false;
            }
            else
            {
                txtSearchCourseName.BackColor = Color.White;
                SearchCIsValid = true;
            }



            if (SearchCIsValid == true)
            {
                var searchDesc = from Course in db.Courses
                                 where Course.CourseName.Contains(CourseName)
                                 select Course;
                dgvSearchCourse.DataSource = searchDesc;
            }
            else
            {
                var SC = from Course in db.Courses select Course;
                dgvSearchCourse.DataSource = SC;
                dgvSearchCourse.Update();
                dgvSearchCourse.Refresh();
            }

        }

        private void txtSearchCCName_TextChanged(object sender, EventArgs e)
        {
            txtSearchCCName.BackColor = Color.White;
            string CCName = txtSearchCCName.Text;
            bool isString = chk.Checkstring(CCName);
            bool notEmpty = chk.CheckEmpty(CCName);
            bool SQLInjection = chk.checkForSQLInjection(CCName);

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
            else if (SQLInjection == false)
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

        private void txtSearcCCSurname_TextChanged(object sender, EventArgs e)
        {
            txtSearcCCSurname.BackColor = Color.White;
            string CCSurname = txtSearcCCSurname.Text;
            bool isString = chk.Checkstring(CCSurname);
            bool notEmpty = chk.CheckEmpty(CCSurname);
            bool checkForSQLInjection = chk.checkForSQLInjection(CCSurname);

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
            else if (checkForSQLInjection == false)
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
                dgvCourseClient.Columns[0].Visible = false;
                dgvCourseClient.Columns[5].Visible = false;
                dgvCourseClient.Columns[6].Visible = false;
                dgvCourseClient.Columns[7].Visible = false;
                dgvCourseClient.Columns[8].Visible = false;
                dgvCourseClient.Update();
                dgvCourseClient.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvCourseClient.DataSource = null;
            var SCC = from Client in db.Clients select Client;
            dgvCourseClient.DataSource = SCC;
            dgvCourseClient.Columns[0].Visible = false;
            dgvCourseClient.Columns[5].Visible = false;
            dgvCourseClient.Columns[6].Visible = false;
            dgvCourseClient.Columns[7].Visible = false;
            dgvCourseClient.Columns[8].Visible = false;
            dgvCourseClient.Update();
            dgvCourseClient.Refresh();
        }

        private void dgvCourseClient_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourseClient.SelectedCells.Count > 0)
            {
                Client _Client = (Client)dgvCourseClient.CurrentRow.DataBoundItem;
                id = _Client.ClientID;
                CourseClientToUpdate = id;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            this.Close();
            Add_Course_Client acc = new Add_Course_Client();
            acc.Show();
        }

        private void btnViewClient_Click(object sender, EventArgs e)
        {
            if (dgvCourseClient.SelectedCells.Count > 0)
            {
                Client _PS = (Client)dgvCourseClient.CurrentRow.DataBoundItem;
                string psName = _PS.ClientName;
                string psSurnme = _PS.ClientSurname;
                string psEmail = _PS.ClientEmail;
                int psPhone = Convert.ToInt32(_PS.ClientPhoneNumber);
                int psGenderID = Convert.ToInt32(_PS.GenderID);

                var getGender = (from x in db.Genders where x.GenderID == psGenderID select x.GenderName).FirstOrDefault();

                string gen = Convert.ToString(getGender);


                MessageBox.Show("Client Name: " + psName + "\n Client Surname: " + psSurnme + "\n Email Address: " + psEmail + "\n Phone Number: " + psPhone + "\n Gender: " + gen, "View Course",
    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            this.Close();
            Update_Course_Client ucc = new Update_Course_Client();
            ucc.Show();
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Are you sure you want to delete this course client?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (test == DialogResult.Yes)
            {
                bool doesItExistAlready = (from ClientCourseLine in db.ClientCourseLines
                                           where ClientCourseLine.ClientID == id
                                           select ClientCourseLine).Any();

                if (doesItExistAlready == false)
                {
                    //Delete Selected
                    var mClient = (from x in db.Clients where x.ClientID == id select x).First();
                    db.Clients.DeleteOnSubmit(mClient);
                    db.SubmitChanges();

                    //refresh DGV
                    dgvCourseClient.DataSource = null;
                    var SCC = from Client in db.Clients select Client;
                    dgvCourseClient.DataSource = SCC;
                    dgvCourseClient.Columns[0].Visible = false;
                    dgvCourseClient.Columns[5].Visible = false;
                    dgvCourseClient.Columns[6].Visible = false;
                    dgvCourseClient.Columns[7].Visible = false;
                    dgvCourseClient.Columns[8].Visible = false;
                    dgvCourseClient.Update();
                    dgvCourseClient.Refresh();

                    MessageBox.Show("Course client has been deleted", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cannot Delete Client as the client is in an active course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else if (test == DialogResult.No)
            {
                MessageBox.Show("Course client not deleted", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
