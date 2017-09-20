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
    public partial class Select_Printer_To_Order_From : Form
    {
        public Select_Printer_To_Order_From()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();

        public static int PrinterIDForOrder;

        private void Select_Printer_To_Order_From_Load(object sender, EventArgs e)
        {
            cbInstructor.Items.Clear();

            var mLoadInstructors = (from x in db.Instructors select x.Name);

            cbInstructor.DataSource = mLoadInstructors;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Printing_Supplier so = new Search_Printing_Supplier();
            so.Show();
        }

        private void btnSelectInstructor_Click(object sender, EventArgs e)
        {
            this.Close();
            Place_Printing_Order ppo = new Place_Printing_Order();
            ppo.Show();
        }
    }
}
