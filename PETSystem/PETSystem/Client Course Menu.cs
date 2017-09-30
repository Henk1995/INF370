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
                string GetCourseName = Convert.ToString(dgvTC.SelectedCells[0].Value);
                string GetInstName = Convert.ToString(dgvTC.SelectedCells[1].Value);
                string GetTSD = Convert.ToString(dgvTC.SelectedCells[2].Value);
                string GetTST = Convert.ToString(dgvTC.SelectedCells[3].Value);
                string GetVenue = Convert.ToString(dgvTC.SelectedCells[4].Value);
                string GetStartDate = Convert.ToString(dgvTC.SelectedCells[5].Value);

                int CourseClientLineID = (from x in db.CourseInstances where x.CourseVenu == GetVenue && x.StartDate == GetStartDate select x.CourseID).FirstOrDefault();

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

                

                int CourseClientLineID = (from x in db.CourseInstances where x.CourseVenu == GetVenue && x.StartDate == GetStartDate select x.CourseID).FirstOrDefault();

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

    }
}
