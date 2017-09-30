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
    public partial class InstructorBioForm : Form
    {
        DateTime endOfTime;
        Timer t;
        public InstructorBioForm()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private void loadpicture()
        {
            cn.ConnectionString = ConnectString.DBC;
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = "Select Data From PictureTable Where Filename ='" + ConnectString.InstructorID + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cbd = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            byte[] ap = (byte[])(ds.Tables[0].Rows[0]["Data"]);
            MemoryStream ms = new MemoryStream(ap);
            pictureBox1.Image = Image.FromStream(ms);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ms.Close();
        }

        private void InstructorBioForm_Load(object sender, EventArgs e)
        {
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            label1.Text = " ID: "+ ConnectString.InstructorID +"\nTitle: "+ ConnectString.InstructorTitle + "\nName: " + ConnectString.InstructorName + "\nSurname: " + ConnectString.InstructorSurname + "\nPhone Number: " + ConnectString.InstructorPhoneNumber +"\nE-Mail: "+ConnectString.instructorEmail+"\nGender: " + ConnectString.InstructorGender;
            loadpicture();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Instructors myform = new Instructors();
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

        private void InstructorBioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
