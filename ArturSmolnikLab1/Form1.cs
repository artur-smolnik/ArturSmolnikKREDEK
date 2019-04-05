﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArturSmolnikLab1
{
    
    public partial class Form1 : Form
    {
        private Factors factors = new Factors();
        private ConquerredPlanets conquerredPlanets = new ConquerredPlanets();
        private ListOfRaces listOfRaces = new ListOfRaces();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            factors.ModifyPopulationByAddition(5);
            populationNumber.Text = factors.GetPopulation().ToString();

            factors.ModifyTechLevelByAddition(1);
            techLevel.Text = factors.GetTechLevel().ToString();

            PlanetsNumber.Text = conquerredPlanets.getPlanetsAmount().ToString();

            racesAmount.Text = listOfRaces.getRacesAmount().ToString();





        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button_Click(object sender, EventArgs e)
        {
            MainWorldTimer.Start();
        }

        private void populationNumberInfo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void PlanetsNumber_Click(object sender, EventArgs e)
        {

        }

        private void addPlanet_Click(object sender, EventArgs e)
        {

            conquerredPlanets.addNewPlanet(new Planet());
        }

        private void techLevel_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void buttonAddRace_Click(object sender, EventArgs e)
        {
            listOfRaces.AddNewRace();
        }
    }
}
