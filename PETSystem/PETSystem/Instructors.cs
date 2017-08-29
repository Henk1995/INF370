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
    public partial class Instructors : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        SqlDataAdapter DA;
        public Instructors()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenuF UM = new MainMenuF();
            UM.ShowDialog();
        }

        private void Instructors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNF370DataSet.Instructor' table. You can move, or remove it, as needed.
            //  this.instructorTableAdapter.Fill(this.iNF370DataSet.Instructor);
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            connectstring.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreateInstructor UM = new CreateInstructor();
            UM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InstructorTR UM = new InstructorTR();
            UM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ViewInstructor UM = new ViewInstructor();
            UM.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateInstructor UM = new UpdateInstructor();
            UM.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //DeleteInstructor UM = new DeleteInstructor();
            //UM.ShowDialog(); this.Visible = false;
            
                
                    if (dgvInstructor.SelectedRows.Count > 0)
                    {
                        int selectedIndex = dgvInstructor.SelectedRows[0].Index;

                        // gets the RowID from the first column in the grid
                        int rowID = int.Parse(dgvInstructor[0, selectedIndex].Value.ToString());


                        MessageBox.Show("Are you sure you want to delete this instructor?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        string Query = "DELETE FROM Instructor WHERE InstructorID='" + rowID + "';";

                        SqlCommand MyCommand2 = new SqlCommand(Query, connectstring);
                        SqlDataReader MyReader2;
                        connectstring.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Deleted");
                        while (MyReader2.Read())
                        {
                        }
                        connectstring.Close();
                   
                    DataTable DT = new DataTable();
                    connectstring.Open();
                    SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", connectstring);
                    DA = new SqlDataAdapter(Fill);
                    DA.Fill(DT);
                    dgvInstructor.DataSource = DT;
                    dgvInstructor.DataMember = DT.TableName;
                    connectstring.Close();
            }
        
                else
                {
                    MessageBox.Show("Please select the row that you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CalculateRoyalties UM = new CalculateRoyalties();
            UM.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SearchInstructor UM = new SearchInstructor();
            UM.ShowDialog();
        }

        private void dgvInstructor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
