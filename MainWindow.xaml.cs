using System.Text;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Lists to hold ingredients, steps, and recipes
        private List<Ingredient> Ingredients = new List<Ingredient>();
        private List<string> Steps = new List<string>();
        private List<Recipe> Recipes;

        // Constructor without parameters
        public MainWindow()
        {
            InitializeComponent();
            Recipes = new List<Recipe>(); // Initialize an empty list if no recipes are passed
        }

        // Constructor with a list of recipes as a parameter
        public MainWindow(List<Recipe> recipes)
        {
            InitializeComponent();
            this.Recipes = recipes ?? new List<Recipe>(); // Use passed recipes or initialize an empty list
        }

        // Event handler for adding ingredients
        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve data from input fields
            string quantity = quanityTBox.Text;
            string ingredientName = ingredientsTBox.Text;
            string calories = caloriesTBox.Text;
            string foodGroup = (foodGroupCBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Check if any field is empty
            if (string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(ingredientName) || string.IsNullOrEmpty(calories) || string.IsNullOrEmpty(foodGroup))
            {
                MessageBox.Show("Please enter all ingredient details.");
                return;
            }

            // Create a new Ingredient object and add it to the list
            Ingredients.Add(new Ingredient(quantity, ingredientName, calories, foodGroup));

            // Update the list box displaying ingredients
            ingredientLBox.ItemsSource = null;
            ingredientLBox.ItemsSource = Ingredients;

            // Clear input fields after adding ingredient
            ingredientsTBox.Clear();
            quanityTBox.Clear();
            caloriesTBox.Clear();
            foodGroupCBox.SelectedIndex = -1;
        }

        // Event handler for adding cooking steps
        private void AddStep_Click(object sender, RoutedEventArgs e)
        {
            // Add the step to the list
            Steps.Add(stepTBox.Text);

            // Update the list box displaying steps
            stepLBox.ItemsSource = null;
            stepLBox.ItemsSource = Steps;

            // Clear input field after adding step
            stepTBox.Clear();
        }

        // Event handler for adding a recipe
        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve recipe name
            string recipeName = nameTBox.Text;
            if (string.IsNullOrEmpty(recipeName))
            {
                MessageBox.Show("Please enter a recipe name.");
                return;
            }

            // Calculate total calories from ingredients
            int totalCalories = Ingredients.Sum(ingredient => (int)Math.Round(double.Parse(ingredient.Calories)));

            // Create a new Recipe object and add it to the list
            Recipe newRecipe = new Recipe(recipeName, new List<Ingredient>(Ingredients), new List<string>(Steps))
            {
                TotalCalories = totalCalories
            };
            Recipes.Add(newRecipe);

            // Clear input fields after adding the recipe
            nameTBox.Clear();
            Ingredients.Clear();
            Steps.Clear();
            ingredientLBox.ItemsSource = null;
            stepLBox.ItemsSource = null;

            // Show success message
            MessageBox.Show("Recipe added successfully.");
        }

        // Event handler for viewing recipes
        private void ViewRecipes_Click(object sender, EventArgs e)
        {
            // Open a new window to display recipes
            RecipesWindow recipesWindow = new RecipesWindow(Recipes);
            recipesWindow.Show();
            this.Hide();
        }

        // Event handler for searching recipes
        private void Search_Click(object sender, EventArgs e)
        {
            // Open a new window for searching recipes
            SearchWindow searchWindow = new SearchWindow(Recipes);
            searchWindow.Show();
            this.Hide();
        }

        // Event handler for clearing all input fields
        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            // Clear all input fields and reset list boxes
            nameTBox.Clear();
            Ingredients.Clear();
            Steps.Clear();
            ingredientLBox.ItemsSource = null;
            stepLBox.ItemsSource = null;
        }

        // Event handler for exiting the application
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            // Shut down the application
            Application.Current.Shutdown();
        }
    }
}