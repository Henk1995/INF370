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
    public partial class MainMenuF : Form
    {
        LoginF LoginM = new LoginF();
        
        public MainMenuF()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginM.ShowDialog();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UserMenu UM = new UserMenu();
            UM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TrainingCourseMenu UM = new TrainingCourseMenu();
            UM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Instructors UM = new Instructors();
            UM.ShowDialog();
        }

        private void MainMenuF_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SearchCourse sc = new SearchCourse();
            sc.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Search_Stock sto = new Search_Stock();
            sto.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Search_Printing_Supplier spp = new Search_Printing_Supplier();
            spp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
