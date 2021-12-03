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
    public partial class Form2 : Form
    {
        SolarSystemData solarSystem;
        List<Planet> planetList = new List<Planet>();
        public Form2(SolarSystemData solarSystemData)
        {
            solarSystem = solarSystemData;
            InitializeComponent();
            UpdateStarTable();
            UpdatePlanetListBox();
            UpdatePlanetStatTable(planetList[0]);
        }

        void planetListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (planetListBox.SelectedIndex < 0)
                return;

            UpdatePlanetStatTable(planetList[planetListBox.SelectedIndex]);
        }
        private void PlanetBool_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlanetListBox();
        }

        void UpdateStarTable()
        {
            starTable.Controls.Add(AddTextLabel(solarSystem.Star.Name,8));
            starTable.Controls.Add(AddTextLabel(solarSystem.Star.Type.ToString(),8));
            starTable.Controls.Add(AddTextLabel(solarSystem.Star.Temperature.ToString() + " K",8));
        }

        void UpdatePlanetListBox()
        {
            planetList.Clear();

            if(boolTerrestial.Checked)
            {
                planetList.AddRange(solarSystem.Planets.Where(p => p.Type == Planet.PlanetType.Terrestial).ToList());
            }
            if (boolDwarfPlanet.Checked)
            {
                planetList.AddRange(solarSystem.Planets.Where(p => p.Type == Planet.PlanetType.Dwarf).ToList());
            }
            if (boolGiant.Checked)
            {
                planetList.AddRange(solarSystem.Planets.Where(p => p.Type == Planet.PlanetType.Giant).ToList());
            }
            if (boolGasGiant.Checked)
            {
                planetList.AddRange(solarSystem.Planets.Where(p => p.Type == Planet.PlanetType.Gas_Giant).ToList());
            }

            planetListBox.DataSource = planetList.Select(p => p.Name).ToList();
        }

        void UpdatePlanetStatTable(Planet planet)
        {
            moonsTable.SuspendLayout(); 
            ResetStatTables();

            planetMainTitle.Text = planet.Name;
            planetTable.Controls.Add(AddTextLabel(planet.Distance() + " Gm"));
            planetTable.Controls.Add(AddTextLabel(planet.Type.ToString()));
            planetTable.Controls.Add(AddTextLabel(planet.Diameter + " km"));
            planetTable.Controls.Add(AddTextLabel(planet.RotationPeriod + " Hours"));
            planetTable.Controls.Add(AddTextLabel(planet.RevolutionPeriod + " Days"));

            foreach (var moon in planet.Moons)
            {
                moonsTable.Size += new Size(0, 32);
                moonsTable.RowCount++;
                moonsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

                moonsTable.Controls.Add(AddTextLabel(moon.Name));
                moonsTable.Controls.Add(AddTextLabel(moon.Distance().ToString() + " Mm"));
                moonsTable.Controls.Add(AddTextLabel(moon.Diameter + " km"));
                moonsTable.Controls.Add(AddTextLabel(moon.RotationPeriod + " Hours"));
                moonsTable.Controls.Add(AddTextLabel(moon.RevolutionPeriod + " Days"));
            }

            if (planet.Moons.Count > 0)
            {
                moonsTable.RowCount--;
                moonsTable.RowStyles.RemoveAt(moonsTable.RowCount - 1);
                moonsTable.Size -= new Size(0, 32);
            }

            moonsTable.ResumeLayout(false);
            moonsTable.PerformLayout();

        }

        void ResetStatTables()
        {
            planetTable.Controls.Clear();
            this.planetTable.Controls.Add(this.label7, 0, 0);
            this.planetTable.Controls.Add(this.label6, 0, 0);
            this.planetTable.Controls.Add(this.label12, 0, 0);
            this.planetTable.Controls.Add(this.label13, 0, 0);
            this.planetTable.Controls.Add(this.label14, 0, 0);
            planetTable.Refresh();

            moonsTable.Controls.Clear();
            moonsTable.Size = new Size(591, 32);
            moonsTable.RowCount = 1;
        }

        Label AddTextLabel(string text, int fontSize = 10)
        {
            Label label = new Label();
            label.Font = new Font("Ebrima", fontSize);
            label.Text = text;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }

    }
}
