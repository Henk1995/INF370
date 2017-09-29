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
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
           
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
