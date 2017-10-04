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

        DateTime endOfTime;
        Timer t;
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
        {//Course name
            ToolTip TTNAME = new ToolTip();
            TTNAME.ToolTipTitle = "Name";
            TTNAME.UseFading = true;
            TTNAME.UseAnimation = true;
            TTNAME.IsBalloon = true;
            TTNAME.SetToolTip(cmbCourseName, "Select the course name here.");
            //instructor
            ToolTip TTINS = new ToolTip();
            TTINS.ToolTipTitle = "Instructor";
            TTINS.UseFading = true;
            TTINS.UseAnimation = true;
            TTINS.IsBalloon = true;
            TTINS.SetToolTip(cbInstructors, "Select the instructor's name here.");
            //startdate
            ToolTip TTSTART = new ToolTip();
            TTSTART.ToolTipTitle = "Start Date";
            TTSTART.UseFading = true;
            TTSTART.UseAnimation = true;
            TTSTART.IsBalloon = true;
            TTSTART.SetToolTip(txtStartDate, "Enter the start date here.\nformat dd/mm/yyy");
            //day of week
            ToolTip TTDAY = new ToolTip();
            TTDAY.ToolTipTitle = "Day";
            TTDAY.UseFading = true;
            TTDAY.UseAnimation = true;
            TTDAY.IsBalloon = true;
            TTDAY.SetToolTip(cbTimeslotDay, "Select the day of the week here");
            //timeslot 
            ToolTip TTTIME = new ToolTip();
            TTTIME.ToolTipTitle = "Time";
            TTTIME.UseFading = true;
            TTTIME.UseAnimation = true;
            TTTIME.IsBalloon = true;
            TTTIME.SetToolTip(cbTimeSlotTime, "Select the time of day here");
            //venu
            ToolTip TTVEN = new ToolTip();
            TTVEN.ToolTipTitle = "Venu";
            TTVEN.UseFading = true;
            TTVEN.UseAnimation = true;
            TTVEN.IsBalloon = true;
            TTVEN.SetToolTip(txtVenue, "Enter the venu here");
            //submit
            ToolTip TTSUB = new ToolTip();
            TTSUB.ToolTipTitle = "Submit";
            TTSUB.UseFading = true;
            TTSUB.UseAnimation = true;
            TTSUB.IsBalloon = true;
            TTSUB.SetToolTip(btnSubmitCouseDetails, "Click here to add new course");
            //Udape 
            ToolTip TTUPADAE = new ToolTip();
            TTUPADAE.ToolTipTitle = "Update";
            TTUPADAE.UseFading = true;
            TTUPADAE.UseAnimation = true;
            TTUPADAE.IsBalloon = true;
            TTUPADAE.SetToolTip(btnSave, "Click here to Update a course after selection.");
            //delete
            ToolTip TTDEL = new ToolTip();
            TTDEL.ToolTipTitle = "Delete";
            TTDEL.UseFading = true;
            TTDEL.UseAnimation = true;
            TTDEL.IsBalloon = true;
            TTDEL.SetToolTip(btnDelete, "Click here to Delete a course after selection.");
            //Course name
            ToolTip TTCOURSENAMAE = new ToolTip();
            TTCOURSENAMAE.ToolTipTitle = "Course Name";
            TTCOURSENAMAE.UseFading = true;
            TTCOURSENAMAE.UseAnimation = true;
            TTCOURSENAMAE.IsBalloon = true;
            TTCOURSENAMAE.SetToolTip(txtCourseName, "Eneter Course name here.");
            //CourseCost
            ToolTip TTCC = new ToolTip();
            TTCC.ToolTipTitle = "Course Cost";
            TTCC.UseFading = true;
            TTCC.UseAnimation = true;
            TTCC.IsBalloon = true;
            TTCC.SetToolTip(txtCourseCost, "Eneter Course Cost here.");
            //Corse Duratoom
            ToolTip TTDDD = new ToolTip();
            TTDDD.ToolTipTitle = "Duration";
            TTDDD.UseFading = true;
            TTDDD.UseAnimation = true;
            TTDDD.IsBalloon = true;
            TTDDD.SetToolTip(txtCourseDuration, "Eneter Course Duration here.");
            //Update
            ToolTip TTGGGG = new ToolTip();
            TTGGGG.ToolTipTitle = "Update";
            TTGGGG.UseFading = true;
            TTGGGG.UseAnimation = true;
            TTGGGG.IsBalloon = true;
            TTGGGG.SetToolTip(btnUpdateCourse, "Click here to update selection.");
            //Remove
            ToolTip TTGGGGg = new ToolTip();
            TTGGGGg.ToolTipTitle = "Remove";
            TTGGGGg.UseFading = true;
            TTGGGGg.UseAnimation = true;
            TTGGGGg.IsBalloon = true;
            TTGGGGg.SetToolTip(btnRemoveCourse, "Click here to Remove selection.");
            //Save
            ToolTip TTGGGGgg = new ToolTip();
            TTGGGGgg.ToolTipTitle = "Save";
            TTGGGGgg.UseFading = true;
            TTGGGGgg.UseAnimation = true;
            TTGGGGgg.IsBalloon = true;
            TTGGGGgg.SetToolTip(button1, "Click here to Save.");
            //Client Name
            ToolTip TTooo = new ToolTip();
            TTooo.ToolTipTitle = "Client name";
            TTooo.UseFading = true;
            TTooo.UseAnimation = true;
            TTooo.IsBalloon = true;
            TTooo.SetToolTip(txtSearchCCName, "Enter client name here to search it.");
            //Client Surname
            ToolTip TToooo = new ToolTip();
            TToooo.ToolTipTitle = "Client Surame";
            TToooo.UseFading = true;
            TToooo.UseAnimation = true;
            TToooo.IsBalloon = true;
            TToooo.SetToolTip(txtSearcCCSurname, "Enter client Surname here to search it.");
            //add
            ToolTip TToooox = new ToolTip();
            TToooox.ToolTipTitle = "Add";
            TToooox.UseFading = true;
            TToooox.UseAnimation = true;
            TToooox.IsBalloon = true;
            TToooox.SetToolTip(btnAddClient, "Click here to add a client.");
            //View
            ToolTip TTooooxx = new ToolTip();
            TTooooxx.ToolTipTitle = "View";
            TTooooxx.UseFading = true;
            TTooooxx.UseAnimation = true;
            TTooooxx.IsBalloon = true;
            TTooooxx.SetToolTip(btnViewClient, "Click here to View a client.");
            //Updatye
            ToolTip TTooooxxx = new ToolTip();
            TTooooxxx.ToolTipTitle = "Update";
            TTooooxxx.UseFading = true;
            TTooooxxx.UseAnimation = true;
            TTooooxxx.IsBalloon = true;
            TTooooxxx.SetToolTip(btnUpdateClient, "Click here to Update a client.");
            //Remove
            ToolTip TTooooxxxx = new ToolTip();
            TTooooxxxx.ToolTipTitle = "Remove";
            TTooooxxxx.UseFading = true;
            TTooooxxxx.UseAnimation = true;
            TTooooxxxx.IsBalloon = true;
            TTooooxxxx.SetToolTip(btnRemoveClient, "Click here to Remove a client.");
            //Back
            ToolTip TTooooxxxxx = new ToolTip();
            TTooooxxxxx.ToolTipTitle = "Back";
            TTooooxxxxx.UseFading = true;
            TTooooxxxxx.UseAnimation = true;
            TTooooxxxxx.IsBalloon = true;
            TTooooxxxxx.SetToolTip(btnRemoveClient, "Click here to return to previous.");

            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

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


            //var mLoadInstances = (from x in db.CourseInstances select x);
            //dgvMaintainClientCourses.DataSource = mLoadInstances;
            //dgvMaintainClientCourses.Columns[7].Visible = false;
            //dgvMaintainClientCourses.Columns[2].Visible = false;
            //dgvMaintainClientCourses.Columns[4].Visible = false;
            //dgvMaintainClientCourses.Columns[5].Visible = false;
            //dgvMaintainClientCourses.Columns[6].Visible = false;
            //dgvMaintainClientCourses.Refresh();

            LoadClientCourseInstanceInfo();



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
            if (dgvMaintainClientCourses.SelectedRows.Count > 0)
            {
                CourseInstance _ClientInCourse = (CourseInstance)dgvMaintainClientCourses.CurrentRow.DataBoundItem;
                string GetCourseName = Convert.ToString(dgvMaintainClientCourses.SelectedCells[1].Value);
                string GetInstName = Convert.ToString(dgvMaintainClientCourses.SelectedCells[2].Value);
                string GetTSD = Convert.ToString(dgvMaintainClientCourses.SelectedCells[3].Value);
                string GetTST = Convert.ToString(dgvMaintainClientCourses.SelectedCells[4].Value);
                string GetVenue = Convert.ToString(dgvMaintainClientCourses.SelectedCells[5].Value);
                string GetStartDate = Convert.ToString(dgvMaintainClientCourses.SelectedCells[6].Value);


                CourseInstanceToUpdate = (from x in db.CourseInstances where x.CourseVenu == GetVenue && x.StartDate == GetStartDate select x.CourseID).FirstOrDefault();
               
                UpdateClientCourseDetails UCCD = new UpdateClientCourseDetails();
                UCCD.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a row to add", "Error");
            }

           
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvMaintainClientCourses.SelectedRows.Count > 0)
            {
                CourseInstance _ClientInCourse = (CourseInstance)dgvMaintainClientCourses.CurrentRow.DataBoundItem;
                string GetCourseName = Convert.ToString(dgvMaintainClientCourses.SelectedCells[1].Value);
                string GetInstName = Convert.ToString(dgvMaintainClientCourses.SelectedCells[2].Value);
                string GetTSD = Convert.ToString(dgvMaintainClientCourses.SelectedCells[3].Value);
                string GetTST = Convert.ToString(dgvMaintainClientCourses.SelectedCells[4].Value);
                string GetVenue = Convert.ToString(dgvMaintainClientCourses.SelectedCells[5].Value);
                string GetStartDate = Convert.ToString(dgvMaintainClientCourses.SelectedCells[6].Value);

                //int NewAvailableCourseID = Convert.ToInt32(from x in db.Courses where x.CourseName == GetCourseName select x.AvailableCourseID);
                //int NewAvailableInstID = Convert.ToInt32(from x in db.Instructors where x.Name == GetInstName select x.InstructorID);
                //int NewTimeslot = Convert.ToInt32(from x in db.TimeSlots where x.TimeslotDay == GetTSD && x.TimeslotTime == GetTST select x.TimeSlotID);


                //id = Convert.ToInt32(from x in db.CourseInstances where x.AvailableCourseID == NewAvailableCourseID && x.InstructorID == NewAvailableInstID && x.TimeSlot == NewTimeslot && x.CourseVenu == GetVenue && x.StartDate == GetStartDate select x.CourseID;
                id = (from x in db.CourseInstances where  x.CourseVenu == GetVenue && x.StartDate == GetStartDate select x.CourseID).FirstOrDefault();

                //Check if there are Students registered in course


                bool doesItExistAlready = (from Active in db.ClientCourseLines
                                           where Active.CourseID == id
                                           select Active).Any();

                if (doesItExistAlready == false)
                {

                    DialogResult test = MessageBox.Show("Are you sure you want to delete this course?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (test == DialogResult.Yes)
                {
                    //Delete Selected
                    var mCourse = (from x in db.CourseInstances where x.CourseID == id select x).FirstOrDefault();
                    db.CourseInstances.DeleteOnSubmit(mCourse);
                    db.SubmitChanges();

                    //refresh DGV
                    LoadClientCourseInstanceInfo();

                    MessageBox.Show("Course has been deleted", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (test == DialogResult.No)
                {
                    MessageBox.Show("Course not deleted", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
                else
                {
                    MessageBox.Show("Cannot Course as thereare active courses running of this course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to add", "Error");
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
            //if (dgvMaintainClientCourses.SelectedCells.Count > 0)
            //{
            //    CourseInstance _CourseInstance = (CourseInstance)dgvMaintainClientCourses.CurrentRow.DataBoundItem;
            //    id = _CourseInstance.AvailableCourseID;
            //    CourseInstanceToUpdate = id;


            //}
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

        private void LoadClientCourseInstanceInfo()
        {
            foreach (var x in dgvMaintainClientCourses.Rows)
            {
                dgvMaintainClientCourses.Rows.Clear();

            }
            dgvMaintainClientCourses.Update();
            dgvMaintainClientCourses.Refresh();

            var mStockload = (from a in db.CourseInstances
                              select new
                              {
                                  a.StartDate,
                                  a.InstructorID,
                                  a.AvailableCourseID,
                                  a.CourseVenu,
                                  a.TimeSlot,
                                  a.CourseID
                              }).ToList();

            foreach (var item in mStockload)
            {
                int SInstructorID = Convert.ToInt32(item.InstructorID);
                int SAvailableCourseID = Convert.ToInt32(item.AvailableCourseID);
                string SCourseVenue = item.CourseVenu;
                int SCourseTime = Convert.ToInt32(item.TimeSlot);
                string SStartDate = item.StartDate;
                int SCourseID = item.CourseID;


                var getCourseName = (from x in db.Courses where x.AvailableCourseID == SAvailableCourseID select x.CourseName).FirstOrDefault();
                var getInstName = (from x in db.Instructors where x.InstructorID == SInstructorID select x.Name).FirstOrDefault();
                var getTSD = (from x in db.TimeSlots where x.TimeSlotID == SCourseTime select x.TimeslotDay).FirstOrDefault();
                var getTST = (from x in db.TimeSlots where x.TimeSlotID == SCourseTime select x.TimeslotTime).FirstOrDefault();
                

                dgvMaintainClientCourses.Rows.Add(new object[] { SCourseID, getCourseName, getInstName, getTSD, getTST, SCourseVenue, SStartDate});

            }

            dgvMaintainClientCourses.Update();
            dgvMaintainClientCourses.Refresh();

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

        private void Maintain_Client_Courses_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
