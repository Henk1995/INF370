using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PETSystem;

namespace Update_Supplier
{
    public partial class Update_Supplier : Form
    {
        DateTime endOfTime;
        Timer t;
        ErrorHandle EH = new ErrorHandle();
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        bool valid5 = false;
        bool valid6 = false;
        string InstructorID;
        public Update_Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSuppType.SelectedIndex.ToString() != null && valid1 && valid2 && valid3 && valid4 && valid5)
                {
                    int SupplierType = cmbSuppType.SelectedIndex;
                    SupplierType = SupplierType + 1;
                    int SuppID = Convert.ToInt32(ConnectString.SupplierID);
                    string Query = "UPDATE Supplier SET SupplierName ='" + this.txtSuppName.Text + "', SupplierAddress = '" + this.txtAdress.Text + "', SupplierEmail = '" + this.txtEmail.Text + "', SupplierPhoneNumber = '" + this.txtPhoneNumber.Text + "',SupplierBankAccNumber ='" + this.txtBancACCN.Text + "',SupplierTypeID = '" + SupplierType + "' WHERE SupplierID =" + SuppID + ";";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    DialogResult answer = MessageBox.Show("Are you sure you want to Update this Supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (answer == DialogResult.Yes)
                    {

                        SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                        SqlDataReader MyReader3;
                        ConnectString.connectstring.Open();
                        MyReader3 = MyCommand3.ExecuteReader();
                        MessageBox.Show("Supplier successfully updated");
                        ConnectString.connectstring.Close();
                        this.Close();
                        this.Dispose(true);
                        Suppliers myform = new Suppliers();
                        myform.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("No Changes Made");
                        ConnectString.connectstring.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("Please enter all information");
                }
            }

            catch
            {

            }
        }

        private void Update_Supplier_Load(object sender, EventArgs e)
        {
            //Name
            ToolTip TTN = new ToolTip();
            TTN.ToolTipTitle = "Name";
            TTN.UseFading = true;
            TTN.UseAnimation = true;
            TTN.IsBalloon = true;
            TTN.SetToolTip(txtSuppName, "Enter the supplier's Name here.");
            //address
            ToolTip TTaddress = new ToolTip();
            TTaddress.ToolTipTitle = "Adress";
            TTaddress.UseFading = true;
            TTaddress.UseAnimation = true;
            TTaddress.IsBalloon = true;
            TTaddress.SetToolTip(txtAdress, "Enter the supplier's Address here.");
            //email
            ToolTip TTemail = new ToolTip();
            TTemail.ToolTipTitle = "E-Mail";
            TTemail.UseFading = true;
            TTemail.UseAnimation = true;
            TTemail.IsBalloon = true;
            TTemail.SetToolTip(txtEmail, "Enter the supplier's E-Mail here.");
            //phone number
            ToolTip TTPH = new ToolTip();
            TTPH.ToolTipTitle = "Phone Number";
            TTPH.UseFading = true;
            TTPH.UseAnimation = true;
            TTPH.IsBalloon = true;
            TTPH.SetToolTip(txtPhoneNumber, "Enter the supplier's Phone Number here.");
            //back acc number
            ToolTip TTBACN = new ToolTip();
            TTBACN.ToolTipTitle = "Bank account number";
            TTBACN.UseFading = true;
            TTBACN.UseAnimation = true;
            TTBACN.IsBalloon = true;
            TTBACN.SetToolTip(txtBancACCN, "Enter the supplier's Bank account number here.");
            //type
            ToolTip TTType = new ToolTip();
            TTType.ToolTipTitle = "Type";
            TTType.UseFading = true;
            TTType.UseAnimation = true;
            TTType.IsBalloon = true;
            TTType.SetToolTip(cmbSuppType, "Select the supplier's Type here.");
            //create
            ToolTip TTCRE = new ToolTip();
            TTCRE.ToolTipTitle = "Update Supplier";
            TTCRE.UseFading = true;
            TTCRE.UseAnimation = true;
            TTCRE.IsBalloon = true;
            TTCRE.SetToolTip(button1, "Click here to Update the supplier's information.");
            //back
            ToolTip TTBACK = new ToolTip();
            TTBACK.ToolTipTitle = "Back";
            TTBACK.UseFading = true;
            TTBACK.UseAnimation = true;
            TTBACK.IsBalloon = true;
            TTBACK.SetToolTip(button2, "Click here to Return to previous screen.");




            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            txtSuppName.Text = ConnectString.SupplierName;
            txtAdress.Text = ConnectString.SupplierAddress;
            txtEmail.Text = ConnectString.SupplierEmail;
            txtPhoneNumber.Text = ConnectString.SupplierPhoneNum;
            txtBancACCN.Text = Convert.ToString(ConnectString.SupplierBankAccount);

            //populate combobox
            cmbSuppType.Items.Clear();
            string query = "SELECT SupplierTypeName FROM SupplierType ";
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query, ConnectString.connectstring);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);

            foreach (DataRow dr in DT.Rows)
            {
                cmbSuppType.Items.Add(dr["SupplierTypeName"]).ToString();
            }
            ConnectString.connectstring.Close();
            //Select index in combobox
            cmbSuppType.SelectedIndex = cmbSuppType.FindStringExact(ConnectString.Suppliertype);

        }

        private void dgvInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtSuppName_TextChanged(object sender, EventArgs e)
        {
            valid1 = EH.Checkstring(txtSuppName.Text);
            bool validSQl = EH.checkForSQLInjection(txtSuppName.Text);
            if (valid1)
            {
                valid1 = validSQl;
            }
            if (!valid1)
            {
                txtSuppName.BackColor = Color.Red;
            }
            else
            {
                txtSuppName.BackColor = Color.White;
            }
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            valid2 = EH.CheckstringNum(txtAdress.Text);
            bool validSQl = EH.checkForSQLInjection(txtAdress.Text);
            if (valid2)
            {
                valid2 = validSQl;
            }

            if (!valid2)
            {
                txtAdress.BackColor = Color.Red;
            }
            else
            {
                txtAdress.BackColor = Color.White;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.CheckEmail(txtEmail.Text);
            bool validSQl = EH.checkForSQLInjection(txtEmail.Text);
            if (valid1)
            {
                valid1 = validSQl;
            }
            if (!valid3)
            {
                txtEmail.BackColor = Color.Red;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            valid4 = EH.CheckInt(txtPhoneNumber.Text);
            bool validSQl = EH.checkForSQLInjection(txtPhoneNumber.Text);
            if (valid1)
            {
                valid1 = validSQl;
            }
            if (!valid4)
            {
                txtPhoneNumber.BackColor = Color.Red;
            }
            else
            {
                txtPhoneNumber.BackColor = Color.White;
            }
        }

        private void txtBancACCN_TextChanged(object sender, EventArgs e)
        {
            valid5 = EH.CheckInt(txtBancACCN.Text);
            bool validSQl = EH.checkForSQLInjection(txtBancACCN.Text);
            if (valid1)
            {
                valid1 = validSQl;
            }
            if (!valid5)
            {
                txtBancACCN.BackColor = Color.Red;
            }
            else
            {
                txtBancACCN.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Suppliers UM = new Suppliers();
            UM.Show();
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

        private void Update_Supplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
