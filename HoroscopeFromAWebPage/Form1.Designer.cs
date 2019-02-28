namespace HoroscopeFromAWebPage
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.horoscopeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.Location = new System.Drawing.Point(170, 49);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(120, 32);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load list";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your urlToHoroscope for today:";
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(17, 100);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.Size = new System.Drawing.Size(266, 235);
            this.mainTextBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // horoscopeLabel
            // 
            this.horoscopeLabel.AutoSize = true;
            this.horoscopeLabel.Location = new System.Drawing.Point(17, 54);
            this.horoscopeLabel.Name = "horoscopeLabel";
            this.horoscopeLabel.Size = new System.Drawing.Size(98, 13);
            this.horoscopeLabel.TabIndex = 4;
            this.horoscopeLabel.Text = "your sign of zodiac:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 349);
            this.Controls.Add(this.horoscopeLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Horoscope for today";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label horoscopeLabel;
    }
}

