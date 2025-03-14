using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using PuppeteerSharp;
using System.Text;
using ClosedXML.Excel;
using System.Globalization;

namespace Comelec_NLE_Automation
{


    public partial class NLE_automation : Form
    {
        private string baseFolderPath;
        private Scraper _scraper;
        private List<string> filteredPrecincts = new List<string>();


        public NLE_automation()
        {
            InitializeComponent();
            _scraper = new Scraper();

            regionComboBox.SelectedIndexChanged += RegionComboBox_SelectedIndexChanged;
            districtProvinceComboBox.SelectedIndexChanged += DistrictProvinceComboBox_SelectedIndexChanged;
            cityMunicipalityComboBox.SelectedIndexChanged += CityMunicipalityComboBox_SelectedIndexChanged;
            barangayComboBox.SelectedIndexChanged += BarangayComboBox_SelectedIndexChanged;
        }

        private void NLE_automation_Load(object sender, EventArgs e)
        {
            string debugDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderName = "NLE_precincts";
            baseFolderPath = Path.Combine(debugDirectory, folderName);

            if (Directory.Exists(baseFolderPath))
            {
                LoadFolders(baseFolderPath);
            }
            else
            {
                MessageBox.Show("Folder not found.", "Folder Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadFolders(string folderPath)
        {
            var directories = Directory.GetDirectories(folderPath).Select(Path.GetFileName).ToArray();
            regionComboBox.Items.Clear();
            regionComboBox.Items.AddRange(directories);
        }

        private void RegionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regionComboBox.SelectedItem != null)
            {
                string selectedFolder = regionComboBox.SelectedItem.ToString();
                string selectedFolderPath = Path.Combine(baseFolderPath, selectedFolder);
                LoadCsvFiles(selectedFolderPath);
            }
        }

        private void LoadCsvFiles(string folderPath)
        {
            var csvFiles = Directory.GetFiles(folderPath, "*.csv").ToArray();
            districtProvinceComboBox.Items.Clear();
            districtProvinceComboBox.Items.AddRange(csvFiles.Select(Path.GetFileNameWithoutExtension).ToArray());

        }

        private void DistrictProvinceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityMunicipalityComboBox.Text = string.Empty;
            barangayComboBox.Text = string.Empty;

            if (districtProvinceComboBox.SelectedItem != null)
            {
                string selectedCsvFile = $"{districtProvinceComboBox.SelectedItem}.csv";
                string selectedFilePath = Path.Combine(baseFolderPath, regionComboBox.SelectedItem.ToString(), selectedCsvFile);
                LoadMunicipalities(selectedFilePath);
            }
        }

        private void LoadMunicipalities(string filePath)
        {
            List<string> municipalities = new List<string>();

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    reader.ReadLine(); // Skip header
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] columns = line.Split(',');
                        if (columns.Length > 2)
                        {
                            string municipality = columns[2].Trim();
                            if (!municipalities.Contains(municipality))
                            {
                                municipalities.Add(municipality);
                            }
                        }
                    }
                }
            }

            cityMunicipalityComboBox.Items.Clear();
            cityMunicipalityComboBox.Items.AddRange(municipalities.ToArray());
        }

        private void CityMunicipalityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            barangayComboBox.Items.Clear();
            if (cityMunicipalityComboBox.SelectedItem != null)
            {
                string selectedMunicipality = cityMunicipalityComboBox.SelectedItem.ToString();
                string selectedCsvFile = $"{districtProvinceComboBox.SelectedItem}.csv";
                string selectedFilePath = Path.Combine(baseFolderPath, regionComboBox.SelectedItem.ToString(), selectedCsvFile);
                LoadBarangays(selectedFilePath, selectedMunicipality);
            }
        }

        private void LoadBarangays(string filePath, string municipality)
        {
            List<string> barangays = new List<string>();

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    reader.ReadLine(); // Skip the header row
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] columns = line.Split(',');
                        if (columns.Length > 3 && columns[2].Trim().Equals(municipality, StringComparison.OrdinalIgnoreCase))
                        {
                            string barangay = columns[3].Trim();
                            if (!barangays.Contains(barangay))
                            {
                                barangays.Add(barangay);
                            }
                        }
                    }
                }
            }

            barangayComboBox.Items.Clear();
            barangayComboBox.Items.AddRange(barangays.ToArray());
            barangayComboBox.SelectedIndexChanged += BarangayComboBox_SelectedIndexChanged;
        }

        private void BarangayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (barangayComboBox.SelectedItem != null)
            {
                string selectedBarangay = barangayComboBox.SelectedItem.ToString();
                string selectedCsvFile = districtProvinceComboBox.SelectedItem.ToString() + ".csv";
                string selectedFilePath = Path.Combine(baseFolderPath, regionComboBox.SelectedItem.ToString(), selectedCsvFile);
                LoadPrecincts(selectedFilePath, cityMunicipalityComboBox.SelectedItem.ToString(), selectedBarangay);
            }
        }


        private void LoadPrecinctsByProvince(string province)
        {
            List<string> precincts = new List<string>();

            foreach (var csvFile in Directory.GetFiles(baseFolderPath, "*.csv", SearchOption.AllDirectories))
            {
                using (StreamReader reader = new StreamReader(csvFile))
                {
                    reader.ReadLine(); // Skip the header row
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] columns = line.Split(',');
                        if (columns.Length > 4 && columns[1].Trim().Equals(province, StringComparison.OrdinalIgnoreCase))
                        {
                            string precinct = columns[4].Trim();
                            if (!precincts.Contains(precinct))
                            {
                                precincts.Add(precinct);
                            }
                        }
                    }
                }
            }

        }
        private void LoadPrecincts(string province = null, string municipality = null, string barangay = null)
        {
            filteredPrecincts.Clear();  // Clear the filtered precincts before loading new ones.

            List<string> precinctIds = new List<string>();  // To store the precinctId values

            foreach (var csvFile in Directory.GetFiles(baseFolderPath, "*.csv", SearchOption.AllDirectories))
            {
                try
                {
                    using (FileStream fs = new FileStream(csvFile, FileMode.Open, FileAccess.Read, FileShare.Read))
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        reader.ReadLine(); // Skip the header row
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] columns = line.Split(',');

                            // Check if the row matches the selected region, province, municipality, and barangay
                            if (columns.Length > 4 &&
                                (province == null || columns[1].Trim().Equals(province, StringComparison.OrdinalIgnoreCase)) &&
                                (municipality == null || columns[2].Trim().Equals(municipality, StringComparison.OrdinalIgnoreCase)) &&
                                (barangay == null || columns[3].Trim().Equals(barangay, StringComparison.OrdinalIgnoreCase)))
                            {
                                // Add the precinctId (the appropriate column) to the list
                                string precinctId = columns[4].Trim();
                                if (!precinctIds.Contains(precinctId))
                                {
                                    precinctIds.Add(precinctId);
                                }
                            }
                        }
                    }
                }
                catch (IOException ex)
                {
                    // Handle the error if the file is locked or any other IO issue
                    MessageBox.Show($"Error accessing file {csvFile}: {ex.Message}", "File Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Join the precinctId values into a single string and set it as the text in filterTextBox
            filterTextBox.Text = string.Join(Environment.NewLine, precinctIds);
        }



        private void regionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            districtProvinceComboBox.Text = string.Empty;
        }

        private void districtProvinceComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Clear the selections for City/Municipality and Barangay
            cityMunicipalityComboBox.Text = string.Empty;
            barangayComboBox.Text = string.Empty;

            // Get the selected province (district) value from the combo box
            string selectedProvince = districtProvinceComboBox.SelectedItem?.ToString();

            // Call LoadPrecincts with the selected province
            LoadPrecincts(province: selectedProvince);
        }

        private void cityMunicipalityComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            barangayComboBox.Text = string.Empty;
            // Get the selected province (district) value from the combo box
            string selectedMunicipality = cityMunicipalityComboBox.SelectedItem?.ToString();

            // Call LoadPrecincts with the selected province
            LoadPrecincts(municipality: selectedMunicipality);
        }

        private void barangayComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Get the selected province (district) value from the combo box
            string selectedBarangay = barangayComboBox.SelectedItem?.ToString();

            // Call LoadPrecincts with the selected province
            LoadPrecincts(barangay: selectedBarangay);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            regionComboBox.Text = string.Empty;
            districtProvinceComboBox.Text = string.Empty;
            cityMunicipalityComboBox.Text = string.Empty;
            barangayComboBox.Text = string.Empty;
            machineIDCheckBox.Checked = false;
            votingCenterCheckBox.Checked = false;
            pricinctsClusterCheckBox.Checked = false;
            absententionsCheckBox.Checked = false;
            registeredVotersCheckBox.Checked = false;
            votersVotedCheckBox.Checked = false;
            validBallotsCastCheckBox.Checked = false;
            turnoutCheckBox.Checked = false;
            nationalPositionsDGV.Rows.Clear();
        }

        private void pricintIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void generateBTN_Click(object sender, EventArgs e)
        {

        }

        private async void generateButton_Click(object sender, EventArgs e)
        {
            generateButton.Enabled = false;
            generateButton.Text = "Generating...";

            try
            {
                string[] precinctIds = filterTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                if (precinctIds.Length == 0)
                {
                    MessageBox.Show("No precincts found. Please select a region, province, and municipality.", "No Precincts", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StringBuilder results = new StringBuilder();
                var barangayData = new Dictionary<string, BarangayResult>();

                foreach (string precinctId in precinctIds)
                {
                    Console.WriteLine($"Scraping precinct: {precinctId}");
                    string url = $"https://2022electionresults.comelec.gov.ph/#/er/{precinctId}/local";
                    ScrapedData? result = await _scraper.ScrapeData(url);

                    if (result != null)
                    {
                        string[] locationParts = result.Location.Split(',');

                        string region = locationParts.Length > 0 ? locationParts[0].Trim() : "";
                        string province = locationParts.Length > 1 ? locationParts[1].Trim() : "";
                        string city = locationParts.Length > 2 ? locationParts[2].Trim() : "";
                        string barangay = locationParts.Length > 3 ? locationParts[3].Trim() : "";

                        string barangayKey = $"{region}|{province}|{city}|{barangay}";

                        if (!barangayData.ContainsKey(barangayKey))
                        {
                            barangayData[barangayKey] = new BarangayResult
                            {
                                Region = region,
                                Province = province,
                                City = city,
                                Barangay = barangay,
                                NumberOfPrecincts = 0,
                                RegisteredVoters = 0,
                                VotersWhoActuallyVoted = 0,
                                ValidBallotsCast = 0,
                                Turnout = 0,
                                Candidates = new Dictionary<string, (int votes, double percentage)>()
                            };
                        }

                        var barangayEntry = barangayData[barangayKey];

                        barangayEntry.NumberOfPrecincts++;
                        barangayEntry.RegisteredVoters += result.NumberOfRegisteredVoters;
                        barangayEntry.VotersWhoActuallyVoted += result.VotersWhoActuallyVoted;
                        barangayEntry.ValidBallotsCast += result.ValidBallotsCast;

                        // Sum candidate votes
                        foreach (var candidate in result.Candidates)
                        {
                            if (!barangayEntry.Candidates.ContainsKey(candidate.Name))
                            {
                                barangayEntry.Candidates[candidate.Name] = (0, 0);
                            }

                            var candidateEntry = barangayEntry.Candidates[candidate.Name];
                            barangayEntry.Candidates[candidate.Name] = (candidateEntry.votes + candidate.Votes, 0);
                        }
                    }
                }

                // Recalculate correct percentages
                foreach (var barangay in barangayData.Values)
                {
                    foreach (var candidate in barangay.Candidates.Keys.ToList())
                    {
                        int totalVotes = barangay.ValidBallotsCast > 0 ? barangay.ValidBallotsCast : 1;
                        double newPercentage = ((double)barangay.Candidates[candidate].votes / totalVotes) * 100;
                        newPercentage = Math.Round(newPercentage, 2); // Ensure 2 decimal places

                        barangay.Candidates[candidate] = (barangay.Candidates[candidate].votes, newPercentage);
                    }
                }

                // Create Excel file
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Election Results");

                    // Set headers
                    worksheet.Cell(1, 1).Value = "Region";
                    worksheet.Cell(1, 2).Value = "Province/District";
                    worksheet.Cell(1, 3).Value = "City/Municipality";
                    worksheet.Cell(1, 4).Value = "Barangay";
                    worksheet.Cell(1, 5).Value = "Number of Precincts";
                    worksheet.Cell(1, 6).Value = "Registered Voters";
                    worksheet.Cell(1, 7).Value = "Voters Who Actually Voted";
                    worksheet.Cell(1, 8).Value = "Valid Ballots Cast";
                    worksheet.Cell(1, 9).Value = "Turnout (%)";

                    int row = 2;

                    // Find unique candidates for dynamic headers
                    var allCandidates = barangayData.Values.SelectMany(b => b.Candidates.Keys).Distinct().ToList();
                    int col = 10;
                    foreach (var candidate in allCandidates)
                    {
                        worksheet.Cell(1, col).Value = $"{candidate} (Votes)";
                        worksheet.Cell(1, col + 1).Value = $"{candidate} (Percentage)";
                        col += 2;
                    }

                    // Insert merged barangay data
                    foreach (var barangay in barangayData.Values)
                    {
                        worksheet.Cell(row, 1).Value = barangay.Region;
                        worksheet.Cell(row, 2).Value = barangay.Province;
                        worksheet.Cell(row, 3).Value = barangay.City;
                        worksheet.Cell(row, 4).Value = barangay.Barangay;
                        worksheet.Cell(row, 5).Value = barangay.NumberOfPrecincts;
                        worksheet.Cell(row, 6).Value = barangay.RegisteredVoters;
                        worksheet.Cell(row, 7).Value = barangay.VotersWhoActuallyVoted;
                        worksheet.Cell(row, 8).Value = barangay.ValidBallotsCast;

                        // Calculate correct turnout
                        double turnout = barangay.VotersWhoActuallyVoted > 0 ?
                                         ((double)barangay.VotersWhoActuallyVoted / barangay.RegisteredVoters) * 100 : 0;
                        worksheet.Cell(row, 9).Value = Math.Round(turnout, 2);

                        col = 10;
                        foreach (var candidate in allCandidates)
                        {
                            if (barangay.Candidates.ContainsKey(candidate))
                            {
                                worksheet.Cell(row, col).Value = barangay.Candidates[candidate].votes;
                                worksheet.Cell(row, col + 1).Value = barangay.Candidates[candidate].percentage.ToString("F2", CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                worksheet.Cell(row, col).Value = 0;
                                worksheet.Cell(row, col + 1).Value = "0.00";
                            }
                            col += 2;
                        }

                        row++;
                    }

                    // Auto-fit columns
                    worksheet.Columns().AdjustToContents();

                    // Save the file
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ElectionResults.xlsx");
                    workbook.SaveAs(filePath);

                    MessageBox.Show($"Excel file saved to: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                generateButton.Enabled = true;
                generateButton.Text = "Generate";
            }
        }

        // Helper class to store merged data
        class BarangayResult
        {
            public string Region { get; set; }
            public string Province { get; set; }
            public string City { get; set; }
            public string Barangay { get; set; }
            public int NumberOfPrecincts { get; set; }
            public int RegisteredVoters { get; set; }
            public int VotersWhoActuallyVoted { get; set; }
            public int ValidBallotsCast { get; set; }
            public double Turnout { get; set; }
            public Dictionary<string, (int votes, double percentage)> Candidates { get; set; }
        }




        private void nationalPositionsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}