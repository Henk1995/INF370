using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PETSystem
{

    public partial class AddResult : Form
    {
        DateTime endOfTime;
        Timer t;
        DataTable DT = new DataTable();
        int courseID;
       
        
        public AddResult()
        {
            InitializeComponent();
        }
        public AddResult(int value)
        {
            
            courseID = value;

            InitializeComponent();
        }
      

        private void AddResult_Load(object sender, EventArgs e)
        {
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
             t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            ConnectString.CourseID = courseID;
            SqlCommand Fill = new SqlCommand("SELECT  Instructor.InstructorID, Instructor.Name,Instructor.Surname,Results.ResultName From  Instructor,Results   Where Instructor.InstructorID = ANY(SELECT TrainingCourseLine.InstructorID FROM TrainingCourseLine   Where TrainingCourseLine.TrainingCourseID = '" + ConnectString.CourseID + "' AND Results.ResultID = ANY(SELECT TrainingCourseLine.ResultID FROM TrainingCourseLine   Where TrainingCourseLine.ResultID <4 AND  TrainingCourseLine.TrainingCourseID = '" + ConnectString.CourseID + "'))", ConnectString.connectstring);
            SqlDataAdapter DA = new SqlDataAdapter(Fill);
            ConnectString.connectstring.Open();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            dataGridView1.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
           
            // Refres datagrid view
            textBox1.Text = "a";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vir pass
           

            try
            {
                string instructorID = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                ConnectString.InstructorID = Convert.ToInt32(instructorID);
                AddResultMessagebox myform = new AddResultMessagebox();
                myform.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please select a row to add an result to");
            }

        }
        //Fail


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            TrainingCourseMenu UM = new TrainingCourseMenu();
            UM.ShowDialog();
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ConnectString.CourseID = courseID;

            // MessageBox.Show(courseID.ToString());
            //Pouplate Datagrid view with course instance participants
            // SqlCommand Fill = new SqlCommand("SELECT Instructor.InstructorID,Title.TitleName, Instructor.Name,Instructor.Surname,Certification.CertificationName FROM Instructor INNER JOIN Title ON Title.TitleID = Instructor.TitleID INNER JOIN Certification ON Certification.CertificationID = Instructor.CertificationID WHERE Instructor.InstructorID = ANY(SELECT TrainingCourseLine.InstructorID FROM TrainingCourseLine   Where TrainingCourseLine.TrainingCourseID = '" + courseID + "')", ConnectString.connectstring);
            ConnectString.connectstring.Open();
            SqlDataAdapter DA;
            DA = new SqlDataAdapter("SELECT  Instructor.InstructorID, Instructor.Name,Instructor.Surname,Results.ResultName From  Instructor,Results   Where Instructor.InstructorID = ANY(SELECT TrainingCourseLine.InstructorID FROM TrainingCourseLine   Where TrainingCourseLine.TrainingCourseID = '" + ConnectString.CourseID + "' AND Results.ResultID = ANY(SELECT TrainingCourseLine.ResultID FROM TrainingCourseLine   Where TrainingCourseLine.ResultID <4 AND  TrainingCourseLine.TrainingCourseID = '" + ConnectString.CourseID + "' AND Instructor.Name like '%" + textBox1.Text + "%'))", ConnectString.connectstring);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            ConnectString.connectstring.Close();
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

        private void AddResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
