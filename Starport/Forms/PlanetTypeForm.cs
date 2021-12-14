using System;
using System.IO;
using System.Windows.Forms;
using static StarportExcel.Structs;

namespace StarportExcel
{
    public partial class PlanetTypeForm : Form
    {
        private string excelPath = "";
        private StreamWriter output;
        private string outputPath = "";

        public PlanetTypeForm()
        {
            InitializeComponent();
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

        public StreamWriter GetOutput()
        {
            return output;
        }

        public void OpenOutput()
        {
            output = new StreamWriter(outputPath);
        }

        public void SetExcelPath(string path)
        {
            excelPath = path;
        }

        public void SetOutputPath(string path)
        {
            outputPath = path;
            output = new StreamWriter(outputPath);
        }

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
                    WriteAllPlanetInfo(i, excel);
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
                            else if (j + 3 == box.Length - 1 && !box[j - 4].Equals('.'))
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

        private void BuildListButton_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(11);
            int planetsToBuild = (int)excel.ReadCellDouble(1, 15);

            for (int i = 1; i <= planetsToBuild; i++) //planet tally is in P column
            {
                //output.Write("Coordinates: ");
                output.Write(excel.ReadCellString(i, 2)); //coordinates
                output.Write(" | ");

                //output.Write("Planet Name: ");
                output.Write(excel.ReadCellString(i, 3)); //colony name
                output.Write(" | ");

                //output.Write("Colony Name: ");
                output.Write(excel.ReadCellString(i, 4));//Planet Name
                output.Write(" | ");

                output.Write("Zounds: ");
                output.Write(excel.ReadCellBool(i, 5));//Zoundsable
                output.Write(" | ");

                output.Write("Medium: ");
                output.Write(excel.ReadCellBool(i, 6));//Medium
                output.Write(" | ");

                output.Write("?: ");
                output.Write(excel.ReadCellBool(i, 7));//Questionable
                output.Write(" | ");

                output.Write("Decconstruct: ");
                output.Write(excel.ReadCellBool(i, 8));//Deconstruct
                output.Write(" | ");

                //output.Write("Research x/10: ");
                output.Write((int)excel.ReadCellDouble(i, 9)); //Research
                output.Write(" | ");
                output.WriteLine("");
            }
            output.Flush();
            MessageBox.Show("Build List added to output", "Message");
        }

        private void ClearOutputButton_Click(object sender, EventArgs e)
        {
            CloseOutput();
            File.WriteAllText(outputPath, "");
            OpenOutput();
            output.Flush();

            MessageBox.Show(outputPath + " has been cleared", "Message");
        }

        private void CMinesListButton_Click(object sender, EventArgs e)
        {
            WriteAllPlanetInfoIf(100, 31, true, false, true);
            MessageBox.Show("Compound Mine Colonies to Output", "Completed!");
        }

        private void ConstructionListButton_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(1);

            output.WriteLine("Construction List: ");
            for (int i = 2; i < Program.GetMax(); i++)
            {
                output.WriteLine(excel.ReadCellString(i, 25)); //needs defense column
            }
            output.Flush();
            excel.Close();

            MessageBox.Show("Construction List added to Output.txt", "Completed");
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void DemocracyListButton_Click(object sender, EventArgs e)
        {
            WriteAllPlanetInfoIf("Democracy", 13);
            MessageBox.Show("Democracy Colonies to Output", "Completed!");
        }

        //buttons
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
                    WriteAllPlanetInfo(i, excel);
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

        private void DirectorshipListButton_Click(object sender, EventArgs e)
        {
            WriteAllPlanetInfoIf("Directorship", 13);
            MessageBox.Show("Directorship Colonies to Output", "Completed!");
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
                    WriteAllPlanetInfo(i, excel);
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

        private void FindMoraleButton_Click(object sender, EventArgs e)
        {
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
                    WriteAllPlanetInfo(i, excel);
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

        private void GrowingButton_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(1);

            output.WriteLine("Growing List: ");
            for (int i = 2; i < Program.GetMax(); i++)
            {
                output.WriteLine(excel.ReadCellString(i, 11)); //growing column
            }
            output.Flush();
            excel.Close();

            MessageBox.Show("Growing List added to Output.txt", "Completed");
        }

        private void HelpMeNiggaDamnToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This box is for essentially displaying the data to a text file, I may make it display to the box in future iterations.", "Message");
        }

        private void LasersListButton_Click(object sender, EventArgs e)
        {
            WriteAllPlanetInfoIf(150, 32, true, false, true);
            MessageBox.Show("Laser Colonies to Output", "Completed!");
        }

        private void LineBreakButton_Click(object sender, EventArgs e)
        {
            output.WriteLine("");
            output.WriteLine("_____________________________________________");
            output.WriteLine("");
        }

        private void LowMetalButton_Click(object sender, EventArgs e)
        {
            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = (int)excel.ReadCellDouble(1, 8);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    if (excel.ReadCellInt(i, 26) <= 5000)
                    {
                    }
                }
            }
        }

        private void MountainousButton_Click(object sender, EventArgs e)
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
            else if (MountainZoundsCheckBox.Checked && MountainousCheckBox.Checked) //both
            {
                Excel excel = OpenFileAt(6);
                int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets

                output.WriteLine("Mountainous: ");

                for (int i = 1; i <= planet; i++)
                {
                    WriteAllPlanetInfo(i, excel);
                }
                output.Flush();
                excel.Close();
                MessageBox.Show("Mountainous added to " + outputPath, "Completed");
            }
            else if (MountainZoundsCheckBox.Checked && !MountainousCheckBox.Checked) //Mountain Zounds only
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
                MessageBox.Show("Mountainous Zounds added to " + outputPath, "Completed");
            }
            else if (!MountainZoundsCheckBox.Checked && MountainousCheckBox.Checked) //normies only
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
                MessageBox.Show("Mountainous without Zounds added to " + outputPath, "Completed");
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

        private void NukesListButton_Click(object sender, EventArgs e)
        {
            WriteAllPlanetInfoIf(250, 32, true, false, true);
            MessageBox.Show("Nukes Colonies to Output", "Completed!");
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
                    WriteAllPlanetInfo(i, excel);
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

        private Excel OpenFileAt(int num)
        {
            Excel excel = new Excel(excelPath, num);
            return excel;
        }

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
                    WriteAllPlanetInfo(i, excel);
                }
                output.Flush();
                excel.Close();

                MessageBox.Show("Paradises added to " + outputPath, "Completed");
            }
        }

        private void PlanetTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //output.Flush();
            CloseOutput();
        }

        private void PrisonListButton_Click(object sender, EventArgs e)
        {
            WriteAllPlanetInfoIf("Prison", 13);
            MessageBox.Show("Prison Colonies to Output", "Completed!");
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
                if (excel.ReadCellString(i, 6) != "" || excel.ReadCellString(i, 7) != "" || excel.ReadCellString(i, 8) != "")
                {
                    output.WriteLine("");
                }
            }
            output.Flush();
            excel.Close();

            MessageBox.Show("Rename lists added to Output.txt", "Completed");
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
                    WriteAllPlanetInfo(i, excel);
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

        private void SameSystemListButton_Click(object sender, EventArgs e)
        {
            Coordinates system = Algorithms.GetCoordinates(numberTextBox.Text);

            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = (int)excel.ReadCellDouble(1, 8);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    string planetName = excel.ReadCellString(i, 2);
                    Coordinates planetCoords = Algorithms.GetCoordinates(planetName);
                    if (system.x == planetCoords.x && system.y == planetCoords.y)
                    {
                        output.WriteLine(planetName);
                    }
                }
                excel.Close();
            }

            output.Flush();
            MessageBox.Show("Colonies in the Same System to output", "Message");
        }

        // Tool strip stuff from here down
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

        private void SocialismListButton_Click(object sender, EventArgs e)
        {
            WriteAllPlanetInfoIf("Socialism", 13);
            MessageBox.Show("Socialism Colonies to Output", "Completed!");
        }

        private void SolarsListButton_Click(object sender, EventArgs e)
        {
            WriteAllPlanetInfoIf(15, 33, false, true, true);
            WriteAllPlanetInfoIf(100, 34, false, true, true);
            MessageBox.Show("Weak Solar Colonies to Output", "Completed!");
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
                    WriteAllPlanetInfo(i, excel);
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

        private void WriteAllPlanetInfo(int planetNum, Excel excel)
        {
            output.Write(excel.ReadCellString(planetNum, 2) + " | "); //column C
            //Console.WriteLine(excel.ReadCellString(planetNum, 2));
            for (int i = 10; i <= 38; i++)
            {
                //Console.WriteLine(i);
                if (i == 11 || i == 12 || (i >= 14 && i <= 19) || (i >= 25 && i <= 37))
                {
                    var temp = excel.ReadCellDouble(planetNum, i);
                    output.Write(temp + " | ");
                }
                else if (i == 38)
                {
                    string temp = excel.ReadCellString(planetNum, i);
                    output.Write(temp);
                }
                else
                {
                    string temp = excel.ReadCellString(planetNum, i);
                    output.Write(temp + " | ");
                }
            }
            output.WriteLine("");
        }

        /// <summary>
        /// Finds and outputs the planet info if the string matches
        /// </summary>
        /// <param name="find"></param>
        /// <param name="column"></param>
        private void WriteAllPlanetInfoIf(string find, int column)
        {
            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = (int)excel.ReadCellDouble(1, 8);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    if (excel.ReadCellString(planet, column).Equals(find))
                    {
                        WriteAllPlanetInfo(planet, excel);
                    }
                }

                excel.Close();
            }
        }

        /// <summary>
        /// Finds and outputs the planet info if the integer matches
        /// </summary>
        /// <param name="find"></param>
        /// <param name="column"></param>
        private void WriteAllPlanetInfoIf(int find, int column)
        {
            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = (int)excel.ReadCellDouble(1, 8);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    int temp = (int)excel.ReadCellDouble(planet, column);
                    if (temp.Equals(find))
                    {
                        WriteAllPlanetInfo(planet, excel);
                    }
                }

                excel.Close();
            }
        }

        /// <summary>
        /// Finds and compares the number and outprints all the planet info if true
        /// </summary>
        /// <param name="find"></param>
        /// <param name="column"></param>
        private void WriteAllPlanetInfoIf(int compare, int column, bool greaterThan, bool lessThan, bool equalTo)
        {
            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = (int)excel.ReadCellDouble(1, 8);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    double temp = excel.ReadCellDouble(planet, column);
                    if (temp < compare && lessThan)
                    {
                        WriteAllPlanetInfo(planet, excel);
                    }
                    else if (temp > compare && greaterThan)
                    {
                        WriteAllPlanetInfo(planet, excel);
                    }
                    else if (temp == compare && equalTo)
                    {
                        WriteAllPlanetInfo(planet, excel);
                    }
                }

                excel.Close();
            }
        }
    }//PlanetTypeForm
}//namespace