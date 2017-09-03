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
    public partial class CreateInstructor : Form
    {
        SqlDataAdapter DA;
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        bool valid5 = false;
        bool valid6 = false;
        bool valid7 = false;
        
        bool valid8 = false;
        ErrorHandle EH = new ErrorHandle();
        public CreateInstructor()
        {
            InitializeComponent();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Instructors UM = new Instructors();
            UM.ShowDialog();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            valid1 = EH.Checkstring(txtName.Text);
            bool validSQl = EH.checkForSQLInjection(txtName.Text);
            if (valid1)
            {
                valid1 = validSQl;
            }
            if (!valid1)
            {
                txtName.BackColor = Color.Red;
            }else
            {
                txtName.BackColor = Color.White;
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            valid2 = EH.Checkstring(txtSurname.Text);
            bool validSQl = EH.checkForSQLInjection(txtSurname.Text);
            if (valid2)
            {
                valid2 = validSQl;
            }
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
            bool validSQl = EH.checkForSQLInjection(txtEmail.Text);
            if (valid3)
            {
                valid3 = validSQl;
            }
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
            valid4 = EH.CheckphoneNum(txtPhoneNumber.Text);
            bool validSQl = EH.checkForSQLInjection(txtPhoneNumber.Text);
            if (valid4)
            {
                valid4 = validSQl;
            }
            if (!valid4)
            {
                txtPhoneNumber.BackColor = Color.Red;
            }
            else
            {
                txtPhoneNumber.BackColor = Color.White;
            }
        }

        private void txtTrainingResult_TextChanged(object sender, EventArgs e)
        {
            valid5 = EH.Checkstring(txtTrainingResult.Text);
            bool validSQl = EH.checkForSQLInjection(txtTrainingResult.Text);
            if (valid5)
            {
                valid5 = validSQl;
            }
            if (!valid5)
            {
                txtTrainingResult.BackColor = Color.Red;
            }
            else
            {
                txtTrainingResult.BackColor = Color.White;
            }
        }

        private void btnCreateInstructor_Click(object sender, EventArgs e)
        {
            bool duplicate = false;
            int GenderID = 0;
            int TitleID = 0;
            int CertificationID = 0;
            valid6 = EH.CheckEmpty(cmbCertification.Text);
            valid7 = EH.CheckEmpty(cmbGender.Text);
            valid8 = EH.CheckEmpty(cmbTitle.Text);
            if (valid1 && valid2 && valid3 && valid4 && valid5 && valid6 && valid7 && valid8)
            {
                string queryA = "SELECT * FROM Instructor WHERE  Email='" + txtEmail.Text + "' OR PhoneNumber='"+ txtPhoneNumber.Text+"'";
                SqlCommand MyCommandA = new SqlCommand(queryA, ConnectString.connectstring);

                SqlDataAdapter DAA = new SqlDataAdapter(MyCommandA);
                DataTable DTA = new DataTable();
                DAA.Fill(DTA);
                ConnectString.connectstring.Open();


                if (DTA.Rows.Count == 1)
                {

                    duplicate = true;
                }
                ConnectString.connectstring.Close();
                if (duplicate)
                {
                    MessageBox.Show("An instructor with that email/phone number already exists.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                }
                else
                {
                    DialogResult answer = MessageBox.Show("Add new instructor to the system?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (answer == DialogResult.Yes)
                    {
                        DataTable DT = new DataTable();
                        string query4 = "SELECT CertificationID FROM Certification WHERE CertificationName ='" + cmbCertification.Text + "'";
                        SqlCommand MyCommand4 = new SqlCommand(query4, ConnectString.connectstring);
                        SqlDataReader MyReader4;
                        ConnectString.connectstring.Open();
                        MyReader4 = MyCommand4.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                        while (MyReader4.Read())
                        {
                            CertificationID = Convert.ToInt32(MyReader4["CertificationID"]);
                        }
                        ConnectString.connectstring.Close();
                        string query1 = "SELECT GenderID FROM Gender WHERE GenderName ='" + cmbGender.Text + "'";
                        SqlCommand MyCommand1 = new SqlCommand(query1, ConnectString.connectstring);
                        SqlDataReader MyReader1;
                        ConnectString.connectstring.Open();
                        MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                        while (MyReader1.Read())
                        {
                            GenderID = Convert.ToInt32(MyReader1["GenderID"]);
                        }
                        ConnectString.connectstring.Close();
                        string query2 = "SELECT TitleID FROM Title WHERE TitleName ='" + cmbTitle.Text + "'";
                        SqlCommand MyCommand2 = new SqlCommand(query2, ConnectString.connectstring);
                        SqlDataReader MyReader2;
                        ConnectString.connectstring.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                        while (MyReader2.Read())
                        {
                            TitleID = Convert.ToInt32(MyReader2["TitleID"]);
                        }
                        ConnectString.connectstring.Close();
                        string Query = "INSERT INTO Instructor (Name,Surname,Email,PhoneNumber,GenderID,TitleID,CertificationID) VALUES ('" + this.txtName.Text + "','" + this.txtSurname.Text + "','" + this.txtEmail.Text + "','" + this.txtPhoneNumber.Text + "','" + GenderID + "','" + TitleID + "','" + CertificationID + "');";
                        SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                        SqlDataReader MyReader3;
                        ConnectString.connectstring.Open();
                        MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        
                        while (MyReader3.Read())
                        {
                        }
                        ConnectString.connectstring.Close();
                        MessageBox.Show("Instructor has been added to the system.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                    {
                        MessageBox.Show("Instructor has not been added to the system.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                }
            }
            else
            {
                MessageBox.Show("Information given was invalid please resubmit all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Title", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            cmbGender.DataSource = DT;
            cmbGender.DataMember = DT.TableName;
            ConnectString.connectstring.Close();*/
        }

        private void CreateInstructor_Load(object sender, EventArgs e)
        { 
            cmbCertification.Items.Clear();
          
            cmbGender.Items.Clear();
            cmbTitle.Items.Clear();
            string query1 = "SELECT GenderName FROM Gender ";
        DataTable DT = new DataTable();
        ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query1, ConnectString.connectstring);
        DA = new SqlDataAdapter(cmd);
        DA.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                cmbGender.Items.Add(dr["GenderName"]).ToString();
    }
    string query2 = "SELECT TitleName FROM Title ";
    DataTable DT2 = new DataTable();

    SqlCommand cmd2 = new SqlCommand(query2, ConnectString.connectstring);
    DA = new SqlDataAdapter(cmd2);
    DA.Fill(DT2);
            foreach (DataRow dr in DT2.Rows)
            {
                cmbTitle.Items.Add(dr["TitleName"]).ToString();
}
ConnectString.connectstring.Close();
            string query3 = "SELECT CertificationName FROM Certification ";
DataTable DT3 = new DataTable();
ConnectString.connectstring.Open();
            SqlCommand cmd3 = new SqlCommand(query3, ConnectString.connectstring);
DA = new SqlDataAdapter(cmd3);
DA.Fill(DT3);
            foreach (DataRow dr in DT3.Rows)
            {
                cmbCertification.Items.Add(dr["CertificationName"]).ToString();
            }
            ConnectString.connectstring.Close();
        }
    }
}
