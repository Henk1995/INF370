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
    public partial class OrderReturns : Form
    {
        public OrderReturns()
        {
            InitializeComponent();
        }

        PET_DBDataContext db = new PET_DBDataContext();


        private void OrderReturns_Load(object sender, EventArgs e)
        {
            var LoadOrders = from TableOrder in db.TableOrders select TableOrder;
            dgvPrinterOrder.DataSource = LoadOrders;
            dgvPrinterOrder.Update();
        }
    }
}
