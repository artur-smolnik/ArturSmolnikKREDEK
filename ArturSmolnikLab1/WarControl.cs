using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    /// <summary>
    /// Provides function which simulates 
    /// </summary>
    class WarControl
    {
        private ListOfPlanets listOfPlanets;
        private Random random;

        public WarControl(ListOfPlanets listOfPlanets)
        {
            this.listOfPlanets = listOfPlanets;
            random = new Random();
        }

        /// <summary>
        /// Function's trying to start resulting in removing one race from the planet
        /// The execution condition is proper density higher than 10 and proper amount of races
        /// Returns bool if war took place
        /// </summary>
        /// <returns>bool</returns>
        public bool TryToStartWar()
        {
            if (listOfPlanets.getCurrentPlanet().CheckIfDensityTooHigh() && listOfPlanets.getCurrentPlanet().getAmountfRaces() > 2)
            {
                if (random.Next(0, 4) == 0)
                {
                    listOfPlanets.getCurrentPlanet().RemoveOneRaceFromPlanet();
                    return true;
                }
            }
            return false;
        }
    }
}
