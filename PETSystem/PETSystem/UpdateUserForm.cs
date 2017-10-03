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
        DateTime endOfTime;
        Timer t;
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {

            //Tool Tips

            //Name
            ToolTip TTName = new ToolTip();
            TTName.ToolTipTitle = "Name";
            TTName.UseFading = true;
            TTName.UseAnimation = true;
            TTName.IsBalloon = true;
            TTName.SetToolTip(txtName, "Enter the user's Name here.");
            //Surname
            ToolTip TTSur = new ToolTip();
            TTSur.ToolTipTitle = "Surname";
            TTSur.UseFading = true;
            TTSur.UseAnimation = true;
            TTSur.IsBalloon = true;
            TTSur.SetToolTip(txtSurname, "Enter the user's Surname here.");
            //Email
            ToolTip TTEmail = new ToolTip();
            TTEmail.ToolTipTitle = "E-mail";
            TTEmail.UseFading = true;
            TTEmail.UseAnimation = true;
            TTEmail.IsBalloon = true;
            TTEmail.SetToolTip(txtEmail, "Enter the user's E-mail here.");
            //USername
            ToolTip TTUSERNAME = new ToolTip();
            TTUSERNAME.ToolTipTitle = "Username";
            TTUSERNAME.UseFading = true;
            TTUSERNAME.UseAnimation = true;
            TTUSERNAME.IsBalloon = true;
            TTUSERNAME.SetToolTip(txtUsername, "Enter the user's Username here.");
            //Password
            ToolTip TTPASS = new ToolTip();
            TTPASS.ToolTipTitle = "Password";
            TTPASS.UseFading = true;
            TTPASS.UseAnimation = true;
            TTPASS.IsBalloon = true;
            TTPASS.SetToolTip(txtPassword, "Enter the user's Password here.");
           
            //Priviledge
            ToolTip TTPRIV = new ToolTip();
            TTPRIV.ToolTipTitle = "Priviledge";
            TTPRIV.UseFading = true;
            TTPRIV.UseAnimation = true;
            TTPRIV.IsBalloon = true;
            TTPRIV.SetToolTip(cbPriviledge, "Enter the user's Priviledge here.");
            //Update
            ToolTip TTADD = new ToolTip();
            TTADD.ToolTipTitle = "Add User";
            TTADD.UseFading = true;
            TTADD.UseAnimation = true;
            TTADD.IsBalloon = true;
            TTADD.SetToolTip(button2, "Click here once all the information above\nhas been provided to Update the user.");
            //Back
            ToolTip TTBACK = new ToolTip();
            TTBACK.ToolTipTitle = "Back";
            TTBACK.UseFading = true;
            TTBACK.UseAnimation = true;
            TTBACK.IsBalloon = true;
            TTBACK.SetToolTip(button1, "Click here to return to the User menu.");


            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
             t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

         //   label1.Text = "User ID: "+ConnectString.UserID;
            txtName.Text = ConnectString.Name;
            txtSurname.Text = ConnectString.Surname;
            txtUsername.Text = ConnectString.UserName;
            txtPassword.Text = ConnectString.Password;
            txtEmail.Text = ConnectString.Email;

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
        int stop = 0;
        int ticks = ConnectString.TimerTime * 60;

        private void timer1_Tick(object sender, EventArgs e)
        {

            stop++;

            if (stop > ticks)
            {
                t.Enabled = false;
                this.Close();
                this.Dispose(true);
                LoginF myform = new LoginF();
                myform.ShowDialog();
            }
            else {
                TimeSpan ts = endOfTime.Subtract(DateTime.Now);
                lblTimer.Text = ts.ToString();
            }
        }

        private void UpdateUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
