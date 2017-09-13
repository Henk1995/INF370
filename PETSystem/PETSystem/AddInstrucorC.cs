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
        SqlDataAdapter DA;
        DataTable DT = new DataTable();
        public AddInstrucorC()
        {
            InitializeComponent();
        }

        private void AddInstrucorC_Load(object sender, EventArgs e)
        {
            
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
            MaintainCourses UM = new MaintainCourses();
            UM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
