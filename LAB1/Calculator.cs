using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    interface ICalculator
    {
        public string And(string str);
        public string Or(string str);
        public string Xor(string str);
        public string Not(string str);
        public string ShowInOctagonal(string str);
        public string ShowInBinary(string str);
        public string ShowInHexagonal(string str);
        public string ShowInDecimal(string str);
        public string Equal(string str);
        public string Clear();
    }

    class Calculator: ICalculator
    {
        public string And(string str)
        {
            str.Split('&');
            return Convert.ToString(Convert.ToInt32(str[0]) & Convert.ToInt32(str[1]));
        }

        public string Or(string str)
        {
            str.Split('|');
            return Convert.ToString(Convert.ToInt32(str[0]) | Convert.ToInt32(str[1]));
        }

        public string Xor(string str)
        {
            str.Split('^');
            return Convert.ToString(Convert.ToInt32(str[0]) ^ Convert.ToInt32(str[1]));
        }

        public string Not(string str)
        {
            return Convert.ToString(~Convert.ToInt32(str));
        }

        public string ShowInOctagonal(string str)
        {
            return Convert.ToString(Convert.ToInt32(str), 8);
        }

        public string ShowInBinary(string str)
        {
            return Convert.ToString(Convert.ToInt32(str), 2);
        }

        public string ShowInDecimal(string str)
        {
            return Convert.ToString(Convert.ToInt32(str), 10);
        }

        public string ShowInHexagonal(string str)
        {
            return Convert.ToString(Convert.ToInt32(str), 16);
        }

        public string Clear()
        {
            return "";
        }

        public string Equal(string str)
        {
            if (str.Contains('&'))
                return And(str);
            if (str.Contains('|'))
                return Or(str);
            if (str.Contains('^'))
                return Xor(str);
            else
                return str;
        }
    }
}
