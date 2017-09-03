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
    public partial class SearchInstructor : Form
    {
        ErrorHandle EH = new ErrorHandle();
        
        SqlDataAdapter DA;
        public SearchInstructor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Instructors UM = new Instructors();
            UM.Show();
        }

        private void txtInstructorID_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
            valid = EH.CheckInt(txtInstructorID.Text);
            bool validSQl = EH.checkForSQLInjection(txtInstructorID.Text);
            if (valid)
            {
                valid = validSQl;
            }
            if (valid)
            {
                txtInstructorID.BackColor = Color.White;
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("select * from Instructor where InstructorID like '" + txtInstructorID.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dgvInstructor.DataSource = DT;
                ConnectString.connectstring.Close();
            }
            else
            {
                txtInstructorID.BackColor = Color.FromArgb(249,29,29);
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvInstructor.DataSource = DT;
                dgvInstructor.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
            valid = EH.Checkstring(txtName.Text);
            bool validSQl = EH.checkForSQLInjection(txtInstructorID.Text);
            if (valid)
            {
                valid = validSQl;
            }
            if (valid)
            {
                txtName.BackColor = Color.White;
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("select * from Instructor where Name like '" + txtName.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dgvInstructor.DataSource = DT;
                ConnectString.connectstring.Close();
            }
            else
            {
                txtName.BackColor = Color.FromArgb(249, 29, 29);
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvInstructor.DataSource = DT;
                dgvInstructor.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
            valid = EH.Checkstring(txtSurname.Text);
            bool validSQl = EH.checkForSQLInjection(txtInstructorID.Text);
            if (valid)
            {
                valid = validSQl;
            }
            if (valid)
            {
                txtSurname.BackColor = Color.White;
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("select * from Instructor where Surname like '" + txtSurname.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dgvInstructor.DataSource = DT;
                ConnectString.connectstring.Close();
            }
            else
            {
                txtSurname.BackColor = Color.FromArgb(249, 29, 29);
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvInstructor.DataSource = DT;
                dgvInstructor.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void SearchInstructor_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
        }
    }
}
