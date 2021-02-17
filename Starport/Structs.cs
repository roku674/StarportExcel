using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarportExcel
{

    class Structs
    {
        public struct Coordinates
        {
            public int x, y;

            public Coordinates(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        };

        public struct ColonyInfo
        {
            public string colonyName, formula;
            public Coordinates coords;
            public int distance;

            public ColonyInfo(string colonyName, string formula, Coordinates coords, int distance)
            { /*
                string colonyName = null;
            string planetName = null; //K
            int pop = -1; //L Population
            int morale = 9999;// M
            string gov = null; //N government
            int treasury = -1; //O
            string pollution = null; //P
            int disastas = 0; // Q
            string pollutionRate = null; //R
            string construction = null; //S
            string research= null; //T
            string military = null; //U
            string harvesting = null; //V
            string building = null; //W
            int metal = -1; // X
            int anae= -1; // Y
            int meds= -1; // Z
            int orgs= -1; // AA
            int oil= -1; // AB
            int uri = -1; // AC
            int equi = -1; // AD
            int spice = -1; // AE
            int nukes = -1; // AF
            int cMines= -1; // AG
            int lasers= -1; // AH
            int solarShots= -1; // AI
            int solarRate = -1; //AJ
            string discovered = null; //AK
                */
                this.colonyName = colonyName;
                this.formula = formula;
                this.coords = coords;
                this.distance = distance;
            }
        };
    }
}
