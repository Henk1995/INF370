﻿using System;
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
    public partial class ViewInstructor : Form
    {
        
        bool valid1 = false;
        SqlDataAdapter DA;
        ErrorHandle EH = new ErrorHandle();
        public ViewInstructor()
        {
            InitializeComponent();
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
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
                string certifyID = dgvInstructor.SelectedRows[0].Cells[7].Value + string.Empty;

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
                string query3 = "SELECT CertificationName FROM Certification WHERE CertificationID ='" + Convert.ToInt32(certifyID) + "'";
                SqlCommand MyCommand3 = new SqlCommand(query3, ConnectString.connectstring);
                SqlDataReader MyReader3;
                ConnectString.connectstring.Open();
                MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader3.Read())
                {
                    certifyID = MyReader3["CertificationName"].ToString();
                }
                ConnectString.connectstring.Close();
                MessageBox.Show(" Name:" + NameId + "\n Surname:" + SurnameId + "\n Phone Number:" + phoneNumberId + " \n E-mail: " + emailId + " \n Certification:" + certifyID, "Result",
    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Please select the row that you want to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Instructors UM = new Instructors();
            UM.Show();
        }

        private void txtInstructorID_TextChanged(object sender, EventArgs e)
        {
            valid1 = EH.CheckEmpty(txtInstructorID.Text);
            valid1 = EH.CheckInt(txtInstructorID.Text);
            bool validSQl = EH.checkForSQLInjection(txtInstructorID.Text);
            if (valid1)
            {
                valid1 = validSQl;
            }
            if (!valid1)
            {
                txtInstructorID.BackColor = Color.Red;
            }
            else
            {
                txtInstructorID.BackColor = Color.White;
            }
        }

        private void titleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.titleBindingSource.EndEdit();
         //   this.tableAdapterManager.UpdateAll(this.iNF370DataSet);

        }

       /* private void instructorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instructorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNF370DataSet);

        }*/

        private void titleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
           // this.titleBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.iNF370DataSet);

        }

        private void ViewInstructor_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'iNF370DataSet.Title' table. You can move, or remove it, as needed.
//this.titleTableAdapter.Fill(this.iNF370DataSet.Title);

        }
    }
}
