
namespace LAB2_3
{
    partial class ProcessorFillForm
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
            this.ProcessorManufacturerGroup = new System.Windows.Forms.GroupBox();
            this.AMDRadioButton = new System.Windows.Forms.RadioButton();
            this.IntelRadioButton = new System.Windows.Forms.RadioButton();
            this.ProcessorSeriesLabel = new System.Windows.Forms.Label();
            this.SeriesTextBox = new System.Windows.Forms.TextBox();
            this.ProcessorModelLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ProcessorCoresTrackBar = new System.Windows.Forms.TrackBar();
            this.ProcessorCoresTrackBarLabel = new System.Windows.Forms.Label();
            this.ProcessorCoresLabel = new System.Windows.Forms.Label();
            this.BaseClockLabel = new System.Windows.Forms.Label();
            this.MaxClockLabel = new System.Windows.Forms.Label();
            this.BaseClockTextBox = new System.Windows.Forms.TextBox();
            this.MaxClockTextBox = new System.Windows.Forms.TextBox();
            this.ProcessorAddButton = new System.Windows.Forms.Button();
            this.ArchitectureGroupBox = new System.Windows.Forms.GroupBox();
            this.x64RadioButton = new System.Windows.Forms.RadioButton();
            this.x86RadioButton = new System.Windows.Forms.RadioButton();
            this.L1_3CacheLabel = new System.Windows.Forms.Label();
            this.L1_L3CacheTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerError = new System.Windows.Forms.ErrorProvider(this.components);
            this.SeriesError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ModelError = new System.Windows.Forms.ErrorProvider(this.components);
            this.BaseClockError = new System.Windows.Forms.ErrorProvider(this.components);
            this.MaxClockError = new System.Windows.Forms.ErrorProvider(this.components);
            this.L1_L3CacheError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProcessorManufacturerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessorCoresTrackBar)).BeginInit();
            this.ArchitectureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturerError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeriesError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseClockError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxClockError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1_L3CacheError)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessorManufacturerGroup
            // 
            this.ProcessorManufacturerGroup.Controls.Add(this.AMDRadioButton);
            this.ProcessorManufacturerGroup.Controls.Add(this.IntelRadioButton);
            this.ProcessorManufacturerGroup.Location = new System.Drawing.Point(13, 13);
            this.ProcessorManufacturerGroup.Name = "ProcessorManufacturerGroup";
            this.ProcessorManufacturerGroup.Size = new System.Drawing.Size(166, 120);
            this.ProcessorManufacturerGroup.TabIndex = 0;
            this.ProcessorManufacturerGroup.TabStop = false;
            this.ProcessorManufacturerGroup.Text = "Производитель";
            // 
            // AMDRadioButton
            // 
            this.AMDRadioButton.AutoSize = true;
            this.AMDRadioButton.Location = new System.Drawing.Point(7, 67);
            this.AMDRadioButton.Name = "AMDRadioButton";
            this.AMDRadioButton.Size = new System.Drawing.Size(78, 29);
            this.AMDRadioButton.TabIndex = 1;
            this.AMDRadioButton.TabStop = true;
            this.AMDRadioButton.Text = "AMD";
            this.AMDRadioButton.UseVisualStyleBackColor = true;
            // 
            // IntelRadioButton
            // 
            this.IntelRadioButton.AutoSize = true;
            this.IntelRadioButton.Location = new System.Drawing.Point(7, 31);
            this.IntelRadioButton.Name = "IntelRadioButton";
            this.IntelRadioButton.Size = new System.Drawing.Size(71, 29);
            this.IntelRadioButton.TabIndex = 0;
            this.IntelRadioButton.TabStop = true;
            this.IntelRadioButton.Text = "Intel";
            this.IntelRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProcessorSeriesLabel
            // 
            this.ProcessorSeriesLabel.AutoSize = true;
            this.ProcessorSeriesLabel.Location = new System.Drawing.Point(20, 154);
            this.ProcessorSeriesLabel.Name = "ProcessorSeriesLabel";
            this.ProcessorSeriesLabel.Size = new System.Drawing.Size(166, 25);
            this.ProcessorSeriesLabel.TabIndex = 1;
            this.ProcessorSeriesLabel.Text = "Серия процессора";
            // 
            // SeriesTextBox
            // 
            this.SeriesTextBox.Location = new System.Drawing.Point(13, 194);
            this.SeriesTextBox.Name = "SeriesTextBox";
            this.SeriesTextBox.Size = new System.Drawing.Size(166, 31);
            this.SeriesTextBox.TabIndex = 2;
            // 
            // ProcessorModelLabel
            // 
            this.ProcessorModelLabel.AutoSize = true;
            this.ProcessorModelLabel.Location = new System.Drawing.Point(13, 248);
            this.ProcessorModelLabel.Name = "ProcessorModelLabel";
            this.ProcessorModelLabel.Size = new System.Drawing.Size(180, 25);
            this.ProcessorModelLabel.TabIndex = 3;
            this.ProcessorModelLabel.Text = "Модель процессора";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(13, 292);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(166, 31);
            this.ModelTextBox.TabIndex = 4;
            // 
            // ProcessorCoresTrackBar
            // 
            this.ProcessorCoresTrackBar.Location = new System.Drawing.Point(20, 382);
            this.ProcessorCoresTrackBar.Maximum = 16;
            this.ProcessorCoresTrackBar.Minimum = 1;
            this.ProcessorCoresTrackBar.Name = "ProcessorCoresTrackBar";
            this.ProcessorCoresTrackBar.Size = new System.Drawing.Size(156, 69);
            this.ProcessorCoresTrackBar.TabIndex = 5;
            this.ProcessorCoresTrackBar.Value = 1;
            this.ProcessorCoresTrackBar.Scroll += new System.EventHandler(this.ProcessorCoresTrackBar_Scroll);
            // 
            // ProcessorCoresTrackBarLabel
            // 
            this.ProcessorCoresTrackBarLabel.AutoSize = true;
            this.ProcessorCoresTrackBarLabel.Location = new System.Drawing.Point(183, 393);
            this.ProcessorCoresTrackBarLabel.Name = "ProcessorCoresTrackBarLabel";
            this.ProcessorCoresTrackBarLabel.Size = new System.Drawing.Size(22, 25);
            this.ProcessorCoresTrackBarLabel.TabIndex = 6;
            this.ProcessorCoresTrackBarLabel.Text = "1";
            // 
            // ProcessorCoresLabel
            // 
            this.ProcessorCoresLabel.AutoSize = true;
            this.ProcessorCoresLabel.Location = new System.Drawing.Point(13, 343);
            this.ProcessorCoresLabel.Name = "ProcessorCoresLabel";
            this.ProcessorCoresLabel.Size = new System.Drawing.Size(151, 25);
            this.ProcessorCoresLabel.TabIndex = 7;
            this.ProcessorCoresLabel.Text = "Количество ядер";
            // 
            // BaseClockLabel
            // 
            this.BaseClockLabel.AutoSize = true;
            this.BaseClockLabel.Location = new System.Drawing.Point(484, 13);
            this.BaseClockLabel.Name = "BaseClockLabel";
            this.BaseClockLabel.Size = new System.Drawing.Size(256, 25);
            this.BaseClockLabel.TabIndex = 8;
            this.BaseClockLabel.Text = "Базовая тактовая частота, ГГц";
            // 
            // MaxClockLabel
            // 
            this.MaxClockLabel.AutoSize = true;
            this.MaxClockLabel.Location = new System.Drawing.Point(478, 95);
            this.MaxClockLabel.Name = "MaxClockLabel";
            this.MaxClockLabel.Size = new System.Drawing.Size(310, 25);
            this.MaxClockLabel.TabIndex = 9;
            this.MaxClockLabel.Text = "Максимальная тактовая частота, ГГц";
            // 
            // BaseClockTextBox
            // 
            this.BaseClockTextBox.Location = new System.Drawing.Point(484, 44);
            this.BaseClockTextBox.Name = "BaseClockTextBox";
            this.BaseClockTextBox.Size = new System.Drawing.Size(304, 31);
            this.BaseClockTextBox.TabIndex = 10;
            // 
            // MaxClockTextBox
            // 
            this.MaxClockTextBox.Location = new System.Drawing.Point(478, 123);
            this.MaxClockTextBox.Name = "MaxClockTextBox";
            this.MaxClockTextBox.Size = new System.Drawing.Size(310, 31);
            this.MaxClockTextBox.TabIndex = 11;
            // 
            // ProcessorAddButton
            // 
            this.ProcessorAddButton.Location = new System.Drawing.Point(562, 307);
            this.ProcessorAddButton.Name = "ProcessorAddButton";
            this.ProcessorAddButton.Size = new System.Drawing.Size(112, 34);
            this.ProcessorAddButton.TabIndex = 12;
            this.ProcessorAddButton.Text = "Добавить";
            this.ProcessorAddButton.UseVisualStyleBackColor = true;
            this.ProcessorAddButton.Click += new System.EventHandler(this.ProcessorAddButton_Click);
            // 
            // ArchitectureGroupBox
            // 
            this.ArchitectureGroupBox.Controls.Add(this.x64RadioButton);
            this.ArchitectureGroupBox.Controls.Add(this.x86RadioButton);
            this.ArchitectureGroupBox.Location = new System.Drawing.Point(484, 172);
            this.ArchitectureGroupBox.Name = "ArchitectureGroupBox";
            this.ArchitectureGroupBox.Size = new System.Drawing.Size(129, 101);
            this.ArchitectureGroupBox.TabIndex = 13;
            this.ArchitectureGroupBox.TabStop = false;
            this.ArchitectureGroupBox.Text = "Архитектура";
            // 
            // x64RadioButton
            // 
            this.x64RadioButton.AutoSize = true;
            this.x64RadioButton.Location = new System.Drawing.Point(7, 66);
            this.x64RadioButton.Name = "x64RadioButton";
            this.x64RadioButton.Size = new System.Drawing.Size(65, 29);
            this.x64RadioButton.TabIndex = 1;
            this.x64RadioButton.Text = "x64";
            this.x64RadioButton.UseVisualStyleBackColor = true;
            // 
            // x86RadioButton
            // 
            this.x86RadioButton.AutoSize = true;
            this.x86RadioButton.Checked = true;
            this.x86RadioButton.Location = new System.Drawing.Point(7, 31);
            this.x86RadioButton.Name = "x86RadioButton";
            this.x86RadioButton.Size = new System.Drawing.Size(65, 29);
            this.x86RadioButton.TabIndex = 0;
            this.x86RadioButton.TabStop = true;
            this.x86RadioButton.Text = "x86";
            this.x86RadioButton.UseVisualStyleBackColor = true;
            // 
            // L1_3CacheLabel
            // 
            this.L1_3CacheLabel.AutoSize = true;
            this.L1_3CacheLabel.Location = new System.Drawing.Point(629, 183);
            this.L1_3CacheLabel.Name = "L1_3CacheLabel";
            this.L1_3CacheLabel.Size = new System.Drawing.Size(92, 25);
            this.L1_3CacheLabel.TabIndex = 14;
            this.L1_3CacheLabel.Text = "L1-L3 Кэш";
            // 
            // L1_L3CacheTextBox
            // 
            this.L1_L3CacheTextBox.Location = new System.Drawing.Point(629, 212);
            this.L1_L3CacheTextBox.Name = "L1_L3CacheTextBox";
            this.L1_L3CacheTextBox.Size = new System.Drawing.Size(150, 31);
            this.L1_L3CacheTextBox.TabIndex = 15;
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
            // MaxClockError
            // 
            this.MaxClockError.ContainerControl = this;
            // 
            // L1_L3CacheError
            // 
            this.L1_L3CacheError.ContainerControl = this;
            // 
            // ProcessorFillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.L1_L3CacheTextBox);
            this.Controls.Add(this.L1_3CacheLabel);
            this.Controls.Add(this.ArchitectureGroupBox);
            this.Controls.Add(this.ProcessorAddButton);
            this.Controls.Add(this.MaxClockTextBox);
            this.Controls.Add(this.BaseClockTextBox);
            this.Controls.Add(this.MaxClockLabel);
            this.Controls.Add(this.BaseClockLabel);
            this.Controls.Add(this.ProcessorCoresLabel);
            this.Controls.Add(this.ProcessorCoresTrackBarLabel);
            this.Controls.Add(this.ProcessorCoresTrackBar);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ProcessorModelLabel);
            this.Controls.Add(this.SeriesTextBox);
            this.Controls.Add(this.ProcessorSeriesLabel);
            this.Controls.Add(this.ProcessorManufacturerGroup);
            this.Name = "ProcessorFillForm";
            this.Text = "Добавить процессор";
            this.ProcessorManufacturerGroup.ResumeLayout(false);
            this.ProcessorManufacturerGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessorCoresTrackBar)).EndInit();
            this.ArchitectureGroupBox.ResumeLayout(false);
            this.ArchitectureGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturerError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeriesError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseClockError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxClockError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1_L3CacheError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ProcessorManufacturerGroup;
        private System.Windows.Forms.RadioButton AMDRadioButton;
        private System.Windows.Forms.RadioButton IntelRadioButton;
        private System.Windows.Forms.Label ProcessorSeriesLabel;
        private System.Windows.Forms.TextBox SeriesTextBox;
        private System.Windows.Forms.Label ProcessorModelLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TrackBar ProcessorCoresTrackBar;
        private System.Windows.Forms.Label ProcessorCoresTrackBarLabel;
        private System.Windows.Forms.Label ProcessorCoresLabel;
        private System.Windows.Forms.Label BaseClockLabel;
        private System.Windows.Forms.Label MaxClockLabel;
        private System.Windows.Forms.TextBox BaseClockTextBox;
        private System.Windows.Forms.TextBox MaxClockTextBox;
        private System.Windows.Forms.Button ProcessorAddButton;
        private System.Windows.Forms.GroupBox ArchitectureGroupBox;
        private System.Windows.Forms.RadioButton x64RadioButton;
        private System.Windows.Forms.RadioButton x86RadioButton;
        private System.Windows.Forms.Label L1_3CacheLabel;
        private System.Windows.Forms.TextBox L1_L3CacheTextBox;
        private System.Windows.Forms.ErrorProvider ManufacturerError;
        private System.Windows.Forms.ErrorProvider SeriesError;
        private System.Windows.Forms.ErrorProvider ModelError;
        private System.Windows.Forms.ErrorProvider BaseClockError;
        private System.Windows.Forms.ErrorProvider MaxClockError;
        private System.Windows.Forms.ErrorProvider L1_L3CacheError;
    }
}