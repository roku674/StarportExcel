﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarportExcel
{
    /// <summary>
    /// Call these methods to clear the lists
    /// </summary>
    class Clearer : MainForm
    {
        public static void ClearZoundsList(Excel excel, int planets)
        {
            excel.WriteToCell(2, 8, 0.ToString());
            for (int i = 1; i <= planets; i++)
            {
                excel.WriteToCell(i, 5, "");
            }
            //Console.WriteLine("Zounds List Cleared");
        }
        public static void ClearGrowList(Excel excel)
        {
            for (int i = 2; i < Program.GetMax(); i++)
            {
                excel.WriteToCell(i, 10, "");
                excel.WriteToCell(i, 11, "");
            }
            // Console.WriteLine("Grow List Cleared");
        }
        public static void ClearNDList(Excel excel)
        {
            for (int i = 2; i < Program.GetMax(); i++)
            {
                excel.WriteToCell(i, 13, "");
                excel.WriteToCell(i, 14, "");
            }
            // Console.WriteLine("Grow List Cleared");
        }
        public static void ClearDDList(Excel excel)
        {
            for (int i = 2; i < Program.GetMax(); i++)
            {
                excel.WriteToCell(i, 19, "");
                //excel.WriteToCell(i, 17, "");
            }
        }

    }
}