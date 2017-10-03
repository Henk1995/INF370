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
            txtUsername.Text = "e.g. User1";
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string un = txtUsername.Text;
            string pw = txtPassword.Text;


            if (valid3 && valid4)
            {
                ConnectString.connectstring.Close();
               string Query1 = "SELECT * FROM UserTable WHERE UserName ='" + this.txtUsername.Text + "'AND UserPassword='" + Encrypt(this.txtPassword.Text) + "';";
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
                    // Kry user ID vir Orders
                    SqlConnection connection2 = new SqlConnection(ConnectString.DBC);
                    connection2.Open();
                    SqlCommand cmdd2 = connection2.CreateCommand();
                    cmdd2.CommandText = "Select UserID FROM UserTable WHERE UserName ='" + txtUsername.Text + "'";
                    ConnectString.UserIDforOrders = ((int)cmdd2.ExecuteScalar());
                    //MessageBox.Show(ConnectString.UserIDforOrders.ToString());

                    connection2.Close();
                    ConnectString.connectstring.Close();
                  //  Check first login and make sure that form will exit correctly from here
                    if (ConnectString.firstLogin == true)
                    {
                        ConnectString.firstLogin = false;
                        validU = true;
                        this.Visible = false;
                        MainMenuF UM = new MainMenuF();
                        UM.ShowDialog();
                    }
                    else
                    {
                        this.Close();
                        this.Dispose(true);
                        MainMenuF FL = new MainMenuF();
                        FL.ShowDialog();
                    }


                }
                
            }
            else
            {
                MessageBox.Show("Invalid username and/or Password");
            }


            // Ek steel gou die user wat gesignin het se ID. ;D
            //var GetUserID = (from X in db.UserTables where X.UserName.Contains(un) && X.UserPassword.Contains(pw) select X.UserID).FirstOrDefault();
            //UserIDthatLoggedIn = GetUserID;

            //Ek kort die UserID wat ingelog het



            //UserIDthatLoggedIn = Convert.ToInt32(USer);

            this.Visible = false;
            MainMenuF UM1 = new MainMenuF();
            UM1.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            ChangePassword UM = new ChangePassword();
            UM.ShowDialog();
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            bool validSQl = EH.checkForSQLInjection(txtUsername.Text);
            
                valid3 = validSQl;
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            ForgotPassword UM = new ForgotPassword();
            UM.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
		txtPassword.PasswordChar = '*';
            bool validSQl = EH.checkForSQLInjection(txtPassword.Text);
            
            
                valid4 = validSQl;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        ToolTip TooltipUsername = new ToolTip();
        ToolTip TooltipPassword = new ToolTip();
        ToolTip TooltipButtonLogin = new ToolTip();
        ToolTip TooltipButtonExit = new ToolTip();
        ToolTip TooltipNewPassword = new ToolTip();
        ToolTip TooltipForgotPassword = new ToolTip();

        private void LoginF_Load(object sender, EventArgs e)
        {//Tooltips
            TooltipUsername.ShowAlways = true;
            TooltipUsername.ToolTipTitle = "Username.";
            TooltipUsername.UseFading = true;
            TooltipUsername.UseAnimation = true;
            TooltipUsername.IsBalloon = true;         
            TooltipUsername.SetToolTip(txtUsername, "Please enter your Username here.");
            TooltipPassword.ShowAlways = true;
            TooltipPassword.ToolTipTitle = "Password.";
            TooltipPassword.UseFading = true;
            TooltipPassword.UseAnimation = true;
            TooltipPassword.IsBalloon = true;
            TooltipPassword.SetToolTip(txtPassword, "Please enter your Password here.");
            TooltipButtonLogin.ShowAlways = true;
            TooltipButtonLogin.ToolTipTitle = "Login.";
            TooltipButtonLogin.UseFading = true;
            TooltipButtonLogin.UseAnimation = true;
            TooltipButtonLogin.IsBalloon = true;
            TooltipButtonLogin.SetToolTip(btnLogin, "Press to log into system after details\nhave been entered above.");
            TooltipButtonExit.ShowAlways = true;
            TooltipButtonExit.ToolTipTitle = "Exit.";
            TooltipButtonExit.UseFading = true;
            TooltipButtonExit.UseAnimation = true;
            TooltipButtonExit.IsBalloon = true;
            TooltipButtonExit.SetToolTip(button1, "Press to exit the program.");
            TooltipNewPassword.ShowAlways = true;
            TooltipNewPassword.ToolTipTitle = "Change Password.";
            TooltipNewPassword.UseFading = true;
            TooltipNewPassword.UseAnimation = true;
            TooltipNewPassword.IsBalloon = true;
            TooltipNewPassword.SetToolTip(linkLabel1, "Press to change your password.");
            TooltipForgotPassword.ShowAlways = true;
            TooltipForgotPassword.ToolTipTitle = "Forgot Password.";
            TooltipForgotPassword.UseFading = true;
            TooltipForgotPassword.UseAnimation = true;
            TooltipForgotPassword.IsBalloon = true;
            TooltipForgotPassword.SetToolTip(linkLabel2, "Press if you have forgotten your password.");
            // first login
           // ConnectString.firstLogin = true;
            //  get Timer Time
            SqlConnection TimeConnection = new SqlConnection(ConnectString.DBC);
            TimeConnection.Open();
            SqlCommand TimeCommand = TimeConnection.CreateCommand();
            TimeCommand.CommandText = "Select Time FROM TimerTabel Where ID = 1";
            ConnectString.TimerTime = ((int)TimeCommand.ExecuteScalar());
            //MessageBox.Show(ConnectString.TimerTime.ToString());

            TimeConnection.Close();
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        bool firstClick = true;
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                txtUsername.Text = "e.g User1";
                firstClick = true;
            }
        }
        
       
        private void txtUsername_Click(object sender, EventArgs e)
        {
            
            if (firstClick == true)
            {
                txtUsername.Text = "";
                firstClick = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
