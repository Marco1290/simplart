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
    public partial class fv_order_detail : Form
    {
        public fv_order_detail()
        {
            InitializeComponent();
            dtg_products.Rows.Add();
            dtg_products.Rows[0].Cells[0].Value = "PROD13141";
            dtg_products.Rows[0].Cells[1].Value = "Test";
            dtg_products.Rows[0].Cells[2].Value = "60";
            dtg_products.Rows[0].Cells[3].Value = "2";
            dtg_products.Rows[0].Cells[4].Value = "Disque";
            dtg_products.Rows[0].Cells[5].Value = "120";
        }

        private void dtg_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
