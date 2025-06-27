using System.Collections.Generic;
using System.Windows;

namespace RecipeCreatorWPFApp
{
    public partial class StepWindow : Window
    {
        public List<string> Steps { get; private set; } = new List<string>();

        public StepWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var stepsText = txtStep.Text.Split(new[] { '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);
            Steps.AddRange(stepsText);

            this.DialogResult = true;
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
