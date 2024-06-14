using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10391534_NicolBlack_RecipeBookGUI_POE_Part3
{
    // Define a public class named Ingredient
    public class Ingredient
    {
        // Properties of the Ingredient class
        // These properties are used to store different attributes of an ingredient
        // Each property has a get and set accessor, allowing read and write access
        public string Quantity { get; set; }   // Quantity of the ingredient
        public string Name { get; set; }       // Name of the ingredient
        public string Calories { get; set; }   // Caloric value of the ingredient
        public string FoodGroup { get; set; }  // Food group to which the ingredient belongs

        // Constructor for the Ingredient class
        // Initializes an instance of Ingredient with provided values
        // Parameters:
        //   - quantity: Quantity of the ingredient
        //   - name: Name of the ingredient
        //   - calories: Caloric value of the ingredient
        //   - foodGroup: Food group to which the ingredient belongs
        public Ingredient(string quantity, string name, string calories, string foodGroup)
        {
            // Assign provided values to respective properties
            Quantity = quantity;
            Name = name;
            Calories = calories;
            FoodGroup = foodGroup;
        }

        // Override the ToString method of the Object class
        // This method provides a string representation of the Ingredient object
        // Returns:
        //   A string representing the ingredient in the format:
        //   "{Quantity} - {Name} ({Calories} calories, {FoodGroup})"
        public override string ToString()
        {
            // Compose and return the formatted string
            return $"{Quantity} - {Name} ({Calories} calories, {FoodGroup})";
        }
    }
}