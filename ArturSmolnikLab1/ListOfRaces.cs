using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    class ListOfRaces
    {
        private static List<Race> listOfRaces = new List<Race>();

        public ListOfRaces()
        {
            listOfRaces = new List<Race>();
        }

        public void AddNewRace()
        {
            listOfRaces.Add(new Race());
        }

        public int getRacesAmount() { return listOfRaces.Count; }


    }
}
