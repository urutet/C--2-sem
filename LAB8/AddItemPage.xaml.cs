using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace LAB6_7
{
    /// <summary>
    /// Interaction logic for AddItemPage.xaml
    /// </summary>
    public partial class AddItemPage : Page
    {
        public MainWindow mainWindow { get; }
        public ImageSource image { get; set; }
        public AddItemPage()
        {
            InitializeComponent();
        }

        public AddItemPage(MainWindow window)
        {
            InitializeComponent();
            mainWindow = window;
        }

        private void add_game_button_Click(object sender, RoutedEventArgs e)
        {
            TextRange shrtDef = new TextRange(Game_shortDef_textbox.Document.ContentStart, Game_shortDef_textbox.Document.ContentEnd);
            TextRange fullDef = new TextRange(Game_fullDef_textbox.Document.ContentStart, Game_fullDef_textbox.Document.ContentEnd);

            //Object constructor
            ObjectClasses.Game game = new ObjectClasses.Game(Game_name_textbox.Text, shrtDef.Text,
                fullDef.Text, Convert.ToDouble(Game_price_textbox.Text), image);
            
            mainWindow.gamesMemento = mainWindow.games;
            mainWindow.games.Add(game);

            ClearAllFields();

            this.NavigationService.Navigate(mainWindow.catalog);
        }

        //add image btn
        private void add_image_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg; *.jpg)|*.png;*.jpeg; *.jpg| All files (*.*)|*.*";
            openFileDialog.InitialDirectory = "D:\\Music\\Chunk! No, Captain Chunk!\\2013 - Pardon My French\\";
            if (openFileDialog.ShowDialog() == true)
            {
                image = new BitmapImage(new Uri(openFileDialog.FileName));
                add_item_image.Source = image;
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        //check input for not int
        private void Game_price_textbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int i);
        }

        private void CustomControl1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You've just triggered hidden custom control!");

            //C# animation (still fails)
            ColorAnimation animation;
            animation = new ColorAnimation();
            animation.From = Colors.Orange;
            animation.To = Colors.Gray;
            animation.Duration = new Duration(TimeSpan.FromSeconds(5));
            this.customBtn.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
        }

        private void ClearAllFields()
        {
            Game_name_textbox.Clear();
            Game_fullDef_textbox.Document.Blocks.Clear();
            Game_shortDef_textbox.Document.Blocks.Clear();
            Game_price_textbox.Clear();
            add_item_image.Source = null;

        }
    }
}
