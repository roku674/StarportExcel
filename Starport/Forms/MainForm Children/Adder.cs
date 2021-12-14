using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StarportExcel
{
    internal class Adder : MainForm
    {
        public static void AddColonyInfo(int sheet, string info, int planetNum)
        {
            Excel excel = OpenFileAt(sheet);

            string colonyName = null;
            string planetName = null; //K
            int pop = -1; //L Population
            int morale = 9999;// M
            string gov = null; //N government
            int treasury = -1; //O
            int hourlyIncome = 0; //P
            string taxRate; // Q
            string pollution = null; //R
            int disastas = 0; // S
            string pollutionRate = null; //T
            string construction = null; //U
            string research = null; //V
            string military = null; //W
            string harvesting = null; //X
            string building = null; //Y
            int metal = -1; // Z
            int anae = -1; // AA
            int meds = -1; // AB
            int orgs = -1; // AC
            int oil = -1; // AD
            int uri = -1; // AE
            int equi = -1; // AF
            int spice = -1; // AG
            int nukes = -1; // AH
            int cMines = -1; // AI
            int lasers = -1; // AJ
            int solarShots = -1; // AK
            int solarRate = -1; //AL
            string discovered = null; //AM

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.AppendLine("");
            StringReader reader = new StringReader(info);
            string line;
            //string firstLine = reader.ReadLine();

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
                    if (i == 4)
                    {
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals(':'))
                            {
                                line = line.Substring(j + 7); //takes everything after the colon
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
                        }
                        string[] temp = line.Split('(');

                        temp[0] = RemoveParenthesisColonComma(temp[0]);
                        temp[0] = RemoveSpaces(temp[0]);
                        treasury = int.Parse(temp[0]);

                        temp[1] = RemoveParenthesisColonComma(temp[1]);
                        temp[1] = RemoveLetters(temp[1]);
                        if (temp[1].Equals(null) || temp[1].Equals("")) { }
                        else
                        {
                            hourlyIncome = int.Parse(temp[1]);
                        }

                        Console.WriteLine(temp[0] + " " + temp[1] + "/hr");
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

                        if (temp.Length > 2)
                        {
                            string trim = RemoveParenthesisColonComma(temp[1]);
                            disastas = int.Parse(trim);
                            pollutionRate = temp[2];
                        }
                        else
                        {
                            pollutionRate = temp[1];
                        }
                        pollutionRate = RemoveLetters(pollutionRate);
                        pollutionRate = RemoveParenthesisColonComma(pollutionRate);
                        pollutionRate = RemoveSlashes(pollutionRate);

                        Console.WriteLine(pollution + " " + disastas);
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
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j].Equals(':'))
                            {
                                line = line.Substring(j + 7); //takes everything after the colon
                            }
                        }
                        building = line;
                        Console.WriteLine(building);
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
                        if (line.Equals("No weapons factory present."))
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
                                        if (temp[1] == null || temp[1].Equals(""))
                                        {
                                            temp[1] = "0";
                                        }

                                        solarShots = int.Parse(temp[0]);
                                        solarRate = int.Parse(temp[1]);
                                        Console.WriteLine(temp[0] + '\n' + temp[1]);
                                    }
                                    line = reader.ReadLine();
                                    if (j >= 39 && j <= 50)
                                    {
                                        discovered = discovered + '\n' + line;
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
                        Console.WriteLine(temp[0] + '\n' + temp[1]);
                    }
                    else if (i >= 48 && i <= 59)
                    {
                        discovered = discovered + '\n' + line;

                        //Console.WriteLine(line);
                    }
                }
            }
            Console.Write(discovered);

            Replacer.ReplacePlanetMethod(excel, sheet, planetNum, colonyName);
            excel.WriteToCell(planetNum, 10, planetName);
            excel.WriteToCell(planetNum, 11, pop.ToString());
            excel.WriteToCell(planetNum, 12, morale.ToString());
            excel.WriteToCell(planetNum, 13, gov);
            excel.WriteToCell(planetNum, 14, treasury.ToString());
            excel.WriteToCell(planetNum, 15, hourlyIncome.ToString());
            //skip 16 this is a calculation
            excel.WriteToCell(planetNum, 17, pollution);
            excel.WriteToCell(planetNum, 18, disastas.ToString());
            excel.WriteToCell(planetNum, 19, pollutionRate);
            excel.WriteToCell(planetNum, 20, construction);
            excel.WriteToCell(planetNum, 21, research);
            excel.WriteToCell(planetNum, 22, military);
            excel.WriteToCell(planetNum, 23, harvesting);
            excel.WriteToCell(planetNum, 24, building);
            excel.WriteToCell(planetNum, 25, metal.ToString());
            excel.WriteToCell(planetNum, 26, anae.ToString());
            excel.WriteToCell(planetNum, 27, meds.ToString());
            excel.WriteToCell(planetNum, 28, orgs.ToString());
            excel.WriteToCell(planetNum, 29, oil.ToString());
            excel.WriteToCell(planetNum, 30, uri.ToString());
            excel.WriteToCell(planetNum, 31, equi.ToString());
            excel.WriteToCell(planetNum, 32, spice.ToString());
            excel.WriteToCell(planetNum, 33, nukes.ToString());
            excel.WriteToCell(planetNum, 34, cMines.ToString());
            excel.WriteToCell(planetNum, 35, lasers.ToString());
            excel.WriteToCell(planetNum, 36, solarShots.ToString());
            excel.WriteToCell(planetNum, 37, solarRate.ToString());
            excel.WriteToCell(planetNum, 38, discovered);

            excel.Close();
        }

        /// <summary>
        /// OBSOLETE USE REPLACER.REPLACEPLANET
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="planetName"></param>
        public static void AddPlanet(int sheet, string planetName)
        {
            Excel excel = OpenFileAt(sheet);

            int planet = excel.ReadCellInt(1, 8); //read p Tally
            int temp = planet + 1; //get it ot the next row

            excel.WriteToCell(temp, 1, temp.ToString()); //updates the number next to the cell
            excel.WriteToCell(temp, 2, planetName); //put the planet in the box

            if (excel.ReadCellInt(1, 8) < temp)
            {
                excel.WriteToCell(1, 8, temp.ToString()); //updates the planet number
            }

            MessageBox.Show(planetName + " added to row " + temp + " sheet " + sheet, "Completed");

            excel.Close();
        }

        public static void AddToBuilds(Excel excel, string coordinates, string planetName, string colonyName, string zoundsable, string medium, string questionable, string deconstruct, string research)

        {
            int totalBuilds = excel.ReadCellInt(1, 15);
            totalBuilds += 1;

            excel.WriteToCell(1, 15, totalBuilds.ToString());
            excel.WriteToCell(totalBuilds, 1, totalBuilds.ToString());

            excel.WriteToCell(totalBuilds, 2, coordinates);
            excel.WriteToCell(totalBuilds, 3, planetName);
            excel.WriteToCell(totalBuilds, 4, colonyName);
            excel.WriteToCell(totalBuilds, 5, zoundsable);
            excel.WriteToCell(totalBuilds, 6, medium);
            excel.WriteToCell(totalBuilds, 7, questionable);
            excel.WriteToCell(totalBuilds, 8, deconstruct);
            excel.WriteToCell(totalBuilds, 9, research);
        }

        /// <summary>
        /// add a singular planet to the construction list
        /// </summary>
        /// <param name="colony"></param>
        /// <param name="totalsSheet"></param>
        public static void AddToConstruction(string colony, Excel totalsSheet)
        {
            //column 11 is growing on totals
            for (int i = 2; i < Program.GetMax(); i++)
            {
                var box = totalsSheet.ReadCellString(i, 25); // column L
                if (box == "")
                {
                    totalsSheet.WriteToCell(i, 25, colony);
                    int temp = i - 1;
                    totalsSheet.WriteToCell(i, 24, temp.ToString()); // put number in the box to the left
                    Console.WriteLine(colony + " added to Construction", "Completed");
                    break;
                }
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
                var box = totalsSheet.ReadCellString(i, 11); // column L
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
            for (int i = 2; i < colonies.Length; i++)
            {
                totalsSheet.WriteToCell(i, 14, colonies[i - 2]);
            }
        }

        public static void AddToWeakSolars(string colony, Excel totalsSheet)
        {
            for (int i = 2; i < Program.GetMax(); i++)
            {
                var box = totalsSheet.ReadCellString(i, 22); // column L
                if (box == "")
                {
                    totalsSheet.WriteToCell(i, 22, colony);
                    int temp = i - 1;
                    totalsSheet.WriteToCell(i, 21, temp.ToString()); // put number in the box to the left
                    Console.WriteLine(colony + " added to Weak Solars");
                    break;
                }
            }
        }

        public static void AddToZounds(string colony, Excel excel)
        {
            int zoundsCount = excel.ReadCellInt(2, 8);
            zoundsCount++; //if it's 0 don't put it in the 0 slot

            excel.WriteToCell(zoundsCount, 4, zoundsCount.ToString()); // this is the 1 2 3 4
            excel.WriteToCell(zoundsCount, 5, colony); //put colony in here //
            int temp = zoundsCount + 1;
            Console.WriteLine(colony + " added to Zounds to cell [F," + temp + "]");

            excel.WriteToCell(2, 8, zoundsCount.ToString());// changes the total zounds
        }

        public static void BuildZoundsDestroy(string colonyInfo, bool resources, bool defended)
        {
            Excel excel = OpenFileAt(11); // build list
            StringReader reader = new StringReader(colonyInfo);
            string line;

            string planetType = null;
            string coordinates = null; // C
            string planetName = null; // D
            string colonyName = null; // E
            string discoveries = null; // K
            int research = -1; // J

            bool[] buildableHolder = new bool[4];

            bool zoundsable = false;
            bool medium = false;
            bool questionable = false;
            bool deconstruct = false;// F , G, H, I

            buildableHolder[0] = zoundsable;
            buildableHolder[1] = medium;
            buildableHolder[2] = questionable;
            buildableHolder[3] = deconstruct;

            for (int i = 0; i < colonyInfo.Length; i++)
            {
                line = reader.ReadLine();

                if (line != null)
                {
                    if (i == 0)
                    {
                        colonyName = line;
                        Console.WriteLine(line);
                    }
                    else if (i == 3)
                    {
                        string[] temp = line.Split(':');
                        planetType = temp[1];
                        planetType = RemoveSpaces(planetType);
                    }
                    else if (i == 4)
                    {
                        string[] temp = line.Split(':');
                        temp = temp[1].Split('(');
                        planetName = temp[0];
                        coordinates = temp[1];
                        coordinates = "(" + coordinates;
                    }
                    else if (i == 40)
                    {
                        string[] temp = line.Split('/');
                        temp[0] = RemoveLetters(temp[0]);
                        temp[0] = RemoveParenthesisColonComma(temp[0]);
                        research = int.Parse(temp[0]);
                    }
                    else if (i >= 41)
                    {
                        discoveries = discoveries + '\n' + line;
                    }
                }
            }

            bool noDuplicate = true;

            for (int i = 1; i <= excel.ReadCellInt(1, 15); i++)
            {
                if (planetName.Equals(excel.ReadCellString(i, 3)))
                {
                    Console.WriteLine("Duplicate Found");
                    noDuplicate = false;
                }
            }

            if (research >= 8 && noDuplicate)
            {
                buildableHolder = Checkers.Buildable(discoveries, planetType);
                zoundsable = buildableHolder[0];
                medium = buildableHolder[1];
                questionable = buildableHolder[2];
                deconstruct = buildableHolder[3];

                int totalBuilds = excel.ReadCellInt(1, 15);
                totalBuilds += 1;
                Console.WriteLine(totalBuilds);
                //excel.WriteToCell(1, 15, totalBuilds.ToString());

                excel.WriteToCell(totalBuilds, 1, totalBuilds.ToString());
                excel.WriteToCell(totalBuilds, 2, coordinates);
                excel.WriteToCell(totalBuilds, 3, planetName);
                excel.WriteToCell(totalBuilds, 4, colonyName);
                excel.WriteToCell(totalBuilds, 5, zoundsable.ToString());
                excel.WriteToCell(totalBuilds, 6, medium.ToString());
                excel.WriteToCell(totalBuilds, 7, questionable.ToString());
                excel.WriteToCell(totalBuilds, 8, deconstruct.ToString());
                excel.WriteToCell(totalBuilds, 9, research.ToString());
                excel.WriteToCell(totalBuilds, 10, resources.ToString());
                excel.WriteToCell(totalBuilds, 11, defended.ToString());
            }
            else
            {
                Console.WriteLine(colonyName + " is Not Finished Researching.");
                //MessageBox.Show(colonyName + " is Not Finished Researching.", "Message");
            }
            excel.Close();
        }

        private static Excel OpenFileAt(int num)
        {
            Excel excel = new Excel(excelPath, num);
            return excel;
        }
    }
}