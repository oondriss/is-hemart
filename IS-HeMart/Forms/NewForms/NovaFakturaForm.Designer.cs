namespace IS_HeMart.Forms.NewForms
{
    partial class NovaFakturaForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.kon_symText = new System.Windows.Forms.TextBox();
			this.var_symText = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.rokCombo = new System.Windows.Forms.ComboBox();
			this.mesiacCombo = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.zpCombo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.vystavButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(231, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nová faktúra";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.kon_symText);
			this.groupBox1.Controls.Add(this.var_symText);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.rokCombo);
			this.groupBox1.Controls.Add(this.mesiacCombo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.zpCombo);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(3, 65);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(627, 306);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Detaily";
			// 
			// kon_symText
			// 
			this.kon_symText.Location = new System.Drawing.Point(197, 235);
			this.kon_symText.Margin = new System.Windows.Forms.Padding(4);
			this.kon_symText.Name = "kon_symText";
			this.kon_symText.Size = new System.Drawing.Size(259, 22);
			this.kon_symText.TabIndex = 11;
			// 
			// var_symText
			// 
			this.var_symText.Location = new System.Drawing.Point(197, 192);
			this.var_symText.Margin = new System.Windows.Forms.Padding(4);
			this.var_symText.Name = "var_symText";
			this.var_symText.Size = new System.Drawing.Size(259, 22);
			this.var_symText.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(55, 239);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 17);
			this.label6.TabIndex = 9;
			this.label6.Text = "Konštantný symbol :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(65, 196);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(126, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "Variabilný symbol :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(145, 150);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Rok :";
			// 
			// rokCombo
			// 
			this.rokCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.rokCombo.FormattingEnabled = true;
			this.rokCombo.Location = new System.Drawing.Point(197, 146);
			this.rokCombo.Margin = new System.Windows.Forms.Padding(4);
			this.rokCombo.Name = "rokCombo";
			this.rokCombo.Size = new System.Drawing.Size(259, 24);
			this.rokCombo.TabIndex = 6;
			// 
			// mesiacCombo
			// 
			this.mesiacCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.mesiacCombo.FormattingEnabled = true;
			this.mesiacCombo.Items.AddRange(new object[] {
            "Január",
            "Február",
            "Marec ",
            "Apríl",
            "Máj",
            "Jún",
            "Júl",
            "August",
            "September",
            "Október",
            "November",
            "December"});
			this.mesiacCombo.Location = new System.Drawing.Point(197, 98);
			this.mesiacCombo.Margin = new System.Windows.Forms.Padding(4);
			this.mesiacCombo.Name = "mesiacCombo";
			this.mesiacCombo.Size = new System.Drawing.Size(259, 24);
			this.mesiacCombo.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(127, 102);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Mesiac :";
			// 
			// zpCombo
			// 
			this.zpCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.zpCombo.FormattingEnabled = true;
			this.zpCombo.Location = new System.Drawing.Point(197, 52);
			this.zpCombo.Margin = new System.Windows.Forms.Padding(4);
			this.zpCombo.Name = "zpCombo";
			this.zpCombo.Size = new System.Drawing.Size(259, 24);
			this.zpCombo.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 55);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Zdravotná poisťovňa :";
			// 
			// vystavButton
			// 
			this.vystavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.vystavButton.Location = new System.Drawing.Point(213, 379);
			this.vystavButton.Margin = new System.Windows.Forms.Padding(4);
			this.vystavButton.Name = "vystavButton";
			this.vystavButton.Size = new System.Drawing.Size(220, 68);
			this.vystavButton.TabIndex = 2;
			this.vystavButton.Text = "Vystav faktúru";
			this.vystavButton.UseVisualStyleBackColor = true;
			this.vystavButton.Click += new System.EventHandler(this.vystavButton_Click);
			// 
			// NovaFakturaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 465);
			this.Controls.Add(this.vystavButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "NovaFakturaForm";
			this.Text = "NovaFakturaForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox zpCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button vystavButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rokCombo;
        private System.Windows.Forms.ComboBox mesiacCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kon_symText;
        private System.Windows.Forms.TextBox var_symText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}