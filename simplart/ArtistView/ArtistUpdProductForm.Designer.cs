namespace simplart.ArtistView
{
    partial class fv_artist_upd_product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fv_artist_upd_product));
            this.lbl_category = new System.Windows.Forms.Label();
            this.cbo_category = new System.Windows.Forms.ComboBox();
            this.txt_product_pic = new System.Windows.Forms.TextBox();
            this.btn_product_pic = new System.Windows.Forms.Button();
            this.rtxt_description = new System.Windows.Forms.RichTextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.NumericUpDown();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_product_pic = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_prod_num = new System.Windows.Forms.Label();
            this.btn_updProduct = new System.Windows.Forms.Button();
            this.slaDataSet = new simplart.SlaDataSet();
            this.sLA_PRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sLA_PRODUCTSTableAdapter = new simplart.SlaDataSetTableAdapters.SLA_PRODUCTSTableAdapter();
            this.tableAdapterManager = new simplart.SlaDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLA_PRODUCTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_category
            // 
            this.lbl_category.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(599, 162);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(52, 13);
            this.lbl_category.TabIndex = 28;
            this.lbl_category.Text = "Catégorie";
            // 
            // cbo_category
            // 
            this.cbo_category.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Items.AddRange(new object[] {
            "Musique",
            "Film",
            "Sculpture"});
            this.cbo_category.Location = new System.Drawing.Point(602, 190);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(121, 21);
            this.cbo_category.TabIndex = 27;
            // 
            // txt_product_pic
            // 
            this.txt_product_pic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_product_pic.Enabled = false;
            this.txt_product_pic.Location = new System.Drawing.Point(476, 287);
            this.txt_product_pic.Name = "txt_product_pic";
            this.txt_product_pic.Size = new System.Drawing.Size(100, 20);
            this.txt_product_pic.TabIndex = 26;
            // 
            // btn_product_pic
            // 
            this.btn_product_pic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_product_pic.Location = new System.Drawing.Point(476, 313);
            this.btn_product_pic.Name = "btn_product_pic";
            this.btn_product_pic.Size = new System.Drawing.Size(75, 23);
            this.btn_product_pic.TabIndex = 25;
            this.btn_product_pic.Text = "télécharger";
            this.btn_product_pic.UseVisualStyleBackColor = true;
            // 
            // rtxt_description
            // 
            this.rtxt_description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxt_description.Location = new System.Drawing.Point(214, 287);
            this.rtxt_description.Name = "rtxt_description";
            this.rtxt_description.Size = new System.Drawing.Size(192, 96);
            this.rtxt_description.TabIndex = 24;
            this.rtxt_description.Text = "";
            // 
            // txt_price
            // 
            this.txt_price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_price.Location = new System.Drawing.Point(458, 189);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 23;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_quantity.Location = new System.Drawing.Point(343, 190);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(50, 20);
            this.txt_quantity.TabIndex = 22;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_name.Location = new System.Drawing.Point(214, 190);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 21;
            // 
            // lbl_product_pic
            // 
            this.lbl_product_pic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_product_pic.AutoSize = true;
            this.lbl_product_pic.Location = new System.Drawing.Point(473, 258);
            this.lbl_product_pic.Name = "lbl_product_pic";
            this.lbl_product_pic.Size = new System.Drawing.Size(85, 13);
            this.lbl_product_pic.TabIndex = 20;
            this.lbl_product_pic.Text = "image du produit";
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(214, 258);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(58, 13);
            this.lbl_description.TabIndex = 19;
            this.lbl_description.Text = "description";
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(455, 162);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(24, 13);
            this.lbl_price.TabIndex = 18;
            this.lbl_price.Text = "Prix";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(340, 162);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(47, 13);
            this.lbl_quantity.TabIndex = 17;
            this.lbl_quantity.Text = "Quantité";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(211, 162);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(79, 13);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Nom du produit";
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.Location = new System.Drawing.Point(250, 68);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(340, 39);
            this.lbl_title.TabIndex = 15;
            this.lbl_title.Text = "Modification produit n°";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lbl_prod_num
            // 
            this.lbl_prod_num.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_prod_num.AutoSize = true;
            this.lbl_prod_num.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_prod_num.Location = new System.Drawing.Point(596, 68);
            this.lbl_prod_num.Name = "lbl_prod_num";
            this.lbl_prod_num.Size = new System.Drawing.Size(27, 39);
            this.lbl_prod_num.TabIndex = 29;
            this.lbl_prod_num.Text = "-";
            // 
            // btn_updProduct
            // 
            this.btn_updProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_updProduct.Location = new System.Drawing.Point(602, 402);
            this.btn_updProduct.Name = "btn_updProduct";
            this.btn_updProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_updProduct.TabIndex = 30;
            this.btn_updProduct.Text = "Enregistrer";
            this.btn_updProduct.UseVisualStyleBackColor = true;
            // 
            // slaDataSet
            // 
            this.slaDataSet.DataSetName = "SlaDataSet";
            this.slaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sLA_PRODUCTSBindingSource
            // 
            this.sLA_PRODUCTSBindingSource.DataMember = "SLA_PRODUCTS";
            this.sLA_PRODUCTSBindingSource.DataSource = this.slaDataSet;
            // 
            // sLA_PRODUCTSTableAdapter
            // 
            this.sLA_PRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SLA_CATEGORIESTableAdapter = null;
            this.tableAdapterManager.SLA_ORDER_PRODUCTSTableAdapter = null;
            this.tableAdapterManager.SLA_ORDERSTableAdapter = null;
            this.tableAdapterManager.SLA_PRODUCTSTableAdapter = this.sLA_PRODUCTSTableAdapter;
            this.tableAdapterManager.SLA_USERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = simplart.SlaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fv_artist_upd_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 729);
            this.Controls.Add(this.btn_updProduct);
            this.Controls.Add(this.lbl_prod_num);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.cbo_category);
            this.Controls.Add(this.txt_product_pic);
            this.Controls.Add(this.btn_product_pic);
            this.Controls.Add(this.rtxt_description);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_product_pic);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fv_artist_upd_product";
            this.Text = "Modification d\'un produit";
            this.Load += new System.EventHandler(this.fv_artist_upd_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLA_PRODUCTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cbo_category;
        private System.Windows.Forms.TextBox txt_product_pic;
        private System.Windows.Forms.Button btn_product_pic;
        private System.Windows.Forms.RichTextBox rtxt_description;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.NumericUpDown txt_quantity;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_product_pic;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_prod_num;
        private System.Windows.Forms.Button btn_updProduct;
        private SlaDataSet slaDataSet;
        private System.Windows.Forms.BindingSource sLA_PRODUCTSBindingSource;
        private SlaDataSetTableAdapters.SLA_PRODUCTSTableAdapter sLA_PRODUCTSTableAdapter;
        private SlaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}