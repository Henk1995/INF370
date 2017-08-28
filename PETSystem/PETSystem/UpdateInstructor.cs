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
    public partial class UpdateInstructor : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        SqlDataAdapter DA;
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        bool valid5 = false;
        bool valid6 = false;
        string InstructorID;

        ErrorHandle EH = new ErrorHandle();
        public UpdateInstructor()
        {
            InitializeComponent();
            
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            connectstring.Close();
            cmbGender.Items.Clear();
            cmbTitle.Items.Clear();
            string query1 = "SELECT GenderName FROM Gender ";
            DataTable DT1 = new DataTable();
            connectstring.Open();
            SqlCommand cmd = new SqlCommand(query1, connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT1);
            foreach (DataRow dr in DT1.Rows)
            {
                cmbGender.Items.Add(dr["GenderName"]).ToString();
            }
            string query2 = "SELECT TitleName FROM Title ";
            DataTable DT2 = new DataTable();

            SqlCommand cmd2 = new SqlCommand(query2, connectstring);
            DA = new SqlDataAdapter(cmd2);
            DA.Fill(DT2);
            foreach (DataRow dr in DT2.Rows)
            {
                cmbTitle.Items.Add(dr["TitleName"]).ToString();
            }
            connectstring.Close();
           
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Instructors UM = new Instructors();
            UM.ShowDialog();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            valid1 = EH.Checkstring(txtName.Text);
            if (!valid1)
            {
                txtName.BackColor = Color.Red;
            }
            else
            {
                txtName.BackColor = Color.White;
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            valid2 = EH.Checkstring(txtSurname.Text);
            if (!valid2)
            {
                txtSurname.BackColor = Color.Red;
            }
            else
            {
                txtSurname.BackColor = Color.White;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.CheckEmail(txtEmail.Text);
            if (!valid3)
            {
                txtEmail.BackColor = Color.Red;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            valid4 = EH.CheckInt(txtPhoneNumber.Text);
            if (!valid4)
            {
                txtPhoneNumber.BackColor = Color.Red;
            }
            else
            {
                txtPhoneNumber.BackColor = Color.White;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int GenderID = 0;
            int TitleID = 0;
            valid5 = EH.CheckEmpty(cmbGender.Text);
            valid6 = EH.CheckEmpty(cmbTitle.Text);
            if (valid1 && valid2 && valid3 && valid4 && valid5 && valid6)
            {
                MessageBox.Show("Are you sure you want to Update this instructor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string query1 = "SELECT GenderID FROM Gender WHERE GenderName ='" + cmbGender.Text + "'";
                SqlCommand MyCommand1 = new SqlCommand(query1, connectstring);
                SqlDataReader MyReader1;
                connectstring.Open();
                MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader1.Read())
                {
                    GenderID = Convert.ToInt32(MyReader1["GenderID"]);
                }
                connectstring.Close();
                string query2 = "SELECT TitleID FROM Title WHERE TitleName ='" + cmbTitle.Text + "'";
                SqlCommand MyCommand2 = new SqlCommand(query2, connectstring);
                SqlDataReader MyReader2;
                connectstring.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader2.Read())
                {
                    TitleID = Convert.ToInt32(MyReader2["TitleID"]);
                }
                connectstring.Close();
                string Query = "UPDATE Instructor SET Name ='" + this.txtName.Text + "', Surname = '" + this.txtSurname.Text + "', Email = '" + this.txtEmail.Text + "', PhoneNumber = '" + this.txtPhoneNumber.Text + "', GenderID ='" + GenderID + "', TitleID = '" + TitleID + "' WHERE InstructorID ="+Convert.ToInt32(InstructorID)+";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                
                SqlCommand MyCommand3 = new SqlCommand(Query, connectstring);
                SqlDataReader MyReader3;
                connectstring.Open();
                MyReader3 = MyCommand3.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader3.Read())
                {
                }
                connectstring.Close();//Connection closed here 
                DataTable DT = new DataTable();
                connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvInstructor.DataSource = DT;
                dgvInstructor.DataMember = DT.TableName;
                connectstring.Close();
            }
            else
            {
                MessageBox.Show("Information given was invalid please resubmit all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        

        

        private void dgvInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInstructor.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                InstructorID = dgvInstructor.SelectedRows[0].Cells[0].Value + string.Empty;
                string NameId = dgvInstructor.SelectedRows[0].Cells[1].Value + string.Empty;
                string SurnameId = dgvInstructor.SelectedRows[0].Cells[2].Value + string.Empty;
                string emailId = dgvInstructor.SelectedRows[0].Cells[3].Value + string.Empty;
                string phoneNumberId = dgvInstructor.SelectedRows[0].Cells[4].Value + string.Empty;
                string Genderid = dgvInstructor.SelectedRows[0].Cells[5].Value + string.Empty;
                string titleid = dgvInstructor.SelectedRows[0].Cells[6].Value + string.Empty;
                string query2 = "SELECT TitleName FROM Title WHERE TitleID ='" + Convert.ToInt32(titleid) + "'";
                SqlCommand MyCommand2 = new SqlCommand(query2, connectstring);
                SqlDataReader MyReader2;
                connectstring.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader2.Read())
                {
                    titleid = MyReader2["TitleName"].ToString();
                }
                connectstring.Close();
                string query1 = "SELECT GenderName FROM Gender WHERE GenderID ='" + Convert.ToInt32(Genderid) + "'";
                SqlCommand MyCommand1 = new SqlCommand(query1, connectstring);
                SqlDataReader MyReader1;
                connectstring.Open();
                MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader1.Read())
                {
                    Genderid = MyReader1["GenderName"].ToString();
                }
                connectstring.Close();
                txtEmail.Text = emailId;
                txtName.Text = NameId;
                txtSurname.Text = SurnameId;
                txtPhoneNumber.Text = phoneNumberId;
                cmbGender.Text = Genderid;
                cmbTitle.Text = titleid;
            }
            }
    }
}
