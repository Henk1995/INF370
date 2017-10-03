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
    public partial class ChangePassword : Form
    {
        
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        ErrorHandle EH = new ErrorHandle();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            //textbox USername
            

            ToolTip textboxTooltip = new ToolTip();
            textboxTooltip.ToolTipTitle = "Username";
            textboxTooltip.UseFading = true;
            textboxTooltip.UseAnimation = true;
            textboxTooltip.IsBalloon = true;
            textboxTooltip.SetToolTip(txtUserName, "Enter your Username here.");
            //oldpass
            ToolTip TTold = new ToolTip();
            TTold.ToolTipTitle = "Old Password";
            TTold.UseFading = true;
            TTold.UseAnimation = true;
            TTold.IsBalloon = true;
            TTold.SetToolTip(txtOldPass, "Enter your current password here.");
            //newpass
            ToolTip TTNEW = new ToolTip();
            TTNEW.ToolTipTitle = "New Password";
            TTNEW.UseFading = true;
            TTNEW.UseAnimation = true;
            TTNEW.IsBalloon = true;
            TTNEW.SetToolTip(txtNewPass, "Enter your new password here.");
            //re-typenewpass
            ToolTip TTRE = new ToolTip();
            TTRE.ToolTipTitle = "Re-Type New Password";
            TTRE.UseFading = true;
            TTRE.UseAnimation = true;
            TTRE.IsBalloon = true;
            TTRE.SetToolTip(txtNewRePass, "Enter your new password here again.");
            //btnback
            ToolTip TTback = new ToolTip();
            TTback.ToolTipTitle = "Back";
            TTback.UseFading = true;
            TTback.UseAnimation = true;
            TTback.IsBalloon = true;
            TTback.SetToolTip(btnChangePass, "Click here to return to the Login screen.");
            //btnchange
            ToolTip TtSub = new ToolTip();
            TtSub.ToolTipTitle = "Change Password";
            TtSub.UseFading = true;
            TtSub.UseAnimation = true;
            TtSub.IsBalloon = true;
            TtSub.SetToolTip(btnBack, "Click here to Submit password changes.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            LoginF UM = new LoginF();
            UM.ShowDialog();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
		
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
		
        }

        private void txtNewRePass_TextChanged(object sender, EventArgs e)
        {
		
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string Query1 = "SELECT * FROM UserTable WHERE UserName ='" + this.txtUserName.Text + "'AND UserPassword='"+this.txtOldPass.Text+"';";
            SqlCommand MyCommand = new SqlCommand(Query1, ConnectString.connectstring);
            SqlDataReader MyReader;
            SqlDataAdapter DA = new SqlDataAdapter(MyCommand);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            ConnectString.connectstring.Open();
            MyReader = MyCommand.ExecuteReader();
            
            if (DT.Rows.Count == 0)
                {
                   
                    valid1 = false;
                valid2 = false;
                }

            ConnectString.connectstring.Close();
            if (valid1 & valid2 & valid3 & valid4)
            {
                DialogResult result = MessageBox.Show("Change password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    string Query = "UPDATE UserTable SET UserPassword ='" + this.txtNewPass.Text + "' WHERE UserName ='" + this.txtUserName.Text + "';";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  

                    SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                    SqlDataReader MyReader3;
                    ConnectString.connectstring.Open();
                    MyReader3 = MyCommand3.ExecuteReader();

                    while (MyReader3.Read())
                    {
                    }
                    ConnectString.connectstring.Close();//Connection closed here
                    MessageBox.Show("Password succesfully changed.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }else
                {
                    MessageBox.Show("Password was not changed.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                if (!valid1&&!valid2)
                {
                    MessageBox.Show("Username and/or password is incorrect please resubmit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if (!valid2)
                {
                    MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNewPass.Text != txtNewRePass.Text) 
                {
                    MessageBox.Show("New passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show("Information invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            valid1 = EH.CheckstringNum(txtUserName.Text);
            bool validSQl = EH.checkForSQLInjection(txtUserName.Text);
            if (valid1)
            {
                valid1 = validSQl;
            }
            if (!valid1)
            {
                txtUserName.BackColor = Color.Red;

            }
            else
            {
                txtUserName.BackColor = Color.White;
            }
        }

        private void txtOldPass_Leave(object sender, EventArgs e)
        {
            txtOldPass.PasswordChar = '*';
            valid2 = EH.CheckstringNum(txtOldPass.Text);
            bool validSQl = EH.checkForSQLInjection(txtOldPass.Text);
            if (valid2)
            {
                valid2 = validSQl;
            }
            if (!valid2)
            {
                txtOldPass.BackColor = Color.Red;

            }
            else
            {
                txtOldPass.BackColor = Color.White;
            }
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            txtNewPass.PasswordChar = '*';
            valid3 = EH.CheckstringNum(txtNewPass.Text);
            bool validSQl = EH.checkForSQLInjection(txtNewPass.Text);
            if (valid3)
            {
                valid3 = validSQl;
            }
            if (!valid3)
            {
                txtNewPass.BackColor = Color.Red;

            }
            else
            {
                txtNewPass.BackColor = Color.White;
            }
        }

        private void txtNewRePass_Leave(object sender, EventArgs e)
        {
            txtNewRePass.PasswordChar = '*';
            valid4 = EH.CheckstringNum(txtNewRePass.Text);
            if ((!valid4) || (txtNewPass.Text != txtNewRePass.Text))
            {
                valid4 = false;
                txtNewRePass.BackColor = Color.Red;

            }
            else
            {
                txtNewRePass.BackColor = Color.White;
            }
        }
    }
}
