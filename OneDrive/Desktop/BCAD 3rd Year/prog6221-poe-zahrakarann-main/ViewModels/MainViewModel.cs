using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using RecipeCreatorWPFApp.Models;

namespace RecipeCreatorWPFApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; set; }

        public ICommand AddNewRecipeCommand { get; }
        public ICommand ViewRecipesCommand { get; }

        public MainViewModel()
        {
            Recipes = new ObservableCollection<Recipe>();
            AddNewRecipeCommand = new RelayCommand(param => AddNewRecipe());
            ViewRecipesCommand = new RelayCommand(param => ViewRecipes());
        }

        public void AddNewRecipe()
        {
            var addRecipeWindow = new AddRecipeWindow
            {
                DataContext = new AddRecipeViewModel(Recipes)
            };
            addRecipeWindow.ShowDialog();
        }

        private void ViewRecipes()
        {
            var viewRecipesWindow = new ViewRecipesWindow(Recipes);
            viewRecipesWindow.ShowDialog();
        }
    }
}
