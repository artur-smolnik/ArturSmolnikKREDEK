﻿using System;
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

        public Colonisation(ListOfPlanets listOfPlanets)
        {
            this.listOfPlanets = listOfPlanets;
            random = new Random();
        }


        public bool tryToColonize()
        {
            if (listOfPlanets.getCurrentPlanet().CheckIfDensityTooHigh())
            {
                if (random.Next(0, 30) == 0)
                {
                    listOfPlanets.AddNewPlanet();
                    return true;
                }
            }
            return false;
        }
    }
}
