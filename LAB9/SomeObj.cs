using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace LAB9
{
    public class SomeObj : DependencyObject
    {


        public int Price
        {
            get { return (int)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Price.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PriceProperty;



        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty;

        static SomeObj()
        {

            FrameworkPropertyMetadata md = new FrameworkPropertyMetadata(10);
            md.CoerceValueCallback = new CoerceValueCallback(CorrectValue);

            PriceProperty =
                DependencyProperty.Register("Price", typeof(int), typeof(SomeObj), md, 
                new ValidateValueCallback(o => { if ((int)o > 0) { return true; } else { return false; } }));

            TitleProperty =
                DependencyProperty.Register("Title", typeof(string), typeof(SomeObj), new PropertyMetadata(""));
        }

        private static object CorrectValue(DependencyObject dObj, object baseValue)
        {
            int i;
            if ((int)baseValue > 100)
                return 100;
            else
                return baseValue;
        }

    }
}
