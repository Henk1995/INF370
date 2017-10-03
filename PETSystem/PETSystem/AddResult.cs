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

    public partial class AddResult : Form
    {
        DateTime endOfTime;
        Timer t;
        DataTable DT = new DataTable();
        int courseID;
       
        
        public AddResult()
        {
            InitializeComponent();
        }
        public AddResult(int value)
        {
            
            courseID = value;

            InitializeComponent();
        }
        PET_DBDataContext db = new PET_DBDataContext();

        private void AddResult_Load(object sender, EventArgs e)
        {
            //ADD
            ToolTip TTADD = new ToolTip();
            TTADD.ToolTipTitle = "Add";
            TTADD.UseFading = true;
            TTADD.UseAnimation = true;
            TTADD.IsBalloon = true;
            TTADD.SetToolTip(button1, "Select an instructor from the list and\nclick here to add a result.");
            //Back
            ToolTip TTBAck = new ToolTip();
            TTBAck.ToolTipTitle = "Back";
            TTBAck.UseFading = true;
            TTBAck.UseAnimation = true;
            TTBAck.IsBalloon = true;
            TTBAck.SetToolTip(button2, "Click here to return to the Training Course Menu.");
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
             t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            foreach (var x in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();

            }
            dataGridView1.Update();
            dataGridView1.Refresh();

            //refresh DGV
            var mLoadCourseClientLineData = (from x in db.TrainingCourseLines
                                             where x.TrainingCourseID == ConnectString.TrainingCourseIDForResult
                                             select x).ToList();
           
            foreach (var item in mLoadCourseClientLineData)
            {
                var getClientName = (from x in db.Instructors where x.InstructorID == item.InstructorID select x.Name).FirstOrDefault();
                var getClientSurname = (from x in db.Instructors where x.InstructorID == item.InstructorID select x.Surname).FirstOrDefault();
                var getResultName = (from x in db.Results where x.ResultID == item.ResultID select x.ResultName).FirstOrDefault();
               
                dataGridView1.Rows.Add(new object[] { item.InstructorID, getClientName, getClientSurname, getResultName });
            }
            dataGridView1.Update();
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vir pass
           

            try
            {
                string instructorID = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                ConnectString.InstructorID = Convert.ToInt32(instructorID);
                AddResultMessagebox myform = new AddResultMessagebox();
                myform.Show();
                this.Close();
                this.Dispose(true);
            }
            catch
            {
                MessageBox.Show("Please select a row to add an result to");
            }

        }
        //Fail


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            TrainingCourseMenu UM = new TrainingCourseMenu();
            UM.ShowDialog();
        }

      

    
        int stop = 0;
        int ticks = ConnectString.TimerTime * 60;

        private void timer1_Tick(object sender, EventArgs e)
        {

            stop++;

            if (stop > ticks)
            {
                t.Enabled = false;
                this.Close();
                this.Dispose(true);
                LoginF myform = new LoginF();
                myform.ShowDialog();
            }
            else {
                TimeSpan ts = endOfTime.Subtract(DateTime.Now);
                lblTimer.Text = ts.ToString();
            }
        }

        private void AddResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
