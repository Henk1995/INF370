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
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        bool valid5 = false;
        bool valid6 = false;
        bool valid7 = false;
        SqlConnection connectstring = new SqlConnection(DBC);
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

        private void txtTrainingResult_TextChanged(object sender, EventArgs e)
        {
            valid5 = EH.Checkstring(txtTrainingResult.Text);
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
            int GenderID=0;
            int TitleID = 0;
            valid6 = EH.CheckEmpty(cmbCertification.Text);
            valid7 = EH.CheckEmpty(cmbGender.Text);
            valid8 = EH.CheckEmpty(cmbTitle.Text);
            if(valid1&&valid2&& valid3 && valid4 && valid5 && valid6 && valid7 && valid8)
            {
                MessageBox.Show("Are you sure you want to create this instructor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                DataTable DT = new DataTable();
                string query1 = "SELECT GenderID FROM Gender WHERE GenderName ='"+cmbGender.Text+"'";
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
                string Query = "INSERT INTO Instructor (Name,Surname,Email,PhoneNumber,GenderID,TitleID,Certufication) VALUES ('" + this.txtName.Text + "','" + this.txtSurname.Text + "','" + this.txtEmail.Text + "','" + this.txtPhoneNumber.Text + "','" + GenderID + "','" + TitleID + "','" + cmbCertification.Text + "');";
                SqlCommand MyCommand3 = new SqlCommand(Query, connectstring);
                SqlDataReader MyReader3;
                connectstring.Open();
                MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader3.Read())
                {
                }
                connectstring.Close();
            }
            else
            {
                MessageBox.Show("Information given was invalid please resubmit all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Title", connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            cmbGender.DataSource = DT;
            cmbGender.DataMember = DT.TableName;
            connectstring.Close();*/
        }

        private void CreateInstructor_Load(object sender, EventArgs e)
        {
            cmbCertification.Items.Clear();
            cmbCertification.Items.Add("Passed");
            cmbCertification.Items.Add("Failed");
            cmbGender.Items.Clear();
            cmbTitle.Items.Clear();
            string query1 = "SELECT GenderName FROM Gender ";
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand cmd = new SqlCommand(query1, connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            foreach (DataRow dr in DT.Rows)
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
    }
}
