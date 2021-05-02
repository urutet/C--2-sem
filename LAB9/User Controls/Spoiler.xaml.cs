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

namespace LAB9.User_Controls
{
    /// <summary>
    /// Interaction logic for Spoiler.xaml
    /// </summary>
    public partial class Spoiler : UserControl
    {



        public object Object
        {
            get { return (object)GetValue(ObjectProperty); }
            set { SetValue(ObjectProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Object.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ObjectProperty =
            DependencyProperty.Register("Object", typeof(object), typeof(Spoiler), new PropertyMetadata("DEFAULT"));



        public Spoiler()
        {
            InitializeComponent();
        }

        private void Spoiler_Click(object sender, RoutedEventArgs e)
        {
            if (spoiler.Visibility == Visibility.Visible)
            {
                spoiler.Visibility = Visibility.Collapsed;
                content.Visibility = Visibility.Visible;
            }
        }

        private void collapse_Click(object sender, RoutedEventArgs e)
        {
            if (content.Visibility == Visibility.Visible)
            {
                spoiler.Visibility = Visibility.Visible;
                content.Visibility = Visibility.Collapsed;
            }
        }
    }
}
