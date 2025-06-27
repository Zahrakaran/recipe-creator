using RecipeCreatorWPFApp.ViewModels;
using System.Windows;

namespace RecipeCreatorWPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}


