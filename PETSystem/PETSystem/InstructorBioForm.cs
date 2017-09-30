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
    }
}
