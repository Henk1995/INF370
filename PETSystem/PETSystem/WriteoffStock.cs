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
    public partial class WriteoffStock : Form
    {
        public WriteoffStock()
        {
            InitializeComponent();
        }

        ErrorHandle chk = new ErrorHandle();
        bool WriteoffValid;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            string Quantity = textBox1.Text;
            bool isInt = chk.CheckInt(Quantity);
            bool notEmpty = chk.CheckEmpty(Quantity);

            if (isInt == false)
            {
                textBox1.BackColor = Color.FromArgb(244, 17, 17);
                WriteoffValid = false;
            }
            else if (notEmpty == false)
            {
                textBox1.BackColor = Color.FromArgb(244, 17, 17);
                WriteoffValid = false;
            }
            else
            {
                textBox1.BackColor = Color.White;
                WriteoffValid = true;
            }



        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            string Quantity = textBox1.Text;

            //!int.TryParse(q, out Quantity)
            if (WriteoffValid == false)
            {
                MessageBox.Show("The input was invalid, Please check it and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Update DB

                MessageBox.Show("Writing off " + Quantity, "stock items");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes window on exit
        }

        private void WriteoffStock_Load(object sender, EventArgs e)
        {

        }
    }
    }

