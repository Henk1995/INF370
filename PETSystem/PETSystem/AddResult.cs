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
            
            //Pouplate Datagrid view with course instance participants
            // SqlCommand Fill = new SqlCommand("SELECT Instructor.InstructorID,Title.TitleName, Instructor.Name,Instructor.Surname,Certification.CertificationName FROM Instructor INNER JOIN Title ON Title.TitleID = Instructor.TitleID INNER JOIN Certification ON Certification.CertificationID = Instructor.CertificationID WHERE Instructor.InstructorID = ANY(SELECT TrainingCourseLine.InstructorID FROM TrainingCourseLine   Where TrainingCourseLine.TrainingCourseID = '" + courseID + "')", ConnectString.connectstring);
            SqlCommand Fill = new SqlCommand("SELECT  Instructor.InstructorID, Instructor.Name,Instructor.Surname,Results.ResultName From  Instructor,Results   Where Instructor.InstructorID = ANY(SELECT TrainingCourseLine.InstructorID FROM TrainingCourseLine   Where TrainingCourseLine.TrainingCourseID = '" + courseID + "' AND Results.ResultID = ANY(SELECT TrainingCourseLine.ResultID FROM TrainingCourseLine   Where TrainingCourseLine.ResultID <3 AND  TrainingCourseLine.TrainingCourseID = '" + courseID + "'))", ConnectString.connectstring);
            SqlDataAdapter DA = new SqlDataAdapter(Fill);
            ConnectString.connectstring.Open();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            dataGridView1.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
           
            //Populate combobox
            string command = "Select Results.ResultName From Results";
            SqlConnection conn = new SqlConnection(ConnectString.DBC);
            conn.Open();
            SqlCommand cmd = new SqlCommand(command, conn);

            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                cmbResult.Items.Add(DR[0]);
            }
            conn.Close();
            cmbResult.SelectedIndex = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vir pass
            AddResultMessagebox myform = new AddResultMessagebox();
            myform.ShowDialog();
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    
                        DialogResult result = MessageBox.Show("Add Result?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Yes)
                        {
                            string Query = "UPDATE TrainingCourseLine SET TrainingCourseLine.ResultID = 2 WHERE TrainingCourseLine.InstructorID ='" + dataGridView1.SelectedRows[0].Cells[0].Value + "';";
                            //This is  MySqlConnection here i have created the object and pass my connection string.  

                            SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                            SqlDataReader MyReader3;
                            ConnectString.connectstring.Open();
                            MyReader3 = MyCommand3.ExecuteReader();

                            while (MyReader3.Read())
                            {
                            }
                            ConnectString.connectstring.Close();//Connection closed here
                            MessageBox.Show("Result Added.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Result Not Added.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                          }
                    }
                   
                
            }
            catch
            {
                MessageBox.Show("Please Select a row to add a result to");
                ConnectString.connectstring.Close();
            }
            
            }
        //Fail


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainingCourseMenu UM = new TrainingCourseMenu();
            UM.ShowDialog();
        }

        private void cmbResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbResult.SelectedIndex.ToString());
        }
    }
}
