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
        bool DateValid;
        bool ReasonValid;
        int loadID = Search_Stock.StockToUpdate;
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
                //txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                WriteoffValid = false;
            }
            else if (notEmpty == false)
            {
                //txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                WriteoffValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                //txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
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
            

            if ( WriteoffValid == false && DateValid == false && ReasonValid == false)
            {
                MessageBox.Show("One or more inputs were invalid, Please check it and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                txtDate.BackColor = Color.FromArgb(244, 17, 17);
                txtReason.BackColor = Color.FromArgb(244, 17, 17);
            }
            else if (WriteoffValid == false)
            {
                MessageBox.Show("The Quantity was invalid, Please check it and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
            }
            else if (DateValid == false)
            {
                MessageBox.Show("The Date was invalid, Please check it and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDate.BackColor = Color.FromArgb(244, 17, 17);
            }
            else if (ReasonValid == false)
            {
                MessageBox.Show("The Reason was invalid, Please check it and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReason.BackColor = Color.FromArgb(244, 17, 17);
            }
            else
            {
                //Update DB


                if (CurrentQuantity < WriteoffAmmount)
                {
                    txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                    MessageBox.Show("You cannot writeoff more stock than your current inventory", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    txtWriteoffQuantity.BackColor = Color.White;
                    NewQuantity = CurrentQuantity - WriteoffAmmount;
                    var mStock = (from x in db.Stocks where x.StockID == Convert.ToInt32(loadID) select x).FirstOrDefault();

                    mStock.StockQuantity = Convert.ToInt32(NewQuantity);

                    db.SubmitChanges();

                    DamagedStock D = new DamagedStock
                    {
                        DamageDate = txtDate.Text,
                        StockID = loadID,
                        Reason = txtReason.Text,
                        DamagedStockQuantity = WriteoffAmmount
                    };

                    db.DamagedStocks.InsertOnSubmit(D);
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

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            txtReason.BackColor = Color.White;
            string Reason = txtWriteoffQuantity.Text;
            bool isString = chk.Checkstring(Reason);
            bool notEmpty = chk.CheckEmpty(Reason);
            bool checkForSQLInjection = chk.checkForSQLInjection(Reason);

            if (isString == false)
            {
                //txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                ReasonValid = false;
            }
            else if (notEmpty == false)
            {
                //txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                ReasonValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                //txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                ReasonValid = false;
            }
            {
                txtWriteoffQuantity.BackColor = Color.White;
                ReasonValid = true;
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            txtDate.BackColor = Color.White;
            string Date = txtWriteoffQuantity.Text;
            bool isDate = chk.CheckDate(Date);
            bool notEmpty = chk.CheckEmpty(Date);
            bool checkForSQLInjection = chk.checkForSQLInjection(Date);

            if (isDate == false)
            {
                //txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                DateValid = false;
            }
            else if (notEmpty == false)
            {
                //txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                DateValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                //txtWriteoffQuantity.BackColor = Color.FromArgb(244, 17, 17);
                DateValid = false;
            }
            {
                txtWriteoffQuantity.BackColor = Color.White;
                DateValid = true;
            }
        }
    }
}

