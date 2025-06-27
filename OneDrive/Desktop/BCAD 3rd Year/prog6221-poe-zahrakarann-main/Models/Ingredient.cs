
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecipeCreatorWPFApp.Models
{
    // class to represent an ingredient
    public class Ingredient
    {
        // property for ingredient name
        public string Name { get; }
        // property for ingredient quantity
        public string Quantity { get; set; }
        // property for ingredient unit
        public string Unit { get; }
        // property for ingredient calories
        public string Calories { get; }
        // property for ingredient food group
        public string FoodGroup { get; }

        // constructor to initialize an ingredient
        public Ingredient(string name, string quantity, string unit, string calories, string foodGroup)
        {
            // set the ingredient name
            Name = name;
            // set the ingredient quantity
            Quantity = quantity;
            // set the ingredient unit
            Unit = unit;
            // set the ingredient calories
            Calories = calories;
            // set the ingredient food group
            FoodGroup = foodGroup;
        }

        // method to get ingredients from user input
        public static List<Ingredient> GetIngredients(int count)
        {
            // initialize a list to store ingredients
            List<Ingredient> ingredients = new List<Ingredient>();

            // loop to get ingredient details from the user
            for (int i = 0; i < count; i++)
            {
                // get ingredient name
                Console.Write($"{RecipeBookConstants.ENTER_INGREDIENT_NAME} {i + 1}: ");
                string name = Console.ReadLine() ?? "unknown";
                Console.WriteLine();

                // get ingredient quantity
                Console.Write($"{RecipeBookConstants.ENTER_INGREDIENT_QUANTITY} {i + 1}: ");
                string quantity = Console.ReadLine() ?? "0";
                Console.WriteLine();

                // get ingredient unit
                Console.Write($"{RecipeBookConstants.ENTER_INGREDIENT_UNIT} {i + 1}: ");
                string unit = Console.ReadLine() ?? "unit";
                Console.WriteLine();

                // get ingredient calories
                Console.Write($"{RecipeBookConstants.ENTER_INGREDIENT_CALORIES} {i + 1}: ");
                string calories = Console.ReadLine() ?? "0";
                Console.WriteLine();

                // get ingredient food group
                Console.Write($"{RecipeBookConstants.ENTER_INGREDIENT_FOOD_GROUP} {i + 1}: ");
                string foodGroup = Console.ReadLine() ?? "unknown";
                Console.WriteLine();

                // create a new ingredient and add to the list
                ingredients.Add(new Ingredient(name, quantity, unit, calories, foodGroup));
                Console.WriteLine();
            }

            // return the list of ingredients
            return ingredients;
        }
    }
}



//Troelsen, A. & Japikse, P., 2022. Pro C# 10 with .NET 6 Foundational Principles and Practices in Programming. 11th ed. Chambersburg: Apress.