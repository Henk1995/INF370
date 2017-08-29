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
    public partial class MaintainCourses : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        SqlDataAdapter DA;
        DataTable DTC = new DataTable();
        ErrorHandle EH = new ErrorHandle();
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        bool valid5 = false;
        bool valid6 = false;
        bool valid7 = false;
        public MaintainCourses()
        {
            InitializeComponent();
        }

        private void MaintainCourses_Load(object sender, EventArgs e)
        {
            AddCoursePanel.Visible = false;
            MSMain.Visible = true;
            AddCourseTypeP.Visible = false;
            MaintainTCPanel.Visible = false;
            dgvMaintain.Visible = false;
            btnSave.Visible = false;
        }

        private void addTrainingCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCoursePanel.Visible = true;
            MSMain.Visible = false;
            cmbName.Items.Clear();
            string query = "SELECT TrainingCourseName FROM TrainingCourseType ";
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand cmd = new SqlCommand(query, connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                cmbName.Items.Add(dr["TrainingCourseName"]).ToString();
            }
            connectstring.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(AddCoursePanel.Visible || AddCourseTypeP.Visible || MaintainTCPanel.Visible)
            {
                AddCoursePanel.Visible = false;
                MSMain.Visible = true;
                AddCourseTypeP.Visible = false;
                MaintainTCPanel.Visible = false;
                dgvMaintain.Visible = false;
                btnSave.Visible = false;
            }
            else if(MSMain.Visible)
            {
                this.Visible = false;
                TrainingCourseMenu UM = new TrainingCourseMenu();
                UM.ShowDialog();
            }
        }

        private void addTrainingCourseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseTypeP.Visible = true;
            MSMain.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maintainTrainingCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintainTCPanel.Visible = true;
            dgvMaintain.Visible = true;
            btnSave.Visible = true;
            MSMain.Visible = false;
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM TrainingCourse", connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvMaintain.DataSource = DT;
            dgvMaintain.DataMember = DT.TableName;
            connectstring.Close();
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            valid1 = EH.Checkstring(txtCourseName.Text);
            if(!valid1)
            {
                txtCourseName.BackColor = Color.Red;
                connectstring.Open();
                DA = new SqlDataAdapter("select * from TrainingCourse where CourseName like '" + txtCourseName.Text + "%'", connectstring);

                DA.Fill(DTC);
                dgvMaintain.DataSource = DTC;
                connectstring.Close();
                DataTable DT = new DataTable();
                connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM TrainingCourse", connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvMaintain.DataSource = DT;
                dgvMaintain.DataMember = DT.TableName;
                connectstring.Close();

            }
            else
            {
                txtCourseName.BackColor = Color.White;
                
                connectstring.Open();
                DA = new SqlDataAdapter("select * from TrainingCourse where CourseName like '" + txtCourseName.Text + "%'", connectstring);
                DTC.Clear();
                DA.Fill(DTC);
                dgvMaintain.DataSource = DTC;
                connectstring.Close();
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            //valid2 = EH.CheckInt(txtYear.Text);
            //if (!valid2)
            //{
            //    txtYear.BackColor = Color.Red;
            //}
            //else
            //{
                
            //    txtYear.BackColor = Color.White;
            //   // connectstring.Open();
            //   // DA = new SqlDataAdapter("select * from TrainingCourse where TrainingCourseDate like '" + txtYear.Text + "%'", connectstring);
            //   //DataTable DT = new DataTable();
            //   // DA.Fill(DT);
            //   // dgvMaintain.DataSource = DT;
            //   // connectstring.Close();
            //}
        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.CheckDate(txtStartDate.Text);
            if (!valid3)
            {
                txtStartDate.BackColor = Color.Red;
            }
            else
            {
                txtStartDate.BackColor = Color.White;
            }
        }

        private void txtVenue_TextChanged(object sender, EventArgs e)
        {
            valid4 = EH.Checkstring(txtVenue.Text);
            if (!valid4)
            {
                txtVenue.BackColor = Color.Red;
            }
            else
            {
                txtVenue.BackColor = Color.White;
            }
        }

        private void txtNCDName_TextChanged(object sender, EventArgs e)
        {
            valid5 = EH.Checkstring(txtNCDName.Text);
            if (!valid5)
            {
                txtNCDName.BackColor = Color.Red;
            }
            else
            {
                txtNCDName.BackColor = Color.White;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmd = new SqlCommandBuilder(DA);
            
            DA.Update(DTC);
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connectstring.Close();
            string Query1 = "SELECT * FROM TrainingCourseType WHERE TrainingCourseName ='" + this.txtNCDName.Text + "';";
            SqlCommand MyCommand = new SqlCommand(Query1, connectstring);
            
            SqlDataAdapter DA1 = new SqlDataAdapter(MyCommand);
            DataTable DT1 = new DataTable();
            DA1.Fill(DT1);
            connectstring.Open();
           

            if (DT1.Rows.Count > 0)
            {
                valid5 = false;
            }
            if(valid5)
            {
                string Query = "INSERT INTO TrainingCourseType(TrainingCourseName) values('" + this.txtNCDName.Text +"');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  

                //This is command class which will handle the query and connection object.  
                SqlCommand MyCommand2 = new SqlCommand(Query, connectstring);
                SqlDataReader MyReader2;
              
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                connectstring.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CTID=0;
            bool duplicate = false;
            string Query1 = "SELECT * FROM TrainingCourse WHERE CourseName ='" + this.txtCourseName.Text + "'AND TrainingCourseDate='" + this.txtStartDate.Text + "';";
            SqlCommand MyCommand = new SqlCommand(Query1, connectstring);
            SqlDataReader MyReader;
            SqlDataAdapter DA = new SqlDataAdapter(MyCommand);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            connectstring.Open();
            MyReader = MyCommand.ExecuteReader();

            if (DT.Rows.Count == 0)
            {

                duplicate = false;
                
            }else
            {
                duplicate = true;
            }
            connectstring.Close();
            if(!duplicate)
            {
                string query = "SELECT TrainingCourseTypeID FROM TrainingCourseType WHERE TrainingCourseName='" + cmbName.Text + "'";
                SqlCommand MyCommand1 = new SqlCommand(query, connectstring);
                SqlDataReader MyReader1;
                connectstring.Open();
                MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader1.Read())
                {
                    CTID = Convert.ToInt32(MyReader1["TrainingCourseTypeID"]);
                }
                connectstring.Close();
                string Query = "INSERT INTO TrainingCourse(CourseName,Duration,TrainingCourseDate,TrainingCourseTypeID) values('" + this.cmbName.Text + "','" + this.numericUpDown1.Text + "','" + this.txtStartDate.Text + "','"+ CTID + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  

                //This is command class which will handle the query and connection object.  
                SqlCommand MyCommand2 = new SqlCommand(Query, connectstring);
                SqlDataReader MyReader2;
                connectstring.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                connectstring.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
