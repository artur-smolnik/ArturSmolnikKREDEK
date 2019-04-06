﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    class RaceControl
    {
        private ListOfPlanets listOfPlanets;
        private Random random;
        private Factors factors;

        public RaceControl(ListOfPlanets listOfPlanets, Factors factors)
        {
            this.listOfPlanets = listOfPlanets;
            this.factors = factors;
            random = new Random();
        }

        public bool tryTooCreateNewRace()
        {
            if(listOfPlanets.getCurrentPlanet().CheckIfDensityTooHigh())
            {
                if(random.Next(0,30)==0)
                {
                    listOfPlanets.getCurrentPlanet().AddOneNewRaceToPlanet();

                    factors.ModifyTechLevelByMultiplying(1.2);
                    
                    return true;
                }
            }
            return false;
        }

        
        
    }
}