using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StarportExcel
{
    class Adder : MainForm
    {
        public static void AddPlanet(int sheet, string planetName, TextBox PlanetOrganizer)
        {
            Excel excel = OpenFileAt(sheet);

            int planet = (int)excel.ReadCellDouble(1, 8); //read p Tally
            int temp = planet + 1; //get it ot the next row

            excel.WriteToCell(temp, 1, temp.ToString()); //updates the number next to the cell
            excel.WriteToCell(temp, 2, planetName); //put the planet in the box


            excel.WriteToCell(1, 8, temp.ToString()); //updates the planet number

            MessageBox.Show(planetName + " added to row " + temp + " sheet " + sheet, "Completed");
            PlanetOrganizer.Text = "Insert Planet Name";

            excel.Close();
        }

        public static void AddInfo(int sheet, string info, int planetNum )
        {
            Excel excel = OpenFileAt(sheet);

            string planetName = ""; //K
            int pop = -1; //L Population
            int morale = 9999;// M
            string gov = "Null"; //N government
            int treasury = -1; //O
            int pollution = -1; //P
            int construction = -1; //Q
            int research= -1; //R
            int military = -1; //S
            int harvesting = -1; //T
            string building = ""; //U
            int Metal = -1; // V
            int Anae= -1; // W
            int Meds= -1; // X
            int Org= -1; // Y
            int Oil= -1; // Z
            int Uri = -1; // AA
            int Equi = -1; // AB
            int Spice = -1; // AC
            int Nukes = -1; // AD
            int Cmines= -1; // AE
            int Lasers= -1; // AF
            int Solar= -1; // AG
            string researches = "";

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.AppendLine("");
            StringReader reader = new StringReader(info);
            string line = "";

            for (int i = 0; i < info.Length; i++)
            {
                if ((line = reader.ReadLine()) != null)
                {
                    if ( i == 3)
                    {
                        planetName = reader.ReadLine();
                        Console.WriteLine(planetName);
                    }
                    else if (i == 7)
                    {
                        //pop = int.Parse(Regex.Replace(line, "[A-Za-z ]", ""));
                        Regex.Replace(line, "[(]", "");
                        Regex.Replace(line, "[)]", "");
                        Regex.Replace(line, "[:]", "");
                        Regex.Replace(line, "[A-Za-z ]", "");

                        Console.WriteLine(line);

                    }
                }

            }

            //do stuff

            excel.Close();
        }

        public static void AddToZounds(string colony, Excel excel)
        {
            int zoundsCount = (int)excel.ReadCellDouble(2, 8);
            zoundsCount++; //if it's 0 don't put it in the 0 slot

            excel.WriteToCell(zoundsCount, 4, zoundsCount.ToString()); // this is the 1 2 3 4
            excel.WriteToCell(zoundsCount, 5, colony); //put colony in here //
            int temp = zoundsCount + 1;
            Console.WriteLine(colony + " added to Zounds to cell [F," + temp + "]");

            excel.WriteToCell(2, 8, zoundsCount.ToString());// changes the total zounds 

        }
        /// <summary>
        /// add a singular planet to the grow list
        /// </summary>
        /// <param name="colony"></param>
        /// <param name="totalsSheet"></param>
        public static void AddToGrow(string colony, Excel totalsSheet)
        {
            //column 11 is growing on totals
            for (int i = 2; i < Program.GetMax(); i++)
            {
                string box = totalsSheet.ReadCellString(i, 11); // column L
                if (box == "")
                {
                    totalsSheet.WriteToCell(i, 11, colony);
                    int temp = i - 1;
                    totalsSheet.WriteToCell(i, 10, temp.ToString()); // put number in the box to the left
                    Console.WriteLine(colony + " added to Knee Grow", "Completed");
                    break;
                }
            }
        }
        /// <summary>
        /// add all of the planets to the grow list at once
        /// </summary>
        /// <param name="colonies"></param>
        /// <param name="totalsSheet"></param>
        public static void AddToGrow(string[] colonies, Excel totalsSheet)
        {
            for (int i = 2; i < colonies.Length; i++)
            {
                totalsSheet.WriteToCell(i, 11, colonies[i - 2]);
            }
        }
        /// <summary>
        /// add a singular planet to the needs defense list
        /// </summary>
        /// <param name="colony"></param>
        /// <param name="totalsSheet"></param>
        public static void AddToND(string colony, Excel totalsSheet)
        {
            //column 14 is Needs Defense on totals
            for (int i = 2; i < Program.GetMax(); i++)
            {
                string box = totalsSheet.ReadCellString(i, 14);
                if (box == "")
                {
                    totalsSheet.WriteToCell(i, 14, colony); //put the colony in the slot
                    int temp = i - 1;
                    totalsSheet.WriteToCell(i, 13, temp.ToString()); // put number in the box to the left
                    Console.WriteLine(colony + " added to Needs Defense", "Completed");
                    break;
                }
            }
        }
        /// <summary>
        /// Add all the colonies at once if you have an array of strings
        /// </summary>
        /// <param name="colonies"></param>
        /// <param name="totalsSheet"></param>
        public static void AddToND(string[] colonies, Excel totalsSheet)
        {
            for(int i = 2; i < colonies.Length; i++)
            {
                totalsSheet.WriteToCell(i, 14, colonies[i - 2]);
            }
        }
        
        public static void AddToDD(string colony, Excel totalsSheet)
        {        
            for (int i = 2; i < Program.GetMax(); i++)
            {
                string box = totalsSheet.ReadCellString(i, 19);
                if (box == "")
                {
                    totalsSheet.WriteToCell(i, 19, colony); //put the colony in the slot
                    int temp = i - 1;
                    totalsSheet.WriteToCell(i, 17, temp.ToString()); // put number in the box to the left
                    Console.WriteLine(colony + " added to Double Domes", "Completed");
                    break;
                }
            }
        }

        private static Excel OpenFileAt(int num)
        {
            Excel excel = new Excel(excelPath, num);
            return excel;
        }

    }
}
