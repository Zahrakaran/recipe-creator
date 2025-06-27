using RecipeCreatorWPFApp.Models;
using System.Windows;
using System.Windows.Controls;

namespace RecipeCreatorWPFApp
{
    public partial class IngredientWindow : Window
    {
        public Ingredient? Ingredient { get; private set; }

        public IngredientWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string quantity = txtQuantity.Text;
            string unit = txtUnit.Text;
            string calories = txtCalories.Text;
            string foodGroup = (cmbFoodGroup.SelectedItem as ComboBoxItem)?.Content.ToString() ?? "Unknown";

            if (long.TryParse(calories, out var parsedCalories))
            {
                Ingredient = new Ingredient(name, quantity, unit, parsedCalories.ToString(), foodGroup);
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for calories.");
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
