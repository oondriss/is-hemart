namespace IS_HeMart.Forms
{
    partial class FakturyForm
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
            this.fakturaGrid = new System.Windows.Forms.DataGridView();
            this.vytvorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // fakturaGrid
            // 
            this.fakturaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fakturaGrid.Location = new System.Drawing.Point(-1, 47);
            this.fakturaGrid.Name = "fakturaGrid";
            this.fakturaGrid.Size = new System.Drawing.Size(650, 422);
            this.fakturaGrid.TabIndex = 0;
            // 
            // vytvorButton
            // 
            this.vytvorButton.Location = new System.Drawing.Point(253, 475);
            this.vytvorButton.Name = "vytvorButton";
            this.vytvorButton.Size = new System.Drawing.Size(120, 43);
            this.vytvorButton.TabIndex = 1;
            this.vytvorButton.Text = "Vytvor faktúru";
            this.vytvorButton.UseVisualStyleBackColor = true;
            this.vytvorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faktúry";
            // 
            // FakturyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vytvorButton);
            this.Controls.Add(this.fakturaGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FakturyForm";
            this.Text = "FakturyForm";
            this.Load += new System.EventHandler(this.FakturyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fakturaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fakturaGrid;
        private System.Windows.Forms.Button vytvorButton;
        private System.Windows.Forms.Label label1;
    }
}