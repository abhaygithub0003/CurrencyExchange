# CurrencyExchange


Currency Converter Application
This project is a Currency Converter application developed using .NET Core. The application fetches real-time exchange rates from an external API and allows users to convert between different currencies. This document outlines the setup, features, usage instructions.

1. Environment Setup and Project Creation
Install .NET Core SDK: Download and install from here.
Choose IDE: Use Visual Studio or Visual Studio Code.
Create Project: Open your IDE and create a new .NET Core console application named CurrencyConverter.
2. Select and Configure API
Select API: Choose an API :- ExchangeRate-API.
Obtain Credentials: Register and get credentials if required.
Add Configuration: Store API key in a configuration file.
3. Implement API Integration
Add Dependencies: Use HttpClient for making HTTP requests.
Fetch Data: Implement asynchronous logic to fetch real-time exchange rates.
Parse Data: Extract necessary exchange rate information from the API response.
4. Develop Currency Conversion Logic
Create Methods: Implement methods to calculate conversions between different currencies.
Handle Inputs: Manage user inputs for amount, source currency, and target currency.
Error Handling: Handle cases of invalid input or unavailable exchange rates.
5. Design User Interface
Console Input/Output: Use console input/output for user interaction.
Prompts and Menus: Provide prompts for amount, source currency, and target currency. Implement a menu for navigation.
Display Results: Show conversion results and exchange rates to the user.
6. Run and Test the Application
Clone Repository: Clone the project repository and navigate to the project directory.
Run Application: Use the command dotnet run to start the application.
Test Functionality: Test various currency conversions and handle edge cases.
7. Documentation and Deliverables
Source Code: Ensure the source code is well-organized and commented.
User Guide: Provide brief usage instructions within the README file.
Test Report: Summarize the testing process and results, noting any issues or bugs found.
By following these steps, you will set up, implement, and run a functional Currency Converter application in .NET Core.



