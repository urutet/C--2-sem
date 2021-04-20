using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB6_7
{
    /// <summary>
    /// Interaction logic for CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        public MainWindow mainWindow { get; }
        public CatalogPage()
        {
            InitializeComponent();
        }

        public CatalogPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
            GamesControl.ItemsSource = mainWindow.games;
        }

        private void ItemSample_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ObjectClasses.Game g = (ObjectClasses.Game)GamesControl.SelectedItem;
            MessageBox.Show(g.FullDef);
        }

        private void delete_button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var game = button.DataContext as ObjectClasses.Game;
                mainWindow.gamesMemento = mainWindow.games;
                mainWindow.games.Remove(game);

            }
            else { return; }
        }
    }
}