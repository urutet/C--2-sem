﻿
namespace LAB2_3
{
    partial class ITLabForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ComputerTypeBox = new System.Windows.Forms.ComboBox();
            this.ComputerTypeLabel = new System.Windows.Forms.Label();
            this.ProcessorLabel = new System.Windows.Forms.Label();
            this.ProcessorComboBox = new System.Windows.Forms.ComboBox();
            this.ProcessorAddButton = new System.Windows.Forms.Button();
            this.VideocardComboBox = new System.Windows.Forms.ComboBox();
            this.VideocardLabel = new System.Windows.Forms.Label();
            this.VideocardAddButton = new System.Windows.Forms.Button();
            this.RAMTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.DDR4Radio = new System.Windows.Forms.RadioButton();
            this.DDR3Radio = new System.Windows.Forms.RadioButton();
            this.RAMSizeLabel = new System.Windows.Forms.Label();
            this.RAMSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.DiskTypeGroup = new System.Windows.Forms.GroupBox();
            this.SSDCheckBox = new System.Windows.Forms.CheckBox();
            this.HDDCheckBox = new System.Windows.Forms.CheckBox();
            this.DateOfPurchasePicker = new System.Windows.Forms.DateTimePicker();
            this.DateOfPurchaseLabel = new System.Windows.Forms.Label();
            this.RAMTrackBarLabel = new System.Windows.Forms.Label();
            this.HDDSizeLabel = new System.Windows.Forms.Label();
            this.HDDSizeTextBox = new System.Windows.Forms.TextBox();
            this.SSDSizeTextBox = new System.Windows.Forms.TextBox();
            this.SSDSizeLabel = new System.Windows.Forms.Label();
            this.ComputerAddButton = new System.Windows.Forms.Button();
            this.RAMTypeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.DiskTypeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.HDDSizeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.SSDSizeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ComputerTypeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.LabGrid = new System.Windows.Forms.DataGridView();
            this.ComputerTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseClockCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfCoresCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CacheSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAMTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAMSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideocardCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VRAMSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectXSupportCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSDSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDDSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JSONSerializeButton = new System.Windows.Forms.Button();
            this.JSONDeserializer = new System.Windows.Forms.Button();
            this.RAMTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RAMSizeTrackBar)).BeginInit();
            this.DiskTypeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RAMTypeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskTypeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDDSizeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSDSizeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerTypeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ComputerTypeBox
            // 
            this.ComputerTypeBox.FormattingEnabled = true;
            this.ComputerTypeBox.Items.AddRange(new object[] {
            "Сервер",
            "Рабочая_Станция",
            "Ноутбук",
            "Нетбук"});
            this.ComputerTypeBox.Location = new System.Drawing.Point(13, 60);
            this.ComputerTypeBox.Name = "ComputerTypeBox";
            this.ComputerTypeBox.Size = new System.Drawing.Size(182, 33);
            this.ComputerTypeBox.TabIndex = 0;
            // 
            // ComputerTypeLabel
            // 
            this.ComputerTypeLabel.AutoSize = true;
            this.ComputerTypeLabel.Location = new System.Drawing.Point(13, 13);
            this.ComputerTypeLabel.Name = "ComputerTypeLabel";
            this.ComputerTypeLabel.Size = new System.Drawing.Size(149, 25);
            this.ComputerTypeLabel.TabIndex = 1;
            this.ComputerTypeLabel.Text = "Тип компьютера";
            // 
            // ProcessorLabel
            // 
            this.ProcessorLabel.AutoSize = true;
            this.ProcessorLabel.Location = new System.Drawing.Point(13, 119);
            this.ProcessorLabel.Name = "ProcessorLabel";
            this.ProcessorLabel.Size = new System.Drawing.Size(105, 25);
            this.ProcessorLabel.TabIndex = 2;
            this.ProcessorLabel.Text = "Процессор";
            // 
            // ProcessorComboBox
            // 
            this.ProcessorComboBox.FormattingEnabled = true;
            this.ProcessorComboBox.Location = new System.Drawing.Point(13, 167);
            this.ProcessorComboBox.Name = "ProcessorComboBox";
            this.ProcessorComboBox.Size = new System.Drawing.Size(182, 33);
            this.ProcessorComboBox.TabIndex = 3;
            // 
            // ProcessorAddButton
            // 
            this.ProcessorAddButton.Location = new System.Drawing.Point(37, 218);
            this.ProcessorAddButton.Name = "ProcessorAddButton";
            this.ProcessorAddButton.Size = new System.Drawing.Size(112, 34);
            this.ProcessorAddButton.TabIndex = 4;
            this.ProcessorAddButton.Text = "Добавить";
            this.ProcessorAddButton.UseVisualStyleBackColor = true;
            this.ProcessorAddButton.Click += new System.EventHandler(this.ProcessorAddButton_Click);
            // 
            // VideocardComboBox
            // 
            this.VideocardComboBox.FormattingEnabled = true;
            this.VideocardComboBox.Location = new System.Drawing.Point(13, 314);
            this.VideocardComboBox.Name = "VideocardComboBox";
            this.VideocardComboBox.Size = new System.Drawing.Size(182, 33);
            this.VideocardComboBox.TabIndex = 5;
            // 
            // VideocardLabel
            // 
            this.VideocardLabel.AutoSize = true;
            this.VideocardLabel.Location = new System.Drawing.Point(13, 272);
            this.VideocardLabel.Name = "VideocardLabel";
            this.VideocardLabel.Size = new System.Drawing.Size(107, 25);
            this.VideocardLabel.TabIndex = 6;
            this.VideocardLabel.Text = "Видеокарта";
            // 
            // VideocardAddButton
            // 
            this.VideocardAddButton.Location = new System.Drawing.Point(37, 364);
            this.VideocardAddButton.Name = "VideocardAddButton";
            this.VideocardAddButton.Size = new System.Drawing.Size(112, 34);
            this.VideocardAddButton.TabIndex = 7;
            this.VideocardAddButton.Text = "Добавить";
            this.VideocardAddButton.UseVisualStyleBackColor = true;
            this.VideocardAddButton.Click += new System.EventHandler(this.VideocardAddButton_Click);
            // 
            // RAMTypeGroupBox
            // 
            this.RAMTypeGroupBox.Controls.Add(this.DDR4Radio);
            this.RAMTypeGroupBox.Controls.Add(this.DDR3Radio);
            this.RAMTypeGroupBox.Location = new System.Drawing.Point(489, 13);
            this.RAMTypeGroupBox.Name = "RAMTypeGroupBox";
            this.RAMTypeGroupBox.Size = new System.Drawing.Size(182, 120);
            this.RAMTypeGroupBox.TabIndex = 8;
            this.RAMTypeGroupBox.TabStop = false;
            this.RAMTypeGroupBox.Text = "Тип памяти";
            // 
            // DDR4Radio
            // 
            this.DDR4Radio.AutoSize = true;
            this.DDR4Radio.Location = new System.Drawing.Point(24, 77);
            this.DDR4Radio.Name = "DDR4Radio";
            this.DDR4Radio.Size = new System.Drawing.Size(84, 29);
            this.DDR4Radio.TabIndex = 1;
            this.DDR4Radio.TabStop = true;
            this.DDR4Radio.Text = "DDR4";
            this.DDR4Radio.UseVisualStyleBackColor = true;
            // 
            // DDR3Radio
            // 
            this.DDR3Radio.AutoSize = true;
            this.DDR3Radio.Checked = true;
            this.DDR3Radio.Location = new System.Drawing.Point(24, 42);
            this.DDR3Radio.Name = "DDR3Radio";
            this.DDR3Radio.Size = new System.Drawing.Size(84, 29);
            this.DDR3Radio.TabIndex = 0;
            this.DDR3Radio.TabStop = true;
            this.DDR3Radio.Text = "DDR3";
            this.DDR3Radio.UseVisualStyleBackColor = true;
            // 
            // RAMSizeLabel
            // 
            this.RAMSizeLabel.AutoSize = true;
            this.RAMSizeLabel.Location = new System.Drawing.Point(489, 167);
            this.RAMSizeLabel.Name = "RAMSizeLabel";
            this.RAMSizeLabel.Size = new System.Drawing.Size(245, 25);
            this.RAMSizeLabel.TabIndex = 9;
            this.RAMSizeLabel.Text = "Объем оперативной памяти";
            // 
            // RAMSizeTrackBar
            // 
            this.RAMSizeTrackBar.Location = new System.Drawing.Point(489, 218);
            this.RAMSizeTrackBar.Maximum = 128;
            this.RAMSizeTrackBar.Minimum = 1;
            this.RAMSizeTrackBar.Name = "RAMSizeTrackBar";
            this.RAMSizeTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RAMSizeTrackBar.Size = new System.Drawing.Size(156, 69);
            this.RAMSizeTrackBar.TabIndex = 10;
            this.RAMSizeTrackBar.Value = 1;
            this.RAMSizeTrackBar.Scroll += new System.EventHandler(this.RAMSizeTrackBar_Scroll);
            // 
            // DiskTypeGroup
            // 
            this.DiskTypeGroup.Controls.Add(this.SSDCheckBox);
            this.DiskTypeGroup.Controls.Add(this.HDDCheckBox);
            this.DiskTypeGroup.Location = new System.Drawing.Point(811, 20);
            this.DiskTypeGroup.Name = "DiskTypeGroup";
            this.DiskTypeGroup.Size = new System.Drawing.Size(182, 113);
            this.DiskTypeGroup.TabIndex = 11;
            this.DiskTypeGroup.TabStop = false;
            this.DiskTypeGroup.Text = "Типы дисков";
            // 
            // SSDCheckBox
            // 
            this.SSDCheckBox.AutoSize = true;
            this.SSDCheckBox.Location = new System.Drawing.Point(7, 67);
            this.SSDCheckBox.Name = "SSDCheckBox";
            this.SSDCheckBox.Size = new System.Drawing.Size(71, 29);
            this.SSDCheckBox.TabIndex = 1;
            this.SSDCheckBox.Text = "SSD";
            this.SSDCheckBox.UseVisualStyleBackColor = true;
            this.SSDCheckBox.CheckedChanged += new System.EventHandler(this.SSDCheckBox_CheckedChanged);
            // 
            // HDDCheckBox
            // 
            this.HDDCheckBox.AutoSize = true;
            this.HDDCheckBox.Location = new System.Drawing.Point(7, 31);
            this.HDDCheckBox.Name = "HDDCheckBox";
            this.HDDCheckBox.Size = new System.Drawing.Size(77, 29);
            this.HDDCheckBox.TabIndex = 0;
            this.HDDCheckBox.Text = "HDD";
            this.HDDCheckBox.UseVisualStyleBackColor = true;
            this.HDDCheckBox.CheckedChanged += new System.EventHandler(this.HDDCheckBox_CheckedChanged);
            // 
            // DateOfPurchasePicker
            // 
            this.DateOfPurchasePicker.Location = new System.Drawing.Point(384, 433);
            this.DateOfPurchasePicker.Name = "DateOfPurchasePicker";
            this.DateOfPurchasePicker.Size = new System.Drawing.Size(300, 31);
            this.DateOfPurchasePicker.TabIndex = 12;
            // 
            // DateOfPurchaseLabel
            // 
            this.DateOfPurchaseLabel.AutoSize = true;
            this.DateOfPurchaseLabel.Location = new System.Drawing.Point(462, 392);
            this.DateOfPurchaseLabel.Name = "DateOfPurchaseLabel";
            this.DateOfPurchaseLabel.Size = new System.Drawing.Size(122, 25);
            this.DateOfPurchaseLabel.TabIndex = 13;
            this.DateOfPurchaseLabel.Text = "Дата покупки";
            // 
            // RAMTrackBarLabel
            // 
            this.RAMTrackBarLabel.AutoSize = true;
            this.RAMTrackBarLabel.Location = new System.Drawing.Point(685, 218);
            this.RAMTrackBarLabel.Name = "RAMTrackBarLabel";
            this.RAMTrackBarLabel.Size = new System.Drawing.Size(22, 25);
            this.RAMTrackBarLabel.TabIndex = 14;
            this.RAMTrackBarLabel.Text = "1";
            // 
            // HDDSizeLabel
            // 
            this.HDDSizeLabel.AutoSize = true;
            this.HDDSizeLabel.Location = new System.Drawing.Point(811, 145);
            this.HDDSizeLabel.Name = "HDDSizeLabel";
            this.HDDSizeLabel.Size = new System.Drawing.Size(194, 25);
            this.HDDSizeLabel.TabIndex = 15;
            this.HDDSizeLabel.Text = "Размер HDD диска, Гб";
            // 
            // HDDSizeTextBox
            // 
            this.HDDSizeTextBox.Location = new System.Drawing.Point(817, 173);
            this.HDDSizeTextBox.Name = "HDDSizeTextBox";
            this.HDDSizeTextBox.ReadOnly = true;
            this.HDDSizeTextBox.Size = new System.Drawing.Size(176, 31);
            this.HDDSizeTextBox.TabIndex = 16;
            // 
            // SSDSizeTextBox
            // 
            this.SSDSizeTextBox.Location = new System.Drawing.Point(818, 254);
            this.SSDSizeTextBox.Name = "SSDSizeTextBox";
            this.SSDSizeTextBox.ReadOnly = true;
            this.SSDSizeTextBox.Size = new System.Drawing.Size(175, 31);
            this.SSDSizeTextBox.TabIndex = 17;
            // 
            // SSDSizeLabel
            // 
            this.SSDSizeLabel.AutoSize = true;
            this.SSDSizeLabel.Location = new System.Drawing.Point(811, 226);
            this.SSDSizeLabel.Name = "SSDSizeLabel";
            this.SSDSizeLabel.Size = new System.Drawing.Size(188, 25);
            this.SSDSizeLabel.TabIndex = 18;
            this.SSDSizeLabel.Text = "Размер SSD диска, Гб";
            // 
            // ComputerAddButton
            // 
            this.ComputerAddButton.Location = new System.Drawing.Point(750, 494);
            this.ComputerAddButton.Name = "ComputerAddButton";
            this.ComputerAddButton.Size = new System.Drawing.Size(243, 34);
            this.ComputerAddButton.TabIndex = 19;
            this.ComputerAddButton.Text = "Добавить компьютер";
            this.ComputerAddButton.UseVisualStyleBackColor = true;
            this.ComputerAddButton.Click += new System.EventHandler(this.ComputerAddButton_Click);
            // 
            // RAMTypeError
            // 
            this.RAMTypeError.ContainerControl = this;
            // 
            // DiskTypeError
            // 
            this.DiskTypeError.ContainerControl = this;
            // 
            // HDDSizeError
            // 
            this.HDDSizeError.ContainerControl = this;
            // 
            // SSDSizeError
            // 
            this.SSDSizeError.ContainerControl = this;
            // 
            // ComputerTypeError
            // 
            this.ComputerTypeError.ContainerControl = this;
            // 
            // LabGrid
            // 
            this.LabGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LabGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComputerTypeCol,
            this.ProcessorCol,
            this.BaseClockCol,
            this.NumberOfCoresCol,
            this.CacheSizeCol,
            this.RAMTypeCol,
            this.RAMSizeCol,
            this.VideocardCol,
            this.VRAMSizeCol,
            this.DirectXSupportCol,
            this.SSDSizeCol,
            this.HDDSizeCol,
            this.DateOfPurchase});
            this.LabGrid.Location = new System.Drawing.Point(13, 571);
            this.LabGrid.Name = "LabGrid";
            this.LabGrid.RowHeadersWidth = 62;
            this.LabGrid.RowTemplate.Height = 33;
            this.LabGrid.Size = new System.Drawing.Size(1004, 225);
            this.LabGrid.TabIndex = 20;
            // 
            // ComputerTypeCol
            // 
            this.ComputerTypeCol.HeaderText = "Тип компьютера";
            this.ComputerTypeCol.MinimumWidth = 8;
            this.ComputerTypeCol.Name = "ComputerTypeCol";
            this.ComputerTypeCol.ReadOnly = true;
            this.ComputerTypeCol.Width = 150;
            // 
            // ProcessorCol
            // 
            this.ProcessorCol.HeaderText = "Процессор";
            this.ProcessorCol.MinimumWidth = 8;
            this.ProcessorCol.Name = "ProcessorCol";
            this.ProcessorCol.ReadOnly = true;
            this.ProcessorCol.Width = 150;
            // 
            // BaseClockCol
            // 
            this.BaseClockCol.HeaderText = "Тактовая частота, ГГц";
            this.BaseClockCol.MinimumWidth = 8;
            this.BaseClockCol.Name = "BaseClockCol";
            this.BaseClockCol.ReadOnly = true;
            this.BaseClockCol.Width = 150;
            // 
            // NumberOfCoresCol
            // 
            this.NumberOfCoresCol.HeaderText = "Количество ядер";
            this.NumberOfCoresCol.MinimumWidth = 8;
            this.NumberOfCoresCol.Name = "NumberOfCoresCol";
            this.NumberOfCoresCol.ReadOnly = true;
            this.NumberOfCoresCol.Width = 150;
            // 
            // CacheSizeCol
            // 
            this.CacheSizeCol.HeaderText = "Размер кэша";
            this.CacheSizeCol.MinimumWidth = 8;
            this.CacheSizeCol.Name = "CacheSizeCol";
            this.CacheSizeCol.ReadOnly = true;
            this.CacheSizeCol.Width = 150;
            // 
            // RAMTypeCol
            // 
            this.RAMTypeCol.HeaderText = "Тип RAM";
            this.RAMTypeCol.MinimumWidth = 8;
            this.RAMTypeCol.Name = "RAMTypeCol";
            this.RAMTypeCol.ReadOnly = true;
            this.RAMTypeCol.Width = 150;
            // 
            // RAMSizeCol
            // 
            this.RAMSizeCol.HeaderText = "Объем RAM";
            this.RAMSizeCol.MinimumWidth = 8;
            this.RAMSizeCol.Name = "RAMSizeCol";
            this.RAMSizeCol.ReadOnly = true;
            this.RAMSizeCol.Width = 150;
            // 
            // VideocardCol
            // 
            this.VideocardCol.HeaderText = "Видеокарта";
            this.VideocardCol.MinimumWidth = 8;
            this.VideocardCol.Name = "VideocardCol";
            this.VideocardCol.ReadOnly = true;
            this.VideocardCol.Width = 150;
            // 
            // VRAMSizeCol
            // 
            this.VRAMSizeCol.HeaderText = "Размер VRAM";
            this.VRAMSizeCol.MinimumWidth = 8;
            this.VRAMSizeCol.Name = "VRAMSizeCol";
            this.VRAMSizeCol.ReadOnly = true;
            this.VRAMSizeCol.Width = 150;
            // 
            // DirectXSupportCol
            // 
            this.DirectXSupportCol.HeaderText = "Поддержка DirectX";
            this.DirectXSupportCol.MinimumWidth = 8;
            this.DirectXSupportCol.Name = "DirectXSupportCol";
            this.DirectXSupportCol.ReadOnly = true;
            this.DirectXSupportCol.Width = 150;
            // 
            // SSDSizeCol
            // 
            this.SSDSizeCol.HeaderText = "Объем SSD";
            this.SSDSizeCol.MinimumWidth = 8;
            this.SSDSizeCol.Name = "SSDSizeCol";
            this.SSDSizeCol.ReadOnly = true;
            this.SSDSizeCol.Width = 150;
            // 
            // HDDSizeCol
            // 
            this.HDDSizeCol.HeaderText = "Объем HDD";
            this.HDDSizeCol.MinimumWidth = 8;
            this.HDDSizeCol.Name = "HDDSizeCol";
            this.HDDSizeCol.ReadOnly = true;
            this.HDDSizeCol.Width = 150;
            // 
            // DateOfPurchase
            // 
            this.DateOfPurchase.HeaderText = "Дата покупки";
            this.DateOfPurchase.MinimumWidth = 8;
            this.DateOfPurchase.Name = "DateOfPurchase";
            this.DateOfPurchase.ReadOnly = true;
            this.DateOfPurchase.Width = 150;
            // 
            // JSONSerializeButton
            // 
            this.JSONSerializeButton.Location = new System.Drawing.Point(13, 494);
            this.JSONSerializeButton.Name = "JSONSerializeButton";
            this.JSONSerializeButton.Size = new System.Drawing.Size(226, 34);
            this.JSONSerializeButton.TabIndex = 21;
            this.JSONSerializeButton.Text = "Сериализовать в JSON";
            this.JSONSerializeButton.UseVisualStyleBackColor = true;
            this.JSONSerializeButton.Click += new System.EventHandler(this.JSONSerializeButton_Click);
            // 
            // JSONDeserializer
            // 
            this.JSONDeserializer.Location = new System.Drawing.Point(406, 494);
            this.JSONDeserializer.Name = "JSONDeserializer";
            this.JSONDeserializer.Size = new System.Drawing.Size(265, 34);
            this.JSONDeserializer.TabIndex = 22;
            this.JSONDeserializer.Text = "Десериализовать из JSON";
            this.JSONDeserializer.UseVisualStyleBackColor = true;
            this.JSONDeserializer.Click += new System.EventHandler(this.JSONDeserializer_Click);
            // 
            // ITLabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 808);
            this.Controls.Add(this.JSONDeserializer);
            this.Controls.Add(this.JSONSerializeButton);
            this.Controls.Add(this.LabGrid);
            this.Controls.Add(this.ComputerAddButton);
            this.Controls.Add(this.SSDSizeLabel);
            this.Controls.Add(this.SSDSizeTextBox);
            this.Controls.Add(this.HDDSizeTextBox);
            this.Controls.Add(this.HDDSizeLabel);
            this.Controls.Add(this.RAMTrackBarLabel);
            this.Controls.Add(this.DateOfPurchaseLabel);
            this.Controls.Add(this.DateOfPurchasePicker);
            this.Controls.Add(this.DiskTypeGroup);
            this.Controls.Add(this.RAMSizeTrackBar);
            this.Controls.Add(this.RAMSizeLabel);
            this.Controls.Add(this.RAMTypeGroupBox);
            this.Controls.Add(this.VideocardAddButton);
            this.Controls.Add(this.VideocardLabel);
            this.Controls.Add(this.VideocardComboBox);
            this.Controls.Add(this.ProcessorAddButton);
            this.Controls.Add(this.ProcessorComboBox);
            this.Controls.Add(this.ProcessorLabel);
            this.Controls.Add(this.ComputerTypeLabel);
            this.Controls.Add(this.ComputerTypeBox);
            this.Name = "ITLabForm";
            this.Text = "IT Лаборатория";
            this.RAMTypeGroupBox.ResumeLayout(false);
            this.RAMTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RAMSizeTrackBar)).EndInit();
            this.DiskTypeGroup.ResumeLayout(false);
            this.DiskTypeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RAMTypeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskTypeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDDSizeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSDSizeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerTypeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComputerTypeBox;
        private System.Windows.Forms.Label ComputerTypeLabel;
        private System.Windows.Forms.Label ProcessorLabel;
        private System.Windows.Forms.Button ProcessorAddButton;
        private System.Windows.Forms.Label VideocardLabel;
        private System.Windows.Forms.Button VideocardAddButton;
        private System.Windows.Forms.GroupBox RAMTypeGroupBox;
        private System.Windows.Forms.RadioButton DDR4Radio;
        private System.Windows.Forms.RadioButton DDR3Radio;
        private System.Windows.Forms.Label RAMSizeLabel;
        private System.Windows.Forms.TrackBar RAMSizeTrackBar;
        private System.Windows.Forms.GroupBox DiskTypeGroup;
        private System.Windows.Forms.CheckBox SSDCheckBox;
        private System.Windows.Forms.CheckBox HDDCheckBox;
        private System.Windows.Forms.DateTimePicker DateOfPurchasePicker;
        private System.Windows.Forms.Label DateOfPurchaseLabel;
        private System.Windows.Forms.Label RAMTrackBarLabel;
        private System.Windows.Forms.Label HDDSizeLabel;
        private System.Windows.Forms.TextBox HDDSizeTextBox;
        private System.Windows.Forms.TextBox SSDSizeTextBox;
        private System.Windows.Forms.Label SSDSizeLabel;
        private System.Windows.Forms.Button ComputerAddButton;
        private System.Windows.Forms.ComboBox ca;
        public System.Windows.Forms.ComboBox ProcessorComboBox;
        public System.Windows.Forms.ComboBox VideocardComboBox;
        private System.Windows.Forms.ErrorProvider RAMTypeError;
        private System.Windows.Forms.ErrorProvider DiskTypeError;
        private System.Windows.Forms.ErrorProvider HDDSizeError;
        private System.Windows.Forms.ErrorProvider SSDSizeError;
        private System.Windows.Forms.ErrorProvider ComputerTypeError;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView LabGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseClockCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfCoresCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CacheSizeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAMTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAMSizeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideocardCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VRAMSizeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectXSupportCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSDSizeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDDSizeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPurchase;
        private System.Windows.Forms.Button JSONSerializeButton;
        private System.Windows.Forms.Button JSONDeserializer;
    }
}

