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
        SqlDataAdapter DA;
        public DeleteInstructor()
        {
            InitializeComponent();
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            connectstring.Close();
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
                if (dgvInstructor.SelectedRows.Count > 0)
                {
                    int selectedIndex = dgvInstructor.SelectedRows[0].Index;

                    // gets the RowID from the first column in the grid
                    int rowID = int.Parse(dgvInstructor[0, selectedIndex].Value.ToString());

                  
                    MessageBox.Show("Are you sure you want to delete this instructor?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    string Query = "DELETE FROM Instructor WHERE InstructorID='" + rowID + "';";

                    SqlCommand MyCommand2 = new SqlCommand(Query, connectstring);
                    SqlDataReader MyReader2;
                    connectstring.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Deleted");
                    while (MyReader2.Read())
                    {
                    }
                    connectstring.Close();
                }
                DataTable DT = new DataTable();
                connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvInstructor.DataSource = DT;
                dgvInstructor.DataMember = DT.TableName;
                connectstring.Close();
            }
            else
            {
                MessageBox.Show("Information provided was invalid please resubmit the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteInstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
