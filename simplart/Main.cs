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
        private Signin signin;
        public Main(Signin signin)
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

        private void Main_Load(object sender, EventArgs e)
        {
            Control flow = ((Form)sender).Controls["flowLayoutPanel1"];
            ((FlowLayoutPanel)flow).AutoScroll = true;

            for (int i = 0; i < 10; ++i)
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
                flow.Controls.Add(flowLayoutPanel);
                picture.Image = simplart.Properties.Resources.logo;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Refresh();
            }
        }

        private void produit_click(object sender, System.EventArgs e)
        {
            new ProductView().ShowDialog();
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
            Panier panier = new Panier();
            panier.ShowDialog();
        }

        private void mesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListProducts listProducts = new ListProducts();
            listProducts.Show();
        }

        private void mesStatistiquesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StatsForm statsForm = new StatsForm();
            statsForm.Show();
        }

        private void mesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCommandes listCommandes = new ListCommandes();
            listCommandes.Show();
        }

        private void mesStatistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatsClientForm statsClientForm = new StatsClientForm();
            statsClientForm.Show();
        }
    }
}
