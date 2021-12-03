using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticaApp
{
    sealed public class Moon : Planet
    {
        public Planet Orbiting { get; set; }

        public Moon(string name, double xPos, double yPos, PlanetType planetType, double diameter, int rotationPeriod, int revolutionPeriod, Planet orbitingPlanet) : base (name,xPos,yPos,planetType,diameter,rotationPeriod,revolutionPeriod)
        {
            Orbiting = orbitingPlanet;

        }

        new public double Distance()
        {
            return Math.Sqrt(Math.Pow((Position.X - 0), 2) + Math.Pow((Position.Y - 0), 2));
        }
    }
}
