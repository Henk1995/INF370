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
      


        
        DateTime endOfTime;
        Timer t;
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

            //  get Timer Time
            SqlConnection TimeConnection = new SqlConnection(ConnectString.DBC);
            TimeConnection.Open();
            SqlCommand TimeCommand = TimeConnection.CreateCommand();
            TimeCommand.CommandText = "Select Time FROM TimerTabel Where ID = 1";
            ConnectString.TimerTime = ((int)TimeCommand.ExecuteScalar());
            //MessageBox.Show(ConnectString.TimerTime.ToString());

            TimeConnection.Close();


            // TODO: This line of code loads data into the 'iNF370DataSet.UserTable' table. You can move, or remove it, as needed.
            // this.userTableTableAdapter.Fill(this.iNF370DataSet.UserTable);

            ConnectString.connectstring.Open();
            
            DA.Fill(DT);
            dgvUsers.DataSource = DT;
            dgvUsers.DataMember = DT.TableName;
            ConnectString.connectstring.Close();


            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);


           
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
            //Load values for update
            try
            {
                if (dgvUsers.SelectedRows.Count > 0)
                {
                    ConnectString.UserID = dgvUsers.SelectedRows[0].Cells[0].Value + string.Empty;
                    ConnectString.Name = dgvUsers.SelectedRows[0].Cells[1].Value + string.Empty;
                    ConnectString.Surname = dgvUsers.SelectedRows[0].Cells[2].Value + string.Empty;
                    ConnectString.UserName = dgvUsers.SelectedRows[0].Cells[3].Value + string.Empty;
                    ConnectString.Password = dgvUsers.SelectedRows[0].Cells[4].Value + string.Empty;
                    ConnectString.Email = dgvUsers.SelectedRows[0].Cells[5].Value + string.Empty;
                    ConnectString.Priv = dgvUsers.SelectedRows[0].Cells[6].Value + string.Empty;
                    //Display form
                    UpdateUserForm myform = new UpdateUserForm();
                    this.Close();
                    this.Dispose(true);
                    myform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a row to update");
                }
            }
            catch
            {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                string Query = "Delete UserTable Where UserID = '" + dgvUsers.SelectedRows[0].Cells[0].Value + "'";
                DialogResult answer = MessageBox.Show("Are you sure you want to Delete this User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (answer == DialogResult.Yes)
                {
                    SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                    SqlDataReader MyReader3;
                    ConnectString.connectstring.Open();
                    MyReader3 = MyCommand3.ExecuteReader();
                    MessageBox.Show("User successfully updated");
                    ConnectString.connectstring.Close();
                    //Refresh DGV
                    textBox1.Text = "a";
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("User was not deleted");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to Delete");
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int stop =0;
        int ticks = ConnectString.TimerTime*60;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            stop++;
            
            if ( stop > ticks)
            {
                t.Enabled = false;
                this.Close();
                this.Dispose(true);
                LoginF myform = new LoginF();
                myform.ShowDialog();
            }
            else {
                TimeSpan ts = endOfTime.Subtract(DateTime.Now);
                label4.Text = ts.ToString();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void setLogoutTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            UpdateTimerTime myform = new UpdateTimerTime();
            myform.ShowDialog();
            
        }

        private void UserMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
