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
        public static string DBC = "Data Source=JWM\\SYSARCH;Initial Catalog=INF370;Integrated Security=True";
        SqlConnection connectstring = new SqlConnection(DBC);
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
            valid5 = EH.CheckEmpty(cmbSuppType.Text);
          
            if (valid1 && valid2 && valid3 && valid4 && valid5 && valid6)
            {
                MessageBox.Show("Are you sure you want to update this Supplier", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string query1 = "SELECT SupplierTypeID FROM Gender WHERE SupplierTypeName ='" + cmbSuppType.Text + "'";
                SqlCommand MyCommand1 = new SqlCommand(query1, connectstring);
                SqlDataReader MyReader1;
                connectstring.Open();
                MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader1.Read())
                {
                    GenderID = Convert.ToInt32(MyReader1["SupplierTypeID"]);
                }
                connectstring.Close();
               
                string Query = "UPDATE Supplier SET SupplierName ='" + this.txtSuppName.Text + "', SupplierAddress = '" + this.txtAdress.Text + "', SupplierEmail = '" + this.txtEmail.Text + "', SupplierPhoneNumber = '" + this.txtPhoneNumber.Text + "', SupplierBankAccNumber ='" + this.txtBancACCN + "', SupplierTypeID = '" + TitleID + "' WHERE SupplierID =" + Convert.ToInt32(InstructorID) + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  

                SqlCommand MyCommand3 = new SqlCommand(Query, connectstring);
                SqlDataReader MyReader3;
                connectstring.Open();
                MyReader3 = MyCommand3.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader3.Read())
                {
                }
                connectstring.Close();//Connection closed here 
                DataTable DT = new DataTable();
                connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Supplier", connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dgvInstructor.DataSource = DT;
                dgvInstructor.DataMember = DT.TableName;
                connectstring.Close();
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
            connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Supplier", connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dgvInstructor.DataSource = DT;
            dgvInstructor.DataMember = DT.TableName;
            connectstring.Close();
            cmbSuppType.Items.Clear();

            string query1 = "SELECT SupplierTypeName FROM SupplierType ";
            DataTable DTa = new DataTable();
            connectstring.Open();
            SqlCommand cmd = new SqlCommand(query1, connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DTa);
            foreach (DataRow dr in DTa.Rows)
            {
                cmbSuppType.Items.Add(dr["SupplierTypeName"]).ToString();
            }
            connectstring.Close();
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
                SqlCommand MyCommand2 = new SqlCommand(query1, connectstring);
                SqlDataReader MyReader2;
                connectstring.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                while (MyReader2.Read())
                {
                    titleid = MyReader2["SupplierTypeName"].ToString();
                }
                connectstring.Close();
               
                txtEmail.Text = emailId;
                txtSuppName.Text = NameId;
                txtAdress.Text = adressId;
                txtPhoneNumber.Text = phoneNumberId;
                txtBancACCN.Text = AccNid;
                cmbSuppType.Text = titleid;
            }
        }
    }
}
