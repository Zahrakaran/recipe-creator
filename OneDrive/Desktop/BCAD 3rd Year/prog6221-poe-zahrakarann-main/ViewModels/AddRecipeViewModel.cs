using RecipeCreatorWPFApp.Models;
using System.Collections.ObjectModel;

namespace RecipeCreatorWPFApp.ViewModels
{
    public class AddRecipeViewModel : BaseViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; }
        public Recipe NewRecipe { get; set; }

        public AddRecipeViewModel(ObservableCollection<Recipe> recipes)
        {
            Recipes = recipes;
        }

        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }
    }
}


