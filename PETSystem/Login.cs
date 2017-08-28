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
    public partial class LoginF : Form
    {
        bool validU = false;
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";


        public LoginF()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connectstring = new SqlConnection(DBC);
            try
            {
                connectstring.Open();
                MessageBox.Show("Open");
                connectstring.Close();
            }
            catch (Exception X)
            {
                MessageBox.Show("Fuck");
            }
            MainMenuF MainM = new MainMenuF();
            if ( txtPassword.Text == "1")
            {
                MessageBox.Show("Welcome Username", "Login Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Visible = false;
                MainM.ShowDialog();
            }else
            {
                MessageBox.Show("Username and/or password is incorrect.", "Login Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            ChangePassword UM = new ChangePassword();
            UM.ShowDialog();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
