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
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
       static SqlConnection connectstring = new SqlConnection(DBC);
        
        DataTable DT = new DataTable();
       static SqlCommand Fill = new SqlCommand("SELECT * FROM UserTable", connectstring);
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
           
            connectstring.Open();
            
            DA.Fill(DT);
            dgvUsers.DataSource = DT;
            dgvUsers.DataMember = DT.TableName;
            connectstring.Close();
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
            connectstring.Open();

            DA.Fill(DT);
            dgvUsers.DataSource = DT;
            dgvUsers.DataMember = DT.TableName;
            connectstring.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connectstring.Open();
            DA = new SqlDataAdapter("select * from UserTable where Name like '" + textBox1.Text + "%'", connectstring);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dgvUsers.DataSource = DT;
            connectstring.Close();
        }
    }
}
