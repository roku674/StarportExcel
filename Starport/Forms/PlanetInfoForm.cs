﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarportExcel
{
    public partial class PlanetInfoForm : Form
    {
        private string excelPath;

        public PlanetInfoForm()
        {
            InitializeComponent();
        }

        private void AddInfoButton_Click(object sender, EventArgs e)
        {
            string info = InfoBox.Text;

            //Console.Write(info);

            for(int i = 0; i < info.Length; i++)
            {
                if (i + 2 < info.Length && info[i].Equals('A') && info[i + 1].Equals('r') && info[i + 2].Equals('c'))
                {
                    //i+3 and i+4 are the numbers if its triple digit 3 4 5
                    if (info[i + 5] == '.')
                    {
                        string str1 = info[i + 3].ToString();
                        string str2 = info[i + 4].ToString();
                        string s = str1 + str2;

                        Adder.AddInfo(2, info, int.Parse(s));
                        break;
                    }
                    else if (info[i + 6] == '.')
                    {
                        string str1 = info[i + 3].ToString();
                        string str2 = info[i + 4].ToString();
                        string str3 = info[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        Adder.AddInfo(2, info, int.Parse(s));
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

                        Adder.AddInfo(3, info, int.Parse(s));
                        break;
                    }
                    else if (info[i + 6] == '.')
                    {
                        string str1 = info[i + 3].ToString();
                        string str2 = info[i + 4].ToString();
                        string str3 = info[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        Adder.AddInfo(3, info, int.Parse(s));
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

                        Adder.AddInfo(4, info, int.Parse(s));
                        break;
                    }
                    else if (info[i + 6] == '.')
                    {
                        string str1 = info[i + 3].ToString();
                        string str2 = info[i + 4].ToString();
                        string str3 = info[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        Adder.AddInfo(4, info, int.Parse(s));
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

                        Adder.AddInfo(5, info, int.Parse(s));
                        break;
                    }
                    else if (info[i + 6] == '.')
                    {
                        string str1 = info[i + 3].ToString();
                        string str2 = info[i + 4].ToString();
                        string str3 = info[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        Adder.AddInfo(5, info, int.Parse(s));
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

                        Adder.AddInfo(6, info, int.Parse(s));
                        break;
                    }
                    else if (info[i + 6] == '.')
                    {
                        string str1 = info[i + 3].ToString();
                        string str2 = info[i + 4].ToString();
                        string str3 = info[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        Adder.AddInfo(6, info, int.Parse(s));
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

                        Adder.AddInfo(7, info, int.Parse(s));
                        break;
                    }
                    else if (info[i + 6] == '.')
                    {
                        string str1 = info[i + 3].ToString();
                        string str2 = info[i + 4].ToString();
                        string str3 = info[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        Adder.AddInfo(7, info, int.Parse(s));
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

                        Adder.AddInfo(8, info, int.Parse(s));
                        break;
                    }
                    else if (info[i + 6] == '.')
                    {
                        string str1 = info[i + 3].ToString();
                        string str2 = info[i + 4].ToString();
                        string str3 = info[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        Adder.AddInfo(8, info, int.Parse(s));
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

                        Adder.AddInfo(9, info, int.Parse(s));
                        break;
                    }
                    else if (info[i + 6] == '.')
                    {
                        string str1 = info[i + 3].ToString();
                        string str2 = info[i + 4].ToString();
                        string str3 = info[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        Adder.AddInfo(9, info, int.Parse(s));
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

                        Adder.AddInfo(10, info, int.Parse(s));
                        break;
                    }
                    else if (info[i + 6] == '.')
                    {
                        string str1 = info[i + 3].ToString();
                        string str2 = info[i + 4].ToString();
                        string str3 = info[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        Adder.AddInfo(10, info, int.Parse(s));
                        break;
                    }
                }

                //check for builds
            }
        }
        public void SetExcelPath(string path)
        {
            excelPath = path;
        }
    }
}