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
    public partial class AddNewStockType : Form
    {
        public AddNewStockType()
        {
            InitializeComponent();
        }
        DateTime endOfTime;
        Timer t;

        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool NameValid;

        // Moet desc validate word? kan maybe oopgelos word?


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            Create_stock_item sc = new Create_stock_item();
            sc.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string StockType = txtStockTypeName.Text;

            if (NameValid == false)
            {
                MessageBox.Show("The stock type was not entered. Please re-enter the stock type and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                StockType mStock = new StockType
                {
                    StockName = txtStockTypeName.Text
                };

                db.StockTypes.InsertOnSubmit(mStock);
                db.SubmitChanges();

                this.Close();

                MessageBox.Show("Added " + StockType + " " + "as a new stock type.", "It Worked");
                Create_stock_item sc = new Create_stock_item();
                sc.Show();
            }
        }

        private void txtStockTypeName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddNewStockType_Load(object sender, EventArgs e)
        {
            //Search
            ToolTip TTSearch = new ToolTip();
            TTSearch.ToolTipTitle = "Stock type";
            TTSearch.UseFading = true;
            TTSearch.UseAnimation = true;
            TTSearch.IsBalloon = true;
            TTSearch.SetToolTip(txtStockTypeName, "Enter Stock type name here.");
            //Add
            ToolTip TTADD = new ToolTip();
            TTADD.ToolTipTitle = "Add";
            TTADD.UseFading = true;
            TTADD.UseAnimation = true;
            TTADD.IsBalloon = true;
            TTADD.SetToolTip(btnSave, "Click here to add the new stock type.");
            //Cancel
            ToolTip TTC = new ToolTip();
            TTC.ToolTipTitle = "Cancel";
            TTC.UseFading = true;
            TTC.UseAnimation = true;
            TTC.IsBalloon = true;
            TTC.SetToolTip(btnCancel, "Click here to Cancel and return to previous screen.");
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);
        }

        private void txtStockTypeName_Leave(object sender, EventArgs e)
        {
            txtStockTypeName.BackColor = Color.White;
            string stockDesc = txtStockTypeName.Text;
            bool isString = chk.Checkstring(stockDesc);
            bool notEmpty = chk.CheckEmpty(stockDesc);
            bool checkForSQLInjection = chk.checkForSQLInjection(stockDesc);

            if (isString == false)
            {
                txtStockTypeName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else if (notEmpty == false)
            {
                txtStockTypeName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else if (checkForSQLInjection == false)
            {
                txtStockTypeName.BackColor = Color.FromArgb(244, 17, 17);
                NameValid = false;
            }
            else
            {
                txtStockTypeName.BackColor = Color.White;
                NameValid = true;
            }
        }

        int stop = 0;
        int ticks = ConnectString.TimerTime * 60;

        private void timer1_Tick(object sender, EventArgs e)
        {

            stop++;

            if (stop > ticks)
            {
                t.Enabled = false;
                this.Close();
                this.Dispose(true);
                LoginF myform = new LoginF();
                myform.ShowDialog();
            }
            else {
                TimeSpan ts = endOfTime.Subtract(DateTime.Now);
                lblTimer.Text = ts.ToString();
            }
        }

        private void AddNewStockType_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
