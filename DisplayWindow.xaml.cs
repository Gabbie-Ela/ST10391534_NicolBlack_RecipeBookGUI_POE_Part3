using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class DisplayWindow : Window
    {
        // Private fields to hold recipe data
        private Recipe recipe;
        private List<Recipe> recipes;
        private List<Ingredient> scaledIngredients;
        private List<string> scaledSteps;

        // Constructor to initialize the window with a recipe and list of recipes
        public DisplayWindow(Recipe recipe, List<Recipe> recipes)
        {
            InitializeComponent();

            // Initialize fields
            this.recipe = recipe;
            this.recipes = recipes;
            this.scaledIngredients = new List<Ingredient>();
            this.scaledSteps = new List<string>();

            // Display initial recipe details
            DisplayRecipeDetails();
        }

        // Method to display original recipe details
        private void DisplayRecipeDetails()
        {
            // Clear the list box
            displayRecipeLBox.Items.Clear();

            // Display basic recipe information
            displayRecipeLBox.Items.Add($"Recipe Name: {recipe.Name}");
            displayRecipeLBox.Items.Add($"Total Calories: {recipe.TotalCalories}");
            displayRecipeLBox.Items.Add("Ingredients:");

            // Display each ingredient as a checkbox item
            foreach (var ingredient in recipe.Ingredients)
            {
                CheckBox ingredientCheckBox = new CheckBox
                {
                    Content = $"{ingredient.Quantity} {ingredient.Name} - {ingredient.Calories} calories"
                };
                displayRecipeLBox.Items.Add(ingredientCheckBox);
            }

            // Display recipe steps
            displayRecipeLBox.Items.Add("Steps:");
            foreach (var step in recipe.Steps)
            {
                CheckBox stepCheckBox = new CheckBox
                {
                    Content = step
                };
                displayRecipeLBox.Items.Add(stepCheckBox);
            }
        }

        // Method to display scaled recipe details
        private void DisplayScaledRecipeDetails()
        {
            // Clear the list box
            displayRecipeLBox.Items.Clear();

            // Display scaled recipe information
            displayRecipeLBox.Items.Add($"Recipe Name: {recipe.Name}");
            int totalScaledCalories = scaledIngredients.Sum(ingredient => int.Parse(ingredient.Calories, CultureInfo.InvariantCulture));
            displayRecipeLBox.Items.Add($"Total Calories: {totalScaledCalories}");
            displayRecipeLBox.Items.Add("Ingredients:");

            // Display each scaled ingredient as a checkbox item
            foreach (var ingredient in scaledIngredients)
            {
                CheckBox ingredientCheckBox = new CheckBox
                {
                    Content = $"{ingredient.Quantity} {ingredient.Name} - {ingredient.Calories} calories"
                };
                displayRecipeLBox.Items.Add(ingredientCheckBox);
            }

            // Display scaled recipe steps
            displayRecipeLBox.Items.Add("Steps:");
            foreach (var step in scaledSteps)
            {
                CheckBox stepCheckBox = new CheckBox
                {
                    Content = step
                };
                displayRecipeLBox.Items.Add(stepCheckBox);
            }
        }

        // Event handler for scaling the recipe based on a selected factor
        private void Scale_Click(object sender, RoutedEventArgs e)
        {
            // Check if a scale factor is selected
            if (scaleCBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a scale factor.");
                return;
            }

            // Parse the selected scale factor
            double factor = double.Parse((scaleCBox.SelectedItem as ComboBoxItem).Content.ToString(), CultureInfo.InvariantCulture);

            // Clear previous scaled ingredients
            scaledIngredients.Clear();

            // Scale each ingredient and add to scaledIngredients list
            foreach (var ingredient in recipe.Ingredients)
            {
                string numericQuantityString = ExtractNumericPart(ingredient.Quantity);
                if (!double.TryParse(numericQuantityString, NumberStyles.Any, CultureInfo.InvariantCulture, out double numericQuantity))
                {
                    MessageBox.Show($"Unable to parse quantity for ingredient: {ingredient.Name}");
                    return;
                }

                double scaledQuantity = numericQuantity * factor;
                double scaledCalories = double.Parse(ingredient.Calories, CultureInfo.InvariantCulture) * factor;

                string scaledQuantityString = $"{scaledQuantity} {GetUnitPart(ingredient.Quantity)}";

                scaledIngredients.Add(new Ingredient(scaledQuantityString, ingredient.Name, scaledCalories.ToString(CultureInfo.InvariantCulture), ingredient.FoodGroup));
            }

            // Copy original steps to scaled steps
            scaledSteps = new List<string>(recipe.Steps);

            // Display the scaled recipe details
            DisplayScaledRecipeDetails();
        }

        // Method to extract numeric part from a string (for quantity)
        private string ExtractNumericPart(string input)
        {
            var match = Regex.Match(input, @"[\d.]+");
            return match.Value;
        }

        // Method to extract unit part from a string (e.g., cup, tbsp)
        private string GetUnitPart(string input)
        {
            var match = Regex.Match(input, @"[^\d.]+");
            return match.Value.Trim();
        }

        // Event handler to reset to original recipe details
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            // Clear scaled ingredients and steps, then display original recipe details
            scaledIngredients.Clear();
            scaledSteps.Clear();
            DisplayRecipeDetails();
        }

        // Event handler to view all recipes
        private void ViewRecipes_Click(object sender, EventArgs e)
        {
            // Show the recipes window and hide this window
            RecipesWindow recipesWindow = new RecipesWindow(recipes);
            recipesWindow.Show();
            this.Hide();
        }

        // Event handler to search recipes
        private void Search_Click(object sender, EventArgs e)
        {
            // Show the search window and hide this window
            SearchWindow searchWindow = new SearchWindow(recipes);
            searchWindow.Show();
            this.Hide();
        }

        // Event handler to exit the application
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Event handler to go back to the main window
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        // Event handler to close the window
        private void CloseBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}