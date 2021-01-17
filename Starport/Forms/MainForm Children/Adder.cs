using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace StarportExcel
{
    class Adder : MainForm
    {
        public static void AddPlanet(int sheet, string planetName, TextBox PlanetOrganizer)
        {
            Excel excel = OpenFileAt(sheet);

            int planet = (int)excel.ReadCellDouble(1, 8); //read p Tally
            int temp = planet + 1; //get it ot the next row

            excel.WriteToCell(temp, 1, temp.ToString()); //updates the number next to the cell
            excel.WriteToCell(temp, 2, planetName); //put the planet in the box


            excel.WriteToCell(1, 8, temp.ToString()); //updates the planet number

            MessageBox.Show(planetName + " added to row " + temp + " sheet " + sheet, "Completed");
            PlanetOrganizer.Text = "Insert Planet Name";

            excel.Close();
        }

        public static void AddToZounds(string colony, Excel excel)
        {
            int zoundsCount = (int)excel.ReadCellDouble(2, 8);
            zoundsCount++; //if it's 0 don't put it in the 0 slot

            excel.WriteToCell(zoundsCount, 4, zoundsCount.ToString()); // this is the 1 2 3 4
            excel.WriteToCell(zoundsCount, 5, colony); //put colony in here //
            int temp = zoundsCount + 1;
            Console.WriteLine(colony + " added to Zounds to cell [F," + temp + "]");

            excel.WriteToCell(2, 8, zoundsCount.ToString());// changes the total zounds 

        }
        public static void AddToGrow(string colony, Excel excel)
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
        public static void AddToND(string colony, Excel excel)
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

        private static Excel OpenFileAt(int num)
        {
            Excel excel = new Excel(excelPath, num);
            return excel;
        }

    }
}
