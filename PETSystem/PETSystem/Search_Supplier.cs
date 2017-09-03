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

namespace Search_Supplier
{
    public partial class Search_Supplier : Form
    {
        ErrorHandle EH = new ErrorHandle();

        SqlDataAdapter DA;
        public Search_Supplier()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Supplier", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            dataGridView1.DataMember = DT.TableName;
            ConnectString.connectstring.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Suppliers UM = new Suppliers();
            UM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
            valid = EH.Checkstring(textBox3.Text);
            bool validSQl = EH.checkForSQLInjection(textBox3.Text);
            if (valid)
            {
                valid = validSQl;
            }
            if (valid)
            {
                textBox3.BackColor = Color.White;
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("select * from Supplier where SupplierName like '" + textBox3.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                ConnectString.connectstring.Close();
            }
            else
            {
                textBox3.BackColor = Color.FromArgb(249, 29, 29);
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Supplier", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                dataGridView1.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
            valid = EH.CheckInt(textBox1.Text);
            bool validSQl = EH.checkForSQLInjection(textBox1.Text);
            if (valid)
            {
                valid = validSQl;
            }
            if (valid)
            {
                textBox1.BackColor = Color.White;
                ConnectString.connectstring.Open();
                DA = new SqlDataAdapter("select * from Supplier where SupplierID like '" + textBox1.Text + "%'", ConnectString.connectstring);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                ConnectString.connectstring.Close();
            }
            else
            {
                textBox1.BackColor = Color.FromArgb(249, 29, 29);
                DataTable DT = new DataTable();
                ConnectString.connectstring.Open();
                SqlCommand Fill = new SqlCommand("SELECT * FROM Supplier", ConnectString.connectstring);
                DA = new SqlDataAdapter(Fill);
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                dataGridView1.DataMember = DT.TableName;
                ConnectString.connectstring.Close();
            }
        }
    }
}
