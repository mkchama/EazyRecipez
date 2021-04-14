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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class FavoritesPage : Page
    {
        private MainWindow mainWindow;
        public FavoritesPage()
        {
            InitializeComponent();
            Loaded += HomePage_Loaded;
        }

        private void HomePage_Loaded(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "Search for recipes..." || searchBox.Text == "")
            {
                searchBox.Text = "Search for recipes...";
                clearButton.Opacity = 0;
            }
        

            else
            {
                string FilePath = AppDomain.CurrentDomain.BaseDirectory + @"/FavRecipes.txt";
                using (StreamReader file = new StreamReader(FilePath))

                {
                    string line;
                    //ThePanel.Children.RemoveRange(0, ThePanel.Children.Count - 2);
                    ThePanel.Children.Clear();
                    while ((line = file.ReadLine()) != null)
                    {
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


                            RecipeList.Children.Add(NameLabel);
                            RecipeList.Children.Add(RatingLabel);
                            RecipeList.Children.Add(TimeLabel);
                            RecipeList.Children.Add(Divider);

                            NewPanel.Children.Add(RecipeList);
                        }


                    }
                }
            }
        }

        private void View_Load(object sender, RoutedEventArgs e)
        {

            string name = "bufrecipe";
            string fileName = @"\recipes\" + name + ".txt";
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + fileName;

            System.IO.StreamReader file = new System.IO.StreamReader(dirParameter);

            var Name = new Label();
            var Rating = new Label();
            var Time = new Label();

            // here set new textbox parameters
            List<string> quotelist = File.ReadAllLines(dirParameter).ToList();
            Console.Write(quotelist);

            if (quotelist.ElementAt(22) == "Checked")
            {
                string TextPath = "/Images/APPE3-BUFFALOCHICKENDIP.jpg";
                Uri resourceUri = new Uri(TextPath, UriKind.Relative);
                recPic.Source = new BitmapImage(resourceUri);
                string recN = quotelist.ElementAt(0);
                string recR = "★★★★★ (86 Reviews)";
                string recT = "Est. " + quotelist.ElementAt(20);
                Name.Content = recN;
                Name.FontSize = 17;
                Name.FontWeight = FontWeights.Bold;

                Rating.Content = recR;
                Rating.FontSize = 15;
                Rating.FontWeight = FontWeights.Bold;
                Time.Content = recT + " min";
                var Divider = new Rectangle();
                Divider.HorizontalAlignment = HorizontalAlignment.Stretch;
                Divider.VerticalAlignment = VerticalAlignment.Center;
                Divider.Fill = System.Windows.Media.Brushes.LightGray;
                Divider.Height = 1;



                stackLabel.Children.Add(Name);
                stackLabel.Children.Add(Rating);
                stackLabel.Children.Add(Time);
                stackLabel.Children.Add(Divider);


            }
            file.Close();








        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                var mainWindow = (MainWindow)Application.Current.MainWindow;
           
            
                FavoritesPage Fav_Page = new FavoritesPage();

                Fav_Page.searchBox.Text = searchBox.Text;

                mainWindow?.ChangeView(Fav_Page);

            



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
            FavoritesPage Fav_Page = new FavoritesPage();

            mainWindow?.ChangeView(Fav_Page);
        }

        private void Buf_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new BufRecipePage());
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


        private void BackToProfile(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new ProfilePage());
        }

       
    }
}
