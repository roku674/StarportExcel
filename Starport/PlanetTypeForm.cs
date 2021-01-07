using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StarportExcel
{
	public partial class PlanetTypeForm : Form
    {
        string excelPath = "";
        readonly string outputPath = @"G:\My Drive\Personal Stuff\Starport\Output.txt";
        private StreamWriter output = new StreamWriter(@"G:\My Drive\Personal Stuff\Starport\Output.txt");

        public PlanetTypeForm()
		{
			InitializeComponent();
        }
        private void PlanetTypeForm_Load(object sender, EventArgs e)
        {

        }
        private void PlanetTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseOutput();
        }

        private void Arctics_Click(object sender, EventArgs e)
        {
            int.TryParse(numberBox.Text, out int temp);
            //Console.WriteLine("Temp is : " + temp);

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(2);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
            }
            else
            {
                Excel excel = OpenFileAt(2);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets
                output.WriteLine("Arctics: ");
                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 2)); //column C
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Arctics added to output.txt", "Completed");
            }
        }

        private void Deserts_Click(object sender, EventArgs e)
        {
            int.TryParse(numberBox.Text, out int temp);

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(3);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
            }
            else
            {
                Excel excel = OpenFileAt(3);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Deserts: ");
                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 2)); //column C
                }
                output.Flush();
                excel.Close();

                MessageBox.Show("Deserts added to output.txt", "Completed");
            }
        }

        private void Earths_Click(object sender, EventArgs e)
        {
            int.TryParse(numberBox.Text, out int temp);

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(4);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
            }
            else
            {
                Excel excel = OpenFileAt(4);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Earthlikes: ");
                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 2)); //column C
                }
                output.Flush();
                excel.Close();

                MessageBox.Show("Earthlikes added to output.txt", "Completed");
            }

        }

        private void Greenhouses_Click(object sender, EventArgs e)
        {
            int.TryParse(numberBox.Text, out int temp);

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(5);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
            }
            else
            {
                Excel excel = OpenFileAt(5);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Greenhouses: ");
                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 2)); //column C
                }
                output.Flush();
                excel.Close();

                MessageBox.Show("Greenhouses added to output.txt", "Completed");
            }
        }

        private void Mountains_Click(object sender, EventArgs e)
        {
            int.TryParse(numberBox.Text, out int temp); 

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(6);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
            }
            else
            {
                Excel excel = OpenFileAt(6);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Mountains: ");
                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 2)); //column C
                }
                output.Flush();
                excel.Close();

                MessageBox.Show("Mountains added to output.txt", "Completed");
            }
        }

        private void Oceanics_Click(object sender, EventArgs e)
        {
            int.TryParse(numberBox.Text, out int temp); 

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(7);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
            }
            else
            {
                Excel excel = OpenFileAt(7);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Oceanics: ");
                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 2)); //column C
                }
                output.Flush();
                excel.Close();

                MessageBox.Show("Oceanics added to output.txt", "Completed");
            }
        }

        private void Paradises_Click(object sender, EventArgs e)
        {
            int.TryParse(numberBox.Text, out int temp); 

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(8);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
            }
            else
            {
                Excel excel = OpenFileAt(8);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Paradises: ");
                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 2)); //column C
                }
                output.Flush();
                excel.Close();

                MessageBox.Show("Paradises added to output.txt", "Completed");
            }
        }

        private void Rockies_Click(object sender, EventArgs e)
        {
            int.TryParse(numberBox.Text, out int temp);

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(9);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
            }
            else
            {
                Excel excel = OpenFileAt(9);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Rockies: ");
                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 2)); //column C
                }
                output.Flush();
                excel.Close();

                MessageBox.Show("Rockies added to output.txt", "Completed");
            }
        }

        private void Volcanics_Click(object sender, EventArgs e)
        {
            int.TryParse(numberBox.Text, out int temp);

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberBox.Text);
                Excel excel = OpenFileAt(10);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberBox.Text = planet;
            }
            else
            {
                Excel excel = OpenFileAt(10);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Volcanics: ");
                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 2)); //column C
                }
                output.Flush();
                excel.Close();

                MessageBox.Show("Volcanics added to output.txt", "Completed");
            }
        }
        private void NeedsDefenses_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(1);

            output.WriteLine("Needs Defense List: ");
            for (int i = 2; i < 200; i++)
            {

                output.WriteLine(excel.ReadCellString(i, 14)); //needs defense column

            }
            output.Flush();
            excel.Close();

            MessageBox.Show("Needs Defense List added to Output.txt", "Completed");

        }
        private void Growing_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(1);

            output.WriteLine("Growing List: ");
            for (int i = 2; i < 200; i++)
            {
                output.WriteLine(excel.ReadCellString(i, 11)); //needs defense column

            }
            output.Flush();
            excel.Close();

            MessageBox.Show("Growing List added to Output.txt", "Completed");
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


        public StreamWriter GetOutput()
        {
            return output;
        }
        public void SetOutputPath(string path)
        {
            output = new StreamWriter(path);
        }

        public void OpenOutput()
        {
            output = new StreamWriter(outputPath);
        }
        public void CloseOutput()
        {
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
            //Marshal.FinalReleaseComObject(output);
            output.Close();
            
            //GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
            //GC.WaitForPendingFinalizers();

        }

        private void ClearOutput_Click(object sender, EventArgs e)
        {
            CloseOutput();
            File.WriteAllText(outputPath, "");
            OpenOutput();
            output.Flush();

            MessageBox.Show(outputPath + " has been cleared", "Message");
        }

        private void LineBreak_Click(object sender, EventArgs e)
        {
            output.WriteLine("");
            output.WriteLine("_____________________________________________");
            output.WriteLine("");
        }
    }//PlanetTypeForm
}//namespace
