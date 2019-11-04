using simplart.ArtistView;
using simplart.ClientView;
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
    public partial class Main : Form
    {
        private fv_signin signin;
        public Main(fv_signin signin)
        {
            this.signin = signin;
            InitializeComponent();
            initUserComponent();
        }

        private void initUserComponent()
        {
            if (!UserAuthService.isArtist())
            {
                artistesToolStripMenuItem.Visible = false;
            }
            
        }
       

    public void RemoveText(object sender, EventArgs e)
            {
                if (txt_search.Text == "domaines,genres,artistes,titres, ...")
                {
                    txt_search.Text = "";
                  
                }
            }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text))
                txt_search.Text = "domaines,genres,artistes,titres, ...";
        }
        private void Main_Load(object sender, EventArgs e)
        {

            flp_articles_list.AutoScroll = true;

            for (int i = 0; i < 50; ++i)
            {
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

                Label lbNom = new Label();
                lbNom.AutoSize = false;
                lbNom.Text = "Test";
                lbNom.TextAlign = ContentAlignment.MiddleCenter;

                Label lbPrix = new Label();
                lbPrix.AutoSize = false;
                lbPrix.Text = "45 .-";
                lbPrix.TextAlign = ContentAlignment.MiddleCenter;

                flowLayoutPanel.Size = new Size(78, 122);

                lbNom.Size = new Size(75, 20);
                lbPrix.Size = new Size(75, 20);


                PictureBox picture = new PictureBox();
                picture.Size = new Size(78, 70);
                flowLayoutPanel.Controls.Add(picture);
                flowLayoutPanel.Controls.Add(lbNom);
                flowLayoutPanel.Controls.Add(lbPrix);
                flowLayoutPanel.Click += new EventHandler(produit_click);
                foreach (Control control in flowLayoutPanel.Controls)
                {
                    control.Click += new EventHandler(produit_click);
                }
                flp_articles_list.Controls.Add(flowLayoutPanel);
                picture.Image = simplart.Properties.Resources.bsi_toomt14;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Refresh();
            }
        }

        private void produit_click(object sender, System.EventArgs e)
        {
            new fv_product().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Voulez-vous vraiment quitter Simplart ?", "Fermer", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    signin.Dispose();
                    break;
   
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void monPanierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fv_basket panier = new fv_basket();
            panier.ShowDialog();
        }

        private void mesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fv_products listProducts = new fv_products();
            listProducts.Show();
        }

        private void mesStatistiquesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fv_stats_artists statsForm = new fv_stats_artists();
            statsForm.Show();
        }

        private void mesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArtistView.fv_orders listCommandes = new ArtistView.fv_orders();
            listCommandes.Show();
        }

        private void mesStatistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fv_stats statsClientForm = new fv_stats();
            statsClientForm.Show();
        }

        private void seDéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.signin.Show();
            this.Dispose();
        }

        private void mesCommandesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fv_client_orders client_Orders = new fv_client_orders();
            client_Orders.Show();
        }

        private void pic_search_Click(object sender, EventArgs e)
        {

        }
    }
}
