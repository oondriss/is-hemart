﻿namespace IS_HeMart.Forms.NewForms
{
    partial class NovaZiadankaForm
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
            this.vystavButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.popisText = new System.Windows.Forms.TextBox();
            this.typCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.No;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(159, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Vystavenie žiadanky";
            // 
            // vystavButton
            // 
            this.vystavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vystavButton.Location = new System.Drawing.Point(179, 279);
            this.vystavButton.Name = "vystavButton";
            this.vystavButton.Size = new System.Drawing.Size(167, 46);
            this.vystavButton.TabIndex = 31;
            this.vystavButton.Text = "Vystaviť žiadanku";
            this.vystavButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.popisText);
            this.groupBox1.Controls.Add(this.typCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 214);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detaily";
            // 
            // popisText
            // 
            this.popisText.Location = new System.Drawing.Point(253, 39);
            this.popisText.Multiline = true;
            this.popisText.Name = "popisText";
            this.popisText.Size = new System.Drawing.Size(253, 150);
            this.popisText.TabIndex = 3;
            // 
            // typCombo
            // 
            this.typCombo.FormattingEnabled = true;
            this.typCombo.Location = new System.Drawing.Point(93, 39);
            this.typCombo.Name = "typCombo";
            this.typCombo.Size = new System.Drawing.Size(121, 21);
            this.typCombo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Popis : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Typ žiadanky :";
            // 
            // NovaZiadankaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 332);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vystavButton);
            this.Controls.Add(this.label11);
            this.Name = "NovaZiadankaForm";
            this.Text = "NovaZiadankaForm";
            this.Load += new System.EventHandler(this.NovaZiadankaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button vystavButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox popisText;
        private System.Windows.Forms.ComboBox typCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}