
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
            this.Hexagonal = new System.Windows.Forms.Button();
            this.Binary = new System.Windows.Forms.Button();
            this.Dec = new System.Windows.Forms.Button();
            this.Oct = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
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
            this.Clear.Location = new System.Drawing.Point(187, 187);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(81, 59);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // And
            // 
            this.And.Location = new System.Drawing.Point(274, 187);
            this.And.Name = "And";
            this.And.Size = new System.Drawing.Size(81, 58);
            this.And.TabIndex = 2;
            this.And.Text = "&&";
            this.And.UseVisualStyleBackColor = true;
            this.And.Click += new System.EventHandler(this.And_Click);
            // 
            // Or
            // 
            this.Or.Location = new System.Drawing.Point(361, 186);
            this.Or.Name = "Or";
            this.Or.Size = new System.Drawing.Size(81, 58);
            this.Or.TabIndex = 3;
            this.Or.Text = "|";
            this.Or.UseVisualStyleBackColor = true;
            this.Or.Click += new System.EventHandler(this.Or_Click);
            // 
            // Xor
            // 
            this.Xor.Location = new System.Drawing.Point(448, 186);
            this.Xor.Name = "Xor";
            this.Xor.Size = new System.Drawing.Size(81, 58);
            this.Xor.TabIndex = 4;
            this.Xor.Text = "^";
            this.Xor.UseVisualStyleBackColor = true;
            this.Xor.Click += new System.EventHandler(this.Xor_Click);
            // 
            // Not
            // 
            this.Not.Location = new System.Drawing.Point(535, 187);
            this.Not.Name = "Not";
            this.Not.Size = new System.Drawing.Size(81, 57);
            this.Not.TabIndex = 5;
            this.Not.Text = "~";
            this.Not.UseVisualStyleBackColor = true;
            this.Not.Click += new System.EventHandler(this.Not_Click);
            // 
            // Hexagonal
            // 
            this.Hexagonal.Location = new System.Drawing.Point(448, 254);
            this.Hexagonal.Name = "Hexagonal";
            this.Hexagonal.Size = new System.Drawing.Size(81, 57);
            this.Hexagonal.TabIndex = 6;
            this.Hexagonal.Text = "HEX";
            this.Hexagonal.UseVisualStyleBackColor = true;
            this.Hexagonal.Click += new System.EventHandler(this.Hex_Click);
            // 
            // Binary
            // 
            this.Binary.Location = new System.Drawing.Point(187, 253);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(81, 58);
            this.Binary.TabIndex = 7;
            this.Binary.Text = "BIN";
            this.Binary.UseVisualStyleBackColor = true;
            this.Binary.Click += new System.EventHandler(this.Binary_Click);
            // 
            // Dec
            // 
            this.Dec.Location = new System.Drawing.Point(361, 253);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(81, 57);
            this.Dec.TabIndex = 8;
            this.Dec.Text = "DEC";
            this.Dec.UseVisualStyleBackColor = true;
            this.Dec.Click += new System.EventHandler(this.Dec_Click);
            // 
            // Oct
            // 
            this.Oct.Location = new System.Drawing.Point(274, 254);
            this.Oct.Name = "Oct";
            this.Oct.Size = new System.Drawing.Size(81, 57);
            this.Oct.TabIndex = 9;
            this.Oct.Text = "OCT";
            this.Oct.UseVisualStyleBackColor = true;
            this.Oct.Click += new System.EventHandler(this.Oct_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Oct);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.Hexagonal);
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
        private System.Windows.Forms.Button Hexagonal;
        private System.Windows.Forms.Button Binary;
        private System.Windows.Forms.Button Dec;
        private System.Windows.Forms.Button Oct;
        private System.Windows.Forms.Button Or;
        private System.Windows.Forms.Button Equal;
    }
}

