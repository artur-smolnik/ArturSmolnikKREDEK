using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    class Factors
    {
        
        private double TechLevel;
        private ListOfPlanets listOfPlanets;
        
        

        public Factors(ListOfPlanets listOfPlanets)
        {
            this.listOfPlanets = listOfPlanets;
        }        

        public double GetPopulation()
        {
            double Population = 0;
            for (int i = 0; i<listOfPlanets.getPlanetsAmount(); i++)
            {
                Population += listOfPlanets.getCurrentPlanet().getInhabitants();   
            }
            return Population;
        }

        public double GetTechLevel() { return TechLevel; }

        public void ModifyTechLevelBySubtraction(double subtraction)
        {
            TechLevel -= subtraction;
        }
        public void ModifyTechLevelByMultiplying(double multiplier)
        {
            TechLevel += Math.Floor(TechLevel * multiplier);
        }

        public void ModifyTechLevelByAddition(double addition)
        {
            TechLevel += addition;
        }


        
        //public void ModifyPopulationByMultiplying(double multiplier)
        //{
        //    Population += Math.Floor(Population * multiplier);
        //}


        //public void ModifyPopulationByAddition(double addition)
        //{
        //    Population += addition;
        //}
    }
}
