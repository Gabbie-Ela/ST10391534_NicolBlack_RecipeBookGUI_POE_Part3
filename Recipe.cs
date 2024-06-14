using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10391534_NicolBlack_RecipeBookGUI_POE_Part3
{
    public class Recipe
    {
        // Property to store the name of the recipe
        public string Name { get; set; }

        // Property to store the list of ingredients required for the recipe
        public List<Ingredient> Ingredients { get; set; }

        // Property to store the list of steps to prepare the recipe
        public List<string> Steps { get; set; }

        // Property to store the total calories of the recipe
        public int TotalCalories { get; set; }

        // Constructor to initialize a Recipe object with name, ingredients, and steps
        public Recipe(string name, List<Ingredient> ingredients, List<string> steps)
        {
            // Set the name of the recipe
            Name = name;
            // Set the list of ingredients required for the recipe
            Ingredients = ingredients;
            // Set the list of steps to prepare the recipe
            Steps = steps;
            // Calculate total calories based on the ingredients
            CalculateTotalCalories(); // Calculate total calories upon initialization
        }

        // Method to calculate the total calories of the recipe
        private void CalculateTotalCalories()
        {
            TotalCalories = 0;
            // Iterate through each ingredient in the recipe
            foreach (var ingredient in Ingredients)
            {
                // Assuming Calories property of Ingredient is a string, convert it to int for summing
                if (int.TryParse(ingredient.Calories, out int calories))
                {
                    // Add the calories of the current ingredient to the total calories of the recipe
                    TotalCalories += calories;
                }
            }
        }

        // Override ToString() method to provide a string representation of the Recipe object
        public override string ToString()
        {
            // Return a string with the name of the recipe and its total calories
            return $"{Name} - {TotalCalories} calories";
        }
    }
}
