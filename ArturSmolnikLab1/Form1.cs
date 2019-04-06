using System;
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
        private ListOfPlanets listOfPlanets;
        private Factors factors;
        private RaceControl raceControl;
        private WarControl warControl;
        private Colonisation colonisation;

        
        
        public Form1()
        {
            InitializeComponent();

            listOfPlanets = new ListOfPlanets();
            factors = new Factors(listOfPlanets);
            raceControl = new RaceControl(listOfPlanets, factors);
            warControl = new WarControl(listOfPlanets);
            colonisation = new Colonisation(listOfPlanets, factors);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            factors.ModifyTechLevelByAddition(1);
            listOfPlanets.getCurrentPlanet().ModifyPopulationByAddition(50000);

            labelPopulationNumber.Text = factors.GetPopulation().ToString();
            labelInhabitants.Text = listOfPlanets.getCurrentPlanet().getInhabitants().ToString();
            labelPlanetsNumber.Text = listOfPlanets.getPlanetsAmount().ToString();
            labelTechLevel.Text = factors.GetTechLevel().ToString();
            labelRacesAmount.Text = listOfPlanets.getCurrentPlanet().GetAmountfRaces().ToString();
            labelDensity.Text = listOfPlanets.getCurrentPlanet().GetDensity().ToString();
            raceControl.tryTooCreateNewRace();
            warControl.tryToStartWar();
            colonisation.tryToColonize();


            
        }

        private void LabelPopulation(object sender, EventArgs e)
        {
            
        }

       

        private void button_Click(object sender, EventArgs e)
        {
            timerMainWorldTimer.Start();
        }

        private void labelPopulationNumberInfo_Click(object sender, EventArgs e)
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

        //private void addPlanet_Click(object sender, EventArgs e)
        //{

        //    listOfPlanets.addNewPlanet(new Planet());
        //}

        private void techLevel_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void buttonAddRace_Click(object sender, EventArgs e)
        {
            listOfPlanets.getCurrentPlanet().AddOneNewRaceToPlanet();
        }

        private void buttonAddPlanet_Click(object sender, EventArgs e)
        {

        }

        private void labelRacesAmountInfo_Click(object sender, EventArgs e)
        {

        }

        private void labelDensity_Click(object sender, EventArgs e)
        {

        }
    }
}
