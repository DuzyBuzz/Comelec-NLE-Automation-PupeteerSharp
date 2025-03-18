Comelec NLE Automation Scraper
Overview
Comelec NLE Automation is a C# application that utilizes PuppeteerSharp to scrape election-related data from a given URL. It extracts information such as voter turnout, the number of registered voters, valid ballots cast, and candidate details.

Features
Scrapes voter statistics including:
Number of Registered Voters
Voters Who Actually Voted
Valid Ballots Cast
Absentations
Turnout Percentage
Location
Extracts candidate details:
Candidate Name
Votes Received
Percentage of Votes
Uses PuppeteerSharp to handle headless browser automation.
Implements error handling for missing or malformed data.
Prerequisites
Ensure you have the following installed:

.NET 6.0 or higher - Download from dotnet.microsoft.com
Node.js (for PuppeteerSharp dependencies) - Download
PuppeteerSharp - Installed via NuGet
