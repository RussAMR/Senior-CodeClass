namespace Best_winform
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
            this.Something = new System.Windows.Forms.Button();
            this.Checkbox_Failsafe = new System.Windows.Forms.CheckBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Something
            // 
            this.Something.Location = new System.Drawing.Point(287, 90);
            this.Something.Name = "Something";
            this.Something.Size = new System.Drawing.Size(178, 131);
            this.Something.TabIndex = 0;
            this.Something.Text = "Something";
            this.Something.UseVisualStyleBackColor = true;
            this.Something.Click += new System.EventHandler(this.button1_Click);
            // 
            // Checkbox_Failsafe
            // 
            this.Checkbox_Failsafe.AutoSize = true;
            this.Checkbox_Failsafe.Location = new System.Drawing.Point(12, 2);
            this.Checkbox_Failsafe.Name = "Checkbox_Failsafe";
            this.Checkbox_Failsafe.Size = new System.Drawing.Size(64, 17);
            this.Checkbox_Failsafe.TabIndex = 1;
            this.Checkbox_Failsafe.Text = "FailSafe";
            this.Checkbox_Failsafe.UseVisualStyleBackColor = true;
            this.Checkbox_Failsafe.CheckedChanged += new System.EventHandler(this.Checkbox_Failsafe_CheckedChanged);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(588, 418);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 4;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Winform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(481, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 135);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.Checkbox_Failsafe);
            this.Controls.Add(this.Something);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Something;
        private System.Windows.Forms.CheckBox Checkbox_Failsafe;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

