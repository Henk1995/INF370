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
    public partial class CalculateRoyalties : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        bool valid1 = false;
        ErrorHandle EH = new ErrorHandle();
        public CalculateRoyalties()
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
            valid1=EH.CheckEmpty(txtInstructorID.Text);
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (valid1)
            {
                MessageBox.Show("Name: \n Surname:\n Royalties owed: \n","Royalties",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }else
            {
                MessageBox.Show("Information provided was invalid please resubmit the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
