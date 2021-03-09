using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB2_3
{
    public partial class AccessoriesForm : Form
    {
        public ITLabForm form;
        public AccessoriesForm()
        {
            InitializeComponent();
        }

        private void AddPCWithAccessoriesButton_Click(object sender, EventArgs e)
        {
            if(WebcamCheckBox.Checked
                && !FingerprintCheckBox.Checked
                && !SecondDisplayCheckBox.Checked)
            {
                Computer computer = new Computer();
                computer = new ComputerWithWebcam(computer);
                form.computers.Add(computer);
                form.LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                            computer.processor.baseClock, computer.processor.numberOfCores,
                            computer.processor.l1_3CacheSize, computer.RAMType,
                            computer.RAMSizeGB, computer.videocard.ToString(),
                            computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                            computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.accessories, computer.dateOfPurchase);
                this.Close();
            }
            if(!WebcamCheckBox.Checked
                && FingerprintCheckBox.Checked
                && !SecondDisplayCheckBox.Checked)
            {
                Computer computer = new Computer();
                computer = new ComputerWithFingerprint(computer);
                form.computers.Add(computer);
                form.LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                            computer.processor.baseClock, computer.processor.numberOfCores,
                            computer.processor.l1_3CacheSize, computer.RAMType,
                            computer.RAMSizeGB, computer.videocard.ToString(),
                            computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                            computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.accessories, computer.dateOfPurchase);
                this.Close();
            }
            if (!WebcamCheckBox.Checked
                && !FingerprintCheckBox.Checked
                && SecondDisplayCheckBox.Checked)
            {
                Computer computer = new Computer();
                computer = new ComputerWithSecondDisplay(computer);
                form.computers.Add(computer);
                form.LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                            computer.processor.baseClock, computer.processor.numberOfCores,
                            computer.processor.l1_3CacheSize, computer.RAMType,
                            computer.RAMSizeGB, computer.videocard.ToString(),
                            computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                            computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.accessories, computer.dateOfPurchase);
                this.Close();
            }
            if (WebcamCheckBox.Checked
                && FingerprintCheckBox.Checked
                && !SecondDisplayCheckBox.Checked)
            {
                Computer computer = new Computer();
                computer = new ComputerWithWebcam(computer);
                computer = new ComputerWithFingerprint(computer);
                form.computers.Add(computer);
                form.LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                            computer.processor.baseClock, computer.processor.numberOfCores,
                            computer.processor.l1_3CacheSize, computer.RAMType,
                            computer.RAMSizeGB, computer.videocard.ToString(),
                            computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                            computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.accessories, computer.dateOfPurchase);
                this.Close();
            }
            if (WebcamCheckBox.Checked
                && !FingerprintCheckBox.Checked
                && SecondDisplayCheckBox.Checked)
            {
                Computer computer = new Computer();
                computer = new ComputerWithWebcam(computer);
                computer = new ComputerWithSecondDisplay(computer);
                form.computers.Add(computer);
                form.LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                            computer.processor.baseClock, computer.processor.numberOfCores,
                            computer.processor.l1_3CacheSize, computer.RAMType,
                            computer.RAMSizeGB, computer.videocard.ToString(),
                            computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                            computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.accessories, computer.dateOfPurchase);
                this.Close();
            }
            if (!WebcamCheckBox.Checked
                && FingerprintCheckBox.Checked
                && SecondDisplayCheckBox.Checked)
            {
                Computer computer = new Computer();
                computer = new ComputerWithFingerprint(computer);
                computer = new ComputerWithSecondDisplay(computer);
                form.computers.Add(computer);
                form.LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                            computer.processor.baseClock, computer.processor.numberOfCores,
                            computer.processor.l1_3CacheSize, computer.RAMType,
                            computer.RAMSizeGB, computer.videocard.ToString(),
                            computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                            computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.accessories, computer.dateOfPurchase);
                this.Close();
            }
            if (WebcamCheckBox.Checked
                && !FingerprintCheckBox.Checked
                && SecondDisplayCheckBox.Checked)
            {
                Computer computer = new Computer();
                computer = new ComputerWithWebcam(computer);
                computer = new ComputerWithSecondDisplay(computer);
                form.computers.Add(computer);
                form.LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                            computer.processor.baseClock, computer.processor.numberOfCores,
                            computer.processor.l1_3CacheSize, computer.RAMType,
                            computer.RAMSizeGB, computer.videocard.ToString(),
                            computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                            computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.accessories, computer.dateOfPurchase);
                this.Close();
            }
            if (WebcamCheckBox.Checked
                && FingerprintCheckBox.Checked
                && SecondDisplayCheckBox.Checked)
            {
                Computer computer = new Computer();
                computer = new ComputerWithWebcam(computer);
                computer = new ComputerWithFingerprint(computer);
                computer = new ComputerWithSecondDisplay(computer);
                form.computers.Add(computer);
                form.LabGrid.Rows.Add(computer.computerType, computer.processor.ToString(),
                            computer.processor.baseClock, computer.processor.numberOfCores,
                            computer.processor.l1_3CacheSize, computer.RAMType,
                            computer.RAMSizeGB, computer.videocard.ToString(),
                            computer.videocard.VRAMSizeGB, computer.videocard.DirectX11Support,
                            computer.SSDdiskSizeGB, computer.HDDdiskSizeGB, computer.accessories, computer.dateOfPurchase);
                this.Close();
            }


        }
    }
}
