﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETSystem
{
    public partial class ViewMaintainCourseClients : Form
    {
        public ViewMaintainCourseClients()
        {
            InitializeComponent();
        }
        DateTime endOfTime;
        Timer t;
        PET_DBDataContext db = new PET_DBDataContext();
        int CourseInstanceID = Client_Course_Menu.CourseClientLineID;
        int SelectedAvailableClient;
        int SelectedClientLine;
        int ClientID;

        // ek kort i manier om al die mense in di eclient table hier in twee verskillende tables te sit

        private void ViewMaintainCourseClients_Load(object sender, EventArgs e)
        {
            //Add
            ToolTip TTADD = new ToolTip();
            TTADD.ToolTipTitle = "Add";
            TTADD.UseFading = true;
            TTADD.UseAnimation = true;
            TTADD.IsBalloon = true;
            TTADD.SetToolTip(button1, "Click here to add a client from list above to course below.");
            //Remove
            ToolTip TTRE = new ToolTip();
            TTRE.ToolTipTitle = "Remove";
            TTRE.UseFading = true;
            TTRE.UseAnimation = true;
            TTRE.IsBalloon = true;
            TTRE.SetToolTip(button2, "Click here to remove a client from list below.");
            //Mainmenu
            ToolTip TTMAIN = new ToolTip();
            TTMAIN.ToolTipTitle = "Main Menu";
            TTMAIN.UseFading = true;
            TTMAIN.UseAnimation = true;
            TTMAIN.IsBalloon = true;
            TTMAIN.SetToolTip(btnMainM, "Click here to Return to the main menu");
            //Back
            ToolTip TTBACK = new ToolTip();
            TTBACK.ToolTipTitle = "Back";
            TTBACK.UseFading = true;
            TTBACK.UseAnimation = true;
            TTBACK.IsBalloon = true;
            TTBACK.SetToolTip(btnBack, "Click here to Return to the previous screen");
            //Print
            //Timer
            endOfTime = DateTime.Now.AddMinutes(ConnectString.TimerTime);
            t = new Timer() { Interval = 1000, Enabled = true };
            t.Tick += new EventHandler(timer1_Tick);
            timer1_Tick(null, null);

            //Load Available Clients list
            var mLoadCourseClients = (from Client in db.Clients
                                      select Client);
            dgvClientsAvailable.DataSource = mLoadCourseClients;
            dgvClientsAvailable.Columns[0].Visible = false;
            dgvClientsAvailable.Columns[5].Visible = false;
            dgvClientsAvailable.Columns[6].Visible = false;
            dgvClientsAvailable.Columns[7].Visible = false;
            dgvClientsAvailable.Columns[8].Visible = false;
            dgvClientsAvailable.Refresh();


            //Load Course Client Line

            RefreshDGV();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Client_Course_Menu ccm = new Client_Course_Menu();
            ccm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try {
                //Add client to course
                if (dgvClientsAvailable.SelectedRows.Count > 0)
                {

                    // get client id
                    Client _ClientInCourse = (Client)dgvClientsAvailable.CurrentRow.DataBoundItem;
                    string SelectedClientName = Convert.ToString(dgvClientsAvailable.SelectedCells[0].Value);
                    var GetClientIDToAddToCourse = (from x in db.Clients where x.ClientID == SelectedAvailableClient select x.ClientID).FirstOrDefault();

                    // add client to client course line
                    ClientCourseLine mClient = new ClientCourseLine
                    {
                        ClientID = GetClientIDToAddToCourse,
                        ResultID = 3,
                        CourseID = CourseInstanceID,
                    };

                    db.ClientCourseLines.InsertOnSubmit(mClient);
                    db.SubmitChanges();

                    MessageBox.Show("Client Added to Course", "Info;");

                    //refresh bottom dgv
                    RefreshDGV();
                    //}
                }
                else
                {
                    MessageBox.Show("Please select a row to add", "Error");
                }
            }
            
            catch
            {
                MessageBox.Show("Client already added", "Error");
            }
            RefreshDGV();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                // Remove client from course
                if (dgvClientsAvailable.SelectedCells.Count > 0)
                {
                    ClientCourseLine _ClientInCourse = (ClientCourseLine)dgvClientCourseLine.CurrentRow.DataBoundItem;
                    string SelectedClientName = Convert.ToString(dgvClientCourseLine.SelectedCells[0].Value);

                    var GetClientIDFromName = (from x in db.Clients where x.ClientName == SelectedClientName select x.ClientID).FirstOrDefault();
                    SelectedClientLine = GetClientIDFromName;

                    //Delete Selected
                    var mRemoveClientFromCourse = (from x in db.ClientCourseLines where x.ClientID == SelectedClientLine select x).First();
                    db.ClientCourseLines.DeleteOnSubmit(mRemoveClientFromCourse);
                    db.SubmitChanges();



                    MessageBox.Show("Client has been removed form the course", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a row to Remove", "Error");
                }
            }
            catch
            {
                MessageBox.Show("Please Select a row", "Error;");
                dgvClientsAvailable.ClearSelection();


            }
            RefreshDGV();

            
        }

        private void dgvClientsAvailable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientsAvailable.SelectedCells.Count > 0)
            {
                Client _Client = (Client)dgvClientsAvailable.CurrentRow.DataBoundItem;
                SelectedAvailableClient = _Client.ClientID;
            }
        }

        private void dgvClientsAvailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientCourseLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientCourseLine_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void RefreshDGV()
        {
            //dgvClientCourseLine.DataSource = null;
            

            foreach ( var x in dgvClientCourseLine.Rows)
            {
                dgvClientCourseLine.Rows.Clear();

            }
            dgvClientCourseLine.Update();
            dgvClientCourseLine.Refresh();

            //refresh DGV
            var mLoadCourseClientLineData = (from x in db.ClientCourseLines
                                             where x.CourseID == Convert.ToInt32(CourseInstanceID)
                                             select x).ToList();

            foreach (var item in mLoadCourseClientLineData)
            {
                var getClientName = (from x in db.Clients where x.ClientID == item.ClientID select x.ClientName).FirstOrDefault();
                var getResultName = (from x in db.Results where x.ResultID == item.ResultID select x.ResultName).FirstOrDefault();

                dgvClientCourseLine.Rows.Add(new object[] { getClientName, getResultName });
            }
            dgvClientCourseLine.Update();
            dgvClientCourseLine.Refresh();
        }

        private void btnMainM_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuF MM = new MainMenuF();
            MM.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Certificate could not be printed at this moment");
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

        private void ViewMaintainCourseClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }
    }
}
