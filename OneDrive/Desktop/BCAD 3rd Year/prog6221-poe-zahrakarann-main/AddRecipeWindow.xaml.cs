using RecipeCreatorWPFApp.Models;
using RecipeCreatorWPFApp.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace RecipeCreatorWPFApp
{
    public partial class AddRecipeWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<Ingredient> Ingredients { get; set; }
        public ObservableCollection<string> Steps { get; set; }

        public AddRecipeWindow()
        {
            InitializeComponent();
            Ingredients = new ObservableCollection<Ingredient>();
            Steps = new ObservableCollection<string>();
            DataContext = this;
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            var ingredientWindow = new IngredientWindow();
            if (ingredientWindow.ShowDialog() == true && ingredientWindow.Ingredient != null)
            {
                Ingredients.Add(ingredientWindow.Ingredient);
                UpdateTotalCalories();
            }
        }

        private void AddStep_Click(object sender, RoutedEventArgs e)
        {
            var stepWindow = new StepWindow();
            if (stepWindow.ShowDialog() == true)
            {
                foreach (var step in stepWindow.Steps)
                {
                    Steps.Add(step);
                }
            }
        }

        private void SaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = txtRecipeName.Text;
            if (string.IsNullOrEmpty(recipeName) || recipeName == "Recipe Name")
            {
                MessageBox.Show("Recipe name cannot be empty.");
                return;
            }

            var recipe = new Recipe(recipeName, new List<Ingredient>(Ingredients), new List<string>(Steps));

            if (DataContext is AddRecipeViewModel addRecipeViewModel)
            {
                addRecipeViewModel.AddRecipe(recipe);
                MessageBox.Show("Recipe saved successfully.");
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("An error occurred. Please try again.");
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtRecipeName.Text == "Recipe Name")
            {
                txtRecipeName.Text = "";
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRecipeName.Text))
            {
                txtRecipeName.Text = "Recipe Name";
            }
        }

        private void UpdateTotalCalories()
        {
            TotalCalories = Ingredients.Sum(i => long.TryParse(i.Calories, out var calories) ? calories : 0);
        }

        private long totalCalories;
        public long TotalCalories
        {
            get => totalCalories;
            set
            {
                totalCalories = value;
                OnPropertyChanged(nameof(TotalCalories));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

