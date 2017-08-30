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
    public partial class TrainingCourseMenu : Form
    {
        
        SqlDataAdapter DA;
        public TrainingCourseMenu()
        {
            InitializeComponent();
        }

        private void btnMainM_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenuF UM = new MainMenuF();
            UM.ShowDialog();
        }

        private void btnMCourses_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MaintainCourses UM = new MaintainCourses();
            UM.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {

        }

        private void TrainingCourseMenu_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM TrainingCourse", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvTC.DataSource = DT;
            dgvTC.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
        }

        private void txtCourseN_TextChanged(object sender, EventArgs e)
        {
            ConnectString.connectstring.Open();
            DA = new SqlDataAdapter("select * from TrainingCourse where CourseName like '" + txtCourseN.Text + "%'", ConnectString.connectstring);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dgvTC.DataSource = DT;
            ConnectString.connectstring.Close();
        }
    }
}
