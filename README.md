# Manhattan Neighborhood Filter

## Summary
This program reads property data from a JSON file and provides functionalities to filter and analyze the neighborhoods in Manhattan. It uses LINQ queries and Lambda statements to extract specific information from the data and perform filtering operations.

## Visuals
Here's an example of what the program output would look like in the console:

![lookslike](./Lab9-LINQInManhattan/lab9.PNG)

## How to Use
To use this program, follow the steps below:

1. Ensure you have the Newtonsoft.Json package installed. If not, you can install it by right-clicking on your project in Visual Studio and selecting "Manage NuGet Packages." Search for "Newtonsoft.Json" and click on "Install" to add the package to your project.

2. Download the provided `data.json` file and place it in the root folder of your solution.

3. Open the solution in Visual Studio and locate the `Program.cs` file.

4. Create new Classes and name them as they named ,Replace the existing code in the `Main` method and in the classes with the code provided in the solution file.

5. Build and run the program. The console application will read the data from the `data.json` file and perform the required operations.

6. Observe the console output, which will display the results of the different filtering and analysis operations.

## Additional Details
- The program uses LINQ queries and Lambda expressions to extract and manipulate data from the JSON file.
- The JSON file should be named `data.json` and placed in the root folder of the solution.
- The program will output the list of all neighborhoods, filter out neighborhoods without names, remove duplicates, and provide consolidated and rewritten queries.
- The `Root` class and related classes have been defined to match the structure of the JSON data.
- Make sure to have the Newtonsoft.Json package installed and referenced in your project to handle JSON deserialization.