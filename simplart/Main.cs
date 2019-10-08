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
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Control flow = ((Form)sender).Controls["flowLayoutPanel1"];

            for (int i = 0; i < 10; ++i)
            {
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.AutoScroll = true;
                Label lbNom = new Label();
                lbNom.Text = "Test";
                Label lbPrix = new Label();
                lbPrix.Text = "45 .-";
                flowLayoutPanel.Size = new Size(78, 122);

                lbNom.Size = new Size(78, 20);
                lbPrix.Size = new Size(78, 20);


                PictureBox picture = new PictureBox();
                picture.Size = new Size(78, 50);
                flowLayoutPanel.Controls.Add(picture);
                flowLayoutPanel.Controls.Add(lbNom);
                flowLayoutPanel.Controls.Add(lbPrix);

                flow.Controls.Add(flowLayoutPanel);
                picture.Image = simplart.Properties.Resources.logo;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Refresh();
            }
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
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
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
    }
}
