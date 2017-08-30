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
       

        public LoginF()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            string Query1 = "SELECT * FROM UserTable WHERE UserName ='" + this.txtUsername.Text + "'AND UserPassword='" + this.txtPassword.Text + "';";
            SqlCommand MyCommand = new SqlCommand(Query1, ConnectString.connectstring);
            SqlDataReader MyReader;
            SqlDataAdapter DA = new SqlDataAdapter(MyCommand);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            ConnectString.connectstring.Open();
            MyReader = MyCommand.ExecuteReader();

            if (DT.Rows.Count == 0)
            {

                validU = false;
                MessageBox.Show("Invalid username and/or Password");
            }
            else
            {
                validU = true;
            }

            ConnectString.connectstring.Close();
            if (validU)
            {
                this.Visible = false;
                MainMenuF UM = new MainMenuF();
                UM.ShowDialog();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            ForgotPassword UM = new ForgotPassword();
            UM.ShowDialog();
        }
    }
}
