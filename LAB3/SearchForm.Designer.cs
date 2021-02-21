
namespace LAB2_3
{
    partial class SearchForm
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
            this.ManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.ManufacturerCheckBox = new System.Windows.Forms.CheckBox();
            this.ModelCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LabGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ManufacturerComboBox
            // 
            this.ManufacturerComboBox.FormattingEnabled = true;
            this.ManufacturerComboBox.Items.AddRange(new object[] {
            "Intel",
            "AMD"});
            this.ManufacturerComboBox.Location = new System.Drawing.Point(12, 61);
            this.ManufacturerComboBox.Name = "ManufacturerComboBox";
            this.ManufacturerComboBox.Size = new System.Drawing.Size(182, 33);
            this.ManufacturerComboBox.TabIndex = 1;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(248, 63);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(150, 31);
            this.ModelTextBox.TabIndex = 3;
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
            this.LabGrid.Location = new System.Drawing.Point(12, 199);
            this.LabGrid.Name = "LabGrid";
            this.LabGrid.RowHeadersWidth = 62;
            this.LabGrid.RowTemplate.Height = 33;
            this.LabGrid.Size = new System.Drawing.Size(1004, 225);
            this.LabGrid.TabIndex = 21;
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
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(448, 59);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(112, 34);
            this.SearchButton.TabIndex = 22;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ManufacturerCheckBox
            // 
            this.ManufacturerCheckBox.AutoSize = true;
            this.ManufacturerCheckBox.Location = new System.Drawing.Point(12, 26);
            this.ManufacturerCheckBox.Name = "ManufacturerCheckBox";
            this.ManufacturerCheckBox.Size = new System.Drawing.Size(166, 29);
            this.ManufacturerCheckBox.TabIndex = 23;
            this.ManufacturerCheckBox.Text = "Производитель";
            this.ManufacturerCheckBox.UseVisualStyleBackColor = true;
            this.ManufacturerCheckBox.CheckedChanged += new System.EventHandler(this.ManufacturerCheckBox_CheckedChanged);
            // 
            // ModelCheckBox
            // 
            this.ModelCheckBox.AutoSize = true;
            this.ModelCheckBox.Location = new System.Drawing.Point(248, 28);
            this.ModelCheckBox.Name = "ModelCheckBox";
            this.ModelCheckBox.Size = new System.Drawing.Size(102, 29);
            this.ModelCheckBox.TabIndex = 24;
            this.ModelCheckBox.Text = "Модель";
            this.ModelCheckBox.UseVisualStyleBackColor = true;
            this.ModelCheckBox.CheckedChanged += new System.EventHandler(this.ModelCheckBox_CheckedChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.ModelCheckBox);
            this.Controls.Add(this.ManufacturerCheckBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LabGrid);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ManufacturerComboBox);
            this.Name = "SearchForm";
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.LabGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.CheckBox ManufacturerCheckBox;
        public System.Windows.Forms.CheckBox ModelCheckBox;
        public System.Windows.Forms.TextBox ModelTextBox;
        public System.Windows.Forms.DataGridView LabGrid;
        public System.Windows.Forms.ComboBox ManufacturerComboBox;
    }
}