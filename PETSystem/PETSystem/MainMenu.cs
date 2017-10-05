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
       public static Image pic1 = PETSystem.Properties.Resources.PETLOGO;
        public static Image pic2 = PETSystem.Properties.Resources.newlogin;
        public static Image[] pictures = { pic1, pic2 };
      
       

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
            // TODO: This line of code loads data into the 'inf370RegDataSet.ApplicationForm' table. You can move, or remove it, as needed.
            // this.applicationFormTableAdapter.Fill(this.inf370RegDataSet.ApplicationForm);
            //pictureBox1.LoadAsync();
            pictureBox1.Image = pictures[0];




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
            Reporting Um = new Reporting();
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
          pictureBox1.Image =  pictures[i];

           

        }

        private void applicationFormBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
       //     this.Validate();
      //      this.applicationFormBindingSource.EndEdit();
     //       this.tableAdapterManager.UpdateAll(this.inf370RegDataSet);

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
