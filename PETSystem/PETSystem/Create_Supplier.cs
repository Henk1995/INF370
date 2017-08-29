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
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        bool valid5 = false;
        bool valid6 = false;
        bool valid7 = false;
        SqlConnection connectstring = new SqlConnection(DBC);
        bool valid8 = false;
        ErrorHandle EH = new ErrorHandle();
        public Create_Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SupplierID = 0;
            
            valid6 = EH.CheckEmpty(cmbSupplierT.Text);
            
            if (valid1 && valid2 && valid3 && valid4 && valid5 && valid6)
            {
                MessageBox.Show("Are you sure you want to Create this new Supplier", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                DataTable DT = new DataTable();
                string query4 = "SELECT SupplierTypeID FROM SupplierType WHERE SupplierTypeName ='" + cmbSupplierT.Text + "'";
                SqlCommand MyCommand4 = new SqlCommand(query4, connectstring);
                SqlDataReader MyReader4;
                connectstring.Open();
                MyReader4 = MyCommand4.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader4.Read())
                {
                    SupplierID = Convert.ToInt32(MyReader4["SupplierTypeID"]);
                }
                connectstring.Close();
               
                string Query = "INSERT INTO Supplier (SupplierName,SupplierAddress,SupplierEmail,SupplierPhoneNumber,SupplierBankAccNumber,SupplierTypeID) VALUES ('" + this.txtSuppName.Text + "','" + this.txtAdress.Text + "','" + this.txtEmail.Text + "','" + this.txtPhonenumber.Text + "','" + this.txtBancACC.Text + "','" + SupplierID + "');";
                SqlCommand MyCommand3 = new SqlCommand(Query, connectstring);
                SqlDataReader MyReader3;
                connectstring.Open();
                MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader3.Read())
                {
                }
                connectstring.Close();
            }
            else
            {
                MessageBox.Show("Information given was invalid please resubmit all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void Create_Supplier_Load(object sender, EventArgs e)
        {
            cmbSupplierT.Items.Clear();

            
            string query1 = "SELECT SupplierTypeName FROM SupplierType ";
            DataTable DT = new DataTable();
            connectstring.Open();
            SqlCommand cmd = new SqlCommand(query1, connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                cmbSupplierT.Items.Add(dr["SupplierTypeName"]).ToString();
            }
            connectstring.Close();
        }

        private void txtSuppName_TextChanged(object sender, EventArgs e)
        {
            valid1 = EH.Checkstring(txtSuppName.Text);
            if (!valid1)
            {
                txtSuppName.BackColor = Color.Red;
            }
            else
            {
                txtSuppName.BackColor = Color.White;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.CheckEmail(txtEmail.Text);
            if (!valid3)
            {
                txtEmail.BackColor = Color.Red;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }
        }

        private void txtPhonenumber_TextChanged(object sender, EventArgs e)
        {
            valid4 = EH.CheckInt(txtPhonenumber.Text);
            if (!valid4)
            {
                txtPhonenumber.BackColor = Color.Red;
            }
            else
            {
                txtPhonenumber.BackColor = Color.White;
            }
        }

        private void txtBancACC_TextChanged(object sender, EventArgs e)
        {
            valid5 = EH.CheckInt(txtBancACC.Text);
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
            valid2 = EH.CheckstringNum(txtAdress.Text);
            if (!valid2)
            {
                txtAdress.BackColor = Color.Red;
            }
            else
            {
                txtAdress.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Suppliers UM = new Suppliers();
            UM.ShowDialog();
        }
    }
}
