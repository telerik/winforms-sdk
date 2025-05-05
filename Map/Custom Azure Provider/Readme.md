# RadMap Custom Azure Provider Demo

This application demonstrates the integration of the Telerik RadMap control with a custom Azure Map Provider. It showcases how to use the Azure Maps API to display map tiles, perform search operations, and add custom map pins based on search results.

## Features
- Integration with Azure Maps using a custom provider.
- Support for caching map tiles locally to improve performance.
- Interactive search functionality with results displayed as map pins.

## Requirements
- An Azure API key is required to use the Azure Map Provider. The application will throw an exception if the API key is not provided.
- .Net Framework 4.8, .NET 9 and Telerik UI for WinForms are required to run the application.

## Usage
1. Provide a valid Azure API key in the `AzureAPIKey` field in the code.
2. Run the application to explore the map and perform searches.
3. Search results will be displayed as pins on the map, with tooltips showing the formatted address.