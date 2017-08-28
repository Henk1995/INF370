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
    public partial class MaintainCourses : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        SqlDataAdapter DA;
        ErrorHandle EH = new ErrorHandle();
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        bool valid5 = false;
        bool valid6 = false;
        bool valid7 = false;
        public MaintainCourses()
        {
            InitializeComponent();
        }

        private void MaintainCourses_Load(object sender, EventArgs e)
        {
            AddCoursePanel.Visible = false;
            MSMain.Visible = true;
            AddCourseTypeP.Visible = false;
            MaintainTCPanel.Visible = false;
            dgvMaintain.Visible = false;
            btnSave.Visible = false;
        }

        private void addTrainingCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCoursePanel.Visible = true;
            MSMain.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(AddCoursePanel.Visible || AddCourseTypeP.Visible || MaintainTCPanel.Visible)
            {
                AddCoursePanel.Visible = false;
                MSMain.Visible = true;
                AddCourseTypeP.Visible = false;
                MaintainTCPanel.Visible = false;
                dgvMaintain.Visible = false;
                btnSave.Visible = false;
            }
            else if(MSMain.Visible)
            {
                this.Visible = false;
                TrainingCourseMenu UM = new TrainingCourseMenu();
                UM.ShowDialog();
            }
        }

        private void addTrainingCourseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseTypeP.Visible = true;
            MSMain.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maintainTrainingCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintainTCPanel.Visible = true;
            dgvMaintain.Visible = true;
            btnSave.Visible = true;
            MSMain.Visible = false;
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Courses", connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvMaintain.DataSource = DT;
            dgvMaintain.DataMember = DT.TableName;
            connectstring.Close();
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            valid1 = EH.Checkstring(txtCourseName.Text);
            if(!valid1)
            {
                txtCourseName.BackColor = Color.Red;
            }else
            {
                txtCourseName.BackColor = Color.White;
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            valid2 = EH.CheckInt(txtYear.Text);
            if (!valid2)
            {
                txtYear.BackColor = Color.Red;
            }
            else
            {
                txtYear.BackColor = Color.White;
            }
        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.CheckDate(txtStartDate.Text);
            if (!valid3)
            {
                txtStartDate.BackColor = Color.Red;
            }
            else
            {
                txtStartDate.BackColor = Color.White;
            }
        }

        private void txtVenue_TextChanged(object sender, EventArgs e)
        {
            valid4 = EH.Checkstring(txtVenue.Text);
            if (!valid4)
            {
                txtVenue.BackColor = Color.Red;
            }
            else
            {
                txtVenue.BackColor = Color.White;
            }
        }

        private void txtNCDName_TextChanged(object sender, EventArgs e)
        {
            valid5 = EH.Checkstring(txtNCDName.Text);
            if (!valid5)
            {
                txtNCDName.BackColor = Color.Red;
            }
            else
            {
                txtNCDName.BackColor = Color.White;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
