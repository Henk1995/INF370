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
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
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
            this.Close();
            CreateInstructor UM = new CreateInstructor();
            UM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            InstructorTR UM = new InstructorTR();
            UM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewInstructor UM = new ViewInstructor();
            UM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdateInstructor UM = new UpdateInstructor();
            UM.Show();
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


                DialogResult answer = MessageBox.Show("Are you sure you want to delete this instructor from the system?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (answer == DialogResult.Yes)
                {
                    string Query = "DELETE FROM Instructor WHERE InstructorID='" + rowID + "';";

                    SqlCommand MyCommand2 = new SqlCommand(Query, ConnectString.connectstring);
                    SqlDataReader MyReader2;
                    ConnectString.connectstring.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Instructor was deleted from the system.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    while (MyReader2.Read())
                    {
                    }
                    ConnectString.connectstring.Close();
                }
                else
                {
                    MessageBox.Show("Instructor was not deleted from the system.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                   
                }
                DataTable DT1 = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT1);
                dgvInstructor.DataSource = DT1;
                dgvInstructor.DataMember = DT1.TableName;
                ConnectString.connectstring.Close();
            }
        
                else
                {
                    MessageBox.Show("Please select the row that you want to delete", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            CalculateRoyalties UM = new CalculateRoyalties();
            UM.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchInstructor UM = new SearchInstructor();
            UM.Show();
        }

        private void dgvInstructor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
