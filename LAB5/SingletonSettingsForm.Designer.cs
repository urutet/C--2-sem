
namespace LAB2_3
{
    partial class SingletonSettingsForm
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
            this.BackgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.BackGroundColorButton = new System.Windows.Forms.Button();
            this.BackgroundColorLabel = new System.Windows.Forms.Label();
            this.FontLabel = new System.Windows.Forms.Label();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackGroundColorButton
            // 
            this.BackGroundColorButton.Location = new System.Drawing.Point(13, 26);
            this.BackGroundColorButton.Name = "BackGroundColorButton";
            this.BackGroundColorButton.Size = new System.Drawing.Size(112, 34);
            this.BackGroundColorButton.TabIndex = 0;
            this.BackGroundColorButton.Text = "Цвет фона";
            this.BackGroundColorButton.UseVisualStyleBackColor = true;
            this.BackGroundColorButton.Click += new System.EventHandler(this.BackGroundColorButton_Click);
            // 
            // BackgroundColorLabel
            // 
            this.BackgroundColorLabel.AutoSize = true;
            this.BackgroundColorLabel.Location = new System.Drawing.Point(152, 26);
            this.BackgroundColorLabel.Name = "BackgroundColorLabel";
            this.BackgroundColorLabel.Size = new System.Drawing.Size(0, 25);
            this.BackgroundColorLabel.TabIndex = 1;
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Location = new System.Drawing.Point(13, 82);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(78, 25);
            this.FontLabel.TabIndex = 2;
            this.FontLabel.Text = "Шрифт: ";
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.Location = new System.Drawing.Point(13, 130);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(144, 25);
            this.FontSizeLabel.TabIndex = 3;
            this.FontSizeLabel.Text = "Размер шрифта:";
            // 
            // SingletonSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 222);
            this.Controls.Add(this.FontSizeLabel);
            this.Controls.Add(this.FontLabel);
            this.Controls.Add(this.BackgroundColorLabel);
            this.Controls.Add(this.BackGroundColorButton);
            this.Name = "SingletonSettingsForm";
            this.Text = "Свойства";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog BackgroundColorDialog;
        private System.Windows.Forms.Button BackGroundColorButton;
        public System.Windows.Forms.Label BackgroundColorLabel;
        public System.Windows.Forms.Label FontLabel;
        public System.Windows.Forms.Label FontSizeLabel;
    }
}