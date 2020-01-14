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

namespace simplart.ClientView
{
    public partial class fv_basket : Form
    {
        public fv_basket()
        {
            InitializeComponent();
        }


        public void addProduct(SlaDataSet.SLA_PRODUCTSRow product)
        {
            Object[] data = new Object[] {product.PRD_ID, product.PRD_NAME, product.PRD_PRICE, product.PRD_QUANTITY, (int.Parse(product.PRD_QUANTITY.ToString()) * int.Parse(product.PRD_PRICE.ToString())) };
            dtg_basket.Rows.Add(data);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtg_basket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_basket_Click(object sender, EventArgs e)
        {
            dtg_basket.Rows.Clear();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if(dtg_basket.Rows.Count <= 0)
            {
                MessageBox.Show("Le panier est vide !");
                return;
            }

            this.sLA_ORDERSTableAdapter.InsertQuery(1, UserAuthService.getUserId());
            int id = int.Parse(this.sLA_ORDERSTableAdapter.LastInsertedIdQuery().ToString());
            SlaDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter = new SlaDataSetTableAdapters.QueriesTableAdapter();

            foreach (DataGridViewRow product in dtg_basket.Rows)
            {
                
                this.sLA_ORDER_PRODUCTSTableAdapter.InsertQuery(id, int.Parse(product.Cells[0].Value.ToString()), int.Parse(product.Cells[3].Value.ToString()));
                decimal? isValid = queriesTableAdapter.PKG_ORDER_UPDATEQUANTITY(int.Parse(product.Cells[0].Value.ToString()), id);
                if(isValid != null && isValid <= 0)
                {
                    MessageBox.Show("Quantité insuffissante pour le produit "+ product.Cells[1].Value.ToString() + "!");
                    return;
                }
            }

           
            MessageBox.Show("Votre commande a bien été enregistré !");
        }

        private void sLA_ORDER_PRODUCTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sLA_ORDER_PRODUCTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.slaDataSet);

        }

        private void fv_basket_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'slaDataSet.SLA_ORDERS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sLA_ORDERSTableAdapter.Fill(this.slaDataSet.SLA_ORDERS);
            // TODO: cette ligne de code charge les données dans la table 'slaDataSet.SLA_ORDER_PRODUCTS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sLA_ORDER_PRODUCTSTableAdapter.Fill(this.slaDataSet.SLA_ORDER_PRODUCTS);

        }
    }
}
