using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    public class Planet
    {
        public Planet()
        {

        }
        public string PlanetNames { get; set; }
        public double mass { get; set; }
        public double diameter { get; set; }
        public double density { get; set; }
        public double gravity { get; set; }
        public double rotationPeriods { get; set; }
        public double lengthOfDay { get; set; }
        public double distanceOfSun { get; set; }
        public double orbitalPeriods { get; set; }
        public double orbitalVelocity { get; set; }
        public int meanTemperatures { get; set; }
        public int numberOfMoons { get; set; }
        public bool ringSystem { get; set; }
    }
}
