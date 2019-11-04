namespace simplart
{
    partial class fv_create_product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fv_create_product));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_product_pic = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.rtxt_description = new System.Windows.Forms.RichTextBox();
            this.btn_product_pic = new System.Windows.Forms.Button();
            this.txt_product_pic = new System.Windows.Forms.TextBox();
            this.cbo_category = new System.Windows.Forms.ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.lbl_error_msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.Location = new System.Drawing.Point(336, 43);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(271, 39);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Ajouter un produit";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(238, 137);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(79, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Nom du produit";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(367, 137);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(47, 13);
            this.lbl_quantity.TabIndex = 3;
            this.lbl_quantity.Text = "Quantité";
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(482, 137);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(24, 13);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Prix";
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(241, 233);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(58, 13);
            this.lbl_description.TabIndex = 5;
            this.lbl_description.Text = "description";
            // 
            // lbl_product_pic
            // 
            this.lbl_product_pic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_product_pic.AutoSize = true;
            this.lbl_product_pic.Location = new System.Drawing.Point(500, 233);
            this.lbl_product_pic.Name = "lbl_product_pic";
            this.lbl_product_pic.Size = new System.Drawing.Size(85, 13);
            this.lbl_product_pic.TabIndex = 6;
            this.lbl_product_pic.Text = "image du produit";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_name.Location = new System.Drawing.Point(241, 165);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 7;
            // 
            // nud_quantity
            // 
            this.nud_quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nud_quantity.Location = new System.Drawing.Point(370, 165);
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(50, 20);
            this.nud_quantity.TabIndex = 8;
            // 
            // txt_price
            // 
            this.txt_price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_price.Location = new System.Drawing.Point(485, 164);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 9;
            // 
            // rtxt_description
            // 
            this.rtxt_description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxt_description.Location = new System.Drawing.Point(241, 262);
            this.rtxt_description.Name = "rtxt_description";
            this.rtxt_description.Size = new System.Drawing.Size(192, 96);
            this.rtxt_description.TabIndex = 10;
            this.rtxt_description.Text = "";
            // 
            // btn_product_pic
            // 
            this.btn_product_pic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_product_pic.Location = new System.Drawing.Point(503, 288);
            this.btn_product_pic.Name = "btn_product_pic";
            this.btn_product_pic.Size = new System.Drawing.Size(75, 23);
            this.btn_product_pic.TabIndex = 11;
            this.btn_product_pic.Text = "télécharger";
            this.btn_product_pic.UseVisualStyleBackColor = true;
            this.btn_product_pic.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_product_pic
            // 
            this.txt_product_pic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_product_pic.Enabled = false;
            this.txt_product_pic.Location = new System.Drawing.Point(503, 262);
            this.txt_product_pic.Name = "txt_product_pic";
            this.txt_product_pic.Size = new System.Drawing.Size(100, 20);
            this.txt_product_pic.TabIndex = 12;
            // 
            // cbo_category
            // 
            this.cbo_category.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Items.AddRange(new object[] {
            "Musique",
            "Film",
            "Sculpture"});
            this.cbo_category.Location = new System.Drawing.Point(629, 165);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(121, 21);
            this.cbo_category.TabIndex = 13;
            // 
            // lbl_category
            // 
            this.lbl_category.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(626, 137);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(52, 13);
            this.lbl_category.TabIndex = 14;
            this.lbl_category.Text = "Catégorie";
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_addProduct.Location = new System.Drawing.Point(629, 388);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_addProduct.TabIndex = 15;
            this.btn_addProduct.Text = "Enregistrer";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // lbl_error_msg
            // 
            this.lbl_error_msg.AutoSize = true;
            this.lbl_error_msg.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_error_msg.Location = new System.Drawing.Point(368, 106);
            this.lbl_error_msg.Name = "lbl_error_msg";
            this.lbl_error_msg.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_msg.TabIndex = 16;
            // 
            // fv_create_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.lbl_error_msg);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.cbo_category);
            this.Controls.Add(this.txt_product_pic);
            this.Controls.Add(this.btn_product_pic);
            this.Controls.Add(this.rtxt_description);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.nud_quantity);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_product_pic);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fv_create_product";
            this.Text = "Ajouter un produit";
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_product_pic;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.RichTextBox rtxt_description;
        private System.Windows.Forms.Button btn_product_pic;
        private System.Windows.Forms.TextBox txt_product_pic;
        private System.Windows.Forms.ComboBox cbo_category;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Label lbl_error_msg;
    }
}