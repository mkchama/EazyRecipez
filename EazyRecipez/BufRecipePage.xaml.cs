using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for RecipePage.xaml
    /// </summary>
    public partial class BufRecipePage : Page
    {
        public BufRecipePage()
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

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new ProfilePage());
        }

        private void Instructions_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new InstructionsPage());
        }

        private void BackToPrevPage(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new HomePage());
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

        private void svPageRight(object sender, RoutedEventArgs e)
        {
            sv1.PageRight();
        }
        private void svPageLeft(object sender, RoutedEventArgs e)
        {
            sv1.PageLeft();
        }

        private void comment_MouseDown(object sender, RoutedEventArgs e)
        {
            if (commentsField.Text.Equals("Add a comment..."))
            {
                commentsField.Text = "";
            }

        }

        private void comment_LostFocus(object sender, RoutedEventArgs e)
        {
            if (commentsField.Text.Equals(""))
            {
                commentsField.Text = "Add a comment...";
            }

        }

        public static void Read_Fav()
        {

        }

        public void DoCheckboxStuff(bool check)
        {

        }

        private void HandleChecked(object sender, RoutedEventArgs e)
        {
            string name = "bufrecipe";
            string fileName = @"\recipes\" + name + ".txt";
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + fileName;

            System.IO.StreamReader file = new System.IO.StreamReader(dirParameter);

            List<string> quotelist = File.ReadAllLines(dirParameter).ToList();
            Console.Write(quotelist);
            quotelist.RemoveAt(22);
            file.Close();

            File.WriteAllLines(dirParameter, quotelist.ToArray());



            using (StreamWriter sw = File.AppendText(dirParameter))
            {
                sw.WriteLine("Checked");
            }



            ToggleButton toggle = sender as ToggleButton;
            string TextPath = "/Images/heart2.png";
            Uri resourceUri = new Uri(TextPath, UriKind.Relative);
            emp_heart.Source = new BitmapImage(resourceUri);
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            string name = "bufrecipe";
            string fileName = @"\recipes\" + name + ".txt";
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + fileName;

            System.IO.StreamReader file = new System.IO.StreamReader(dirParameter);

            List<string> quotelist = File.ReadAllLines(dirParameter).ToList();
            Console.Write(quotelist);
            quotelist.RemoveAt(22);
            file.Close();

            File.WriteAllLines(dirParameter, quotelist.ToArray());

            using (StreamWriter sw = File.AppendText(dirParameter))
            {
                sw.WriteLine("UnChecked");
            }

            ToggleButton toggle = sender as ToggleButton;
            string TextPath = "/Images/iheart.png";
            Uri resourceUri = new Uri(TextPath, UriKind.Relative);
            emp_heart.Source = new BitmapImage(resourceUri);

        }



        /*private void Change_Color(object sender, RoutedEventArgs e)
        {
    
            if(cb.isChecked == false)
            {
                heartPanel.Children.Remove(emp_heart);
                Image HeartImage = new Image();

                string TextPath = "/Images/redheart.png";
                Uri resourceUri = new Uri(TextPath, UriKind.Relative);


                HeartImage.Source = new BitmapImage(resourceUri);

                heartPanel.Children.Add(HeartImage);
     
            }
            else
            {
                heartPanel.Children.Add(emp_heart);
            }
            
        }*/

        private void View_Load(object sender, RoutedEventArgs e)
        {

            string name = "bufrecipe";
            string fileName = @"\recipes\" + name + ".txt";
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + fileName;



            System.IO.StreamReader file = new System.IO.StreamReader(dirParameter);

            recipeName.Text = file.ReadLine();
            subHeaderText.Text = file.ReadLine();
            string Category = file.ReadLine();
            categoryText.FontWeight = FontWeights.Bold;
            categoryText.Text = Category;
            string next;
            int ing = 1;
            while ((next = file.ReadLine()) != "Instructions")
            {
                if (ing == 1)
                {
                    ingredientsField.Text += "• " + next;

                }
                else
                {
                    ingredientsField.Text += "\n" + "• " + next;

                }
                ing++;

            }
            int ind = 1;
            while ((next = file.ReadLine()) != "endInstructions")
            {
                if (ind == 1)
                {
                    instructionField.Text += ind.ToString() + ". " + next;
                }
                else
                {
                    instructionField.Text += "\n" + ind.ToString() + ". " + next;

                }
                ind++;
            }
            timeText.FontWeight = FontWeights.Bold;
            timeText.Text = Get_Time(file);
            authorText.FontWeight = FontWeights.Bold;
            authorText.Text = file.ReadLine();




            if (file.ReadLine() == "Checked")
            {
                string TextPath = "/Images/heart2.png";
                Uri resourceUri = new Uri(TextPath, UriKind.Relative);
                emp_heart.Source = new BitmapImage(resourceUri);
            }
            else
            {
                ToggleButton toggle = sender as ToggleButton;
                string TextPath = "/Images/iheart.png";
                Uri resourceUri = new Uri(TextPath, UriKind.Relative);
                emp_heart.Source = new BitmapImage(resourceUri);
            }
            file.Close();

        }



        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {

                var mainWindow = (MainWindow)Application.Current.MainWindow;
                Image RecipeImage = new Image();
                var userNameLabel = new Label();
                var commentLabel = new Label();

                string TextPath = "/Images/icons8-user-50.png";
                Uri resourceUri = new Uri(TextPath, UriKind.Relative);


                RecipeImage.Source = new BitmapImage(resourceUri);
                RecipeImage.Width = 25;


                var RecipeList = new StackPanel();
                RecipeList.Orientation = Orientation.Horizontal;

                var ImagePan = new StackPanel();
                ImagePan.Orientation = Orientation.Horizontal;

                userNameLabel.Content = "TestUser:";
                userNameLabel.FontWeight = FontWeights.Bold;

                userNameLabel.FontSize = 18;

                var Divider = new Rectangle();
                Divider.HorizontalAlignment = HorizontalAlignment.Stretch;
                Divider.VerticalAlignment = VerticalAlignment.Center;
                Divider.Fill = System.Windows.Media.Brushes.LightGray;
                Divider.Height = 1;

                commentLabel.Content = commentsField.Text;

                commentLabel.FontSize = 15;

                RecipeList.Height = 50;



                RecipeList.Children.Add(RecipeImage);
                RecipeList.Children.Add(userNameLabel);
                RecipeList.Children.Add(commentLabel);


                commentPanel.Children.Add(RecipeList);
                commentPanel.Children.Add(Divider);
                commentsField.Clear();


            }
        }

        private string Get_Time(System.IO.StreamReader file)
        {
            string first = file.ReadLine();
            string second = file.ReadLine();
            if (first == "0")
            {
                return second + "min";
            }
            else
            {
                if (second == "0")
                {
                    return first + "h";
                }
                else
                {
                    return first + "h " + second + "min";
                }
            }

        }


    }
}
