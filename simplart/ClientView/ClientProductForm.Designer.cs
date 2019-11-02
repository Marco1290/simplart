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
            this.lkl_return = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.Location = new System.Drawing.Point(281, 71);
            this.lbl_product_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(127, 20);
            this.lbl_product_name.TabIndex = 1;
            this.lbl_product_name.Text = "Album Al Pacioni";
            // 
            // rtxt_product_description
            // 
            this.rtxt_product_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_product_description.Location = new System.Drawing.Point(285, 109);
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
            this.btn_addTo_basket.Location = new System.Drawing.Point(512, 192);
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
            this.nud_quantity.Location = new System.Drawing.Point(343, 192);
            this.nud_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(31, 20);
            this.nud_quantity.TabIndex = 4;
            this.nud_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pic_product
            // 
            this.pic_product.Image = global::simplart.Properties.Resources.bsi_toomt14;
            this.pic_product.Location = new System.Drawing.Point(77, 71);
            this.pic_product.Margin = new System.Windows.Forms.Padding(2);
            this.pic_product.Name = "pic_product";
            this.pic_product.Size = new System.Drawing.Size(163, 167);
            this.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_product.TabIndex = 0;
            this.pic_product.TabStop = false;
            // 
            // lkl_return
            // 
            this.lkl_return.AutoSize = true;
            this.lkl_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lkl_return.Location = new System.Drawing.Point(634, 335);
            this.lkl_return.Name = "lkl_return";
            this.lkl_return.Size = new System.Drawing.Size(58, 20);
            this.lkl_return.TabIndex = 5;
            this.lkl_return.TabStop = true;
            this.lkl_return.Text = "Retour";
            // 
            // fv_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 387);
            this.Controls.Add(this.lkl_return);
            this.Controls.Add(this.nud_quantity);
            this.Controls.Add(this.btn_addTo_basket);
            this.Controls.Add(this.rtxt_product_description);
            this.Controls.Add(this.lbl_product_name);
            this.Controls.Add(this.pic_product);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fv_product";
            this.Text = "Fiche du produit";
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
        private System.Windows.Forms.LinkLabel lkl_return;
    }
}