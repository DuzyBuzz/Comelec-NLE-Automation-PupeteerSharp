using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PuppeteerSharp;

namespace Comelec_NLE_Automation
{
    public class Scraper
    {
        public async Task<ScrapedData?> ScrapeData(string url)
        {
            try
            {

                await using var browser = await Puppeteer.LaunchAsync(new LaunchOptions
                {
                    Headless = false,
                    Args = new[] { "--no-sandbox", "--disable-setuid-sandbox", "--disable-blink-features=AutomationControlled" }
                });


                await using var page = await browser.NewPageAsync();
                await page.GoToAsync(url, WaitUntilNavigation.Networkidle2);

                // Ensure elements load properly before extraction
                await page.WaitForSelectorAsync(".gen-inf-row:nth-child(7) .gen-inf-value", new WaitForSelectorOptions { Timeout = 10000 });
                await page.WaitForSelectorAsync(".gen-inf-row:nth-child(10) .gen-inf-value", new WaitForSelectorOptions { Timeout = 10000 });
                await page.WaitForSelectorAsync(".gen-inf-row:nth-child(7) .gen-inf-value", new WaitForSelectorOptions { Timeout = 10000 });
                await page.WaitForSelectorAsync(".gen-inf-row:nth-child(10) .gen-inf-value", new WaitForSelectorOptions { Timeout = 10000 });

                async Task<string> GetValueAsync(string selector)
                {
                    var element = await page.QuerySelectorAsync(selector);
                    return element != null ? (await (await element.GetPropertyAsync("textContent")).JsonValueAsync<string>()).Trim() : "0";
                }

                var selectors = new Dictionary<string, string>
                {
                    {"Absentations", ".gen-inf-row:nth-child(6) .gen-inf-value"},
                    {"NumberOfRegisteredVoters", ".gen-inf-row:nth-child(7) .gen-inf-value"},
                    {"VotersWhoActuallyVoted", ".gen-inf-row:nth-child(8) .gen-inf-value"},
                    {"ValidBallotsCast", ".gen-inf-row:nth-child(9) .gen-inf-value"},
                    {"Turnout", ".gen-inf-row:nth-child(10) .gen-inf-value"},
                    {"Location", ".gen-inf-row:nth-child(2) .gen-inf-value"}
                };

                var scrapedValues = new Dictionary<string, string>();
                foreach (var (key, selector) in selectors)
                {
                    try
                    {
                        scrapedValues[key] = await GetValueAsync(selector);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"❌ Error extracting {key}: {ex.Message}");
                        scrapedValues[key] = "0";
                    }
                }

                var candidateRows = await page.QuerySelectorAllAsync(".candidate-row");
                var candidates = new List<Candidate>();
                foreach (var row in candidateRows)
                {
                    try
                    {
                        var nameElement = await row.QuerySelectorAsync(".candidate-info");
                        var votesElement = await row.QuerySelectorAsync(".col-xs-4.col-sm-2.col-middle.no-side-padding.inside-no-margin.candidate-contest-result .candidate-result span");
                        var percentageElement = await row.QuerySelectorAsync(".hidden-xs.col-sm-2.col-middle.no-side-padding.inside-no-margin.candidate-contest-result .candidate-result span");

                        var name = nameElement != null ? await (await nameElement.GetPropertyAsync("textContent")).JsonValueAsync<string>() : "";
                        var votesText = votesElement != null ? await (await votesElement.GetPropertyAsync("textContent")).JsonValueAsync<string>() : "0";
                        var percentageText = percentageElement != null ? await (await percentageElement.GetPropertyAsync("textContent")).JsonValueAsync<string>() : "0%";

                        if (!string.IsNullOrEmpty(name))
                        {
                            candidates.Add(new Candidate
                            {
                                Name = name.Trim(),
                                Votes = int.TryParse(votesText.Replace(",", ""), out int votes) ? votes : 0,
                                Percentage = float.TryParse(percentageText.Replace("%", "").Trim(), out float percentage) ? percentage : 0
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"❌ Error extracting candidate data: {ex.Message}");
                    }
                }

                await browser.CloseAsync();

                Console.WriteLine($"✅ Data extracted: VotersVoted - {scrapedValues["NumberOfRegisteredVoters"]}, Turnout - {scrapedValues["Turnout"]}, Location - {scrapedValues["Location"]}");

                return new ScrapedData
                {
                    Absentations = int.TryParse(scrapedValues["Absentations"].Replace(",", ""), out int absentationsValue) ? absentationsValue : 0,
                    NumberOfRegisteredVoters = int.TryParse(scrapedValues["NumberOfRegisteredVoters"].Replace(",", ""), out int numberOfRegisteredVotersValue) ? numberOfRegisteredVotersValue : 0,
                    VotersWhoActuallyVoted = int.TryParse(scrapedValues["VotersWhoActuallyVoted"].Replace(",", ""), out int votersWhoActuallyVotedValue) ? votersWhoActuallyVotedValue : 0,
                    ValidBallotsCast = int.TryParse(scrapedValues["ValidBallotsCast"].Replace(",", ""), out int validBallotsCastValue) ? validBallotsCastValue : 0,
                    Turnout = float.TryParse(scrapedValues["Turnout"].Replace("%", ""), out float turnoutValue) ? turnoutValue : 0,
                    Location = scrapedValues["Location"],
                    Candidates = candidates
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Failed to scrape {url}: {ex.Message}");
                return null;
            }
        }
    }

    public class ScrapedData
    {
        public int LDL { get; set; }
        public int CTB { get; set; }
        public int NumberOfRegisteredVoters { get; set; }
        public int VotersWhoActuallyVoted { get; set;  }
        public int ValidBallotsCast { get; set; }
        public int Absentations { get; set; }
        public float Turnout { get; set; }
        public string Location { get; set; }
        public List<Candidate> Candidates { get; set; } = new List<Candidate>();
    }

    public class Candidate
    {
        public string Name { get; set; }
        public int Votes { get; set; }
        public float Percentage { get; set; }
    }
}
