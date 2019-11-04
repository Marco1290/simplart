using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplart.ArtistView
{
    public partial class fv_orders : Form
    {
        public fv_orders()
        {
            InitializeComponent();
            dtg_orders.Rows.Add();
            dtg_orders.Rows[0].Cells[0].Value = "CMD14145";
            dtg_orders.Rows[0].Cells[1].Value = "Marco Casta";
            dtg_orders.Rows[0].Cells[2].Value = "2 x Test";
            dtg_orders.Rows[0].Cells[3].Value = "Validé";
            dtg_orders.Rows[0].Cells[4].Value = "10/10/2019";
            dtg_orders.Rows[0].Cells[5].Value = "120";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtg_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fv_order_detail fv_Order_Detail = new fv_order_detail();
            fv_Order_Detail.ShowDialog();
        }
    }
}
