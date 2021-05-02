using System;
using System.Collections.Generic;
using System.Text;

namespace LAB10.Models
{
    public class Processor
    {
        public int Processor_ID { get; set; }
        public string Name { get; set; }
        public int Cores { get; set; }
        public int Clock_Hz { get; set; }
        public int L3_Cache { get; set; }

        public Processor()
        {

        }

        public Processor(int processor_ID, string name, int cores, int clock_Hz, int l3_Cache)
        {
            Processor_ID = processor_ID;
            Name = name;
            Cores = cores;
            Clock_Hz = clock_Hz;
            L3_Cache = l3_Cache;
        }
    }
}
