using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2_3
{
    class Computer
    {
        public enum ComputerType
        {
            Сервер,
            Рабочая_Станция,
            Ноутбук,
            Нетбук
        }
        public ComputerType computerType { get; set; } 
        public Videocard videocard { get; set; }
        public int RAMSizeGB { get; set; }
        public string RAMType { get; set; }
        public int SSDdiskSizeGB { get; set; }
        public int HDDdiskSizeGB { get; set; }
        public DateTime dateOfPurchase { get; set; }
        public Processor processor { get; set; }
    }

    class Processor
    {
        public enum Manufacturer
        {
            Intel,
            AMD
        }
        public Manufacturer manufacturer { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public int numberOfCores { get; set; }
        public float baseClock { get; set; }
        public float maxClock { get; set; }
        public enum Architecture
        {
            x86,
            x64
        }

        public Architecture architecture { get; set; }
        public int l1_3CacheSize { get; set; }

        public override string ToString()
        {
            return $@"{manufacturer} {Series} {Model}";
        }

    }

    class Videocard
    {
        public enum Manufacturer
        {
            Intel,
            AMD,
            Nvidia
        }

        public Manufacturer manufacturer { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public string baseClock { get; set; }
        public bool DirectX11Support { get; set; }
        public int VRAMSizeGB { get; set; }

        public override string ToString()
        {
            return $@"{manufacturer} {Series} {Model}";
        }
    }
}
