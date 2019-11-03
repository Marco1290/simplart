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
    public partial class fv_signin : Form
    {
        private Main main;
        private fv_signup signup;
        public fv_signin()
        {
           
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txt_username.TextLength < 1 || txt_password.TextLength < 1)
            {
                lbl_error_msg.Text = "Veuillez entrer un nom d'utilisateur et un mot de passe !";
            }

            if (txt_username.Text.Equals("artiste"))
            {
                UserAuthService.Username = txt_username.Text;
            }
            else
            {
                UserAuthService.Username = "client";
            }
            this.main = new Main(this);
            main.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup = new fv_signup();
            signup.ShowDialog();
      
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
