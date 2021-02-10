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
                string planetName = ""; //K
                int pop = -1; //L Population
                int morale = 9999;// M
                string gov = "Null"; //N government
                int treasury = -1; //O
                int pollution = -1; //P
                int construction = -1; //Q
                int research = -1; //R
                int military = -1; //S
                int harvesting = -1; //T
                string building = ""; //U
                int Metal = -1; // V
                int Anae = -1; // W
                int Meds = -1; // X
                int Org = -1; // Y
                int Oil = -1; // Z
                int Uri = -1; // AA
                int Equi = -1; // AB
                int Spice = -1; // AC
                int Nukes = -1; // AD
                int Cmines = -1; // AE
                int Lasers = -1; // AF
                int Solar = -1; // AG
                string researches = "";
                */
                this.colonyName = colonyName;
                this.formula = formula;
                this.coords = coords;
                this.distance = distance;
            }
        };
    }
}
