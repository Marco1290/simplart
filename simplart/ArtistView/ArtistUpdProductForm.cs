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
    public partial class fv_artist_upd_product : Form
    {
        private SlaDataSet.SLA_PRODUCTSRow product;

        public fv_artist_upd_product(int product_id)
        {
            product = this.sLA_PRODUCTSTableAdapter.GetDataByID(product_id).First();

            InitializeComponent();
        }


        private void init()
        {

        }
        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void sLA_PRODUCTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sLA_PRODUCTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.slaDataSet);

        }

        private void fv_artist_upd_product_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'slaDataSet.SLA_PRODUCTS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sLA_PRODUCTSTableAdapter.Fill(this.slaDataSet.SLA_PRODUCTS);

        }
    }
}
