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
    public partial class RecipesWindow : Window
    {
        private List<Recipe> recipes;  // Private field to store recipes list

        public RecipesWindow(List<Recipe> recipes)
        {
            InitializeComponent();  // Initialize GUI components defined in XAML
            this.recipes = recipes;  // Assign provided list of recipes to the private field
            DisplayRecipes(recipes);  // Display all recipes initially
        }

        // Method to display recipes in the ListBox
        private void DisplayRecipes(List<Recipe> recipesToDisplay)
        {
            allRecipesLBox.Items.Clear();  // Clear existing items in the ListBox
            foreach (var recipe in recipesToDisplay)
            {
                // Create CheckBox for each recipe with name and total calories
                CheckBox recipeCheckBox = new CheckBox
                {
                    Content = $"{recipe.Name} - Total Calories: {recipe.TotalCalories}"
                };
                allRecipesLBox.Items.Add(recipeCheckBox);  // Add CheckBox to the ListBox
            }
        }

        // Event handler for double-clicking on a recipe in the ListBox
        private void AllRecipesLBox_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            int selectedIndex = allRecipesLBox.SelectedIndex;  // Get index of selected item
            if (selectedIndex != -1)
            {
                Recipe selectedRecipe = recipes[selectedIndex];  // Retrieve selected recipe
                // Open a new window to display details of the selected recipe
                DisplayWindow displayWindow = new DisplayWindow(selectedRecipe, recipes);
                displayWindow.Show();  // Show the display window
                this.Hide();  // Hide the current window (RecipesWindow)
            }
        }

        // Event handler for the Filter button click
        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve filter criteria from UI elements
            string ingredientName = ingredientsTBox.Text;
            string selectedFoodGroup = (foodGroupCBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            string caloriesText = caloriesTBox.Text;

            int maxCalories = 0;
            // Parse max calories input; if invalid, show message and return
            if (!string.IsNullOrEmpty(caloriesText) && !int.TryParse(caloriesText, out maxCalories))
            {
                MessageBox.Show("Please enter a valid number for calories.");
                return;
            }

            // Filter recipes based on the criteria
            var filteredRecipes = recipes.Where(recipe =>
            {
                bool matchesIngredient = string.IsNullOrEmpty(ingredientName) || recipe.Ingredients.Any(i => i.Name.Equals(ingredientName, StringComparison.OrdinalIgnoreCase));
                bool matchesFoodGroup = string.IsNullOrEmpty(selectedFoodGroup) || recipe.Ingredients.Any(i => i.FoodGroup.Equals(selectedFoodGroup, StringComparison.OrdinalIgnoreCase));
                bool matchesCalories = maxCalories == 0 || recipe.TotalCalories <= maxCalories;
                return matchesIngredient && matchesFoodGroup && matchesCalories;
            }).ToList();

            DisplayRecipes(filteredRecipes);  // Display filtered recipes

            // Clear filter input fields after displaying filtered recipes
            ingredientsTBox.Clear();
            caloriesTBox.Clear();
            foodGroupCBox.SelectedIndex = -1;
        }

        // Event handler for the Search button click
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            // Open a new window to perform recipe search
            SearchWindow search = new SearchWindow(recipes);
            search.Show();  // Show the search window
            this.Hide();  // Hide the current window (RecipesWindow)
        }

        // Event handler for the Back button click
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            // Return to the main window with the current recipes list
            MainWindow mainWindow = new MainWindow(recipes);
            mainWindow.Show();  // Show the main window
            this.Hide();  // Hide the current window (RecipesWindow)
        }

        // Event handler for the View Recipes button click
        private void ViewRecipes_Click(object sender, RoutedEventArgs e)
        {
            // Open a new instance of RecipesWindow to view recipes
            RecipesWindow recipesWindow = new RecipesWindow(recipes);
            recipesWindow.Show();  // Show the recipes window
            this.Hide();  // Hide the current window (RecipesWindow)
        }

        // Event handler for the Delete button click
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            List<Recipe> recipesToDelete = new List<Recipe>();

            // Iterate through all CheckBox items in the ListBox
            foreach (var item in allRecipesLBox.Items)
            {
                if (item is CheckBox checkBox && checkBox.IsChecked == true)
                {
                    // Extract recipe name from CheckBox content
                    string recipeName = checkBox.Content.ToString().Split('-')[0].Trim();
                    // Find the recipe to delete from the recipes list
                    Recipe recipeToDelete = recipes.FirstOrDefault(r => r.Name == recipeName);
                    if (recipeToDelete != null)
                    {
                        recipesToDelete.Add(recipeToDelete);  // Add recipe to delete list
                    }
                }
            }

            // Remove selected recipes from the recipes list
            foreach (var recipe in recipesToDelete)
            {
                recipes.Remove(recipe);
            }

            DisplayRecipes(recipes);  // Display updated recipes list
        }

        // Event handler for the Exit menu item click
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();  // Close the current window (RecipesWindow)
        }

        // Event handler for closing the window using the Close button
        private void CloseBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();  // Close the current window (RecipesWindow)
        }

        private void caloriesTBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}