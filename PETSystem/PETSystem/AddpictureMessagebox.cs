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
    public partial class AddpictureMessagebox : Form
    {
        public AddpictureMessagebox()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectString.Addpicture = true;
            this.Close();
            this.Dispose(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectString.Addpicture = false;
            this.Close();
            this.Dispose(true);
        }
    }
}
