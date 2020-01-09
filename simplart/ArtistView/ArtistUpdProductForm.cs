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
        private fv_products fv_products;

        public fv_artist_upd_product(fv_products fv_Products,int product_id)
        {
            fv_products = fv_Products;
            InitializeComponent();
            init(product_id);
        }


        private void init(int product_id)
        {
            product = this.sLA_PRODUCTSTableAdapter.GetDataByID(product_id).First();

            txt_name.Text = product.PRD_NAME;
            txt_price.Text = product.PRD_PRICE;
            nud_quantity.Text = product.PRD_QUANTITY.ToString();
            rtxt_description.Text = product.PRD_DESCRIPTION;
            txt_product_pic.Text = product.PRD_IMAGE_PATH;
            cbo_category.SelectedValue = product.PRD_CAT_ID;


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
            // TODO: cette ligne de code charge les données dans la table 'slaDataSet1.SLA_CATEGORIES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sLA_CATEGORIESTableAdapter.Fill(this.slaDataSet1.SLA_CATEGORIES);
            // TODO: cette ligne de code charge les données dans la table 'slaDataSet.SLA_PRODUCTS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sLA_PRODUCTSTableAdapter.Fill(this.slaDataSet.SLA_PRODUCTS);

        }

        private void btn_updProduct_Click(object sender, EventArgs e)
        {
            // Update the new row to the database
            sLA_PRODUCTSTableAdapter.UpdateQuery(int.Parse(cbo_category.SelectedValue.ToString()),txt_name.Text,txt_price.Text,int.Parse(nud_quantity.Text),rtxt_description.Text,txt_product_pic.Text,product.PRD_ID);
            fv_products.updateProductDataGridView();
            MessageBox.Show("Le produit a bien été modifié !");
            Hide();
        }
    }
}
