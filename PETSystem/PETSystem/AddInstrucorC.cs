using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PETSystem
{
    public partial class AddInstrucorC : Form
    {
        SqlDataAdapter DA;
        public AddInstrucorC()
        {
            InitializeComponent();
        }

        private void AddInstrucorC_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.Clear();

            cmbName.Items.Clear();
            cmbStartdate.Items.Clear();
            cmbSurname.Items.Clear();
            string query1 = "SELECT CourseName FROM TrainingCourse ";
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query1, ConnectString.connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                cmbCourse.Items.Add(dr["CourseName"]).ToString();
            }
            ConnectString.connectstring.Close();
            string query2 = "SELECT TrainingCourseDate FROM TrainingCourse ";
            DataTable DT1 = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd1 = new SqlCommand(query2, ConnectString.connectstring);
            DA = new SqlDataAdapter(cmd1);
            DA.Fill(DT1);
            foreach (DataRow dr in DT1.Rows)
            {
                cmbStartdate.Items.Add(dr["TrainingCourseDate"]).ToString();
            }
            ConnectString.connectstring.Close();
            string query3 = "SELECT Name FROM Instructor ";
            DataTable DT2 = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd2 = new SqlCommand(query3, ConnectString.connectstring);
            DA = new SqlDataAdapter(cmd2);
            DA.Fill(DT2);
            foreach (DataRow dr in DT2.Rows)
            {
                cmbName.Items.Add(dr["Name"]).ToString();
            }
            ConnectString.connectstring.Close();
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query3 = "SELECT Surname FROM Instructor where Name = ' "+cmbName.Text+" ' ";
            DataTable DT2 = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd2 = new SqlCommand(query3, ConnectString.connectstring);
            DA = new SqlDataAdapter(cmd2);
            DA.Fill(DT2);
            foreach (DataRow dr in DT2.Rows)
            {
                cmbSurname.Items.Add(dr["Surname"]).ToString();
            }
            ConnectString.connectstring.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MaintainCourses UM = new MaintainCourses();
            UM.ShowDialog();
        }
    }
}
