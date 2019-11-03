namespace simplart
{
    partial class fv_products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fv_products));
            this.dtg_products = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_updProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_products)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_products
            // 
            this.dtg_products.AllowUserToAddRows = false;
            this.dtg_products.AllowUserToDeleteRows = false;
            this.dtg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.PrixU,
            this.Quantité,
            this.categorie});
            this.dtg_products.Location = new System.Drawing.Point(260, 225);
            this.dtg_products.Name = "dtg_products";
            this.dtg_products.ReadOnly = true;
            this.dtg_products.Size = new System.Drawing.Size(683, 239);
            this.dtg_products.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.Location = new System.Drawing.Point(531, 83);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(200, 39);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Mes produits";
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(260, 506);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(179, 23);
            this.btn_addProduct.TabIndex = 4;
            this.btn_addProduct.Text = "Ajouter un produit";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.button2_Click);
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
            this.Quantité.HeaderText = "Quantité en stock";
            this.Quantité.Name = "Quantité";
            this.Quantité.ReadOnly = true;
            // 
            // categorie
            // 
            this.categorie.HeaderText = "Catégorie";
            this.categorie.Name = "categorie";
            this.categorie.ReadOnly = true;
            // 
            // btn_updProduct
            // 
            this.btn_updProduct.Location = new System.Drawing.Point(786, 506);
            this.btn_updProduct.Name = "btn_updProduct";
            this.btn_updProduct.Size = new System.Drawing.Size(157, 23);
            this.btn_updProduct.TabIndex = 5;
            this.btn_updProduct.Text = "Modifier un produit";
            this.btn_updProduct.UseVisualStyleBackColor = true;
            this.btn_updProduct.Click += new System.EventHandler(this.btn_updProduct_Click);
            // 
            // fv_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 668);
            this.Controls.Add(this.btn_updProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dtg_products);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fv_products";
            this.Text = "Mes Produits";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_products;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.Button btn_updProduct;
    }
}