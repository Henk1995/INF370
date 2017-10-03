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
    public partial class UpdateTrainingCourseTypeForm : Form
    {
        public UpdateTrainingCourseTypeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            AddInstrucorC myform = new AddInstrucorC();
            myform.ShowDialog();
        }

        private void UpdateTrainingCourseTypeForm_Load(object sender, EventArgs e)
        {
            txtName.Text = ConnectString.CourseName;
            //Course Type
            ToolTip TTType = new ToolTip();
            TTType.ToolTipTitle = "Type";
            TTType.UseFading = true;
            TTType.UseAnimation = true;
            TTType.IsBalloon = true;
            TTType.SetToolTip(txtName, "Enter the updated Course type here.");
            //Update
            ToolTip TTUPDATE = new ToolTip();
            TTUPDATE.ToolTipTitle = "Update";
            TTUPDATE.UseFading = true;
            TTUPDATE.UseAnimation = true;
            TTUPDATE.IsBalloon = true;
            TTUPDATE.SetToolTip(button1, "Click here to update the course type.");
            //Back
            ToolTip TTbAck = new ToolTip();
            TTbAck.ToolTipTitle = "Back";
            TTbAck.UseFading = true;
            TTbAck.UseAnimation = true;
            TTbAck.IsBalloon = true;
            TTbAck.SetToolTip(button2, "Click here to return to previous screen.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               int ID = Convert.ToInt32(ConnectString.CourseStringID);
                    string Query = "UPDATE TrainingCourseType SET TrainingCourseName ='" + this.txtName.Text + "' WHERE TrainingCourseTypeID =" + ID + ";";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    DialogResult answer = MessageBox.Show("Are you sure you want to Update this Training Course Type?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (answer == DialogResult.Yes)
                    {

                        SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                        SqlDataReader MyReader3;
                        ConnectString.connectstring.Open();
                        MyReader3 = MyCommand3.ExecuteReader();
                        MessageBox.Show("Training Course Type successfully updated");
                        ConnectString.connectstring.Close();
                        this.Close();
                        this.Dispose(true);
                        AddInstrucorC myform = new AddInstrucorC();
                        myform.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("No Changes Made");
                        ConnectString.connectstring.Close();
                    }
                
            }

            catch
            {

            }
        }
    }
}
