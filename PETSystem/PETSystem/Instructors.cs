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
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            ConnectString.connectstring.Close();

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

                        SqlCommand MyCommand2 = new SqlCommand(Query, ConnectString.connectstring);
                        SqlDataReader MyReader2;
                        ConnectString.connectstring.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Deleted");
                        while (MyReader2.Read())
                        {
                        }
                        ConnectString.connectstring.Close();
                   
                    DataTable DT = new DataTable();
                    ConnectString.connectstring.Open();
                    SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
                    DA = new SqlDataAdapter(Fill);
                    DA.Fill(DT);
                    dgvInstructor.DataSource = DT;
                    dgvInstructor.DataMember = DT.TableName;
                    ConnectString.connectstring.Close();
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
