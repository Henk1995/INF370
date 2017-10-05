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
            //USer
            ToolTip TTUSers = new ToolTip();
            TTUSers.ToolTipTitle = "Users";
            TTUSers.UseFading = true;
            TTUSers.UseAnimation = true;
            TTUSers.IsBalloon = true;
            TTUSers.SetToolTip(Users, "Click here to go to the user menu.");
            //Training
            ToolTip TTTRAIN = new ToolTip();
            TTTRAIN.ToolTipTitle = "Instructor Training";
            TTTRAIN.UseFading = true;
            TTTRAIN.UseAnimation = true;
            TTTRAIN.IsBalloon = true;
            TTTRAIN.SetToolTip(button1, "Click here to go to the Instructor training menu.");
            //Instructor
            ToolTip TTINS = new ToolTip();
            TTINS.ToolTipTitle = "Instructors";
            TTINS.UseFading = true;
            TTINS.UseAnimation = true;
            TTINS.IsBalloon = true;
            TTINS.SetToolTip(button2, "Click here to go to the Instructors menu.");
            //Suppliers
            ToolTip TTSUP = new ToolTip();
            TTSUP.ToolTipTitle = "Suppliers";
            TTSUP.UseFading = true;
            TTSUP.UseAnimation = true;
            TTSUP.IsBalloon = true;
            TTSUP.SetToolTip(button3, "Click here to go to the Supplier menu.");
            //orders
            ToolTip TTORDER = new ToolTip();
            TTORDER.ToolTipTitle = "Orders";
            TTORDER.UseFading = true;
            TTORDER.UseAnimation = true;
            TTORDER.IsBalloon = true;
            TTORDER.SetToolTip(button4, "Click here to go to the Orders menu.");
            //printers
            ToolTip TTPRINT = new ToolTip();
            TTPRINT.ToolTipTitle = "Printers";
            TTPRINT.UseFading = true;
            TTPRINT.UseAnimation = true;
            TTPRINT.IsBalloon = true;
            TTPRINT.SetToolTip(button5, "Click here to go to the printers menu.");
            //stock
            ToolTip TTSTOCK = new ToolTip();
            TTSTOCK.ToolTipTitle = "Stock";
            TTSTOCK.UseFading = true;
            TTSTOCK.UseAnimation = true;
            TTSTOCK.IsBalloon = true;
            TTSTOCK.SetToolTip(button8, "Click here to go to the Stock menu.");
            //courses
            ToolTip ttCOURSES = new ToolTip();
            ttCOURSES.ToolTipTitle = "Courses";
            ttCOURSES.UseFading = true;
            ttCOURSES.UseAnimation = true;
            ttCOURSES.IsBalloon = true;
            ttCOURSES.SetToolTip(button7, "Click here to go to the Courses menu.");
            //reports
            ToolTip ttREPORTS = new ToolTip();
            ttREPORTS.ToolTipTitle = "Reports";
            ttREPORTS.UseFading = true;
            ttREPORTS.UseAnimation = true;
            ttREPORTS.IsBalloon = true;
            ttREPORTS.SetToolTip(button6, "Click here to go to the Reports menu.");

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

        private void label1_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("Chrome.exe", "http://www.parents.co.za");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                {
                    MessageBox.Show(noBrowser.Message);
                }
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
