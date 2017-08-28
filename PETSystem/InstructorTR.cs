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
    public partial class InstructorTR : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        ErrorHandle EH = new ErrorHandle();
        SqlDataAdapter DA;
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        public InstructorTR()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Instructors UM = new Instructors();
            UM.ShowDialog();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            valid1 = EH.Checkstring(txtName.Text);
            if(!valid1)
            {
                txtName.BackColor = Color.Red;

            }else
            {
                txtName.BackColor = Color.White;
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            valid2 = EH.Checkstring(txtSurname.Text);
            if (!valid2)
            {
                txtSurname.BackColor = Color.Red;

            }
            else
            {
                txtSurname.BackColor = Color.White;
            }
        }

        private void txtInstructorID_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.CheckInt(txtInstructorID.Text);
            if (!valid3)
            {
                txtInstructorID.BackColor = Color.Red;

            }
            else
            {
                txtInstructorID.BackColor = Color.White;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(valid1&&valid2&&valid3)
            {
                MessageBox.Show("Name:\n Surname:\n Phone Number: \n E-mail:\n Result:","Result",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }else
            {
                MessageBox.Show("Information provided is invalid please resubmit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void InstructorTR_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvTR.DataSource = DT;
            dgvTR.DataMember = DT.TableName;
            connectstring.Close();
        }
    }
}
