using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
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
        public double getInhabitants()
        {
            return Inhabitants;
        }

        public int  GetDensity()
        {
            return (int)Math.Floor(Inhabitants / Area);
        }

        public bool CheckIfDensityTooHigh()
        {
            if (GetDensity() > 10) return true;
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
        public double GetArea()
        {
            return Area;
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
