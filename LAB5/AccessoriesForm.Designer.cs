
namespace LAB2_3
{
    partial class AccessoriesForm
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
            this.AcessoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.SecondDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.FingerprintCheckBox = new System.Windows.Forms.CheckBox();
            this.WebcamCheckBox = new System.Windows.Forms.CheckBox();
            this.AddPCWithAccessoriesButton = new System.Windows.Forms.Button();
            this.AcessoriesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcessoriesGroupBox
            // 
            this.AcessoriesGroupBox.Controls.Add(this.SecondDisplayCheckBox);
            this.AcessoriesGroupBox.Controls.Add(this.FingerprintCheckBox);
            this.AcessoriesGroupBox.Controls.Add(this.WebcamCheckBox);
            this.AcessoriesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AcessoriesGroupBox.Name = "AcessoriesGroupBox";
            this.AcessoriesGroupBox.Size = new System.Drawing.Size(324, 162);
            this.AcessoriesGroupBox.TabIndex = 0;
            this.AcessoriesGroupBox.TabStop = false;
            this.AcessoriesGroupBox.Text = "Аксессуары";
            // 
            // SecondDisplayCheckBox
            // 
            this.SecondDisplayCheckBox.AutoSize = true;
            this.SecondDisplayCheckBox.Location = new System.Drawing.Point(7, 103);
            this.SecondDisplayCheckBox.Name = "SecondDisplayCheckBox";
            this.SecondDisplayCheckBox.Size = new System.Drawing.Size(150, 29);
            this.SecondDisplayCheckBox.TabIndex = 2;
            this.SecondDisplayCheckBox.Text = "Второй экран";
            this.SecondDisplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // FingerprintCheckBox
            // 
            this.FingerprintCheckBox.AutoSize = true;
            this.FingerprintCheckBox.Location = new System.Drawing.Point(7, 67);
            this.FingerprintCheckBox.Name = "FingerprintCheckBox";
            this.FingerprintCheckBox.Size = new System.Drawing.Size(267, 29);
            this.FingerprintCheckBox.TabIndex = 1;
            this.FingerprintCheckBox.Text = "Сканер отпечатков пальцев";
            this.FingerprintCheckBox.UseVisualStyleBackColor = true;
            // 
            // WebcamCheckBox
            // 
            this.WebcamCheckBox.AutoSize = true;
            this.WebcamCheckBox.Location = new System.Drawing.Point(7, 31);
            this.WebcamCheckBox.Name = "WebcamCheckBox";
            this.WebcamCheckBox.Size = new System.Drawing.Size(99, 29);
            this.WebcamCheckBox.TabIndex = 0;
            this.WebcamCheckBox.Text = "Камера";
            this.WebcamCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddPCWithAccessoriesButton
            // 
            this.AddPCWithAccessoriesButton.Location = new System.Drawing.Point(224, 196);
            this.AddPCWithAccessoriesButton.Name = "AddPCWithAccessoriesButton";
            this.AddPCWithAccessoriesButton.Size = new System.Drawing.Size(112, 34);
            this.AddPCWithAccessoriesButton.TabIndex = 1;
            this.AddPCWithAccessoriesButton.Text = "Добавить";
            this.AddPCWithAccessoriesButton.UseVisualStyleBackColor = true;
            this.AddPCWithAccessoriesButton.Click += new System.EventHandler(this.AddPCWithAccessoriesButton_Click);
            // 
            // AccessoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 254);
            this.Controls.Add(this.AddPCWithAccessoriesButton);
            this.Controls.Add(this.AcessoriesGroupBox);
            this.Name = "AccessoriesForm";
            this.Text = "AccessoriesForm";
            this.AcessoriesGroupBox.ResumeLayout(false);
            this.AcessoriesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AcessoriesGroupBox;
        private System.Windows.Forms.CheckBox SecondDisplayCheckBox;
        private System.Windows.Forms.CheckBox FingerprintCheckBox;
        private System.Windows.Forms.CheckBox WebcamCheckBox;
        private System.Windows.Forms.Button AddPCWithAccessoriesButton;
    }
}