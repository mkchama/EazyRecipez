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
using System.IO;

namespace EazyRecipez
{
    /// <summary>
    /// Interaction logic for EditRecipe.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        String content;
        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";
        public EditPage()
        {
            InitializeComponent();
        }

        

        private void BackToUserRecipe(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new UserRecipePage());
        }


        private void Cancel(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new UserRecipePage());
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            string writerfile = dirParameter;
            using (StreamWriter writer = new StreamWriter(writerfile))
            {
                writer.WriteLine(this.recipeNameField.Text);
                writer.WriteLine(this.descriptionField.Text);
                writer.WriteLine(this.ingredientsField.Text);
                writer.WriteLine(this.instructionsField.Text);
            }
        }

 
    }
}
