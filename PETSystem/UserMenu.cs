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
        SqlConnection connectstring = new SqlConnection(DBC);
        SqlDataAdapter DA ;
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
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM UserTable", connectstring);
            DA = new SqlDataAdapter(Fill);
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

        }
    }
}
