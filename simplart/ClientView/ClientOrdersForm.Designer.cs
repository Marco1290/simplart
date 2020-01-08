namespace simplart.ClientView
{
    partial class fv_client_orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fv_client_orders));
            this.dtg_orders = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_title = new System.Windows.Forms.Label();
            this.slaDataSet = new simplart.SlaDataSet();
            this.slaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sLAPRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sLA_PRODUCTSTableAdapter = new simplart.SlaDataSetTableAdapters.SLA_PRODUCTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLAPRODUCTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_orders
            // 
            this.dtg_orders.AllowUserToAddRows = false;
            this.dtg_orders.AllowUserToDeleteRows = false;
            this.dtg_orders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtg_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Articles,
            this.prix});
            this.dtg_orders.Location = new System.Drawing.Point(209, 150);
            this.dtg_orders.Name = "dtg_orders";
            this.dtg_orders.ReadOnly = true;
            this.dtg_orders.Size = new System.Drawing.Size(666, 350);
            this.dtg_orders.TabIndex = 3;
            this.dtg_orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_orders_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Réference";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Articles
            // 
            this.Articles.HeaderText = "Articles";
            this.Articles.Name = "Articles";
            this.Articles.ReadOnly = true;
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix total";
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.Location = new System.Drawing.Point(453, 62);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(177, 39);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Mes achats";
            // 
            // slaDataSet
            // 
            this.slaDataSet.DataSetName = "SlaDataSet";
            this.slaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // slaDataSetBindingSource
            // 
            this.slaDataSetBindingSource.DataSource = this.slaDataSet;
            this.slaDataSetBindingSource.Position = 0;
            // 
            // sLAPRODUCTSBindingSource
            // 
            this.sLAPRODUCTSBindingSource.DataMember = "SLA_PRODUCTS";
            this.sLAPRODUCTSBindingSource.DataSource = this.slaDataSetBindingSource;
            // 
            // sLA_PRODUCTSTableAdapter
            // 
            this.sLA_PRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // fv_client_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dtg_orders);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fv_client_orders";
            this.Text = "Mes Achats";
            this.Load += new System.EventHandler(this.fv_client_orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLAPRODUCTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_orders;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articles;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.BindingSource slaDataSetBindingSource;
        private SlaDataSet slaDataSet;
        private System.Windows.Forms.BindingSource sLAPRODUCTSBindingSource;
        private SlaDataSetTableAdapters.SLA_PRODUCTSTableAdapter sLA_PRODUCTSTableAdapter;
    }
}