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
            //output.Flush();
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
            else if (ArcticZoundsCheckBox.Checked && ArcticsCheckBox.Checked) //both
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
            else if (ArcticZoundsCheckBox.Checked && !ArcticsCheckBox.Checked) //Arctic Zounds only
            {
                Excel excel = OpenFileAt(2);
                int planet = (int)excel.ReadCellDouble(2, 8); //amount of zounds

                output.WriteLine("Arctic Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 5)); //column F
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Arctics Zounds added to " + outputPath, "Completed");
            }
            else if (!ArcticZoundsCheckBox.Checked && ArcticsCheckBox.Checked) //normies only
            {
                Excel excel = OpenFileAt(2);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Arctic Non-Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    string box = excel.ReadCellString(i, 2);
                    for (int j = 0; j < box.Length; j++)//go through string
                    {
                        if (box[j].Equals('.'))
                        {
                            if (j + 5 < box.Length && !box[j + 5].Equals('Z'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                            else if (j + 3 == box.Length-1 && !box[j-4].Equals('.'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                        }
                    }                   
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Arctics without Zounds added to " + outputPath, "Completed");
            }
            else
            {
                MessageBox.Show("Nothing was selected");
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
            else if (DesertZoundsCheckBox.Checked && DesertsCheckBox.Checked) //both
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
            else if (DesertZoundsCheckBox.Checked && !DesertsCheckBox.Checked) //Desert Zounds only
            {
                Excel excel = OpenFileAt(3);
                int planet = (int)excel.ReadCellDouble(2, 8); //amount of zounds

                output.WriteLine("Desert Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 5)); //column F
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Deserts Zounds added to " + outputPath, "Completed");
            }
            else if (!DesertZoundsCheckBox.Checked && DesertsCheckBox.Checked) //normies only
            {
                Excel excel = OpenFileAt(3);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Desert Non-Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    string box = excel.ReadCellString(i, 2);
                    for (int j = 0; j < box.Length; j++)//go through string
                    {
                        if (box[j].Equals('.'))
                        {
                            if (j + 5 < box.Length && !box[j + 5].Equals('Z'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                            else if (j + 3 == box.Length - 1 && !box[j - 4].Equals('.'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                        }
                    }
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Deserts without Zounds added to " + outputPath, "Completed");
            }
            else
            {
                MessageBox.Show("Nothing was selected");
            }
        }

        private void EarthlikesButton_Click(object sender, EventArgs e)
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
            else if (EarthlikeZoundsCheckBox.Checked && EarthlikesCheckBox.Checked) //both
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
            else if (EarthlikeZoundsCheckBox.Checked && !EarthlikesCheckBox.Checked) //Earthlike Zounds only
            {
                Excel excel = OpenFileAt(4);
                int planet = (int)excel.ReadCellDouble(2, 8); //amount of zounds

                output.WriteLine("Earthlike Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 5)); //column F
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Earthlikes Zounds added to " + outputPath, "Completed");
            }
            else if (!EarthlikeZoundsCheckBox.Checked && EarthlikesCheckBox.Checked) //normies only
            {
                Excel excel = OpenFileAt(4);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Earthlike Non-Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    string box = excel.ReadCellString(i, 2);
                    for (int j = 0; j < box.Length; j++)//go through string
                    {
                        if (box[j].Equals('.'))
                        {
                            if (j + 5 < box.Length && !box[j + 5].Equals('Z'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                            else if (j + 3 == box.Length - 1 && !box[j - 4].Equals('.'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                        }
                    }
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Earthlikes without Zounds added to " + outputPath, "Completed");
            }
            else
            {
                MessageBox.Show("Nothing was selected");
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
            else if (GreenhouseZoundsCheckBox.Checked && GreenhousesCheckBox.Checked) //both
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
            else if (GreenhouseZoundsCheckBox.Checked && !GreenhousesCheckBox.Checked) //Greenhouse Zounds only
            {
                Excel excel = OpenFileAt(5);
                int planet = (int)excel.ReadCellDouble(2, 8); //amount of zounds

                output.WriteLine("Greenhouse Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 5)); //column F
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Greenhouses Zounds added to " + outputPath, "Completed");
            }
            else if (!GreenhouseZoundsCheckBox.Checked && GreenhousesCheckBox.Checked) //normies only
            {
                Excel excel = OpenFileAt(5);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Greenhouse Non-Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    string box = excel.ReadCellString(i, 2);
                    for (int j = 0; j < box.Length; j++)//go through string
                    {
                        if (box[j].Equals('.'))
                        {
                            if (j + 5 < box.Length && !box[j + 5].Equals('Z'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                            else if (j + 3 == box.Length - 1 && !box[j - 4].Equals('.'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                        }
                    }
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Greenhouses without Zounds added to " + outputPath, "Completed");
            }
            else
            {
                MessageBox.Show("Nothing was selected");
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
            else if (MountainZoundsCheckBox.Checked && MountainsCheckBox.Checked) //both
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
            else if (MountainZoundsCheckBox.Checked && !MountainsCheckBox.Checked) //Mountain Zounds only
            {
                Excel excel = OpenFileAt(6);
                int planet = (int)excel.ReadCellDouble(2, 8); //amount of zounds

                output.WriteLine("Mountain Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 5)); //column F
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Mountains Zounds added to " + outputPath, "Completed");
            }
            else if (!MountainZoundsCheckBox.Checked && MountainsCheckBox.Checked) //normies only
            {
                Excel excel = OpenFileAt(6);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Mountain Non-Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    string box = excel.ReadCellString(i, 2);
                    for (int j = 0; j < box.Length; j++)//go through string
                    {
                        if (box[j].Equals('.'))
                        {
                            if (j + 5 < box.Length && !box[j + 5].Equals('Z'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                            else if (j + 3 == box.Length - 1 && !box[j - 4].Equals('.'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                        }
                    }
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Mountains without Zounds added to " + outputPath, "Completed");
            }
            else
            {
                MessageBox.Show("Nothing was selected");
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
            else if (OceanicZoundsCheckBox.Checked && OceanicsCheckBox.Checked) //both
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
            else if (OceanicZoundsCheckBox.Checked && !OceanicsCheckBox.Checked) //Oceanic Zounds only
            {
                Excel excel = OpenFileAt(7);
                int planet = (int)excel.ReadCellDouble(2, 8); //amount of zounds

                output.WriteLine("Oceanic Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 5)); //column F
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Oceanics Zounds added to " + outputPath, "Completed");
            }
            else if (!OceanicZoundsCheckBox.Checked && OceanicsCheckBox.Checked) //normies only
            {
                Excel excel = OpenFileAt(7);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Oceanic Non-Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    string box = excel.ReadCellString(i, 2);
                    for (int j = 0; j < box.Length; j++)//go through string
                    {
                        if (box[j].Equals('.'))
                        {
                            if (j + 5 < box.Length && !box[j + 5].Equals('Z'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                            else if (j + 3 == box.Length - 1 && !box[j - 4].Equals('.'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                        }
                    }
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Oceanics without Zounds added to " + outputPath, "Completed");
            }
            else
            {
                MessageBox.Show("Nothing was selected");
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
            else if (RockyZoundsCheckBox.Checked && RockiesCheckBox.Checked) //both
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
            else if (RockyZoundsCheckBox.Checked && !RockiesCheckBox.Checked) //Rockie Zounds only
            {
                Excel excel = OpenFileAt(9);
                int planet = (int)excel.ReadCellDouble(2, 8); //amount of zounds

                output.WriteLine("Rocky Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 5)); //column F
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Rocky Zounds added to " + outputPath, "Completed");
            }
            else if (!RockyZoundsCheckBox.Checked && RockiesCheckBox.Checked) //normies only
            {
                Excel excel = OpenFileAt(9);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Rocky Non-Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    string box = excel.ReadCellString(i, 2);
                    for (int j = 0; j < box.Length; j++)//go through string
                    {
                        if (box[j].Equals('.'))
                        {
                            if (j + 5 < box.Length && !box[j + 5].Equals('Z'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                            else if (j + 3 == box.Length - 1 && !box[j - 4].Equals('.'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                        }
                    }
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Rockies without Zounds added to " + outputPath, "Completed");
            }
            else
            {
                MessageBox.Show("Nothing was selected");
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
            else if (VolcanicZoundsCheckBox.Checked && VolcanicsCheckBox.Checked) //both
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
            else if (VolcanicZoundsCheckBox.Checked && !VolcanicsCheckBox.Checked) //Volcanic Zounds only
            {
                Excel excel = OpenFileAt(10);
                int planet = (int)excel.ReadCellDouble(2, 8); //amount of zounds

                output.WriteLine("Volcanic Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    output.WriteLine(excel.ReadCellString(i, 5)); //column F
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Volcanics Zounds added to " + outputPath, "Completed");
            }
            else if (!VolcanicZoundsCheckBox.Checked && VolcanicsCheckBox.Checked) //normies only
            {
                Excel excel = OpenFileAt(10);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Volcanic Non-Zounds: ");

                for (int i = 1; i <= planet; i++)
                {
                    string box = excel.ReadCellString(i, 2);
                    for (int j = 0; j < box.Length; j++)//go through string
                    {
                        if (box[j].Equals('.'))
                        {
                            if (j + 5 < box.Length && !box[j + 5].Equals('Z'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                            else if (j + 3 == box.Length - 1 && !box[j - 4].Equals('.'))
                            {
                                output.WriteLine(excel.ReadCellString(i, 2)); //column C
                            }
                        }
                    }
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Volcanics without Zounds added to " + outputPath, "Completed");
            }
            else
            {
                MessageBox.Show("Nothing was selected");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FindMoraleButton_Click(object sender, EventArgs e)
        {

        }

        private void DeconstructListButton_Click(object sender, EventArgs e)
        {

        }

        private void BuildListButton_Click(object sender, EventArgs e)
        {

        }

        private void SolarsListButton_Click(object sender, EventArgs e)
        {

        }

        private void LasersListButton_Click(object sender, EventArgs e)
        {

        }

        private void NukesListButton_Click(object sender, EventArgs e)
        {

        }

        private void SocialismListButton_Click(object sender, EventArgs e)
        {

        }

        private void DemocracyListButton_Click(object sender, EventArgs e)
        {

        }

        private void PrisonListButton_Click(object sender, EventArgs e)
        {

        }

        private void DirectorshipListButton_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }//PlanetTypeForm
}//namespace
