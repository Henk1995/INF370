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
    public partial class UserMenu : Form
    {
       
        
        DataTable DT = new DataTable();
        
        static SqlCommand Fill = new SqlCommand("SELECT UserTable.UserID,UserTable.Name,UserTable.Surname,UserTable.UserName,UserTable.UserPassword,UserTable.Email,PrivilegeType.PrivName FROM UserTable INNER JOIN PrivilegeType ON PrivilegeType.PrivilegeID = UserTable.PriveledgeID", ConnectString.connectstring);
        SqlDataAdapter DA = new SqlDataAdapter(Fill);
      

        public UserMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNF370DataSet.UserTable' table. You can move, or remove it, as needed.
            // this.userTableTableAdapter.Fill(this.iNF370DataSet.UserTable);
           
            ConnectString.connectstring.Open();
            
            DA.Fill(DT);
            dgvUsers.DataSource = DT;
            dgvUsers.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
        }

        private void btnMainM_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUser UM = new AddUser();
            UM.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                SqlCommandBuilder cmd = new SqlCommandBuilder(DA);

                DA.Update(DT);
                ConnectString.connectstring.Open();

                DA.Fill(DT);
                dgvUsers.DataSource = DT;
                dgvUsers.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
                textBox1.Text = "a";
                textBox1.Text = "";
            }
            catch(Exception myerr)
            {
                
                MessageBox.Show(myerr.ToString());
                dgvUsers.DataSource = "";
                ConnectString.connectstring.Open();

                DA.Fill(DT);
                dgvUsers.DataSource = DT;
                dgvUsers.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ConnectString.connectstring.Open();
            DA = new SqlDataAdapter("SELECT UserTable.UserID,UserTable.Name,UserTable.Surname,UserTable.UserName,UserTable.UserPassword,UserTable.Email,PrivilegeType.PrivName FROM UserTable INNER JOIN PrivilegeType ON PrivilegeType.PrivilegeID = UserTable.PriveledgeID where Name like '%" + textBox1.Text + "%'", ConnectString.connectstring);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dgvUsers.DataSource = DT;
            ConnectString.connectstring.Close();
        }
    }
}
