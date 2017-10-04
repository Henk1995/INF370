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
    
    public partial class Create_stock_item : Form
    {
        DateTime endOfTime;
        Timer t;
        PET_DBDataContext db = new PET_DBDataContext();
        ErrorHandle chk = new ErrorHandle();
        bool stockDValid;
        bool unitPValid;


        public Create_stock_item()
        {
            InitializeComponent();
        }
        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            if (ConnectString.ActiveForm == true)
            {
                ConnectString.ActiveForm = false;
                this.Dispose(true);
                this.Close();
            }
            else {
                Search_Stock sc = new Search_Stock();
                sc.Show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string UnitPrice = txtPrice.Text;
            string stockDesc = txtDesc.Text;

            if (stockDValid == false && unitPValid == false)
            {
                MessageBox.Show("The Stock description and Price was not entered or entered incorrectly. Please re-enter the details and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (stockDValid == false)
            {
                MessageBox.Show("The stock description was not entered. Please re-enter the stock description and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (unitPValid == false)
            {
                MessageBox.Show("The Price was not entered or entered incorrectly. Please re-enter the Unit Price and try again.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                Stock mStock = new Stock
                {
                    StockDescription = txtDesc.Text,
                    StockUnitPrice = Convert.ToInt32(txtPrice.Text),
                    StockTypeID = Convert.ToInt32(cbType.SelectedIndex + 1),
                    StockQuantity = 0
                    };

                    db.Stocks.InsertOnSubmit(mStock);
                    db.SubmitChanges();

                    //this.Close();

                    MessageBox.Show("Added " + stockDesc +"", "Notification");
                if (ConnectString.ActiveForm == true)
                {
                    ConnectString.ActiveForm = false;
                    this.Dispose(true);
                    this.Close();
                }
                else {
                    MessageBox.Show("Added " + stockDesc + "", "Notification");
                    Search_Stock sc = new Search_Stock();
                    sc.Show();
                }
                
            }
        }

        private void Create_stock_item_Load(object sender, EventArgs e)
        {
            //Stock description
            ToolTip TTD = new ToolTip();
            TTD.ToolTipTitle = "Stock description";
            TTD.UseFading = true;
            TTD.UseAnimation = true;
            TTD.IsBalloon = true;
            TTD.SetToolTip(txtDesc, "Enter stock description here.");
            //Stock Unit price
            ToolTip TTUP = new ToolTip();
            TTUP.ToolTipTitle = "Stock Unit Price";
            TTUP.UseFading = true;
            TTUP.UseAnimation = true;
            TTUP.IsBalloon = true;
            TTUP.SetToolTip(txtPrice, "Enter stock unit price here.");
            //Stock type
            ToolTip TTT = new ToolTip();
            TTT.ToolTipTitle = "Stock Type";
            TTT.UseFading = true;
            TTT.UseAnimation = true;
            TTT.IsBalloon = true;
            TTT.SetToolTip(cbType, "Select stock type  here.");
            //new stock type
            ToolTip TTNEWSTOCKT = new ToolTip();
            TTNEWSTOCKT.ToolTipTitle = "New Stock Type";
            TTNEWSTOCKT.UseFading = true;
            TTNEWSTOCKT.UseAnimation = true;
            TTNEWSTOCKT.IsBalloon = true;
            TTNEWSTOCKT.SetToolTip(btnAddStockType, "Click here if you want to add a new stock type.");
            //add
            ToolTip TTADD = new ToolTip();
            TTADD.ToolTipTitle = "Add";
            TTADD.UseFading = true;
            TTADD.UseAnimation = true;
            TTADD.IsBalloon = true;
            TTADD.SetToolTip(btnSave, "Click here to add the new stock item.");
            //cancel
            ToolTip TTCAN = new ToolTip();
            TTCAN.ToolTipTitle = "Cancel";
            TTCAN.UseFading = true;
            TTCAN.UseAnimation = true;
            TTCAN.IsBalloon = true;
            TTCAN.SetToolTip(btnCancel, "Click here to Cancel and return to previous screen");
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            var mStockTypeID = (
                  from a in db.StockTypes
                  select a.StockName)
                   .ToList();

            cbType.DataSource = mStockTypeID;

        }

        private void btnAddStockType_Click(object sender, EventArgs e)
        {
            this.Close();
            AddNewStockType f = new AddNewStockType();
            f.Show();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            txtDesc.BackColor = Color.White;
            string stockDesc = txtDesc.Text;
            bool isString = chk.Checkstring(stockDesc);
            bool notEmpty = chk.CheckEmpty(stockDesc);

            if (isString == false)
            {
                txtDesc.BackColor = Color.FromArgb(244, 17, 17);
                stockDValid = false;
            }
            else if (notEmpty == false)
            {
                txtDesc.BackColor = Color.FromArgb(244, 17, 17);
                stockDValid = false;
            }
            else
            {
                txtDesc.BackColor = Color.White;
                stockDValid = true;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtPrice.BackColor = Color.White;
            string UnitPrice = txtPrice.Text;
            bool isInt = chk.CheckInt(UnitPrice);
            bool notEmpty = chk.CheckEmpty(UnitPrice);

            if (isInt == false)
            {
                txtPrice.BackColor = Color.FromArgb(244, 17, 17);
                unitPValid = false;
            }
            else if (notEmpty == false)
            {
                txtPrice.BackColor = Color.FromArgb(244, 17, 17);
                unitPValid = false;
            }
            else
            {
                txtPrice.BackColor = Color.White;
                unitPValid = true;
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

        private void Create_stock_item_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
