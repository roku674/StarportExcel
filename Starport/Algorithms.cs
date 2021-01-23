using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarportExcel
{
    class Algorithms
    {
        private static bool[,] galaxyMap = new bool[1000, 1000];
        public static bool[,] GalaxyMap { get => galaxyMap; set => galaxyMap = value; }

        /// <summary>
        /// structure for the x,y coordinates of a system (123, 123)
        /// </summary>
        public struct Coordinates
        {
            public int x, y;

            public Coordinates(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        };

        /// <summary>
        /// Sorts the planets only by the X coordinates 1 dimension
        /// </summary>
        /// <param name="planets"></param>
        /// <returns></returns>
        public static string[] SortPlanetsByX(string[] planets)
        {
            Array.Sort(planets);
            return planets;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="planets"></param>
        /// <param name=""></param>
        /// <returns>if the it returns an empty array then there is no valid path</returns>
        public static string[] ShortestPath(string[] planets, Coordinates start, Coordinates destionation)
        {
            string[] shortestPath = new string[0];
            return shortestPath;
        }

        /// <summary>
        /// Get the coordinates of the planet by name of the planet
        /// </summary>
        /// <param name="colonyName"></param>
        /// <returns></returns>
        public static Coordinates GetCoordinates(string colonyName)
        {
            Coordinates colonyLoc = new Coordinates();

            for (int i = 0; i < colonyName.Length; i++)//go through the string
            {
                //Panther(500,596)Gre009.050.N
                if (colonyName[i].Equals('(')) //x
                {
                    if (colonyName[i + 4].Equals(',')){

                        colonyLoc.x = int.Parse(colonyName[i + 1].ToString() + colonyName[i + 2].ToString() + colonyName[i + 3].ToString());
                    }
                    else if (colonyName[i + 3].Equals(','))
                    {
                        colonyLoc.x = int.Parse(colonyName[i + 1].ToString() + colonyName[i + 2].ToString());
                    }
                    else if (colonyName[i + 2].Equals(',')) {
                        colonyLoc.x = int.Parse(colonyName[i + 1].ToString());
                    }
                }
                if (colonyName[i].Equals(')')) //y
                {
                    if (colonyName[i - 4].Equals(','))
                    {
                        colonyLoc.y = int.Parse(colonyName[i - 3].ToString() + colonyName[i - 2].ToString() + colonyName[i - 1].ToString());
                    }
                    else if (colonyName[i - 3].Equals(','))
                    {
                        colonyLoc.y = int.Parse(colonyName[i + - 2].ToString() + colonyName[i - 1].ToString());
                    }
                    else if (colonyName[i - 2].Equals(','))
                    {
                        colonyLoc.y = int.Parse(colonyName[i - 1].ToString());
                    }
                }
            }

            return colonyLoc;
        }
    }
}
