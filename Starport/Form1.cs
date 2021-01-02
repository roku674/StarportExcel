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

namespace Starport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateQuote_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFile(1);

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

            double paradisesZ = excel.ReadCellDouble(9, 3);
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

        }

        private void FindGrowing_Click(object sender, EventArgs e)
        {

            //all planets start at 2C
            //zounds start at 2F
            //Tallies are I2 == Planet I3 == Zoudns
            for (int j = 2; j < 10; j++)
            {
                Excel excel = OpenFile(j);

                int planet = (int)excel.ReadCellDouble(8, 2);

                for (int i = 1; i < planet+1; i++)
                {
                    if (excel.ReadCellString(i, 2) != "")
                    {
                        if (excel.ReadCellString(i, 1) == "")
                        {
                            excel.WriteToCell(i, 1, i.ToString()); //writes to the cell to the left and just puts a number in it
                        }
                        string box = excel.ReadCellString(i, 2);


                    }
                }//end of i loop

                excel.Save();
                excel.Close();
            }// end of J loop
        }
        private void AddToGrow(string colony)
        {
            Excel excel = OpenFile(1);
            //column 11 is growing on totals
            for (int i = 2; i < 50; i++)
            {
                string box = excel.ReadCellString(i, 11);
                if (box == "")
                {
                    if (excel.ReadCellString(i, 10) == "")
                    {
                        excel.WriteToCell(i, 10, i.ToString()); //writes to the cell to the left and just puts a number in it
                    }

                    excel.WriteToCell(i, 11, colony);
                }
            }

            excel.Save();
            excel.Close();
        }

        private void CheckGrow_Click(object sender, EventArgs e)
        {
            int max = 50;
            Excel excel = OpenFile(1);
            for(int i = 2; i < max; i++)
            {
                string box = excel.ReadCellString(i, 11);
                if(box != "")
                {
                    //Console.WriteLine(box);
                    for (int j = 0; j < box.Length; j++) //itterate through the string character by character
                    {
                        if (box[j].Equals('.'))
                        {
                            if (j + 5 <= box.Length && box[j + 5].Equals('G') )
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

                                for(int k = i; k < max; k++)
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

            excel.Save(); 
            excel.Close();
            MessageBox.Show("Closed");
        }

        private Excel OpenFile(int num)
        {
            Excel excel = new Excel(@"G:\My Drive\Personal Stuff\Starport\PlanetTallies.xlsx", num);
            return excel;
        }
        public void WriteData(int num)
        {
            Excel excel = OpenFile(num);

            excel.Save();
            excel.Close();
        }

        

    }
}
