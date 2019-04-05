using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    class ConquerredPlanets
    {
        private static List<Planet> ListOfPlanets = new List<Planet>();

        public ConquerredPlanets()
        {
           ListOfPlanets  = new List<Planet>();
        }

        public void addNewPlanet(Planet planet)
        {
            ListOfPlanets.Add(planet);
        }

        public int getPlanetsAmount()
        {
            return ListOfPlanets.Count;
        }
    }
}
