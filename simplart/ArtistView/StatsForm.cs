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
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void fillChart()
        {
            //AddXY value in chart1 in series named as Salary  
            chart1.Series["nb. ventes"].Points.AddXY("Janvier 2019", "10000");
            chart1.Series["nb. ventes"].Points.AddXY("Février 2019", "8000");
            chart1.Series["nb. ventes"].Points.AddXY("Mars 2019", "7000");
            chart1.Series["nb. ventes"].Points.AddXY("Avril 2019", "10000");
            chart1.Series["nb. ventes"].Points.AddXY("Mai 2019", "8500");
            //chart title  
            chart1.Titles.Add("Nb. ventes par mois");
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {

            fillChart();

        }
    }
}
