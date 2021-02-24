using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    public class Planet
    {
        public string PlanetNames { get; set; }
        private double mass { get; set; }
        public double diameter { get; set; }
        private double density { get; set; }
        private double gravity { get; set; }
        private double rotationPeriods { get; set; }
        private double lengthOfDay { get; set; }
        private double distanceOfSun { get; set; }
        private double orbitalPeriods { get; set; }
        private double orbitalVelocity { get; set; }
        public int meanTemperatures { get; set; }
        private int numberOfMoons { get; set; }
        private bool ringSystem { get; set; }

        // Skriver ikke alle værdierne pga. at det ville blive for meget arbejde, men ideen var at alle værdierne skulle skrives som parametre
        public Planet(string PlanetNames, double mass, double diameter, int meanTemperatures)
        {
            this.PlanetNames = PlanetNames;
            this.mass = mass;
            this.diameter = diameter;
            this.meanTemperatures = meanTemperatures;
        }
    }
}
