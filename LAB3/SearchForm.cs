using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB2_3
{
    public partial class SearchForm : Form
    {
        public ITLabForm form;
        List<Computer> computersSearched = new List<Computer>();
        public List<Computer> allComputers;

        public SearchForm()
        {
            InitializeComponent();
            ManufacturerComboBox.Enabled = false;
            ModelTextBox.Enabled = false;
        }

        private void ManufacturerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(!ManufacturerCheckBox.Checked)
            {
                ManufacturerComboBox.Enabled = false;
                ManufacturerComboBox.SelectedItem = null;
            }
            else
            {
                ManufacturerComboBox.Enabled = true;
            }
        }

        private void ModelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(!ModelCheckBox.Checked)
            {
                ModelTextBox.Enabled = false;
                ModelTextBox.Text = null;
            }
            else
            {
                ModelTextBox.Enabled = true;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(ManufacturerCheckBox.Checked && ModelCheckBox.Checked)
            {
                    computersSearched = Search.RangeSearch(allComputers, this);
                    foreach(var computer in computersSearched)
                    {
                        LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                            computer.processor.baseClock, computer.processor.numberOfCores,
                            computer.processor.l1_3CacheSize, computer.RAMType,
                            computer.RAMSizeGB, computer.videocard.ToString(),
                            computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                            computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.dateOfPurchase);
                    }
            }
            else if((ManufacturerCheckBox.Checked && !ModelCheckBox.Checked) || (!ManufacturerCheckBox.Checked && ModelCheckBox.Checked))
            {
                    computersSearched = Search.SearchByFullManufactAndModel(allComputers, this,
                        (Processor.Manufacturer)Enum.Parse(typeof(Processor.Manufacturer),
                        ManufacturerComboBox.SelectedItem.ToString()), ModelTextBox.Text);
                
                foreach (var computer in computersSearched)
                {
                    LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                        computer.processor.baseClock, computer.processor.numberOfCores,
                        computer.processor.l1_3CacheSize, computer.RAMType,
                        computer.RAMSizeGB, computer.videocard.ToString(),
                        computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                        computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.dateOfPurchase);
                }
            }
            else
            {
                MessageBox.Show("Отметьте чекбокс для поиска.");
            }
        }
    }
}
