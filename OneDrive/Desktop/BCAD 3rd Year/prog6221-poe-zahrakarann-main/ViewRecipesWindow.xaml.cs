using RecipeCreatorWPFApp.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RecipeCreatorWPFApp
{
    public partial class ViewRecipesWindow : Window
    {
        public ObservableCollection<Recipe> Recipes { get; set; }
        private ObservableCollection<Recipe> filteredRecipes;

        public ViewRecipesWindow(ObservableCollection<Recipe> recipes)
        {
            InitializeComponent();
            Recipes = recipes;
            lstRecipes.ItemsSource = Recipes;
            filteredRecipes = new ObservableCollection<Recipe>(Recipes);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FilterByMaxCalories_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(ShowInputDialog("Enter maximum calories:"), out int maxCalories))
            {
                filteredRecipes = new ObservableCollection<Recipe>(
                    Recipes.Where(r => r.CalculateTotalCalories() <= maxCalories));
                lstRecipes.ItemsSource = filteredRecipes;
            }
        }

        private void FilterByFoodGroup_Click(object sender, RoutedEventArgs e)
        {
            string selectedFoodGroup = (cmbFoodGroups.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (!string.IsNullOrEmpty(selectedFoodGroup))
            {
                filteredRecipes = new ObservableCollection<Recipe>(
                    Recipes.Where(r => r.ContainsFoodGroup(selectedFoodGroup)));
                lstRecipes.ItemsSource = filteredRecipes;
            }
        }

        private void FilterByIngredient_Click(object sender, RoutedEventArgs e)
        {
            string ingredientName = txtIngredient.Text.Trim();
            if (!string.IsNullOrEmpty(ingredientName))
            {
                filteredRecipes = new ObservableCollection<Recipe>(
                    Recipes.Where(r => r.ContainsIngredient(ingredientName)));
                lstRecipes.ItemsSource = filteredRecipes;
            }
        }

        private string ShowInputDialog(string prompt)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(prompt, "Input", "");
        }
    }
}
