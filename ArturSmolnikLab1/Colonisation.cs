using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    class Colonisation
    {
        private ListOfPlanets listOfPlanets;
        private Random random;
        private Factors factors;

        public Colonisation(ListOfPlanets listOfPlanets, Factors factors)
        {
            this.listOfPlanets = listOfPlanets;
            this.factors = factors;
            random = new Random();
        }


        public bool tryToColonize()
        {
            if (listOfPlanets.getCurrentPlanet().CheckIfDensityTooHigh())
            {
                if (factors.GetTechLevel() >3000) { 
                    if (random.Next(0, 30) == 0)
                    {
                        factors.ModifyTechLevelBySubtraction(3000);
                        listOfPlanets.AddNewPlanet();
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
