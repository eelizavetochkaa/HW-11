using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_13
{
    class Alotofbuildings
    {
        private Buildings1[] buildings;

        public Alotofbuildings()
        {
            buildings = new Buildings1[10];
        }
        

        public Buildings1 this[int index]
        {
            get { return buildings[index]; }
            set { buildings[index] = value; }
        }


    }
}
