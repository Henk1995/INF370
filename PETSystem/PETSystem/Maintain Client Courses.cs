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
    public partial class Maintain_Client_Courses : Form
    {
        public Maintain_Client_Courses()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();


        private void Maintain_Client_Courses_Load(object sender, EventArgs e)
        {
            AddCoursePanel.Visible = false;
            MSMain.Visible = true;
            AddCourseTypeP.Visible = false;
            MaintainTCPanel.Visible = false;
            dgvMaintainClientCourses.Visible = false;
            btnSave.Visible = false;
        }

        private void btnSubmitCouseDetails_Click(object sender, EventArgs e)
        {
            int InstructorID = 0;
            bool Duplicate = false;
            bool IsQualified = false;

            // get values from CMB's
            

            //Check for duplicate entry met course naam (CMB) en start date

            //check if duplicate
            DataTable dt = new DataTable();

            

            if (dt.Rows.Count == 0)
            {
                Duplicate = false;
            }
            else
            {
                Duplicate = true;
            }

            //Check if Inst is Qualified


        }

        private void btnSubmitNewCourseName_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (AddCoursePanel.Visible || AddCourseTypeP.Visible || MaintainTCPanel.Visible)
            {
                AddCoursePanel.Visible = false;
                MSMain.Visible = true;
                AddCourseTypeP.Visible = false;
                MaintainTCPanel.Visible = false;
                dgvMaintainClientCourses.Visible = false;
                btnSave.Visible = false;
            }
            else if (MSMain.Visible)
            {
                this.Close();
                Client_Course_Menu UM = new Client_Course_Menu();
                UM.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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

        }

        private void addTrainingCourseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchCourseName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
