using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace StarportExcel
{
    class Checkers : MainForm
    {
        public static void CheckGrow()
        {
            Excel excel = OpenFileAt(1);
            for (int l = 2; l <= Program.GetMax(); l++)
            {
                string box = excel.ReadCellString(l, 11);
                if (box != "")
                {
                    if (excel.ReadCellDouble(l, 10).ToString() != "")
                    {
                        int num = l - 1;
                        excel.WriteToCell(l, 10, num.ToString()); //writes to the cell to the left and just puts a number in it
                        //Console.WriteLine(i + " added");
                    }
                    //Console.WriteLine(box);
                    for (int j = 0; j < box.Length; j++) //itterate through the string character by character
                    {
                        if (box[j].Equals('.'))
                        {
                            if (j + 5 < box.Length && (box[j + 5].Equals('G') || box[j + 5].Equals('R')))
                            {
                                //stay
                            }
                            else if (j + 6 < box.Length && (box[j + 6].Equals('G') || box[j + 6].Equals('R')))
                            {
                                //stay
                            }
                            else if (j + 7 < box.Length && (box[j + 7].Equals('G') || box[j + 7].Equals('R')))
                            {
                                //stay
                            }
                            else
                            {
                                //Console.WriteLine("Removed" + box);
                                MessageBox.Show("Removed: " + box, "Message");
                                excel.WriteToCell(l, 11, ""); //you aint belong here son

                                for (int k = l; k < Program.GetMax(); k++)
                                {
                                    string next = excel.ReadCellString(k + 1, 11);

                                    for (int i = 0; i < next.Length; i++)
                                    {
                                        //Console.WriteLine("char: " + next[i] + " at" + i);
                                        if (i + 2 < next.Length && next[i].Equals('A') && next[i + 1].Equals('r') && next[i + 2].Equals('c'))
                                        {
                                            //i+3 and i+4 are the numbers if its triple digit 3 4 5
                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Arctics!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Arctics!C" + num;
                                            }

                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('D') && next[i + 1].Equals('e') && next[i + 2].Equals('s'))
                                        {

                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Deserts!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Deserts!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('E') && next[i + 1].Equals('a') && next[i + 2].Equals('r'))
                                        {

                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Earthlikes!C" + num;

                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Earthlikes!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('G') && next[i + 1].Equals('r') && next[i + 2].Equals('e'))
                                        {

                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Greenhouses!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Greenhouses!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('M') && next[i + 1].Equals('o') && next[i + 2].Equals('u'))
                                        {
                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Mountainous!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Mountainous!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('O') && next[i + 1].Equals('c') && next[i + 2].Equals('e'))
                                        {

                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Oceanics!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Oceanics!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('I') && next[i + 1].Equals('G') && next[i + 2].Equals('P'))
                                        {

                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Paradises!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Paradises!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('R') && next[i + 1].Equals('o') && next[i + 2].Equals('c'))
                                        {

                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Rockies!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Rockies!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('V') && next[i + 1].Equals('o') && next[i + 2].Equals('l'))
                                        {
                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Volcanics!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Volcanics!C" + num;
                                            }
                                        }
                                        else
                                        {
                                        } //MessageBox.Show(next + " not found!");                             

                                    }//end i

                                    if (next != "")
                                    {
                                        excel.WriteToCell(k, 11, next);
                                        Console.WriteLine("Moved " + next + " up 1");
                                    }
                                    else
                                    {
                                        excel.WriteToCell(k, 11, next);
                                        excel.WriteToCell(k + 1, 11, "");
                                        Console.WriteLine("Moved " + next + " up 1, don't duplicate");
                                    }
                                }//for k                               
                            }
                            break; //should break as soon as it finds the first period
                        } //if .
                    }//for j
                }//if
            }//for i
            excel.Close();
            MessageBox.Show("Check Grow Done", "Completed");
        }

        /// <summary>
        /// Check Totals all at once
        /// </summary>
        /// <param name="planetSheet">Planet page you're on</param>
        /// <param name="planetName">name of planet</param>
        /// <param name="formula">This will be the formula to be inserted</param>
        public static void CheckTotals(Excel totalsSheet, Excel planetSheet, string planetName, string formula)
        {
            //Console.WriteLine(" \n Check Totals info: " + planetName + " || " + formula);
            for (int i = 0; i < planetName.Length; i++) //go through string planetName 
            {
                if (planetName[i].Equals('['))
                {
                    planetName = StringReplacer(i, '(', planetName);
                    planetSheet.WriteToCell(i, 2, planetName);
                    Console.WriteLine(planetName + " changed!");
                }
                else if (planetName[i].Equals(']'))
                {
                    planetName = StringReplacer(i, ')', planetName);
                    planetSheet.WriteToCell(i, 2, planetName);
                    Console.WriteLine(planetName + " changed!");
                }

                if (planetName[i].Equals('.'))
                {
                    if (i + 5 < planetName.Length && planetName[i + 5].Equals('Z'))
                    {
                        Adder.AddToZounds(formula, planetSheet);
                    }
                    //check D
                    if (i + 5 < planetName.Length && (planetName[i + 5].Equals('G') || planetName[i + 5].Equals('R')))
                    {
                        Adder.AddToGrow(formula, totalsSheet);
                    }

                    else if (i + 5 < planetName.Length && planetName[i + 5].Equals('D'))
                    {
                        Adder.AddToDD(formula, totalsSheet);
                    }
                    else if (i + 6 < planetName.Length && planetName[i + 6].Equals('D'))
                    {
                        Adder.AddToDD(formula, totalsSheet);
                    }

                    else if (i + 6 < planetName.Length && (planetName[i + 6].Equals('G') || planetName[i + 6].Equals('R')))

                    {
                        Adder.AddToGrow(formula, totalsSheet);
                    }
                    else if (i + 7 < planetName.Length && (planetName[i + 7].Equals('G') || planetName[i + 7].Equals('R')))
                    {
                        Adder.AddToGrow(formula, totalsSheet);
                    }
                    else { }

                    if (i + 5 < planetName.Length && planetName[i + 5].Equals('N'))
                    {
                        Adder.AddToND(formula, totalsSheet);
                    }
                    else if (i + 6 < planetName.Length && planetName[i + 6].Equals('N'))
                    {
                        Adder.AddToND(formula, totalsSheet);
                    }
                    else if (i + 7 < planetName.Length && planetName[i + 7].Equals('N'))
                    {
                        Adder.AddToND(formula, totalsSheet);
                    }
                    else { }

                    break;
                }
            }
        }       
        public static bool[] Buildable(string discoveries, string planetType)
        {
            bool[] shouldBuild = new bool[4]; //Zoundsable, Medium, Questionable, Deconstruct
            //Console.WriteLine(planetType);
            shouldBuild[3] = true;

            for (int i = 0; i < discoveries.Length; i++)
            {
                //zoundsable
                if(discoveries[i].Equals('A') && 
                    discoveries[i+1].Equals('r') && 
                    discoveries[i+2].Equals('c') && 
                    discoveries[i+3].Equals('h') && 
                    (discoveries[i+17].Equals('1') || discoveries[i + 17].Equals('2') || discoveries[i + 17].Equals('3') || discoveries[i + 17].Equals('4') || discoveries[i + 17].Equals('5') ) && 
                    planetType.Equals("arctic")
                    )
                {
                    Console.WriteLine("Zoundsable Arctic");
                    shouldBuild[0] = true;
                    shouldBuild[3] = false;
                }
                else if(discoveries[i].Equals('A') && 
                    discoveries[i + 1].Equals('r') && 
                    discoveries[i + 2].Equals('c') && 
                    discoveries[i + 3].Equals('h') && 
                    discoveries[i + 17].Equals('5') && 
                    (planetType.Equals("desert") || planetType.Equals("mountainous") )
                    )
                {
                    Console.WriteLine("By God's Grace a zoundsable Desert/Mountain. Lucky asf");
                    shouldBuild[0] = true;
                    shouldBuild[3] = false;
                }
                else if(discoveries[i].Equals('A') && 
                    discoveries[i + 1].Equals('r') && 
                    discoveries[i + 2].Equals('c') && 
                    discoveries[i + 3].Equals('h') &&
                    (discoveries[i + 17].Equals('3') || discoveries[i + 17].Equals('4') || discoveries[i + 17].Equals('5') ) &&
                    !(planetType.Equals("desert") || planetType.Equals("mountainous") )
                    )
                {
                    Console.WriteLine("Zoundsable");
                    shouldBuild[0] = true;
                    shouldBuild[3] = false;
                }

                //mediums
                if (discoveries[i].Equals('S') && 
                    discoveries[i + 1].Equals('t') && 
                    discoveries[i + 2].Equals('r') && 
                    discoveries[i + 3].Equals('i') && 
                    discoveries[i + 4].Equals('p') && 
                    (discoveries[i+17].Equals('3') || discoveries[i + 17].Equals('4') || discoveries[i + 17].Equals('5') )
                    )
                {
                    Console.WriteLine("Thicc Strippers");
                    shouldBuild[1] = true;
                    shouldBuild[3] = false;
                }
                else if (discoveries[i].Equals('W') &&
                    discoveries[i+1].Equals('e') &&
                    discoveries[i + 2].Equals('a') &&
                    discoveries[i + 3].Equals('t') &&
                    (discoveries[i + 23].Equals('2') || discoveries[i + 23].Equals('3'))
                    )
                {
                    Console.WriteLine("Weather Man");
                    shouldBuild[1] = true;
                    shouldBuild[3] = false;
                }

                else if (discoveries[i].Equals('M') &&
                    discoveries[i + 1].Equals('i') &&
                    discoveries[i + 2].Equals('l') &&
                    discoveries[i + 3].Equals('i') &&
                    (discoveries[i + 23].Equals('3') || discoveries[i + 23].Equals('4') || discoveries[i + 23].Equals('5'))
                    )
                {
                    Console.WriteLine("Hoo Rah");
                    shouldBuild[1] = true;
                    shouldBuild[3] = false;
                }

                //Questionable
                if (discoveries[i].Equals('S') &&
                    discoveries[i + 1].Equals('t') &&
                    discoveries[i + 2].Equals('r') &&
                    discoveries[i + 3].Equals('i') &&
                    discoveries[i + 4].Equals('p') &&
                    (discoveries[i + 17].Equals('1') || discoveries[i + 17].Equals('2'))
                    )
                {
                    Console.WriteLine("Strippers");
                    shouldBuild[2] = true;
                    shouldBuild[3] = false;
                }
                else if (discoveries[i].Equals('W') &&
                    discoveries[i + 1].Equals('e') &&
                    discoveries[i + 2].Equals('a') &&
                    discoveries[i + 3].Equals('t') &&
                    (discoveries[i + 23].Equals('1') || discoveries[i + 23].Equals('4') || discoveries[i + 23].Equals('5'))
                    )
                {
                    Console.WriteLine("Weather Woman");
                    shouldBuild[2] = true;
                    shouldBuild[3] = false;
                }

                else if (discoveries[i].Equals('M') &&
                    discoveries[i + 1].Equals('i') &&
                    discoveries[i + 2].Equals('l') &&
                    discoveries[i + 3].Equals('i') &&
                    (discoveries[i + 23].Equals('1') || discoveries[i + 23].Equals('2'))
                    )
                {
                    Console.WriteLine("Mil trad 1/2");
                    shouldBuild[2] = true;
                    shouldBuild[3] = false;
                }
                else if (discoveries[i].Equals('C') &&
                    discoveries[i + 1].Equals('h') &&
                    discoveries[i + 2].Equals('a') &&
                    discoveries[i + 3].Equals('n') &&
                    (discoveries[i + 25].Equals('3') || discoveries[i + 25].Equals('4') || discoveries[i + 25].Equals('5'))
                    )
                {
                    Console.WriteLine("Channel Desc");
                    shouldBuild[2] = true;
                    shouldBuild[3] = false;
                }
                else if (discoveries[i].Equals('D') &&
                    discoveries[i + 1].Equals('r') &&
                    discoveries[i + 2].Equals('i') &&
                    discoveries[i + 3].Equals('l') &&
                    (discoveries[i + 13].Equals('3') || discoveries[i + 13].Equals('4') || discoveries[i + 13].Equals('5')) &&
                    (planetType.Equals("arctic") || planetType.Equals("greenhouse") || planetType.Equals("mountainous") || planetType.Equals("rocky") || planetType.Equals("volcanic"))
                    )
                {
                    Console.WriteLine("Drilling Volc/Rocky/Mountain");
                    shouldBuild[2] = true;
                    shouldBuild[3] = false;
                }
                else if (discoveries[i].Equals('N') &&
                    discoveries[i + 1].Equals('a') &&
                    discoveries[i + 2].Equals('t') &&
                    discoveries[i + 3].Equals('i') &&
                    (discoveries[i + 18].Equals('4') || discoveries[i + 18].Equals('5')) &&
                    (planetType.Equals("arctic") || planetType.Equals("greenhouse") || planetType.Equals("mountainous") || planetType.Equals("rocky") || planetType.Equals("volcanic"))
                    )
                {
                    Console.WriteLine("Medicine Volc/Rocky/Mountain");
                    shouldBuild[2] = true;
                    shouldBuild[3] = false;
                }

            }

            return shouldBuild;
        }

        public static void CheckParenthesis()
        {
            for (int j = 2; j <= 12; j++) // goes through each sheet
            {
                //Console.WriteLine("Not scanning the Invasion list until i figure out what's going wrong");
                Excel excel = OpenFileAt(j);
                //Console.WriteLine("Sheet " + j + " opened");
                int planet = (int)excel.ReadCellDouble(1, 8);
                if (j == 11)
                {
                    planet = (int)excel.ReadCellDouble(1, 15);
                }
                if (j == 12)
                {
                    planet = (int)excel.ReadCellDouble(2, 10);
                    Console.WriteLine(planet);
                }
                //Console.WriteLine("Planet Total: " + planet);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    Console.WriteLine(excel.ReadCellString(i, 2));
                    if (excel.ReadCellString(i, 2) != "")
                    {
                        string box = excel.ReadCellString(i, 2);
                        for (int k = 0; k < box.Length; k++)
                        {
                            if (box[k].Equals('['))
                            {
                                box = StringReplacer(k, '(', box);
                                excel.WriteToCell(i, 2, box);
                                Console.WriteLine(box + " changed!");
                            }
                            else if (box[k].Equals(']'))
                            {
                                box = StringReplacer(k, ')', box);
                                excel.WriteToCell(i, 2, box);
                                Console.WriteLine(box + " changed!");
                            }
                        }
                    } //end if                            
                }//end of i loop

                excel.Close();

            }// end of J loop
            MessageBox.Show("converted all brackets into Parenthesis", "Completed");
        }

        public static void CheckNeedsDefense()
        {
            Excel excel = OpenFileAt(1);
            for (int l = 2; l <= Program.GetMax(); l++)
            {
                string box = excel.ReadCellString(l, 14);
                if (box != "")
                {
                    if (excel.ReadCellDouble(l, 13).ToString() != "")
                    {
                        int num = l - 1;
                        excel.WriteToCell(l, 13, num.ToString()); //writes to the cell to the left and just puts a number in it
                        //Console.WriteLine(i + " added");
                    }
                    //Console.WriteLine(box);
                    for (int j = 0; j < box.Length; j++) //itterate through the string character by character
                    {
                        if (box[j].Equals('.'))
                        {
                            if (j + 5 < box.Length && box[j + 5].Equals('N')) { }
                            else if (j + 6 < box.Length && box[j + 6].Equals('N')) { }
                            else if (j + 7 < box.Length && box[j + 7].Equals('N')) { }
                            else
                            {
                                //Console.WriteLine("Removed" + box);
                                MessageBox.Show("Removed: " + box, "Message");
                                excel.WriteToCell(l, 14, ""); //yeet

                                for (int k = l; k < Program.GetMax(); k++)
                                {
                                    string next = excel.ReadCellString(k + 1, 14);

                                    for (int i = 0; i < next.Length; i++)
                                    {
                                        //Console.WriteLine("char: " + next[i] + " at" + i);
                                        if (i + 2 < next.Length && next[i].Equals('A') && next[i + 1].Equals('r') && next[i + 2].Equals('c'))
                                        {
                                            //i+3 and i+4 are the numbers if its triple digit 3 4 5
                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Arctics!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Arctics!C" + num;
                                            }

                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('D') && next[i + 1].Equals('e') && next[i + 2].Equals('s'))
                                        {

                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Deserts!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Deserts!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('E') && next[i + 1].Equals('a') && next[i + 2].Equals('r'))
                                        {

                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Earthlikes!C" + num;

                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Earthlikes!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('G') && next[i + 1].Equals('r') && next[i + 2].Equals('e'))
                                        {

                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Greenhouses!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Greenhouses!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('M') && next[i + 1].Equals('o') && next[i + 2].Equals('u'))
                                        {
                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Mountainous!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Mountainous!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('O') && next[i + 1].Equals('c') && next[i + 2].Equals('e'))
                                        {

                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Oceanics!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Oceanics!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('I') && next[i + 1].Equals('G') && next[i + 2].Equals('P'))
                                        {

                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Paradises!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Paradises!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('R') && next[i + 1].Equals('o') && next[i + 2].Equals('c'))
                                        {

                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Rockies!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Rockies!C" + num;
                                            }
                                        }
                                        else if (i + 2 < next.Length && next[i].Equals('V') && next[i + 1].Equals('o') && next[i + 2].Equals('l'))
                                        {
                                            if (next[i + 5] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string s = str1 + str2;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Volcanics!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Volcanics!C" + num;
                                            }
                                        }
                                        else
                                        {
                                        } //MessageBox.Show(next + " not found!");                             

                                    }//end i

                                    if (next != "")
                                    {
                                        excel.WriteToCell(k, 14, next);
                                        Console.WriteLine("Moved " + next + " up 1");
                                    }
                                    else
                                    {
                                        excel.WriteToCell(k, 14, next);
                                        excel.WriteToCell(k + 1, 14, "");
                                        Console.WriteLine("Moved " + next + " up 1, don't duplicate");
                                    }
                                }//for k                               
                            }
                            break; //should break as soon as it finds the first period
                        } //if .
                    }//for j
                }//if
            }//for i
            excel.Close();
            MessageBox.Show("Check Needs Defense Done", "Completed");
        }

        private static Excel OpenFileAt(int num)
        {
            Excel excel = new Excel(excelPath, num);
            return excel;
        }
    }
}
