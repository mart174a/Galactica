using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalacticaApp
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        SolarSystemData solarSystem;
        List<Planet> pointsToShowInChart = new List<Planet>();
        List<Color> rndColors = new List<Color>();
        int daysCount = 0;

        public Form1(SolarSystemData solarSystemData)
        {
            solarSystem = solarSystemData;
            InitializeComponent();
            for(int i = 0; i < 100; i++)
            {
                rndColors.Add(Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            }
            planetList.DataSource = solarSystem.Planets.Select(p => p.Name).ToList();
            sunButton.Text = solarSystem.Star.Name;
            sunButton_Click(null,null);
            UpdateDays(1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateDays(trackBar1.Value);
            UpdateChartPoints();
        }

        private void planetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (planetList.SelectedIndex < 0)
                return;

            //Set Title
            chartTitle.Text = planetList.SelectedValue.ToString();
            //Set chart point list
            UpdateDays(1);
            pointsToShowInChart = solarSystem.Planets[planetList.SelectedIndex].Moons.Select(m => (Planet)m).ToList();
            UpdateChartPoints();
            metricLaber1.Text = "Mm";
            metricLaber2.Text = "Mm";
        }

        void UpdateChartSize(int zoomInt)
        {
            int interval = 20 * zoomInt;
            int min = -100 * zoomInt;
            int max = 100 * zoomInt;
            int majorInterval = 100 * zoomInt;
            int minorInterval = 10 * zoomInt;


            //X Axis
            chart1.ChartAreas[0].AxisX.Interval = interval;
            chart1.ChartAreas[0].AxisX.Minimum = min;
            chart1.ChartAreas[0].AxisX.Maximum = max;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = majorInterval;
            chart1.ChartAreas[0].AxisX.MinorGrid.Interval = minorInterval;

            //Y Axis
            chart1.ChartAreas[0].AxisY.Interval = interval;
            chart1.ChartAreas[0].AxisY.Minimum = min;
            chart1.ChartAreas[0].AxisY.Maximum = max;
            chart1.ChartAreas[0].AxisY.MajorGrid.Interval = majorInterval;
            chart1.ChartAreas[0].AxisY.MinorGrid.Interval = minorInterval;
        }

        void UpdateChartPoints()
        {
            int counter = 0;
            //Clear
            chart1.Series["Series1"].Points.Clear();
            nameAndPosList.Items.Clear();

            foreach (var p in pointsToShowInChart)
            {
                //Point postion and add
                var point = p.PositionAfterXDays(daysCount);
                chart1.Series["Series1"].Points.AddXY(point.X, point.Y);

                //list view 
                var lvi = new ListViewItem(p.Name + point.ToString(true));
                lvi.ForeColor = rndColors[counter];
                nameAndPosList.Items.Add(lvi);

                //Point color
                chart1.Series["Series1"].Points[counter].Color = rndColors[counter];
                chart1.Series["Series1"].Points[counter].BorderColor = Color.Black;

                //Counter increment
                counter++;
            }

            //IF 0 then nothing to show
            if (nameAndPosList.Items.Count == 0)
            {
                nameAndPosList.Items.Add(new ListViewItem("Ingen Måner at vise"));
            }

        }

        void UpdateDays(int days)
        {
            daysCount = days;
            dayCounterLabel.Text = $"Days : {daysCount}";
            yearCounterLabel.Text = $"Years : {Math.Floor(daysCount/365.00)}";

            //Set trackBar
            if (daysCount != trackBar1.Value)
            {
                if(daysCount < trackBar1.Minimum)
                {
                    trackBar1.Value =trackBar1.Minimum;
                }
                else if (daysCount > trackBar1.Maximum)
                {
                    trackBar1.Value = trackBar1.Maximum;
                }
                else
                {
                    trackBar1.Value = daysCount;
                }
            }
        }

        private void sunButton_Click(object sender, EventArgs e)
        {
            //Set Title
            chartTitle.Text = solarSystem.Star.Name.ToString();
            //Set chart point list
            pointsToShowInChart = solarSystem.Star.Planets;
            //unSelect in planet list
            UpdateDays(1);
            planetList.SelectedItem = null;
            UpdateChartPoints();
            metricLaber1.Text = "Gm";
            metricLaber2.Text = "Gm";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateDays(daysCount+(int)dayCountSpeed.Value);
            UpdateChartPoints();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void zoomSlider_Scroll(object sender, EventArgs e)
        {
            UpdateChartSize(zoomSlider.Value);
        }

    }
}




