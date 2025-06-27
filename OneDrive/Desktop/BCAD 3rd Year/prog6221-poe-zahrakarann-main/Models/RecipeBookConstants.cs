using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCreatorWPFApp.Models
{
    // constants used in the application
    public static class RecipeBookConstants
    {
        // welcome message
        public const string WELCOME_MESSAGE = "Greetings chef :) Welcome to the Recipe Creator App!";
        //dispaly menu options
        public const string MENU_OPTIONS = "Kindly, choose an option:\n1. Add a new recipe\n2. View previous recipes\nType 'exit' if you'd like to close the application.";
        // prompt to enter the number of ingredients
        public const string ENTER_INGREDIENT_COUNT = "Please enter the number of ingredients in your recipe: ";
        // prompt to enter ingredient name
        public const string ENTER_INGREDIENT_NAME = "Please enter the ingredient name for ingredient";
        // prompt to enter ingredient quantity
        public const string ENTER_INGREDIENT_QUANTITY = "Okay, now enter the value of the quantity for ingredient";
        // prompt to enter ingredient unit
        public const string ENTER_INGREDIENT_UNIT = "And now enter the quantity unit for ingredient";
        // prompt to enter ingredient calories
        public const string ENTER_INGREDIENT_CALORIES = "Please enter the number of calories for ingredient";
        // prompt to enter ingredient food group
        public const string ENTER_INGREDIENT_FOOD_GROUP = "Now, enter the food group for ingredient";
        // prompt to enter the number of steps
        public const string ENTER_STEP_COUNT = "How many steps does the recipe have? ";
        // prompt to enter a step
        public const string ENTER_STEP = "Describe the method for step";
        // title for displaying the recipe
        public const string RECIPE_TITLE = "\nHere's your recipe!";
        // title for displaying the ingredients
        public const string INGREDIENTS_TITLE = "\nIngredients:";
        // title for displaying the steps
        public const string STEPS_TITLE = "\nSteps:";
        // prompt to enter the recipe name
        public const string ENTER_RECIPE_NAME = "Please go ahead and enter the name of the recipe:";
        // prompt to save the recipe or not
        public const string SAVE_RECIPE_PROMPT = "Would you like to save this recipe to a file? (yes/no): ";
        // prompt to enter file path to save recipe to 
        public const string ENTER_FILE_PATH = "Please enter file path to save the recipe: ";
        // title for displaying successful recipe save
        public const string SAVE_SUCCESSFUL = "Woohoo! The recipe has been saved successfully.";
        // prompt to enter another recipe
        public const string ANOTHER_RECIPE_PROMPT = "Would you like to enter another recipe? (yes/no): ";
        // prompt to select a recipe to display
        public const string SELECT_RECIPE_PROMPT = "Do you want to select a recipe to display? (yes/no): ";
        // prompt to enter recipe number
        public const string ENTER_RECIPE_NUMBER = "Please enter the number of the recipe you want to display: ";
        // title for displaying invalid integer message
        public const string INVALID_INTEGER_MESSAGE = "Oops! Invalid input. Please enter a valid integer.";
        // title for displaying invalid double message
        public const string INVALID_DOUBLE_MESSAGE = "Uh-oh! Invalid input. Please enter a valid number.";
        // title for displaying quantities reset
        public const string QUANTITIES_RESET = "The quantities have been reset to their original values.";
        // title for displaying recipe was cleared
        public const string RECIPE_CLEARED = "The recipe has been cleared. Please go ahead and enter the new recipe details.";
        // title for displaying no recipes available
        public const string NO_RECIPES_MESSAGE = "No recipes available.";
        // title for displaying invalid selection
        public const string INVALID_SELECTION_MESSAGE = "Oopsie! That's an invalid selection there, chef.";
        // title for displaying total calories
        public const string TOTAL_CALORIES = "Total calories:";
        // warning for calories exceeding limit
        public const string CALORIE_WARNING = "Warning: This recipe exceeds 300 calories. *Bombastic side-eye*";
        // title for displaying invalid chice message
        public const string INVALID_CHOICE_MESSAGE = "Whoopsie! That's an invalid choice. Please select a valid option.";
    }
}
