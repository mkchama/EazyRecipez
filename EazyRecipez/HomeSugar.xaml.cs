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
using System.IO;

namespace EazyRecipez
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomeSugar : Page
    {



        public HomeSugar()
        {
            InitializeComponent();
            Loaded += HomeSugar_Loaded;
        }

        private void HomeSugar_Loaded(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "Search for recipes..." || searchBox.Text == "")
            {
                searchBox.Text = "Search for recipes...";
                clearButton.Opacity = 0;
            }
            
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                var mainWindow = (MainWindow)Application.Current.MainWindow;
                HomePage Home_Page = new HomePage();

                Home_Page.searchBox.Text = searchBox.Text;

                mainWindow?.ChangeView(Home_Page);
            }
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
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            HomePage Home_Page = new HomePage();

            mainWindow?.ChangeView(Home_Page);
        }




        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new ProfilePage());
        }

        private void Breakfast_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            BreakfastPage Breakfast_Page = new BreakfastPage();
            if (searchBox.Text != "Search for recipes...")
            {
                Breakfast_Page.searchBox.Text = searchBox.Text;
            }
            mainWindow?.ChangeView(Breakfast_Page);
        }

        private void Lunch_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            LunchPage Lunch_Page = new LunchPage();
            if (searchBox.Text != "Search for recipes...")
            {
                Lunch_Page.searchBox.Text = searchBox.Text;
            }
            mainWindow?.ChangeView(Lunch_Page);
        }

        private void Dinner_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            DinnerPage Dinner_Page = new DinnerPage();
            if (searchBox.Text != "Search for recipes...")
            {
                Dinner_Page.searchBox.Text = searchBox.Text;
            }
            mainWindow?.ChangeView(Dinner_Page);
        }

        private void Dessert_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            DessertPage Dessert_Page = new DessertPage();
            if (searchBox.Text != "Search for recipes...")
            {
                Dessert_Page.searchBox.Text = searchBox.Text;
            }
            mainWindow?.ChangeView(Dessert_Page);
        }

        private void Appetizer_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            AppetizerPage Appetizer_Page = new AppetizerPage();
            if (searchBox.Text != "Search for recipes...")
            {
                Appetizer_Page.searchBox.Text = searchBox.Text;
            }

            mainWindow?.ChangeView(Appetizer_Page);
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new CreatePage());
        }

        //The RecipePage, fluffy pancakes might need to be changed, it's used for being tested right now"
        private void Recipe_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new RecipePage());
        }



        private void DessertPage1_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new DessertRecipe1());
        }
        private void DessertPage2_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new DessertRecipe2());
        }

        private void DinnerPage1_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new DinnerRecipe1());
        }

        private void DinnerPage2_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new DinnerRecipe2());
        }

        private void AppetizerPage1_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new AppetizerRecipe1());
        }

        private void AppetizerPage2_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new AppetizerRecipe2());
        }



        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollViewer = (ScrollViewer)sender;
            if (e.Delta < 0)
            {
                scrollViewer.LineRight();
            }
            else
            {
                scrollViewer.LineLeft();
            }
            e.Handled = true;
        }


    }
}
