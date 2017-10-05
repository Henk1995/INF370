using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETSystem
{
    public partial class AddClientResultMessageBox : Form
    {
        public AddClientResultMessageBox()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();
        int CurrentCourseID = Client_Course_Menu.CourseClientLineID;
        int CurrentClientToUpdateID = AddClientResult.SelectedClientLine;

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Add Result?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    //Change result to passed
                    var getInfo = (from x in db.ClientCourseLines where x.ClientID == CurrentClientToUpdateID && x.CourseID == CurrentCourseID select x).FirstOrDefault();

                    getInfo.ResultID = 1;
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Result Not Added.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }



            }
            catch
            {
                
            }
            this.Close();
            AddClientResult myform = new AddClientResult();
            myform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Add Result?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    //Change result to passed
                    var getInfo = (from x in db.ClientCourseLines where x.ClientID == CurrentClientToUpdateID && x.CourseID == CurrentCourseID select x).FirstOrDefault();

                    getInfo.ResultID = 2;
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Result Not Added.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }



            }
            catch
            {

            }
            this.Close();
            AddClientResult myform = new AddClientResult();
            myform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            AddClientResult myform = new AddClientResult();
            myform.Show();
        }

        private void AddClientResultMessageBox_Load(object sender, EventArgs e)
        {
            label2.Text = "Please indicate if the selected Client\npassed or failed the course";
            //passed
            ToolTip TTpass = new ToolTip();
            TTpass.ToolTipTitle = "Pass";
            TTpass.UseFading = true;
            TTpass.UseAnimation = true;
            TTpass.IsBalloon = true;
            TTpass.SetToolTip(button1, "Click here if the client Passed.");
            //feaie
            ToolTip TTFAI = new ToolTip();
            TTFAI.ToolTipTitle = "Fail";
            TTFAI.UseFading = true;
            TTFAI.UseAnimation = true;
            TTFAI.IsBalloon = true;
            TTFAI.SetToolTip(button3, "Click here if the client Failed.");
            //cancel
            ToolTip TTC = new ToolTip();
            TTC.ToolTipTitle = "Cancel";
            TTC.UseFading = true;
            TTC.UseAnimation = true;
            TTC.IsBalloon = true;
            TTC.SetToolTip(button2, "Click here to cancel.");
        }
    }
}
