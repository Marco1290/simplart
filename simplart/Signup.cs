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
    public partial class fv_signup : Form
    {
        public fv_signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
            Dispose();

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            lbl_error_msg.Text = "";

            if (txt_email.TextLength < 1 || txt_password.TextLength < 1 || txt_username.TextLength < 1 )
            {
                lbl_error_msg.Text = "Tous les champs sont obligatoires !";
            }
        }
    }
}
