﻿using Microsoft.Office.Interop.Excel;
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
using System.IO;

namespace StarportExcel
{    
    public partial class MainForm : Form
    {
        public static string excelPath = @"G:\My Drive\Personal Stuff\Starport\PlanetTallies.xlsx";
        
        public MainForm()
        {
            InitializeComponent();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            //MessageBox.Show("Make Sure the excel sheet is closed before pressing anything!", "Warning");
            Excel.Kill();
        }

        // Tool strip stuff from here down

        private void NewFileToolStripButton_Click(object sender, EventArgs e)
        {

        }
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            openFileDialog1.Title = "Open the Excel Sheet";
            openFileDialog1.ShowDialog();

            //Check to see if a filename was given
            if (openFileDialog1.FileName != "" && openFileDialog1.FileName != null)
            {
                SetExcelPath(File.ReadAllText(openFileDialog1.FileName));
            }
        }
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {

        }
        private void HelpMeNiggaDamnToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Literally will make a more elaborate help than this later \n sidenote checkout https://github.com/roku674/StarportExcel", "Message");
        }
        private void PrintToolStripButton_Click(object sender, EventArgs e)
        {

        }
        //End of Tool strip stuff
        private void ReturnPlanet_Click(object sender, EventArgs e)
        {
            PlanetTypeForm customMessageBox = new PlanetTypeForm();
            customMessageBox.SetExcelPath(excelPath);
            customMessageBox.ShowDialog();           
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
                    //i+3 and i+4 are the numbers if its triple digit 3 4 5
                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(2, int.Parse(s), newPlanetName);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(2, int.Parse(s), newPlanetName);
                        break;
                    }

                }
                else if (newPlanetName[i].Equals('D') && newPlanetName[i + 1].Equals('e') && newPlanetName[i + 2].Equals('s') && i + 2 < newPlanetName.Length)
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(3, int.Parse(s), newPlanetName);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(3, int.Parse(s), newPlanetName);
                        break;
                    }
                }
                else if (newPlanetName[i].Equals('E') && newPlanetName[i + 1].Equals('a') && newPlanetName[i + 2].Equals('r') && i + 2 < newPlanetName.Length)
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(4, int.Parse(s), newPlanetName);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(4, int.Parse(s), newPlanetName);
                        break;
                    }
                }
                else if (newPlanetName[i].Equals('G') && newPlanetName[i + 1].Equals('r') && newPlanetName[i + 2].Equals('e') && i + 2 < newPlanetName.Length)
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(5, int.Parse(s), newPlanetName);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(5, int.Parse(s), newPlanetName);
                        break;
                    }
                }
                else if (newPlanetName[i].Equals('M') && newPlanetName[i + 1].Equals('o') && newPlanetName[i + 2].Equals('u') && i + 2 < newPlanetName.Length)
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(6, int.Parse(s), newPlanetName);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(6, int.Parse(s), newPlanetName);
                        break;
                    }
                }
                else if (newPlanetName[i].Equals('O') && newPlanetName[i + 1].Equals('c') && newPlanetName[i + 2].Equals('e') && i + 2 < newPlanetName.Length)
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(7, int.Parse(s), newPlanetName);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(7, int.Parse(s), newPlanetName);
                        break;
                    }
                }
                else if (newPlanetName[i].Equals('P') && newPlanetName[i + 1].Equals('a') && newPlanetName[i + 2].Equals('r') && i + 2 < newPlanetName.Length)
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(8, int.Parse(s), newPlanetName);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(8, int.Parse(s), newPlanetName);
                        break;
                    }
                }
                else if (newPlanetName[i].Equals('R') && newPlanetName[i + 1].Equals('o') && newPlanetName[i + 2].Equals('c') && i + 2 < newPlanetName.Length)
                {

                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(9, int.Parse(s), newPlanetName);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(9, int.Parse(s), newPlanetName);
                        break;
                    }
                }
                else if (newPlanetName[i].Equals('V') && newPlanetName[i + 1].Equals('o') && newPlanetName[i + 2].Equals('l') && i + 2 < newPlanetName.Length)
                {
                    if (newPlanetName[i + 5] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string s = str1 + str2;

                        ReplacePlanetMethod(10, int.Parse(s), newPlanetName);
                        break;
                    }
                    else if (newPlanetName[i + 6] == '.')
                    {
                        string str1 = newPlanetName[i + 3].ToString();
                        string str2 = newPlanetName[i + 4].ToString();
                        string str3 = newPlanetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        ReplacePlanetMethod(10, int.Parse(s), newPlanetName);
                        break;
                    }
                }
                else { } //MessageBox.Show(newPlanetName + " not found!");                             

            }//end i
        }
        private void ClearNeedsDefense_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(1);
            ClearNDList(excel);
            excel.Close();
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

            double invasions = excel.ReadCellDouble(15, 2);

            Console.WriteLine("Arctics " + arcticsZ + "/" + arctics +
                "|~{yellow}~Deserts" + desertsZ + "/" + deserts +
                "|~{green}~Earths" + earthsZ + "/" + earths +
                "|~{orange}~Greenhouses" + greenhousesZ + "/" + greenhouses +
                "|~{purple}~Mountains" + mountainsZ + "/" + mountains +
                "|~{blue}~Oceanics" + oceansZ + "/" + oceans +
                "|~{pink}~Paradises ~{link}1:" + paradises + "~" +
                "|~{gray}~Rockies" + rockiesZ + "/" + rockies +
                "|~{red}~Volcanics" + volcanicsZ + "/" + volcanics +
                "|~{cyan}~ Sum: " + totalsZ + " Zounds / " + totals + "~{link}21: Colonies~");

            itsMyWindow.Text = "Arctic " + arcticsZ + "/" + arctics +
                "|~{yellow}~Desert " + desertsZ + "/" + deserts +
                "|~{green}~Earth " + earthsZ + "/" + earths +
                "|~{orange}~Green " + greenhousesZ + "/" + greenhouses +
                "|~{purple}~Mount " + mountainsZ + "/" + mountains +
                "|~{blue}~Ocean " + oceansZ + "/" + oceans +
                "|~{pink}~Paradises ~{link}1:" + paradises + "~" +
                "|~{gray}~Rock " + rockiesZ + "/" + rockies +
                "|~{red}~Volc " + volcanicsZ + "/" + volcanics +
                "|~{link}25:Captured:~ " + invasions + 
                "|~{cyan}~ Sum: " + totalsZ + " Zounds / " + totals + "~{link}21: Colonies~";
        }
        private void CheckGrow_Click(object sender, EventArgs e)
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
        private void ClearGrow_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel(excelPath, 1);
            ClearGrowList(excel);
            excel.Close();
        }
        private void CheckParenthesis_Click(object sender, EventArgs e)
        {

            for (int j = 2; j <= 12; j++) // goes through each sheet
            {
                Console.WriteLine("Not scanning the Invasion list until i figure out what's going wrong");
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
                    //Console.WriteLine(planet);
                }
                //Console.WriteLine("Planet Total: " + planet);
                for (int i = planet+1; i >= 1; i--) // goes through the planet list
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
        private void CheckND_Click(object sender, EventArgs e)
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
            MessageBox.Show("Find Grow Done", "Completed");
        }
        private void FindTotals_Click(object sender, EventArgs e)
        {
            //open them up and clear them
            Excel totals = OpenFileAt(1);

            ClearNDList(totals);
            ClearGrowList(totals);

            Console.WriteLine("Beginning Totals...\n");

            for (int k = 2; k <= 10; k++) // goes through each sheet
            {
                Excel excel = OpenFileAt(k);

                int planet = (int)excel.ReadCellDouble(1, 8);

                excel.WriteToCell(2, 8, 0.ToString());//clear zounds num

                int temp = 0;
                for (int j = 1; j <= planet + 15; j++) // goes through the planet list
                {
                    if (excel.ReadCellString(j, 2) != "") //if there's something there
                    {                       
                        excel.WriteToCell(j, 1, j.ToString()); //writes to the cell to the left and just puts a number in it
                        temp = j;

                        string planetName = excel.ReadCellString(j, 2); //read the name of the planet
                        //Console.WriteLine(planetName + " found");
                        int num = j + 1;
                        //if statement by planet type
                            if (k == 2)
                            {                               
                                string formula = "=Arctics!C" + num;
                                CheckTotals(totals, excel, planetName, formula);
                                //Console.WriteLine(planetName + " found");                                        
                            }
                            else if (k == 3) {
                                string formula = "=Deserts!C" + num;
                                CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 4) {
                                string formula = "=Earths!C" + num;
                                CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 5) {
                                string formula = "=Greenhouses!C" + num;
                                CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 6) {
                                string formula = "=Mountains!C" + num;
                                CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 7) {
                                string formula = "=Oceanics!C" + num;
                                CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 8) {
                                string formula = "=Paradises!C" + num;
                                CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 9) {
                                string formula = "=Rockies!C" + num;
                                CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 10) {
                                string formula = "=Volcanics!C" + num;
                                CheckTotals(totals, excel, planetName, formula);
                            }
                            else { } //MessageBox.Show(planetName + " not found!");                             
                    }
            
                }//end of j loop

                excel.WriteToCell(1, 8, temp.ToString()); //changes the total planets
                //Console.WriteLine("Planet Total: " + temp);

                excel.Close(); //deallocate

            }// end of i loop
            totals.Close();
            Console.Write("Done");
            MessageBox.Show("Find Totals Done", "Completed");
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
            MessageBox.Show("Find Zounds Done", "Completed");
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
                                if (k + 5 < box.Length && box[k + 5].Equals('N'))
                                {
                                    AddToND(box, totals);
                                    break;
                                }
                                else if (k + 6 < box.Length && box[k + 6].Equals('N') )
                                {
                                    AddToND(box, totals);
                                    break;
                                }
                                else if (k + 7 < box.Length && box[k + 7].Equals('N'))
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
            MessageBox.Show("Find Needs Defense Done", "Completed");
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
            MessageBox.Show("Zounds lists Cleared!",  "Completed");
        }

        private void AddToZounds(string colony, Excel excel)
        {
            int zoundsCount = (int)excel.ReadCellDouble(2, 8);
            zoundsCount++; //if it's 0 don't put it in the 0 slot

            excel.WriteToCell(zoundsCount, 5, colony); //put colony in here //
            int temp = zoundsCount + 1;
            Console.WriteLine(colony + " added to Zounds to cell [F," + temp + "]");

            excel.WriteToCell(zoundsCount, 4, zoundsCount.ToString()); // this is the 1 2 3 4

            excel.WriteToCell(2, 8, zoundsCount.ToString());// changes the total zounds 

        }
        private void AddToGrow(string colony, Excel excel)
        {
            //column 11 is growing on totals
            for (int i = 2; i < 500; i++)
            {
                string box = excel.ReadCellString(i, 11); // column L
                if (box == "")
                {
                    excel.WriteToCell(i, 11, colony);
                    int temp = i - 1;
                    excel.WriteToCell(i, 10, temp.ToString()); // put number in the box to the left
                    Console.WriteLine(colony + " added to Knee Grow", "Completed");
                    break;
                }
            }
        }
        private void AddToND(string colony, Excel excel)
        {
            //column 14 is Needs Defense on totals
            for (int i = 2; i < 500; i++)
            {
                string box = excel.ReadCellString(i, 14);
                if (box == "")
                {
                    excel.WriteToCell(i, 14, colony); //put the colony in the slot
                    int temp = i - 1;
                    excel.WriteToCell(i, 13, temp.ToString()); // put number in the box to the left
                    Console.WriteLine(colony + " added to Needs Defense", "Completed");
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

            MessageBox.Show(planetName + " added to row " + temp +  " sheet " + sheet, "Completed");
            PlanetOrganizer.Text = "Insert Planet Name";

            excel.Close();
        }
        private void ReplacePlanetMethod(int sheet,int row, string newPlanetName)
        {
            Excel excel = OpenFileAt(sheet);

            excel.WriteToCell(row, 2, newPlanetName); //put the planet in the box
            //excel.WriteToCell(row, 1, row.ToString()); //updates the number next to the cell

            MessageBox.Show(newPlanetName + " replaced" + " slot" + row + " on" + " sheet" + sheet, "Completed");


            PlanetOrganizer.Text = "Insert Planet Name";

            excel.Close();
        }

        private void ClearGrowList(Excel excel)
        {
            for (int i = 2; i < 1000; i++)
            {
                excel.WriteToCell(i, 10, "");
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
            for (int i = 2; i < 1000; i++)
            {
                excel.WriteToCell(i, 13, "");
                excel.WriteToCell(i, 14, "");
            }
            // Console.WriteLine("Grow List Cleared");
        }
        /// <summary>
        /// Check Totals all at once
        /// </summary>
        /// <param name="planetSheet">Planet page you're on</param>
        /// <param name="planetName">name of planet</param>
        /// <param name="formula">This will be the formula to be inserted</param>
        private void CheckTotals(Excel totalsSheet, Excel planetSheet, string planetName, string formula)
        {

            //Console.WriteLine(" \n Check Totals info: " + planetName + " || " + formula);
            for (int i = 0; i < planetName.Length; i++) //continue from the First planet letter
            {
                if (planetName[i].Equals('.'))
                {
                    if (i + 5 < planetName.Length && planetName[i + 5].Equals('Z'))
                    {
                        AddToZounds(formula, planetSheet);
                    }
                    else { }

                    if (i + 5 < planetName.Length && planetName[i + 5].Equals('G'))
                    {
                        AddToGrow(formula, totalsSheet);
                    }
                    else if (i + 6 < planetName.Length && planetName[i + 6].Equals('G'))
                    {
                        AddToGrow(formula, totalsSheet);
                    }
                    else { }

                    if (i + 6 < planetName.Length && planetName[i + 5].Equals('N') && planetName[i + 6].Equals('D'))
                    {
                        AddToND(formula, totalsSheet);
                    }
                    else if (i + 7 < planetName.Length && planetName[i + 6].Equals('N') && planetName[i + 7].Equals('D'))
                    {
                        AddToND(formula, totalsSheet);
                    }
                    else if (i + 8 < planetName.Length && planetName[i + 7].Equals('N') && planetName[i + 8].Equals('D'))
                    {
                        AddToND(formula, totalsSheet);
                    }
                    else { }
                }
            }

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

        public string GetExcelPath()
        {
            return excelPath;
        }
        public void SetExcelPath(string path)
        {
            excelPath = path;
        }

        private void MainForm_FormClosing(object sender, CancelEventArgs e)
        {
            Excel.Kill();
            //Console.WriteLine("Kill Excel called");
        }

    } //form1
}//namespace