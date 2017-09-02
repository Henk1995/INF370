using System;
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

        PET_DBDataContext db = new PET_DBDataContext();
        int CourseInstanceID = Client_Course_Menu.CourseClientLineID;
        int SelectedAvailableClient;
        int SelectedClientLine;

        // ek kort i manier om al die mense in di eclient table hier in twee verskillende tables te sit

        private void ViewMaintainCourseClients_Load(object sender, EventArgs e)
        {
            //Load Available Clients list
            var mLoadCourseClients = (from Client in db.Clients
                                      select Client);
            dgvClientsAvailable.DataSource = mLoadCourseClients;
            dgvClientsAvailable.Refresh();


            //Load Course Client Line

            var mLoadCourseClientLineData = (from x in db.ClientCourseLines
                                             where x.CourseID == Convert.ToInt32(CourseInstanceID)
                              select x).ToList();



            dgvClientCourseLine.DataSource = mLoadCourseClientLineData;
            dgvClientCourseLine.Refresh();
        }

        private void btnAddClientToCourse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add " + CourseInstanceID + " To the Course?");

            // get name in client where clientid = client id in couseinstanceline

            //var mStockload = (from a in db.Stocks
            //                  where a.StockID == NewID
            //                  select new
            //                  {
            //                      a.StockID,
            //                      a.StockDescription,
            //                      a.StockUnitPrice,
            //                      a.StockTypeID,
            //                  }).ToList();

            //foreach (var item in mStockload)
            //{
            //    lblStockID.Text = Convert.ToString(item.StockID);
            //    txtName.Text = item.StockDescription;
            //    txtPrice.Text = Convert.ToString(item.StockUnitPrice);
            //    getTypeID = item.StockTypeID;
            //}

            //list names in dgv of clients

        }

        private void dgvClientsAvailable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientsAvailable.SelectedCells.Count > 0)
            {
                Client mCourseClient = (Client)dgvClientsAvailable.CurrentRow.DataBoundItem;
                SelectedAvailableClient = mCourseClient.ClientID;
            }
        }

        private void dgvClientCourseLine_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientCourseLine.SelectedCells.Count > 0)
            {
                ClientCourseLine mCourseClientLine = (ClientCourseLine)dgvClientCourseLine.CurrentRow.DataBoundItem;
                SelectedClientLine = mCourseClientLine.ClientID;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Client_Course_Menu ccm = new Client_Course_Menu();
            ccm.Show();
        }
    }
}
