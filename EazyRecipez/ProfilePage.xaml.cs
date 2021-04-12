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
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
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

        private void BtnClickFav(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new FavoritesPage());
        }

        private void BtnClickRecipes(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new MyRecipesPage());
        }

        private void Buf_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new BufRecipePage());
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

            if(quotelist.ElementAt(22) == "Checked")
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
    }
}
