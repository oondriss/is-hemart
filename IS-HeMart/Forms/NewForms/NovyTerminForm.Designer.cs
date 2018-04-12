namespace IS_HeMart.Forms.NewForms
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
            this.casCombo = new System.Windows.Forms.ComboBox();
            this.datumTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.No;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(99, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Pridanie termínu";
            // 
            // pridatButton
            // 
            this.pridatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatButton.Location = new System.Drawing.Point(118, 233);
            this.pridatButton.Name = "pridatButton";
            this.pridatButton.Size = new System.Drawing.Size(168, 49);
            this.pridatButton.TabIndex = 27;
            this.pridatButton.Text = "Pridať termín";
            this.pridatButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.casCombo);
            this.groupBox1.Controls.Add(this.datumTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 157);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "detaily";
            // 
            // casCombo
            // 
            this.casCombo.FormattingEnabled = true;
            this.casCombo.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "8:30"});
            this.casCombo.Location = new System.Drawing.Point(162, 83);
            this.casCombo.Name = "casCombo";
            this.casCombo.Size = new System.Drawing.Size(205, 21);
            this.casCombo.TabIndex = 3;
            // 
            // datumTimePicker
            // 
            this.datumTimePicker.Location = new System.Drawing.Point(167, 28);
            this.datumTimePicker.Name = "datumTimePicker";
            this.datumTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Čas vyšetrenia :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dátum vyšetrenia : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 114);
            this.textBox1.TabIndex = 4;
            // 
            // NovyTerminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 300);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pridatButton);
            this.Controls.Add(this.label11);
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
        private System.Windows.Forms.DateTimePicker datumTimePicker;
        private System.Windows.Forms.ComboBox casCombo;
        private System.Windows.Forms.TextBox textBox1;
    }
}