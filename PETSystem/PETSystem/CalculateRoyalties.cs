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
    public partial class CalculateRoyalties : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        bool valid1 = false;
        ErrorHandle EH = new ErrorHandle();
        public CalculateRoyalties()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Instructors UM = new Instructors();
            UM.ShowDialog();
        }

        private void txtInstructorID_TextChanged(object sender, EventArgs e)
        {
            valid1=EH.CheckEmpty(txtInstructorID.Text);
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string Name = "";
            string Surname = "";
            int courseid = 0;
            int amountC = 0;
            int amountO = 0;
            string queryA = "SELECT * FROM Instructor WHERE InstructorID ='" + Convert.ToInt32(txtInstructorID.Text) + "'";
            SqlCommand MyCommandA = new SqlCommand(queryA, connectstring);
            
            SqlDataAdapter DAA = new SqlDataAdapter(MyCommandA);
            DataTable DTA = new DataTable();
            DAA.Fill(DTA);
            connectstring.Open();


            if (DTA.Rows.Count == 0)
            {

                valid1 = false;
            }
            connectstring.Close();
            if (valid1)
            {
                string query2 = "SELECT CourseID FROM CourseInstance WHERE InstructorID ='" + Convert.ToInt32(txtInstructorID.Text) + "'";
                SqlCommand MyCommand = new SqlCommand(query2, connectstring);
                SqlDataReader MyReader;
                SqlDataAdapter DA = new SqlDataAdapter(MyCommand);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                connectstring.Open();
                

                if (DT.Rows.Count == 0)
                {
                    connectstring.Close();
                   
                    string query1 = "SELECT Name FROM Instructor WHERE  InstructorID ='" + Convert.ToInt32(txtInstructorID.Text) + "'";
                    SqlCommand MyCommand3 = new SqlCommand(query1, connectstring);
                    SqlDataReader MyReader3;
                    connectstring.Open();
                    MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader3.Read())
                    {
                        Name = MyReader3["Name"].ToString();
                    }
                    connectstring.Close();
                    string query4 = "SELECT Surname FROM Instructor WHERE  InstructorID ='" + Convert.ToInt32(txtInstructorID.Text) + "'";
                    SqlCommand MyCommand4 = new SqlCommand(query4, connectstring);
                    SqlDataReader MyReader4;
                    connectstring.Open();
                    MyReader4 = MyCommand4.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader4.Read())
                    {
                        Surname = MyReader4["Surname"].ToString();
                    }
                    connectstring.Close();
                    MessageBox.Show("Name: " + Name + " \n Surname: " + Surname + "\n Royalties owed: $" + amountO + " \n", "Royalties", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MyReader = MyCommand.ExecuteReader();
                    while (MyReader.Read())
                    {
                        courseid = Convert.ToInt32(MyReader["CourseID"]);
                    }
                    connectstring.Close();
                   
                    string query3 = "SELECT * FROM ClientCourseLine WHERE CourseID ='" + courseid + "'";
                    SqlCommand MyCommand2 = new SqlCommand(query3, connectstring);
                    connectstring.Open();
                    SqlDataAdapter DA2 = new SqlDataAdapter(MyCommand2);
                    DataTable DT2 = new DataTable();
                    DA2.Fill(DT2);
                    amountC = DT2.Rows.Count;
                    
                    amountO = amountC * 10;
                    connectstring.Close();
                    string query1 = "SELECT Name FROM Instructor WHERE  InstructorID ='" + Convert.ToInt32(txtInstructorID.Text) + "'";
                    SqlCommand MyCommand3 = new SqlCommand(query1, connectstring);
                    SqlDataReader MyReader3;
                    connectstring.Open();
                    MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                  
                    while (MyReader3.Read())
                    {
                        Name = MyReader3["Name"].ToString();
                    }
                    connectstring.Close();
                    string query4 = "SELECT Surname FROM Instructor WHERE  InstructorID ='" + Convert.ToInt32(txtInstructorID.Text) + "'";
                    SqlCommand MyCommand4 = new SqlCommand(query4, connectstring);
                    SqlDataReader MyReader4;
                    connectstring.Open();
                    MyReader4 = MyCommand4.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader4.Read())
                    {
                        Surname = MyReader4["Surname"].ToString();
                    }
                    connectstring.Close();
                    MessageBox.Show("Name: "+ Name + " \n Surname: " + Surname + "\n Royalties owed: $" + amountO + " \n", "Royalties", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
                   // Here our query will be executed and data saved into the database.  

              
              
            }else
            {
               
                MessageBox.Show("Information provided was invalid please resubmit the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateRoyalties_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", connectstring);
            SqlDataAdapter DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            connectstring.Close();
        }
    }
}
