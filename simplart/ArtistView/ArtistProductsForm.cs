﻿using simplart.ArtistView;
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
    public partial class fv_products : Form
    {
        public fv_products()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fv_create_product createProduct = new fv_create_product(this);
            createProduct.ShowDialog();
        }

        private void btn_updProduct_Click(object sender, EventArgs e)
        {
            fv_artist_upd_product updateProduct = new fv_artist_upd_product(this, getIdRow());
            updateProduct.ShowDialog();
        }

        private void dtg_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void updateProductDataGridView()
        {
            this.sLA_PRODUCTSTableAdapter.FillByUser(this.slaDataSet.SLA_PRODUCTS, UserAuthService.getUserId());
        }
        private int getIdRow()
        {
            int index = dtg_products.CurrentCell.RowIndex;

            DataGridViewRow dataGridViewRow = dtg_products.Rows[index];

            return int.Parse(dataGridViewRow.Cells[0].Value.ToString());
        }

        private void btn_prd_delete_Click(object sender, EventArgs e)
        {
            
            

            SlaDataSetTableAdapters.SLA_PRODUCTSTableAdapter productsTableAdapter = new SlaDataSetTableAdapters.SLA_PRODUCTSTableAdapter();

            productsTableAdapter.DeleteQuery(getIdRow());

            updateProductDataGridView();

        }

        private void fv_products_Load(object sender, EventArgs e)
        {
            updateProductDataGridView();


        }
    }
}
