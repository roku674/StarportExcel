using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;


namespace StarportExcel
{
    class Replacer : MainForm
    {
        /// <summary>
        /// Replaces planet in the list or if it doesn't exist adds it
        /// </summary>
        /// <param name="newPlanetName">The planet you want to add</param>
        /// <param name="PlanetOrganizer">What's in the textbox from teh user</param>
        public static void ReplacePlanetClick(string newPlanetName, TextBox PlanetOrganizer)
        {
            for (int i = 0; i < newPlanetName.Length; i++)
            {
                if (newPlanetName[i].Equals('['))
                {
                    newPlanetName = StringReplacer(i, '(', newPlanetName);                                 
                }
                else if (newPlanetName[i].Equals(']'))
                {
                    newPlanetName = StringReplacer(i, ')', newPlanetName);              
                }

                if (i + 2 < newPlanetName.Length && newPlanetName[i].Equals('A') && newPlanetName[i + 1].Equals('r') && newPlanetName[i + 2].Equals('c'))
                {
                    //i+3 and i+4 are the numbers if its triple digit 3 4 5
                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(2, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(2, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }

                }
                else if (i + 2 < newPlanetName.Length && newPlanetName[i].Equals('D') && newPlanetName[i + 1].Equals('e') && newPlanetName[i + 2].Equals('s'))
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(3, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(3, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                }
                else if (i + 2 < newPlanetName.Length && newPlanetName[i].Equals('E') && newPlanetName[i + 1].Equals('a') && newPlanetName[i + 2].Equals('r'))
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(4, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(4, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                }
                else if (i + 2 < newPlanetName.Length && newPlanetName[i].Equals('G') && newPlanetName[i + 1].Equals('r') && newPlanetName[i + 2].Equals('e'))
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(5, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(5, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                }
                else if (i + 2 < newPlanetName.Length && newPlanetName[i].Equals('M') && newPlanetName[i + 1].Equals('o') && newPlanetName[i + 2].Equals('u'))
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(6, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(6, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                }
                else if (i + 2 < newPlanetName.Length && newPlanetName[i].Equals('O') && newPlanetName[i + 1].Equals('c') && newPlanetName[i + 2].Equals('e'))
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(7, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(7, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                }
                else if (i + 2 < newPlanetName.Length && newPlanetName[i].Equals('P') && newPlanetName[i + 1].Equals('a') && newPlanetName[i + 2].Equals('r'))
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(8, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(8, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                }
                else if (i + 2 < newPlanetName.Length && newPlanetName[i].Equals('R') && newPlanetName[i + 1].Equals('o') && newPlanetName[i + 2].Equals('c'))
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(9, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(9, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                }
                else if (i + 2 < newPlanetName.Length && newPlanetName[i].Equals('V') && newPlanetName[i + 1].Equals('o') && newPlanetName[i + 2].Equals('l'))
                {
                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(10, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(10, int.Parse(s), newPlanetName, PlanetOrganizer);
                        break;
                    }
                }
                else { } //MessageBox.Show(newPlanetName + " not found!");
            }//end i
        }

        public static void ReplacePlanetMethod(int sheet, int row, string newPlanetName, TextBox PlanetOrganizer)
        {
            Excel excel = OpenFileAt(sheet);

            if (excel.ReadCellString(row, 2) == "") // if the box was empty
            {
                excel.WriteToCell(row, 2, newPlanetName); //planet in box
                excel.WriteToCell(row, 1, row.ToString()); // update number next to it 

                if (row > excel.ReadCellDouble(1, 8)) //if the new numbeer is greater than the total 
                {
                    excel.WriteToCell(1, 8, row.ToString()); //update number
                    MessageBox.Show(newPlanetName + " added to" + " slot " + row + " on sheet " + sheet + " Totals updated to " + row, "Completed");
                }
                else
                {
                    MessageBox.Show(newPlanetName + " added to" + " slot " + row + " on sheet " + sheet, "Completed");
                }

            }
            else if (excel.ReadCellString(row, 2).Equals(newPlanetName))
            {
                MessageBox.Show("Identitcal planet found! Nothing has been added", "Error!");
            }
            else
            {
                string oldPlanetName = excel.ReadCellString(row, 2);
                excel.WriteToCell(row, 2, newPlanetName); //put the planet in the box
                                                          
                MessageBox.Show(newPlanetName + " replaced " + oldPlanetName +  " in slot " + row + " on" + " sheet " + sheet, "Completed");
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
