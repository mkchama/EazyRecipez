﻿using System;
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

        public static Boolean recipeCreated = false;

        public AppetizerPage()
        {
            InitializeComponent();
            Loaded += AppetizerPage_Loaded;
        }
        void AppetizerPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (recipeCreated)
            {
                breadRecipe.Visibility = Visibility.Visible;
            } else
            {
                breadRecipe.Visibility = Visibility.Hidden;
            }
             

            if (searchBox.Text == "Search for appetizer recipes..." || searchBox.Text == "")
            {
                searchBox.Text = "Search for appetizer recipes...";
                clearButton.Opacity = 0;
            }
            else
            {//change the recipes
                string FilePath = AppDomain.CurrentDomain.BaseDirectory + @"/AppetizerRecipes.txt";
                using (StreamReader file = new StreamReader(FilePath))

                {
                    string line;
                    //ThePanel.Children.RemoveRange(0, ThePanel.Children.Count - 2);
                    ThePanel.Children.Clear();
                    while ((line = file.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        string[] contents = line.Split('&');

                        if (contents[0].ToLower().Contains(searchBox.Text.ToLower()))
                        {
                            var NewPanel = new StackPanel();
                            NewPanel.Orientation = Orientation.Horizontal;
                            ThePanel.Children.Add(NewPanel);


                            string TextPath = "/Images/" + contents[3];
                            Uri resourceUri = new Uri(TextPath, UriKind.Relative);
                            Image RecipeImage = new Image();
                            RecipeImage.Width = 85;
                            RecipeImage.Source = new BitmapImage(resourceUri);

                            NewPanel.Children.Add(RecipeImage);

                            var RecipeList = new StackPanel();

                            var NameLabel = new Label();
                            NameLabel.Content = contents[0];
                            NameLabel.FontSize = 17;
                            NameLabel.FontWeight = FontWeights.Bold;

                            var RatingLabel = new Label();
                            RatingLabel.Content = contents[1];
                            RatingLabel.FontSize = 15;
                            RatingLabel.FontWeight = FontWeights.Bold;

                            var TimeLabel = new Label();
                            TimeLabel.Content = contents[2];
                            var Divider = new Rectangle();
                            Divider.HorizontalAlignment = HorizontalAlignment.Stretch;
                            Divider.VerticalAlignment = VerticalAlignment.Center;
                            Divider.Fill = System.Windows.Media.Brushes.LightGray;
                            Divider.Height = 1;

                            RecipeList.Children.Add(Divider);
                            RecipeList.Children.Add(NameLabel);
                            RecipeList.Children.Add(RatingLabel);
                            RecipeList.Children.Add(TimeLabel);
                            

                            NewPanel.Children.Add(RecipeList);
                        }


                    }
                }
            }
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                var mainWindow = (MainWindow)Application.Current.MainWindow;
                AppetizerPage Appetizer_Page = new AppetizerPage();

                Appetizer_Page.searchBox.Text = searchBox.Text;

                mainWindow?.ChangeView(Appetizer_Page);
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
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            AppetizerPage Appetizer_Page = new AppetizerPage();

            mainWindow?.ChangeView(Appetizer_Page);

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

        private void Buf_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new BufRecipePage());
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
