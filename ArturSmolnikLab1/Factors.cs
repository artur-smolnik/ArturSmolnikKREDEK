﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    class Factors
    {
        private double MedicineLevel;
        private double TechLevel;
        private double Population;

        public double GetMedicineLevel() { return MedicineLevel; }
        public double GetTechLevel() { return TechLevel; }
        public double GetPopulation() { return Population; }

        public Factors()
        {
            Population = 2;
        }
        public void ModifyMedicineLevelByMultiplying(double multiplier)
        {
            MedicineLevel += Math.Floor(MedicineLevel * multiplier);               
        }
        public void ModifyTechLevelByMultiplying(double multiplier)
        {
            TechLevel += Math.Floor(TechLevel * multiplier);           
        }
        public void ModifyPopulationByMultiplying(double multiplier)
        {
            Population += Math.Floor(Population * multiplier);
        }

        public void ModifyMedicineLevelByAddition(double addition)
        {
            MedicineLevel += addition;
        }
        public void ModifyTechLevelByAddition(double addition)
        {
            TechLevel += addition;
        }
        public void ModifyPopulationByAddition(double addition)
        {
            Population += addition;
        }
    }
}