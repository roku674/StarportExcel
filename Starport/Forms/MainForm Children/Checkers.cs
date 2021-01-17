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
            for (int i = 2; i <= max; i++)
            {
                string box = excel.ReadCellString(i, 11);
                if (box != "")
                {
                    if (excel.ReadCellDouble(i, 10).ToString() != "")
                    {
                        int num = i - 1;
                        excel.WriteToCell(i, 10, num.ToString()); //writes to the cell to the left and just puts a number in it
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
                                excel.WriteToCell(i, 11, ""); //yeet

                                for (int k = i; k < max; k++)
                                {
                                    string next = excel.ReadCellString(k + 1, 11);
                                    if (next != "")
                                    {
                                        excel.WriteToCell(k, 11, next);
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
            for (int i = 2; i <= max; i++)
            {
                string box = excel.ReadCellString(i, 14);
                if (box != "")
                {
                    if (excel.ReadCellDouble(i, 13).ToString() != "")
                    {
                        int num = i - 1;
                        excel.WriteToCell(i, 13, num.ToString()); //writes to the cell to the left and just puts a number in it
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
                                excel.WriteToCell(i, 14, ""); //yeet

                                for (int k = i; k < max; k++)
                                {
                                    string next = excel.ReadCellString(k + 1, 14);
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
