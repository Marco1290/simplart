namespace simplart
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.flp_articles_list = new System.Windows.Forms.FlowLayoutPanel();
            this.mns_primary = new System.Windows.Forms.MenuStrip();
            this.monPanierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesCommandesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mesStatistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesStatistiquesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_title = new System.Windows.Forms.Label();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.mns_primary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(803, 149);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(652, 26);
            this.txt_search.TabIndex = 0;
            this.txt_search.TabStop = false;
            this.txt_search.Text = "domaines,genres,artistes,titres, ...";
            this.txt_search.Enter += new System.EventHandler(this.RemoveText);
            this.txt_search.Leave += new System.EventHandler(this.AddText);
            // 
            // flp_articles_list
            // 
            this.flp_articles_list.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flp_articles_list.BackColor = System.Drawing.Color.SlateGray;
            this.flp_articles_list.Location = new System.Drawing.Point(76, 198);
            this.flp_articles_list.Margin = new System.Windows.Forms.Padding(2);
            this.flp_articles_list.Name = "flp_articles_list";
            this.flp_articles_list.Size = new System.Drawing.Size(1431, 600);
            this.flp_articles_list.TabIndex = 4;
            this.flp_articles_list.TabStop = true;
            this.flp_articles_list.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // mns_primary
            // 
            this.mns_primary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monPanierToolStripMenuItem,
            this.mesCommandesToolStripMenuItem1,
            this.mesStatistiquesToolStripMenuItem,
            this.artistesToolStripMenuItem,
            this.seDéconnecterToolStripMenuItem});
            this.mns_primary.Location = new System.Drawing.Point(0, 0);
            this.mns_primary.Name = "mns_primary";
            this.mns_primary.Size = new System.Drawing.Size(1526, 24);
            this.mns_primary.TabIndex = 5;
            this.mns_primary.Text = "menuStrip1";
            // 
            // monPanierToolStripMenuItem
            // 
            this.monPanierToolStripMenuItem.Name = "monPanierToolStripMenuItem";
            this.monPanierToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.monPanierToolStripMenuItem.Text = "Mon Panier";
            this.monPanierToolStripMenuItem.Click += new System.EventHandler(this.monPanierToolStripMenuItem_Click);
            // 
            // mesCommandesToolStripMenuItem1
            // 
            this.mesCommandesToolStripMenuItem1.Name = "mesCommandesToolStripMenuItem1";
            this.mesCommandesToolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.mesCommandesToolStripMenuItem1.Text = "Mes Achats";
            this.mesCommandesToolStripMenuItem1.Click += new System.EventHandler(this.mesCommandesToolStripMenuItem1_Click);
            // 
            // mesStatistiquesToolStripMenuItem
            // 
            this.mesStatistiquesToolStripMenuItem.Name = "mesStatistiquesToolStripMenuItem";
            this.mesStatistiquesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.mesStatistiquesToolStripMenuItem.Text = "Mes Statistiques";
            this.mesStatistiquesToolStripMenuItem.Click += new System.EventHandler(this.mesStatistiquesToolStripMenuItem_Click);
            // 
            // artistesToolStripMenuItem
            // 
            this.artistesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesProduitsToolStripMenuItem,
            this.mesCommandesToolStripMenuItem,
            this.mesStatistiquesToolStripMenuItem1});
            this.artistesToolStripMenuItem.Name = "artistesToolStripMenuItem";
            this.artistesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.artistesToolStripMenuItem.Text = "Artistes";
            // 
            // mesProduitsToolStripMenuItem
            // 
            this.mesProduitsToolStripMenuItem.Name = "mesProduitsToolStripMenuItem";
            this.mesProduitsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.mesProduitsToolStripMenuItem.Text = "Mes produits";
            this.mesProduitsToolStripMenuItem.Click += new System.EventHandler(this.mesProduitsToolStripMenuItem_Click);
            // 
            // mesCommandesToolStripMenuItem
            // 
            this.mesCommandesToolStripMenuItem.Name = "mesCommandesToolStripMenuItem";
            this.mesCommandesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.mesCommandesToolStripMenuItem.Text = "Mes commandes";
            this.mesCommandesToolStripMenuItem.Click += new System.EventHandler(this.mesCommandesToolStripMenuItem_Click);
            // 
            // mesStatistiquesToolStripMenuItem1
            // 
            this.mesStatistiquesToolStripMenuItem1.Name = "mesStatistiquesToolStripMenuItem1";
            this.mesStatistiquesToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.mesStatistiquesToolStripMenuItem1.Text = "Mes Statistiques";
            this.mesStatistiquesToolStripMenuItem1.Click += new System.EventHandler(this.mesStatistiquesToolStripMenuItem1_Click);
            // 
            // seDéconnecterToolStripMenuItem
            // 
            this.seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            this.seDéconnecterToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.seDéconnecterToolStripMenuItem.Text = "Se déconnecter";
            this.seDéconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDéconnecterToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Impact", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.Location = new System.Drawing.Point(711, 54);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(170, 48);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Simplart";
            // 
            // pic_search
            // 
            this.pic_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_search.Image = global::simplart.Properties.Resources.icons8_search_512;
            this.pic_search.Location = new System.Drawing.Point(1476, 149);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(31, 26);
            this.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_search.TabIndex = 9;
            this.pic_search.TabStop = false;
            this.pic_search.Click += new System.EventHandler(this.pic_search_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_logo.Image = global::simplart.Properties.Resources.logo;
            this.pic_logo.Location = new System.Drawing.Point(1417, 38);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(90, 83);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 8;
            this.pic_logo.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1526, 881);
            this.Controls.Add(this.pic_search);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.flp_articles_list);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.mns_primary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mns_primary;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Simplart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.mns_primary.ResumeLayout(false);
            this.mns_primary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.FlowLayoutPanel flp_articles_list;
        private System.Windows.Forms.MenuStrip mns_primary;
        private System.Windows.Forms.ToolStripMenuItem monPanierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesStatistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDéconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesStatistiquesToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.ToolStripMenuItem mesCommandesToolStripMenuItem1;
    }
}

