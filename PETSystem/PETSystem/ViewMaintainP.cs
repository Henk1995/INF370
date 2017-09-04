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
    public partial class ViewMaintainP : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        SqlDataAdapter DA;
        int courseID;
        public ViewMaintainP()
        {
            
            

            InitializeComponent();
        }
        public ViewMaintainP(int value)
        {

            courseID = value;

            InitializeComponent();
        }

        private void ViewMaintainP_Load(object sender, EventArgs e)
        {
            bool duplicate = false; ;
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT InstructorID FROM TrainingCourseLine where TrainingCourseID ='"+ courseID+"'", ConnectString.connectstring);
            SqlDataAdapter DAA = new SqlDataAdapter(Fill);
            DataTable DTA = new DataTable();
            DAA.Fill(DTA);
            ConnectString.connectstring.Open();


            if (DTA.Rows.Count == 0)
            {

                duplicate = false;
                MessageBox.Show("No instructors were found in that training course");
            }
            else if (duplicate)
            {
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                dataGridView1.DataMember = DT.TableName;
            }
            ConnectString.connectstring.Close();
        }

        private void btnMainM_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainingCourseMenu UM = new TrainingCourseMenu();
            UM.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
//            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
//            object fileName = @"C:\Users\Jan-Wilkens\Documents\GitHub\PETSystem\PETSystem";
//            object confirmConversions = Type.Missing;
//            object readOnly = Type.Missing;
//            object addToRecentFiles = Type.Missing;
//            object passwordDoc = Type.Missing;
//            object passwordTemplate = Type.Missing;
//            object revert = Type.Missing;
//            object writepwdoc = Type.Missing;
//            object writepwTemplate = Type.Missing;
//            object format = Type.Missing;
//            object encoding = Type.Missing;
//            object visible = Type.Missing;
//            object openRepair = Type.Missing;
//            object docDirection = Type.Missing;
//            object notEncoding = Type.Missing;
//            object xmlTransform = Type.Missing;
//            Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(

//ref fileName, ref confirmConversions, ref readOnly, ref addToRecentFiles,

//ref passwordDoc, ref passwordTemplate, ref revert, ref writepwdoc,

//ref writepwTemplate, ref format, ref encoding, ref visible, ref openRepair,

//ref docDirection, ref notEncoding, ref xmlTransform);

        }
    }
}
