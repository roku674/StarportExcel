using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StarportExcel
{
	public partial class GetPlanetByTypeForm : Form
    {
        string excelPath = "";

        public GetPlanetByTypeForm()
		{
			InitializeComponent();
		}

        private void Arctics_Click(object sender, EventArgs e)
        {
            if (numberBox.Text != null && numberBox.Text != "" && numberBox.Text != "Insert Planet Number here then press the planet type Button.")
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(2);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
                //excel.Close();
            }           
        }

        private void Deserts_Click(object sender, EventArgs e)
        {
            if (numberBox.Text != null && numberBox.Text != "" && numberBox.Text != "Insert Planet Number here then press the planet type Button.")
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(3);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
                //excel.Close();
            }
        }

        private void Earths_Click(object sender, EventArgs e)
        {
            if (numberBox.Text != null && numberBox.Text != "" && numberBox.Text != "Insert Planet Number here then press the planet type Button.")
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(4);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
                //excel.Close();
            }
        }

        private void Greenhouses_Click(object sender, EventArgs e)
        {
            if (numberBox.Text != null && numberBox.Text != "" && numberBox.Text != "Insert Planet Number here then press the planet type Button.")
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(5);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
               // excel.Close();
            }
        }

        private void Mountains_Click(object sender, EventArgs e)
        {
            if (numberBox.Text != null && numberBox.Text != "" && numberBox.Text != "Insert Planet Number here then press the planet type Button.")
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(6);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
                //excel.Close();
            }
        }

        private void Oceanics_Click(object sender, EventArgs e)
        {
            if (numberBox.Text != null && numberBox.Text != "" && numberBox.Text != "Insert Planet Number here then press the planet type Button.")
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(7);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
                //excel.Close();
            }
        }

        private void Paradises_Click(object sender, EventArgs e)
        {
            if (numberBox.Text != null && numberBox.Text != "" && numberBox.Text != "Insert Planet Number here then press the planet type Button.")
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(8);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
                //excel.Close();
            }
        }

        private void Rockies_Click(object sender, EventArgs e)
        {
            if (numberBox.Text != null && numberBox.Text != "" && numberBox.Text != "Insert Planet Number here then press the planet type Button.")
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(9);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
                //excel.Close();
            }
        }

        private void Volcanics_Click(object sender, EventArgs e)
        {
            if (numberBox.Text != null && numberBox.Text != "")
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(10);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
                //excel.Close();
            }
        }
        private Excel OpenFileAt(int num)
        {
            Excel excel = new Excel(excelPath, num);
            return excel;
        }
        public void SetExcelPath(string path)
        {
            excelPath = path;
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }
    }//CustomMessageBox
}//namespace
