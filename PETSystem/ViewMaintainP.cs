using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace PETSystem
{
    public partial class ViewMaintainP : Form
    {
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
        public ViewMaintainP()
        {
            
            

            InitializeComponent();
        }

        private void ViewMaintainP_Load(object sender, EventArgs e)
        {

        }

        private void btnMainM_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenuF UM = new MainMenuF();
            UM.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TrainingCourseMenu UM = new TrainingCourseMenu();
            UM.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
