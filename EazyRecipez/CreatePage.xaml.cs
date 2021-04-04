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
using System.Threading;
using System.Threading.Tasks;

namespace EazyRecipez
{
    /// <summary>
    /// Interaction logic for CreatePage.xaml
    /// </summary>
    public partial class CreatePage : Page
    {
        public CreatePage()
        {
            InitializeComponent();
        }

        private void recipeName_MouseDown(object sender, RoutedEventArgs e)
        {
            if (recipeNameField.Text.Equals("Enter the recipe name"))
            {
                recipeNameField.Text = "";
            }

        }

        private void description_MouseDown(object sender, RoutedEventArgs e)
        {
            if (descriptionField.Text.Equals("Enter a description"))
            {
                descriptionField.Text = "";
            }

        }

        protected void ButtonGenerate_Click(object sender, RoutedEventArgs e)
        {
            var newTextBox = new TextBox();
            // here set new textbox parameters
            newTextBox.Name = "newInstruction1";
            newTextBox.Text = "Add another instruction";
            newTextBox.FontSize = 20;
            instructionPanel.Children.Add(newTextBox);
        }

        protected void ButtonIngredient_Click(object sender, RoutedEventArgs e)
        {
            var newTextBox = new TextBox();
            // here set new textbox parameters
            newTextBox.Name = "newIngredient";
            newTextBox.Text = "Add another ingredient";
            newTextBox.FontSize = 20;
            ingredientField.Children.Add(newTextBox);
            ingredientField.RegisterName(newTextBox.Name, newTextBox.Text);

        }



        private void ingredients_MouseDown(object sender, RoutedEventArgs e)
        {
            if (ingredientsField.Text.Equals("Enter an ingredient"))
            {
                ingredientsField.Text = "";
            }

        }

        private void title_LostFocus(object sender, RoutedEventArgs e)
        {
            if (recipeNameField.Text.Equals(""))
            {
                recipeNameField.Text = "Enter the recipe name";
            }

        }

        private void description_LostFocus(object sender, RoutedEventArgs e)
        {
            if (descriptionField.Text.Equals(""))
            {
                descriptionField.Text = "Enter a description";
            }

        }

        private void ingredients_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ingredientsField.Text.Equals(""))
            {
                ingredientsField.Text = "Enter an ingredient";
            }

        }

        private void instructions_LostFocus(object sender, RoutedEventArgs e)
        {
            if (instructionsField.Text.Equals(""))
            {
                instructionsField.Text = "Enter an instruction";
            }

        }

        private void instructions_MouseDown(object sender, RoutedEventArgs e)
        {
            if (instructionsField.Text.Equals("Enter an instruction"))
            {
                instructionsField.Text = "";
            }

        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new ProfilePage());
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new HomePage());
        }

        private void Image_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new ImageGallery());
        }

        private async void Offline_Click(object sender, RoutedEventArgs e)
        {
            if (Valid_Request(sender))
            {
                savedOffline.Visibility = Visibility.Visible;
                savedOfflineLabel.Visibility = Visibility.Visible;

                offlineButton.IsEnabled = false;
                onlineButton.IsEnabled = false;

                await Task.Delay(TimeSpan.FromSeconds(2));
                var mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow?.ChangeView(new OfflinePage());
            }


        }

        private async void Online_Click(object sender, RoutedEventArgs e)
        {

            if (Valid_Request(sender))
            {
                savedOnline.Visibility = Visibility.Visible;
                savedOnlineLabel.Visibility = Visibility.Visible;

                offlineButton.IsEnabled = false;
                onlineButton.IsEnabled = false;

                await Task.Delay(TimeSpan.FromSeconds(2));
                var mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow?.ChangeView(new OnlinePage());
            }

        }

        private bool Valid_Request(Object sender)
        {
            if (!recipeNameField.Text.Equals("Enter the recipe name") && !instructionsField.Text.Equals("Enter an instruction") && !ingredientsField.Text.Equals("Enter an ingredient")
                && !descriptionField.Text.Equals("Enter a description") && categoryCombo.SelectedIndex > -1 && Time_Chosen(sender))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Time_Chosen(Object sender)
        {
            if (hoursBox.SelectedIndex > -1 || minutesBox.SelectedIndex > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
