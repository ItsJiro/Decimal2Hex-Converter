namespace Dec2Hex
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ToConvert = new System.Windows.Forms.TextBox();
            this.Converted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Created by ItsJiro";
            // 
            // ToConvert
            // 
            this.ToConvert.BackColor = System.Drawing.SystemColors.Control;
            this.ToConvert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToConvert.Location = new System.Drawing.Point(64, 20);
            this.ToConvert.MaxLength = 2147483647;
            this.ToConvert.Name = "ToConvert";
            this.ToConvert.Size = new System.Drawing.Size(119, 20);
            this.ToConvert.TabIndex = 6;
            this.ToConvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToConvert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToConvert_KeyPress);
            // 
            // Converted
            // 
            this.Converted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Converted.Location = new System.Drawing.Point(64, 58);
            this.Converted.MaxLength = 2147483647;
            this.Converted.Name = "Converted";
            this.Converted.ReadOnly = true;
            this.Converted.Size = new System.Drawing.Size(119, 20);
            this.Converted.TabIndex = 7;
            this.Converted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 137);
            this.Controls.Add(this.Converted);
            this.Controls.Add(this.ToConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Decimal To Hex 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ToConvert;
        private System.Windows.Forms.TextBox Converted;
    }
}

