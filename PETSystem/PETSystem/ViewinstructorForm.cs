using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;
using System.Data.SqlClient;


namespace PETSystem
{
    public partial class ViewinstructorForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlParameter picture;
        public ViewinstructorForm()
        {
            InitializeComponent();
        }
        private void open()
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "C:/Picture/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(f.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label1.Text = f.SafeFileName.ToString();
                }
            }
            catch { }
        }
        private void savepicture()
        {

            // Kry Count van Order Line
            int CountOfpics;
            SqlConnection cnnCount = new SqlConnection(ConnectString.DBC);
            cnnCount.Open();
            SqlCommand cmdCount = cnnCount.CreateCommand();
            cmdCount.CommandText = "Select COUNT(id) from PictureTable Where FileName = '" + ConnectString.InstructorID + "'";
            CountOfpics = ((int)cmdCount.ExecuteScalar());


            cnnCount.Close();
            if (CountOfpics > 0)
            {
                string Queryyz = "Delete  From PictureTable Where FileName ='" + ConnectString.InstructorID + "'";
                //This is  MySqlConnection here i have created the object and pass my connection string.  


                SqlCommand MyCommandz = new SqlCommand(Queryyz, ConnectString.connectstring);
                SqlDataReader MyReaderz;
                ConnectString.connectstring.Open();
                MyReaderz = MyCommandz.ExecuteReader();
                //  MessageBox.Show("Stock quantity has been updated.");
                ConnectString.connectstring.Close();
            }

            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms,pictureBox1.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@picture",a);
                cmd.CommandText = "Insert Into PictureTable (Filename,Data) values('"+ConnectString.InstructorID+"',@picture)";
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                label1.Text = "";
                pictureBox1.Image = null;
                MessageBox.Show("Image Saved.\nReturning to Instructors Menu.","Notification");
                this.Close();
                this.Dispose(true);
                Instructors myform = new Instructors();
                myform.ShowDialog();
            }
        }
        private void ViewinstructorForm_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = ConnectString.DBC;
            cmd.Connection = cn;
            label1.Text = "";
            picture = new SqlParameter("@picture", SqlDbType.Image);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            savepicture();
        }
        private void loadpicture()
        {
            cn.Open();
            cmd.CommandText = "Select Data From PictureTable Where Filename ='" + ConnectString.InstructorID + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cbd = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            byte[] ap = (byte[])(ds.Tables[0].Rows[0]["Data"]);
            MemoryStream ms = new MemoryStream(ap);
          //  pictureBox2.Image = Image.FromStream(ms);
         //   pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            ms.Close();
        }
       
    }
}
