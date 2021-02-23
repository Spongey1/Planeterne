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
            Planet Merkur = new Planet();
            Planet Venus = new Planet();
            Planet Jorden = new Planet();
            Planet Mars = new Planet();
            Planet Jupiter = new Planet();
            Planet Saturn = new Planet();
            Planet Uranus = new Planet();
            Planet Neptun = new Planet();
            Planet Pluto = new Planet();

            // Skriver ikke alle værdierne pga. at det ville blive for meget arbejde, men ideen var at alle værdierne skulle skrives på denne måde.
            Merkur.PlanetNames = "Merkur";
            Merkur.mass = 0.330;
            Merkur.diameter = 4879;
            Merkur.meanTemperatures = 167;

            Venus.PlanetNames = "Venus";
            Venus.mass = 4.87;
            Venus.diameter = 12104;
            Venus.meanTemperatures = 464;

            Jorden.PlanetNames = "Jorden";
            Jorden.mass = 5.97;
            Jorden.diameter = 12756;
            Jorden.meanTemperatures = 15;

            Mars.PlanetNames = "Mars";
            Mars.mass = 0.642;
            Mars.diameter = 6792;
            Mars.meanTemperatures = -65;

            Jupiter.PlanetNames = "Jupiter";
            Jupiter.mass = 1898;
            Jupiter.diameter = 142984;
            Jupiter.meanTemperatures = -110;

            Saturn.PlanetNames = "Saturn";
            Saturn.mass = 568;
            Saturn.diameter = 120536;
            Saturn.meanTemperatures = -140;

            Uranus.PlanetNames = "Uranus";
            Uranus.mass = 86.8;
            Uranus.diameter = 51118;
            Uranus.meanTemperatures = -195;

            Neptun.PlanetNames = "Neptun";
            Neptun.mass = 102;
            Neptun.diameter = 49528;
            Neptun.meanTemperatures = -200;

            Pluto.PlanetNames = "Pluto";
            Pluto.mass = 0.0146;
            Pluto.diameter = 2370;
            Pluto.meanTemperatures = -225;

            List<Planet> Planet = new List<Planet>();
            Planet.Add(Merkur);
            Planet.Add(Venus);
            Planet.Add(Jorden);
            Planet.Add(Mars);
            Planet.Add(Jupiter);
            Planet.Add(Saturn);
            Planet.Add(Uranus);
            Planet.Add(Neptun);
            Planet.Add(Pluto);
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