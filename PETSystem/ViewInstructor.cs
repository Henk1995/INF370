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
    public partial class ViewInstructor : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        bool valid1 = false;
        ErrorHandle EH = new ErrorHandle();
        public ViewInstructor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Name: John\n Surname: Doe\n Phone Number: 0824521477\n E-mail: johndoe@gmail.com\n Result: Passed\n Qualified courses: PET\n Gender:Male\n Title:Mr.\n Certification:qualififed", "Result",
MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void titleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.titleBindingSource.EndEdit();
         //   this.tableAdapterManager.UpdateAll(this.iNF370DataSet);

        }

       /* private void instructorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instructorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNF370DataSet);

        }*/

        private void titleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
           // this.titleBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.iNF370DataSet);

        }

        private void ViewInstructor_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'iNF370DataSet.Title' table. You can move, or remove it, as needed.
//this.titleTableAdapter.Fill(this.iNF370DataSet.Title);

        }
    }
}
