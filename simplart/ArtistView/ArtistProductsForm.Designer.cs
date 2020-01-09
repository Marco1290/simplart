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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fv_products));
            this.dtg_products = new System.Windows.Forms.DataGridView();
            this.vWPRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slaDataSet = new simplart.SlaDataSet();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_updProduct = new System.Windows.Forms.Button();
            this.btn_prd_delete = new System.Windows.Forms.Button();
            this.sLAPRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sLA_PRODUCTSTableAdapter = new simplart.SlaDataSetTableAdapters.SLA_PRODUCTSTableAdapter();
            this.vW_PRODUCTSTableAdapter = new simplart.SlaDataSetTableAdapters.VW_PRODUCTSTableAdapter();
            this.pRDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRDUSRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRDCATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRDPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRDQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRDDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRDIMAGEPATHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRDISACTIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLAPRODUCTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_products
            // 
            this.dtg_products.AllowUserToAddRows = false;
            this.dtg_products.AllowUserToDeleteRows = false;
            this.dtg_products.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtg_products.AutoGenerateColumns = false;
            this.dtg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRDIDDataGridViewTextBoxColumn,
            this.pRDUSRIDDataGridViewTextBoxColumn,
            this.pRDCATIDDataGridViewTextBoxColumn,
            this.pRDNAMEDataGridViewTextBoxColumn,
            this.pRDPRICEDataGridViewTextBoxColumn,
            this.pRDQUANTITYDataGridViewTextBoxColumn,
            this.pRDDESCRIPTIONDataGridViewTextBoxColumn,
            this.pRDIMAGEPATHDataGridViewTextBoxColumn,
            this.pRDISACTIFDataGridViewTextBoxColumn});
            this.dtg_products.DataSource = this.sLAPRODUCTSBindingSource;
            this.dtg_products.Location = new System.Drawing.Point(161, 146);
            this.dtg_products.Name = "dtg_products";
            this.dtg_products.ReadOnly = true;
            this.dtg_products.Size = new System.Drawing.Size(758, 317);
            this.dtg_products.TabIndex = 0;
            this.dtg_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_products_CellContentClick);
            // 
            // vWPRODUCTSBindingSource
            // 
            this.vWPRODUCTSBindingSource.DataMember = "VW_PRODUCTS";
            this.vWPRODUCTSBindingSource.DataSource = this.slaDataSet;
            // 
            // slaDataSet
            // 
            this.slaDataSet.DataSetName = "SlaDataSet";
            this.slaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.Location = new System.Drawing.Point(440, 49);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(200, 39);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Mes produits";
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_addProduct.Location = new System.Drawing.Point(161, 506);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(179, 23);
            this.btn_addProduct.TabIndex = 4;
            this.btn_addProduct.Text = "Ajouter un produit";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_updProduct
            // 
            this.btn_updProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_updProduct.Location = new System.Drawing.Point(459, 506);
            this.btn_updProduct.Name = "btn_updProduct";
            this.btn_updProduct.Size = new System.Drawing.Size(157, 23);
            this.btn_updProduct.TabIndex = 5;
            this.btn_updProduct.Text = "Modifier un produit";
            this.btn_updProduct.UseVisualStyleBackColor = true;
            this.btn_updProduct.Click += new System.EventHandler(this.btn_updProduct_Click);
            // 
            // btn_prd_delete
            // 
            this.btn_prd_delete.Location = new System.Drawing.Point(757, 506);
            this.btn_prd_delete.Name = "btn_prd_delete";
            this.btn_prd_delete.Size = new System.Drawing.Size(162, 23);
            this.btn_prd_delete.TabIndex = 6;
            this.btn_prd_delete.Text = "Suprimer un produit";
            this.btn_prd_delete.UseVisualStyleBackColor = true;
            this.btn_prd_delete.Click += new System.EventHandler(this.btn_prd_delete_Click);
            // 
            // sLAPRODUCTSBindingSource
            // 
            this.sLAPRODUCTSBindingSource.DataMember = "SLA_PRODUCTS";
            this.sLAPRODUCTSBindingSource.DataSource = this.slaDataSet;
            // 
            // sLA_PRODUCTSTableAdapter
            // 
            this.sLA_PRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // vW_PRODUCTSTableAdapter
            // 
            this.vW_PRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // pRDIDDataGridViewTextBoxColumn
            // 
            this.pRDIDDataGridViewTextBoxColumn.DataPropertyName = "PRD_ID";
            this.pRDIDDataGridViewTextBoxColumn.HeaderText = "PRD_ID";
            this.pRDIDDataGridViewTextBoxColumn.Name = "pRDIDDataGridViewTextBoxColumn";
            this.pRDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRDUSRIDDataGridViewTextBoxColumn
            // 
            this.pRDUSRIDDataGridViewTextBoxColumn.DataPropertyName = "PRD_USR_ID";
            this.pRDUSRIDDataGridViewTextBoxColumn.HeaderText = "PRD_USR_ID";
            this.pRDUSRIDDataGridViewTextBoxColumn.Name = "pRDUSRIDDataGridViewTextBoxColumn";
            this.pRDUSRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRDCATIDDataGridViewTextBoxColumn
            // 
            this.pRDCATIDDataGridViewTextBoxColumn.DataPropertyName = "PRD_CAT_ID";
            this.pRDCATIDDataGridViewTextBoxColumn.HeaderText = "PRD_CAT_ID";
            this.pRDCATIDDataGridViewTextBoxColumn.Name = "pRDCATIDDataGridViewTextBoxColumn";
            this.pRDCATIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRDNAMEDataGridViewTextBoxColumn
            // 
            this.pRDNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRD_NAME";
            this.pRDNAMEDataGridViewTextBoxColumn.HeaderText = "PRD_NAME";
            this.pRDNAMEDataGridViewTextBoxColumn.Name = "pRDNAMEDataGridViewTextBoxColumn";
            this.pRDNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRDPRICEDataGridViewTextBoxColumn
            // 
            this.pRDPRICEDataGridViewTextBoxColumn.DataPropertyName = "PRD_PRICE";
            this.pRDPRICEDataGridViewTextBoxColumn.HeaderText = "PRD_PRICE";
            this.pRDPRICEDataGridViewTextBoxColumn.Name = "pRDPRICEDataGridViewTextBoxColumn";
            this.pRDPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRDQUANTITYDataGridViewTextBoxColumn
            // 
            this.pRDQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "PRD_QUANTITY";
            this.pRDQUANTITYDataGridViewTextBoxColumn.HeaderText = "PRD_QUANTITY";
            this.pRDQUANTITYDataGridViewTextBoxColumn.Name = "pRDQUANTITYDataGridViewTextBoxColumn";
            this.pRDQUANTITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRDDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.pRDDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "PRD_DESCRIPTION";
            this.pRDDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "PRD_DESCRIPTION";
            this.pRDDESCRIPTIONDataGridViewTextBoxColumn.Name = "pRDDESCRIPTIONDataGridViewTextBoxColumn";
            this.pRDDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRDIMAGEPATHDataGridViewTextBoxColumn
            // 
            this.pRDIMAGEPATHDataGridViewTextBoxColumn.DataPropertyName = "PRD_IMAGE_PATH";
            this.pRDIMAGEPATHDataGridViewTextBoxColumn.HeaderText = "PRD_IMAGE_PATH";
            this.pRDIMAGEPATHDataGridViewTextBoxColumn.Name = "pRDIMAGEPATHDataGridViewTextBoxColumn";
            this.pRDIMAGEPATHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRDISACTIFDataGridViewTextBoxColumn
            // 
            this.pRDISACTIFDataGridViewTextBoxColumn.DataPropertyName = "PRD_IS_ACTIF";
            this.pRDISACTIFDataGridViewTextBoxColumn.HeaderText = "PRD_IS_ACTIF";
            this.pRDISACTIFDataGridViewTextBoxColumn.Name = "pRDISACTIFDataGridViewTextBoxColumn";
            this.pRDISACTIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fv_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.btn_prd_delete);
            this.Controls.Add(this.btn_updProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dtg_products);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fv_products";
            this.Text = "Mes Produits";
            this.Load += new System.EventHandler(this.fv_products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLAPRODUCTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_products;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_updProduct;
        private System.Windows.Forms.Button btn_prd_delete;
        private SlaDataSet slaDataSet;
        private System.Windows.Forms.BindingSource sLAPRODUCTSBindingSource;
        private SlaDataSetTableAdapters.SLA_PRODUCTSTableAdapter sLA_PRODUCTSTableAdapter;
        private System.Windows.Forms.BindingSource vWPRODUCTSBindingSource;
        private SlaDataSetTableAdapters.VW_PRODUCTSTableAdapter vW_PRODUCTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRDUSRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRDCATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRDPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRDQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRDDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRDIMAGEPATHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRDISACTIFDataGridViewTextBoxColumn;
    }
}