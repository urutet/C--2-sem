using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB2_3
{
    public partial class ProcessorFillForm : Form
    {
        public J form1Link;

        public ProcessorFillForm()
        {
            InitializeComponent();
        }

        private void ProcessorAddButton_Click(object sender, EventArgs e)
        {
            Processor processor = new Processor();
            int tryParse = 0;
            if (!IntelRadioButton.Checked && !AMDRadioButton.Checked)
            {
                ManufacturerError.SetError(this.ProcessorManufacturerGroup, "Выберите производителя");
            }
            if(SeriesTextBox.Text == "" ||
                SeriesTextBox.Text == null)
            {
                SeriesError.SetError(this.SeriesTextBox, "Заполните поле!");
            }
            if (ModelTextBox.Text == "" ||
                ModelTextBox.Text == null)
            {
                ModelError.SetError(this.ModelTextBox, "Заполните поле!");
            }
            if(BaseClockTextBox.Text == "" ||
                BaseClockTextBox.Text == null ||
                !Int32.TryParse(BaseClockTextBox.Text, out tryParse))
            {
                BaseClockError.SetError(this.BaseClockTextBox, "Заполните поле!");
            }
            if(MaxClockTextBox.Text == "" ||
                MaxClockTextBox.Text == null ||
                !Int32.TryParse(MaxClockTextBox.Text, out tryParse))
            {
                MaxClockError.SetError(this.MaxClockTextBox, "Заполните поле корректным значением!");
            }
            if (L1_L3CacheTextBox.Text == "" ||
                L1_L3CacheTextBox.Text == null ||
                !Int32.TryParse(L1_L3CacheTextBox.Text, out tryParse))
            {
                MaxClockError.SetError(this.MaxClockTextBox, "Заполните поле корректным значением!");
            }
            else
            {

                if(IntelRadioButton.Checked)
                    processor.manufacturer = (Processor.Manufacturer)Enum.Parse(typeof(Processor.Manufacturer), "Intel");
                else
                    processor.manufacturer = (Processor.Manufacturer)Enum.Parse(typeof(Processor.Manufacturer), "AMD");
                
                processor.Series = SeriesTextBox.Text;
                processor.Model = ModelTextBox.Text;
                processor.numberOfCores = ProcessorCoresTrackBar.Value;
                processor.baseClock = Convert.ToInt32(BaseClockTextBox.Text);
                processor.maxClock = Convert.ToInt32(MaxClockTextBox.Text);
                processor.l1_3CacheSize = Convert.ToInt32(L1_L3CacheTextBox.Text);

                if (x86RadioButton.Checked)
                    processor.architecture = (Processor.Architecture)Enum.Parse(typeof(Processor.Architecture), "x86");
                else
                    processor.architecture = (Processor.Architecture)Enum.Parse(typeof(Processor.Architecture), "x64");

                form1Link.ProcessorComboBox.Items.Add(processor);
                this.Close();
            }
        }

        private void ProcessorCoresTrackBar_Scroll(object sender, EventArgs e)
        {
            ProcessorCoresTrackBarLabel.Text = Convert.ToString(ProcessorCoresTrackBar.Value);
        }
    }
}
