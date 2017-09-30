using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PETSystem
{
    public partial class AddInstrucorC : Form
    {
        DateTime endOfTime;
        Timer t;
        SqlDataAdapter DA;
        DataTable DT = new DataTable();
        public AddInstrucorC()
        {
            InitializeComponent();
        }

        private void AddInstrucorC_Load(object sender, EventArgs e)
        {

            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            textBox1.Visible = false;
            SqlCommand Fill = new SqlCommand("SELECT * FROM TrainingCourseType", ConnectString.connectstring);
            SqlDataAdapter DA = new SqlDataAdapter(Fill);
            ConnectString.connectstring.Open();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            dataGridView1.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            MaintainCourses UM = new MaintainCourses();
            UM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    ConnectString.CourseStringID = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                    ConnectString.CourseName = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;

                    //Display form
                    UpdateTrainingCourseTypeForm myform = new UpdateTrainingCourseTypeForm();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string Query = "Delete TrainingCourseType Where TrainingCourseTypeID = '" + dataGridView1.SelectedRows[0].Cells[0].Value + "'";
                DialogResult answer = MessageBox.Show("Are you sure you want to Delete this Training Course Type?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (answer == DialogResult.Yes)
                {
                    SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                    SqlDataReader MyReader3;
                    ConnectString.connectstring.Open();
                    MyReader3 = MyCommand3.ExecuteReader();
                    MessageBox.Show("Training Course Type successfully removed");
                    ConnectString.connectstring.Close();
                    //Refresh DGV
                    textBox1.Text = "a";
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Training Course type was not deleted");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to Delete");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable DT2 = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill2 = new SqlCommand("SELECT * from TrainingCourseType", ConnectString.connectstring);
            SqlDataAdapter DA2 = new SqlDataAdapter(Fill2);
            DA2.Fill(DT2);
            dataGridView1.DataSource = DT2;
            dataGridView1.DataMember = DT2.TableName;
            textBox1.BackColor = Color.White;
            ConnectString.connectstring.Close();
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

        private void AddInstrucorC_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
