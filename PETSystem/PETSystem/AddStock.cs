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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        ErrorHandle chk = new ErrorHandle();
        bool AddValid;

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtQuantity.BackColor = Color.White;

            txtQuantity.BackColor = Color.White;
            string Quantity = txtQuantity.Text;
            bool isInt = chk.CheckInt(Quantity);
            bool notEmpty = chk.CheckEmpty(Quantity);

            if (isInt == false)
            {
                txtQuantity.BackColor = Color.FromArgb(244, 17, 17);
                AddValid = false;
            }
            else if (notEmpty == false)
            {
                txtQuantity.BackColor = Color.FromArgb(244, 17, 17);
                AddValid = false;
            }
            else
            {
                txtQuantity.BackColor = Color.White;
                AddValid = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string Quan = txtQuantity.Text;
            if (AddValid == false)
            {
                txtQuantity.BackColor = Color.FromArgb(244, 17, 17);
                MessageBox.Show("The input was invalid, Please check it and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Adding " + Quan, "items to stock table");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
