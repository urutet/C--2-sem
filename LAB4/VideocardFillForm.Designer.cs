
namespace LAB2_3
{
    partial class VideocardFillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.SeriesLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.BaseClockLabel = new System.Windows.Forms.Label();
            this.DirectXSupportCheckBox = new System.Windows.Forms.CheckBox();
            this.VRAMSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.VRAMSizeLabel = new System.Windows.Forms.Label();
            this.VRAMSizeTrackBoxLabel = new System.Windows.Forms.Label();
            this.SeriesTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.BaseClockTextBox = new System.Windows.Forms.TextBox();
            this.AddVideocardButton = new System.Windows.Forms.Button();
            this.ManufacturerError = new System.Windows.Forms.ErrorProvider(this.components);
            this.SeriesError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ModelError = new System.Windows.Forms.ErrorProvider(this.components);
            this.BaseClockError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ManufacturerComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.VRAMSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturerError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeriesError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseClockError)).BeginInit();
            this.SuspendLayout();
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(23, 28);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(140, 25);
            this.ManufacturerLabel.TabIndex = 0;
            this.ManufacturerLabel.Text = "Производитель";
            // 
            // SeriesLabel
            // 
            this.SeriesLabel.AutoSize = true;
            this.SeriesLabel.Location = new System.Drawing.Point(23, 104);
            this.SeriesLabel.Name = "SeriesLabel";
            this.SeriesLabel.Size = new System.Drawing.Size(62, 25);
            this.SeriesLabel.TabIndex = 1;
            this.SeriesLabel.Text = "Серия";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(23, 174);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(76, 25);
            this.ModelLabel.TabIndex = 2;
            this.ModelLabel.Text = "Модель";
            // 
            // BaseClockLabel
            // 
            this.BaseClockLabel.AutoSize = true;
            this.BaseClockLabel.Location = new System.Drawing.Point(23, 239);
            this.BaseClockLabel.Name = "BaseClockLabel";
            this.BaseClockLabel.Size = new System.Drawing.Size(151, 25);
            this.BaseClockLabel.TabIndex = 3;
            this.BaseClockLabel.Text = "Тактовая частота";
            // 
            // DirectXSupportCheckBox
            // 
            this.DirectXSupportCheckBox.AutoSize = true;
            this.DirectXSupportCheckBox.Location = new System.Drawing.Point(23, 318);
            this.DirectXSupportCheckBox.Name = "DirectXSupportCheckBox";
            this.DirectXSupportCheckBox.Size = new System.Drawing.Size(220, 29);
            this.DirectXSupportCheckBox.TabIndex = 4;
            this.DirectXSupportCheckBox.Text = "Поддержка DirectX 11";
            this.DirectXSupportCheckBox.UseVisualStyleBackColor = true;
            // 
            // VRAMSizeTrackBar
            // 
            this.VRAMSizeTrackBar.Location = new System.Drawing.Point(23, 378);
            this.VRAMSizeTrackBar.Maximum = 16;
            this.VRAMSizeTrackBar.Minimum = 1;
            this.VRAMSizeTrackBar.Name = "VRAMSizeTrackBar";
            this.VRAMSizeTrackBar.Size = new System.Drawing.Size(156, 69);
            this.VRAMSizeTrackBar.TabIndex = 5;
            this.VRAMSizeTrackBar.Value = 1;
            this.VRAMSizeTrackBar.Scroll += new System.EventHandler(this.VRAMSizeTrackBar_Scroll);
            // 
            // VRAMSizeLabel
            // 
            this.VRAMSizeLabel.AutoSize = true;
            this.VRAMSizeLabel.Location = new System.Drawing.Point(23, 350);
            this.VRAMSizeLabel.Name = "VRAMSizeLabel";
            this.VRAMSizeLabel.Size = new System.Drawing.Size(209, 25);
            this.VRAMSizeLabel.TabIndex = 6;
            this.VRAMSizeLabel.Text = "Объем видеопамяти, Гб";
            // 
            // VRAMSizeTrackBoxLabel
            // 
            this.VRAMSizeTrackBoxLabel.AutoSize = true;
            this.VRAMSizeTrackBoxLabel.Location = new System.Drawing.Point(185, 391);
            this.VRAMSizeTrackBoxLabel.Name = "VRAMSizeTrackBoxLabel";
            this.VRAMSizeTrackBoxLabel.Size = new System.Drawing.Size(22, 25);
            this.VRAMSizeTrackBoxLabel.TabIndex = 7;
            this.VRAMSizeTrackBoxLabel.Text = "1";
            // 
            // SeriesTextBox
            // 
            this.SeriesTextBox.Location = new System.Drawing.Point(23, 132);
            this.SeriesTextBox.Name = "SeriesTextBox";
            this.SeriesTextBox.Size = new System.Drawing.Size(150, 31);
            this.SeriesTextBox.TabIndex = 9;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(23, 205);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(150, 31);
            this.ModelTextBox.TabIndex = 10;
            // 
            // BaseClockTextBox
            // 
            this.BaseClockTextBox.Location = new System.Drawing.Point(23, 267);
            this.BaseClockTextBox.Name = "BaseClockTextBox";
            this.BaseClockTextBox.Size = new System.Drawing.Size(150, 31);
            this.BaseClockTextBox.TabIndex = 11;
            // 
            // AddVideocardButton
            // 
            this.AddVideocardButton.Location = new System.Drawing.Point(154, 443);
            this.AddVideocardButton.Name = "AddVideocardButton";
            this.AddVideocardButton.Size = new System.Drawing.Size(112, 34);
            this.AddVideocardButton.TabIndex = 12;
            this.AddVideocardButton.Text = "Добавить";
            this.AddVideocardButton.UseVisualStyleBackColor = true;
            this.AddVideocardButton.Click += new System.EventHandler(this.AddVideocardButton_Click);
            // 
            // ManufacturerError
            // 
            this.ManufacturerError.ContainerControl = this;
            // 
            // SeriesError
            // 
            this.SeriesError.ContainerControl = this;
            // 
            // ModelError
            // 
            this.ModelError.ContainerControl = this;
            // 
            // BaseClockError
            // 
            this.BaseClockError.ContainerControl = this;
            // 
            // ManufacturerComboBox
            // 
            this.ManufacturerComboBox.FormattingEnabled = true;
            this.ManufacturerComboBox.Items.AddRange(new object[] {
            "Intel",
            "AMD",
            "Nvidia"});
            this.ManufacturerComboBox.Location = new System.Drawing.Point(23, 57);
            this.ManufacturerComboBox.Name = "ManufacturerComboBox";
            this.ManufacturerComboBox.Size = new System.Drawing.Size(150, 33);
            this.ManufacturerComboBox.TabIndex = 13;
            // 
            // VideocardFillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 500);
            this.Controls.Add(this.ManufacturerComboBox);
            this.Controls.Add(this.AddVideocardButton);
            this.Controls.Add(this.BaseClockTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.SeriesTextBox);
            this.Controls.Add(this.VRAMSizeTrackBoxLabel);
            this.Controls.Add(this.VRAMSizeLabel);
            this.Controls.Add(this.VRAMSizeTrackBar);
            this.Controls.Add(this.DirectXSupportCheckBox);
            this.Controls.Add(this.BaseClockLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.SeriesLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Name = "VideocardFillForm";
            this.Text = "Добавить Видеокарту";
            ((System.ComponentModel.ISupportInitialize)(this.VRAMSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturerError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeriesError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseClockError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label SeriesLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label BaseClockLabel;
        private System.Windows.Forms.CheckBox DirectXSupportCheckBox;
        private System.Windows.Forms.TrackBar VRAMSizeTrackBar;
        private System.Windows.Forms.Label VRAMSizeLabel;
        private System.Windows.Forms.Label VRAMSizeTrackBoxLabel;
        private System.Windows.Forms.TextBox SeriesTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox BaseClockTextBox;
        private System.Windows.Forms.Button AddVideocardButton;
        private System.Windows.Forms.ErrorProvider ManufacturerError;
        private System.Windows.Forms.ErrorProvider SeriesError;
        private System.Windows.Forms.ErrorProvider ModelError;
        private System.Windows.Forms.ErrorProvider BaseClockError;
        private System.Windows.Forms.ComboBox ManufacturerComboBox;
    }
}