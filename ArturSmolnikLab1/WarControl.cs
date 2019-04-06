using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    class WarControl
    {
        private ListOfPlanets listOfPlanets;
        private Random random;

        public WarControl(ListOfPlanets listOfPlanets)
        {
            this.listOfPlanets = listOfPlanets;
            random = new Random();
        }

        public bool tryToStartWar()
        {
            if (listOfPlanets.getCurrentPlanet().CheckIfDensityTooHigh() && listOfPlanets.getCurrentPlanet().GetAmountfRaces() > 2)
            {
                if (random.Next(0, 40) == 0)
                {
                    listOfPlanets.getCurrentPlanet().RemoveOneRaceFromPlanet();
                    return true;
                }
            }
            return false;
        }
    }
}
