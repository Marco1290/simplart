using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplart.ArtistView
{
    public partial class fv_stats_artists : Form
    {
        public fv_stats_artists()
        {
            InitializeComponent();
        }

        private void fillChart()
        {
            //AddXY value in chart1 in series named as Salary  
            cht_nbventes.Series["nb. ventes"].Points.AddXY("Janvier 2019", "10000");
            cht_nbventes.Series["nb. ventes"].Points.AddXY("Février 2019", "8000");
            cht_nbventes.Series["nb. ventes"].Points.AddXY("Mars 2019", "7000");
            cht_nbventes.Series["nb. ventes"].Points.AddXY("Avril 2019", "10000");
            cht_nbventes.Series["nb. ventes"].Points.AddXY("Mai 2019", "8500");
            //chart title  
            cht_nbventes.Titles.Add("Nb. ventes par mois");
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {

            fillChart();

        }
    }
}
