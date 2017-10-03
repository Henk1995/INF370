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
    public partial class AddResultMessagebox : Form
    {
        int DGVValue,REEsultValue;
        public AddResultMessagebox()
        {
            
            InitializeComponent();
        }

      




        private void AddResultMessagebox_Load(object sender, EventArgs e)
        {
            //Tooltips
            //Passed
            ToolTip TTPASS = new ToolTip();
            TTPASS.ToolTipTitle = "Pass";
            TTPASS.UseFading = true;
            TTPASS.UseAnimation = true;
            TTPASS.IsBalloon = true;
            TTPASS.SetToolTip(button1, "Click here to Pass the selected instructor.");
            //Failed
            ToolTip TtFail = new ToolTip();
            TtFail.ToolTipTitle = "Fail";
            TtFail.UseFading = true;
            TtFail.UseAnimation = true;
            TtFail.IsBalloon = true;
            TtFail.SetToolTip(button2, "Click here to Fail the selected instructor.");
            //Back
            ToolTip TtCancel = new ToolTip();
            TtFail.ToolTipTitle = "Cancel";
            TtFail.UseFading = true;
            TtFail.UseAnimation = true;
            TtFail.IsBalloon = true;
            TtFail.SetToolTip(button3, "Click here to cancel and return back to the Result page.");

            label2.Text = "Please indicate if the selected instructor\npassed or failed the course";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                DialogResult result = MessageBox.Show("Add Result?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    string Query = "UPDATE TrainingCourseLine SET TrainingCourseLine.ResultID = 2 WHERE TrainingCourseLine.InstructorID ='" + ConnectString.InstructorID + "' AND TrainingCourseLine.TrainingCourseID = '" + ConnectString.TrainingCourseIDForResult + "';";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  

                    SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                    SqlDataReader MyReader3;
                    ConnectString.connectstring.Open();
                    MyReader3 = MyCommand3.ExecuteReader();

                    while (MyReader3.Read())
                    {
                    }
                    ConnectString.connectstring.Close();//Connection closed here
                    MessageBox.Show("Result Added.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Result Not Added.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Please Select a row to add a result to");
                ConnectString.connectstring.Close();
            }
            this.Close();
            this.Dispose(true);
            int value = ConnectString.CourseID;
            AddResult myform = new AddResult(value);
            myform.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            AddResult myform = new AddResult();
            myform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            try
            {
                

                    DialogResult result = MessageBox.Show("Add Result?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        string Query = "UPDATE TrainingCourseLine SET TrainingCourseLine.ResultID = 1 WHERE TrainingCourseLine.InstructorID ='" + ConnectString.InstructorID + "' AND TrainingCourseLine.TrainingCourseID = '"+ConnectString.TrainingCourseIDForResult+"';";
                        //This is  MySqlConnection here i have created the object and pass my connection string.  

                        SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                        SqlDataReader MyReader3;
                        ConnectString.connectstring.Open();
                        MyReader3 = MyCommand3.ExecuteReader();

                        while (MyReader3.Read())
                        {
                        }
                        ConnectString.connectstring.Close();//Connection closed here
                        MessageBox.Show("Result Added.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                   
                    else
                    {
                        MessageBox.Show("Result Not Added.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                


            }
            catch
            {
                MessageBox.Show("Please Select a row to add a result to");
                ConnectString.connectstring.Close();
            }
            this.Close();
            this.Dispose(true);
            int value = ConnectString.CourseID;
            AddResult myform = new AddResult(value);
            myform.ShowDialog();
            
        }
    }
}
