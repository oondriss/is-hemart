namespace IS_HeMart.Forms.NewForms
{
    partial class NovyUkonPacientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pocetCombo = new System.Windows.Forms.ComboBox();
            this.kodCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.popisText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.No;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(211, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Pridanie úkonu";
            // 
            // pridatButton
            // 
            this.pridatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatButton.Location = new System.Drawing.Point(216, 374);
            this.pridatButton.Name = "pridatButton";
            this.pridatButton.Size = new System.Drawing.Size(167, 46);
            this.pridatButton.TabIndex = 32;
            this.pridatButton.Text = "Pridať úkon";
            this.pridatButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kód úkonu : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pocetCombo);
            this.groupBox1.Controls.Add(this.kodCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.popisText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 309);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detaily";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Počet :";
            // 
            // pocetCombo
            // 
            this.pocetCombo.FormattingEnabled = true;
            this.pocetCombo.Location = new System.Drawing.Point(91, 126);
            this.pocetCombo.Name = "pocetCombo";
            this.pocetCombo.Size = new System.Drawing.Size(126, 21);
            this.pocetCombo.TabIndex = 39;
            // 
            // kodCombo
            // 
            this.kodCombo.FormattingEnabled = true;
            this.kodCombo.Location = new System.Drawing.Point(91, 62);
            this.kodCombo.Name = "kodCombo";
            this.kodCombo.Size = new System.Drawing.Size(126, 21);
            this.kodCombo.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Popis úkonu : ";
            // 
            // popisText
            // 
            this.popisText.Location = new System.Drawing.Point(252, 62);
            this.popisText.Multiline = true;
            this.popisText.Name = "popisText";
            this.popisText.Size = new System.Drawing.Size(289, 214);
            this.popisText.TabIndex = 34;
            // 
            // NovyUkonPacientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pridatButton);
            this.Controls.Add(this.label11);
            this.Name = "NovyUkonPacientForm";
            this.Text = "NovyUkonPacientForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button pridatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox popisText;
        private System.Windows.Forms.ComboBox kodCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pocetCombo;
    }
}