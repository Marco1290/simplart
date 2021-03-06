﻿namespace simplart.ClientView
{
    partial class fv_stats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fv_stats));
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_charts = new System.Windows.Forms.Panel();
            this.cht_nbventes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_charts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_nbventes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.Location = new System.Drawing.Point(342, 51);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(250, 39);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Mes statistiques";
            // 
            // pnl_charts
            // 
            this.pnl_charts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_charts.Controls.Add(this.cht_nbventes);
            this.pnl_charts.Location = new System.Drawing.Point(111, 138);
            this.pnl_charts.Name = "pnl_charts";
            this.pnl_charts.Size = new System.Drawing.Size(711, 330);
            this.pnl_charts.TabIndex = 3;
            // 
            // cht_nbventes
            // 
            chartArea1.Name = "ChartArea1";
            this.cht_nbventes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cht_nbventes.Legends.Add(legend1);
            this.cht_nbventes.Location = new System.Drawing.Point(157, 14);
            this.cht_nbventes.Name = "cht_nbventes";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "nb. ventes";
            this.cht_nbventes.Series.Add(series1);
            this.cht_nbventes.Size = new System.Drawing.Size(397, 300);
            this.cht_nbventes.TabIndex = 0;
            this.cht_nbventes.Text = "nb. ventes par mois";
            // 
            // fv_stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_charts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fv_stats";
            this.Text = "Mes Statistiques";
            this.Load += new System.EventHandler(this.StatsClientForm_Load);
            this.pnl_charts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cht_nbventes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_charts;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_nbventes;
    }
}