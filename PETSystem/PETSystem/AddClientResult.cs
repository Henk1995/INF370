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
    public partial class AddClientResult : Form
    {
        public AddClientResult()
        {
            InitializeComponent();
        }
        DateTime endOfTime;
        Timer t;
        public static int SelectedClientLine;
        ErrorHandle chk = new ErrorHandle();
        PET_DBDataContext db = new PET_DBDataContext();
        int CourseInstanceID = Client_Course_Menu.CourseClientLineID;

        private void AddClientResult_Load(object sender, EventArgs e)
        {
            //Add Result
            ToolTip TTR = new ToolTip();
            TTR.ToolTipTitle = "Result";
            TTR.UseFading = true;
            TTR.UseAnimation = true;
            TTR.IsBalloon = true;
            TTR.SetToolTip(button1, "Click here to add a result to a selected user.");
            //Back
            ToolTip TTB = new ToolTip();
            TTB.ToolTipTitle = "Back";
            TTB.UseFading = true;
            TTB.UseAnimation = true;
            TTB.IsBalloon = true;
            TTB.SetToolTip(button2, "Click here to go back to previous screen.");
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);
            // var getClientDetails = (from)

            //dgvClientCourseLine.DataSource = null;


            foreach ( var x in dgvClientList.Rows)
            {
                dgvClientList.Rows.Clear();

            }
            dgvClientList.Update();
            dgvClientList.Refresh();

            //refresh DGV
            var mLoadCourseClientLineData = (from x in db.ClientCourseLines
                                             where x.CourseID == Convert.ToInt32(CourseInstanceID)
                                             select x).ToList();

            foreach (var item in mLoadCourseClientLineData)
            {
                var getClientName = (from x in db.Clients where x.ClientID == item.ClientID select x.ClientName).FirstOrDefault();
                var getClientSurname = (from x in db.Clients where x.ClientID == item.ClientID select x.ClientSurname).FirstOrDefault();
                var getResultName = (from x in db.Results where x.ResultID == item.ResultID select x.ResultName).FirstOrDefault();
                
                dgvClientList.Rows.Add(new object[] { item.ClientID, getClientName, getClientSurname, getResultName });
            }
            dgvClientList.Update();
            dgvClientList.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Client_Course_Menu ccm = new Client_Course_Menu();
            ccm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvClientList.SelectedRows.Count > 0)
            {
                ClientCourseLine _ClientInCourse = (ClientCourseLine)dgvClientList.CurrentRow.DataBoundItem;
                //string SelectedClientName = Convert.ToString(dgvClientList.SelectedCells[0].Value);

                SelectedClientLine = Convert.ToInt32(dgvClientList.SelectedCells[0].Value);

                this.Close();
                AddClientResultMessageBox ACRMB = new AddClientResultMessageBox();
                ACRMB.Show();

                

                //var GetClientIDFromName = (from x in db.Clients where x.ClientName == SelectedClientName select x.ClientID).FirstOrDefault();
                //SelectedClientLine = GetClientIDFromName;
            }
            else
            {
                MessageBox.Show("Please select a row to add", "Error");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void AddClientResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
