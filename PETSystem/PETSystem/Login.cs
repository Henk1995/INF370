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
        //LINQ Connection string
        public static int UserIDthatLoggedIn;
        PET_DBDataContext db = new PET_DBDataContext();

        bool validU = false;
        bool valid3 = false;
        bool valid4 = false;
        ErrorHandle EH = new ErrorHandle();
        public LoginF()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string un = txtUsername.Text;
            string pw = txtPassword.Text;

            if (valid3 && valid4)
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
            }
            else
            {
                MessageBox.Show("Invalid username and/or Password");
            }
            if (validU)
            {

                //    // Ek steel gou die user wat gesignin het se ID. ;D
                //    var GetUserID = (from X in db.UserTables where X.UserName.Contains(un) && X.UserPassword.Contains(pw) select X.UserID).FirstOrDefault();
                //    UserIDthatLoggedIn = GetUserID;

                this.Visible = false;
                MainMenuF UM = new MainMenuF();
                UM.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ChangePassword UM = new ChangePassword();
            UM.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            bool validSQl = EH.checkForSQLInjection(txtUsername.Text);
            
                valid3 = validSQl;
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ForgotPassword UM = new ForgotPassword();
            UM.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            bool validSQl = EH.checkForSQLInjection(txtPassword.Text);
            
            
                valid4 = validSQl;
            
        }
    }
}
