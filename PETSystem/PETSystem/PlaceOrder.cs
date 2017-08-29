using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Place_Order
{
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to place this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
