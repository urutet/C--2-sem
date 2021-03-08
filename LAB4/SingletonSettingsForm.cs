using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB2_3
{
    public partial class SingletonSettingsForm : Form
    {
        public ITLabForm form;
        public SingletonSettingsForm()
        {
            InitializeComponent();
        }

        private void BackGroundColorButton_Click(object sender, EventArgs e)
        {
            BackgroundColorDialog.ShowDialog();
            form.BackColor = BackgroundColorDialog.Color;
            FormSettingsSingleton.GetInstance().backColor = BackgroundColorDialog.Color;
            BackgroundColorLabel.Text = Convert.ToString(FormSettingsSingleton.GetInstance().backColor);
        }
    }
}
