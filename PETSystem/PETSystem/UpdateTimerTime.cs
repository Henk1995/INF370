﻿using System;
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
    public partial class UpdateTimerTime : Form
    {
        public UpdateTimerTime()
        {
            InitializeComponent();
        }

        private void UpdateTimerTime_Load(object sender, EventArgs e)
        {
            label1.Text = " The current logout timer is set to: " + Convert.ToString(ConnectString.TimerTime) + " Minutes.";
            //Tooltips
            //select
            ToolTip TTSelect = new ToolTip();
            TTSelect.ToolTipTitle = "Select Time";
            TTSelect.UseFading = true;
            TTSelect.UseAnimation = true;
            TTSelect.IsBalloon = true;
            TTSelect.SetToolTip(numericUpDown1, "Select a time in minutes for the logout timer.");
            //Save
            ToolTip ttSave = new ToolTip();
            ttSave.ToolTipTitle = "Save";
            ttSave.UseFading = true;
            ttSave.UseAnimation = true;
            ttSave.IsBalloon = true;
            ttSave.SetToolTip(button1, "Click to save the time specified above.");
            //back
            ToolTip TTBack = new ToolTip();
            TTBack.ToolTipTitle = "Back";
            TTBack.UseFading = true;
            TTBack.UseAnimation = true;
            TTBack.IsBalloon = true;
            TTBack.SetToolTip(button2, "Click to return to the User menu.");
        }
        int newtime;
        private void button1_Click(object sender, EventArgs e)
        {


            if (Convert.ToInt32(numericUpDown1.Value) < 1)
            {
                MessageBox.Show("Please Select a valid time in minutes\nThe time must be larger than 0","Notification");
            }
            else {
                try
                {
                    newtime = Convert.ToInt32(numericUpDown1.Value);
                    string QueryStock = "UPDATE TimerTabel SET Time ='" + newtime + "' WHERE ID = 1";



                    SqlCommand ComandStock = new SqlCommand(QueryStock, ConnectString.connectstring);
                    SqlDataReader ReaderStock;
                    ConnectString.connectstring.Open();
                    ReaderStock = ComandStock.ExecuteReader();
                    MessageBox.Show("Timer Successfully Updated");
                    ConnectString.connectstring.Close();
                    ConnectString.TimerTime = newtime;
                    this.Close();
                    this.Dispose(true);
                    UserMenu myform = new UserMenu();
                    myform.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Please Select a valid time in minutes");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            UserMenu myform = new UserMenu();
            myform.ShowDialog();
        }
    }
}
