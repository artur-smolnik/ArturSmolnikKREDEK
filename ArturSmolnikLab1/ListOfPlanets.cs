using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    class ListOfPlanets
    {
        private static List<Planet> listOfPlanets = new List<Planet>();

        public ListOfPlanets()
        {
           listOfPlanets  = new List<Planet>();
        }

        public void addNewPlanet(Planet planet)
        {
            listOfPlanets.Add(planet);
        }

        public int getPlanetsAmount()
        {
            return listOfPlanets.Count;
        }
    }
}
