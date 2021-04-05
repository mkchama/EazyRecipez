using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for AppetizerPage.xaml
    /// </summary>
    public partial class AppetizerPage : Page
    {
        public AppetizerPage()
        {
            InitializeComponent();
            Loaded += AppetizerPage_Loaded;
        }
        void AppetizerPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "Search for appetizer recipes...")
            {
                clearButton.Opacity = 0;
            }
        }

        private void RecipeName_MouseDown(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text.Equals("Search for appetizer recipes..."))
            {
                searchBox.Text = "";
            }

        }
        private void RecipeName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text.Equals(""))
            {
                searchBox.Text = "Search for appetizer recipes...";
            }
            else
            {
                clearButton.Opacity = 100;
            }

        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            searchBox.Text = "Search for appetizer recipes...";
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

        private void Breakfast_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            BreakfastPage Breakfast_Page = new BreakfastPage();
            if (searchBox.Text != "Search for appetizer recipes...")
            {
                Breakfast_Page.searchBox.Text = searchBox.Text;
            }
            mainWindow?.ChangeView(Breakfast_Page);
        }

        private void Lunch_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            LunchPage Lunch_Page = new LunchPage();
            if (searchBox.Text != "Search for appetizer recipes...")
            {
                Lunch_Page.searchBox.Text = searchBox.Text;
            }
            mainWindow?.ChangeView(Lunch_Page);
        }

        private void Dinner_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            DinnerPage Dinner_Page = new DinnerPage();
            if (searchBox.Text != "Search for appetizer recipes...")
            {
                Dinner_Page.searchBox.Text = searchBox.Text;
            }

            mainWindow?.ChangeView(Dinner_Page);
        }

        private void Dessert_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            DessertPage Dessert_Page = new DessertPage();
            if (searchBox.Text != "Search for appetizer recipes...")
            {
                Dessert_Page.searchBox.Text = searchBox.Text;
            }

            mainWindow?.ChangeView(Dessert_Page);
        }

        private void Appetizer_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            HomePage Home_Page = new HomePage();
            if (searchBox.Text != "Search for appetizer recipes...")
            {
                Home_Page.searchBox.Text = searchBox.Text;
            }

            mainWindow?.ChangeView(Home_Page);
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
    }
}
