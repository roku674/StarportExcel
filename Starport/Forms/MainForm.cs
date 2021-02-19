using System;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static StarportExcel.Structs;

namespace StarportExcel
{
    public partial class MainForm : Form
    {
        public static string excelPath = @"G:\My Drive\Personal Stuff\Starport\PlanetTallies.xlsx";
        
        public MainForm()
        {
            InitializeComponent();  
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            //MessageBox.Show("Make Sure the excel sheet is closed before pressing anything!", "Warning");
            Excel.Kill();
        }

        // Tool strip stuff from here down
        private void OpenToolStripButtonMain_Click(object sender, EventArgs e)
        {
            Console.WriteLine("before: " + excelPath);

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx|All Files|*.*",
                FilterIndex = 2,
                Title = "Open the Excel Sheet"
            };
            openFileDialog1.ShowDialog();

            //Check to see if a filename was given
            if (openFileDialog1.FileName != "")
            {
                SetExcelPath(@openFileDialog1.FileName);
            }
            Console.WriteLine("after: " + excelPath);
        }
        private void SaveToolStripButtonMain_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Excel files|*.xlsx",
                Title = "Save an Image File"
            };
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                Excel excel = OpenFileAt(1);
                excel.SaveAs(@saveFileDialog1.FileName);
                excel.Close();
            }
        }
        private void HelpMeNiggaDamnToolStripButtonMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It's gotten to big now you're going to have to check out the readme \n sidenote checkout https://github.com/roku674/StarportExcel", "Message");
        }
        private void PrintToolStripButtonMain_Click(object sender, EventArgs e)
        {

        }
        //End of Tool strip stuff
        private void ReturnPlanetButton_Click(object sender, EventArgs e)
        {
            PlanetTypeForm customMessageBox = new PlanetTypeForm();
            customMessageBox.SetExcelPath(excelPath);
            customMessageBox.ShowDialog();           
        }
        private void ReplacePlanetButton_Click(object sender, EventArgs e)
        {
            string newPlanetName = PlanetOrganizerTextBox.Text;

            Replacer.ReplacePlanetClick(newPlanetName, PlanetOrganizerTextBox);

            PlanetOrganizerTextBox.Text = "Insert Planet Name or Start Coordinates";
        }
        private void CreateQuoteButton_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(1);

            //number, letter          

            double arcticsZ = excel.ReadCellDouble(3, 3); //4D
            double arctics = excel.ReadCellDouble(3, 2); //4C

            double desertsZ = excel.ReadCellDouble(4, 3);
            double deserts = excel.ReadCellDouble(4, 2);

            double earthsZ = excel.ReadCellDouble(5, 3);
            double earthlikes = excel.ReadCellDouble(5, 2);

            double greenhousesZ = excel.ReadCellDouble(6, 3);
            double greenhouses = excel.ReadCellDouble(6, 2);

            double mountainsZ = excel.ReadCellDouble(7, 3);
            double mountains = excel.ReadCellDouble(7, 2);

            double oceansZ = excel.ReadCellDouble(8, 3);
            double oceans = excel.ReadCellDouble(8, 2);

            //double paradisesZ = excel.ReadCellDouble(9, 3);
            double paradises = excel.ReadCellDouble(9, 2);

            double rockiesZ = excel.ReadCellDouble(10, 3);
            double rockies = excel.ReadCellDouble(10, 2);

            double volcanicsZ = excel.ReadCellDouble(11, 3);
            double volcanics = excel.ReadCellDouble(11, 2);

            double totalsZ = excel.ReadCellDouble(12, 3);
            double totals = excel.ReadCellDouble(12, 2);

            double invasions = excel.ReadCellDouble(15, 2);

            itsMyWindowTextBox.Text = "Arc " + arcticsZ + "/" + arctics +
                "|~{yellow}~Des " + desertsZ + "/" + deserts +
                "|~{green}~Earth " + earthsZ + "/" + earthlikes +
                "|~{orange}~Green " + greenhousesZ + "/" + greenhouses +
                "|~{purple}~Mount " + mountainsZ + "/" + mountains +
                "|~{blue}~Oce " + oceansZ + "/" + oceans +
                "|~{pink}~Paradises ~{link}1:" + paradises + "~" +
                "|~{gray}~Roc " + rockiesZ + "/" + rockies +
                "|~{red}~Volc " + volcanicsZ + "/" + volcanics +
                "|~{link}25:Captured:~ " + invasions +
                "|~{cyan}~ " + totalsZ + " Zounds / " + totals + "~{link}21: Colonies~";

            Console.WriteLine(itsMyWindowTextBox.Text);

            excel.Close();
        }
        private void CheckGrowButton_Click(object sender, EventArgs e)
        {
            Checkers.CheckGrow();
        }
        private void CheckParenthesisButton_Click(object sender, EventArgs e)
        {
            Checkers.CheckParenthesis();        
        }
        private void CheckNDButton_Click(object sender, EventArgs e)
        {
            Checkers.CheckNeedsDefense();
        }
        private void FindGrowingButton_Click(object sender, EventArgs e)
        {

            //all planets start at 2C
            //zounds start at 2F
            //Tallies are I2 == Planet I3 == Zoudns
            Excel totals = OpenFileAt(1);
            Clearer.ClearGrowList(totals);

            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = excel.ReadCellInt(1, 8);
                //Console.WriteLine("Planet Total: " + planet);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    if (excel.ReadCellString(i, 2) != "")
                    {
                        if (excel.ReadCellDouble(i, 1).ToString() != "")
                        {
                            excel.WriteToCell(i, 1, i.ToString()); //writes to the cell to the left and just puts a number in it
                        }

                        string box = excel.ReadCellString(i, 2);

                        for (int k = 0; k < box.Length; k++) //itterate through the string character by character
                        {
                            if (box[k].Equals('.'))
                            {
                                if (k + 5 < box.Length && box[k + 5].Equals('G'))
                                {
                                    Adder.AddToGrow(GetFormula(box), totals);                                   
                                    break;
                                }
                                else if (k + 6 < box.Length && box[k + 6].Equals('G'))
                                {
                                    Adder.AddToGrow(GetFormula(box), totals );
                                    break;
                                }
                                else if (k + 7 < box.Length && box[k + 7].Equals('G'))
                                {
                                    Adder.AddToGrow(GetFormula(box), totals);
                                    break;
                                }
                                else
                                {
                                    //do nothing
                                }
                            }//end if
                        }// for k
                    } //end if                            
                }//end of i loop

                excel.Close();
                
            }// end of J loop

            totals.Close();
            MessageBox.Show("Find Grow/Research Done", "Completed");
        }
        private void FindTotalsButton_Click(object sender, EventArgs e)
        {
            //open them up and clear them
            Excel totals = OpenFileAt(1);

            Clearer.ClearNDList(totals);
            Clearer.ClearGrowList(totals);
            Clearer.ClearDDList(totals);

            Console.WriteLine("Beginning Totals...\n");

            for (int k = 2; k <= 10; k++) // goes through each sheet
            {
                Excel excel = OpenFileAt(k);

                int planet = excel.ReadCellInt(1, 8);

                excel.WriteToCell(2, 8, 0.ToString());//clear zounds num
                Clearer.ClearZoundsList(excel, planet);

                int temp = 0;
                for (int j = 1; j <= planet + 15; j++) // goes through the planet list
                {
                    
                    if (excel.ReadCellString(j, 2) != "") //if there's something there
                    {                       
                        excel.WriteToCell(j, 1, j.ToString()); //writes to the cell to the left and just puts a number in it
                        temp = j;

                        string planetName = excel.ReadCellString(j, 2); //read the name of the planet
                        //Console.WriteLine(planetName);

                        int num = j + 1;
                        //if statement by planet type
                            if (k == 2)
                            { 
                                string formula = "=Arctics!C" + num;
                                Checkers.CheckTotals(totals, excel, planetName, formula);
                                //Console.WriteLine(planetName + " found");                                        
                            }
                            else if (k == 3) {
                                string formula = "=Deserts!C" + num;
                                Checkers.CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 4) {
                                string formula = "=Earthlikes!C" + num;
                                Checkers.CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 5) {
                                string formula = "=Greenhouses!C" + num;
                                Checkers.CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 6) {
                                string formula = "=Mountainous!C" + num;
                                Checkers.CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 7) {
                                string formula = "=Oceanics!C" + num;
                                Checkers.CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 8) {
                                string formula = "=Paradises!C" + num;
                                Checkers.CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 9) {
                                string formula = "=Rockies!C" + num;
                                Checkers.CheckTotals(totals, excel, planetName, formula);
                            }
                            else if (k == 10) {
                                string formula = "=Volcanics!C" + num;
                                Checkers.CheckTotals(totals, excel, planetName, formula);
                            }
                            else { }                            
                    }
            
                }//end of j loop

                excel.WriteToCell(1, 8, temp.ToString()); //changes the total planets
                //Console.WriteLine("Planet Total: " + temp);

                excel.Close(); //deallocate

            }// end of i loop
            totals.Close();
            Console.Write("Done");
            MessageBox.Show("Find Totals Done", "Completed");
        }   
        private void FindZoundsButton_Click(object sender, EventArgs e)
        {
            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = excel.ReadCellInt(1, 8);            
                excel.WriteToCell(2, 8, 0.ToString());//clear zounds num

                //ClearZoundsList(excel, planet);
                //Console.WriteLine("Planet Total: " + planet);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    string box = excel.ReadCellString(i, 2); //get the contents of coulumn C

                    for (int k = 0; k < box.Length; k++) //itterate through the string character by character
                    {
                        if (box[k].Equals('.'))
                        {
                            if (k + 5 < box.Length && box[k + 5].Equals('Z'))
                            {
                                //Console.WriteLine(planet + " added to Zounds");
                                Adder.AddToZounds(GetFormula(box), excel);
                                break;
                            }

                        }//end if
                        else if(box == " ")
                        {
                            break;
                        }
                    }// for k        

                }//end of i loop

                excel.Close();

            }// end of J loop
            MessageBox.Show("Find Zounds Done", "Completed");
        }
        private void FindNeedsDefenseButton_Click(object sender, EventArgs e)
        {
            Excel totals = OpenFileAt(1);
            Clearer.ClearNDList(totals);

            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = excel.ReadCellInt(1, 8);
                //Console.WriteLine("Planet Total: " + planet);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    if (excel.ReadCellString(i, 2) != "")
                    {
                        if (excel.ReadCellDouble(i, 1).ToString() != "")
                        {
                            excel.WriteToCell(i, 1, i.ToString()); //writes to the cell to the left and just puts a number in it
                        }

                        string box = excel.ReadCellString(i, 2);

                        for (int k = 0; k < box.Length; k++) //itterate through the string character by character
                        {
                            if (box[k].Equals('.'))
                            {
                                if (k + 5 < box.Length && box[k + 5].Equals('N'))
                                {
                                    Adder.AddToND(GetFormula(box), totals);
                                    break;
                                }
                                else if (k + 6 < box.Length && box[k + 6].Equals('N') )
                                {
                                    Adder.AddToND(GetFormula(box), totals);
                                    break;
                                }
                                else if (k + 7 < box.Length && box[k + 7].Equals('N'))
                                {
                                    Adder.AddToND(GetFormula(box), totals);
                                    break;
                                }
                                else
                                {
                                    //do nothing
                                }
                            }//end if
                        }// for k
                    } //end if                            
                }//end of i loop

                excel.Close();

            }// end of J loop

            totals.Close();
            MessageBox.Show("Find Needs Defense Done", "Completed");
        }
        private void SortGrowingByXButton_Click(object sender, EventArgs e)
        {
            Excel totalsSheet = OpenFileAt(1);
            int temp = 0;
            for (int i = 2; i < 1000; i++)
            {
                if (totalsSheet.ReadCellString(i, 11) != "")
                {
                    temp++;
                }
            }

            if (temp == 0)
            {
                MessageBox.Show("No Planets are growing, thus can't be sorted", "Error");
                return;
            }

            //Console.WriteLine(temp);
            string[] planets = new string[temp];

            for (int i = 2; i < planets.Length + 2; i++)
            {
                //Console.WriteLine(i);
                if (totalsSheet.ReadCellString(i, 11) != "") //if not empty
                {
                    planets[i - 2] = totalsSheet.ReadCellString(i, 11); //add to list
                    //Console.WriteLine(totalsSheet.ReadCellString(i, 11) + " added to list at index " + i);
                }
            }

            Algorithms.SortPlanetsByX(planets);

            

            for (int i = 0; i < planets.Length; i++)
            {
                if (planets[i] != "" && planets[i] != null)
                {
                    int temp2 = i + 2;
                    //Console.WriteLine(temp2);
                    totalsSheet.WriteToCell(temp2, 11, GetFormula(planets[i])); //write the contents of the array into the box
                }
            }

            totalsSheet.Close();

            MessageBox.Show("Growing & Research List Sorted by X Coordinates", "Completed");
        }
        private void SortGrowingBySystemButton_Click(object sender, EventArgs e)
        {
            Excel totals = OpenFileAt(1);
            int temp = 0;
            for (int i = 2; i < Program.GetMax(); i++)
            {
                if (totals.ReadCellString(i, 11) != "")
                {
                    temp++;
                }
            }
            if (temp == 0)
            {
                MessageBox.Show("No Planets are growing, thus can't be sorted", "Error");
                return;
            }
            string[] planets = new string[temp];

            for (int i = 0; i < planets.Length; i++) //establish teh array
            {
                planets[i] = totals.ReadCellString((i + 2), 11);
            }

            string originString = PlanetOrganizerTextBox.Text; //get text from text box
            Coordinates origin;

            if (originString != "")
            {
                origin = Algorithms.GetCoordinates(originString); //if there's something there take it
            }
            else
            {
                origin = Algorithms.GetCoordinates(planets[0]); //else go with the first one in the list
            }
            ColonyInfo[] colInfo = Algorithms.SortPlanetsByXAndY(planets, origin, Algorithms.GetCoordinates(planets[temp - 1])); //get the sorted array

            Clearer.ClearGrowList(totals); //clear list
            for (int i = 0; i < colInfo.Length; i++)
            {
                Adder.AddToGrow(GetFormula(colInfo[i].colonyName), totals);
            }

            totals.Close();
            PlanetOrganizerTextBox.Text = "Insert Planet Name or Start Coordinates";
            MessageBox.Show("Growign & Research List Sorted by System", "Completed");
        }
        private void SortDefensesByXButton_Click(object sender, EventArgs e)
        {
            Excel totalsSheet = OpenFileAt(1);
            int temp = 0;
            for (int i= 2; i < Program.GetMax(); i++)
            {
                if (totalsSheet.ReadCellString(i, 14) != "")
                {
                    temp++;
                }
            }
            if (temp == 0)
            {
                MessageBox.Show("No Planets need defenses, thus can't be sorted", "Error");
                return;
            }
            //Console.WriteLine(temp);
            string[] planets = new string[temp];

            for (int i = 2; i < planets.Length+2; i++)
            {
                //Console.WriteLine(i);
                if(totalsSheet.ReadCellString(i, 14) != "") //if not empty
                {
                    planets[i-2] = totalsSheet.ReadCellString(i, 14); //add to list
                    //Console.WriteLine(totalsSheet.ReadCellString(i, 14) + " added to list at index " + i);
                }
            }
            Array.Sort(planets);

            /*
            for (int i = 0; i < planets.Length; i++) {
                Console.WriteLine(planets[i] + " at index " + i);
            }
            */

            for (int i = 0; i < planets.Length; i++)
            {
                if(planets[i] != "" && planets[i] != null)
                {
                    int temp2 = i+2;
                    //Console.WriteLine(temp2);
                    totalsSheet.WriteToCell(temp2, 14, GetFormula(planets[i])); //write the contents of the array into the box
                }                
            }

            totalsSheet.Close();

            MessageBox.Show("Needs Defenses List Sorted by X coordinates", "Completed");
        }
        private void SortDefensesBySystemButton_Click(object sender, EventArgs e)
        {
            Excel totals = OpenFileAt(1);
            int temp = 0;
            for (int i = 2; i < Program.GetMax(); i++)
            {
                if (totals.ReadCellString(i, 14) != "")
                {
                    temp++;
                }
            }
            if(temp == 0)
            {
                MessageBox.Show("No Planets need defenses, thus can't be sorted", "Error");
                return;
            }
            string[] planets = new string[temp];

            for (int i = 0; i < planets.Length; i++) //establish teh array
            {
                planets[i] = totals.ReadCellString((i + 2), 14);
            }

            string originString = PlanetOrganizerTextBox.Text; //get text from text box
            Coordinates origin;

            if (originString != "" && originString != "Insert Planet Name or Start Coordinates")
            {
                origin = Algorithms.GetCoordinates(originString); //if there's something there take it
            }
            else
            {
                origin = Algorithms.GetCoordinates(planets[0]); //else go with the first one in the list
            }
            ColonyInfo[] colInfo = Algorithms.SortPlanetsByXAndY(planets, origin, Algorithms.GetCoordinates(planets[temp - 1])); //get the sorted array

            Clearer.ClearNDList(totals); //clear list
            for (int i = 0; i < colInfo.Length; i++)
            {
                Adder.AddToND(GetFormula(colInfo[i].colonyName), totals);
            }

            totals.Close();
            PlanetOrganizerTextBox.Text = "Insert Planet Name or Start Coordinates";
            MessageBox.Show("Needs Defenses List Sorted by System", "Completed");
        }
        private void ClearGrowButton_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel(excelPath, 1);
            Clearer.ClearGrowList(excel);
            excel.Close();
        }
        private void ClearNeedsDefenseButton_Click(object sender, EventArgs e)
        {
            Excel excel = OpenFileAt(1);
            Clearer.ClearNDList(excel);
            excel.Close();
        }
        private void ClearZoundsButton_Click(object sender, EventArgs e)
        {
            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);
                int planet = excel.ReadCellInt(1, 8);
                Clearer.ClearZoundsList(excel, planet);
                excel.Close();
            }
            MessageBox.Show("Zounds lists Cleared!", "Completed");
        }
        private void FindDDButton_Click(object sender, EventArgs e)
        {            
            Excel totals = OpenFileAt(1);
            Clearer.ClearDDList(totals);

            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = excel.ReadCellInt(1, 8);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    if (excel.ReadCellString(i, 2) != "")
                    {
                        if (excel.ReadCellDouble(i, 1).ToString() != "")
                        {
                            excel.WriteToCell(i, 1, i.ToString()); //writes to the cell to the left and just puts a number in it
                        }

                        string box = excel.ReadCellString(i, 2);

                        for (int k = 0; k < box.Length; k++) //itterate through the string character by character
                        {
                            if (box[k].Equals('.'))
                            {
                                if (k + 5 < box.Length && box[k + 5].Equals('D'))
                                {
                                    Adder.AddToDD(GetFormula(box), totals);
                                    break;
                                }
                                else if (k + 6 < box.Length && box[k + 6].Equals('D'))
                                {
                                    Adder.AddToDD(GetFormula(box), totals);
                                    break;
                                }
                                else
                                {
                                    //do nothing
                                }
                            }//end if
                        }// for k
                    } //end if                            
                }//end of i loop

                excel.Close();

            }// end of J loop
            totals.Close();
            MessageBox.Show("Found all Double Domes", "Completed");
        }
        
        private void EditRenameListButton_Click(object sender, EventArgs e)
        {
            //open up a box askign where the coordinates are, old name, new name
        }

        private void EditInvasionListButton_Click(object sender, EventArgs e)
        {
            //open up a new box
        }
        private void EditPlanetInfoButton_Click(object sender, EventArgs e)
        {
            PlanetInfoForm customMessageBox = new PlanetInfoForm();
            customMessageBox.SetExcelPath(excelPath);
            customMessageBox.ShowDialog();
        }

        private void ClearRenameButton_Click(object sender, EventArgs e)
        {

        }
        private void FindDeconstructButton_Click(object sender, EventArgs e)
        {

        }

        public static string StringReplacer(int num , char replacement, string str)
        {
            StringBuilder sb = new StringBuilder(str);
            sb[num] = replacement;
            return sb.ToString();
        }
        private static Excel OpenFileAt(int num)
        {
            Excel excel = new Excel(excelPath, num);
            return excel;
        }

        public string GetExcelPath()
        {
            return excelPath;
        }
        public void SetExcelPath(string path)
        {
            excelPath = path;
        }
        /// <summary>
        /// Call this method To get the excel formula this reads the name and numbers behind the name type
        /// </summary>
        /// <param name="planetName">Must be the name of the planet</param>
        /// <returns></returns>
        public string GetFormula(string planetName)
        {
            string returnString = planetName;
            //Console.WriteLine(planetName + " given to GetFormula()");

            for (int i = 0; i < planetName.Length; i++)
            {
                //Console.WriteLine("char: " + planetName[i] + " at" + i);
                if (i + 2 < planetName.Length && planetName[i].Equals('A') && planetName[i + 1].Equals('r') && planetName[i + 2].Equals('c'))
                {
                    //i+3 and i+4 are the numbers if its triple digit 3 4 5
                    if (planetName[i + 5] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string s = str1 + str2;

                        int num = int.Parse(s);
                        num++;

                        returnString =  "=Arctics!C" + num;
                    }
                    else if (planetName[i + 6] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string str3 = planetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Arctics!C" + num;
                    }

                }
                else if (i + 2 < planetName.Length && planetName[i].Equals('D')  && planetName[i + 1].Equals('e') && planetName[i + 2].Equals('s'))
                {

                    if (planetName[i + 5] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string s = str1 + str2;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Deserts!C" + num;
                    }
                    else if (planetName[i + 6] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string str3 = planetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        int num = int.Parse(s);
                        num++;

                        returnString =  "=Deserts!C" + num;
                    }
                }
                else if (i + 2 < planetName.Length && planetName[i].Equals('E') && planetName[i + 1].Equals('a') && planetName[i + 2].Equals('r'))
                {

                    if (planetName[i + 5] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string s = str1 + str2;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Earthlikes!C" + num;

                    }
                    else if (planetName[i + 6] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string str3 = planetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Earthlikes!C" + num;
                    }
                }
                else if (i + 2 < planetName.Length && planetName[i].Equals('G') && planetName[i + 1].Equals('r') && planetName[i + 2].Equals('e'))
                {

                    if (planetName[i + 5] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string s = str1 + str2;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Greenhouses!C" + num;
                    }
                    else if (planetName[i + 6] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string str3 = planetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Greenhouses!C" + num;
                    }
                }
                else if (i + 2 < planetName.Length && planetName[i].Equals('M') && planetName[i + 1].Equals('o') && planetName[i + 2].Equals('u'))
                {
                    if (planetName[i + 5] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string s = str1 + str2;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Mountainous!C" + num;
                    }
                    else if (planetName[i + 6] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string str3 = planetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Mountainous!C" + num;
                    }
                }
                else if (i + 2 < planetName.Length && planetName[i].Equals('O') && planetName[i + 1].Equals('c') && planetName[i + 2].Equals('e'))
                {

                    if (planetName[i + 5] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string s = str1 + str2;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Oceanics!C" + num;
                    }
                    else if (planetName[i + 6] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string str3 = planetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Oceanics!C" + num;
                    }
                }
                else if (i + 2 < planetName.Length && planetName[i].Equals('I') && planetName[i + 1].Equals('G') && planetName[i + 2].Equals('P'))
                {

                    if (planetName[i + 5] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string s = str1 + str2;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Paradises!C" + num;
                    }
                    else if (planetName[i + 6] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string str3 = planetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Paradises!C" + num;
                    }
                }
                else if (i + 2 < planetName.Length && planetName[i].Equals('R') && planetName[i + 1].Equals('o') && planetName[i + 2].Equals('c'))
                {

                    if (planetName[i + 5] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string s = str1 + str2;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Rockies!C" + num;
                    }
                    else if (planetName[i + 6] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string str3 = planetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Rockies!C" + num;
                    }
                }
                else if (i + 2 < planetName.Length && planetName[i].Equals('V') && planetName[i + 1].Equals('o') && planetName[i + 2].Equals('l'))
                {
                    if (planetName[i + 5] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string s = str1 + str2;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Volcanics!C" + num;
                    }
                    else if (planetName[i + 6] == '.')
                    {
                        string str1 = planetName[i + 3].ToString();
                        string str2 = planetName[i + 4].ToString();
                        string str3 = planetName[i + 5].ToString();
                        string s = str1 + str2 + str3;

                        int num = int.Parse(s);
                        num++;

                        returnString = "=Volcanics!C" + num;
                    }
                }
                else {
                } //MessageBox.Show(planetName + " not found!");                             

            }//end i

            return returnString;
        }
        private void MainForm_FormClosing(object sender, CancelEventArgs e)
        {
            Excel.Kill();
            //Console.WriteLine("Kill Excel called");
        }

        public static string RemoveLetters(string append)
        {
            append = Regex.Replace(append, "[A-Za-z ]", "");
            return append;
        }
        public static string RemoveParenthesisColonComma(string append)
        {
            append = Regex.Replace(append, "[(]", "");
            append = Regex.Replace(append, "[)]", "");
            append = Regex.Replace(append, "[:]", "");
            append = Regex.Replace(append, "[:]", "");
            append = Regex.Replace(append, "[,]", "");
            return append;
        }
        public static string RemoveSlashes(string append)
        {
            append = Regex.Replace(append, "[/]", "");
            append = Regex.Replace(append, "['\']", "");
            return append;
        }
        public static string RemoveSpaces(string append)
        {
            //append.TrimStart();
            append.Trim();
            append = Regex.Replace(append, " ", "");
            return append;
        }

        private void NamePlanetButton_Click(object sender, EventArgs e)
        {

        }

        private void FindWeakSolarsButton_Click(object sender, EventArgs e)
        {
            Excel totals = OpenFileAt(1);
            for (int j = 2; j <= 10; j++) // goes through each sheet
            {
                Excel excel = OpenFileAt(j);

                int planet = excel.ReadCellInt(1, 8);
                for (int i = 1; i <= planet; i++) // goes through the planet list
                {
                    if (( excel.ReadCellInt(i, 34) > 0  && excel.ReadCellInt(i, 34) <= 15) || excel.ReadCellInt(i, 35) > 0 && excel.ReadCellInt(i, 35) <= 87 )
                    {
                        Console.WriteLine("Solar is " + excel.ReadCellInt(i, 34));
                        Console.WriteLine("Solar rate is " + excel.ReadCellInt(i, 35));
                        Adder.AddToWeakSolars(excel.ReadCellString(i, 2), totals);
                    }
                }

                excel.Close();
            }
            totals.Close();
            MessageBox.Show("Weak Solars added to totals", "Message");
        }

    } //form1
}//namespace
