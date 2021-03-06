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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool AddValid;
        int getTypeID;
        int CurrentQuantity;
        int NewID = Search_Stock.StockToUpdate;
        int AddAmmount;
        int NewQuantity;

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            
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
                AddAmmount = Convert.ToInt32(txtQuantity.Text);
                NewQuantity = CurrentQuantity + AddAmmount;

                var mStock = (from x in db.Stocks where x.StockID == Convert.ToInt32(NewID) select x).FirstOrDefault();

                mStock.StockQuantity = Convert.ToInt32(NewQuantity);

                db.SubmitChanges();
                
                this.Close();

                MessageBox.Show("Adding " + Quan, "items to stock table");

                this.Close();
                Search_Stock sc = new Search_Stock();
                sc.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Stock sc = new Search_Stock();
            sc.Show();
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            var mStockload = (from a in db.Stocks
                              where a.StockID == NewID
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
                lblstockID.Text = Convert.ToString(item.StockID);
                lblStockDesc.Text = item.StockDescription;
                lblPrice.Text = Convert.ToString(item.StockUnitPrice);
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

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            txtQuantity.BackColor = Color.White;

            txtQuantity.BackColor = Color.White;
            string Quantity = txtQuantity.Text;
            bool isInt = chk.CheckInt(Quantity);
            bool notEmpty = chk.CheckEmpty(Quantity);
            bool checkForSQLInjection = chk.checkForSQLInjection(Quantity);

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
            else if (checkForSQLInjection == false)
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
    }
}
