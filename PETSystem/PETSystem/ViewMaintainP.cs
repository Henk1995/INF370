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
        //Error Handel
        ErrorHandle EH = new ErrorHandle();
        // public static string DBC =  "Data Source=DESKTOP-P44G52P\\SQLEXPRESS;Initial Catalog=inf370Reg;Integrated Security=True";
        DataTable DT = new DataTable();
        DataTable DT2 = new DataTable();
        static SqlCommand Fill = new SqlCommand("SELECT Instructor.InstructorID,Title.TitleName, Instructor.Name,Instructor.Surname,Gender.GenderName,Instructor.Email,Instructor.PhoneNumber,Certification.CertificationName FROM Instructor INNER JOIN Gender ON Gender.GenderID = Instructor.GenderID INNER JOIN Title ON Title.TitleID = Instructor.TitleID INNER JOIN Certification ON Certification.CertificationID = Instructor.CertificationID ", ConnectString.connectstring);
        
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
            SqlCommand Fill2 = new SqlCommand("SELECT Instructor.InstructorID,Title.TitleName, Instructor.Name,Instructor.Surname,Certification.CertificationName FROM Instructor INNER JOIN Title ON Title.TitleID = Instructor.TitleID INNER JOIN Certification ON Certification.CertificationID = Instructor.CertificationID WHERE Instructor.InstructorID = ANY(SELECT TrainingCourseLine.InstructorID FROM TrainingCourseLine Where TrainingCourseLine.TrainingCourseID = '" + courseID+"')", ConnectString.connectstring);
            SqlDataAdapter DA2 = new SqlDataAdapter(Fill2);

            ConnectString.connectstring.Open();

            DA2.Fill(DT2);
            dataGridView2.DataSource = DT2;
            dataGridView2.DataMember = DT2.TableName;
            ConnectString.connectstring.Close();
           
        }

        private void btnMainM_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainingCourseMenu UM = new TrainingCourseMenu();
            UM.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmd = new SqlCommandBuilder(DA);

            DA.Update(DT);
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
                    string Query = "INSERT INTO TrainingCourseLine(InstructorID,TrainingCourseID,ResultID) values('" + dataGridView1.SelectedCells[0].Value + "','" + courseID + "','" + 1 + "')";
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
            bool valid1 = EH.Checkstring(textBox1.Text);
            bool validSQl = EH.checkForSQLInjection(textBox1.Text);
            if (valid1)
            {
                valid1 = validSQl;
            }
            if (valid1)
            {
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("SELECT Instructor.InstructorID,Title.TitleName, Instructor.Name,Instructor.Surname,Gender.GenderName,Instructor.Email,Instructor.PhoneNumber,Certification.CertificationName FROM Instructor INNER JOIN Gender ON Gender.GenderID = Instructor.GenderID INNER JOIN Title ON Title.TitleID = Instructor.TitleID INNER JOIN Certification ON Certification.CertificationID = Instructor.CertificationID  where Instructor.Name like '%" + textBox1.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                ConnectString.connectstring.Close();
            }
            else
            {
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT Instructor.InstructorID,Title.TitleName, Instructor.Name,Instructor.Surname,Gender.GenderName,Instructor.Email,Instructor.PhoneNumber,Certification.CertificationName FROM Instructor INNER JOIN Gender ON Gender.GenderID = Instructor.GenderID INNER JOIN Title ON Title.TitleID = Instructor.TitleID INNER JOIN Certification ON Certification.CertificationID = Instructor.CertificationID", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                dataGridView1.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool valid1 = EH.Checkstring(textBox2.Text);
            bool validSQl = EH.checkForSQLInjection(textBox2.Text);
            if (valid1)
            {
                valid1 = validSQl;
            }
            if (valid1)
            {
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("SELECT Instructor.InstructorID, Title.TitleName, Instructor.Name, Instructor.Surname, Certification.CertificationName FROM Instructor INNER JOIN Title ON Title.TitleID = Instructor.TitleID INNER JOIN Certification ON Certification.CertificationID = Instructor.CertificationID WHERE Instructor.InstructorID = ANY(SELECT TrainingCourseLine.InstructorID FROM TrainingCourseLine Where TrainingCourseLine.TrainingCourseID = '" + courseID+"' AND  Instructor.Name like '%" + textBox2.Text + "%')", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView2.DataSource = DT;
                ConnectString.connectstring.Close();
            }
            else
            {
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT Instructor.InstructorID, Title.TitleName, Instructor.Name, Instructor.Surname, Certification.CertificationName FROM Instructor INNER JOIN Title ON Title.TitleID = Instructor.TitleID INNER JOIN Certification ON Certification.CertificationID = Instructor.CertificationID WHERE Instructor.InstructorID = ANY(SELECT TrainingCourseLine.InstructorID FROM TrainingCourseLine Where TrainingCourseLine.TrainingCourseID = '" + courseID+"')", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dataGridView2.DataSource = DT;
                dataGridView2.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }

        }
    }
}
