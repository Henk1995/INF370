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
    public partial class Select_Instructor : Form
    {
        DateTime endOfTime;
        Timer t;
        public Select_Instructor()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();

        public static int InstructorIDForOrder;

        private void Select_Instructor_Load(object sender, EventArgs e)
        {
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            cbInstructor.Items.Clear();

            var mLoadInstructors = (from x in db.Instructors select x.Name);

            cbInstructor.DataSource = mLoadInstructors;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Order so = new Search_Order();
            so.Show();
        }

        private void btnSelectInstructor_Click(object sender, EventArgs e)
        {
            string InsName = Convert.ToString(cbInstructor.SelectedItem);
            var GetInstID =(from x in db.Instructors where x.Name.Contains(InsName) select x.InstructorID).FirstOrDefault();

            InstructorIDForOrder = Convert.ToInt32(GetInstID);
            ConnectString.InstructorID = InstructorIDForOrder;

            this.Close();
            Place_Instructor_Order pio = new Place_Instructor_Order();
            pio.Show();
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

        private void Select_Instructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
