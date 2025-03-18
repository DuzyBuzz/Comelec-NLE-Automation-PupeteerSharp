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
Installation
Clone the repository:

sh
Copy
Edit
git clone https://github.com/yourusername/Comelec_NLE_Automation.git
cd Comelec_NLE_Automation
Install PuppeteerSharp using NuGet:

sh
Copy
Edit
dotnet add package PuppeteerSharp
Restore dependencies:

sh
Copy
Edit
dotnet restore
Usage
Open the project in Visual Studio or any preferred IDE.
Modify the Scraper class to input the desired URL.
Run the program:
sh
Copy
Edit
dotnet run
The extracted election data will be displayed in the console.
Code Structure
Scraper.cs - Contains the PuppeteerSharp logic for scraping election data.
ScrapedData.cs - Defines the data model for storing extracted information.
Candidate.cs - Represents individual candidate details.
Error Handling
If an element is missing, the scraper logs an error and assigns default values.
If PuppeteerSharp fails to load the page, the process exits gracefully.
Contribution
Feel free to contribute by submitting pull requests. Ensure you follow best practices and test your changes before submitting.

License
This project is open-source under the MIT License.

