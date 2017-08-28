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
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        SqlDataAdapter DA;
        public SearchInstructor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Instructors UM = new Instructors();
            UM.ShowDialog();
        }

        private void txtInstructorID_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
            valid = EH.CheckInt(txtInstructorID.Text);
            if (valid)
            {
                txtInstructorID.BackColor = Color.White;
            }
            else
            {
                txtInstructorID.BackColor = Color.FromArgb(249,29,29);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
            valid = EH.Checkstring(txtName.Text);
            if (valid)
            {
                txtName.BackColor = Color.White;
            }
            else
            {
                txtName.BackColor = Color.FromArgb(249, 29, 29);
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
            valid = EH.Checkstring(txtSurname.Text);
            if (valid)
            {
                txtSurname.BackColor = Color.White;
            }
            else
            {
                txtSurname.BackColor = Color.FromArgb(249, 29, 29);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void SearchInstructor_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            connectstring.Close();
        }
    }
}
