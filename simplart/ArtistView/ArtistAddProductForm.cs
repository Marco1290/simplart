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

namespace simplart
{
    public partial class fv_create_product : Form
    {
        private fv_products fv_products;

        public fv_create_product(fv_products fv_Products)
        {
            fv_products = fv_Products;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                
                txt_product_pic.Text = openFileDialog1.FileName;
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if(txt_name.TextLength< 1  ||txt_price.TextLength < 1)
            {
                MessageBox.Show("Le prix et le nom du produit sont obligatoires !");
                return;
            }
            if (rtxt_description.TextLength < 20)
            {
                MessageBox.Show("Il faut un description de 20 caractères minimum !");
                return;
            }


            // Update the new row to the database
            sLA_PRODUCTSTableAdapter.InsertQuery(UserAuthService.getUserId(), int.Parse(cbo_category.SelectedValue.ToString()), txt_name.Text, txt_price.Text, int.Parse(nud_quantity.Text), rtxt_description.Text, txt_product_pic.Text,1);
            fv_products.updateProductDataGridView();
            MessageBox.Show("Le produit a bien été ajouté !");
            Hide();
        }

        private void fv_create_product_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'slaDataSet.SLA_CATEGORIES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sLA_CATEGORIESTableAdapter.Fill(this.slaDataSet.SLA_CATEGORIES);
            // TODO: cette ligne de code charge les données dans la table 'slaDataSet.SLA_PRODUCTS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sLA_PRODUCTSTableAdapter.Fill(this.slaDataSet.SLA_PRODUCTS);
       

        }

        private void sLA_PRODUCTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sLA_PRODUCTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.slaDataSet);

        }
    }
}
