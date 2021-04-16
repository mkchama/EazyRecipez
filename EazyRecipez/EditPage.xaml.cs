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

/*        private void Save_Click(object sender, RoutedEventArgs e)
        {

            string writerfile = dirParameter;
            using (StreamWriter writer = new StreamWriter(writerfile))
            {
                writer.WriteLine(this.recipeNameField.Text);
                writer.WriteLine(this.descriptionField.Text);
                writer.WriteLine(this.ingredientsField.Text);
                writer.WriteLine(this.instructionsField.Text);
            }
        }*/

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

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\recipes\" + "testing.txt", string.Empty);
            string fileName = @"\recipes\" + "testing.txt";
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;

            

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
                minFormat = min;
            }
            string Title = recipeNameField.Text;
            string Description = descriptionField.Text;
            string Category = "Category: " + categoryCombo.Text;
            string Ingredients = "2 cups all purpose | plain flour \n1 / 4 cup granulated sugar or sweetener \n4 teaspoons baking powder \n1 / 4 teaspoon baking soda \n1 / 2 teaspoon salt \n1 3 / 4 cups milk, (440ml) \n1 / 4 cup butter, (60g | 2 oz)\n2 teaspoons pure vanilla extract\n1 large egg";
            string Instructions = "Instructions\nCombine together the flour, sugar (or sweetener), baking powder, baking soda and salt in a large-sized bowl. Make a well in the centre and add the milk, slightly cooled melted butter, vanilla and egg.\nUse a wire whisk to whisk the wet ingredients together first before slowly folding them into the dry ingredients.Mix together until smooth(there may be a couple of lumps but that's okay).\nSet the batter aside and allow to rest while heating up your pan or griddle.\nHeat a nonstick pan or griddle over low-medium heat and wipe over with a little butter to lightly grease pan. Pour ¼ cup of batter onto the pan and spread out gently into a round shape with the back of your ladle or measuring cup.\nWhen the underside is golden and bubbles begin to appear on the surface, flip with a spatula and cook until golden. Repeat with remaining batter.\nendInstructions";
            string hr = "0";
            string Minute = "Time: " + minFormat;
            string Author = "Author: Test User";
            string Fav = "UnChecked";
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            using (StreamWriter csw = new StreamWriter(fs))
            {
                csw.WriteLine(Title);
                csw.WriteLine(Description);
                csw.WriteLine(Category);
                csw.WriteLine(Ingredients);
                csw.WriteLine(Instructions);
                csw.WriteLine(hr);
                csw.WriteLine(Minute);
                csw.WriteLine(Author);
                csw.WriteLine(Fav);


            }

            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new UserRecipePage());

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
