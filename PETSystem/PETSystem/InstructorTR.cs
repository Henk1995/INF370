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
    public partial class InstructorTR : Form
    {
        
        ErrorHandle EH = new ErrorHandle();
        SqlDataAdapter DA;
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        public InstructorTR()
        {
            InitializeComponent();
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
            if(!valid1)
            {
                txtName.BackColor = Color.Red;
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("select * from Instructor where Name like '" + txtName.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dgvTR.DataSource = DT;
                ConnectString.connectstring.Close();

            }
            else
            {
                txtName.BackColor = Color.White;
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("select * from Instructor where Name like '" + txtName.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dgvTR.DataSource = DT;
                ConnectString.connectstring.Close();
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            valid2 = EH.Checkstring(txtSurname.Text);
            if (!valid2)
            {
                txtSurname.BackColor = Color.Red;
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("select * from Instructor where Surname like '" + txtSurname.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dgvTR.DataSource = DT;
                ConnectString.connectstring.Close();
            }
            else
            {
                txtSurname.BackColor = Color.White;
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("select * from Instructor where Surname like '" + txtSurname.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dgvTR.DataSource = DT;
                ConnectString.connectstring.Close();
            }
        }

        private void txtInstructorID_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.CheckInt(txtInstructorID.Text);
            if (!valid3)
            {
                txtInstructorID.BackColor = Color.Red;
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("select * from Instructor where InstructorID like '" + txtInstructorID.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dgvTR.DataSource = DT;
                ConnectString.connectstring.Close();
            }
            else
            {
                txtInstructorID.BackColor = Color.White;
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("select * from Instructor where InstructorID like '" + txtInstructorID.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dgvTR.DataSource = DT;
                ConnectString.connectstring.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(valid1&&valid2&&valid3)
            {
                if (dgvTR.SelectedRows.Count > 0)
                {
                    string InstructorID = dgvTR.SelectedRows[0].Cells[0].Value + string.Empty;
                    string NameId = dgvTR.SelectedRows[0].Cells[1].Value + string.Empty;
                    string SurnameId = dgvTR.SelectedRows[0].Cells[2].Value + string.Empty;
                    string emailId = dgvTR.SelectedRows[0].Cells[3].Value + string.Empty;
                    string phoneNumberId = dgvTR.SelectedRows[0].Cells[4].Value + string.Empty;
                    string Genderid = dgvTR.SelectedRows[0].Cells[5].Value + string.Empty;
                    string titleid = dgvTR.SelectedRows[0].Cells[6].Value + string.Empty;

                    string query2 = "SELECT TitleName FROM Title WHERE TitleID ='" + Convert.ToInt32(titleid) + "'";
                    SqlCommand MyCommand2 = new SqlCommand(query2, ConnectString.connectstring);
                    SqlDataReader MyReader2;
                    ConnectString.connectstring.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader2.Read())
                    {
                        titleid = MyReader2["TitleName"].ToString();
                    }
                    ConnectString.connectstring.Close();
                    string query1 = "SELECT GenderName FROM Gender WHERE GenderID ='" + Convert.ToInt32(Genderid) + "'";
                    SqlCommand MyCommand1 = new SqlCommand(query1, ConnectString.connectstring);
                    SqlDataReader MyReader1;
                    ConnectString.connectstring.Open();
                    MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader1.Read())
                    {
                        Genderid = MyReader1["GenderName"].ToString();
                    }
                    ConnectString.connectstring.Close();
                    MessageBox.Show(" Name:" + NameId + "\n Surname:" + SurnameId + "\n Phone Number:" + phoneNumberId + " \n E-mail: " + emailId + " \n Certification:", "Result",
        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Please select the row that you want to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Name:\n Surname:\n Phone Number: \n E-mail:\n Result:","Result",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }else
            {
                MessageBox.Show("Information provided is invalid please resubmit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void InstructorTR_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvTR.DataSource = DT;
            dgvTR.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
        }
    }
}
