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
    public partial class Search_Order : Form
    {
        public Search_Order()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Select_Instructor si = new Select_Instructor();
            si.Show();
        }

        private void Search_Order_Load(object sender, EventArgs e)
        {
            var LoadOrders = from Order in db.TableOrders select Order;
            dgvOrders.DataSource = LoadOrders;
            dgvOrders.Refresh();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF UM = new MainMenuF();
            UM.ShowDialog();
        }
    }
}
