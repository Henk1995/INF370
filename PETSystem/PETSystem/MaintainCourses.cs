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
        DateTime endOfTime;
        Timer t;
        private void MaintainCourses_Load(object sender, EventArgs e)
        {
            //CourseName
            ToolTip TTCNAME = new ToolTip();
            TTCNAME.ToolTipTitle = "Course Name";
            TTCNAME.UseFading = true;
            TTCNAME.UseAnimation = true;
            TTCNAME.IsBalloon = true;
            TTCNAME.SetToolTip(txtNewName, "Enter the new training course name here.");
            //Start DAte
            ToolTip TTSTART = new ToolTip();
            TTSTART.ToolTipTitle = "Start Date";
            TTSTART.UseFading = true;
            TTSTART.UseAnimation = true;
            TTSTART.IsBalloon = true;
            TTSTART.SetToolTip(txtStartDate, "Enter the new training course Start Date here.\nFormat dd/mm/yyyy.");
            //Duration in weeks
            ToolTip TTDuration = new ToolTip();
            TTDuration.ToolTipTitle = "Duration";
            TTDuration.UseFading = true;
            TTDuration.UseAnimation = true;
            TTDuration.IsBalloon = true;
            TTDuration.SetToolTip(numericUpDown1, "Select the duration in weeks.");
            //Venu
            ToolTip TtType = new ToolTip();
            TtType.ToolTipTitle = "Course Type";
            TtType.UseFading = true;
            TtType.UseAnimation = true;
            TtType.IsBalloon = true;
            TtType.SetToolTip(cmbName, "Select the new course's Type.");
            //Submit 
            ToolTip TTSubmit = new ToolTip();
            TTSubmit.ToolTipTitle = "Submit";
            TTSubmit.UseFading = true;
            TTSubmit.UseAnimation = true;
            TTSubmit.IsBalloon = true;
            TTSubmit.SetToolTip(button1, "Click to add the new Training Course\n once all information has been provided.");
            //Back
            ToolTip TTBAck = new ToolTip();
            TTBAck.ToolTipTitle = "Back";
            TTBAck.UseFading = true;
            TTBAck.UseAnimation = true;
            TTBAck.IsBalloon = true;
            TTBAck.SetToolTip(button2, "Click to return to the Training Course Menu.");
            //Submit Training Course Name
            ToolTip TtNENAME = new ToolTip();
            TtNENAME.ToolTipTitle = "Submit";
            TtNENAME.UseFading = true;
            TtNENAME.UseAnimation = true;
            TtNENAME.IsBalloon = true;
            TtNENAME.SetToolTip(button3, "Click to add new course Type.");
            //newcourse type txt
            ToolTip TtTypetxt = new ToolTip();
            TtTypetxt.ToolTipTitle = "New Course Type";
            TtTypetxt.UseFading = true;
            TtTypetxt.UseAnimation = true;
            TtTypetxt.IsBalloon = true;
            TtTypetxt.SetToolTip(txtNCDName, "Enter a new course type name to be added to th system.");
            //Search Field
            ToolTip TtSearchField = new ToolTip();
            TtSearchField.ToolTipTitle = "Search Field";
            TtSearchField.UseFading = true;
            TtSearchField.UseAnimation = true;
            TtSearchField.IsBalloon = true;
            TtSearchField.SetToolTip(cbSearch, "Select the field that must be searched.");
            //Search Text
            ToolTip TTSearchText = new ToolTip();
            TTSearchText.ToolTipTitle = "Search Text";
            TTSearchText.UseFading = true;
            TTSearchText.UseAnimation = true;
            TTSearchText.IsBalloon = true;
            TTSearchText.SetToolTip(txtCourseName, "Enter the text value that must be searched.");
            //Update
            ToolTip TTUpdate = new ToolTip();
            TTUpdate.ToolTipTitle = "Update";
            TTUpdate.UseFading = true;
            TTUpdate.UseAnimation = true;
            TTUpdate.IsBalloon = true;
            TTUpdate.SetToolTip(btnSave, "Select a training course from the list and\nclick here to Update it.");
            //delete
            ToolTip TTDelete = new ToolTip();
            TTDelete.ToolTipTitle = "Update";
            TTDelete.UseFading = true;
            TTDelete.UseAnimation = true;
            TTDelete.IsBalloon = true;
            TTDelete.SetToolTip(button6, "Select a training course from the list and\nclick here to Delete it.");
            //Update Training Course Type
            ToolTip TTUTCT = new ToolTip();
            TTUTCT.ToolTipTitle = "Update Training Course Type";
            TTUTCT.UseFading = true;
            TTUTCT.UseAnimation = true;
            TTUTCT.IsBalloon = true;
            TTUTCT.SetToolTip(button5, "Click here tu update a training course type.");

            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            cbSearch.SelectedIndex = 0;
            //btnDelete.Visible = false;
            //AddCoursePanel.Visible = false;
            // MSMain.Visible = true;
            //  AddCourseTypeP.Visible = false;
            //  MaintainTCPanel.Visible = false;
            //  dgvMaintain.Visible = false;
            //  btnSave.Visible = false;
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT TrainingCourse.TrainingCourseID AS 'ID',TrainingCourse.CourseName,TrainingCourse.Duration AS 'Duration in Weeks',TrainingCourse.TrainingCourseDate AS 'Start Date',TrainingCourseType.TrainingCourseName AS 'Training Course Type' FROM TrainingCourse INNER JOIN TrainingCourseType ON TrainingCourseType.TrainingCourseTypeID = TrainingCourse.TrainingCourseTypeID", ConnectString.connectstring);
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
            //MSMain.Visible = false;
          
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
          //  AddCourseTypeP.Visible = true;
            //MSMain.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

              
            }
            else
            {
                
               
            }
            //Name Year type
            if (cbSearch.SelectedIndex == 0)
            {
                DataTable DT2 = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill2 = new SqlCommand("SELECT TrainingCourse.TrainingCourseID AS 'ID',TrainingCourse.CourseName,TrainingCourse.Duration AS 'Duration in Weeks',TrainingCourse.TrainingCourseDate AS 'Start Date',TrainingCourseType.TrainingCourseName AS 'Training Course Type' FROM TrainingCourse INNER JOIN TrainingCourseType ON TrainingCourseType.TrainingCourseTypeID = TrainingCourse.TrainingCourseTypeID WHERE TrainingCourse.CourseName Like '%"+txtCourseName.Text+"%'", ConnectString.connectstring);
                SqlDataAdapter DA2 = new SqlDataAdapter(Fill2);
                DA2.Fill(DT2);
                dgvMaintain.DataSource = DT2;
                dgvMaintain.DataMember = DT2.TableName;
                txtCourseName.BackColor = Color.White;
                ConnectString.connectstring.Close();
            }
            else if (cbSearch.SelectedIndex == 1)
            {
                DataTable DTx = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fillx = new SqlCommand("SELECT TrainingCourse.TrainingCourseID AS 'ID',TrainingCourse.CourseName,TrainingCourse.Duration AS 'Duration in Weeks',TrainingCourse.TrainingCourseDate AS 'Start Date',TrainingCourseType.TrainingCourseName AS 'Training Course Type' FROM TrainingCourse INNER JOIN TrainingCourseType ON TrainingCourseType.TrainingCourseTypeID = TrainingCourse.TrainingCourseTypeID WHERE TrainingCourse.TrainingCourseDate Like '%" + txtCourseName.Text + "%'", ConnectString.connectstring);
                SqlDataAdapter DAx = new SqlDataAdapter(Fillx);
                DAx.Fill(DTx);
                dgvMaintain.DataSource = DTx;
                dgvMaintain.DataMember = DTx.TableName;
                txtCourseName.BackColor = Color.White;
                ConnectString.connectstring.Close();
            }
            else
            {
                DataTable DTz = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fillz = new SqlCommand("SELECT TrainingCourse.TrainingCourseID AS 'ID',TrainingCourse.CourseName,TrainingCourse.Duration AS 'Duration in Weeks',TrainingCourse.TrainingCourseDate AS 'Start Date',TrainingCourseType.TrainingCourseName AS 'Training Course Type' FROM TrainingCourse INNER JOIN TrainingCourseType ON TrainingCourseType.TrainingCourseTypeID = TrainingCourse.TrainingCourseTypeID WHERE TrainingCourseType.TrainingCourseName Like '%" + txtCourseName.Text + "%'", ConnectString.connectstring);
                SqlDataAdapter DAz = new SqlDataAdapter(Fillz);
                DAz.Fill(DTz);
                dgvMaintain.DataSource = DTz;
                dgvMaintain.DataMember = DTz.TableName;
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
            
        }

        private void txtVenue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNCDName_TextChanged(object sender, EventArgs e)
        {
            
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
                    MessageBox.Show("Please provide new course type name");
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
            if (valid3 && valid2 && EH.CheckEmpty(cmbName.Text))
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
                string Query = "INSERT INTO TrainingCourse(CourseName,Duration,TrainingCourseDate,TrainingCourseTypeID) values('" + txtNewName.Text + "','" + this.numericUpDown1.Text + "','" + this.txtStartDate.Text + "','" + CTID + "');";
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

        private void txtStartDate_Leave(object sender, EventArgs e)
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

        private void txtVenue_Leave(object sender, EventArgs e)
        {
            valid4 = EH.CheckstringNum(txtNewName.Text);
            bool validSQl = EH.checkForSQLInjection(txtNewName.Text);
            if (valid4)
            {
                valid4 = validSQl;
            }
            if (!valid4)
            {
                txtNewName.BackColor = Color.Red;
            }
            else
            {
                txtNewName.BackColor = Color.White;
            }
        }

        private void txtNCDName_Leave(object sender, EventArgs e)
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

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int stop = 0;
        int ticks = ConnectString.TimerTime * 60;

        private void timer1_Tick(object sender, EventArgs e)
        {

            stop++;

            if (stop > ticks)
            {
                t.Enabled = false;
                this.Close();
                this.Dispose(true);
                LoginF myform = new LoginF();
                myform.ShowDialog();
            }
            else {
                TimeSpan ts = endOfTime.Subtract(DateTime.Now);
                lblTimer.Text = ts.ToString();
            }
        }

        private void MaintainCourses_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
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
                        ConnectString.connectstring.Close();
                        MessageBox.Show("Training Course was not deleted");
                    }
                }
                else
                {
                    ConnectString.connectstring.Close();
                    MessageBox.Show("Please select a row to Delete");
                }
            }
            catch
            {
                ConnectString.connectstring.Close();
                MessageBox.Show("This course is currently running and has instructors assigned to it.\nRemove all participants from course first in order to remove it","Notification");
            }
        }
    }
}