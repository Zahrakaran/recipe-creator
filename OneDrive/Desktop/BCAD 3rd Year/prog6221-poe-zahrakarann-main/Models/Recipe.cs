
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RecipeCreatorWPFApp.Models
{
    // class to handle recipe-related operations
    public class Recipe
    {
        // property for recipe name
        public string RecipeName { get; }
        // list to store ingredients
        public List<Ingredient> Ingredients { get; }
        // list to store steps
        public List<string> Steps { get; }

        // constructor to initialize recipe
        public Recipe(string recipeName, List<Ingredient> ingredients, List<string> steps)
        {
            // set the recipe name
            RecipeName = recipeName;
            // set the ingredients
            Ingredients = ingredients;
            // set the steps
            Steps = steps;
        }

        // method to display the recipe
        public void DisplayRecipe()
        {
            // display the recipe title
            Console.WriteLine(RecipeBookConstants.RECIPE_TITLE);
            Console.WriteLine(RecipeName);

            // display the ingredients
            Console.WriteLine(RecipeBookConstants.INGREDIENTS_TITLE);
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            // display the steps
            Console.WriteLine(RecipeBookConstants.STEPS_TITLE);
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }

        // method to save the recipe to a file
        public void SaveRecipe(string filePath)
        {
            // create a stream writer to write the recipe to the specified file
            using StreamWriter writer = new StreamWriter(filePath);
            // write the recipe name
            writer.WriteLine(RecipeName);
            // write each ingredient
            foreach (var ingredient in Ingredients)
            {
                writer.WriteLine($"{ingredient.Quantity},{ingredient.Unit},{ingredient.Name},{ingredient.Calories},{ingredient.FoodGroup}");
            }
            // write each step
            foreach (var step in Steps)
            {
                writer.WriteLine(step);
            }
        }

        // method to scale ingredients
        public void ScaleIngredients(double factor)
        {
            // loop through each ingredient in the list
            foreach (var ingredient in Ingredients)
            {
                // try to parse the quantity of the ingredient from string to double
                if (double.TryParse(ingredient.Quantity, out double quantity))
                {
                    // if parsing is successful, scale the quantity by the factor provided
                    ingredient.Quantity = (quantity * factor).ToString();
                }
                else
                {
                    // if parsing fails, print an error message indicating the issue with parsing the quantity
                    Console.WriteLine($"Error parsing quantity for ingredient: {ingredient.Name}");
                }
            }
        }

        // method to reset ingredients
        public void ResetIngredients()
        {
            // clear the ingredients list
            Ingredients.Clear();
        }

        // method to calculate total calories
        public double CalculateTotalCalories()
        {
            // initialize total calories to 0
            double totalCalories = 0;
            // loop through each ingredient and sum up the calories
            foreach (var ingredient in Ingredients)
            {
                if (double.TryParse(ingredient.Calories, out double calories))
                {
                    totalCalories += calories;
                }
            }
            // return the total calories
            return totalCalories;
        }

        // method to get steps from user input
        public static List<string> GetSteps(int count)
        {
            // initialize a list to store steps
            List<string> steps = new List<string>();

            // loop to get step details from the user
            for (int i = 0; i < count; i++)
            {
                // get step description
                Console.Write($"{RecipeBookConstants.ENTER_STEP} {i + 1}: ");
                string step = Console.ReadLine() ?? "undefined step";
                // add the step to the list
                steps.Add(step);
            }

            // return the list of steps
            return steps;
        }
        // Recipe.cs
        public bool ContainsFoodGroup(string foodGroup)
        {
            // Logic to check if the recipe contains the specified food group
            // Example:
            return Ingredients.Any(i => i.FoodGroup == foodGroup);
        }

        public bool ContainsIngredient(string ingredientName)
        {
            // Logic to check if the recipe contains the specified ingredient
            // Example:
            return Ingredients.Any(i => i.Name.Equals(ingredientName, StringComparison.OrdinalIgnoreCase));
        }

    }
}



//Troelsen, A. & Japikse, P., 2022. Pro C# 10 with .NET 6 Foundational Principles and Practices in Programming. 11th ed. Chambersburg: Apress.