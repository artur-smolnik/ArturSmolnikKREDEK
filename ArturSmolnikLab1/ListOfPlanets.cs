using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    /// <summary>
    /// This class is in charge of conqurred planets 
    /// </summary>
    class ListOfPlanets
    {
        private static List<Planet> listOfPlanets;
        private Random random;
   
        public ListOfPlanets()
        {            
            listOfPlanets  = new List<Planet>();
            listOfPlanets.Add(new Planet());
            random = new Random();
        }
        /// <summary>
        /// Returns numer of conquerred planets
        /// </summary>
        /// <returns>int</returns>
        public int getPlanetsAmount()
        {
            return listOfPlanets.Count;
        }
        /// <summary>
        /// Returns last  conquerred planet
        /// </summary>
        /// <returns>Planet</returns>
        public Planet getCurrentPlanet()
        {            
            return listOfPlanets[listOfPlanets.Count - 1];
        }
        /// <summary>
        /// Adds new planet to list
        /// </summary>
        public void AddNewPlanet()
        {
            listOfPlanets.Add(new Planet());
        }        
    }
}
