using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PETSystem
{
    public partial class UpdateTrainingCourseForm : Form
    {
        public UpdateTrainingCourseForm()
        {
            InitializeComponent();
        }
        DateTime endOfTime;
        Timer t;
        private void UpdateTrainingCourseForm_Load(object sender, EventArgs e)
        {
            //Name
            ToolTip TTName = new ToolTip();
            TTName.ToolTipTitle = "Course Name";
            TTName.UseFading = true;
            TTName.UseAnimation = true;
            TTName.IsBalloon = true;
            TTName.SetToolTip(txtname, "Enter the updated course name here.");
            //Duration
            ToolTip TTDuration = new ToolTip();
            TTDuration.ToolTipTitle = "Duration";
            TTDuration.UseFading = true;
            TTDuration.UseAnimation = true;
            TTDuration.IsBalloon = true;
            TTDuration.SetToolTip(txtDuration, "Enter the updated course duration in weeks here.");
            //StartDate
            ToolTip TTstartDate = new ToolTip();
            TTstartDate.ToolTipTitle = "Duration";
            TTstartDate.UseFading = true;
            TTstartDate.UseAnimation = true;
            TTstartDate.IsBalloon = true;
            TTstartDate.SetToolTip(txtStartDate, "Enter the updated course start date here.\nFormat dd/mm/yy.");
            //Course Type
            ToolTip TTType = new ToolTip();
            TTType.ToolTipTitle = "Course Type";
            TTType.UseFading = true;
            TTType.UseAnimation = true;
            TTType.IsBalloon = true;
            TTType.SetToolTip(cbCourseType, "Enter the updated course Type date here.");
            //Update
            ToolTip TTUpdate = new ToolTip();
            TTUpdate.ToolTipTitle = "Update";
            TTUpdate.UseFading = true;
            TTUpdate.UseAnimation = true;
            TTUpdate.IsBalloon = true;
            TTUpdate.SetToolTip(button2, "Click here to Update the training course to the information provided above.");
            //Back
            ToolTip TTBack = new ToolTip();
            TTBack.ToolTipTitle = "Back";
            TTBack.UseFading = true;
            TTBack.UseAnimation = true;
            TTBack.IsBalloon = true;
            TTBack.SetToolTip(button1, "Click here to return to the Maintain Courses Screen.");

            //Timer

            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            //MessageBox.Show(ConnectString.CourseStringID);
            txtname.Text = ConnectString.CourseName;
            txtDuration.Text = ConnectString.CourseDuration;
            txtStartDate.Text = ConnectString.CourseDate;
            //populate combobox
            cbCourseType.Items.Clear();
            string query = "SELECT TrainingCourseName FROM TrainingCourseType ";
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query, ConnectString.connectstring);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            
            foreach (DataRow dr in DT.Rows)
            {
                cbCourseType.Items.Add(dr["TrainingCourseName"]).ToString();
            }
            ConnectString.connectstring.Close();
            //Select index in combobox
            cbCourseType.SelectedIndex = cbCourseType.FindStringExact(ConnectString.CourseType);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            MaintainCourses myform = new MaintainCourses();
            myform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCourseType.SelectedIndex.ToString() != null)
                {
                    int CourseType = cbCourseType.SelectedIndex;
                    CourseType = CourseType + 1;
                    int courseID = Convert.ToInt32(ConnectString.CourseStringID);
                    string Query = "UPDATE TrainingCourse SET CourseName ='" + this.txtname.Text + "', Duration = '" + Convert.ToInt32(this.txtDuration.Text) + "', TrainingCourseDate = '" + this.txtStartDate.Text + "', TrainingCourseTypeID = '" + CourseType + "' WHERE TrainingCourseID =" + courseID + ";";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    DialogResult answer = MessageBox.Show("Are you sure you want to Update this Training Course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (answer == DialogResult.Yes)
                    {

                        SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                        SqlDataReader MyReader3;
                        ConnectString.connectstring.Open();
                        MyReader3 = MyCommand3.ExecuteReader();
                        MessageBox.Show("Training Course successfully updated");
                        ConnectString.connectstring.Close();
                        this.Close();
                        this.Dispose(true);
                        MaintainCourses myform = new MaintainCourses();
                        myform.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("No Changes Made");
                        ConnectString.connectstring.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Course Type");
                }
            }
            
            catch
            {
                MessageBox.Show("Please enter valid input into all the fields");
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

        private void UpdateTrainingCourseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
