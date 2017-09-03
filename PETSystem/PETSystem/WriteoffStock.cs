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

        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool WriteoffValid;
        int loadID = Search_Stock.ToUpdate;
        int getTypeID;
        int CurrentQuantity;
        int WriteoffAmmount;
        int NewQuantity;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtWriteoffQuantity.BackColor = Color.White;
            string Quantity = txtWriteoffQuantity.Text;
            bool isInt = chk.CheckInt(Quantity);
            bool notEmpty = chk.CheckEmpty(Quantity);
            bool checkForSQLInjection = chk.checkForSQLInjection(Quantity);

            if (isInt == false)
            {
                txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                WriteoffValid = false;
            }
            else if (notEmpty == false)
            {
                txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                WriteoffValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                WriteoffValid = false;
            }
            {
                txtWriteoffQuantity.BackColor = Color.White;
                WriteoffValid = true;
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            string Quantity = txtWriteoffQuantity.Text;
            

            WriteoffAmmount = Convert.ToInt32(txtWriteoffQuantity.Text);
            

            //!int.TryParse(q, out Quantity)
            if (WriteoffValid == false)
            {
                MessageBox.Show("The input was invalid, Please check it and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Update DB


                if (CurrentQuantity < WriteoffAmmount)
                {
                    MessageBox.Show("You cannot writeoff more stock than your current inventory", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    NewQuantity = CurrentQuantity - WriteoffAmmount;
                    var mStock = (from x in db.Stocks where x.StockID == Convert.ToInt32(loadID) select x).FirstOrDefault();

                    mStock.StockQuantity = Convert.ToInt32(NewQuantity);

                    db.SubmitChanges();

                    this.Close();

                    MessageBox.Show("Updated quantity", "It Worked");

                    Search_Stock sc = new Search_Stock();
                    sc.Show();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes window on exit

            Search_Stock sc = new Search_Stock();
            sc.Show();
        }
        
        private void WriteoffStock_Load(object sender, EventArgs e)
        {
            

            var mStockload = (from a in db.Stocks
                              where a.StockID == loadID
                              select new
                              {
                                  a.StockID,
                                  a.StockDescription,
                                  a.StockUnitPrice,
                                  a.StockTypeID,
                                  a.StockQuantity


                              }).ToList();

            foreach (var item in mStockload)
            {
                lblStockID.Text = Convert.ToString(item.StockID);
                lblStockDesc.Text = item.StockDescription;
                lblStockUnitPrice.Text = Convert.ToString(item.StockUnitPrice);
                lblStockQuantity.Text = Convert.ToString(item.StockQuantity);
                getTypeID = item.StockTypeID;
                CurrentQuantity = Convert.ToInt32(item.StockQuantity);
            }

            var mStockTypeload = (from x in db.StockTypes
                              where x.StockTypeID == getTypeID
                              select new
                              {
                                 x.StockTypeID,
                                 x.StockName
                              }).ToList();

            foreach (var Typevalue in mStockTypeload)
            {
                lblStockType.Text = Typevalue.StockName;
            }


        }
    }
}

