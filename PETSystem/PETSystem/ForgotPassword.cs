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
using System.Net.Mail;
using System.Net;


namespace PETSystem
{
    public partial class ForgotPassword : Form
    {
        ErrorHandle EH = new ErrorHandle();
        bool valid1 = false;
        bool valid3 = false;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (valid3)
            {
                string Query1 = "SELECT * FROM UserTable WHERE UserName ='" + this.txtUserName.Text + "';";
                SqlCommand MyCommand = new SqlCommand(Query1, ConnectString.connectstring);
                SqlDataReader MyReader;
                SqlDataAdapter DA = new SqlDataAdapter(MyCommand);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                ConnectString.connectstring.Open();
                MyReader = MyCommand.ExecuteReader();

                if (DT.Rows.Count == 0)
                {

                    valid1 = false;
                    MessageBox.Show("The username you supplied does not exist please supply an other one");

                }
                else
                {
                    valid1 = true;
                }
                ConnectString.connectstring.Close();
                if (valid1)
                {
                    string emailA = "";
                    string password = "";




                    string query2 = "SELECT Email FROM UserTable WHERE UserName ='" + txtUserName.Text + "'";
                    SqlCommand MyCommand2 = new SqlCommand(query2, ConnectString.connectstring);
                    SqlDataReader MyReader2;
                    ConnectString.connectstring.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader2.Read())
                    {
                        emailA = MyReader2["Email"].ToString();
                    }
                    ConnectString.connectstring.Close();
                    string query3 = "SELECT UserPassword FROM UserTable WHERE UserName ='" + txtUserName.Text + "'";
                    SqlCommand MyCommand3 = new SqlCommand(query3, ConnectString.connectstring);
                    SqlDataReader MyReader3;
                    ConnectString.connectstring.Open();
                    MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader3.Read())
                    {
                        password = MyReader3["UserPassword"].ToString();
                    }
                    ConnectString.connectstring.Close();
                    using (SmtpClient client = new SmtpClient())
                    {
                        client.Host = "smtp.gmail.com";
                        client.UseDefaultCredentials = true;
                        NetworkCredential netCred = new NetworkCredential("janwilkensmalan1@gmail.com", "Wilkens123");
                        client.Credentials = netCred;
                        client.EnableSsl = true;
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        using (MailMessage mail = new MailMessage("janwilkensmalan1@gmail.com", emailA))
                        {
                            try
                            {
                                mail.Subject = "Forgot Password";
                                mail.Body = txtUserName.Text + " your password is:" + password;
                                mail.IsBodyHtml = false;
                                client.Send(mail);
                            }

                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                                if (ex.InnerException != null)
                                { MessageBox.Show("InnerException is: {0}", ex.InnerException.ToString()); }

                            }
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Username is not valid please submit a valid username");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginF UM = new LoginF();
            UM.Show();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            valid3 = EH.CheckstringNum(txtUserName.Text);
            bool validSQl = EH.checkForSQLInjection(txtUserName.Text);
            if (valid3)
            {
                valid3 = validSQl;
            }
            if (!valid3)
            {
                txtUserName.BackColor = Color.Red;
            }
            else
            {
                txtUserName.BackColor = Color.White;
            }
        }
    }
    }

