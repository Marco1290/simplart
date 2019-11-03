﻿namespace simplart.ClientView
{
    partial class fv_basket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fv_basket));
            this.btn_order = new System.Windows.Forms.Button();
            this.dtg_basket = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_clear_basket = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_basket)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(439, 547);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(116, 33);
            this.btn_order.TabIndex = 5;
            this.btn_order.Text = "Commander";
            this.btn_order.UseVisualStyleBackColor = true;
            // 
            // dtg_basket
            // 
            this.dtg_basket.AllowUserToAddRows = false;
            this.dtg_basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_basket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.PrixU,
            this.Quantité,
            this.PrixT});
            this.dtg_basket.Location = new System.Drawing.Point(251, 136);
            this.dtg_basket.Name = "dtg_basket";
            this.dtg_basket.ReadOnly = true;
            this.dtg_basket.Size = new System.Drawing.Size(730, 351);
            this.dtg_basket.TabIndex = 4;
            this.dtg_basket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_basket_CellContentClick);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.Location = new System.Drawing.Point(530, 45);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(174, 39);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Mon panier";
            this.lbl_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_clear_basket
            // 
            this.btn_clear_basket.Location = new System.Drawing.Point(740, 547);
            this.btn_clear_basket.Name = "btn_clear_basket";
            this.btn_clear_basket.Size = new System.Drawing.Size(107, 33);
            this.btn_clear_basket.TabIndex = 6;
            this.btn_clear_basket.Text = "Vider le panier";
            this.btn_clear_basket.UseVisualStyleBackColor = true;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom de l\'article";
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
            // PrixT
            // 
            this.PrixT.HeaderText = "Prix total";
            this.PrixT.Name = "PrixT";
            this.PrixT.ReadOnly = true;
            // 
            // fv_basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 698);
            this.Controls.Add(this.btn_clear_basket);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.dtg_basket);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fv_basket";
            this.Text = "Mon Panier";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_basket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.DataGridView dtg_basket;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_clear_basket;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixT;
    }
}