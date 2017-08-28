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
    public partial class ChangePassword : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        ErrorHandle EH = new ErrorHandle();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginF UM = new LoginF();
            UM.ShowDialog();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            valid1 = EH.CheckstringNum(txtUserName.Text);
            if (!valid1)
            {
                txtUserName.BackColor = Color.Red;

            }else
            {
                txtUserName.BackColor = Color.White;
            }
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            valid2 = EH.CheckstringNum(txtOldPass.Text);
            if (!valid2)
            {
                txtOldPass.BackColor = Color.Red;

            }
            else
            {
                txtOldPass.BackColor = Color.White;
            }
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.CheckstringNum(txtNewPass.Text);
            if (!valid3)
            {
                txtNewPass.BackColor = Color.Red;

            }
            else
            {
                txtNewPass.BackColor = Color.White;
            }
        }

        private void txtNewRePass_TextChanged(object sender, EventArgs e)
        {
            valid4 = EH.CheckstringNum(txtNewRePass.Text);
            if ((!valid4) || (txtNewPass.Text != txtNewRePass.Text))
            {
                valid4 = false;
                txtNewRePass.BackColor = Color.Red;

            }
            else
            {
                txtNewRePass.BackColor = Color.White;
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string Query1 = "SELECT * FROM UserTable WHERE UserName ='" + this.txtUserName.Text + "'AND UserPassword='"+this.txtOldPass.Text+"';";
            SqlCommand MyCommand = new SqlCommand(Query1, connectstring);
            SqlDataReader MyReader;
            SqlDataAdapter DA = new SqlDataAdapter(MyCommand);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            connectstring.Open();
            MyReader = MyCommand.ExecuteReader();
            
            if (DT.Rows.Count == 0)
                {
                   
                    valid1 = false;
                valid2 = false;
                }
            
            connectstring.Close();
            if (valid1 & valid2 & valid3 & valid4)
            {
                MessageBox.Show("Change password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                string Query = "UPDATE UserTable SET UserPassword ='" + this.txtNewPass.Text + "' WHERE UserName ='" + this.txtUserName.Text + "';";
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
                MessageBox.Show("Password succesfully changed.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                if (!valid1&&!valid2)
                {
                    MessageBox.Show("Username and/or password is incorrect please resubmit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if (!valid2)
                {
                    MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNewPass.Text != txtNewRePass.Text) 
                {
                    MessageBox.Show("New passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show("Information invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
