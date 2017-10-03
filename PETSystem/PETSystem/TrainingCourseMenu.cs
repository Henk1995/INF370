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
    public partial class TrainingCourseMenu : Form
    {
        DateTime endOfTime;
        Timer t;
        ErrorHandle EH = new ErrorHandle();
        SqlDataAdapter DA;
        public TrainingCourseMenu()
        {
            InitializeComponent();
        }

        private void btnMainM_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }

        private void btnMCourses_Click(object sender, EventArgs e)
        {
            this.Close();
            MaintainCourses UM = new MaintainCourses();
            UM.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void TrainingCourseMenu_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            
            //Tooltips
            //Search
            ToolTip TTSearch = new ToolTip();
            TTSearch.ToolTipTitle = "Search";
            TTSearch.UseFading = true;
            TTSearch.UseAnimation = true;
            TTSearch.IsBalloon = true;
            TTSearch.SetToolTip(txtCourseN, "Enter the search text here to search for it.\nSearches according to search field.");
            //Add
            ToolTip TTAdd = new ToolTip();
            TTAdd.ToolTipTitle = "Add Result";
            TTAdd.UseFading = true;
            TTAdd.UseAnimation = true;
            TTAdd.IsBalloon = true;
            TTAdd.SetToolTip(btnAddResult, "Select a course from the right and\nclick here to add results to the participants.");
            //ViewMP
            ToolTip TTVMP = new ToolTip();
            TTVMP.ToolTipTitle = "View/Maintain Participants";
            TTVMP.UseFading = true;
            TTVMP.UseAnimation = true;
            TTVMP.IsBalloon = true;
            TTVMP.SetToolTip(btnVMParticipants, "Select a course from the right and\nclick here to update the participants of a course");
            //MaintainCourses
            ToolTip TTMC = new ToolTip();
            TTMC.ToolTipTitle = "Maintain Courses";
            TTMC.UseFading = true;
            TTMC.UseAnimation = true;
            TTMC.IsBalloon = true;
            TTMC.SetToolTip(btnMCourses, "Click here to open the maintain courses menu.");
            //MainMenu
            ToolTip TTMM = new ToolTip();
            TTMM.ToolTipTitle = "Main menu";
            TTMM.UseFading = true;
            TTMM.UseAnimation = true;
            TTMM.IsBalloon = true;
            TTMM.SetToolTip(btnMainM, "Click here to open the Main menu.");
            //Combobox
            ToolTip TTCB = new ToolTip();
            TTCB.ToolTipTitle = "Search Field";
            TTCB.UseFading = true;
            TTCB.UseAnimation = true;
            TTCB.IsBalloon = true;
            TTCB.SetToolTip(comboBox1, "Click here to select a field to search.");



            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);


            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT TrainingCourse.TrainingCourseID AS 'ID',TrainingCourse.CourseName,TrainingCourse.Duration AS 'Duration in Weeks',TrainingCourse.TrainingCourseDate AS 'Start Date',TrainingCourseType.TrainingCourseName AS 'Training Course Type' FROM TrainingCourse INNER JOIN TrainingCourseType ON TrainingCourseType.TrainingCourseTypeID = TrainingCourse.TrainingCourseTypeID", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvTC.DataSource = DT;
            dgvTC.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
            
            string query = "SELECT TrainingCourseName FROM TrainingCourseType ";
            DataTable DT1 = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query, ConnectString.connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT1);
            
            ConnectString.connectstring.Close();
        }

        private void txtCourseN_TextChanged(object sender, EventArgs e)
        {
            bool valid1 = EH.Checkstring(txtCourseN.Text);
            bool validSQl = EH.checkForSQLInjection(txtCourseN.Text);
          
                if (comboBox1.SelectedIndex == 0)
                {
                    ConnectString.connectstring.Open();
                    DA = new SqlDataAdapter("SELECT TrainingCourse.TrainingCourseID AS 'ID',TrainingCourse.CourseName,TrainingCourse.Duration AS 'Duration in Weeks',TrainingCourse.TrainingCourseDate AS 'Start Date',TrainingCourseType.TrainingCourseName AS 'Training Course Type' FROM TrainingCourse INNER JOIN TrainingCourseType ON TrainingCourseType.TrainingCourseTypeID = TrainingCourse.TrainingCourseTypeID where CourseName like '%" + txtCourseN.Text + "%'", ConnectString.connectstring);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    dgvTC.DataSource = DT;
                    ConnectString.connectstring.Close();
                }
                else
                {
                    ConnectString.connectstring.Open();
                    DA = new SqlDataAdapter("SELECT TrainingCourse.TrainingCourseID AS 'ID',TrainingCourse.CourseName,TrainingCourse.Duration AS 'Duration in Weeks',TrainingCourse.TrainingCourseDate AS 'Start Date',TrainingCourseType.TrainingCourseName AS 'Training Course Type' FROM TrainingCourse INNER JOIN TrainingCourseType ON TrainingCourseType.TrainingCourseTypeID = TrainingCourse.TrainingCourseTypeID where TrainingCourseDate like '%" + txtCourseN.Text + "%'", ConnectString.connectstring);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    dgvTC.DataSource = DT;
                    ConnectString.connectstring.Close();
                }
          
        }

        private void txtCourseT_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnVMParticipants_Click(object sender, EventArgs e)
        {

            if (dgvTC.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTC.SelectedRows[0].Index;

                // gets the RowID from the first column in the grid
                int rowID = int.Parse(dgvTC[0, selectedIndex].Value.ToString());
                string CourseName = dgvTC.SelectedRows[0].Cells[1].Value + string.Empty;
                this.Close();
                ViewMaintainP UM = new ViewMaintainP(rowID,CourseName);
                UM.Show();
            }
            else
            {
                MessageBox.Show("Please select the row you want to view");
            }
                }
        private void btnAddResult_Click(object sender, EventArgs e)
        {

            if (dgvTC.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTC.SelectedRows[0].Index;

                // gets the RowID from the first column in the grid
                int rowID = int.Parse(dgvTC[0, selectedIndex].Value.ToString());
                ConnectString.TrainingCourseIDForResult = rowID;
                string CourseName = dgvTC.SelectedRows[0].Cells[1].Value + string.Empty;
                this.Close();
                AddResult UM = new AddResult(rowID);
                UM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select the row you want to view");
            }



            
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

        private void TrainingCourseMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
    }

