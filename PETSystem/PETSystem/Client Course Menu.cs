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
    public partial class Client_Course_Menu : Form
    {
        public Client_Course_Menu()
        {
            InitializeComponent();
        }
        DateTime endOfTime;
        Timer t;
        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool SearchCCNameValid;
        bool SearchCCtypeValid;
        public static int CourseClientLineID;
        int IDtoSend;
        

        private void btnMCourses_Click(object sender, EventArgs e)
        {
            this.Close();
            Maintain_Client_Courses mcc = new Maintain_Client_Courses();
            mcc.Show();
        }

        private void btnVMParticipants_Click(object sender, EventArgs e)
        {
            if (dgvTC.SelectedRows.Count > 0)
            {
                CourseInstance _ClientInCourse = (CourseInstance)dgvTC.CurrentRow.DataBoundItem;
                string GetCourseName = Convert.ToString(dgvTC.SelectedCells[1].Value);
                string GetInstName = Convert.ToString(dgvTC.SelectedCells[2].Value);
                string GetTSD = Convert.ToString(dgvTC.SelectedCells[3].Value);
                string GetTST = Convert.ToString(dgvTC.SelectedCells[4].Value);
                string GetVenue = Convert.ToString(dgvTC.SelectedCells[5].Value);
                string GetStartDate = Convert.ToString(dgvTC.SelectedCells[6].Value);

                CourseClientLineID = Convert.ToInt32(dgvTC.SelectedCells[0].Value);
               // CourseClientLineID = Convert.ToInt32(from x in db.CourseInstances where x.CourseVenu == GetVenue && x.StartDate == GetStartDate select x.CourseID);

                this.Close();
                ViewMaintainCourseClients vmcc = new ViewMaintainCourseClients();
                vmcc.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to add", "Error");
            }
        }

        private void btnMainM_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF scc = new MainMenuF();
            scc.Show();
        }

      

        private void Client_Course_Menu_Load(object sender, EventArgs e)
        {
            //ViewP
            ToolTip TTVP = new ToolTip();
            TTVP.ToolTipTitle = "View/Maintain Participants";
            TTVP.UseFading = true;
            TTVP.UseAnimation = true;
            TTVP.IsBalloon = true;
            TTVP.SetToolTip(btnVMParticipants, "Click here to view/maintain the participants of a selected course.");
            //Addres
            ToolTip TTADD = new ToolTip();
            TTADD.ToolTipTitle = "Add Result";
            TTADD.UseFading = true;
            TTADD.UseAnimation = true;
            TTADD.IsBalloon = true;
            TTADD.SetToolTip(btnAddResult, "Click here to add results to a selected course.");
            //Maintain Courses
            ToolTip TTMAINT = new ToolTip();
            TTMAINT.ToolTipTitle = "Maintain Courses";
            TTMAINT.UseFading = true;
            TTMAINT.UseAnimation = true;
            TTMAINT.IsBalloon = true;
            TTMAINT.SetToolTip(btnMCourses, "Click here to maintain courses.");
            //BAck
            ToolTip TTBACK = new ToolTip();
            TTBACK.ToolTipTitle = "Back";
            TTBACK.UseFading = true;
            TTBACK.UseAnimation = true;
            TTBACK.IsBalloon = true;
            TTBACK.SetToolTip(btnMainM, "Click here to retrn to previous screen.");
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            //var S = from CourseInstance in db.CourseInstances select CourseInstance;
            //dgvTC.DataSource = S;
            //dgvTC.Update();

            LoadClientCourseInstanceInfo();


        }

        private void dgvTC_SelectionChanged(object sender, EventArgs e)
        {
        //    if (dgvTC.SelectedCells.Count > 0)
        //    {
        //        CourseInstance mCourseInstance = (CourseInstance)dgvTC.CurrentRow.DataBoundItem;
        //        IDtoSend = mCourseInstance.CourseID;
        //        CourseClientLineID = IDtoSend;
        //    }
        }

        private void dgvTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            if (dgvTC.SelectedRows.Count > 0)
            {
                CourseInstance _ClientInCourse = (CourseInstance)dgvTC.CurrentRow.DataBoundItem;
                string GetCourseName = Convert.ToString(dgvTC.SelectedCells[1].Value);
                string GetInstName = Convert.ToString(dgvTC.SelectedCells[2].Value);
                string GetTSD = Convert.ToString(dgvTC.SelectedCells[3].Value);
                string GetTST = Convert.ToString(dgvTC.SelectedCells[4].Value);
                string GetVenue = Convert.ToString(dgvTC.SelectedCells[5].Value);
                string GetStartDate = Convert.ToString(dgvTC.SelectedCells[6].Value);


                CourseClientLineID = Convert.ToInt32(dgvTC.SelectedCells[0].Value);
               // CourseClientLineID = Convert.ToInt32(from x in db.CourseInstances where x.CourseVenu == GetVenue && x.StartDate == GetStartDate select x.CourseID);

                this.Close();
                AddClientResult ACR = new AddClientResult();
                ACR.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to add", "Error");
            }
        }

        private void LoadClientCourseInstanceInfo()
        {
            foreach (var x in dgvTC.Rows)
            {
                dgvTC.Rows.Clear();

            }
            dgvTC.Update();
            dgvTC.Refresh();

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


                dgvTC.Rows.Add(new object[] { SCourseID , getCourseName, getInstName, getTSD, getTST, SCourseVenue, SStartDate});

            }

            dgvTC.Update();
            dgvTC.Refresh();

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

        private void Client_Course_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
