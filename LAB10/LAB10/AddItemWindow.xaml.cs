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
using System.Windows.Shapes;

namespace LAB10
{
    /// <summary>
    /// Interaction logic for AddItemWindow.xaml
    /// </summary>
    public partial class AddItemWindow : Window
    {
        MainWindow mw;

        public AddItemWindow()
        {
            InitializeComponent();
        }

        public AddItemWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            mw = mainWindow;
        }
    }
}
