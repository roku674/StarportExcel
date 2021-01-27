using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StarportExcel.Structs;

namespace StarportExcel
{
    

    class Algorithms
    {
        private static bool[,] galaxyMap = new bool[999, 999];
        public static bool[,] GalaxyMap { get => galaxyMap; set => galaxyMap = value; }

        /// <summary>
        /// structure for the x,y coordinates of a system (123, 123)
        /// </summary>
        

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
        /// Pass in the array of strings and amount of points you want ot return, will return them in order 
        /// </summary>
        /// <param name="planets">list of planets</param>
        /// <param name="origin">starting location if null will use first planet</param>
        /// <param name="amount">how many closest points you want to return</param>
        /// <returns></returns>
        public static ColonyInfo[] SortPlanetsByXAndY(string[] planets, Coordinates origin, Coordinates destination)
        {
            ColonyInfo[] colInfo = new ColonyInfo[planets.Length];

            for(int i = 0; i < planets.Length; i++)
            {
                colInfo[i].colonyName = planets[i];
                colInfo[i].coords = GetCoordinates(planets[i]);
                colInfo[i].distance = Distance(colInfo[i].coords, origin);
            }

            QuickSort(colInfo, 0, planets.Length-1);

            return colInfo;
        }

        /// <summary>
        /// Find the distance
        /// </summary>
        /// <param name="coords">destination</param>
        /// <param name="origin">point of origin</param>
        /// <returns></returns>
        public static int Distance(Coordinates coords, Coordinates origin)
        {
            return (int) Math.Sqrt((coords.x - origin.x) * (coords.x - origin.x) + (coords.y - origin.y) * (coords.y - origin.y));
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
        /// Get the coordinates of the planet by name of the planet adn returns a struct 
        /// </summary>
        /// <param name="colonyName"></param>
        /// <returns>struct Coordinates contains x and y</returns>
        public static Coordinates GetCoordinates(string colonyName)
        {
            Coordinates colonyLoc = new Coordinates();

            for (int i = 0; i < colonyName.Length; i++)//go through the string
            {
                if (colonyName[i].Equals('['))
                {
                    colonyName = Replacer.StringReplacer(i, '(', colonyName);
                }
                else if (colonyName[i].Equals(']'))
                {
                    colonyName = Replacer.StringReplacer(i, ')', colonyName);
                }

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

        //standard quicksort algorithm bellow
        static int Partition(ColonyInfo[] arr, int low,
                                   int high)
        {
            int pivot = arr[high].distance;

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j].distance < pivot)
                {
                    i++;

                    ColonyInfo temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            ColonyInfo temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        static void QuickSort(ColonyInfo[] arr, int low, int high)
        {
            if (low < high)
            {

                int par = Partition(arr, low, high);

                QuickSort(arr, low, par - 1);
                QuickSort(arr, par + 1, high);
            }
        }
    }
}
