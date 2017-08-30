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
        
        SqlDataAdapter DA;
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
            int GenderID = 0;
            int TitleID = 0;
            valid6 = EH.CheckEmpty(cmbSuppType.Text);
          
            if (valid1 && valid2 && valid3 && valid4 && valid5 && valid6)
            {
                MessageBox.Show("Are you sure you want to update this Supplier", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string query1 = "SELECT SupplierTypeID FROM SupplierType WHERE SupplierTypeName ='" + cmbSuppType.Text + "'";
                SqlCommand MyCommand1 = new SqlCommand(query1, ConnectString.connectstring);
                SqlDataReader MyReader1;
                ConnectString.connectstring.Open();
                MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader1.Read())
                {
                    GenderID = Convert.ToInt32(MyReader1["SupplierTypeID"]);
                }
                ConnectString.connectstring.Close();
               
                string Query = "UPDATE Supplier SET SupplierName ='" + this.txtSuppName.Text + "', SupplierAddress = '" + this.txtAdress.Text + "', SupplierEmail = '" + this.txtEmail.Text + "', SupplierPhoneNumber = '" + this.txtPhoneNumber.Text + "', SupplierBankAccNumber ='" + this.txtBancACCN.Text + "', SupplierTypeID = '" + GenderID + "' WHERE SupplierID =" + Convert.ToInt32(InstructorID) + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  

                SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                SqlDataReader MyReader3;
                ConnectString.connectstring.Open();
                MyReader3 = MyCommand3.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader3.Read())
                {
                }
                ConnectString.connectstring.Close();//Connection closed here 
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Supplier", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvInstructor.DataSource = DT;
                dgvInstructor.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
            else
            {
                MessageBox.Show("Information given was invalid please resubmit all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            MessageBox.Show("Are you sure you want to update this Supplier", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }

        private void Update_Supplier_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Supplier", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            ConnectString.connectstring.Close();
            cmbSuppType.Items.Clear();

            string query1 = "SELECT SupplierTypeName FROM SupplierType ";
            DataTable DTa = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query1, ConnectString.connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DTa);
            foreach (DataRow dr in DTa.Rows)
            {
                cmbSuppType.Items.Add(dr["SupplierTypeName"]).ToString();
            }
            ConnectString.connectstring.Close();
        }

        private void dgvInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInstructor.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                InstructorID = dgvInstructor.SelectedRows[0].Cells[0].Value + string.Empty;
                string NameId = dgvInstructor.SelectedRows[0].Cells[1].Value + string.Empty;
                string adressId = dgvInstructor.SelectedRows[0].Cells[2].Value + string.Empty;
                string emailId = dgvInstructor.SelectedRows[0].Cells[3].Value + string.Empty;
                string phoneNumberId = dgvInstructor.SelectedRows[0].Cells[4].Value + string.Empty;
                string AccNid = dgvInstructor.SelectedRows[0].Cells[5].Value + string.Empty;
                string titleid = dgvInstructor.SelectedRows[0].Cells[6].Value + string.Empty;
                string query1 = "SELECT SupplierTypeName FROM SupplierType ";
                SqlCommand MyCommand2 = new SqlCommand(query1, ConnectString.connectstring);
                SqlDataReader MyReader2;
                ConnectString.connectstring.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader2.Read())
                {
                    titleid = MyReader2["SupplierTypeName"].ToString();
                }
                ConnectString.connectstring.Close();
               
                txtEmail.Text = emailId;
                txtSuppName.Text = NameId;
                txtAdress.Text = adressId;
                txtPhoneNumber.Text = phoneNumberId;
                txtBancACCN.Text = AccNid;
                cmbSuppType.Text = titleid;
            }
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

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            valid4 = EH.CheckInt(txtPhoneNumber.Text);
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
            UM.ShowDialog();
        }
    }
}
