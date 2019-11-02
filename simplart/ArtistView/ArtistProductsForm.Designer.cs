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
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_addProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_products)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_products
            // 
            this.dtg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.PrixU,
            this.Quantité,
            this.categorie,
            this.Action});
            this.dtg_products.Location = new System.Drawing.Point(122, 131);
            this.dtg_products.Name = "dtg_products";
            this.dtg_products.Size = new System.Drawing.Size(542, 184);
            this.dtg_products.TabIndex = 0;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom du produit";
            this.nom.Name = "nom";
            // 
            // PrixU
            // 
            this.PrixU.HeaderText = "Prix unitaire";
            this.PrixU.Name = "PrixU";
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité en stock";
            this.Quantité.Name = "Quantité";
            // 
            // categorie
            // 
            this.categorie.HeaderText = "Catégorie";
            this.categorie.Name = "categorie";
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(292, 40);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(169, 31);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Mes produits";
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(485, 354);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(179, 23);
            this.btn_addProduct.TabIndex = 4;
            this.btn_addProduct.Text = "Ajouter un produit";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // fv_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dtg_products);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fv_products";
            this.Text = "Mes produits";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
    }
}