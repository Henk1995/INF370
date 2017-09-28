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
    public partial class Instructors : Form
    {
        
        SqlDataAdapter DA;
        public Instructors()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }

        private void Instructors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNF370DataSet.Instructor' table. You can move, or remove it, as needed.
            //  this.instructorTableAdapter.Fill(this.iNF370DataSet.Instructor);
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT Instructor.InstructorID,Instructor.Name,Instructor.Surname,Instructor.Email,Instructor.PhoneNumber, Gender.GenderName, Title.TitleName, Certification.CertificationName FROM Instructor INNER JOIN Gender ON Instructor.GenderID = Gender.GenderID INNER JOIN Title ON Instructor.TitleID = Title.TitleID INNER JOIN Certification ON Instructor.CertificationID = Certification.CertificationID;", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            ConnectString.connectstring.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateInstructor UM = new CreateInstructor();
            UM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            InstructorTR UM = new InstructorTR();
            UM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewInstructor UM = new ViewInstructor();
            UM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dgvInstructor.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string InstructorID = dgvInstructor.SelectedRows[0].Cells[0].Value + string.Empty;
                string NameId = dgvInstructor.SelectedRows[0].Cells[1].Value + string.Empty;
                string SurnameId = dgvInstructor.SelectedRows[0].Cells[2].Value + string.Empty;
                string emailId = dgvInstructor.SelectedRows[0].Cells[3].Value + string.Empty;
                string phoneNumberId = dgvInstructor.SelectedRows[0].Cells[4].Value + string.Empty;
                string Genderid = dgvInstructor.SelectedRows[0].Cells[5].Value + string.Empty;
                string titleid = dgvInstructor.SelectedRows[0].Cells[6].Value + string.Empty;
                
                int GenderID = 0;
                int TitleID = 0;
                //valid5 = EH.CheckEmpty(cmbGender.Text);
                //valid6 = EH.CheckEmpty(cmbTitle.Text);
                //if (valid1 && valid2 && valid3 && valid4 && valid5 && valid6)
                //{
                    DialogResult answer = MessageBox.Show("Are you sure you want to Update this instructor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (answer == DialogResult.Yes)
                    {
                        //This is my update query in which i am taking input from the user through windows forms and update the record.  
                        string querya = "SELECT GenderID FROM Gender WHERE GenderName ='" + Genderid + "'";
                        SqlCommand MyCommanda = new SqlCommand(querya, ConnectString.connectstring);
                        SqlDataReader MyReaderA;
                        ConnectString.connectstring.Open();
                        MyReaderA = MyCommanda.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                        while (MyReaderA.Read())
                        {
                            GenderID = Convert.ToInt32(MyReaderA["GenderID"]);
                        }
                        ConnectString.connectstring.Close();
                        string query3 = "SELECT TitleID FROM Title WHERE TitleName ='" + titleid + "'";
                        SqlCommand MyCommand3 = new SqlCommand(query3, ConnectString.connectstring);
                        SqlDataReader MyReader3;
                        ConnectString.connectstring.Open();
                        MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                        while (MyReader3.Read())
                        {
                            TitleID = Convert.ToInt32(MyReader3["TitleID"]);
                        }
                        ConnectString.connectstring.Close();
                        string Query = "UPDATE Instructor SET Name ='" + NameId + "', Surname = '" + SurnameId + "', Email = '" + emailId + "', PhoneNumber = '" + phoneNumberId + "', GenderID ='" + GenderID + "', TitleID = '" + TitleID + "' WHERE InstructorID =" + Convert.ToInt32(InstructorID) + ";";
                        //This is  MySqlConnection here i have created the object and pass my connection string.  

                        SqlCommand MyCommand4 = new SqlCommand(Query, ConnectString.connectstring);
                        SqlDataReader MyReader4;
                        ConnectString.connectstring.Open();
                        MyReader4 = MyCommand4.ExecuteReader();

                        while (MyReader4.Read())
                        {
                        }
                        ConnectString.connectstring.Close();//Connection closed here 
                        DataTable DT = new DataTable();
                        ConnectString.connectstring.Open();
                        SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
                        DA = new SqlDataAdapter(Fill);
                        DA.Fill(DT);
                        dgvInstructor.DataSource = DT;
                        dgvInstructor.DataMember = DT.TableName;
                        ConnectString.connectstring.Close();
                        MessageBox.Show("Instructor was Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Instructor was not Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                }
            }
        

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //DeleteInstructor UM = new DeleteInstructor();
            //UM.ShowDialog(); this.Visible = false;
            
                
                    if (dgvInstructor.SelectedRows.Count > 0)
                    {
                        int selectedIndex = dgvInstructor.SelectedRows[0].Index;

                        // gets the RowID from the first column in the grid
                        int rowID = int.Parse(dgvInstructor[0, selectedIndex].Value.ToString());


                DialogResult answer = MessageBox.Show("Are you sure you want to delete this instructor from the system?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (answer == DialogResult.Yes)
                {
                    string Query = "DELETE FROM Instructor WHERE InstructorID='" + rowID + "';";

                    SqlCommand MyCommand2 = new SqlCommand(Query, ConnectString.connectstring);
                    SqlDataReader MyReader2;
                    ConnectString.connectstring.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Instructor was deleted from the system.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    while (MyReader2.Read())
                    {
                    }
                    ConnectString.connectstring.Close();
                }
                else
                {
                    MessageBox.Show("Instructor was not deleted from the system.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                   
                }
                DataTable DT1 = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT1);
                dgvInstructor.DataSource = DT1;
                dgvInstructor.DataMember = DT1.TableName;
                ConnectString.connectstring.Close();
            }
        
                else
                {
                    MessageBox.Show("Please select the row that you want to delete", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            CalculateRoyalties UM = new CalculateRoyalties();
            UM.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchInstructor UM = new SearchInstructor();
            UM.Show();
        }

		
        private void dgvInstructor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
