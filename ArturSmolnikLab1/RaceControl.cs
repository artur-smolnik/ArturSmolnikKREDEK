using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    /// <summary>
    /// Class provides function adding new races to planet
    /// </summary>
    class RaceControl
    {
        private ListOfPlanets listOfPlanets;
        private Random random;
        private Factors factors;

        public RaceControl(ListOfPlanets listOfPlanets, Factors factors)
        {
            this.listOfPlanets = listOfPlanets;
            this.factors = factors;
            random = new Random();
        }

        /// <summary>
        /// Function tries to add new race to planet when density reaches proper level and returns true when succed
        /// </summary>
        /// <returns>bool</returns>
        public bool tryTooCreateNewRace()
        {
            if(listOfPlanets.GetCurrentPlanet().CheckIfDensityTooHigh())
            {
                if(random.Next(0,3)==0)
                {
                    listOfPlanets.GetCurrentPlanet().AddOneNewRaceToPlanet();

                    factors.ModifyTechLevelByAddition(100);
                    
                    return true;
                }
            }
            return false;
        }

        
        
    }
}
