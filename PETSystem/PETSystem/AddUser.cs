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
    public partial class AddUser : Form
    {
       
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        bool valid5 = false;
        bool valid6 = true;
        ErrorHandle EH = new ErrorHandle();
        SqlDataAdapter DA;

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
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
            this.Visible = false;
            UserMenu UM = new UserMenu();
            UM.ShowDialog();
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            valid1 = EH.Checkstring(txtFirst.Text);
            if (!valid1)
            {
                txtFirst.BackColor = Color.Red;
            }
            else
            {
                txtFirst.BackColor = Color.White;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            valid2 = EH.Checkstring(txtLastName.Text);
            if (!valid2)
            {
                txtLastName.BackColor = Color.Red;
            }
            else
            {
                txtLastName.BackColor = Color.White;
            }
        }

        private void txtUserN_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.CheckstringNum(txtUserN.Text);
            if (!valid3)
            {
                txtUserN.BackColor = Color.Red;
            }
            else
            {
                txtUserN.BackColor = Color.White;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            valid4 = EH.CheckstringNum(txtPass.Text);
            if (!valid4)
            {
                txtPass.BackColor = Color.Red;
            }
            else
            {
                txtPass.BackColor = Color.White;
            }
        }

        private void txtRetype_TextChanged(object sender, EventArgs e)
        {
            
            valid5 = EH.CheckstringNum(txtRetype.Text);
            if ((!valid5)|| (txtRetype.Text != txtPass.Text))
            {
                txtRetype.BackColor = Color.Red;
                
            }
            else if ((valid5) || (txtRetype.Text == txtPass.Text))
            {
                txtRetype.BackColor = Color.White;
            }
        }

        private void btnAddU_Click(object sender, EventArgs e)
        {
            
            if (valid1&&valid2&&valid3&&valid4&&valid5&&valid6)
            {
                int privID =0;
                valid1 = EH.CheckEmpty(txtFirst.Text);
                valid2 = EH.CheckEmpty(txtLastName.Text);
                valid3 = EH.CheckEmpty(txtUserN.Text);
                valid4 = EH.CheckEmpty(txtPass.Text);
                valid5 = EH.CheckEmpty(txtRetype.Text);
                valid6 = EH.CheckEmpty(cmbPrivilege.Text);
                string query = "SELECT PrivilegeID FROM PrivilegeType WHERE PrivName='"+ cmbPrivilege.Text+"'";
                SqlCommand MyCommand1 = new SqlCommand(query, ConnectString.connectstring);
                SqlDataReader MyReader1;
                ConnectString.connectstring.Open();
                MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                
                while (MyReader1.Read())
                {
                    privID = Convert.ToInt32( MyReader1["PrivilegeID"]);
                }
                ConnectString.connectstring.Close();
                string Query = "INSERT INTO UserTable(Name,Surname,UserPassword,UserName,PriveledgeID) values('" + this.txtFirst.Text + "','" + this.txtLastName.Text + "','" + this.txtPass.Text + "','" + this.txtUserN.Text + "','" + privID + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                
                //This is command class which will handle the query and connection object.  
                SqlCommand MyCommand2 = new SqlCommand(Query, ConnectString.connectstring);
                SqlDataReader MyReader2;
                ConnectString.connectstring.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                ConnectString.connectstring.Close();
                MessageBox.Show("Add new user to the system?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }else
            {
                MessageBox.Show("Please ensure all fields are filled in and correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
