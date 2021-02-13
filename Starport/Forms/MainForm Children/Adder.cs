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

            string colonyName = null;
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
            int orgs= -1; // Z
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
                
                line = reader.ReadLine();
                if (line != null)
                {
                    if (i == 0)
                    {
                        colonyName = line;
                        Console.WriteLine(line);
                    }
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
                        string[] temp = line.Split(':');
                        temp = temp[1].Split('('); //temp[1] is the growth rate
                        temp[0] = RemoveSpaces(temp[0]);
                        temp[0] = RemoveParenthesisColonComma(temp[0]);
                        Console.WriteLine(temp[0]);

                        pop = int.Parse(temp[0]);

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
                        line = RemoveLetters(line);
                        Console.WriteLine(line);
                        treasury = int.Parse(line);
                    }
                    else if (i == 12)
                    {
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals(':'))
                            {
                                line = line.Substring(j + 6); //takes everything after the colon
                            }                          
                        }

                        string[] temp = line.Split('(');
                        pollution = temp[0];

                        pollutionRate = temp[1];

               
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
                        line = RemoveSpaces(line);
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
                        line = RemoveSpaces(line);
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
                        line = RemoveSpaces(line);
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
                        line = RemoveSpaces(line);
                        harvesting = line;
                    }
                    else if (i == 20)
                    {
                        string[] temp = line.Split(':');
                        temp[1] = RemoveSpaces(temp[1]);
                        building = temp[1];
                        Console.WriteLine(temp[1]);
                    }
                    else if (i == 30)
                    {
                        //metal and anae on thsir ow
                        string[] temp = line.Split(':');
                        temp[1] = RemoveLetters(temp[1]);
                        temp[2] = RemoveSpaces(temp[2]);
                        metal = int.Parse(temp[1]);
                        anae = int.Parse(temp[2]);
                        Console.WriteLine(temp[1] + '\n' + temp[2]);
                    }
                    else if (i == 31)
                    {
                        //meds & orgs
                        string[] temp = line.Split(':');
                        temp[1] = RemoveLetters(temp[1]);
                        temp[2] = RemoveSpaces(temp[2]);
                        meds = int.Parse(temp[1]);
                        orgs = int.Parse(temp[2]);
                        Console.WriteLine(temp[1] + '\n' + temp[2]);
                    }
                    else if (i == 32)
                    {
                        //oil and uri
                        string[] temp = line.Split(':');
                        temp[1] = RemoveLetters(temp[1]);
                        temp[2] = RemoveSpaces(temp[2]);
                        oil = int.Parse(temp[1]);
                        uri = int.Parse(temp[2]);
                        Console.WriteLine(temp[1] + '\n' + temp[2]);
                    }
                    else if (i == 33)
                    {
                        //equi and spice
                        string[] temp = line.Split(':');
                        temp[1] = RemoveLetters(temp[1]);
                        temp[2] = RemoveSpaces(temp[2]);
                        equi = int.Parse(temp[1]);
                        spice = int.Parse(temp[2]);
                        Console.WriteLine(temp[1] + '\n' + temp[2]);
                    }
                    else if (i == 36)
                    {
                        if(line.Equals("No weapons factory present."))
                        {
                            for (int j = i; j < info.Length; j++)
                            {
                                if (line != null)
                                {
                                    if (j == 38)
                                    {
                                        string[] temp = line.Split('(');
                                        temp[0] = RemoveLetters(temp[0]);
                                        temp[0] = RemoveParenthesisColonComma(temp[0]);

                                        temp[1] = RemoveLetters(temp[1]);
                                        temp[1] = RemoveParenthesisColonComma(temp[1]);

                                        solarShots = int.Parse(temp[0]);
                                        solarRate = int.Parse(temp[1]);
                                        Console.WriteLine(temp[0] + '\n' + temp[1]);
                                    }
                                    line = reader.ReadLine();
                                    if (j >= 39 && j <= 50)
                                    {

                                        researches = researches + '\n' + line;

                                    }
                                }
                            }
                            Console.WriteLine("No Weapons Factory");
                            break;
                        }
                        else
                        {
                            //nukes 
                            string[] temp = line.Split(':');
                            temp[1] = RemoveSpaces(temp[1]);
                            temp[1].Trim();
                            nukes = int.Parse(temp[1]);
                            Console.WriteLine(temp[1]);
                        }                       
                    }
                    else if (i == 39)
                    {
                        //cmines
                        string[] temp = line.Split(':');
                        temp[1] = RemoveSpaces(temp[1]);

                        cMines = int.Parse(temp[1]);
                        Console.WriteLine(temp[1]);
                    }
                    else if (i == 41)
                    {
                        //lasers
                        string[] temp = line.Split(':');
                        temp[1] = RemoveSpaces(temp[1]);

                        lasers = int.Parse(temp[1]);
                        Console.WriteLine(temp[1]);
                    }
                    else if (i == 46)
                    {
                        //solar
                        string[] temp = line.Split('(');
                        temp[0] = RemoveLetters(temp[0]);
                        temp[0] = RemoveParenthesisColonComma(temp[0]);

                        temp[1] = RemoveLetters(temp[1]);
                        temp[1] = RemoveParenthesisColonComma(temp[1]);

                        solarShots = int.Parse(temp[0]);
                        solarRate = int.Parse(temp[1]);
                        Console.WriteLine(temp[0] + '\n' + temp[1] );
                    }
                    else if (i >= 48 && i <= 59)
                    {

                        researches = researches + '\n' + line;

                        //Console.WriteLine(line);
                    }                    
                }                
            }
            Console.Write(researches);
            if (excel.ReadCellString(planetNum, 2).Equals("") || excel.ReadCellString(planetNum, 2).Equals(null))
            {
                excel.WriteToCell(planetNum, 2, colonyName);
            }
            excel.WriteToCell(planetNum, 10, planetName);
            excel.WriteToCell(planetNum, 11, pop.ToString());
            excel.WriteToCell(planetNum, 12, morale.ToString());
            excel.WriteToCell(planetNum, 13, gov);
            excel.WriteToCell(planetNum, 14, treasury.ToString());
            excel.WriteToCell(planetNum, 15, pollution);
            excel.WriteToCell(planetNum, 16, pollutionRate);
            excel.WriteToCell(planetNum, 17, construction);
            excel.WriteToCell(planetNum, 18, research);
            excel.WriteToCell(planetNum, 19, military);
            excel.WriteToCell(planetNum, 20, harvesting);
            excel.WriteToCell(planetNum, 21, building);
            excel.WriteToCell(planetNum, 22, metal.ToString());
            excel.WriteToCell(planetNum, 23, anae.ToString());
            excel.WriteToCell(planetNum, 24, meds.ToString());
            excel.WriteToCell(planetNum, 25, orgs.ToString());
            excel.WriteToCell(planetNum, 26, oil.ToString());
            excel.WriteToCell(planetNum, 27, uri.ToString());
            excel.WriteToCell(planetNum, 28, equi.ToString());
            excel.WriteToCell(planetNum, 29, spice.ToString());
            excel.WriteToCell(planetNum, 30, nukes.ToString());
            excel.WriteToCell(planetNum, 31, cMines.ToString());
            excel.WriteToCell(planetNum, 32, lasers.ToString());
            excel.WriteToCell(planetNum, 33, solarShots.ToString());
            excel.WriteToCell(planetNum, 34, solarRate.ToString());
            excel.WriteToCell(planetNum, 35, researches);

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
