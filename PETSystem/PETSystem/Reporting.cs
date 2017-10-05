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
            //Training course
            ToolTip TTTRAINING = new ToolTip();
            TTTRAINING.ToolTipTitle = "Training Course Report";
            TTTRAINING.UseFading = true;
            TTTRAINING.UseAnimation = true;
            TTTRAINING.IsBalloon = true;
            TTTRAINING.SetToolTip(button3, "Click here to generate the Training course report.");
            //Stock
            ToolTip TTTOCK = new ToolTip();
            TTTOCK.ToolTipTitle = "Stock Report";
            TTTOCK.UseFading = true;
            TTTOCK.UseAnimation = true;
            TTTOCK.IsBalloon = true;
            TTTOCK.SetToolTip(button1, "Click here to generate the Stock report.");
            //instructor course
            ToolTip TTInstructorcoursereport = new ToolTip();
            TTInstructorcoursereport.ToolTipTitle = "Instructor Course Report";
            TTInstructorcoursereport.UseFading = true;
            TTInstructorcoursereport.UseAnimation = true;
            TTInstructorcoursereport.IsBalloon = true;
            TTInstructorcoursereport.SetToolTip(button5, "Click here to generate the Instructor Course report.");
            //supplier
            ToolTip TTSUP = new ToolTip();
            TTSUP.ToolTipTitle = "Supplier Report";
            TTSUP.UseFading = true;
            TTSUP.UseAnimation = true;
            TTSUP.IsBalloon = true;
            TTSUP.SetToolTip(button4, "Click here to generate the Supplier report.");
            //sales
            ToolTip TTSALES = new ToolTip();
            TTSALES.ToolTipTitle = "Sales Report";
            TTSALES.UseFading = true;
            TTSALES.UseAnimation = true;
            TTSALES.IsBalloon = true;
            TTSALES.SetToolTip(button8, "Click here to generate the Sales report.");
            //client couirse
            ToolTip TTCC = new ToolTip();
            TTCC.ToolTipTitle = "Client Course Report";
            TTCC.UseFading = true;
            TTCC.UseAnimation = true;
            TTCC.IsBalloon = true;
            TTCC.SetToolTip(button7, "Click here to generate the Client Course report.");
            //back
            ToolTip TTBACK = new ToolTip();
            TTBACK.ToolTipTitle = "Back";
            TTBACK.UseFading = true;
            TTBACK.UseAnimation = true;
            TTBACK.IsBalloon = true;
            TTBACK.SetToolTip(button6, "Click here to return to previous screen.");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            InstructorCoursesReport p = new InstructorCoursesReport();
            p.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SuppliersReport j = new SuppliersReport();
            j.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClinetCourseReport h = new ClinetCourseReport();
            h.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SalesReportform j = new SalesReportform();
            j.ShowDialog();
        }
    }
}
