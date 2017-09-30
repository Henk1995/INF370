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
using System.Configuration;
using System.Security.Cryptography;
using System.IO;

namespace PETSystem
{
    public partial class AddUser : Form
    {
        DateTime endOfTime;
        Timer t;
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        bool valid5 = false;
        bool valid6 = true;
        bool valid7 = true;
        ErrorHandle EH = new ErrorHandle();
        SqlDataAdapter DA;

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
             t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            // TODO: This line of code loads data into the 'iNF370DataSet.PrivilegeType' table. You can move, or remove it, as needed.
            //this.privilegeTypeTableAdapter.Fill(this.iNF370DataSet.PrivilegeType);
            cmbPrivilege.Items.Clear();
            string query = "SELECT PrivName FROM PrivilegeType ";
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query, ConnectString.connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            foreach(DataRow dr in DT.Rows)
            {
                cmbPrivilege.Items.Add(dr["PrivName"]).ToString();
            }
            ConnectString.connectstring.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            UserMenu UM = new UserMenu();
            UM.Show();
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUserN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
		
        }

        private void txtRetype_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddU_Click(object sender, EventArgs e)
        {
            bool duplicate = false;
            int privID = 0;
            valid1 = EH.CheckEmpty(txtFirst.Text);
            valid2 = EH.CheckEmpty(txtLastName.Text);
            valid3 = EH.CheckEmpty(txtUserN.Text);
            valid4 = EH.CheckEmpty(txtPass.Text);
           
            valid6 = EH.CheckEmpty(cmbPrivilege.Text);
            valid7 = EH.CheckEmpty(txtEmail.Text);
            if (valid1 && valid2 && valid3 && valid4 && valid5 && valid6 && valid7)
            {
                string queryA = "SELECT * FROM UserTable WHERE UserName ='" + txtUserN.Text + "'";
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
                    MessageBox.Show("Add username already exists please select a new one.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    DialogResult answer = MessageBox.Show("Add new user to the system?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (answer == DialogResult.Yes)
                    {


                        string query = "SELECT PrivilegeID FROM PrivilegeType WHERE PrivName='" + cmbPrivilege.Text + "'";
                        SqlCommand MyCommand1 = new SqlCommand(query, ConnectString.connectstring);
                        SqlDataReader MyReader1;
                        ConnectString.connectstring.Open();
                        MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                        while (MyReader1.Read())
                        {
                            privID = Convert.ToInt32(MyReader1["PrivilegeID"]);
                        }
                        ConnectString.connectstring.Close();
                        string Query = "INSERT INTO UserTable(Name,Surname,UserPassword,UserName,PriveledgeID, Email) values('" + this.txtFirst.Text + "','" + this.txtLastName.Text + "','" + Encrypt( this.txtPass.Text) + "','" + this.txtUserN.Text + "','" + privID + "','" + this.txtEmail.Text + "')";
                        //This is  MySqlConnection here i have created the object and pass my connection string.  

                        //This is command class which will handle the query and connection object.  
                        SqlCommand MyCommand2 = new SqlCommand(Query, ConnectString.connectstring);
                        SqlDataReader MyReader2;
                        ConnectString.connectstring.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        
                        while (MyReader2.Read())
                        {
                        }
                        ConnectString.connectstring.Close();
                        MessageBox.Show("User has been added to the system. \n Returning to User menu.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        UserMenu myform = new UserMenu();
                        this.Close();
                        myform.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("User has not been added to the system.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                }else
            {
                    MessageBox.Show("Please ensure all fields are filled in and correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

        private void cmbPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                   }

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private void txtFirst_Leave(object sender, EventArgs e)
        {
            valid1 = EH.Checkstring(txtFirst.Text);
            bool validSQl = EH.checkForSQLInjection(txtFirst.Text);
            if (valid1)
            {
                valid1 = validSQl;
            }
            if (!valid1)
            {
                txtFirst.BackColor = Color.Red;
            }
            else
            {
                txtFirst.BackColor = Color.White;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            valid2 = EH.Checkstring(txtLastName.Text);
            bool validSQl = EH.checkForSQLInjection(txtFirst.Text);
            if (valid2)
            {
                valid2 = validSQl;
            }
            if (!valid2)
            {
                txtLastName.BackColor = Color.Red;
            }
            else
            {
                txtLastName.BackColor = Color.White;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            valid7 = EH.CheckEmail(txtEmail.Text);
            bool validSQl = EH.checkForSQLInjection(txtEmail.Text);
            if (valid7)
            {
                valid7 = validSQl;
            }
            if (!valid7)
            {
                txtEmail.BackColor = Color.Red;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }

        }

        private void txtUserN_Leave(object sender, EventArgs e)
        {
            valid3 = EH.CheckstringNum(txtUserN.Text);
            bool validSQl = EH.checkForSQLInjection(txtFirst.Text);
            if (valid3)
            {
                valid3 = validSQl;
            }
            if (!valid3)
            {
                txtUserN.BackColor = Color.Red;
            }
            else
            {
                txtUserN.BackColor = Color.White;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            valid4 = EH.CheckstringNum(txtPass.Text);
            bool validSQl = EH.checkForSQLInjection(txtFirst.Text);
            if (valid4)
            {
                valid4 = validSQl;
            }
            if (!valid4)
            {
                txtPass.BackColor = Color.Red;
            }
            else
            {
                txtPass.BackColor = Color.White;
            }
        }

        private void txtRetype_Leave(object sender, EventArgs e)
        {
            txtRetype.PasswordChar = '*';
            valid5 = EH.CheckstringNum(txtRetype.Text);
            if ((!valid5) || (txtRetype.Text != txtPass.Text))
            {
                txtRetype.BackColor = Color.Red;
                valid5 = false;

            }
            else if ((valid5) || (txtRetype.Text == txtPass.Text))
            {
                txtRetype.BackColor = Color.White;
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
                lblLogout.Text = ts.ToString();
            }
        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
    }
