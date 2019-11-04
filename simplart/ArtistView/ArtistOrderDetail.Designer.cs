namespace simplart.ArtistView
{
    partial class fv_order_detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fv_order_detail));
            this.dtg_products = new System.Windows.Forms.DataGridView();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_order_id = new System.Windows.Forms.Label();
            this.btn_invoice = new System.Windows.Forms.Button();
            this.lbl_tot_price = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_client_name = new System.Windows.Forms.Label();
            this.lbl_dateCre = new System.Windows.Forms.Label();
            this.lbl_status_field = new System.Windows.Forms.Label();
            this.lbl_client_name_field = new System.Windows.Forms.Label();
            this.lbl_dateCre_field = new System.Windows.Forms.Label();
            this.lbl_tot_price_field = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_products)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_products
            // 
            this.dtg_products.AllowUserToAddRows = false;
            this.dtg_products.AllowUserToDeleteRows = false;
            this.dtg_products.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.nom,
            this.PrixU,
            this.Quantité,
            this.categorie,
            this.price});
            this.dtg_products.Location = new System.Drawing.Point(134, 215);
            this.dtg_products.Name = "dtg_products";
            this.dtg_products.ReadOnly = true;
            this.dtg_products.Size = new System.Drawing.Size(807, 235);
            this.dtg_products.TabIndex = 1;
            this.dtg_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_products_CellContentClick);
            // 
            // reference
            // 
            this.reference.HeaderText = "Référence";
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom du produit";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // PrixU
            // 
            this.PrixU.HeaderText = "Prix unitaire";
            this.PrixU.Name = "PrixU";
            this.PrixU.ReadOnly = true;
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.Name = "Quantité";
            this.Quantité.ReadOnly = true;
            // 
            // categorie
            // 
            this.categorie.HeaderText = "Catégorie";
            this.categorie.Name = "categorie";
            this.categorie.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Prix";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.Location = new System.Drawing.Point(380, 53);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(212, 39);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Commande n°";
            // 
            // lbl_order_id
            // 
            this.lbl_order_id.AutoSize = true;
            this.lbl_order_id.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_id.Location = new System.Drawing.Point(598, 57);
            this.lbl_order_id.Name = "lbl_order_id";
            this.lbl_order_id.Size = new System.Drawing.Size(123, 34);
            this.lbl_order_id.TabIndex = 3;
            this.lbl_order_id.Text = "CMD14145";
            this.lbl_order_id.UseMnemonic = false;
            // 
            // btn_invoice
            // 
            this.btn_invoice.Location = new System.Drawing.Point(802, 561);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(139, 23);
            this.btn_invoice.TabIndex = 5;
            this.btn_invoice.Text = "Générer facture";
            this.btn_invoice.UseVisualStyleBackColor = true;
            // 
            // lbl_tot_price
            // 
            this.lbl_tot_price.AutoSize = true;
            this.lbl_tot_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_tot_price.Location = new System.Drawing.Point(800, 481);
            this.lbl_tot_price.Name = "lbl_tot_price";
            this.lbl_tot_price.Size = new System.Drawing.Size(73, 18);
            this.lbl_tot_price.TabIndex = 6;
            this.lbl_tot_price.Text = "Prix total :";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(131, 158);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(41, 13);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "Statut :";
            // 
            // lbl_client_name
            // 
            this.lbl_client_name.AutoSize = true;
            this.lbl_client_name.Location = new System.Drawing.Point(412, 158);
            this.lbl_client_name.Name = "lbl_client_name";
            this.lbl_client_name.Size = new System.Drawing.Size(78, 13);
            this.lbl_client_name.TabIndex = 8;
            this.lbl_client_name.Text = "Nom du client :";
            // 
            // lbl_dateCre
            // 
            this.lbl_dateCre.AutoSize = true;
            this.lbl_dateCre.Location = new System.Drawing.Point(763, 158);
            this.lbl_dateCre.Name = "lbl_dateCre";
            this.lbl_dateCre.Size = new System.Drawing.Size(92, 13);
            this.lbl_dateCre.TabIndex = 9;
            this.lbl_dateCre.Text = "Date de création :";
            // 
            // lbl_status_field
            // 
            this.lbl_status_field.AutoSize = true;
            this.lbl_status_field.Location = new System.Drawing.Point(194, 158);
            this.lbl_status_field.Name = "lbl_status_field";
            this.lbl_status_field.Size = new System.Drawing.Size(36, 13);
            this.lbl_status_field.TabIndex = 11;
            this.lbl_status_field.Text = "Validé";
            // 
            // lbl_client_name_field
            // 
            this.lbl_client_name_field.AutoSize = true;
            this.lbl_client_name_field.Location = new System.Drawing.Point(507, 158);
            this.lbl_client_name_field.Name = "lbl_client_name_field";
            this.lbl_client_name_field.Size = new System.Drawing.Size(67, 13);
            this.lbl_client_name_field.TabIndex = 12;
            this.lbl_client_name_field.Text = "Marco Casta";
            // 
            // lbl_dateCre_field
            // 
            this.lbl_dateCre_field.AutoSize = true;
            this.lbl_dateCre_field.Location = new System.Drawing.Point(876, 158);
            this.lbl_dateCre_field.Name = "lbl_dateCre_field";
            this.lbl_dateCre_field.Size = new System.Drawing.Size(65, 13);
            this.lbl_dateCre_field.TabIndex = 13;
            this.lbl_dateCre_field.Text = "10/10/2019";
            // 
            // lbl_tot_price_field
            // 
            this.lbl_tot_price_field.AutoSize = true;
            this.lbl_tot_price_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_tot_price_field.Location = new System.Drawing.Point(876, 481);
            this.lbl_tot_price_field.Name = "lbl_tot_price_field";
            this.lbl_tot_price_field.Size = new System.Drawing.Size(67, 18);
            this.lbl_tot_price_field.TabIndex = 15;
            this.lbl_tot_price_field.Text = "120 CHF";
            // 
            // fv_order_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.lbl_tot_price_field);
            this.Controls.Add(this.lbl_dateCre_field);
            this.Controls.Add(this.lbl_client_name_field);
            this.Controls.Add(this.lbl_status_field);
            this.Controls.Add(this.lbl_dateCre);
            this.Controls.Add(this.lbl_client_name);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_tot_price);
            this.Controls.Add(this.btn_invoice);
            this.Controls.Add(this.lbl_order_id);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dtg_products);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fv_order_detail";
            this.Text = "Détail de la commande";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_products;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_order_id;
        private System.Windows.Forms.Button btn_invoice;
        private System.Windows.Forms.Label lbl_tot_price;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_client_name;
        private System.Windows.Forms.Label lbl_dateCre;
        private System.Windows.Forms.Label lbl_status_field;
        private System.Windows.Forms.Label lbl_client_name_field;
        private System.Windows.Forms.Label lbl_dateCre_field;
        private System.Windows.Forms.Label lbl_tot_price_field;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}