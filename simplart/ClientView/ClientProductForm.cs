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
        private Main main;

        public fv_product(Main main, int id)
        {
            this.main = main;
            SlaDataSet dataSet = new SlaDataSet();

            SlaDataSetTableAdapters.SLA_PRODUCTSTableAdapter listProducts = new SlaDataSetTableAdapters.SLA_PRODUCTSTableAdapter();
            listProducts.Fill(dataSet.SLA_PRODUCTS);
            product = listProducts.GetData().Where(p => p.PRD_ID.Equals(id)).First();

            InitializeComponent();

            lbl_product_name.Text = product.PRD_NAME;
            lbl_prd_price.Text = product.PRD_PRICE + " .-";
            rtxt_product_description.Text = product.PRD_DESCRIPTION;
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
            SlaDataSet dataSet = new SlaDataSet();
            SlaDataSet.SLA_PRODUCTSRow productModified  = dataSet.SLA_PRODUCTS.NewSLA_PRODUCTSRow();

            productModified.PRD_ID = product.PRD_ID;
            productModified.PRD_NAME = product.PRD_NAME;
            productModified.PRD_PRICE = product.PRD_PRICE;
            productModified.PRD_QUANTITY = int.Parse(nud_quantity.Text);

            main.addProductToBasket(productModified);
            main.openBasket();
            
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
