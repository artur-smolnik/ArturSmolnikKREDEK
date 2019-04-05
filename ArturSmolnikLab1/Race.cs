using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturSmolnikLab1
{
    class Race
    {
        String RaceName;
        private bool HighIntellgence;
        private bool WarSkill;

        Random random = new Random();

        public Race()
        {            
            HighIntellgence = Convert.ToBoolean(random.Next(0, 2));
            WarSkill = Convert.ToBoolean(random.Next(0, 2));
        }       
    }
}
