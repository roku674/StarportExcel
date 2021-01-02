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

            double arcticsZ = excel.ReadCellDouble(3, 3); //D4
            double arctics = excel.ReadCellDouble(3, 2); //C4

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
            //column 11
            Excel excel = OpenFile(1);
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
