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
        private static int IdCounter = 0;
        private int PlanetId;
        private int AmountOfRaces;
        private int Area;
        private int Density;
        private int Inhabitants;
        List<Race> InhabitedRaces = new List<Race>();

        public Planet()
        {
            PlanetId = IdCounter;
            AmountOfRaces = 1;
            Area = random.Next(100000, 2147483647);
            Inhabitants = random.Next(random.Next(10, 10000), random.Next(100000, 200000));

            IdCounter++;

        }
       

    } 
}
