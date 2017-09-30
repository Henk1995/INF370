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
