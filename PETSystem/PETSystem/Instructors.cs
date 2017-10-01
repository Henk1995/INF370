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
        DateTime endOfTime;
        Timer t;
        SqlDataAdapter DA;
        ErrorHandle EH;
        public Instructors()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }

        private void Instructors_Load(object sender, EventArgs e)
        {

            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            comboBox1.SelectedIndex = 0;
            // TODO: This line of code loads data into the 'iNF370DataSet.Instructor' table. You can move, or remove it, as needed.
            //  this.instructorTableAdapter.Fill(this.iNF370DataSet.Instructor);
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT Instructor.InstructorID,Instructor.Name,Instructor.Surname,Instructor.Email,Instructor.PhoneNumber, Gender.GenderName, Title.TitleName, Certification.CertificationName FROM Instructor INNER JOIN Gender ON Instructor.GenderID = Gender.GenderID INNER JOIN Title ON Instructor.TitleID = Title.TitleID INNER JOIN Certification ON Instructor.CertificationID = Certification.CertificationID", ConnectString.connectstring);
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
            if (dgvInstructor.SelectedRows.Count > 0)
            {
                string InstructorID = dgvInstructor.SelectedRows[0].Cells[0].Value + string.Empty;
                string NameId = dgvInstructor.SelectedRows[0].Cells[1].Value + string.Empty;
                string SurnameId = dgvInstructor.SelectedRows[0].Cells[2].Value + string.Empty;
                string emailId = dgvInstructor.SelectedRows[0].Cells[3].Value + string.Empty;
                string phoneNumberId = dgvInstructor.SelectedRows[0].Cells[4].Value + string.Empty;
                string Genderid = dgvInstructor.SelectedRows[0].Cells[5].Value + string.Empty;
                string titleid = dgvInstructor.SelectedRows[0].Cells[6].Value + string.Empty;

               
                MessageBox.Show(" Name:" + NameId + "\n Surname:" + SurnameId + "\n Phone Number:" + phoneNumberId + " \n E-mail: " + emailId + " \n Certification:", "Result",
    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Please select the row that you want to view", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            //this.Close();
            //InstructorTR UM = new InstructorTR();
            //UM.Show();
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
                ConnectString.InstructorID = Convert.ToInt32(InstructorID);
                string NameId = dgvInstructor.SelectedRows[0].Cells[1].Value + string.Empty;
                string SurnameId = dgvInstructor.SelectedRows[0].Cells[2].Value + string.Empty;
                string emailId = dgvInstructor.SelectedRows[0].Cells[3].Value + string.Empty;
                string phoneNumberId = dgvInstructor.SelectedRows[0].Cells[4].Value + string.Empty;
                string Genderid = dgvInstructor.SelectedRows[0].Cells[5].Value + string.Empty;
                string titleid = dgvInstructor.SelectedRows[0].Cells[6].Value + string.Empty;
                this.Close();
                this.Dispose(true);
                UpdateInstructor UD = new UpdateInstructor(NameId, SurnameId, emailId, phoneNumberId, Genderid, titleid);
                UD.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select a valid row");
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //DeleteInstructor UM = new DeleteInstructor();
            //UM.ShowDialog(); this.Visible = false;

            try { 
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
                    catch
            {
                ConnectString.connectstring.Close();
                MessageBox.Show("Instructor cannot be deleted as he/she is the instructor of an active course", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                dgvInstructor.ClearSelection();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Name = "";
            string Surname = "";
            int courseid = 0;
            int amountC = 0;
            int amountO = 0;
            if (dgvInstructor.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvInstructor.SelectedRows[0].Index;

                // gets the RowID from the first column in the grid
                int rowID = int.Parse(dgvInstructor[0, selectedIndex].Value.ToString());
                string queryA = "SELECT * FROM Instructor WHERE InstructorID ='" + rowID + "'";
                SqlCommand MyCommandA = new SqlCommand(queryA, ConnectString.connectstring);

                SqlDataAdapter DAA = new SqlDataAdapter(MyCommandA);
                DataTable DTA = new DataTable();
                DAA.Fill(DTA);
              
          
                string query2 = "SELECT CourseID FROM CourseInstance WHERE InstructorID ='" + rowID + "'";
                SqlCommand MyCommand = new SqlCommand(query2, ConnectString.connectstring);
                SqlDataReader MyReader;
                SqlDataAdapter DA = new SqlDataAdapter(MyCommand);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                ConnectString.connectstring.Open();


                if (DT.Rows.Count == 0)
                {
                    ConnectString.connectstring.Close();

                    string query1 = "SELECT Name FROM Instructor WHERE  InstructorID ='" + rowID + "'";
                    SqlCommand MyCommand3 = new SqlCommand(query1, ConnectString.connectstring);
                    SqlDataReader MyReader3;
                    ConnectString.connectstring.Open();
                    MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader3.Read())
                    {
                        Name = MyReader3["Name"].ToString();
                    }
                    ConnectString.connectstring.Close();
                    string query4 = "SELECT Surname FROM Instructor WHERE  InstructorID ='" + rowID + "'";
                    SqlCommand MyCommand4 = new SqlCommand(query4, ConnectString.connectstring);
                    SqlDataReader MyReader4;
                    ConnectString.connectstring.Open();
                    MyReader4 = MyCommand4.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader4.Read())
                    {
                        Surname = MyReader4["Surname"].ToString();
                    }
                    ConnectString.connectstring.Close();
                    MessageBox.Show("Name: " + Name + " \n Surname: " + Surname + "\n Royalties owed: $" + amountO + " \n", "Royalties", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MyReader = MyCommand.ExecuteReader();
                    while (MyReader.Read())
                    {
                        courseid = Convert.ToInt32(MyReader["CourseID"]);
                    }
                    ConnectString.connectstring.Close();

                    string query3 = "SELECT * FROM ClientCourseLine WHERE CourseID ='" + courseid + "'";
                    SqlCommand MyCommand2 = new SqlCommand(query3, ConnectString.connectstring);
                    ConnectString.connectstring.Open();
                    SqlDataAdapter DA2 = new SqlDataAdapter(MyCommand2);
                    DataTable DT2 = new DataTable();
                    DA2.Fill(DT2);
                    amountC = DT2.Rows.Count;

                    amountO = amountC * 10;
                    ConnectString.connectstring.Close();
                    string query1 = "SELECT Name FROM Instructor WHERE  InstructorID ='" + rowID + "'";
                    SqlCommand MyCommand3 = new SqlCommand(query1, ConnectString.connectstring);
                    SqlDataReader MyReader3;
                    ConnectString.connectstring.Open();
                    MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader3.Read())
                    {
                        Name = MyReader3["Name"].ToString();
                    }
                    ConnectString.connectstring.Close();
                    string query4 = "SELECT Surname FROM Instructor WHERE  InstructorID ='" + rowID + "'";
                    SqlCommand MyCommand4 = new SqlCommand(query4, ConnectString.connectstring);
                    SqlDataReader MyReader4;
                    ConnectString.connectstring.Open();
                    MyReader4 = MyCommand4.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader4.Read())
                    {
                        Surname = MyReader4["Surname"].ToString();
                    }
                    ConnectString.connectstring.Close();
                    MessageBox.Show("Name: " + Name + " \n Surname: " + Surname + "\n Royalties owed: $" + amountO + " \n", "Royalties", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                // Here our query will be executed and data saved into the database.  



            }
            else
            {

                MessageBox.Show("Information provided was invalid please resubmit the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

		
        private void dgvInstructor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtInstructorID_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
          //  valid = EH.CheckInt(txtInstructorID.Text);
          //  bool validSQl = EH.checkForSQLInjection(txtInstructorID.Text);
            if (valid)
            {
              //  valid = validSQl;
            }
            if (valid)
            {
              
            }
            else
            {
             
            }
            //Name surname phone email
            if (comboBox1.SelectedIndex == 0)
            {
                DataTable DT2 = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fillz = new SqlCommand("SELECT Instructor.InstructorID,Instructor.Name,Instructor.Surname,Instructor.Email,Instructor.PhoneNumber, Gender.GenderName, Title.TitleName, Certification.CertificationName FROM Instructor INNER JOIN Gender ON Gender.GenderID = Instructor.GenderID  INNER JOIN Title ON Title.TitleID =  Instructor.TitleID INNER JOIN Certification ON Certification.CertificationID = Instructor.CertificationID  Where Instructor.Name Like '%" + txtInstructorID.Text + "%'", ConnectString.connectstring);
                SqlDataAdapter DA2 = new SqlDataAdapter(Fillz);
                DA2.Fill(DT2);
                dgvInstructor.DataSource = DT2;
                dgvInstructor.DataMember = DT2.TableName;
                txtInstructorID.BackColor = Color.White;
                ConnectString.connectstring.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DataTable DT2 = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fillz = new SqlCommand("SELECT Instructor.InstructorID,Instructor.Name,Instructor.Surname,Instructor.Email,Instructor.PhoneNumber, Gender.GenderName, Title.TitleName, Certification.CertificationName FROM Instructor INNER JOIN Gender ON Gender.GenderID = Instructor.GenderID  INNER JOIN Title ON Title.TitleID =  Instructor.TitleID INNER JOIN Certification ON Certification.CertificationID = Instructor.CertificationID  Where Instructor.Surname Like '%" + txtInstructorID.Text + "%'", ConnectString.connectstring);
                SqlDataAdapter DA2 = new SqlDataAdapter(Fillz);
                DA2.Fill(DT2);
                dgvInstructor.DataSource = DT2;
                dgvInstructor.DataMember = DT2.TableName;
                txtInstructorID.BackColor = Color.White;
                ConnectString.connectstring.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                DataTable DT2 = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fillz = new SqlCommand("SELECT Instructor.InstructorID,Instructor.Name,Instructor.Surname,Instructor.Email,Instructor.PhoneNumber, Gender.GenderName, Title.TitleName, Certification.CertificationName FROM Instructor INNER JOIN Gender ON Gender.GenderID = Instructor.GenderID  INNER JOIN Title ON Title.TitleID =  Instructor.TitleID INNER JOIN Certification ON Certification.CertificationID = Instructor.CertificationID  Where Instructor.PhoneNumber Like '%" + txtInstructorID.Text + "%'", ConnectString.connectstring);
                SqlDataAdapter DA2 = new SqlDataAdapter(Fillz);
                DA2.Fill(DT2);
                dgvInstructor.DataSource = DT2;
                dgvInstructor.DataMember = DT2.TableName;
                txtInstructorID.BackColor = Color.White;
                ConnectString.connectstring.Close();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                DataTable DT2 = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fillz = new SqlCommand("SELECT Instructor.InstructorID,Instructor.Name,Instructor.Surname,Instructor.Email,Instructor.PhoneNumber, Gender.GenderName, Title.TitleName, Certification.CertificationName FROM Instructor INNER JOIN Gender ON Gender.GenderID = Instructor.GenderID  INNER JOIN Title ON Title.TitleID =  Instructor.TitleID INNER JOIN Certification ON Certification.CertificationID = Instructor.CertificationID  Where Instructor.Email Like '%" + txtInstructorID.Text + "%'", ConnectString.connectstring);
                SqlDataAdapter DA2 = new SqlDataAdapter(Fillz);
                DA2.Fill(DT2);
                dgvInstructor.DataSource = DT2;
                dgvInstructor.DataMember = DT2.TableName;
                txtInstructorID.BackColor = Color.White;
                ConnectString.connectstring.Close();
            }
            else
            {
                MessageBox.Show("Please select a search paramater");
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
          //  valid = EH.Checkstring(txtSurname.Text);
            bool validSQl = EH.checkForSQLInjection(txtInstructorID.Text);
            if (valid)
            {
                valid = validSQl;
            }
            if (valid)
            {
            
            }
            else
            {
              
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
//valid = EH.Checkstring(txtName.Text);
            bool validSQl = EH.checkForSQLInjection(txtInstructorID.Text);
            if (valid)
            {
                valid = validSQl;
            }
            if (valid)
            {
             
            }
            else
            {
             
            }
        }

        private void txtInstructorID_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (dgvInstructor.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvInstructor.SelectedRows[0].Index;

                // gets the RowID from the first column in the grid
                ConnectString.InstructorID = int.Parse(dgvInstructor[0, selectedIndex].Value.ToString());
                ConnectString.InstructorName = dgvInstructor.SelectedRows[0].Cells[1].Value + string.Empty;
                ConnectString.InstructorSurname = dgvInstructor.SelectedRows[0].Cells[2].Value + string.Empty;
                ConnectString.instructorEmail = dgvInstructor.SelectedRows[0].Cells[3].Value + string.Empty;
                ConnectString.InstructorPhoneNumber = dgvInstructor.SelectedRows[0].Cells[4].Value + string.Empty;
                ConnectString.InstructorGender = dgvInstructor.SelectedRows[0].Cells[5].Value + string.Empty;
                ConnectString.InstructorTitle = dgvInstructor.SelectedRows[0].Cells[6].Value + string.Empty;
                this.Close();
                InstructorBioForm um = new InstructorBioForm();
                um.ShowDialog();
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

        private void Instructors_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
