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
       static SqlCommand Fill = new SqlCommand("SELECT * FROM UserTable", ConnectString.connectstring);
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
            this.Visible = false;
            MainMenuF UM = new MainMenuF();
            UM.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddUser UM = new AddUser();
            UM.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmd = new SqlCommandBuilder(DA);

            DA.Update(DT);
            ConnectString.connectstring.Open();

            DA.Fill(DT);
            dgvUsers.DataSource = DT;
            dgvUsers.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ConnectString.connectstring.Open();
            DA = new SqlDataAdapter("select * from UserTable where Name like '" + textBox1.Text + "%'", ConnectString.connectstring);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dgvUsers.DataSource = DT;
            ConnectString.connectstring.Close();
        }
    }
}
