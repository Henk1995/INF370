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


            this.Close();
            ViewMaintainCourseClients vmcc = new ViewMaintainCourseClients();
            vmcc.Show();
        }

        private void btnMainM_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchCourse scc = new SearchCourse();
            scc.Show();
        }

        private void txtCourseN_TextChanged(object sender, EventArgs e)
        {
            txtCourseN.BackColor = Color.White;
            string PrintSupplierName = txtCourseN.Text;
            bool isString = chk.Checkstring(PrintSupplierName);
            bool notEmpty = chk.CheckEmpty(PrintSupplierName);

            if (isString == false)
            {
                txtCourseN.BackColor = Color.FromArgb(244, 17, 17);
                SearchCCNameValid = false;
            }
            else if (notEmpty == false)
            {
                txtCourseN.BackColor = Color.FromArgb(244, 17, 17);
                SearchCCNameValid = false;
            }
            else
            {
                txtCourseN.BackColor = Color.White;
                SearchCCNameValid = true;
            }

            if (SearchCCNameValid == true)
            {
                var searchDesc = from CourseInstance in db.CourseInstances
                                 where CourseInstance.AvailableCourseID == (Convert.ToInt32(txtCourseN.Text))
                                 select CourseInstance;
                dgvTC.DataSource = searchDesc;
                dgvTC.Refresh();
            }
            else
            {
                dgvTC.DataSource = null;
                var S = from CourseInstance in db.CourseInstances select CourseInstance;
                dgvTC.DataSource = S;
                dgvTC.Update();
                dgvTC.Refresh();
            }
        }

        private void Client_Course_Menu_Load(object sender, EventArgs e)
        {
            var S = from CourseInstance in db.CourseInstances select CourseInstance;
            dgvTC.DataSource = S;
            dgvTC.Update();
        }

        private void dgvTC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTC.SelectedCells.Count > 0)
            {
                CourseInstance mCourseInstance = (CourseInstance)dgvTC.CurrentRow.DataBoundItem;
                IDtoSend = mCourseInstance.CourseID;
            }
        }
    }
}
