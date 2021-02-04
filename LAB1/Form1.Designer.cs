
namespace LAB1
{
    partial class Form1
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.And = new System.Windows.Forms.Button();
            this.Or = new System.Windows.Forms.Button();
            this.Xor = new System.Windows.Forms.Button();
            this.Not = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.HEX_label = new System.Windows.Forms.Label();
            this.DEC_label = new System.Windows.Forms.Label();
            this.BIN_label = new System.Windows.Forms.Label();
            this.OCT_label = new System.Windows.Forms.Label();
            this.DEC_value = new System.Windows.Forms.Label();
            this.BIN_value = new System.Windows.Forms.Label();
            this.OCT_value = new System.Windows.Forms.Label();
            this.HEX_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(30, 46);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(737, 45);
            this.textBox.TabIndex = 0;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DarkOrange;
            this.Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.Location = new System.Drawing.Point(99, 255);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(81, 59);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // And
            // 
            this.And.Location = new System.Drawing.Point(186, 255);
            this.And.Name = "And";
            this.And.Size = new System.Drawing.Size(81, 58);
            this.And.TabIndex = 2;
            this.And.Text = "&&";
            this.And.UseVisualStyleBackColor = true;
            this.And.Click += new System.EventHandler(this.And_Click);
            // 
            // Or
            // 
            this.Or.Location = new System.Drawing.Point(273, 254);
            this.Or.Name = "Or";
            this.Or.Size = new System.Drawing.Size(81, 58);
            this.Or.TabIndex = 3;
            this.Or.Text = "|";
            this.Or.UseVisualStyleBackColor = true;
            this.Or.Click += new System.EventHandler(this.Or_Click);
            // 
            // Xor
            // 
            this.Xor.Location = new System.Drawing.Point(360, 254);
            this.Xor.Name = "Xor";
            this.Xor.Size = new System.Drawing.Size(81, 58);
            this.Xor.TabIndex = 4;
            this.Xor.Text = "^";
            this.Xor.UseVisualStyleBackColor = true;
            this.Xor.Click += new System.EventHandler(this.Xor_Click);
            // 
            // Not
            // 
            this.Not.Location = new System.Drawing.Point(447, 255);
            this.Not.Name = "Not";
            this.Not.Size = new System.Drawing.Size(81, 57);
            this.Not.TabIndex = 5;
            this.Not.Text = "~";
            this.Not.UseVisualStyleBackColor = true;
            this.Not.Click += new System.EventHandler(this.Not_Click);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(535, 254);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(81, 57);
            this.Equal.TabIndex = 10;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // HEX_label
            // 
            this.HEX_label.AutoSize = true;
            this.HEX_label.Location = new System.Drawing.Point(58, 169);
            this.HEX_label.Name = "HEX_label";
            this.HEX_label.Size = new System.Drawing.Size(45, 25);
            this.HEX_label.TabIndex = 11;
            this.HEX_label.Text = "HEX";
            // 
            // DEC_label
            // 
            this.DEC_label.AutoSize = true;
            this.DEC_label.Location = new System.Drawing.Point(58, 94);
            this.DEC_label.Name = "DEC_label";
            this.DEC_label.Size = new System.Drawing.Size(45, 25);
            this.DEC_label.TabIndex = 12;
            this.DEC_label.Text = "DEC";
            // 
            // BIN_label
            // 
            this.BIN_label.AutoSize = true;
            this.BIN_label.Location = new System.Drawing.Point(58, 119);
            this.BIN_label.Name = "BIN_label";
            this.BIN_label.Size = new System.Drawing.Size(40, 25);
            this.BIN_label.TabIndex = 13;
            this.BIN_label.Text = "BIN";
            // 
            // OCT_label
            // 
            this.OCT_label.AutoSize = true;
            this.OCT_label.Location = new System.Drawing.Point(58, 144);
            this.OCT_label.Name = "OCT_label";
            this.OCT_label.Size = new System.Drawing.Size(46, 25);
            this.OCT_label.TabIndex = 14;
            this.OCT_label.Text = "OCT";
            // 
            // DEC_value
            // 
            this.DEC_value.AutoSize = true;
            this.DEC_value.Location = new System.Drawing.Point(123, 94);
            this.DEC_value.Name = "DEC_value";
            this.DEC_value.Size = new System.Drawing.Size(19, 25);
            this.DEC_value.TabIndex = 15;
            this.DEC_value.Text = "_";
            // 
            // BIN_value
            // 
            this.BIN_value.AutoSize = true;
            this.BIN_value.Location = new System.Drawing.Point(123, 119);
            this.BIN_value.Name = "BIN_value";
            this.BIN_value.Size = new System.Drawing.Size(19, 25);
            this.BIN_value.TabIndex = 16;
            this.BIN_value.Text = "_";
            // 
            // OCT_value
            // 
            this.OCT_value.AutoSize = true;
            this.OCT_value.Location = new System.Drawing.Point(121, 144);
            this.OCT_value.Name = "OCT_value";
            this.OCT_value.Size = new System.Drawing.Size(19, 25);
            this.OCT_value.TabIndex = 17;
            this.OCT_value.Text = "_";
            // 
            // HEX_value
            // 
            this.HEX_value.AutoSize = true;
            this.HEX_value.Location = new System.Drawing.Point(121, 173);
            this.HEX_value.Name = "HEX_value";
            this.HEX_value.Size = new System.Drawing.Size(19, 25);
            this.HEX_value.TabIndex = 18;
            this.HEX_value.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HEX_value);
            this.Controls.Add(this.OCT_value);
            this.Controls.Add(this.BIN_value);
            this.Controls.Add(this.DEC_value);
            this.Controls.Add(this.OCT_label);
            this.Controls.Add(this.BIN_label);
            this.Controls.Add(this.DEC_label);
            this.Controls.Add(this.HEX_label);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Not);
            this.Controls.Add(this.Xor);
            this.Controls.Add(this.Or);
            this.Controls.Add(this.And);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button And;
        private System.Windows.Forms.Button OrSt;
        private System.Windows.Forms.Button Xor;
        private System.Windows.Forms.Button Not;
        private System.Windows.Forms.Button Or;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Label HEX_label;
        private System.Windows.Forms.Label DEC_label;
        private System.Windows.Forms.Label BIN_label;
        private System.Windows.Forms.Label OCT_label;
        private System.Windows.Forms.Label DEC_value;
        private System.Windows.Forms.Label BIN_value;
        private System.Windows.Forms.Label OCT_value;
        private System.Windows.Forms.Label HEX_value;
    }
}

