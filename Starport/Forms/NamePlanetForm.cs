using System;
using System.Windows.Forms;

namespace StarportExcel.Forms
{
    public partial class NamePlanetForm : Form
    {
        private string coordinates;
        private string planetType;
        private string uniqueId0;
        private string uniqueId1;
        private string uniqueId2;
        private string uniqueId3;
        private string uniqueId4;
        private string unitCircleLoc;

        public NamePlanetForm()
        {
            InitializeComponent();
        }

        private static Excel OpenFileAt(int num)
        {
            Excel excel = new Excel(MainForm.excelPath, num);
            return excel;
        }

        private void ArcticsButton_Click(object sender, EventArgs e)
        {
            planetType = "Arc" + AmountOfPlanets(2);
        }

        private string AmountOfPlanets(int excelPage)
        {
            Excel excel = OpenFileAt(excelPage);
            int planet = (int)excel.ReadCellDouble(1, 8); //amount of planets
            planet++;
            excel.Close();

            string planetNumber = "";

            if (planet <= 9)
            {
                planetNumber = "00" + planet.ToString();
            }
            else if (planet >= 10 && planet <= 99)
            {
                planetNumber = "0" + planet.ToString();
            }
            else
            {
                planetNumber = planet.ToString();
            }

            return planetNumber;
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            NameTagTextBox.Text = "";
            coordinates = "";
            CoordinatesTextBox.Text = "";
            planetType = "";
            uniqueId0 = "";
            uniqueId1 = "";
            uniqueId2 = "";
            uniqueId3 = "";
            uniqueId4 = "";
            unitCircleLoc = "";
            UnitCircleCoordinatesTextBox.Text = "";

            MessageBox.Show("All Identifiers & Names have been cleared! ", "Completed");
        }

        private void CoordinatesTextBox_TextChanged(object sender, EventArgs e)
        {
            coordinates = CoordinatesTextBox.Text;

            for (int k = 0; k < coordinates.Length; k++)
            {
                if (coordinates[k].Equals('['))
                {
                    coordinates = MainForm.StringReplacer(k, '(', coordinates);
                    Console.WriteLine(coordinates + " changed!");
                }
                else if (coordinates[k].Equals(']'))
                {
                    coordinates = MainForm.StringReplacer(k, ')', coordinates);
                    Console.WriteLine(coordinates + " changed!");
                }
            }
        }

        private void DesertsButton_Click(object sender, EventArgs e)
        {
            planetType = "Des" + AmountOfPlanets(3);
        }

        private void DoubleDomeButton_Click(object sender, EventArgs e)
        {
            uniqueId1 = "D";
        }

        private void EarthlikesButton_Click(object sender, EventArgs e)
        {
            planetType = "Ear" + AmountOfPlanets(4);
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            coordinates.Trim();
            unitCircleLoc.Trim();
            PlanetNameOutput.Text = MainForm.ownerName + coordinates + planetType + "." + unitCircleLoc + "." + uniqueId0 + uniqueId1 + uniqueId2 + uniqueId3 + uniqueId4;
        }

        private void GreenhousesButton_Click(object sender, EventArgs e)
        {
            planetType = "Gre" + AmountOfPlanets(5);
        }

        private void GrowingButton_Click(object sender, EventArgs e)
        {
            uniqueId2 = "G";
        }

        private void InvadedButton_Click(object sender, EventArgs e)
        {
            uniqueId4 = "I";
        }

        private void MountainousButton_Click(object sender, EventArgs e)
        {
            planetType = "Mou" + AmountOfPlanets(6);
        }

        private void NameTagTextBox_TextChanged(object sender, EventArgs e)
        {
            NameTagTextBox.Text.Trim();
            MainForm.ownerName = NameTagTextBox.Text;
        }

        private void NeedsDefenseButton_Click(object sender, EventArgs e)
        {
            uniqueId3 = "N";
        }

        private void OceanicsButton_Click(object sender, EventArgs e)
        {
            planetType = "Oce" + AmountOfPlanets(7);
        }

        private void ResearchButton_Click(object sender, EventArgs e)
        {
            uniqueId2 = "R";
        }

        private void RockiesButton_Click(object sender, EventArgs e)
        {
            planetType = "Roc" + AmountOfPlanets(9);
        }

        private void UnitCircleCoordinatesButton_TextChanged(object sender, EventArgs e)
        {
            unitCircleLoc = UnitCircleCoordinatesTextBox.Text;
        }

        private void VolcanicsButton_Click(object sender, EventArgs e)
        {
            planetType = "Vol" + AmountOfPlanets(10);
        }

        private void ZoundsButton_Click(object sender, EventArgs e)
        {
            uniqueId0 = "Z";
        }

        private void ConstructingButton_Click(object sender, EventArgs e)
        {
            uniqueId4 = "C";
        }
    }
}