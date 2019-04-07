using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{   
     /// <summary>
     /// This class provides disaster aspect 
     /// </summary>
    class Disaster
    {
       
        private Random random;
        private ListOfPlanets listOfPlanets;
        private Factors factors;
        public Disaster(ListOfPlanets listOfPlanets, Factors factors)
        {
            random = new Random();
            this.factors = factors;
            this.listOfPlanets = listOfPlanets;
        }

        /// <summary>
        /// Function imitate random occurence of famine on each planet at the same time
        /// When occurs, TechLevel decreases by choosen number of points
        /// and whole population decreases by 0-90%
        /// </summary>
        /// <returns>bool</returns>
        public bool Famine()
        {
            if (random.Next(0, 80) == 0 && listOfPlanets.getPlanetsAmount()>4)
            {
                for(int i =0; i < listOfPlanets.getPlanetsAmount(); i++)
                {                    
                    listOfPlanets.getCurrentPlanet().SetInhabitants((((double)random.Next(0, 10)) / (double)10) * listOfPlanets.getCurrentPlanet().getInhabitants());
                }
                factors.ModifyTechLevelByAddition(-2000);
                return true;
            }

            return false;
        }

    }
}
