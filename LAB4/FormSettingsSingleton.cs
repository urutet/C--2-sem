using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace LAB2_3
{
    class FormSettingsSingleton
    {
        public Color backColor {get; set; }
        public Font font { get; set; }
        public int fontSize { get; set; }

        private static readonly Lazy<FormSettingsSingleton> Lazy =
            new Lazy<FormSettingsSingleton>(() => new FormSettingsSingleton());

        private FormSettingsSingleton()
        {
        }

        public static FormSettingsSingleton GetInstance() => Lazy.Value;


    }
}
