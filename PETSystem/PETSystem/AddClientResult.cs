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

        public static int SelectedClientLine;
        ErrorHandle chk = new ErrorHandle();
        PET_DBDataContext db = new PET_DBDataContext();
        int CourseInstanceID = Client_Course_Menu.CourseClientLineID;

        private void AddClientResult_Load(object sender, EventArgs e)
        {
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

                dgvClientList.Rows.Add(new object[] { getClientName, getClientSurname, getResultName });
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
            // Remove client from course
            if (dgvClientList.SelectedCells.Count > 0)
            {
                ClientCourseLine _ClientInCourse = (ClientCourseLine)dgvClientList.CurrentRow.DataBoundItem;
                string SelectedClientName = Convert.ToString(dgvClientList.SelectedCells[0].Value);
                //string SelectedClientSurname = Convert.ToString(dgvClientList.SelectedCells[1].Value);

                var GetClientIDFromName = (from x in db.Clients where x.ClientName == SelectedClientName select x.ClientID).FirstOrDefault();
                SelectedClientLine = GetClientIDFromName;
            }
            else
            {
                MessageBox.Show("Please select a row to add", "Error");
            }

            this.Close();
            AddClientResultMessageBox ACRMB = new AddClientResultMessageBox();
            ACRMB.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
