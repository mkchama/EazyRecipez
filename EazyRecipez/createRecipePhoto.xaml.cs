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
using System.IO;

namespace EazyRecipez
{
    /// <summary>
    /// Interaction logic for CreatePage.xaml
    /// </summary>
    public partial class createRecipePhoto : Page
    {


        private List<TextBox> ingredientsList = new List<TextBox>();
        private List<TextBox> instructionList = new List<TextBox>();


        public createRecipePhoto()
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
            int id = ingredientsList.Count;

            // here set new textbox parameters
            newTextBox.Name = "newInstruction" + id.ToString();
            newTextBox.Text = "";
            newTextBox.FontSize = 20;
            instructionPanel.Children.Add(newTextBox);
        }

        protected void ButtonIngredient_Click(object sender, RoutedEventArgs e)
        {
            var newTextBox = new TextBox();
            int id = ingredientsList.Count;

            // here set new textbox parameters
            newTextBox.Name = "newIngredient" + id.ToString();
            newTextBox.Text = "";
            newTextBox.FontSize = 20;
            ingredientsList.Add(newTextBox);
            ingredientField.Children.Add(newTextBox);

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

                Save_File(sender, false);

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

                Save_File(sender, true);

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

        private async void Save_File(Object sender, Boolean isOnline)
        {
            string fileName = @"\recipes\" + recipeNameField.Text + ".txt";
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;

            string category = categoryCombo.Text;
            string categoryPath = AppDomain.CurrentDomain.BaseDirectory + @"/" + category + "Recipes.txt";
            string onlinePath = AppDomain.CurrentDomain.BaseDirectory + @"/onlineRecipes.txt";
            string offlinePath = AppDomain.CurrentDomain.BaseDirectory + @"/offlineRecipes.txt";

            string min;
            string hour;

            if (hoursBox.SelectedIndex > -1)
            {
                hour = hoursBox.Text;
            }
            else
            {
                hour = "0";
            }
            if (minutesBox.SelectedIndex > -1)
            {
                min = minutesBox.Text;
            }
            else
            {
                min = "0";
            }


            string mainPhoto = "dessert1-sugarcreampie.jpg";
            string hourFormat;
            string minFormat;
            if (int.Parse(hour) > 1)
            {
                hourFormat = hour + " hours ";
            }
            else if ((int.Parse(hour) == 0))
            {
                hourFormat = "";
            }
            else
            {
                hourFormat = hour + " hour ";
            }
            if (int.Parse(min) == 0)
            {
                minFormat = "";
            }
            else
            {
                minFormat = min + " min";
            }
            string line = recipeNameField.Text + "&☆☆☆☆☆ (0 reviews)&" + hourFormat + minFormat + "&" + mainPhoto;
            using (FileStream fs = new FileStream(categoryPath, FileMode.Append, FileAccess.Write))
            using (StreamWriter csw = new StreamWriter(fs))
            {
                csw.WriteLine(line);
            }

            if (isOnline)
            {
                using (FileStream fs = new FileStream(onlinePath, FileMode.Append, FileAccess.Write))
                using (StreamWriter csw = new StreamWriter(fs))
                {
                    csw.WriteLine(line);
                }
            }
            else
            {
                using (FileStream fs = new FileStream(offlinePath, FileMode.Append, FileAccess.Write))
                using (StreamWriter csw = new StreamWriter(fs))
                {
                    csw.WriteLine(line);
                }
            }



            using (FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"/AllRecipes.txt", FileMode.Append, FileAccess.Write))
            using (StreamWriter csw = new StreamWriter(fs))
            {
                csw.WriteLine(line);
            }

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(recipeNameField.Text);
                sw.WriteLine(descriptionField.Text);
                sw.WriteLine(categoryCombo.Text);
                sw.WriteLine(ingredientsField.Text);
                foreach (var ingredient in ingredientsList)
                {
                    if (ingredient.Text != "")
                    {
                        sw.WriteLine(ingredient.Text);
                    }

                }
                sw.WriteLine("Instructions");
                sw.WriteLine(instructionsField.Text);
                foreach (var instruction in instructionList)
                {
                    if (instruction.Text != "")
                    {
                        sw.WriteLine(instruction.Text);
                    }

                }
                sw.WriteLine("endInstructions");
                sw.WriteLine(hour);
                sw.WriteLine(min);
                sw.WriteLine("Demo User");

            }

        }

    }
}
