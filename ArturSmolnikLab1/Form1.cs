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
            this.Text = "SPACE CONQUER";
            listOfPlanets = new ListOfPlanets();
            factors = new Factors(listOfPlanets);
            raceControl = new RaceControl(listOfPlanets, factors);
            warControl = new WarControl(listOfPlanets);
            colonisation = new Colonisation(listOfPlanets, factors);
            disaster = new Disaster(listOfPlanets, factors);
        }

        private void timerMainTimer(object sender, EventArgs e)
        {
            //two functions below modify inhabitants number and techlevel
            factors.ModifyTechLevelByAddition(50);
            factors.ModifyInhabitantsByAddition();

            //functions below are responsible for gui and displaying stats
            labelPopulationNumber.Text = factors.GetPopulation().ToString();
            labelInhabitants.Text = listOfPlanets.getCurrentPlanet().GetInhabitants().ToString();
            labelPlanetsNumber.Text = listOfPlanets.getPlanetsAmount().ToString();
            labelTechLevel.Text = factors.getTechLevel().ToString();
            labelRacesAmount.Text = listOfPlanets.getCurrentPlanet().GetAmountfRaces().ToString();
            labelDensity.Text = listOfPlanets.getCurrentPlanet().GetDensity().ToString();
            raceControl.tryTooCreateNewRace();

            //If war occurs, then picture changes 
            if (warControl.tryToStartWar())
            {
                pictureBox.Image = Properties.Resources.battle;
                labelWorldEvent.Text = "IT'S WAR TIME!";
            }

            //If colonisation occurs, then picture changes 
            if (colonisation.tryToColonize())
            {
                pictureBox.Image = Properties.Resources.colonisation;
                labelWorldEvent.Text = "IT'S COLONISATION TIME!";
            }

            //If famine occurs, then picture changes 
            if (disaster.Famine())
            {
                pictureBox.Image = Properties.Resources.famine;
                labelWorldEvent.Text = "IT'S FAMINE TIME!";
            }   


            
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelWorldEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
