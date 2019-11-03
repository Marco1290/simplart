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
    public partial class fv_product : Form
    {
        public fv_product()
        {
            InitializeComponent();
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
    }
}
