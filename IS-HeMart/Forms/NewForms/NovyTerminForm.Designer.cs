﻿namespace IS_HeMart.Forms.NewForms
{
    partial class NovyTerminForm
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
			this.label11 = new System.Windows.Forms.Label();
			this.pridatButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.popisText = new System.Windows.Forms.TextBox();
			this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Cursor = System.Windows.Forms.Cursors.No;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label11.Location = new System.Drawing.Point(315, 11);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(210, 31);
			this.label11.TabIndex = 26;
			this.label11.Text = "Pridanie termínu";
			// 
			// pridatButton
			// 
			this.pridatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.pridatButton.Location = new System.Drawing.Point(321, 287);
			this.pridatButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pridatButton.Name = "pridatButton";
			this.pridatButton.Size = new System.Drawing.Size(224, 60);
			this.pridatButton.TabIndex = 27;
			this.pridatButton.Text = "Pridať termín";
			this.pridatButton.UseVisualStyleBackColor = true;
			this.pridatButton.Click += new System.EventHandler(this.pridatButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.popisText);
			this.groupBox1.Controls.Add(this.datumDateTimePicker);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(4, 63);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(837, 217);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "detaily";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(515, 37);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Poznámka";
			// 
			// popisText
			// 
			this.popisText.Location = new System.Drawing.Point(519, 57);
			this.popisText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.popisText.Multiline = true;
			this.popisText.Name = "popisText";
			this.popisText.Size = new System.Drawing.Size(308, 139);
			this.popisText.TabIndex = 4;
			// 
			// datumDateTimePicker
			// 
			this.datumDateTimePicker.Location = new System.Drawing.Point(216, 57);
			this.datumDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.datumDateTimePicker.Name = "datumDateTimePicker";
			this.datumDateTimePicker.Size = new System.Drawing.Size(272, 22);
			this.datumDateTimePicker.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(79, 128);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Čas vyšetrenia :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 64);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dátum vyšetrenia : ";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker1.Location = new System.Drawing.Point(216, 128);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(272, 22);
			this.dateTimePicker1.TabIndex = 6;
			// 
			// NovyTerminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(847, 369);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pridatButton);
			this.Controls.Add(this.label11);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "NovyTerminForm";
			this.Text = "NovyTerminForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button pridatButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.TextBox popisText;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}