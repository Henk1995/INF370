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

namespace Create_Supplier
{
    public partial class Create_Supplier : Form
    {
        SqlDataAdapter DA;
        DateTime endOfTime;
        Timer t;
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        bool valid5 = false;
        bool valid6 = false;
        bool valid7 = false;
        bool valid8 = false;
        ErrorHandle EH = new ErrorHandle();
        public Create_Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SupplierID = 0;
            bool duplicate = false;
            valid6 = EH.CheckEmpty(cmbSupplierT.Text);

            if (valid1 && valid2 && valid3 && valid4 && valid5 && valid6)
            {
                string queryA = "SELECT * FROM Supplier WHERE SupplierName ='" + txtSuppName.Text + "' OR SupplierAddress ='" + txtAdress.Text + "' OR SupplierEmail ='" + txtEmail.Text + "' OR SupplierPhoneNumber ='" + txtPhonenumber.Text + "' OR SupplierBankAccNumber ='" + txtBancACC.Text + "'";
                SqlCommand MyCommandA = new SqlCommand(queryA, ConnectString.connectstring);

                SqlDataAdapter DAA = new SqlDataAdapter(MyCommandA);
                DataTable DTA = new DataTable();
                DAA.Fill(DTA);
                ConnectString.connectstring.Open();


                if (DTA.Rows.Count == 1)
                {

                    duplicate = true;
                }
                ConnectString.connectstring.Close();
                if (duplicate)
                {
                    MessageBox.Show("This supplier already exists please resubmit information.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                } else
                {
                    DialogResult answer = MessageBox.Show("Are you sure you want to Update this Training Course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (answer == DialogResult.Yes)
                    {
                        DataTable DT = new DataTable();
                        string query4 = "SELECT SupplierTypeID FROM SupplierType WHERE SupplierTypeName ='" + cmbSupplierT.Text + "'";
                        SqlCommand MyCommand4 = new SqlCommand(query4, ConnectString.connectstring);
                        SqlDataReader MyReader4;
                        ConnectString.connectstring.Open();
                        MyReader4 = MyCommand4.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                        while (MyReader4.Read())
                        {
                            SupplierID = Convert.ToInt32(MyReader4["SupplierTypeID"]);
                        }
                        ConnectString.connectstring.Close();

                        string Query = "INSERT INTO Supplier (SupplierName,SupplierAddress,SupplierEmail,SupplierPhoneNumber,SupplierBankAccNumber,SupplierTypeID) VALUES ('" + this.txtSuppName.Text + "','" + this.txtAdress.Text + "','" + this.txtEmail.Text + "','" + this.txtPhonenumber.Text + "','" + this.txtBancACC.Text + "','" + SupplierID + "');";
                        SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                        SqlDataReader MyReader3;
                        ConnectString.connectstring.Open();
                        MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("Supplier Created Successfully");
                        while (MyReader3.Read())
                        {
                        }
                        ConnectString.connectstring.Close();
                        this.Dispose(true);
                        this.Close();
                        Suppliers myform = new Suppliers();
                        myform.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Supplier hsa not been created");
                    }
            }
            }
            else
            {
                MessageBox.Show("Information given was invalid please resubmit all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void Create_Supplier_Load(object sender, EventArgs e)
        {

            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            //populate combobox
            cmbSupplierT.Items.Clear();
            string query = "SELECT SupplierTypeName FROM SupplierType ";
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query, ConnectString.connectstring);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);

            foreach (DataRow dr in DT.Rows)
            {
                cmbSupplierT.Items.Add(dr["SupplierTypeName"]).ToString();
            }
            ConnectString.connectstring.Close();
            //Select index in combobox
            cmbSupplierT.SelectedIndex = 0;
        }

        private void txtSuppName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPhonenumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBancACC_TextChanged(object sender, EventArgs e)
        {
            valid5 = EH.CheckInt(txtBancACC.Text);
            bool validSQl = EH.checkForSQLInjection(txtBancACC.Text);
            if (valid5)
            {
                valid5 = validSQl;
            }
            if (!valid5)
            {
                txtBancACC.BackColor = Color.Red;
            }
            else
            {
                txtBancACC.BackColor = Color.White;
            }
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Suppliers UM = new Suppliers();
            UM.Show();
        }

        private void txtSuppName_Leave(object sender, EventArgs e)
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

        private void txtAdress_Leave(object sender, EventArgs e)
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            valid3 = EH.CheckEmail(txtEmail.Text);
            bool validSQl = EH.checkForSQLInjection(txtEmail.Text);
            if (valid3)
            {
                valid3 = validSQl;
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

        private void txtPhonenumber_Leave(object sender, EventArgs e)
        {
            valid4 = EH.CheckphoneNum(txtPhonenumber.Text);
            bool validSQl = EH.checkForSQLInjection(txtPhonenumber.Text);
            if (valid4)
            {
                valid4 = validSQl;
            }
            if (!valid4)
            {
                txtPhonenumber.BackColor = Color.Red;
            }
            else
            {
                txtPhonenumber.BackColor = Color.White;
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

        private void Create_Supplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
