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
        private Factors factors = new Factors();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            factors.ModifyPopulationByAddition(5);
            populationNumber.Text = factors.GetPopulation().ToString();
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
    }
}
