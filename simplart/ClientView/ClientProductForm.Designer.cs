namespace simplart
{
    partial class fv_product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fv_product));
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.rtxt_product_description = new System.Windows.Forms.RichTextBox();
            this.btn_addTo_basket = new System.Windows.Forms.Button();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.pic_product = new System.Windows.Forms.PictureBox();
            this.lbl_prd_price = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.Location = new System.Drawing.Point(547, 84);
            this.lbl_product_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(40, 20);
            this.lbl_product_name.TabIndex = 1;
            this.lbl_product_name.Text = "Test";
            // 
            // rtxt_product_description
            // 
            this.rtxt_product_description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxt_product_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_product_description.Location = new System.Drawing.Point(362, 156);
            this.rtxt_product_description.Margin = new System.Windows.Forms.Padding(2);
            this.rtxt_product_description.Name = "rtxt_product_description";
            this.rtxt_product_description.ReadOnly = true;
            this.rtxt_product_description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxt_product_description.Size = new System.Drawing.Size(395, 63);
            this.rtxt_product_description.TabIndex = 2;
            this.rtxt_product_description.Text = resources.GetString("rtxt_product_description.Text");
            this.rtxt_product_description.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_addTo_basket
            // 
            this.btn_addTo_basket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_addTo_basket.Location = new System.Drawing.Point(668, 299);
            this.btn_addTo_basket.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addTo_basket.Name = "btn_addTo_basket";
            this.btn_addTo_basket.Size = new System.Drawing.Size(101, 24);
            this.btn_addTo_basket.TabIndex = 3;
            this.btn_addTo_basket.Text = "Ajouter au panier";
            this.btn_addTo_basket.UseVisualStyleBackColor = true;
            this.btn_addTo_basket.Click += new System.EventHandler(this.button1_Click);
            // 
            // nud_quantity
            // 
            this.nud_quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nud_quantity.Location = new System.Drawing.Point(506, 303);
            this.nud_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(52, 20);
            this.nud_quantity.TabIndex = 4;
            this.nud_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_quantity.ValueChanged += new System.EventHandler(this.nud_quantity_ValueChanged);
            // 
            // pic_product
            // 
            this.pic_product.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_product.Image = global::simplart.Properties.Resources.bsi_toomt14;
            this.pic_product.Location = new System.Drawing.Point(76, 156);
            this.pic_product.Margin = new System.Windows.Forms.Padding(2);
            this.pic_product.Name = "pic_product";
            this.pic_product.Size = new System.Drawing.Size(163, 167);
            this.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_product.TabIndex = 0;
            this.pic_product.TabStop = false;
            // 
            // lbl_prd_price
            // 
            this.lbl_prd_price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_prd_price.AutoSize = true;
            this.lbl_prd_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_prd_price.Location = new System.Drawing.Point(359, 305);
            this.lbl_prd_price.Name = "lbl_prd_price";
            this.lbl_prd_price.Size = new System.Drawing.Size(33, 18);
            this.lbl_prd_price.TabIndex = 6;
            this.lbl_prd_price.Text = "45.-";
            this.lbl_prd_price.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(357, 276);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(24, 13);
            this.lbl_price.TabIndex = 7;
            this.lbl_price.Text = "Prix";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(503, 276);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(47, 13);
            this.lbl_quantity.TabIndex = 8;
            this.lbl_quantity.Text = "Quantité";
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(362, 130);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(60, 13);
            this.lbl_description.TabIndex = 9;
            this.lbl_description.Text = "Description";
            // 
            // fv_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_prd_price);
            this.Controls.Add(this.nud_quantity);
            this.Controls.Add(this.btn_addTo_basket);
            this.Controls.Add(this.rtxt_product_description);
            this.Controls.Add(this.lbl_product_name);
            this.Controls.Add(this.pic_product);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fv_product";
            this.Text = "Fiche du produit";
            this.Load += new System.EventHandler(this.fv_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_product;
        private System.Windows.Forms.Label lbl_product_name;
        private System.Windows.Forms.RichTextBox rtxt_product_description;
        private System.Windows.Forms.Button btn_addTo_basket;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.Label lbl_prd_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_description;
    }
}