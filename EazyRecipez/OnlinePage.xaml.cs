using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EazyRecipez
{
    /// <summary>
    /// Interaction logic for OnlinePage.xaml
    /// </summary>
    public partial class OnlinePage : Page
    {
        public OnlinePage()
        {
            InitializeComponent();
        }


        private void RecipeName_MouseDown(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text.Equals("Search for recipes..."))
            {
                searchBox.Text = "";
            }

        }
        private void RecipeName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text.Equals(""))
            {
                searchBox.Text = "Search for recipes...";
            }
            else
            {
                clearButton.Opacity = 100;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            searchBox.Text = "Search for recipes...";
            clearButton.Opacity = 0;


        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new HomePage());
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new CreatePage());
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new ProfilePage());
        }


        private void BackToMyRecipes(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new MyRecipesPage());
        }

        private void Pancake_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new UserRecipePage());
        }
        private void DinnerPage1_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new DinnerRecipe1());
        }

        private void AppetizerPage1_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new AppetizerRecipe1());
        }

    }


}
