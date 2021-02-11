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

            string planetName = null; //K
            int pop = -1; //L Population
            int morale = 9999;// M
            string gov = null; //N government
            int treasury = -1; //O
            string pollution = null; //P
            string pollutionRate = null; //Q
            string construction = null; //R
            string research= null; //S
            string military = null; //T
            string harvesting = null; //U
            string building = null; //V
            int metal = -1; // W
            int anae= -1; // X
            int meds= -1; // Y
            int org= -1; // Z
            int oil= -1; // AA
            int uri = -1; // AB
            int equi = -1; // AC
            int spice = -1; // AD
            int nukes = -1; // AE
            int cMines= -1; // AF
            int lasers= -1; // AG
            int solarShots= -1; // AH
            int solarRate = -1; //AI
            string researches = null; //AJ

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.AppendLine("");
            StringReader reader = new StringReader(info);
            string line;

            for (int i = 0; i < info.Length; i++)
            { 
                if ((line = reader.ReadLine()) != null)
                {
                    if ( i == 4)
                    {
                        for(int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals(':'))
                            {
                               line =  line.Substring(j+7); //takes everything after the colon
                            }
                            else if (line[j].Equals('('))
                            {
                                line = line.Substring(0, j); //removes everything after the parenthesis
                            }                            
                        }
                        planetName = line;
                        Console.WriteLine(planetName);
                    }
                    else if (i == 8)
                    {                        
                        line = RemoveParenthesisColonComma(line);
                        line = RemoveLetters(line);
                        Console.WriteLine(line);

                        pop = int.Parse(line);

                    }
                    else if (i == 9)
                    {
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals('('))
                            {
                                line = line.Substring(0, j);
                            }                           
                        }
                        line = RemoveParenthesisColonComma(line);
                        line = RemoveLetters(line);
                        Console.WriteLine(line);
                        morale = int.Parse(line);
                    }
                    else if (i == 10)
                    {
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals(':'))
                            {
                                line = line.Substring(j + 5); //takes everything after the colon
                            }                           
                        }                        
                        gov = RemoveSpaces(line);
                        Console.WriteLine(gov);
                    }
                    else if (i == 11)
                    {
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals(':'))
                            {
                                line = line.Substring(j + 7); //takes everything after the colon
                            }
                            if (line[j].Equals('('))
                            {
                                line = line.Substring(0, j); //removes everything after the parenthesis
                            }
                        }
                        line = RemoveParenthesisColonComma(line);
                        Console.WriteLine(line);
                        treasury = int.Parse(line);
                    }
                    else if (i == 12)
                    {
                        string temp = null;
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals(':'))
                            {
                                line = line.Substring(j + 6); //takes everything after the colon
                            }                          
                        }
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals('('))
                            {
                                string[] tmp = line.Split('(');
                                pollution = tmp[0];

                                pollutionRate = tmp[1];

                            }
                        }                      
                        pollutionRate = RemoveLetters(pollutionRate);
                        pollutionRate = RemoveParenthesisColonComma(pollutionRate);
                        pollutionRate = RemoveSlashes(pollutionRate);

                        Console.WriteLine(pollution);
                        Console.WriteLine(pollutionRate);
                    }
                    else if (i == 15)
                    {
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals(':'))
                            {
                                line = line.Substring(j + 3); //takes everything after the colon
                            }
                        }
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals('('))
                            {
                                line = line.Substring(0, j); //removes everything after the parenthesis
                            }
                        }
                        Console.WriteLine(line);
                        construction = line;
                    }
                    else if (i == 16)
                    {
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals(':'))
                            {
                                line = line.Substring(j + 7); //takes everything after the colon
                            }
                        }
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals('('))
                            {
                                line = line.Substring(0, j); //removes everything after the parenthesis
                            }
                        }
                        Console.WriteLine(line);
                        research = line;
                    }
                    else if (i == 17)
                    {
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals(':'))
                            {
                                line = line.Substring(j + 7); //takes everything after the colon
                            }
                        }
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals('('))
                            {
                                line = line.Substring(0, j); //removes everything after the parenthesis
                            }
                        }
                        Console.WriteLine(line);
                        military = line;
                    }
                    else if (i == 18)
                    {
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals(':'))
                            {
                                line = line.Substring(j + 5); //takes everything after the colon
                            }
                        }
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals('('))
                            {
                                line = line.Substring(0, j); //removes everything after the parenthesis
                            }
                        }
                        Console.WriteLine(line);
                        harvesting = line;
                    }
                    else if (i == 30)
                    {
                        //metal and anae on thsir ow
                    }
                    else if (i == 31)
                    {
                        //meds & orgs
                    }
                    else if (i == 32)
                    {
                        //oil and uri
                    }
                    else if (i == 33)
                    {
                        //equi and spice
                    }
                    else if (i == 36)
                    {
                        //nukes
                    }
                    else if (i == 339)
                    {
                        //cmines
                    }
                    else if (i == 41)
                    {
                        //lasers
                    }
                    else if (i == 47)
                    {
                        //solar
                    }
                    else if (i >= 48 && i <= 58)
                    {
                        //nukes
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
