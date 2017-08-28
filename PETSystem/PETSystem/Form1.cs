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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_Stock h = new Search_Stock();
            h.Show();
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            SearchCourse s = new SearchCourse();
            s.Show();
        }

        private void btnPrintingSupplier_Click(object sender, EventArgs e)
        {
            Search_Printing_Supplier sps = new Search_Printing_Supplier();
            sps.Show();
        }
    }
}
