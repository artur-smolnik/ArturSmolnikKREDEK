using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    class Planet
    {
        private Random random = new Random();
        private int AmountOfRaces;
        private readonly int Area;
        private double Inhabitants;


        public Planet()
        {
            AmountOfRaces = 1;
            Area = random.Next(100000, 2147483647);
            Inhabitants = random.Next(random.Next(10, 10000), random.Next(100000, 200000));


        }
        public double getInhabitants()
        {
            return Inhabitants;
        }

        public int  GetDensity()
        {
            return (int)Inhabitants / Area;
        }

        public bool CheckIfDensityTooHigh()
        {
            if (GetDensity() > 1000) return true;
            else return false;
        }

        public int GetAmountfRaces()
        {
            return AmountOfRaces;
        }

        public void AddOneNewRaceToPlanet()
        {
            AmountOfRaces++;
        }

        public void RemoveOneRaceFromPlanet()
        {
            AmountOfRaces--;
        }

        public void ModifyPopulationByMultiplying(double multiplier)
        {
            Inhabitants += Math.Floor(Inhabitants * multiplier);
        }

        public void ModifyPopulationByAddition(double addition)
        {
            Inhabitants += addition;
        }
    } 
}
