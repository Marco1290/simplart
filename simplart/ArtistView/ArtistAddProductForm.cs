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
        public fv_create_product()
        {
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
                lbl_error_msg.Text = "Le prix et le nom du produit sont obligatoires !";
            }
            if (rtxt_description.TextLength < 20)
            {
                lbl_error_msg.Text += "\n Il faut un description de 20 caractères minimum !";
            }
        }
    }
}
