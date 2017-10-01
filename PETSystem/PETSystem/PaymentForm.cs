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

namespace PETSystem
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            label6.Text = ConnectString.PaymentOrderID;
            label10.Text = ConnectString.PaymentRefNumber;
            label7.Text = ConnectString.PaymentinstructorName;
            label8.Text = ConnectString.PaymentCost;

            //CB
            cbPayment.Items.Clear();
            string query = "SELECT PaymentName FROM PaymentType ";
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query, ConnectString.connectstring);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);

            foreach (DataRow dr in DT.Rows)
            {
                cbPayment.Items.Add(dr["PaymentName"]).ToString();
            }
            ConnectString.connectstring.Close();
            //Select index in combobox
            cbPayment.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Search_Order myform = new Search_Order();
            myform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
              //  double paymentAmount;
                string paymentDate;
                double PaymentVat;
                double PaymentChange;
                double AmountRecieved;
                int paymentType;
                int OrderID;

                AmountRecieved = Convert.ToInt32(txtPayment.Text);
                paymentDate = DateTime.Now.ToString("dd/MM/yyyy");
                PaymentVat = Convert.ToInt32(ConnectString.PaymentCost) * 0.14;
                PaymentChange = AmountRecieved - Convert.ToInt32(ConnectString.PaymentCost);
                paymentType = cbPayment.SelectedIndex +1;

                ConnectString.connectstring.Open();
                string Query = "INSERT INTO Payment(PaymentAmount,PaymentDate,PaymentVat,PaymentChange,AmountRecieved,PaymentTypeID,OrderID) values('"+ConnectString.PaymentCost+"','"+paymentDate+"','"+PaymentVat+"','"+PaymentChange+"','"+AmountRecieved+"','"+paymentType+"','"+ConnectString.PaymentOrderID+"')";
                //This is  MySqlConnection here i have created the object and pass my connection string.  

                //This is command class which will handle the query and connection object.  
                SqlCommand MyCommand2 = new SqlCommand(Query, ConnectString.connectstring);
                SqlDataReader MyReader2;

                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Payment Added");
                while (MyReader2.Read())
                {
                }
                ConnectString.connectstring.Close();

                txtSlip.Text = ".......PET SYSTEMS.......\n\nDate:" + paymentDate + "\nOrder Cost: R" + ConnectString.PaymentCost + "\nOrder Vat: R" + PaymentVat + "\nAmount Recieved: R" + AmountRecieved + "\nPayment Type: " + cbPayment.Text + "\nChange: R" + PaymentChange;
            }
            catch
            {
                MessageBox.Show("Please enter a valid amount recieved");
            }
        }
    }
}
