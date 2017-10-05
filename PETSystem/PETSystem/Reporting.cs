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
            ReportDocument report = new ReportDocument();
            report.Load( "C:\\Users\\Jan-Wilkens\\Source\\Repos\\PETSystem\\PETSystem\\PETSystem\\CrystalReport4.rpt");
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("C:\\Users\\Jan-Wilkens\\Source\\Repos\\PETSystem\\PETSystem\\PETSystem\\CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eXportvirJan2DataSet);

        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eXportvirJan2DataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.eXportvirJan2DataSet.Stock);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("C:\\Users\\Jan-Wilkens\\Source\\Repos\\PETSystem\\PETSystem\\PETSystem\\InstructorReport.rpt");
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("C:\\Users\\Jan-Wilkens\\Source\\Repos\\PETSystem\\PETSystem\\PETSystem\\SupplierReport.rpt");
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("C:\\Users\\Jan-Wilkens\\Source\\Repos\\PETSystem\\PETSystem\\PETSystem\\OrdersR.rpt");
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
