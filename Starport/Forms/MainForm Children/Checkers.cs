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
            int max = 300;
            Excel excel = OpenFileAt(1);
            for (int l = 2; l <= max; l++)
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
                            if (j + 5 < box.Length && box[j + 5].Equals('G'))
                            {
                                //stay
                            }
                            else if (j + 6 < box.Length && box[j + 6].Equals('G'))
                            {
                                //stay
                            }
                            else
                            {
                                //Console.WriteLine("Removed" + box);
                                MessageBox.Show("Removed: " + box, "Message");
                                excel.WriteToCell(l, 11, ""); //yeet

                                for (int k = l; k < max; k++)
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

                                                next = "=Earths!C" + num;

                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Earths!C" + num;
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

                                                next = "=Mountains!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Mountains!C" + num;
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
                                        else if (i + 2 < next.Length && next[i].Equals('P') && next[i + 1].Equals('a') && next[i + 2].Equals('r'))
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
                                        /*if (excel.ReadCellString(k+2,11) == "")
                                        {
                                            excel.WriteToCell(k + 2, 11, "");
                                        }*/
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
            for (int i = 0; i < planetName.Length; i++) //continue from the First planet letter
            {
                if (planetName[i].Equals('.'))
                {
                    if (i + 5 < planetName.Length && planetName[i + 5].Equals('Z'))
                    {
                        Adder.AddToZounds(formula, planetSheet);
                    }
                    else { }

                    if (i + 5 < planetName.Length && planetName[i + 5].Equals('G'))
                    {
                        Adder.AddToGrow(formula, totalsSheet);
                    }
                    else if (i + 6 < planetName.Length && planetName[i + 6].Equals('G'))
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
                }
            }

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
                    planet = (int)excel.ReadCellDouble(1, 10);
                }
                if (j == 12)
                {
                    planet = (int)excel.ReadCellDouble(2, 10);
                    Console.WriteLine(planet);
                }
                //Console.WriteLine("Planet Total: " + planet);
                for (int i = planet + 1; i >= 1; i--) // goes through the planet list
                {
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
            int max = 300;
            Excel excel = OpenFileAt(1);
            for (int l = 2; l <= max; l++)
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

                                for (int k = l; k < max; k++)
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

                                                next = "=Earths!C" + num;

                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Earths!C" + num;
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

                                                next = "=Mountains!C" + num;
                                            }
                                            else if (next[i + 6] == '.')
                                            {
                                                string str1 = next[i + 3].ToString();
                                                string str2 = next[i + 4].ToString();
                                                string str3 = next[i + 5].ToString();
                                                string s = str1 + str2 + str3;

                                                int num = int.Parse(s);
                                                num++;

                                                next = "=Mountains!C" + num;
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
                                        else if (i + 2 < next.Length && next[i].Equals('P') && next[i + 1].Equals('a') && next[i + 2].Equals('r'))
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
