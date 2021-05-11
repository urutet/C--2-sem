using LAB10.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB10.ViewModels
{
    class AddItemVM
    {
        public Models.DBCommandsModel dBCommands { get; }

        public string Processor_Name { get; set; }
        public int Cores { get; set; }
        public int PClock_HZ { get; set; }
        public int L3_Cache { get; set; }

        public string RAM_Name { get; set; }
        public int RAM_Size { get; set; }
        public int Clock_HZ { get; set; }

        public string GPU_Name { get; set; }
        public int GRAM_Size { get; set; }

        public RelayCommand AddItemCommand { get; set; }

        public AddItemVM()
        {
            dBCommands = new Models.DBCommandsModel();

            AddItemCommand = new RelayCommand(obj =>
            {
                dBCommands.Insert(RAM_Name, Clock_HZ, RAM_Size, Processor_Name, Cores, PClock_HZ, L3_Cache, GPU_Name, GRAM_Size);
            });
        }
    }
}
