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
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Windows.Input;
using System.IO;
using Microsoft.Win32;

namespace LAB6_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ObjectClasses.Game> games { get; set; }
        public ObservableCollection<ObjectClasses.Game> gamesMemento { get; set; }
        public CatalogPage catalog { get; }
        public AddItemPage addItemPage { get; }
        public SettingsPage settingsPage { get; }
        public static RoutedCommand serializeCommand { get; } = new RoutedCommand();
        public static RoutedCommand deserializeCommand { get; } = new RoutedCommand();

        public MainWindow()
        {
            InitializeComponent();
            games = new ObservableCollection<ObjectClasses.Game>();
            catalog = new CatalogPage(this);
            addItemPage = new AddItemPage(this);
            settingsPage = new SettingsPage(this);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef = this;
            this.ParentFrame.Navigate(catalog);
            Mouse.OverrideCursor = ((FrameworkElement)this.Resources["ArrowCursor"]).Cursor;
        }

        private void catalog_button_Click(object sender, RoutedEventArgs e)
        {
            this.ParentFrame.Navigate(catalog);
        }

        private void add_item_button_Click(object sender, RoutedEventArgs e)
        {
            this.ParentFrame.Navigate(addItemPage);
        }

        private void settings_button_Click(object sender, RoutedEventArgs e)
        {
            this.ParentFrame.Navigate(settingsPage);
        }

        private void SerializeCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            ObservableCollection<ObjectClasses.Game> games = e.Parameter as ObservableCollection<ObjectClasses.Game>;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                string filepath = saveFileDialog.FileName;
                using (StreamWriter sw = new StreamWriter(filepath, true))
                {
                    string serialize = JsonConvert.SerializeObject(this.games, Formatting.Indented);
                    sw.Write(serialize);

                    sw.Close();
                }
            }
        }

        private void SerializeCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DeserializeCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            ObservableCollection<ObjectClasses.Game> games = new ObservableCollection<ObjectClasses.Game>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string filepath = openFileDialog.FileName;
                using (StreamReader sw = new StreamReader(filepath))
                {
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    games = (ObservableCollection<ObjectClasses.Game>)jsonSerializer.Deserialize(sw, typeof(ObservableCollection<ObjectClasses.Game>));
                    foreach(var game in games)
                    {
                        this.games.Add(game);
                    }
                    sw.Close();
                }
            }
        }

        private void DeserializeCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void undoBtn_Click(object sender, RoutedEventArgs e)
        {
            catalog.GamesControl.ItemsSource = gamesMemento;
            var view = CollectionViewSource.GetDefaultView(gamesMemento);
            view.Refresh();
        }

        private void redoBtn_Click(object sender, RoutedEventArgs e)
        {
            catalog.GamesControl.ItemsSource = games;
            var view = CollectionViewSource.GetDefaultView(games);
            view.Refresh();
        }
    }
}
