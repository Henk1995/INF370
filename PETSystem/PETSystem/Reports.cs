﻿using System;
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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report cannot be generated at this moment");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report cannot be generated at this moment");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report cannot be generated at this moment");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report cannot be generated at this moment");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.Show();
        }
    }
}
