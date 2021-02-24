using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class Program
    {

        static void Main(string[] args)
        {
            Planet Merkur = new Planet("Merkur", 0.330, 4879, 167);
            Planet Venus = new Planet("Venus", 4.87, 12104, 464);
            Planet Jorden = new Planet("Jorden", 5.97, 12756, 15);
            Planet Mars = new Planet("Mars", 0.642, 6792, -65);
            Planet Jupiter = new Planet("Jupiter", 1898, 142984, -110);
            Planet Saturn = new Planet("Saturn", 568, 120536, -140);
            Planet Uranus = new Planet("Uranus", 86.8, 51118, -195);
            Planet Neptun = new Planet("Neptun", 102, 49528, -200);
            Planet Pluto = new Planet("Pluto", 0.0146, 2370, -225);

            List<Planet> Planet = new List<Planet>() { Merkur, Jorden, Mars, Jupiter, Saturn, Uranus, Neptun };
            Planet.Add(Venus);
            Planet.Remove(Pluto); // Fjernes opg 6
            Planet.Add(Pluto); // Tilføjes opg 8

            Console.WriteLine(Planet.Count());

            foreach (Planet item in Planet)
            {
                Console.WriteLine(item.PlanetNames);
            }
            Console.ReadKey();
            Console.Clear();

            List<Planet> PlanetMeanTemperature = new List<Planet>();
            foreach (Planet item in Planet)
            {
                if (item.meanTemperatures < 0)
                {
                    PlanetMeanTemperature.Add(item);
                    Console.WriteLine(item.PlanetNames);
                }
            }
            Console.ReadKey();
            Console.Clear();

            List<Planet> PlanetDiameter = new List<Planet>();
            foreach (Planet item in Planet)
            {
                if (item.diameter > 10000 && item.diameter < 50000)
                {
                    PlanetDiameter.Add(item);
                    Console.WriteLine(item.PlanetNames);
                }
            }
            PlanetDiameter.Clear();
            Console.ReadKey();
            Console.Clear();
        }
    }
}