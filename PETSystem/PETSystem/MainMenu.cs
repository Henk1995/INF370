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
            this.Close();
            LoginM.Show();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            this.Close();
            UserMenu UM = new UserMenu();
            UM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainingCourseMenu UM = new TrainingCourseMenu();
            UM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Instructors UM = new Instructors();
            UM.Show();
        }

        private void MainMenuF_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchCourse sc = new SearchCourse();
            sc.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Stock sto = new Search_Stock();
            sto.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Printing_Supplier spp = new Search_Printing_Supplier();
            spp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Order SO = new Search_Order();
            SO.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Suppliers spp = new Suppliers();
            spp.Show();
        }
    }
}
