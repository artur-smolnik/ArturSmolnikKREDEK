using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    /// <summary>
    /// This class provides support for populationNumber and TechLevel
    /// </summary>
    class Factors
    {
        /// <summary>
        /// Inhabitants growth per one cycle
        /// </summary>
        private double PopulationAddition;

        /// <summary>
        /// Global parameter 
        /// </summary>
        private double TechLevel;

        private ListOfPlanets listOfPlanets;
        


        public Factors(ListOfPlanets listOfPlanets)
        {

            this.listOfPlanets = listOfPlanets;
            PopulationAddition = 20000;
        }

        /// <summary>
        /// Returns number of whole population of all planets
        /// </summary>
        /// <returns>double</returns>
        public double GetPopulation()
        {
            double Population = 0;
            for (int i = 0; i<listOfPlanets.getPlanetsAmount(); i++)
            {
                Population += listOfPlanets.getCurrentPlanet().GetInhabitants();   
            }
            return Population;
        }

        /// <summary>
        /// Returns current TechLevel
        /// </summary>
        /// <returns>double</returns>
        public double getTechLevel() { return TechLevel; }       


        /// <summary>
        /// Function modifies TechLevel by given parameter
        /// </summary>
        /// <param name="addition"></param>
        public void ModifyTechLevelByAddition(double addition)
        {
            TechLevel += addition;
        }


       /// <summary>
       /// Function changes current amount of inhabitants by given addition factor
       /// </summary>
        public void ModifyInhabitantsByAddition()
        {
            listOfPlanets.getCurrentPlanet().SetInhabitants(Math.Floor(listOfPlanets.getCurrentPlanet().GetInhabitants() + PopulationAddition));
        }


       /// <summary>
       /// Function set how fast amount of inhabitants grows
       /// </summary>
       /// <param name="addition"></param>
        public void setPopulationAddition(double addition)
        {
            PopulationAddition = addition;
        }

        /// <summary>
        /// Function used by button SpeedUp,
        /// clicking results in incresing inhabitants growth per one cycle
        /// </summary>
        public void SpeedUp()
        {
            PopulationAddition += 1000;
        }
        /// <summary>
        /// Function used by button SlowDowno,
        /// clicking results in decreasing inhabitants drop per one cycle
        /// </summary>
        public void SlowDown()
        {
            if(PopulationAddition >=1000) PopulationAddition -= 1000;
        }
    }
}
