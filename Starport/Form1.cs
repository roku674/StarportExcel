using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarportExcel
{    
    public partial class Form1 : Form
    {
        readonly string excelPath = @"G:\My Drive\Personal Stuff\Starport\PlanetTallies.xlsx";
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Make Sure the excel sheet is close first!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateQuote_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(1);

            //number, letter          

            double arcticsZ = excel.ReadCellDouble(3, 3); //4D
            double arctics = excel.ReadCellDouble(3, 2); //4C

            double desertsZ = excel.ReadCellDouble(4, 3);
            double deserts = excel.ReadCellDouble(4, 2);

            double earthsZ = excel.ReadCellDouble(5, 3);
            double earths = excel.ReadCellDouble(5, 2);

            double greenhousesZ = excel.ReadCellDouble(6, 3);
            double greenhouses = excel.ReadCellDouble(6, 2);

            double mountainsZ = excel.ReadCellDouble(7, 3);
            double mountains = excel.ReadCellDouble(7, 2);

            double oceansZ = excel.ReadCellDouble(8, 3);
            double oceans = excel.ReadCellDouble(8, 2);

            //double paradisesZ = excel.ReadCellDouble(9, 3);
            double paradises = excel.ReadCellDouble(9, 2);

            double rockiesZ = excel.ReadCellDouble(10, 3);
            double rockies = excel.ReadCellDouble(10, 2);

            double volcanicsZ = excel.ReadCellDouble(11, 3);
            double volcanics = excel.ReadCellDouble(11, 2);

            double totalsZ = excel.ReadCellDouble(12, 3);
            double totals = excel.ReadCellDouble(12, 2);

            Console.WriteLine("Arctics " + arcticsZ + "/" + arctics +
                "|~{yellow}~Deserts " + desertsZ + "/" + deserts +
                "|~{green}~Earths " + earthsZ + "/" + earths +
                "|~{orange}~Greenhouses " + greenhousesZ + "/" + greenhouses +
                "|~{brown}~Mountains " + mountainsZ + "/" + mountains +
                "|~{blue}~Oceans " + oceansZ + "/" + oceans +
                "|~{pink}~Paradises ~{link}1:" + paradises + "~" +
                "|~{gray}~Rockies " + rockiesZ + "/" + rockies +
                "|~{red}~Volcanics " + volcanicsZ + "/" + volcanics +
                "|~{cyan}~ Sum: " + totalsZ + " Zounds / " + totals + "~{link}21: Colonies~");

            itsMyWindow.Text = "Arctics " + arcticsZ + "/" + arctics +
                "|~{yellow}~Deserts " + desertsZ + "/" + deserts +
                "|~{green}~Earths " + earthsZ + "/" + earths +
                "|~{orange}~Greenhouses " + greenhousesZ + "/" + greenhouses +
                "|~{brown}~Mountains " + mountainsZ + "/" + mountains +
                "|~{blue}~Oceans " + oceansZ + "/" + oceans +
                "|~{pink}~Paradises ~{link}1:" + paradises + "~" +
                "|~{gray}~Rockies " + rockiesZ + "/" + rockies +
                "|~{red}~Volcanics " + volcanicsZ + "/" + volcanics +
                "|~{cyan}~ Sum: " + totalsZ + " Zounds / " + totals + "~{link}21: Colonies~";
        }
        private void CheckGrow_Click(object sender, EventArgs e)
        {
            int max = 20;
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
                                MessageBox.Show("Removed: " + box);
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
            MessageBox.Show("Check Grow Done");
        }
        private void CheckParenthesis_Click(object sender, EventArgs e)
        {

            for (int j = 2; j <= 12; j++) // goes through each sheet
            {
                    Console.WriteLine("Not scanning the Invasion list until i figure out what's going wrong");
                    Excel excel = OpenFileAt(j);
                    //Console.WriteLine("Sheet " + j + " opened");
                    int planet = (int)excel.ReadCellDouble(1, 8);
                    if (j == 12)
                    {
                        planet = (int)excel.ReadCellDouble(2, 10);
                        //Console.WriteLine(planet);
                    }
                    //Console.WriteLine("Planet Total: " + planet);
                    for (int i = planet + 2 - 1; i >= 1; i--) // goes through the planet list
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
            MessageBox.Show("converted all brackets into Parenthesis");
        }

        private void FindGrowing_Click(object sender, EventArgs e)
        {

            //all planets start at 2C
            //zounds start at 2F
            //Tallies are I2 == Planet I3 == Zoudns
            Excel totals = OpenFileAt(1);
            ClearGrowList(totals);

            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = (int)excel.ReadCellDouble(1, 8);
                //Console.WriteLine("Planet Total: " + planet);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    if (excel.ReadCellString(i, 2) != "")
                    {
                        if (excel.ReadCellDouble(i, 1).ToString() != "")
                        {
                            excel.WriteToCell(i, 1, i.ToString()); //writes to the cell to the left and just puts a number in it
                        }

                        string box = excel.ReadCellString(i, 2);

                        for (int k = 0; k < box.Length; k++) //itterate through the string character by character
                        {
                            if (box[k].Equals('.'))
                            {
                                if (k + 5 < box.Length && box[k + 5].Equals('G'))
                                {
                                    AddToGrow(box, totals);                                   
                                    break;
                                }
                                else if (k + 6 < box.Length && box[k + 6].Equals('G'))
                                {
                                    AddToGrow(box, totals );
                                    break;
                                }
                                else
                                {
                                    //do nothing
                                }
                            }//end if
                        }// for k
                    } //end if                            
                }//end of i loop

                excel.Close();
                
            }// end of J loop

            totals.Close();
            MessageBox.Show("Find Grow Done");
        }
        private void FindTotals_Click(object sender, EventArgs e)
        {            
            for (int i = 2; i <= 10; i++) // goes through each sheet
            {
                Excel excel = OpenFileAt(i);

                int planet = (int)excel.ReadCellDouble(1, 8);
                int temp = 0;
                for (int j = 1; j <= planet + 5; j++) // goes through the planet list
                {
                    if (excel.ReadCellString(j, 2) != "")
                    {
                        excel.WriteToCell(j, 1, j.ToString()); //writes to the cell to the left and just puts a number in it
                        temp = j;
                    }
                    
                }//end of j loop

                excel.WriteToCell(1, 8, temp.ToString()); //changes the total planets
                //Console.WriteLine("Planet Total: " + temp);

                excel.Close();

            }// end of i loop

            FindZounds_Click(sender, e);
            FindGrowing_Click(sender, e);
            FindNeedsDefense_Click(sender, e);

            MessageBox.Show("Find Totals Done");
        }
        private void FindZounds_Click(object sender, EventArgs e)
        {
            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = (int)excel.ReadCellDouble(1, 8);            
                excel.WriteToCell(2, 8, 0.ToString());//clear zounds num

                //ClearZoundsList(excel, planet);
                //Console.WriteLine("Planet Total: " + planet);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    string box = excel.ReadCellString(i, 2); //get the contents of coulumn C

                    for (int k = 0; k < box.Length; k++) //itterate through the string character by character
                    {
                        if (box[k].Equals('.'))
                        {
                            if (k + 5 < box.Length && box[k + 5].Equals('Z'))
                            {
                                AddToZounds(box, excel);
                                break;
                            }

                        }//end if
                        else if(box == " ")
                        {
                            break;
                        }
                    }// for k        

                }//end of i loop

                excel.Close();

            }// end of J loop
            MessageBox.Show("Find Zounds Done");
        }
        private void FindNeedsDefense_Click(object sender, EventArgs e)
        {
            Excel totals = OpenFileAt(1);
            ClearNDList(totals);

            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = (int)excel.ReadCellDouble(1, 8);
                //Console.WriteLine("Planet Total: " + planet);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    if (excel.ReadCellString(i, 2) != "")
                    {
                        if (excel.ReadCellDouble(i, 1).ToString() != "")
                        {
                            excel.WriteToCell(i, 1, i.ToString()); //writes to the cell to the left and just puts a number in it
                        }

                        string box = excel.ReadCellString(i, 2);

                        for (int k = 0; k < box.Length; k++) //itterate through the string character by character
                        {
                            if (box[k].Equals('.'))
                            {
                                if (k + 6 < box.Length && box[k + 5].Equals('N') && box[k + 6].Equals('D'))
                                {
                                    AddToND(box, totals);
                                    break;
                                }
                                else if (k + 7 < box.Length && box[k + 6].Equals('N') && box[k + 7].Equals('D'))
                                {
                                    AddToND(box, totals);
                                    break;
                                }
                                else if (k + 8 < box.Length && box[k + 7].Equals('N') && box[k + 8].Equals('D'))
                                {
                                    AddToND(box, totals);
                                    break;
                                }
                                else
                                {
                                    //do nothing
                                }
                            }//end if
                        }// for k
                    } //end if                            
                }//end of i loop

                excel.Close();

            }// end of J loop

            totals.Close();
            MessageBox.Show("Find Needs Defense Done");
        }
        private void ClearZounds_Click(object sender, EventArgs e)
        {
            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);
                int planet = (int)excel.ReadCellDouble(1, 8);
                ClearZoundsList(excel, planet);
                excel.Close();
            }
            MessageBox.Show("Zounds lists Cleared!");
        }

        private void AddToGrow(string colony, Excel excel)
        {
            //column 11 is growing on totals
            for (int i = 2; i < 50; i++)
            {
                string box = excel.ReadCellString(i, 11);
                if (box == "")
                {
                    excel.WriteToCell(i, 11, colony);
                   // Console.WriteLine(colony + " added to Knee Grow");
                    break;
                }
            }
        }
        private void AddToZounds(string colony, Excel excel)
        {
            int zoundsCount = (int)excel.ReadCellDouble(2, 8);
            zoundsCount++; //if it's 0 don't put it in the 0 slot

            excel.WriteToCell(zoundsCount, 5, colony); //put colony in here //
            Console.WriteLine(colony + " added to Zounds to cell [F,"+ zoundsCount + "]");

            excel.WriteToCell(zoundsCount, 4, zoundsCount.ToString()); // this is the 1 2 3 4

            excel.WriteToCell(2, 8, zoundsCount.ToString());// changes the total zounds 

        }
        private void AddToND(string colony, Excel excel)
        {
            //column 11 is growing on totals
            for (int i = 2; i < 50; i++)
            {
                string box = excel.ReadCellString(i, 14);
                if (box == "")
                {
                    excel.WriteToCell(i, 14, colony);
                    // Console.WriteLine(colony + " added to Needs Defense");
                    break;
                }
            }
        }
        private void AddPlanet(int sheet, string planetName)
        {
            Excel excel = OpenFileAt(sheet);

            int planet = (int)excel.ReadCellDouble(1, 8); //read p Tally
            int temp = planet+1; //get it ot the next row

            excel.WriteToCell(temp, 2, planetName); //put the planet in the box
            excel.WriteToCell(temp, 1, temp.ToString()); //updates the number next to the cell

            excel.WriteToCell(1, 8, temp.ToString()); //updates the planet number

            MessageBox.Show(planetName + " added to" + " sheet" + sheet);
            PlanetOrganizer.Text = "Insert Planet Name";

            excel.Close();
        }
        private void ReplacePlanet(int sheet, string newPlanetName)
        {
            Excel excel = OpenFileAt(sheet);

            int planet = (int)excel.ReadCellDouble(1, 8); //read p Tally
            int temp = planet+1; //get it ot the next row

            excel.WriteToCell(temp, 2, planetName); //put the planet in the box
            excel.WriteToCell(temp, 1, temp.ToString()); //updates the number next to the cell

            excel.WriteToCell(1, 8, temp.ToString()); //updates the planet number

            MessageBox.Show(planetName + " added to" + " sheet" + sheet);
            PlanetOrganizer.Text = "Insert Planet Name";

            excel.Close();
        }

        private void ClearGrowList(Excel excel)
        {
            for (int i = 2; i < 30; i++)
            {
                excel.WriteToCell(i, 11, "");
            }
           // Console.WriteLine("Grow List Cleared");
        }
        private void ClearZoundsList(Excel excel, int planets)
        {
            for(int i = 1; i <= planets; i++)
            {
                excel.WriteToCell(2, 8, 0.ToString());
                excel.WriteToCell(i, 5, "");
            }
            //Console.WriteLine("Zounds List Cleared");
        }
        private void ClearNDList(Excel excel)
        {
            for (int i = 2; i < 30; i++)
            {
                excel.WriteToCell(i, 14, "");
            }
            // Console.WriteLine("Grow List Cleared");
        }
        private void PlanetSorter_Click(object sender, EventArgs e)
        {
            string planetName = PlanetOrganizer.Text;

            for (int i = 0; i < planetName.Length; i++)
            {
                if (planetName[i].Equals('A') && planetName[i + 1].Equals('r') && planetName[i + 2].Equals('c') && i + 2 < planetName.Length)
                {
                    AddPlanet(2, planetName);
                    break;
                }
                else if (planetName[i].Equals('D') && planetName[i + 1].Equals('e') && planetName[i + 2].Equals('s') && i + 2 < planetName.Length) { AddPlanet(3, planetName); break; }
                else if (planetName[i].Equals('E') && planetName[i + 1].Equals('a') && planetName[i + 2].Equals('r') && i + 2 < planetName.Length) { AddPlanet(4, planetName); break; }
                else if (planetName[i].Equals('G') && planetName[i + 1].Equals('r') && planetName[i + 2].Equals('e') && i + 2 < planetName.Length) { AddPlanet(5, planetName); break; }
                else if (planetName[i].Equals('M') && planetName[i + 1].Equals('o') && planetName[i + 2].Equals('u') && i + 2 < planetName.Length) { AddPlanet(6, planetName); break; }
                else if (planetName[i].Equals('O') && planetName[i + 1].Equals('c') && planetName[i + 2].Equals('e') && i + 2 < planetName.Length) { AddPlanet(7, planetName); break; }
                else if (planetName[i].Equals('P') && planetName[i + 1].Equals('a') && planetName[i + 2].Equals('r') && i + 2 < planetName.Length) { AddPlanet(8, planetName); break; }
                else if (planetName[i].Equals('R') && planetName[i + 1].Equals('o') && planetName[i + 2].Equals('c') && i + 2 < planetName.Length) { AddPlanet(9, planetName); break; }
                else if (planetName[i].Equals('V') && planetName[i + 1].Equals('o') && planetName[i + 2].Equals('l') && i + 2 < planetName.Length) { AddPlanet(10, planetName); break; }
                else { } //MessageBox.Show(planetName + " not found!");                             

            }//end i
        }
        private void ReplacePlanet_Click(object sender, EventArgs e)
        {
            string newPlanetName = PlanetOrganizer.Text;

            for (int i = 0; i < newPlanetName.Length; i++)
            {
                if (newPlanetName[i].Equals('A') && newPlanetName[i + 1].Equals('r') && newPlanetName[i + 2].Equals('c') && i + 2 < newPlanetName.Length)
                {
                    AddPlanet(2, newPlanetName);
                    break;
                }
                else if (newPlanetName[i].Equals('D') && newPlanetName[i + 1].Equals('e') && newPlanetName[i + 2].Equals('s') && i + 2 < newPlanetName.Length) { AddPlanet(3, newPlanetName); break; }
                else if (newPlanetName[i].Equals('E') && newPlanetName[i + 1].Equals('a') && newPlanetName[i + 2].Equals('r') && i + 2 < newPlanetName.Length) { AddPlanet(4, newPlanetName); break; }
                else if (newPlanetName[i].Equals('G') && newPlanetName[i + 1].Equals('r') && newPlanetName[i + 2].Equals('e') && i + 2 < newPlanetName.Length) { AddPlanet(5, newPlanetName); break; }
                else if (newPlanetName[i].Equals('M') && newPlanetName[i + 1].Equals('o') && newPlanetName[i + 2].Equals('u') && i + 2 < newPlanetName.Length) { AddPlanet(6, newPlanetName); break; }
                else if (newPlanetName[i].Equals('O') && newPlanetName[i + 1].Equals('c') && newPlanetName[i + 2].Equals('e') && i + 2 < newPlanetName.Length) { AddPlanet(7, newPlanetName); break; }
                else if (newPlanetName[i].Equals('P') && newPlanetName[i + 1].Equals('a') && newPlanetName[i + 2].Equals('r') && i + 2 < newPlanetName.Length) { AddPlanet(8, newPlanetName); break; }
                else if (newPlanetName[i].Equals('R') && newPlanetName[i + 1].Equals('o') && newPlanetName[i + 2].Equals('c') && i + 2 < newPlanetName.Length) { AddPlanet(9, newPlanetName); break; }
                else if (newPlanetName[i].Equals('V') && newPlanetName[i + 1].Equals('o') && newPlanetName[i + 2].Equals('l') && i + 2 < newPlanetName.Length) { AddPlanet(10, newPlanetName); break; }
                else { } //MessageBox.Show(newPlanetName + " not found!");                             

            }//end i


        }

        /// <summary>
        /// Replaces a character in astring
        /// </summary>
        /// <param name="num">Integer in the string aray</param>
        /// <param name="replacement">character you're replacing it with</param>
        /// <param name="str">original string</param>
        /// <returns></returns>
        public string StringReplacer(int num , char replacement, string str)
        {
            StringBuilder sb = new StringBuilder(str);
            sb[num] = replacement;
            return sb.ToString();
        }
        private Excel OpenFileAt(int num)
        {
            Excel excel = new Excel(excelPath, num);
            return excel;
        }

        
    }
}
