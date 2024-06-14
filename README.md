# ST10391534_NicolBlack_RecipeBookGUI_POE_Part3
Recipe Book WPF Application
Description
The Recipe Book WPF application is designed to manage recipes efficiently. It provides functionalities to capture, display, scale, and delete recipes. This user-friendly application ensures seamless navigation and interaction through its intuitive interface.

Program Classes and Pages
The RecipeBookGUI_PPOE application is composed of interconnected classes and pages that facilitate smooth navigation and user interaction. Key components include:

MainWindow.xaml
Add Ingredient: Allows users to input ingredient details such as name, quantity, calories, and food group. Ingredients are added to a list displayed in a ListBox.

Add Step: Enables users to input preparation steps for a recipe. Each step is appended to a list and displayed in a ListBox.

Add Recipe: Compiles entered details into a complete recipe, ensuring all necessary steps are included before adding to the collection. Displays a success message upon completion.

Exit Application: Provides a button to close the application.

RecipesWindow.xaml
View Recipes: Displays all recipes stored in the application.

Search: Allows users to filter recipes by ingredient, calories, or food group.

Delete Recipe: Enables users to remove recipes from the collection.

Back Navigation: Allows users to return to the previous window.

Exit Application: Provides a button to close the application.

SearchWindow.xaml
Search: Allows users to enter queries to filter recipes dynamically.

Results Display: Shows recipes matching the search criteria.

Detailed View: Double-clicking on a recipe in the results list opens detailed information in a separate window.

DisplayWindow.xaml
Recipe Details: Displays the full details of a selected recipe, including name, calories, ingredients (shown as checkboxes), and preparation steps.

Scale Recipe: Allows users to adjust ingredient quantities and calories by selecting scaling options (0.5, 2, 3).

Reset Recipe: Resets the recipe to its original details.

View All Recipes: Provides a button to view all recipes stored in the application.

Search: Allows users to search for specific recipes.

Exit Application: Provides a button to close the application.

How to Compile and Run the Recipe Book WPF Application
Prerequisites
Ensure the following prerequisites are met:

Visual Studio: Install Visual Studio on your computer. This guide assumes Visual Studio is used for compilation.
Steps
Clone the Repository:

Clone the repository containing the WPF application code.
Open Solution in Visual Studio:

Launch Visual Studio.
Go to File -> Open -> Project/Solution....
Navigate to the directory where you cloned the repository and select the solution file (ST10391534_NicolBlack_RecipeBookGUI_POE_Part3.sln) for the project.
Restore NuGet Packages:

If prompted, restore the NuGet packages required for the project.
Build the Solution:

Once the solution is loaded, navigate to Build -> Build Solution (or press Ctrl+Shift+B) to compile the application.
Set as Startup Project:

In the Solution Explorer, right-click on the project (ST10391534_NicolBlack_RecipeBookGUI_POE_Part3).
Select Set as Startup Project.
Run the Application:

Press F5 or go to Debug -> Start Debugging to run the application.
Interact with the Application:

The application window titled "Recipe Book" will launch.
Use buttons such as "Add Recipe", "View Recipes", "Search", and others to interact with the application's features.
Exit the Application:

To close the application, click on the "Exit" button within the application interface.
Conclusion
This guide provides a comprehensive approach to compiling, running, and interacting with the Recipe Book WPF application using Visual Studio. Each window and feature is designed to enhance usability and provide a seamless experience for managing recipes effectively.
