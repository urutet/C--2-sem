﻿using System;
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
using System.ComponentModel.DataAnnotations;

namespace LAB2_3
{
    public partial class ITLabForm : Form
    {
        public List<Computer> computers = new List<Computer>();

        public ITLabForm()
        {
            InitializeComponent();
            DateTimer.Start();
            HDDSizeTextBox.Enabled = false;
            SSDSizeTextBox.Enabled = false;

            FormSettingsSingleton settings = FormSettingsSingleton.GetInstance();
            settings.backColor = this.BackColor;
            settings.font = this.Font;
            settings.fontSize = this.FontHeight;

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
            LastMoveLabel.Text = "Последнее действие: добавление процессора";

        }

        private void VideocardAddButton_Click(object sender, EventArgs e)
        {
            VideocardFillForm videocardFillForm = new VideocardFillForm();
            videocardFillForm.form1Link = this;
            videocardFillForm.Show();
            LastMoveLabel.Text = "Последнее действие: добавление видеокарты";

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
            if (ComputerTypeBox.SelectedItem == null)
                ComputerTypeError.SetError(this.ComputerTypeBox, "Заполните поле!");
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



            //Не лучший метод (стоило бы использовать TryValidateField())
            var results = new List<ValidationResult>();
            var context = new ValidationContext(computer);

            if (!Validator.TryValidateObject(computer, context, results, true))
            {
                using (StreamWriter sw = new StreamWriter("lab3.txt", true))
                {
                    foreach (var error in results)
                    {
                        sw.WriteLine(error);
                    }
                }
            }

            computers.Add(computer);
            try
            {
                    LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                            computer.processor.baseClock, computer.processor.numberOfCores,
                            computer.processor.l1_3CacheSize, computer.RAMType,
                            computer.RAMSizeGB, computer.videocard.ToString(),
                            computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                            computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.dateOfPurchase);
            }
            catch
            {
                MessageBox.Show("Заполните все поля!");
            }


        }
        LastMoveLabel.Text = "Последнее действие: добавление компьютера";
            ItemsCountLabel.Text = $"Количество объектов: {computers.Count}";


        }

        private void HDDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!HDDCheckBox.Checked)
            {
                HDDSizeTextBox.Enabled = false;
                HDDSizeTextBox.Clear();
            }
            else
                HDDSizeTextBox.Enabled = true;
        }

        private void SSDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!SSDCheckBox.Checked)
            {
                SSDSizeTextBox.Enabled = false;
                SSDSizeTextBox.Clear();
            }
            else
                SSDSizeTextBox.Enabled = true;
        }

        private void LoadFileItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D:\\BSTU\\2 sem\\ООП\\LAB2_3";
                openFileDialog.Filter = "json files (*.json)|*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    List<Computer> computersFromJson = new List<Computer>();
                    computersFromJson = SerializerClass.DeserializeJSON<List<Computer>>(filePath); //НЕВОЗМОЖНО ПРЕОБРАЗОВАТЬ В СПИСОК

                    computers = computers.Concat(computersFromJson).ToList();
                    foreach (var computer in computersFromJson)
                    {
                        LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                       computer.processor.baseClock, computer.processor.numberOfCores,
                       computer.processor.l1_3CacheSize, computer.RAMType,
                       computer.RAMSizeGB, computer.videocard.ToString(),
                       computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                       computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.dateOfPurchase);
                        foreach (var pcs in computers)
                        {
                            if(!computer.processor.Equals(pcs.processor))
                                ProcessorComboBox.Items.Add(computer.processor);
                            if(!computer.videocard.Equals(pcs.videocard))
                                VideocardComboBox.Items.Add(computer.videocard);
                        }
                    }
                }
            }
            LastMoveLabel.Text = "Последнее действие: загрузка таблицы";
            ItemsCountLabel.Text = $"Количество объектов: {computers.Count}";

        }

        private void SaveFileItem_Click(object sender, EventArgs e)
        {
            if (computers.Count == 0)
            {
                MessageBox.Show("Список компьютеров пуст!");
            }
            else
            {
                Stream SaveStream;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "D:\\BSTU\\2 sem\\ООП\\LAB2_3";

                saveFileDialog.Filter = "json files (*.json)|*.json";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SerializerClass.SerializeJSON<List<Computer>>(saveFileDialog.FileName, computers);
                }
            }
            LastMoveLabel.Text = "Последнее действие: сохранение таблицы";

        }

        private void AboutBoxMenu_Click(object sender, EventArgs e)
        {
            AboutBoxForm aboutBox = new AboutBoxForm();
            aboutBox.Show();
            LastMoveLabel.Text = "Последнее действие: о программе";

        }

        private void SearchMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.form = this;
            searchForm.allComputers = computers;
            searchForm.Show();
            LastMoveLabel.Text = "Последнее действие: поиск";
        }

        private void SortMenuItem_Click(object sender, EventArgs e)
        {
            LabGrid.Rows.Clear();
            var sortedPCs = computers.OrderByDescending(el => el.dateOfPurchase).
                ThenBy(el => el.processor.baseClock).
                ThenBy(el => el.RAMSizeGB);
            foreach(var computer in sortedPCs)
            {
                LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                      computer.processor.baseClock, computer.processor.numberOfCores,
                      computer.processor.l1_3CacheSize, computer.RAMType,
                      computer.RAMSizeGB, computer.videocard.ToString(),
                      computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                      computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.dateOfPurchase);
            }
            LastMoveLabel.Text = "Последнее действие: сортировка";

        }

        private void SearchToolBoxButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.form = this;
            searchForm.allComputers = computers;
            searchForm.Show();
            LastMoveLabel.Text = "Последнее действие: поиск";

        }

        private void SortToolBoxButton_Click(object sender, EventArgs e)
        {
            LabGrid.Rows.Clear();
            var sortedPCs = computers.OrderByDescending(el => el.dateOfPurchase).
                ThenBy(el => el.processor.baseClock).
                ThenBy(el => el.RAMSizeGB);
            foreach (var computer in sortedPCs)
            {
                LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                      computer.processor.baseClock, computer.processor.numberOfCores,
                      computer.processor.l1_3CacheSize, computer.RAMType,
                      computer.RAMSizeGB, computer.videocard.ToString(),
                      computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                      computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.dateOfPurchase);
            }
            LastMoveLabel.Text = "Последнее действие: сортировка";
        }

        private void ClearToolBoxButton_Click(object sender, EventArgs e)
        {
            computers.Clear();
            LabGrid.Rows.Clear();
            LastMoveLabel.Text = "Последнее действие: очистка";
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss");
        }

        private void IntelWithoutVideocard_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            IntelBuilder intelBuilder = new IntelBuilder();
            director.BuilderBase = intelBuilder;
            director.BuildWithoutVideocard();
            computers.Add(intelBuilder.GetComputer());
            LabGrid.Rows.Add(intelBuilder.GetComputer().computerType, intelBuilder.GetComputer().processor.ToString(),
                      intelBuilder.GetComputer().processor.baseClock, intelBuilder.GetComputer().processor.numberOfCores,
                      intelBuilder.GetComputer().processor.l1_3CacheSize, intelBuilder.GetComputer().RAMType,
                      intelBuilder.GetComputer().RAMSizeGB, "Empty",
                      "Empty", "Empty",
                      intelBuilder.GetComputer().SSDdiskSizeGB, intelBuilder.GetComputer().HDDdiskSizeGB, intelBuilder.GetComputer().dateOfPurchase);
            amdBuilder.AddObserver(director);
            amdBuilder.NotifyObservers();
            if (director.approval)
                MessageBox.Show("ПК создан верно!");
        }

        private void IntelWithVideocard_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            IntelBuilder intelBuilder = new IntelBuilder();
            director.BuilderBase = intelBuilder;
            director.BuildWithVideocard();
            computers.Add(intelBuilder.GetComputer());
            LabGrid.Rows.Add(intelBuilder.GetComputer().computerType, intelBuilder.GetComputer().processor.ToString(),
                      intelBuilder.GetComputer().processor.baseClock, intelBuilder.GetComputer().processor.numberOfCores,
                      intelBuilder.GetComputer().processor.l1_3CacheSize, intelBuilder.GetComputer().RAMType,
                      intelBuilder.GetComputer().RAMSizeGB, intelBuilder.GetComputer().videocard.ToString(),
                      intelBuilder.GetComputer().videocard.VRAMSizeGB, intelBuilder.GetComputer().videocard.DirectX11Support,
                      intelBuilder.GetComputer().SSDdiskSizeGB, intelBuilder.GetComputer().HDDdiskSizeGB, intelBuilder.GetComputer().dateOfPurchase);
            amdBuilder.AddObserver(director);
            amdBuilder.NotifyObservers();
            if (director.approval)
                MessageBox.Show("ПК создан верно!");
        }

        private void AMDWithoutVideocard_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            AMDBuilder amdBuilder = new AMDBuilder();
            director.BuilderBase = amdBuilder;
            director.BuildWithoutVideocard();
            computers.Add(amdBuilder.GetComputer());
            LabGrid.Rows.Add(amdBuilder.GetComputer().computerType, amdBuilder.GetComputer().processor.ToString(),
                      amdBuilder.GetComputer().processor.baseClock, amdBuilder.GetComputer().processor.numberOfCores,
                      amdBuilder.GetComputer().processor.l1_3CacheSize, amdBuilder.GetComputer().RAMType,
                      amdBuilder.GetComputer().RAMSizeGB, "Empty",
                      "Empty", "Empty",
                      amdBuilder.GetComputer().SSDdiskSizeGB, amdBuilder.GetComputer().HDDdiskSizeGB, amdBuilder.GetComputer().dateOfPurchase);
            amdBuilder.AddObserver(director);
            amdBuilder.NotifyObservers();
            if (director.approval)
                MessageBox.Show("ПК создан верно!");
        }

        private void AMDWithVideocard_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            AMDBuilder amdBuilder = new AMDBuilder();
            director.BuilderBase = amdBuilder;
            director.BuildWithVideocard();
            computers.Add(amdBuilder.GetComputer());
            LabGrid.Rows.Add(amdBuilder.GetComputer().computerType, amdBuilder.GetComputer().processor.ToString(),
                      amdBuilder.GetComputer().processor.baseClock, amdBuilder.GetComputer().processor.numberOfCores,
                      amdBuilder.GetComputer().processor.l1_3CacheSize, amdBuilder.GetComputer().RAMType,
                      amdBuilder.GetComputer().RAMSizeGB, amdBuilder.GetComputer().videocard.ToString(),
                      amdBuilder.GetComputer().videocard.VRAMSizeGB, amdBuilder.GetComputer().videocard.DirectX11Support,
                      amdBuilder.GetComputer().SSDdiskSizeGB, amdBuilder.GetComputer().HDDdiskSizeGB, amdBuilder.GetComputer().dateOfPurchase);
            amdBuilder.AddObserver(director);
            amdBuilder.NotifyObservers();
            if (director.approval)
                MessageBox.Show("ПК создан верно!");
        }

        private void SingletonSettings_Click(object sender, EventArgs e)
        {
            SingletonSettingsForm form = new SingletonSettingsForm();
            form.form = this;
            form.BackgroundColorLabel.Text = Convert.ToString(FormSettingsSingleton.GetInstance().backColor);
            form.FontLabel.Text = $@"Шрифт: {FormSettingsSingleton.GetInstance().font.Name}";
            form.FontSizeLabel.Text = $@"Размер шрифта: {Convert.ToString(FormSettingsSingleton.GetInstance().fontSize)}";
            form.Show();
        }

        private void DeepCopyButton_Click(object sender, EventArgs e)
        {
            Computer pc = computers[computers.Count-1].DeepCopy();
            LabGrid.Rows.Add(pc.computerType, pc.processor.ToString(),
                      pc.processor.baseClock, pc.processor.numberOfCores,
                      pc.processor.l1_3CacheSize, pc.RAMType,
                      pc.RAMSizeGB, pc.videocard.ToString(),
                      pc.videocard.VRAMSizeGB, pc.videocard.DirectX11Support,
                      pc.SSDdiskSizeGB, pc.HDDdiskSizeGB, pc.dateOfPurchase);
        }

        private void AccessoriesDecorator_Click(object sender, EventArgs e)
        {
            AccessoriesForm acessoriesForm = new AccessoriesForm();
            acessoriesForm.form = this;
            acessoriesForm.Show();
        }
    }
}
