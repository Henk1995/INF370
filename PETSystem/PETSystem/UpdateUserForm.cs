using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PETSystem
{
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            label1.Text = "User ID: "+ConnectString.UserID;
            txtName.Text = ConnectString.Name;
            txtSurname.Text = ConnectString.Surname;
            txtUsername.Text = ConnectString.UserName;
            txtPassword.Text = ConnectString.Password;
            txtEmail.Text = ConnectString.Password;

            //populate combobox
            cbPriviledge.Items.Clear();
            string query = "SELECT PrivName FROM PrivilegeType ";
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query, ConnectString.connectstring);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                cbPriviledge.Items.Add(dr["PrivName"]).ToString();
            }
            ConnectString.connectstring.Close();

            if (ConnectString.Priv == "Admin")
            {
                cbPriviledge.SelectedIndex = 0;

            }
            else
            {
                cbPriviledge.SelectedIndex = 1;
            }
            ConnectString.connectstring.Close();
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Update
            try
            {
                int privUSer = cbPriviledge.SelectedIndex;
                privUSer = privUSer + 1;
                string Query = "UPDATE UserTable SET Name ='" + this.txtName.Text + "', Surname = '" + this.txtSurname.Text + "', UserPassword = '" + this.txtPassword.Text + "', UserName = '" + this.txtUsername.Text + "', PriveledgeID ='" + privUSer+ "', Email = '" + this.txtEmail.Text + "' WHERE UserID =" + ConnectString.UserID + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                DialogResult answer = MessageBox.Show("Are you sure you want to Update this User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (answer == DialogResult.Yes)
                {
                    
                    SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                    SqlDataReader MyReader3;
                    ConnectString.connectstring.Open();
                    MyReader3 = MyCommand3.ExecuteReader();
                    MessageBox.Show("User successfully updated");
                    ConnectString.connectstring.Close();
                    this.Close();
                    this.Dispose(true);
                    UserMenu myform = new UserMenu();
                    myform.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("No Changes Made");
                    ConnectString.connectstring.Close();
                }
            }
            catch
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            UserMenu myform = new UserMenu();
            myform.ShowDialog();
        }
    }
}
