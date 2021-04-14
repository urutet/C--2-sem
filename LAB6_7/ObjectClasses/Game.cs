using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace LAB6_7.ObjectClasses
{
    public class Game
    {
        public string Name { get; set; }
        public string ShortDef { get; set; }
        public string FullDef { get; set; }
        public double Price { get; set; }
        public ImageSource image { get; set; }

        public Game()
        { }

        public Game(string name, string shortdef, string fulldef, double price, ImageSource img = null)
        {
            Name = name;
            ShortDef = shortdef;
            FullDef = fulldef;
            Price = price;
            image = img;
        }
    }
}
