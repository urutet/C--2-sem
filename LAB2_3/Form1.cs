using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace LAB2_3
{
    public partial class J : Form
    {
        List<Computer> computers = new List<Computer>();

        public J()
        {
            InitializeComponent();
        }

        private void RAMSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            RAMTrackBarLabel.Text = Convert.ToString(RAMSizeTrackBar.Value);
        }

        private void ProcessorAddButton_Click(object sender, EventArgs e)
        {
            ProcessorFillForm processorFillForm = new ProcessorFillForm();
            processorFillForm.form1Link = this;
            processorFillForm.Show();
        }

        private void VideocardAddButton_Click(object sender, EventArgs e)
        {
            VideocardFillForm videocardFillForm = new VideocardFillForm();
            videocardFillForm.form1Link = this;
            videocardFillForm.Show();
        }

        private void ComputerAddButton_Click(object sender, EventArgs e)
        {
            
                if (!DDR3Radio.Checked && !DDR4Radio.Checked)
                    RAMTypeError.SetError(this.RAMTypeGroupBox, "Выберите значение!");
                if ((HDDSizeTextBox.Text == "" ||
                    HDDSizeTextBox.Text == null) && HDDCheckBox.Checked)
                    HDDSizeError.SetError(this.HDDSizeTextBox, "Введите значение!");
                if ((SSDSizeTextBox.Text == "" ||
                    SSDSizeTextBox.Text == null) && SSDCheckBox.Checked)
                    SSDSizeError.SetError(this.SSDSizeTextBox, "Введите значение!");
                /*if (ComputerTypeBox.SelectedValue == null)
                    ComputerTypeError.SetError(this.ComputerTypeBox, "Заполните поле!");*/
                else
                {
                    Computer computer = new Computer();
                    computer.computerType = (Computer.ComputerType)Enum.Parse(typeof(Computer.ComputerType), ComputerTypeBox.SelectedItem.ToString());
                    computer.processor = (Processor)ProcessorComboBox.SelectedItem;
                    computer.videocard = (Videocard)VideocardComboBox.SelectedItem;

                    if (DDR3Radio.Checked)
                        computer.RAMType = "DDR3";
                    else
                        computer.RAMType = "DDR4";
                    computer.RAMSizeGB = RAMSizeTrackBar.Value;
                    if (HDDCheckBox.Checked)
                        computer.HDDdiskSizeGB = Convert.ToInt32(HDDSizeTextBox.Text);
                    if (SSDCheckBox.Checked)
                        computer.SSDdiskSizeGB = Convert.ToInt32(SSDSizeTextBox.Text);
                    computer.dateOfPurchase = DateOfPurchasePicker.Value;

                    computers.Add(computer);
                LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                    computer.processor.baseClock, computer.processor.numberOfCores,
                    computer.processor.l1_3CacheSize, computer.RAMType,
                    computer.RAMSizeGB, computer.videocard.ToString(),
                    computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                    computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.dateOfPurchase);
                    

                }
            

        }

        private void HDDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HDDCheckBox.Checked)
                HDDSizeTextBox.ReadOnly = false;
            else
                HDDSizeTextBox.ReadOnly = true;
        }

        private void SSDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SSDCheckBox.Checked)
                SSDSizeTextBox.ReadOnly = false;
            else
                SSDSizeTextBox.ReadOnly = true;
        }

        private void JSONSerializeButton_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw = new StreamWriter(@$"D:\BSTU\2 sem\ООП\LAB2_3\lab2_3.json", true))
                    {
                        foreach (var computer in computers)
                        {
                            string serialize = JsonConvert.SerializeObject(computer);
                            sw.Write(serialize);
                        }
                    }
        }
    }
}
