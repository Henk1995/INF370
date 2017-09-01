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
    public partial class Select_Instructor : Form
    {
        public Select_Instructor()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();

        public static int InstructorIDForOrder;

        private void Select_Instructor_Load(object sender, EventArgs e)
        {
            cbInstructor.Items.Clear();

            var mLoadInstructors = (from x in db.Instructors select x.Name);

            cbInstructor.DataSource = mLoadInstructors;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Search_Order so = new Search_Order();
            so.Show();
        }

        private void btnSelectInstructor_Click(object sender, EventArgs e)
        {
            InstructorIDForOrder = cbInstructor.SelectedIndex + 1;

            Place_Instructor_Order pio = new Place_Instructor_Order();
            pio.Show();
        }
    }
}
