﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace PETSystem
{
    public partial class UpdateInstructor : Form
    {
      
        SqlDataAdapter DA;
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        bool valid4 = false;
        bool valid5 = false;
        bool valid6 = false;
        string InstructorID;
        string NameId;
        string SurnameId;
        string emailId;
        string phoneNumberId;
        string Genderid;
        string titleid;
        DateTime endOfTime;
        Timer t;
        ErrorHandle EH = new ErrorHandle();
        public UpdateInstructor()
        {
            InitializeComponent();
            
           
            
        }

        public UpdateInstructor(string name, string surname, string email, string phoneN, string Gender, string TitleI)
        {
            InitializeComponent();
            NameId = name;

            SurnameId = surname;
            emailId = email;
            phoneNumberId = phoneN;
            Genderid = Gender;
            titleid = TitleI;
            txtEmail.Text = emailId;
            txtName.Text = NameId;
            txtSurname.Text = SurnameId;
            txtPhoneNumber.Text = phoneNumberId;
            DataTable DT = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
            DA = new SqlDataAdapter(Fill);
            DA.Fill(DT);

            ConnectString.connectstring.Close();
            cmbGender.Items.Clear();
            cmbTitle.Items.Clear();
            string query1 = "SELECT GenderName FROM Gender ";
            DataTable DT1 = new DataTable();
            ConnectString.connectstring.Open();
            SqlCommand cmd = new SqlCommand(query1, ConnectString.connectstring);
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT1);
            foreach (DataRow dr in DT1.Rows)
            {
                cmbGender.Items.Add(dr["GenderName"]).ToString();
            }
            string query2 = "SELECT TitleName FROM Title ";
            DataTable DT2 = new DataTable();

            SqlCommand cmd2 = new SqlCommand(query2, ConnectString.connectstring);
            DA = new SqlDataAdapter(cmd2);
            DA.Fill(DT2);
            foreach (DataRow dr in DT2.Rows)
            {
                cmbTitle.Items.Add(dr["TitleName"]).ToString();
            }
            ConnectString.connectstring.Close();

            cmbGender.Text = Genderid;
            cmbTitle.Text = titleid;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Instructors UM = new Instructors();
            UM.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int GenderID = 0;
            int TitleID = 0;
            valid5 = EH.CheckEmpty(cmbGender.Text);
            valid6 = EH.CheckEmpty(cmbTitle.Text);
            if (valid1 && valid2 && valid3 && valid4 && valid5 && valid6)
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to Update this instructor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (answer == DialogResult.Yes)
                {
                    //This is my update query in which i am taking input from the user through windows forms and update the record.  
                    string query1 = "SELECT GenderID FROM Gender WHERE GenderName ='" + cmbGender.Text + "'";
                    SqlCommand MyCommand1 = new SqlCommand(query1, ConnectString.connectstring);
                    SqlDataReader MyReader1;
                    ConnectString.connectstring.Open();
                    MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader1.Read())
                    {
                        GenderID = Convert.ToInt32(MyReader1["GenderID"]);
                    }
                    ConnectString.connectstring.Close();
                    string query2 = "SELECT TitleID FROM Title WHERE TitleName ='" + cmbTitle.Text + "'";
                    SqlCommand MyCommand2 = new SqlCommand(query2, ConnectString.connectstring);
                    SqlDataReader MyReader2;
                    ConnectString.connectstring.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader2.Read())
                    {
                        TitleID = Convert.ToInt32(MyReader2["TitleID"]);
                    }
                    ConnectString.connectstring.Close();
                    string Query = "UPDATE Instructor SET Name ='" + this.txtName.Text + "', Surname = '" + this.txtSurname.Text + "', Email = '" + this.txtEmail.Text + "', PhoneNumber = '" + this.txtPhoneNumber.Text + "', GenderID ='" + GenderID + "', TitleID = '" + TitleID + "' WHERE InstructorID =" + Convert.ToInt32(InstructorID) + ";";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  

                    SqlCommand MyCommand3 = new SqlCommand(Query, ConnectString.connectstring);
                    SqlDataReader MyReader3;
                    ConnectString.connectstring.Open();
                    MyReader3 = MyCommand3.ExecuteReader();
                    
                    while (MyReader3.Read())
                    {
                    }
                    ConnectString.connectstring.Close();//Connection closed here 
                    DataTable DT = new DataTable();
                    ConnectString.connectstring.Open();
                    SqlCommand Fill = new SqlCommand("SELECT * FROM Instructor", ConnectString.connectstring);
                    DA = new SqlDataAdapter(Fill);
                    DA.Fill(DT);
                    
                    ConnectString.connectstring.Close();
                    MessageBox.Show("Instructor was Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Instructor was not Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
            else
            {
                MessageBox.Show("Information given was invalid please resubmit all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




        //private void dgvInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgvInstructor.SelectedRows.Count > 0) // make sure user select at least 1 row 
        //    {
        //        InstructorID = dgvInstructor.SelectedRows[0].Cells[0].Value + string.Empty;
        //        string NameId = dgvInstructor.SelectedRows[0].Cells[1].Value + string.Empty;
        //        string SurnameId = dgvInstructor.SelectedRows[0].Cells[2].Value + string.Empty;
        //        string emailId = dgvInstructor.SelectedRows[0].Cells[3].Value + string.Empty;
        //        string phoneNumberId = dgvInstructor.SelectedRows[0].Cells[4].Value + string.Empty;
        //        string Genderid = dgvInstructor.SelectedRows[0].Cells[5].Value + string.Empty;
        //        string titleid = dgvInstructor.SelectedRows[0].Cells[6].Value + string.Empty;
        //        string query2 = "SELECT TitleName FROM Title WHERE TitleID ='" + Convert.ToInt32(titleid) + "'";
        //        SqlCommand MyCommand2 = new SqlCommand(query2, ConnectString.connectstring);
        //        SqlDataReader MyReader2;
        //        ConnectString.connectstring.Open();
        //        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

        //        while (MyReader2.Read())
        //        {
        //            titleid = MyReader2["TitleName"].ToString();
        //        }
        //        ConnectString.connectstring.Close();
        //        string query1 = "SELECT GenderName FROM Gender WHERE GenderID ='" + Convert.ToInt32(Genderid) + "'";
        //        SqlCommand MyCommand1 = new SqlCommand(query1, ConnectString.connectstring);
        //        SqlDataReader MyReader1;
        //        ConnectString.connectstring.Open();
        //        MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

        //        while (MyReader1.Read())
        //        {
        //            Genderid = MyReader1["GenderName"].ToString();
        //        }
        //        ConnectString.connectstring.Close();

        //    }
        //    }
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private void loadpicture()
        {
            cn.ConnectionString = ConnectString.DBC;
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = "Select Data From PictureTable Where Filename ='" + ConnectString.InstructorID + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cbd = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            byte[] ap = (byte[])(ds.Tables[0].Rows[0]["Data"]);
            MemoryStream ms = new MemoryStream(ap);
            pictureBox1.Image = Image.FromStream(ms);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ms.Close();
        }
        private void UpdateInstructor_Load(object sender, EventArgs e)
        {
            //Tooltips
            //Name
            ToolTip TTname = new ToolTip();
            TTname.ToolTipTitle = "Name";
            TTname.UseFading = true;
            TTname.UseAnimation = true;
            TTname.IsBalloon = true;
            TTname.SetToolTip(txtName, "Enter the instructor's Name here.");
            //Surname
            ToolTip ttSur = new ToolTip();
            ttSur.ToolTipTitle = "Surname";
            ttSur.UseFading = true;
            ttSur.UseAnimation = true;
            ttSur.IsBalloon = true;
            ttSur.SetToolTip(txtSurname, "Enter the instructor's Surnam here.");
            //email
            ToolTip TTE = new ToolTip();
            TTE.ToolTipTitle = "E-Mail";
            TTE.UseFading = true;
            TTE.UseAnimation = true;
            TTE.IsBalloon = true;
            TTE.SetToolTip(txtEmail, "Enter the instructor's E-Mail here.");
            //phonenumber
            ToolTip TTP = new ToolTip();
            TTP.ToolTipTitle = "Phone Number";
            TTP.UseFading = true;
            TTP.UseAnimation = true;
            TTP.IsBalloon = true;
            TTP.SetToolTip(txtPhoneNumber, "Enter the instructor's Phone Number here.");
            //gender
            ToolTip TTG = new ToolTip();
            TTG.ToolTipTitle = "Gender";
            TTG.UseFading = true;
            TTG.UseAnimation = true;
            TTG.IsBalloon = true;
            TTG.SetToolTip(cmbGender, "Select the instructor's Gender here.");
            //title
            ToolTip TTT = new ToolTip();
            TTT.ToolTipTitle = "Title";
            TTT.UseFading = true;
            TTT.UseAnimation = true;
            TTT.IsBalloon = true;
            TTT.SetToolTip(cmbTitle, "Select the instructor's Title here.");
            //back
            ToolTip TTB = new ToolTip();
            TTB.ToolTipTitle = "Back";
            TTB.UseFading = true;
            TTB.UseAnimation = true;
            TTB.IsBalloon = true;
            TTB.SetToolTip(btnBack, "Click here to return to the previous screen.");
            //edit image
            ToolTip TTEm = new ToolTip();
            TTEm.ToolTipTitle = "Edit Image";
            TTEm.UseFading = true;
            TTEm.UseAnimation = true;
            TTEm.IsBalloon = true;
            TTEm.SetToolTip(button1, "Click here to Edit the instructors image.");
            //update
            ToolTip TTUP = new ToolTip();
            TTUP.ToolTipTitle = "Update Instructor";
            TTUP.UseFading = true;
            TTUP.UseAnimation = true;
            TTUP.IsBalloon = true;
            TTUP.SetToolTip(btnUpdate, "Click here to Update the instructor's information\nto the information provided above.");


            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            loadpicture();
           

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            valid1 = EH.Checkstring(txtName.Text);
            bool validSQl = EH.checkForSQLInjection(txtName.Text);
            if (valid1)
            {
                valid1 = validSQl;
            }
            if (!valid1)
            {
                txtName.BackColor = Color.Red;
            }
            else
            {
                txtName.BackColor = Color.White;
            }
        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            valid2 = EH.Checkstring(txtSurname.Text);
            bool validSQl = EH.checkForSQLInjection(txtSurname.Text);
            if (valid2)
            {
                valid2 = validSQl;
            }
            if (!valid2)
            {
                txtSurname.BackColor = Color.Red;
            }
            else
            {
                txtSurname.BackColor = Color.White;
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

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            valid4 = EH.CheckphoneNum(txtPhoneNumber.Text);
            bool validSQl = EH.checkForSQLInjection(txtPhoneNumber.Text);
            if (valid4)
            {
                valid4 = validSQl;
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

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
             this.Dispose(true);
            
            ViewinstructorForm myform = new ViewinstructorForm();
            myform.ShowDialog();
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

        private void UpdateInstructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }

        private void UpdateInstructor_MouseMove(object sender, MouseEventArgs e)
        {
           //
        }
    }
}
