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
        private double PopulationMultiplier;
        private double PopulationAddition;
        private double PopulationSubtraction;


        public Factors(ListOfPlanets listOfPlanets)
        {

            this.listOfPlanets = listOfPlanets;
            PopulationMultiplier = 1.0005;
            PopulationAddition = 20000;
            PopulationSubtraction = 0;
        }        

        public double GetPopulation()
        {
            double Population = 0;
            for (int i = 0; i<listOfPlanets.getPlanetsAmount(); i++)
            {
                Population += listOfPlanets.getCurrentPlanet().GetInhabitants();   
            }
            return Population;
        }

        public double GetTechLevel() { return TechLevel; }

        public void ModifyTechLevelBySubtraction(double subtraction)
        {
            TechLevel -=subtraction;
        }

        public void ModifyTechLevelByMultiplying(double multiplier)
        {
            TechLevel += Math.Floor(TechLevel * multiplier);
        }

        public void ModifyTechLevelByAddition(double addition)
        {
            TechLevel += addition;
        }

        //------------------------------------------------------------------------------population 

        public void ModifyPopulationByMultiplying()
        {
            listOfPlanets.getCurrentPlanet().SetInhabitants(Math.Floor(listOfPlanets.getCurrentPlanet().GetInhabitants() * PopulationMultiplier));
        }


        public void ModifyPopulationByAddition()
        {
            listOfPlanets.getCurrentPlanet().SetInhabitants(Math.Floor(listOfPlanets.getCurrentPlanet().GetInhabitants() + PopulationAddition));
        }

        public void ModifyPopulationBySubtraction()
        {
            listOfPlanets.getCurrentPlanet().SetInhabitants(Math.Floor(listOfPlanets.getCurrentPlanet().GetInhabitants() - PopulationSubtraction));
        }

        //----------------------------------------------------------------setters

        public void setPopulationMultiplier(double multiplier)
        {
            PopulationMultiplier = multiplier;
        }

        public void setPopulationAddition(double addition)
        {
            PopulationAddition = addition;
        }

        public void setPopulationSubtraction(double subtraction)
        {
            PopulationSubtraction = subtraction;
        }

        public void SpeedUp()
        {
            PopulationAddition += 1000;
        }

        public void SlowDown()
        {
            PopulationAddition -= 1000;
        }
    }
}
