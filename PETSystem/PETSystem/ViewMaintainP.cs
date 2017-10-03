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
    public partial class ViewMaintainP : Form
    {
        DateTime endOfTime;
        Timer t;
        //Error Handel
        ErrorHandle EH = new ErrorHandle();
        // public static string DBC =  "Data Source=DESKTOP-P44G52P\\SQLEXPRESS;Initial Catalog=inf370Reg;Integrated Security=True";
        DataTable DT = new DataTable();
        DataTable DT2 = new DataTable();
        static SqlCommand Fill = new SqlCommand("SELECT Instructor.InstructorID,Title.TitleName, Instructor.Name,Instructor.Surname,Gender.GenderName AS 'Gender',Instructor.Email,Instructor.PhoneNumber AS 'Phone Number' FROM Instructor INNER JOIN Gender ON Gender.GenderID = Instructor.GenderID INNER JOIN Title ON Title.TitleID = Instructor.TitleID ", ConnectString.connectstring);
        
        SqlDataAdapter DA = new SqlDataAdapter(Fill);
        string Coursename;
        int courseID;
        public ViewMaintainP()
        {
            
            

            InitializeComponent();
        }
        public ViewMaintainP(int value,string Coursevalue)
        {
            Coursename = Coursevalue;
            courseID = value;

            InitializeComponent();
        }

        private void ViewMaintainP_Load(object sender, EventArgs e)
        {

            //Tooltips
            //Search instructor txt
            ToolTip TTSearch = new ToolTip();
            TTSearch.ToolTipTitle = "Search Instructor";
            TTSearch.UseFading = true;
            TTSearch.UseAnimation = true;
            TTSearch.IsBalloon = true;
            TTSearch.SetToolTip(textBox1, "Enter the search text here to search for a instrucot in the system.");
            //Search instructor CB
            ToolTip TTCBINS = new ToolTip();
            TTCBINS.ToolTipTitle = "Search Field";
            TTCBINS.UseFading = true;
            TTCBINS.UseAnimation = true;
            TTCBINS.IsBalloon = true;
            TTCBINS.SetToolTip(comboBox1, "Select a field you want to search for.");
            //Search participants txt
            ToolTip TTSearchP = new ToolTip();
            TTSearchP.ToolTipTitle = "Search Participant";
            TTSearchP.UseFading = true;
            TTSearchP.UseAnimation = true;
            TTSearchP.IsBalloon = true;
            TTSearchP.SetToolTip(textBox2, "Enter the search text here to search for a course participant.");
            //Search participant cb
            ToolTip TTCBP = new ToolTip();
            TTCBP.ToolTipTitle = "Search Field";
            TTCBP.UseFading = true;
            TTCBP.UseAnimation = true;
            TTCBP.IsBalloon = true;
            TTCBP.SetToolTip(comboBox2, "Select a field you want to search for.");
            //Add ToolTip TTCBP = new ToolTip();
            ToolTip TTADD = new ToolTip();
            TTADD.ToolTipTitle = "Add";
            TTADD.UseFading = true;
            TTADD.UseAnimation = true;
            TTADD.IsBalloon = true;
            TTADD.SetToolTip(button1, "Select a instuctor from top list and \nclick here to add the instructor to the course.");
            //RemoveTTCBP.ToolTipTitle = "Add";
            ToolTip TTRemove = new ToolTip();
            TTRemove.ToolTipTitle = "Remove";
            TTRemove.UseFading = true;
            TTRemove.UseAnimation = true;
            TTRemove.IsBalloon = true;
            TTRemove.SetToolTip(button2, "Select a instuctor from bottom list and \nclick here to Remove the instructor from the course.");
            //PrintCertificates
            ToolTip TtPrint = new ToolTip();
            TtPrint.ToolTipTitle = "Print";
            TtPrint.UseFading = true;
            TtPrint.UseAnimation = true;
            TtPrint.IsBalloon = true;
            TtPrint.SetToolTip(btnPrint, "Click here to print a certificate for an instructor.");

            //Back
            ToolTip TTBack = new ToolTip();
            TTBack.ToolTipTitle = "Back";
            TTBack.UseFading = true;
            TTBack.UseAnimation = true;
            TTBack.IsBalloon = true;
            TTBack.SetToolTip(btnBack, "Click here to Return to the Training Course Menu.");



            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
             t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            //Show Course label

            label2.Text = "Instructors in Course ID: "+courseID.ToString()+"\nCourse Name: "+ Coursename;
            // Load Instructors
            ConnectString.connectstring.Open();
            
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
           dataGridView1.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
            //Load Course Instance
            //SqlCommand Fill2 = new SqlCommand("SELECT TrainingCourse.TrainingCourseID,TrainingCourse.CourseName,Instructor.InstructorID,Instructor.Name,Instrcutor.Surname FROM Instructor,TrainingCourse Where TrainingCourseLine.TrainingCourseID ='"+courseID+"'", ConnectString.connectstring);
            SqlCommand Fill2 = new SqlCommand("SELECT Instructor.InstructorID,Title.TitleName, Instructor.Name,Instructor.Surname FROM Instructor INNER JOIN Title ON Title.TitleID = Instructor.TitleID  WHERE Instructor.InstructorID = ANY(SELECT TrainingCourseLine.InstructorID FROM TrainingCourseLine Where TrainingCourseLine.TrainingCourseID = '" + courseID+"')", ConnectString.connectstring);
            SqlDataAdapter DA2 = new SqlDataAdapter(Fill2);

            ConnectString.connectstring.Open();

            DA2.Fill(DT2);
            dataGridView2.DataSource = DT2;
            dataGridView2.DataMember = DT2.TableName;
            ConnectString.connectstring.Close();
           
        }

        private void btnMainM_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainingCourseMenu UM = new TrainingCourseMenu();
            UM.Show();
        }

      

        private void btnPrint_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Certificate could not be printed at this moment");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string Query = "INSERT INTO TrainingCourseLine(InstructorID,TrainingCourseID,ResultID) values('" + dataGridView1.SelectedCells[0].Value + "','" + courseID + "','" + 3 + "')";
                    SqlCommand MyCommand = new SqlCommand(Query, ConnectString.connectstring);
                    SqlDataReader MyReader;
                    ConnectString.connectstring.Open();
                    MyReader = MyCommand.ExecuteReader();
                    ConnectString.connectstring.Close();
                    MessageBox.Show("Instructor has been added", "Notification");
                    //Refresh DGV
                    textBox2.Text = "a";
                    textBox2.Text = "";
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Please select a row to add","Error");
                }
            }
            catch
            {
                MessageBox.Show("Instructor Already in course", "Error;");
                dataGridView1.ClearSelection();
                ConnectString.connectstring.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    string Query = "Delete TrainingCourseLine Where TrainingCourseLine.InstructorID = '" + dataGridView2.SelectedCells[0].Value + "'";
                    SqlCommand MyCommand = new SqlCommand(Query, ConnectString.connectstring);
                    SqlDataReader MyReader;
                    ConnectString.connectstring.Open();
                    MyReader = MyCommand.ExecuteReader();
                    ConnectString.connectstring.Close();
                    dataGridView2.Refresh();
                    MessageBox.Show("Instructor has been removed", "Notification");
                    //Refresh DGV
                    textBox2.Text = "a";
                    textBox2.Text = "";
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Please select a row to remove","Error");
                }
            }
            catch
            {
                ConnectString.connectstring.Close();
                MessageBox.Show("Please select an instructor from the course table to remove", "Error;");
                dataGridView1.ClearSelection();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                ConnectString.connectstring.Close();
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("SELECT Instructor.InstructorID,Title.TitleName, Instructor.Name,Instructor.Surname,Gender.GenderName AS 'Gender',Instructor.Email,Instructor.PhoneNumber AS 'Phone Number' FROM Instructor INNER JOIN Gender ON Gender.GenderID = Instructor.GenderID INNER JOIN Title ON Title.TitleID = Instructor.TitleID where Instructor.Name like '%" + textBox1.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                ConnectString.connectstring.Close();
            }
            else
            {
                ConnectString.connectstring.Close();
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("SELECT Instructor.InstructorID,Title.TitleName, Instructor.Name,Instructor.Surname,Gender.GenderName AS 'Gender',Instructor.Email,Instructor.PhoneNumber AS 'Phone Number' FROM Instructor INNER JOIN Gender ON Gender.GenderID = Instructor.GenderID INNER JOIN Title ON Title.TitleID = Instructor.TitleID where Instructor.Surname like '%" + textBox1.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                ConnectString.connectstring.Close();
            }
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool valid1 = EH.Checkstring(textBox2.Text);
            bool validSQl = EH.checkForSQLInjection(textBox2.Text);

            if (comboBox2.SelectedIndex == 0)
            {
                ConnectString.connectstring.Close();
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("SELECT Instructor.InstructorID, Title.TitleName, Instructor.Name, Instructor.Surname FROM Instructor INNER JOIN Title ON Title.TitleID = Instructor.TitleID WHERE Instructor.InstructorID = ANY(SELECT TrainingCourseLine.InstructorID FROM TrainingCourseLine Where TrainingCourseLine.TrainingCourseID = '" + courseID + "' AND  Instructor.Name like '%" + textBox2.Text + "%')", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView2.DataSource = DT;
                ConnectString.connectstring.Close();
            }
            else
            {
                ConnectString.connectstring.Close();
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("SELECT Instructor.InstructorID, Title.TitleName, Instructor.Name, Instructor.Surname FROM Instructor INNER JOIN Title ON Title.TitleID = Instructor.TitleID WHERE Instructor.InstructorID = ANY(SELECT TrainingCourseLine.InstructorID FROM TrainingCourseLine Where TrainingCourseLine.TrainingCourseID = '" + courseID + "' AND  Instructor.Surname like '%" + textBox2.Text + "%')", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView2.DataSource = DT;
                ConnectString.connectstring.Close();
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

        private void ViewMaintainP_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
