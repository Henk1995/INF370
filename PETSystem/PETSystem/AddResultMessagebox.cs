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
    public partial class AddResultMessagebox : Form
    {
        public AddResultMessagebox()
        {
            InitializeComponent();
        }

        private void AddResultMessagebox_Load(object sender, EventArgs e)
        {
            label2.Text = "Please indicate if the selected instructor\npassed or failed the course";
        }
    }
}
