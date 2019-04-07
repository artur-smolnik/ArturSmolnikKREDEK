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

        //---------------------------------------------------getters
        public double GetInhabitants()
        {
            return Inhabitants;
        }

        public int  GetDensity()
        {
            return (int)Math.Floor(Inhabitants / Area);
        }

        public int GetAmountfRaces()
        {
            return AmountOfRaces;
        }

        public double GetArea()
        {
            return Area;
        }
        //--------------------------------------------------------------------
        public bool CheckIfDensityTooHigh()
        {
            if (GetDensity() > 10) return true;
            else return false;
        }

        public void SetInhabitants(double newInhabitants)
        {
            Inhabitants = newInhabitants;
        }

        public void AddOneNewRaceToPlanet()
        {
            AmountOfRaces++;
        }        

        public void RemoveOneRaceFromPlanet()
        {
            AmountOfRaces--;
        }

        //public void setMultiplier(double multiplier)
        //{
        //    PopulationMultiplier = multiplier;
        //}

        //public void setAddition(double addition)
        //{
        //    PopulationAddition = addition;
        //}

        //public void setSubtraction(double subtraction)
        //{
        //    PopulationSubtraction = subtraction;
        //}

        //public void ModifyPopulationByMultiplying()
        //{
        //    Inhabitants += Math.Floor(Inhabitants * PopulationMultiplier);
        //}

        //public void ModifyPopulationByAddition()
        //{
        //    Inhabitants += PopulationAddition;
        //}

        

        
    } 
}
