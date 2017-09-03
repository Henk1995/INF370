using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Delete_Supplier
{
    public partial class Delete_Supplier : Form
    {
        public Delete_Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to Delete this supplier", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            PETSystem.Suppliers UM = new PETSystem.Suppliers();
            UM.Show();
        }
    }
}
