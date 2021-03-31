﻿using System;
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
using System.Windows.Controls.Primitives;

namespace EazyRecipez
{
    /// <summary>
    /// Interaction logic for UserRecipePage.xaml
    /// </summary>
    public partial class UserRecipePage : Page
    {
        public UserRecipePage()
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

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new EditPage());
        }

        private void BackToMyRecipes(object sender, MouseButtonEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new MyRecipesPage());
        }

        private void ListBoxScrollHandler(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
                ScrollBar.LineDownCommand.Execute(null, e.OriginalSource as IInputElement);
            if (e.Delta < 0)
                ScrollBar.LineUpCommand.Execute(null, e.OriginalSource as IInputElement);
            e.Handled = true;
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
    }
}
