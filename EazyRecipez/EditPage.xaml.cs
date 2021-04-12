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
    /// Interaction logic for EditRecipe.xaml
    /// </summary>
    public partial class EditPage : Page

    {
        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";
        public EditPage()
        {
            InitializeComponent();
        }

        private List<TextBox> ingredientsList = new List<TextBox>();
        private List<TextBox> instructionList = new List<TextBox>();


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

        private void View_Load(object sender, RoutedEventArgs e)
        {

            string name = "fluff";
            string fileName = @"\recipes\" + name + ".txt";
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + fileName;



            System.IO.StreamReader file = new System.IO.StreamReader(dirParameter);

            recipeNameField.Text = file.ReadLine();
            descriptionField.Text = file.ReadLine();
            categoryCombo.Text = file.ReadLine();

            string next;
            int ing = 1;
            while ((next = file.ReadLine()) != "Instructions")
            {
                var newTextBox = new TextBox();
                
                int id = ingredientsList.Count;

                // here set new textbox parameters
                
                if (ing == 1)
                {

                    ingredientsField.Text += next;

                }
                else
                {
                    newTextBox.Name = "ingredientsField";
          
                    newTextBox.Width = 270;
                    newTextBox.FontSize = 20;
                    newTextBox.TextWrapping = TextWrapping.Wrap;
                    newTextBox.Text += next;
      
                    ingredientField.Children.Add(newTextBox);

                }
                ing++;

            }
            int ind = 1;
            while ((next = file.ReadLine()) != "endInstructions")
            {
                var newInstructBox = new TextBox();
                if (ind == 1)
                {
                    instructionsField.Text +=  next;
                }
                else
                {
                    newInstructBox.Name = "instructionsField";

                    newInstructBox.Width = 270;
                    newInstructBox.FontSize = 20;
                    newInstructBox.TextWrapping = TextWrapping.Wrap;
                    newInstructBox.Text += next;

                    instructionPanel.Children.Add(newInstructBox);

                }
                ind++;
            }

            hoursBox.Text = file.ReadLine();
            minutesBox.Text = file.ReadLine();




            file.Close();

        }




    }
}
