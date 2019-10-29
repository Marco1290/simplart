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
    public partial class Signin : Form
    {
        private Main main;
        private Signup signup;
        public Signin()
        {
            signup = new Signup();
            this.main = new Main(this);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox username = (TextBox)this.Controls["username"];
            TextBox password = (TextBox)this.Controls["password"];

            if (username.Text.Equals("artiste"))
            {
                UserAuthService.username = username.Text;
            }
            else
            {
                UserAuthService.username = "client";
            }

            main.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup.ShowDialog();
      
        }
        
    
    }
}
