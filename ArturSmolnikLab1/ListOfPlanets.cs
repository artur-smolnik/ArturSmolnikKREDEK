﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    class ListOfPlanets
    {
        private static List<Planet> listOfPlanets = new List<Planet>();
        private Random random;

        public ListOfPlanets()
        {
           listOfPlanets  = new List<Planet>();
            random = new Random();
        }

        public int getPlanetsAmount()
        {
            return listOfPlanets.Count;
        }

        public Planet getCurrentPlanet()
        {
            return listOfPlanets[listOfPlanets.Count - 1];
        }

        public void AddNewPlanet()
        {
            listOfPlanets.Add(new Planet());
        }        
    }
}
