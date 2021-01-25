using System;
using System.IO;
using System.Windows.Forms;

namespace StarportExcel
{
    public partial class PlanetTypeForm : Form
    {
        string excelPath = "";
        string outputPath = @"G:\My Drive\Personal Stuff\Starport\Output.txt";
        private StreamWriter output = new StreamWriter(@"G:\My Drive\Personal Stuff\Starport\Output.txt");

        public PlanetTypeForm()
		{
			InitializeComponent();
        }
        private void PlanetTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            output.Flush();
            CloseOutput();
        }

        // Tool strip stuff from here down

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                Filter = "Text Files|*.txt|All Files|*.*",
                FilterIndex = 2,
                Title = "Open the Excel Sheet"
            };
            openFileDialog1.ShowDialog();

            //Check to see if a filename was given
            if (openFileDialog1.FileName != "")
            {
                SetOutputPath(@openFileDialog1.FileName);                
            }
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Text Files|*.txt|All Files|*.*",
                Title = "Save an Image File"
            };
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(@saveFileDialog1.FileName, "");
            }
        }

        private void HelpMeNiggaDamnToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This box is for essentially displaying the data to a text file, I may make it display to the box in future iterations.", "Message");
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {

        }

        //buttons

        private void ArcticsButton_Click(object sender, EventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int temp);
            //Console.WriteLine("Temp is : " + temp);

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberTextBox.Text);
                Excel excel = OpenFileAt(2);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberTextBox.Text = planet;
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
                MessageBox.Show("Arctics added to " + outputPath, "Completed");
            }
        }

        private void DesertsButton_Click(object sender, EventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int temp);

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberTextBox.Text);
                Excel excel = OpenFileAt(3);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberTextBox.Text = planet;
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

                MessageBox.Show("Deserts added to " + outputPath, "Completed");
            }
        }

        private void EarthsButton_Click(object sender, EventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int temp);

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberTextBox.Text);
                Excel excel = OpenFileAt(4);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberTextBox.Text = planet;
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

                MessageBox.Show("Earthlikes added to " + outputPath, "Completed");
            }

        }

        private void GreenhousesButton_Click(object sender, EventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int temp);

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberTextBox.Text);
                Excel excel = OpenFileAt(5);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberTextBox.Text = planet;
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

                MessageBox.Show("Greenhouses added to " + outputPath, "Completed");
            }
        }

        private void MountainsButton_Click(object sender, EventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int temp); 

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberTextBox.Text);
                Excel excel = OpenFileAt(6);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberTextBox.Text = planet;
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

                MessageBox.Show("Mountains added to " + outputPath, "Completed");
            }
        }

        private void OceanicsButton_Click(object sender, EventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int temp); 

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberTextBox.Text);
                Excel excel = OpenFileAt(7);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberTextBox.Text = planet;
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

                MessageBox.Show("Oceanics added to " + outputPath, "Completed");
            }
        }

        private void ParadisesButton_Click(object sender, EventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int temp); 

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberTextBox.Text);
                Excel excel = OpenFileAt(8);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberTextBox.Text = planet;
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

                MessageBox.Show("Paradises added to " + outputPath, "Completed");
            }
        }

        private void RockiesButton_Click(object sender, EventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int temp);

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberTextBox.Text);
                Excel excel = OpenFileAt(9);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberTextBox.Text = planet;
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

                MessageBox.Show("Rockies added to " + outputPath, "Completed");
            }
        }

        private void VolcanicsButton_Click(object sender, EventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int temp);

            if (temp > 0)
            {
                int planetNumber = Int32.Parse(numberTextBox.Text);
                Excel excel = OpenFileAt(10);
                string planet = excel.ReadCellString(planetNumber, 2); //read row planet number column c
                excel.Close();//dellocate
                numberTextBox.Text = planet;
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

                MessageBox.Show("Volcanics added to " + outputPath, "Completed");
            }
        }
        private void NeedsDefensesButton_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(1);

            output.WriteLine("Needs Defense List: ");
            for (int i = 2; i < Program.GetMax(); i++)
            {

                output.WriteLine(excel.ReadCellString(i, 14)); //needs defense column

            }
            output.Flush();
            excel.Close();

            MessageBox.Show("Needs Defense List added to Output.txt", "Completed");

        }
        private void GrowingButton_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(1);

            output.WriteLine("Growing List: ");
            for (int i = 2; i < Program.GetMax(); i++)
            {
                output.WriteLine(excel.ReadCellString(i, 11)); //needs defense column

            }
            output.Flush();
            excel.Close();

            MessageBox.Show("Growing List added to Output.txt", "Completed");
        }
        private void RenameListsButton_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(1);

            output.WriteLine("Rename Lists : Coordinates | Current Name | Rename ");

            for (int i = 2; i < Program.GetMax(); i++)
            {
                if (excel.ReadCellString(i, 6) != "")
                {
                    output.Write(excel.ReadCellString(i, 6) + " | "); //location
                }
                if (excel.ReadCellString(i, 7) != "")
                {
                    output.Write(excel.ReadCellString(i, 7) + " | ");//before
                }
                if (excel.ReadCellString(i, 8) != "")
                {
                    output.Write("/namecolony " + excel.ReadCellString(i, 8));//after 
                }
                if(excel.ReadCellString(i, 6) != "" || excel.ReadCellString(i, 7) != "" || excel.ReadCellString(i, 8) != "")
                {
                    output.WriteLine("");
                }
            }
            output.Flush();
            excel.Close();

            MessageBox.Show("Rename lists added to Output.txt", "Completed");
        }
        private void DoubleDomeListButton_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(1);

            output.WriteLine("Double Domes Lists: Candidates | Double Domes: ");

            for (int i = 2; i < Program.GetMax(); i++)
            {
                if (excel.ReadCellString(i, 18) != "")
                {
                    output.Write(excel.ReadCellString(i, 18) + " | "); //Candidates
                }
                if (excel.ReadCellString(i, 19) != "")
                {
                    output.Write(excel.ReadCellString(i, 19) + " | ");//double doems
                }
                if (excel.ReadCellString(i, 18) != "" || excel.ReadCellString(i, 19) != "")
                {
                    output.WriteLine("");
                }               
            }
            output.Flush();
            excel.Close();

            MessageBox.Show("Double Domes list added to Output.txt", "Completed");
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
            outputPath = path;
            output = new StreamWriter(outputPath);
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

        private void ClearOutputButton_Click(object sender, EventArgs e)
        {
            CloseOutput();
            File.WriteAllText(outputPath, "");
            OpenOutput();
            output.Flush();

            MessageBox.Show(outputPath + " has been cleared", "Message");
        }

        private void LineBreakButton_Click(object sender, EventArgs e)
        {
            output.WriteLine("");
            output.WriteLine("_____________________________________________");
            output.WriteLine("");
        }

        private void CMinesListButton_Click(object sender, EventArgs e)
        {

        }


    }//PlanetTypeForm
}//namespace
