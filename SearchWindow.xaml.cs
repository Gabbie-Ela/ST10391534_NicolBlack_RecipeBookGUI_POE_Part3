using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ST10391534_NicolBlack_RecipeBookGUI_POE_Part3
{
    // SearchWindow class inherits from Window class
    public partial class SearchWindow : Window
    {
        // Private field to store list of Recipe objects
        private List<Recipe> recipes;

        // Constructor that initializes the window with a list of recipes
        public SearchWindow(List<Recipe> recipes)
        {
            // Initializes components defined in XAML
            InitializeComponent();

            // Assigns the provided list of recipes to the private field
            this.recipes = recipes;

            // Displays all recipes initially upon window creation
            DisplayAllRecipes();
        }

        // Method to display all recipes in the searchBox
        private void DisplayAllRecipes()
        {
            // Sets the ItemsSource of searchBox to a formatted string for each recipe in recipes
            searchBox.ItemsSource = recipes.Select(r => $"{r.Name} - Total Calories: {r.TotalCalories}").ToList();
        }

        // Event handler for when the text in the searchTBox changes
        private void SearchTBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // Calls FilterRecipes method with the current text in the search box
            FilterRecipes(searchTBox.Text);
        }

        // Method to filter recipes based on a search text
        private void FilterRecipes(string searchText)
        {
            // If search text is empty or whitespace, display all recipes and return
            if (string.IsNullOrWhiteSpace(searchText))
            {
                DisplayAllRecipes();
                return;
            }

            // Convert search text to lowercase for case-insensitive search
            searchText = searchText.ToLower();

            // Filters recipes based on conditions: recipe name, ingredient names, and food group names
            var filteredRecipes = recipes.Where(r =>
                r.Name.ToLower().Contains(searchText) ||
                r.Ingredients.Any(i => i.Name.ToLower().Contains(searchText)) ||
                r.Ingredients.Any(i => i.FoodGroup.ToLower().Contains(searchText))
            ).ToList();

            // Updates the ItemsSource of searchBox with filtered recipes
            searchBox.ItemsSource = filteredRecipes.Select(r => $"{r.Name} - Total Calories: {r.TotalCalories}").ToList();
        }

        // Event handler for double-click event on searchBox
        private void SearchBox_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Retrieves the index of the selected item in searchBox
            int selectedIndex = searchBox.SelectedIndex;
            // If an item is selected
            if (selectedIndex != -1)
            {
                // Retrieves the corresponding recipe from recipes list
                Recipe selectedRecipe = recipes[selectedIndex];
                // Creates a new DisplayWindow instance with the selected recipe and the list of all recipes
                DisplayWindow displayWindow = new DisplayWindow(selectedRecipe, recipes);
                // Shows the DisplayWindow and hides the current SearchWindow
                displayWindow.Show();
                this.Hide();
            }
        }

        // Event handler for Search button click
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            // Calls FilterRecipes method with the current text in the searchTBox
            FilterRecipes(searchTBox.Text);
        }

        // Event handler for ViewRecipes button click
        private void ViewRecipes_Click(object sender, RoutedEventArgs e)
        {
            // Creates a new RecipesWindow instance with the list of all recipes
            RecipesWindow recipesWindow = new RecipesWindow(recipes);
            // Shows the RecipesWindow and hides the current SearchWindow
            recipesWindow.Show();
            this.Hide();
        }

        // Event handler for Exit button click
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            // Shuts down the application
            Application.Current.Shutdown();
        }

        // Event handler for BackBtn click
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            // Creates a new MainWindow instance
            MainWindow mainWindow = new MainWindow();
            // Shows the MainWindow and hides the current SearchWindow
            mainWindow.Show();
            this.Hide();
        }

        // Event handler for CloseBtn mouse down
        private void CloseBtn_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Closes the current SearchWindow
            this.Close();
        }
    }
}