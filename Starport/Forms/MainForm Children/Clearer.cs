using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarportExcel
{
    /// <summary>
    /// Call these methods to clear the lists
    /// </summary>
    internal class Clearer : MainForm
    {
        public static void ClearBuildList(Excel excel)
        {
            int planets = (int)excel.ReadCellDouble(1, 15);

            excel.WriteToCell(1, 15, "");
            for (int i = 1; i <= planets; i++)
            {
                excel.WriteToCell(i, 1, "");
                excel.WriteToCell(i, 2, "");
                excel.WriteToCell(i, 3, "");
                excel.WriteToCell(i, 4, "");
                excel.WriteToCell(i, 5, "");
                excel.WriteToCell(i, 6, "");
                excel.WriteToCell(i, 7, "");
                excel.WriteToCell(i, 8, "");
                excel.WriteToCell(i, 9, "");
                excel.WriteToCell(i, 10, "");
                excel.WriteToCell(i, 11, "");
            }
            Console.WriteLine("Build List Cleared");
        }

        public static void ClearConstructionList(Excel excel)
        {
            for (int i = 2; i < Program.GetMax(); i++)
            {
                excel.WriteToCell(i, 24, "");
                excel.WriteToCell(i, 25, "");
            }
            // Console.WriteLine("Con List Cleared");
        }

        public static void ClearDDList(Excel excel)
        {
            for (int i = 2; i < Program.GetMax(); i++)
            {
                excel.WriteToCell(i, 19, "");
                //excel.WriteToCell(i, 17, "");
            }
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

        public static void ClearWeakList(Excel excel)
        {
            for (int i = 2; i < Program.GetMax(); i++)
            {
                excel.WriteToCell(i, 21, "");
                excel.WriteToCell(i, 22, "");
            }
            // Console.WriteLine("Weak Solar List Cleared");
        }

        public static void ClearZoundsList(Excel excel, int planets)
        {
            excel.WriteToCell(2, 8, 0.ToString());
            for (int i = 1; i <= planets; i++)
            {
                excel.WriteToCell(i, 5, "");
            }
            //Console.WriteLine("Zounds List Cleared");
        }
    }
}