using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void createQuote_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        public void OpenFile()
        {
            Excel excel = new Excel(@"G:\My Drive\Personal Stuff\Starport\PlanetTallies.xlsx", 1);

            //MessageBox.Show(excel.ReadCell(1, 1));
        }
    }
}
