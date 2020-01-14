namespace simplart.ArtistView
{
    partial class fv_orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fv_orders));
            this.lbl_title = new System.Windows.Forms.Label();
            this.dtg_orders = new System.Windows.Forms.DataGridView();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_validate_orders = new System.Windows.Forms.Button();
            this.btn_cancel_orders = new System.Windows.Forms.Button();
            this.slaDataSet = new simplart.SlaDataSet();
            this.vWORDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_ORDERSTableAdapter = new simplart.SlaDataSetTableAdapters.VW_ORDERSTableAdapter();
            this.sLAORDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sLA_ORDERSTableAdapter = new simplart.SlaDataSetTableAdapters.SLA_ORDERSTableAdapter();
            this.oRDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDUSRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWORDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLAORDERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.Location = new System.Drawing.Point(412, 51);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(253, 39);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Mes commandes";
            this.lbl_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtg_orders
            // 
            this.dtg_orders.AllowUserToAddRows = false;
            this.dtg_orders.AllowUserToDeleteRows = false;
            this.dtg_orders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtg_orders.AutoGenerateColumns = false;
            this.dtg_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oRDIDDataGridViewTextBoxColumn,
            this.oRDSTATUSDataGridViewTextBoxColumn,
            this.oRDUSRIDDataGridViewTextBoxColumn});
            this.dtg_orders.DataSource = this.sLAORDERSBindingSource;
            this.dtg_orders.Location = new System.Drawing.Point(138, 182);
            this.dtg_orders.Name = "dtg_orders";
            this.dtg_orders.ReadOnly = true;
            this.dtg_orders.Size = new System.Drawing.Size(790, 293);
            this.dtg_orders.TabIndex = 1;
            this.dtg_orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_orders_CellContentClick);
            // 
            // cbo_status
            // 
            this.cbo_status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "En attente",
            "En cours ",
            "Terminé"});
            this.cbo_status.Location = new System.Drawing.Point(147, 155);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(121, 21);
            this.cbo_status.TabIndex = 2;
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(144, 139);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(35, 13);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "Statut";
            // 
            // btn_validate_orders
            // 
            this.btn_validate_orders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_validate_orders.Location = new System.Drawing.Point(147, 519);
            this.btn_validate_orders.Name = "btn_validate_orders";
            this.btn_validate_orders.Size = new System.Drawing.Size(75, 23);
            this.btn_validate_orders.TabIndex = 4;
            this.btn_validate_orders.Text = "Valider";
            this.btn_validate_orders.UseVisualStyleBackColor = true;
            // 
            // btn_cancel_orders
            // 
            this.btn_cancel_orders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cancel_orders.Location = new System.Drawing.Point(862, 519);
            this.btn_cancel_orders.Name = "btn_cancel_orders";
            this.btn_cancel_orders.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_orders.TabIndex = 4;
            this.btn_cancel_orders.Text = "Annuler ";
            this.btn_cancel_orders.UseVisualStyleBackColor = true;
            // 
            // slaDataSet
            // 
            this.slaDataSet.DataSetName = "SlaDataSet";
            this.slaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWORDERSBindingSource
            // 
            this.vWORDERSBindingSource.DataMember = "VW_ORDERS";
            this.vWORDERSBindingSource.DataSource = this.slaDataSet;
            // 
            // vW_ORDERSTableAdapter
            // 
            this.vW_ORDERSTableAdapter.ClearBeforeFill = true;
            // 
            // sLAORDERSBindingSource
            // 
            this.sLAORDERSBindingSource.DataMember = "SLA_ORDERS";
            this.sLAORDERSBindingSource.DataSource = this.slaDataSet;
            // 
            // sLA_ORDERSTableAdapter
            // 
            this.sLA_ORDERSTableAdapter.ClearBeforeFill = true;
            // 
            // oRDIDDataGridViewTextBoxColumn
            // 
            this.oRDIDDataGridViewTextBoxColumn.DataPropertyName = "ORD_ID";
            this.oRDIDDataGridViewTextBoxColumn.HeaderText = "ORD_ID";
            this.oRDIDDataGridViewTextBoxColumn.Name = "oRDIDDataGridViewTextBoxColumn";
            this.oRDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oRDSTATUSDataGridViewTextBoxColumn
            // 
            this.oRDSTATUSDataGridViewTextBoxColumn.DataPropertyName = "ORD_STATUS";
            this.oRDSTATUSDataGridViewTextBoxColumn.HeaderText = "ORD_STATUS";
            this.oRDSTATUSDataGridViewTextBoxColumn.Name = "oRDSTATUSDataGridViewTextBoxColumn";
            this.oRDSTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oRDUSRIDDataGridViewTextBoxColumn
            // 
            this.oRDUSRIDDataGridViewTextBoxColumn.DataPropertyName = "ORD_USR_ID";
            this.oRDUSRIDDataGridViewTextBoxColumn.HeaderText = "ORD_USR_ID";
            this.oRDUSRIDDataGridViewTextBoxColumn.Name = "oRDUSRIDDataGridViewTextBoxColumn";
            this.oRDUSRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fv_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.btn_cancel_orders);
            this.Controls.Add(this.btn_validate_orders);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.cbo_status);
            this.Controls.Add(this.dtg_orders);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fv_orders";
            this.Text = "Mes Commandes";
            this.Load += new System.EventHandler(this.fv_orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWORDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLAORDERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dtg_orders;
        private System.Windows.Forms.ComboBox cbo_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_validate_orders;
        private System.Windows.Forms.Button btn_cancel_orders;
        private SlaDataSet slaDataSet;
        private System.Windows.Forms.BindingSource vWORDERSBindingSource;
        private SlaDataSetTableAdapters.VW_ORDERSTableAdapter vW_ORDERSTableAdapter;
        private System.Windows.Forms.BindingSource sLAORDERSBindingSource;
        private SlaDataSetTableAdapters.SLA_ORDERSTableAdapter sLA_ORDERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDUSRIDDataGridViewTextBoxColumn;
    }
}