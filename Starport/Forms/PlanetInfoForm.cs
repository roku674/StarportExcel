﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StarportExcel.Structs;

namespace StarportExcel
{
    public partial class PlanetInfoForm : Form
    {
        private string excelPath;
        private string ownerName = "Panther";

        public PlanetInfoForm()
        {
            InitializeComponent();
        }
        private void AddColonyInfoButton_Click(object sender, EventArgs e)
        {

            string info = InfoBox.Text;

            if (info.Equals("") || info.Equals(null))
            {
                MessageBox.Show("No Information Found!", "Failed");
                return;
            }
            //Console.Write(info);
            else
            {
                StringReader reader = new StringReader(info);
                string firstLine = reader.ReadLine();
                firstLine = MainForm.RemoveSpaces(firstLine);
                for (int i = 0; i < info.Length; i++)
                {
                    if (firstLine.Equals(ownerName + ".Research.Arc") || firstLine.Equals(ownerName + ".Build.Arc") || firstLine.Equals(ownerName + ".Build.Arc.Z") ||
                           firstLine.Equals(ownerName + ".Research.Des") || firstLine.Equals(ownerName + ".Build.Des") || firstLine.Equals(ownerName + ".Build.Des.Z") ||
                           firstLine.Equals(ownerName + ".Research.Ear") || firstLine.Equals(ownerName + ".Build.Ear") || firstLine.Equals(ownerName + ".Build.Ear.Z") ||
                           firstLine.Equals(ownerName + ".Research.Gre") || firstLine.Equals(ownerName + ".Build.Gre") || firstLine.Equals(ownerName + ".Build.Gre.Z") ||
                           firstLine.Equals(ownerName + ".Research.Mou") || firstLine.Equals(ownerName + ".Build.Gre") || firstLine.Equals(ownerName + ".Build.Gre.Z") ||
                           firstLine.Equals(ownerName + ".Research.Oce") || firstLine.Equals(ownerName + ".Build.Oce") || firstLine.Equals(ownerName + ".Build.Oce.Z") ||
                           firstLine.Equals(ownerName + ".Research.IGP") || firstLine.Equals(ownerName + ".Build.IGP") || firstLine.Equals(ownerName + ".Build.IGP.Z"))

                    {
                        //console.WriteLine(firstLine);
                        Adder.BuildZoundsDestroy(info, true, DefendedCheckBox.Checked);
                        break;
                    }
                    else if (firstLine.Equals(ownerName + ".Research.Roc") || firstLine.Equals(ownerName + ".Build.Roc") || firstLine.Equals(ownerName + ".Build.Roc.Z") ||
                           firstLine.Equals(ownerName + ".Research.Vol") || firstLine.Equals(ownerName + ".Build.Vol") || firstLine.Equals(ownerName + ".Build.Vol.Z")) 
                     {
                        Adder.BuildZoundsDestroy(info, false, DefendedCheckBox.Checked);
                     }

                    else if (i + 2 < info.Length && info[i].Equals('A') && info[i + 1].Equals('r') && info[i + 2].Equals('c'))
                    {
                        //i+3 and i+4 are the numbers if its triple digit 3 4 5
                        if (info[i + 5] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string s = str1 + str2;

                            Adder.AddColonyInfo(2, info, int.Parse(s));
                            break;
                        }
                        else if (info[i + 6] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string str3 = info[i + 5].ToString();
                            string s = str1 + str2 + str3;

                            Adder.AddColonyInfo(2, info, int.Parse(s));
                            break;
                        }

                    }
                    else if (i + 2 < info.Length && info[i].Equals('D') && info[i + 1].Equals('e') && info[i + 2].Equals('s'))
                    {

                        if (info[i + 5] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string s = str1 + str2;

                            Adder.AddColonyInfo(3, info, int.Parse(s));
                            break;
                        }
                        else if (info[i + 6] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string str3 = info[i + 5].ToString();
                            string s = str1 + str2 + str3;

                            Adder.AddColonyInfo(3, info, int.Parse(s));
                            break;
                        }
                    }
                    else if (i + 2 < info.Length && info[i].Equals('E') && info[i + 1].Equals('a') && info[i + 2].Equals('r'))
                    {

                        if (info[i + 5] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string s = str1 + str2;

                            Adder.AddColonyInfo(4, info, int.Parse(s));
                            break;
                        }
                        else if (info[i + 6] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string str3 = info[i + 5].ToString();
                            string s = str1 + str2 + str3;

                            Adder.AddColonyInfo(4, info, int.Parse(s));
                            break;
                        }
                    }
                    else if (i + 2 < info.Length && info[i].Equals('G') && info[i + 1].Equals('r') && info[i + 2].Equals('e'))
                    {

                        if (info[i + 5] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string s = str1 + str2;

                            Adder.AddColonyInfo(5, info, int.Parse(s));
                            break;
                        }
                        else if (info[i + 6] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string str3 = info[i + 5].ToString();
                            string s = str1 + str2 + str3;

                            Adder.AddColonyInfo(5, info, int.Parse(s));
                            break;
                        }
                    }
                    else if (i + 2 < info.Length && info[i].Equals('M') && info[i + 1].Equals('o') && info[i + 2].Equals('u'))
                    {

                        if (info[i + 5] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string s = str1 + str2;

                            Adder.AddColonyInfo(6, info, int.Parse(s));
                            break;
                        }
                        else if (info[i + 6] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string str3 = info[i + 5].ToString();
                            string s = str1 + str2 + str3;

                            Adder.AddColonyInfo(6, info, int.Parse(s));
                            break;
                        }
                    }
                    else if (i + 2 < info.Length && info[i].Equals('O') && info[i + 1].Equals('c') && info[i + 2].Equals('e'))
                    {

                        if (info[i + 5] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string s = str1 + str2;

                            Adder.AddColonyInfo(7, info, int.Parse(s));
                            break;
                        }
                        else if (info[i + 6] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string str3 = info[i + 5].ToString();
                            string s = str1 + str2 + str3;

                            Adder.AddColonyInfo(7, info, int.Parse(s));
                            break;
                        }
                    }
                    else if (i + 2 < info.Length && info[i].Equals('I') && info[i + 1].Equals('G') && info[i + 2].Equals('P'))
                    {

                        if (info[i + 5] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string s = str1 + str2;

                            Adder.AddColonyInfo(8, info, int.Parse(s));
                            break;
                        }
                        else if (info[i + 6] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string str3 = info[i + 5].ToString();
                            string s = str1 + str2 + str3;

                            Adder.AddColonyInfo(8, info, int.Parse(s));
                            break;
                        }
                    }
                    else if (i + 2 < info.Length && info[i].Equals('R') && info[i + 1].Equals('o') && info[i + 2].Equals('c'))
                    {

                        if (info[i + 5] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string s = str1 + str2;

                            Adder.AddColonyInfo(9, info, int.Parse(s));
                            break;
                        }
                        else if (info[i + 6] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string str3 = info[i + 5].ToString();
                            string s = str1 + str2 + str3;

                            Adder.AddColonyInfo(9, info, int.Parse(s));
                            break;
                        }
                    }
                    else if (i + 2 < info.Length && info[i].Equals('V') && info[i + 1].Equals('o') && info[i + 2].Equals('l'))
                    {
                        if (info[i + 5] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string s = str1 + str2;

                            Adder.AddColonyInfo(10, info, int.Parse(s));
                            break;
                        }
                        else if (info[i + 6] == '.')
                        {
                            string str1 = info[i + 3].ToString();
                            string str2 = info[i + 4].ToString();
                            string str3 = info[i + 5].ToString();
                            string s = str1 + str2 + str3;

                            Adder.AddColonyInfo(10, info, int.Parse(s));
                            break;
                        }
                    }                   
                    //check for builds
                }
                //MessageBox.Show(firstLine + " Information Added!", "Completed");
                InfoBox.Text = "";
            }           
        }
        private void SortBuildsButton_Click(object sender, EventArgs e)
        {
            
            Excel excel = OpenFileAt(11);
            int totalBuilds = excel.ReadCellInt(1, 15); //amount of builds num
            string[,] planets = new string[totalBuilds, 8];
            Console.WriteLine(planets.GetLength(0) + " " + planets.GetLength(1));

            for (int i = 1; i <= planets.GetLength(0); i++) //establish the array
            {
                bool tempBools = false;
                //Console.WriteLine(i);
                planets[i-1,0] = excel.ReadCellString(i, 2);
                planets[i-1,1] = excel.ReadCellString(i, 3);
                planets[i-1,2] = excel.ReadCellString(i, 4);

                tempBools = excel.ReadCellBool(i, 5);
                planets[i-1,3] = tempBools.ToString();

                tempBools = excel.ReadCellBool(i, 6);
                planets[i-1,4] = tempBools.ToString();

                tempBools = excel.ReadCellBool(i, 7);
                planets[i-1,5] =tempBools.ToString();

                tempBools = excel.ReadCellBool(i, 8);
                planets[i-1,6] = tempBools.ToString();

                int tempInt = excel.ReadCellInt(i, 9);
                planets[i-1,7] = tempInt.ToString();
            }
            //Clearer.ClearBuildList(excel);

            Coordinates origin;
            origin = Algorithms.GetCoordinates("(0,0)");

            ColonyInfo[] colInfo = Algorithms.SortPlanetsByXAndY(planets, origin, Algorithms.GetCoordinates(planets[totalBuilds - 1, 0])); //get the sorted array

            Clearer.ClearBuildList(excel);

            Console.WriteLine("This algorithm is bad its making tons of duplicates"); /*
            for (int i = 0; i < planets.GetLength(0); i++)
            {                
                for (int j = 0; j < planets.GetLength(0); j++)
                {
                    Coordinates oldList = Algorithms.GetCoordinates(planets[j, 0]);
                    if ((colInfo[i].coords.x == oldList.x) && (colInfo[i].coords.y == oldList.y))
                    {
                        //Console.WriteLine(planets[i, 0] + " ");
                        Adder.AddToBuilds(excel, planets[j, 0], planets[j, 1], planets[j, 2], planets[j, 3], planets[j, 4], planets[j, 5], planets[j, 6], planets[j, 7]);
                    }
                }               
            }
            */
            excel.Close();
            MessageBox.Show("Build List Sorted by System", "Completed");

        }

        private static Excel OpenFileAt(int num)
        {
            Excel excel = new Excel(MainForm.excelPath, num);
            return excel;
        }

        public void SetExcelPath(string path)
        {
            excelPath = path;
        }

        private void ClearBuildsButton_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(11);
            Clearer.ClearBuildList(excel);
            MessageBox.Show("Build List Cleared!", "Message");
            excel.Close();
        }

        private void RemoveDuplicatesButton_Click(object sender, EventArgs e)
        {/*
            Excel excel = OpenFileAt(11);
            int buildList = excel.ReadCellInt(1, 15);
            for(int i = 1; i <= buildList; i++)
            {
                for (int j = 1; j <= buildList; j++)
                {
                    Console.WriteLine(i + " " + j);
                   if (excel.ReadCellString(i, 3).Equals(excel.ReadCellString(j, 3)))
                    {
                        excel.WriteToCell(i, 2, excel.ReadCellString(i + 1, 2));
                        excel.WriteToCell(i, 3, excel.ReadCellString(i + 1, 3));
                        excel.WriteToCell(i, 4, excel.ReadCellString(i + 1, 4));

                        excel.WriteToCell(i, 5, excel.ReadCellBool(i + 1, 5).ToString());
                        excel.WriteToCell(i, 6, excel.ReadCellBool(i + 1, 6).ToString());
                        excel.WriteToCell(i, 7, excel.ReadCellBool(i + 1, 7).ToString());
                        excel.WriteToCell(i, 8, excel.ReadCellBool(i + 1, 8).ToString());
                        excel.WriteToCell(i, 9, excel.ReadCellDouble(i + 1, 9).ToString());

                        int temp = buildList - 1;
                        excel.WriteToCell(1, 15, temp.ToString());
                    }
                
            }
            excel.Close();
            */
            MessageBox.Show("Duplicates removed from build List!", "Message");
        }

        private void RenameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RenameCheckBox.Checked)
            {
                ownerName = renameTextBox.Text;
            }
        }
    }
}
