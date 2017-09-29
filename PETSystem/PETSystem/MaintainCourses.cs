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
    public partial class MaintainCourses : Form
    {
        SqlDataAdapter DA;
        DataTable DTC = new DataTable();
        ErrorHandle EH = new ErrorHandle();
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        bool valid5 = false;
        bool valid6 = false;
        bool valid7 = false;
        public MaintainCourses()
        {
            InitializeComponent();
        }

        private void MaintainCourses_Load(object sender, EventArgs e)
        {
            //btnDelete.Visible = false;
            //AddCoursePanel.Visible = false;
            // MSMain.Visible = true;
            //  AddCourseTypeP.Visible = false;
            //  MaintainTCPanel.Visible = false;
            //  dgvMaintain.Visible = false;
            //  btnSave.Visible = false;
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT TrainingCourse.TrainingCourseID,TrainingCourse.CourseName,TrainingCourse.Duration AS 'Duration in weeks',TrainingCourse.TrainingCourseDate,TrainingCourseType.TrainingCourseName FROM TrainingCourse INNER JOIN TrainingCourseType ON TrainingCourseType.TrainingCourseTypeID = TrainingCourse.TrainingCourseID", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvMaintain.DataSource = DT;
            dgvMaintain.DataMember = DT.TableName;
            ConnectString.connectstring.Close();

            //Combobox
            cmbName.Items.Clear();
            string query = "SELECT TrainingCourseName FROM TrainingCourseType ";
            DataTable DTT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query, ConnectString.connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DTT);
            foreach (DataRow dr in DTT.Rows)
            {
                cmbName.Items.Add(dr["TrainingCourseName"]).ToString();
            }
            ConnectString.connectstring.Close();
        }

        private void addTrainingCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  AddCoursePanel.Visible = true;
            MSMain.Visible = false;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*    if (AddCoursePanel.Visible || AddCourseTypeP.Visible || MaintainTCPanel.Visible)
                {
                    btnDelete.Visible = false;
                    AddCoursePanel.Visible = false;
                    MSMain.Visible = true;
                    AddCourseTypeP.Visible = false;
                    MaintainTCPanel.Visible = false;
                    dgvMaintain.Visible = false;
                    btnSave.Visible = false;
                }
                else if (MSMain.Visible)
                {
                    this.Close();
                    TrainingCourseMenu UM = new TrainingCourseMenu();
                    UM.Show();


                }*/

            this.Close();
            this.Dispose(true);
            TrainingCourseMenu myform = new TrainingCourseMenu();
            myform.ShowDialog();
        }

        private void addTrainingCourseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseTypeP.Visible = true;
            MSMain.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maintainTrainingCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            MaintainTCPanel.Visible = true;
            dgvMaintain.Visible = true;
            btnSave.Visible = true;
            MSMain.Visible = false;
          
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            valid1 = EH.Checkstring(txtCourseName.Text);
            bool validSQl = EH.checkForSQLInjection(txtCourseName.Text);
            if (valid1)
            {
                valid1 = validSQl;
            }
            if (valid1)
            {
                DataTable DT2 = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill2 = new SqlCommand("SELECT TrainingCourse.TrainingCourseID,TrainingCourse.CourseName,TrainingCourse.Duration AS 'Duration in weeks',TrainingCourse.TrainingCourseDate AS 'Start Date',TrainingCourseType.TrainingCourseName FROM TrainingCourse INNER JOIN TrainingCourseType ON TrainingCourseType.TrainingCourseTypeID = TrainingCourse.TrainingCourseID WHERE TrainingCourse.CourseName like '%" + txtCourseName.Text + "%'", ConnectString.connectstring);
                SqlDataAdapter DA2 = new SqlDataAdapter(Fill2);
                DA2.Fill(DT2);
                dgvMaintain.DataSource = DT2;
                dgvMaintain.DataMember = DT2.TableName;
                txtCourseName.BackColor = Color.White;
                ConnectString.connectstring.Close();             
            }
            else
            {
                
                txtCourseName.BackColor = Color.Red;
                DataTable DT2 = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill2 = new SqlCommand("SELECT TrainingCourse.TrainingCourseID,TrainingCourse.CourseName,TrainingCourse.Duration AS 'Duration in weeks',TrainingCourse.TrainingCourseDate,TrainingCourseType.TrainingCourseName FROM TrainingCourse INNER JOIN TrainingCourseType ON TrainingCourseType.TrainingCourseTypeID = TrainingCourse.TrainingCourseID WHERE TrainingCourse.CourseName like '%" + txtCourseName.Text + "%'", ConnectString.connectstring);
                SqlDataAdapter DA2 = new SqlDataAdapter(Fill2);
                DA2.Fill(DT2);
                dgvMaintain.DataSource = DT2;
                dgvMaintain.DataMember = DT2.TableName;
                txtCourseName.BackColor = Color.White;
                ConnectString.connectstring.Close();
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            //valid2 = EH.CheckInt(txtYear.Text);
            //if (!valid2)
            //{
            //    txtYear.BackColor = Color.Red;
            //}
            //else
            //{

            //    txtYear.BackColor = Color.White;
            //   // ConnectString.connectstring.Open();
            //   // DA = new SqlDataAdapter("select * from TrainingCourse where TrainingCourseDate like '" + txtYear.Text + "%'", ConnectString.connectstring);
            //   //DataTable DT = new DataTable();
            //   // DA.Fill(DT);
            //   // dgvMaintain.DataSource = DT;
            //   // ConnectString.connectstring.Close();
            //}
        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.CheckDate(txtStartDate.Text);
            bool validSQl = EH.checkForSQLInjection(txtStartDate.Text);
            if (valid3)
            {
                valid3 = validSQl;
            }
            if (!valid3)
            {
                txtStartDate.BackColor = Color.Red;
            }
            else
            {
                txtStartDate.BackColor = Color.White;
            }
        }

        private void txtVenue_TextChanged(object sender, EventArgs e)
        {
            valid4 = EH.CheckstringNum(txtVenue.Text);
            bool validSQl = EH.checkForSQLInjection(txtVenue.Text);
            if (valid4)
            {
                valid4 = validSQl;
            }
            if (!valid4)
            {
                txtVenue.BackColor = Color.Red;
            }
            else
            {
                txtVenue.BackColor = Color.White;
            }
        }

        private void txtNCDName_TextChanged(object sender, EventArgs e)
        {
            valid5 = EH.Checkstring(txtNCDName.Text);
            bool validSQl = EH.checkForSQLInjection(txtNCDName.Text);
            if (valid5)
            {
                valid5 = validSQl;
            }
            if (!valid5)
            {
                txtNCDName.BackColor = Color.Red;
            }
            else
            {
                txtNCDName.BackColor = Color.White;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMaintain.SelectedRows.Count > 0)
                {
                    ConnectString.CourseStringID = dgvMaintain.SelectedRows[0].Cells[0].Value + string.Empty;
                    ConnectString.CourseName = dgvMaintain.SelectedRows[0].Cells[1].Value + string.Empty;
                    ConnectString.CourseDuration = dgvMaintain.SelectedRows[0].Cells[2].Value + string.Empty;
                    ConnectString.CourseDate = dgvMaintain.SelectedRows[0].Cells[3].Value + string.Empty;
                    ConnectString.CourseType = dgvMaintain.SelectedRows[0].Cells[4].Value + string.Empty;
                    
                    //Display form
                    UpdateTrainingCourseForm myform = new UpdateTrainingCourseForm();
                    this.Close();
                    
                    this.Dispose(true);
                    myform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a row to update");
                }
            }
            catch
            {

            }

            

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (valid5)
            {
                ConnectString.connectstring.Close();
                string Query1 = "SELECT * FROM TrainingCourseType WHERE TrainingCourseName ='" + this.txtNCDName.Text + "';";
                SqlCommand MyCommand = new SqlCommand(Query1, ConnectString.connectstring);

                SqlDataAdapter DA1 = new SqlDataAdapter(MyCommand);
                DataTable DT1 = new DataTable();
                DA1.Fill(DT1);
                ConnectString.connectstring.Open();


                if (DT1.Rows.Count > 0)
                {
                    valid5 = false;
                    //MessageBox.Show("Please provide new course type name");
                }
                else
                {

                    string Query = "INSERT INTO TrainingCourseType(TrainingCourseName) values('" + this.txtNCDName.Text + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  

                    //This is command class which will handle the query and connection object.  
                    SqlCommand MyCommand2 = new SqlCommand(Query, ConnectString.connectstring);
                    SqlDataReader MyReader2;

                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Course type added");
                    while (MyReader2.Read())
                    {
                    }
                   

                }
                if (txtNCDName.Text == "")
                {
                    MessageBox.Show("Please provide new course type name");
                }
                ConnectString.connectstring.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CTID = 0;
            bool duplicate = true;
            if (valid3 && valid4 && valid2 && EH.CheckEmpty(cmbName.Text))
            {
                string Query1 = "SELECT * FROM TrainingCourse WHERE CourseName ='" + this.cmbName.Text + "'AND TrainingCourseDate='" + this.txtStartDate.Text + "';";
                SqlCommand MyCommand = new SqlCommand(Query1, ConnectString.connectstring);
                SqlDataReader MyReader;
                SqlDataAdapter DA = new SqlDataAdapter(MyCommand);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                ConnectString.connectstring.Open();
                MyReader = MyCommand.ExecuteReader();

                if (DT.Rows.Count == 0)
                {

                    duplicate = false;

                }
                else
                {
                    duplicate = true;
                }
                ConnectString.connectstring.Close();
            }
            if (!duplicate)
            {
                string query = "SELECT TrainingCourseTypeID FROM TrainingCourseType WHERE TrainingCourseName='" + cmbName.Text + "'";
                SqlCommand MyCommand1 = new SqlCommand(query, ConnectString.connectstring);
                SqlDataReader MyReader1;
                ConnectString.connectstring.Open();
                MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader1.Read())
                {
                    CTID = Convert.ToInt32(MyReader1["TrainingCourseTypeID"]);
                }
                ConnectString.connectstring.Close();
                string Query = "INSERT INTO TrainingCourse(CourseName,Duration,TrainingCourseDate,TrainingCourseTypeID) values('" + this.cmbName.Text + "','" + this.numericUpDown1.Text + "','" + this.txtStartDate.Text + "','" + CTID + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  

                //This is command class which will handle the query and connection object.  
                SqlCommand MyCommand2 = new SqlCommand(Query, ConnectString.connectstring);
                SqlDataReader MyReader2;
                ConnectString.connectstring.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Training Course Added.");
                while (MyReader2.Read())
                {
                }
                ConnectString.connectstring.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all inputs");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            valid2 = EH.CheckEmpty(this.numericUpDown1.Text);
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddInstrucorC UM = new AddInstrucorC();
            UM.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMaintain.SelectedRows.Count > 0)
            {
                string Query = "Delete TrainingCourse Where TrainingCourseID = '" + dgvMaintain.SelectedRows[0].Cells[0].Value + "'";
                DialogResult answer = MessageBox.Show("Are you sure you want to Delete this Training Course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (answer == DialogResult.Yes)
                {
                    SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                    SqlDataReader MyReader3;
                    ConnectString.connectstring.Open();
                    MyReader3 = MyCommand3.ExecuteReader();
                    MessageBox.Show("Training Course successfully removed");
                    ConnectString.connectstring.Close();
                    //Refresh DGV
                    txtCourseName.Text = "a";
                    txtCourseName.Text = "";
                }
                else
                {
                    MessageBox.Show("Training Course was not deleted");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to Delete");
            }
        }

        private void cmbName_Click(object sender, EventArgs e)
        {
            cmbName.Items.Clear();
            string query = "SELECT TrainingCourseName FROM TrainingCourseType ";
            DataTable DTT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query, ConnectString.connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DTT);
            foreach (DataRow dr in DTT.Rows)
            {
                cmbName.Items.Add(dr["TrainingCourseName"]).ToString();
            }
            ConnectString.connectstring.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            AddInstrucorC UM = new AddInstrucorC();
            UM.ShowDialog();
        }
    }
}