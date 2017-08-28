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
    public partial class DeleteInstructor : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        bool valid1 = false;
        SqlConnection connectstring = new SqlConnection(DBC);
        ErrorHandle EH = new ErrorHandle();
        public DeleteInstructor()
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
            valid1 = EH.CheckEmpty(txtInstructorID.Text);
            valid1 = EH.CheckInt(txtInstructorID.Text);
            if (!valid1)
            {
                txtInstructorID.BackColor = Color.Red;
            }
            else
            {
                txtInstructorID.BackColor = Color.White;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (valid1)
            {
                //MessageBox.Show("Are you sure you want to delete this instructor?","Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                //string Query = "delete from student.studentinfo where idStudentInfo='" + this.IdTextBox.Text + "';";
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MySqlDataReader MyReader2;
                //MyConn2.Open();
                //MyReader2 = MyCommand2.ExecuteReader();
                //MessageBox.Show("Data Deleted");
                //while (MyReader2.Read())
                //{
                //}
                //MyConn2.Close();
            }
            else
            {
                MessageBox.Show("Information provided was invalid please resubmit the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
