using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplart.ClientView
{
    public partial class fv_client_orders : Form
    {
        public fv_client_orders()
        {
            InitializeComponent();
        }

        private void dtg_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fv_client_orders_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'slaDataSet.SLA_PRODUCTS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sLA_PRODUCTSTableAdapter.Fill(this.slaDataSet.SLA_PRODUCTS);



        }
    }
}
