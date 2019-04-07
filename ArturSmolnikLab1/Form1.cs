using System;
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
        private Disaster disaster;
        
        
        public Form1()
        {
            InitializeComponent();

            listOfPlanets = new ListOfPlanets();
            factors = new Factors(listOfPlanets);
            raceControl = new RaceControl(listOfPlanets, factors);
            warControl = new WarControl(listOfPlanets);
            colonisation = new Colonisation(listOfPlanets, factors);
            disaster = new Disaster(listOfPlanets);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            factors.ModifyTechLevelByAddition(100);
            factors.ModifyInhabitantsByAddition();

            labelPopulationNumber.Text = factors.GetPopulation().ToString();
            labelInhabitants.Text = listOfPlanets.GetCurrentPlanet().GetInhabitants().ToString();
            labelPlanetsNumber.Text = listOfPlanets.GetPlanetsAmount().ToString();
            labelTechLevel.Text = factors.GetTechLevel().ToString();
            labelRacesAmount.Text = listOfPlanets.GetCurrentPlanet().GetAmountfRaces().ToString();
            labelDensity.Text = listOfPlanets.GetCurrentPlanet().GetDensity().ToString();
            raceControl.tryTooCreateNewRace();
            warControl.tryToStartWar();
            colonisation.tryToColonize();
            disaster.Famine();
            


            
        }

        private void LabelPopulation(object sender, EventArgs e) { }
        private void LabelDensityInfo(object sender, EventArgs e) { }
        private void LabelInhabitantsInfo(object sender, EventArgs e) { }
        private void LabelInhabitants(object sender, EventArgs e) { }
        private void LabelCurrentPlanetInfo(object sender, EventArgs e) { }
        private void LabelPopulationNumberInfo(object sender, EventArgs e) { }
        private void LabelTechLevelInfo(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }
        private void LabelPlanetsNumber(object sender, EventArgs e) { }
        private void LabelTechLevel(object sender, EventArgs e) { }
        private void LabelRacesAmount(object sender, EventArgs e) { }
        private void LabelRacesAmountInfo(object sender, EventArgs e) { }
        private void LabelDensity(object sender, EventArgs e) { }

        private void ButtonSpeedUp(object sender, EventArgs e)
        {
            factors.SpeedUp();
        }

        private void ButtonSlowDown(object sender, EventArgs e)
        {
            factors.SlowDown();
        }

        private void ButtonStart(object sender, EventArgs e)
        {
            timerMainWorldTimer.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
