using simplart.Services;
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
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtg_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fv_order_detail fv_Order_Detail = new fv_order_detail();
            fv_Order_Detail.ShowDialog();
        }

        private void fv_orders_Load(object sender, EventArgs e)
        {
           
            // TODO: cette ligne de code charge les données dans la table 'slaDataSet.SLA_ORDERS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sLA_ORDERSTableAdapter.FillByUser(this.slaDataSet.SLA_ORDERS, UserAuthService.getUserId());


            // TODO: cette ligne de code charge les données dans la table 'slaDataSet.VW_ORDERS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           

        }
    }
}
