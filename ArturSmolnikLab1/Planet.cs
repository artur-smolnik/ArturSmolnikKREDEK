using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    /// <summary>
    /// Class provides the planet parameters and sets up initial parameters randomly
    /// </summary>
    class Planet
    {
        private Random random;
        private int AmountOfRaces;
        private double Area;
        private double Inhabitants;
       
        public Planet()
        {
            random = new Random();
            AmountOfRaces = 1;
            Area = random.Next(100000, 214745);
            Inhabitants = random.Next(random.Next(123450, 234560), random.Next(1000000, 2000000));            

        }

        /// <summary>
        /// Returns number of planet's inhabitants
        /// </summary>
        /// <returns>double</returns>
        public double getInhabitants()
        {
            return Inhabitants;
        }

        /// <summary>
        /// Returns planet's population density 
        /// </summary>
        /// <returns>int</returns>
        public int  getDensity()
        {
            return (int)Math.Floor(Inhabitants / Area);
        }

        /// <summary>
        /// Returns the number of races living in a given planet
        /// </summary>
        /// <returns>int</returns>
        public int getAmountfRaces()
        {
            return AmountOfRaces;
        }
        
        /// <summary>
        /// Returns planet's area
        /// </summary>
        /// <returns>double</returns>
        public double getArea()
        {
            return Area;
        }
        
        /// <summary>
        /// Returns true when population density is higher than 10
        /// </summary>
        /// <returns>bool</returns>
        public bool CheckIfDensityTooHigh()
        {
            if (getDensity() > 10) return true;
            else return false;
        }

        /// <summary>
        /// Function sets the number of inhabitants to the number given in parameter
        /// </summary>
        /// <param name="newInhabitants"></param>
        public void SetInhabitants(double newInhabitants)
        {
            Inhabitants = newInhabitants;
        }

        /// <summary>
        /// Function increments number of races living on planet
        /// </summary>
        public void AddOneNewRaceToPlanet()
        {
            AmountOfRaces++;
        }        

        /// <summary>
        /// Function decrements number of races living on planet
        /// </summary>
        public void RemoveOneRaceFromPlanet()
        {
            AmountOfRaces--;
        }        
    } 
}
