using simplart.ClientView;
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
    public partial class fv_product : Form {

        private SlaDataSet.SLA_PRODUCTSRow product;

        public fv_product(int id)
        {
            SlaDataSet dataSet = new SlaDataSet();

            SlaDataSetTableAdapters.SLA_PRODUCTSTableAdapter listProducts = new SlaDataSetTableAdapters.SLA_PRODUCTSTableAdapter();
            listProducts.Fill(dataSet.SLA_PRODUCTS);
            product = listProducts.GetData().Where(p => p.PRD_ID.Equals(id)).First();

            InitializeComponent();

            lbl_product_name.Text = product.PRD_NAME;
            lbl_prd_price.Text = product.PRD_PRICE + " .-";
            rtxt_product_description.Text = product.PRD_DESCRIPTION;
            nud_quantity.Value = product.PRD_QUANTITY;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fv_basket fv_Basket = new fv_basket();
            Dispose();
            fv_Basket.ShowDialog();
            
        }

        private void lkl_return_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dispose();
        }

        private void fv_product_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nud_quantity_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
