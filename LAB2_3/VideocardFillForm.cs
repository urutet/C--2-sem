using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB2_3
{
    public partial class VideocardFillForm : Form
    {
        public J form1Link;

        public VideocardFillForm()
        {
            InitializeComponent();
        }

        private void VRAMSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            VRAMSizeTrackBoxLabel.Text = Convert.ToString(VRAMSizeTrackBar.Value);
        }

        private void AddVideocardButton_Click(object sender, EventArgs e)
        {
            if(ManufacturerComboBox.Text == "" ||
                ManufacturerComboBox.Text == null)
            {
                ManufacturerError.SetError(this.ManufacturerComboBox, "Заполните поле!");
                
            }
            if(SeriesTextBox.Text == "" ||
                SeriesTextBox.Text == null)
            {
                SeriesError.SetError(this.SeriesTextBox, "Заполните поле!");
                
            }
            if(ModelTextBox.Text == "" ||
                ModelTextBox.Text == null)
            {
                ModelError.SetError(this.ModelTextBox, "Заполните поле!");
                
            }
            if(BaseClockTextBox.Text == "" ||
                BaseClockTextBox.Text == null)
            {
                BaseClockError.SetError(this.BaseClockTextBox, "Заполните поле!");
            }
            else
            {
                Videocard videocard= new Videocard();
                videocard.manufacturer = (Videocard.Manufacturer)Enum.Parse(typeof(Videocard.Manufacturer), ManufacturerComboBox.SelectedItem.ToString());
                videocard.Series = SeriesTextBox.Text;
                videocard.Model = ModelTextBox.Text;
                videocard.baseClock = BaseClockTextBox.Text;
                videocard.DirectX11Support = DirectXSupportCheckBox.Checked;
                videocard.VRAMSizeGB = VRAMSizeTrackBar.Value;
                form1Link.VideocardComboBox.Items.Add(videocard);
                this.Close();
            }
        }
    }
}
