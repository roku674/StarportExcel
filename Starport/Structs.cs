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
            {
                this.colonyName = colonyName;
                this.formula = formula;
                this.coords = coords;
                this.distance = distance;
            }
        };
    }
}
