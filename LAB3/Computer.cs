using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace LAB2_3
{
    public class Computer
    {
        public enum ComputerType
        {
            Сервер,
            Рабочая_Станция,
            Ноутбук,
            Нетбук
        }
        [Required(ErrorMessage = "Укажите тип ПК")]
        public ComputerType computerType { get; set; }

        public Videocard videocard { get; set; }

        [Required(ErrorMessage = "Укажите объем ОЗУ")]
        public int RAMSizeGB { get; set; }

        [Required(ErrorMessage = "Укажите тип ОЗУ"), RegularExpression("DDR[1-4]")]
        public string RAMType { get; set; }

        [Required(ErrorMessage = "Укажите объем SSD", AllowEmptyStrings = true)]
        public int SSDdiskSizeGB { get; set; }

        [Required(ErrorMessage = "Укажите объем HDD", AllowEmptyStrings = true)]
        public int HDDdiskSizeGB { get; set; }
        public DateTime dateOfPurchase { get; set; }

        [ProcessorValidation]
        public Processor processor { get; set; }

        
    }

    [ProcessorValidation]
    public class Processor
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

        [Required(ErrorMessage = "Укажите тактовую частоту процессора"), RegularExpression(@"\d{4}")]
        public float baseClock { get; set; }

        [Required(ErrorMessage = "Укажите максимальную тактовую частоту процессора"), RegularExpression(@"\d{4}")]
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

    public class Videocard
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

        [Required(ErrorMessage = "Укажите тактовую частоту процессора"), RegularExpression(@"\d{4}")]
        public string baseClock { get; set; }
        public bool DirectX11Support { get; set; }

        [Required(ErrorMessage = "Укажите объем ОЗУ")]
        public int VRAMSizeGB { get; set; }

        public override string ToString()
        {
            return $@"{manufacturer} {Series} {Model}";
        }
    }

    public static class Search
    {
        public static List<Computer> SearchByFullManufactAndModel(List<Computer> computers, SearchForm searchForm, Processor.Manufacturer manufacturer, string Model)
        {
            if (searchForm.ManufacturerCheckBox.Checked && searchForm.ModelCheckBox.Checked)
            {
                var SearchResult = computers.Where(el => el.processor.manufacturer == manufacturer &&
                el.processor.Model == Model).ToList();
                return SearchResult;
            }
            else if (searchForm.ManufacturerCheckBox.Checked && !searchForm.ModelCheckBox.Checked)
            {
                var SearchResult = computers.Where(el => el.processor.manufacturer == manufacturer).ToList();
                return SearchResult;
            }
            else if (!searchForm.ManufacturerCheckBox.Checked && searchForm.ModelCheckBox.Checked)
            {
                var SearchResult = computers.Where(el => el.processor.Model.Contains(Model)).ToList();
                return SearchResult;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static List<Computer> RangeSearch(List<Computer> computers, SearchForm searchForm)
        {
            List<Computer> computers1 = new List<Computer>();
            Regex AMDRegex = new Regex(@"Ryzen [3579]", RegexOptions.IgnoreCase);
            Regex IntelRegex = new Regex(@"Core i[3579]", RegexOptions.IgnoreCase);

            foreach (var computer in computers)
            {
                if (AMDRegex.IsMatch(searchForm.ModelTextBox.Text) && 
                    searchForm.ManufacturerComboBox.SelectedItem.ToString() == computer.processor.manufacturer.ToString())
                {
                    computers1.Add(computer);
                }
                else if(IntelRegex.IsMatch(searchForm.ModelTextBox.Text) &&
                    searchForm.ManufacturerComboBox.SelectedItem.ToString() == computer.processor.manufacturer.ToString())
                {
                    computers1.Add(computer);
                }
            }
            return computers1;
        }
    }
}
