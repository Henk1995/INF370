using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace PETSystem
{
    public partial class Reporting : Form
    {
        public Reporting()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock_Report f = new Stock_Report();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InstructorTrainingReport m = new InstructorTrainingReport();
            m.ShowDialog();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void Reporting_Load(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            InstructorCoursesReport p = new InstructorCoursesReport();
            p.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
