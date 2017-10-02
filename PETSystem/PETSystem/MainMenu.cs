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
        string[] pictures = { "system1.jpg", "system2.jpg", "system3.jpg" };

        int i = 0;

       

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
         //pictureBox1.LoadAsync();
          pictureBox1.Image = Image.FromFile("C:\\Users\\Jan-Wilkens\\Source\\Repos\\PETSystem\\PETSystem\\" + pictures[0]);




        }

        private void button7_Click(object sender, EventArgs e)
        {
            //this.Close();
            //SearchCourse sc = new SearchCourse();
            //sc.Show();

            this.Close();
            Client_Course_Menu scc = new Client_Course_Menu();
            scc.Show();
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
            this.Close();
            Suppliers spp = new Suppliers();
            spp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Reports Um = new Reports();
            Um.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
           if (pictures.Length == i) { i = 0; }
          //pictureBox1.Image = Image.FromFile("C:\\Users\\Jan-Wilkens\\Source\\Repos\\PETSystem\\PETSystem\\" + pictures[i]);

           

        }
    }
}
