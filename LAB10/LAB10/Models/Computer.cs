using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace LAB10.Models
{
    public class Computer
    {
        public int Computer_ID { get; set; }
        public string Name { get; set; }
        public Processor processor { get; set; }
        public RAM ram { get; set; }
        public GPU gpu { get; set; }
        public ImageSource image { get; set; }
    }
}
