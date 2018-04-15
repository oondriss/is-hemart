namespace IS_HeMart.Forms
{
    partial class UkonyForm
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
			this.components = new System.ComponentModel.Container();
			this.label11 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.kod_ukText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.vyhladajButton = new System.Windows.Forms.Button();
			this.zoznamUkonovBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.zoznamUkonovIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nazovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.popisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.zamestnanecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ukonyPacientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.zoznamUkonovBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label11.Location = new System.Drawing.Point(479, 11);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(92, 31);
			this.label11.TabIndex = 29;
			this.label11.Text = "Úkony";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zoznamUkonovIDDataGridViewTextBoxColumn,
            this.nazovDataGridViewTextBoxColumn,
            this.popisDataGridViewTextBoxColumn,
            this.bodyDataGridViewTextBoxColumn,
            this.zamestnanecDataGridViewTextBoxColumn,
            this.ukonyPacientaDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.zoznamUkonovBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(-1, 46);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(1045, 494);
			this.dataGridView1.TabIndex = 25;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.kod_ukText);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(-1, 546);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(633, 76);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Vyhľadávanie ";
			// 
			// kod_ukText
			// 
			this.kod_ukText.Location = new System.Drawing.Point(245, 28);
			this.kod_ukText.Margin = new System.Windows.Forms.Padding(4);
			this.kod_ukText.Name = "kod_ukText";
			this.kod_ukText.Size = new System.Drawing.Size(248, 22);
			this.kod_ukText.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(121, 32);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kód úkonu :";
			// 
			// vyhladajButton
			// 
			this.vyhladajButton.Location = new System.Drawing.Point(703, 559);
			this.vyhladajButton.Margin = new System.Windows.Forms.Padding(4);
			this.vyhladajButton.Name = "vyhladajButton";
			this.vyhladajButton.Size = new System.Drawing.Size(269, 55);
			this.vyhladajButton.TabIndex = 31;
			this.vyhladajButton.Text = "Vyhľadaj úkon ";
			this.vyhladajButton.UseVisualStyleBackColor = true;
			// 
			// zoznamUkonovBindingSource
			// 
			this.zoznamUkonovBindingSource.DataSource = typeof(IS_HeMart.DataModel.ZoznamUkonov);
			// 
			// zoznamUkonovIDDataGridViewTextBoxColumn
			// 
			this.zoznamUkonovIDDataGridViewTextBoxColumn.DataPropertyName = "ZoznamUkonovID";
			this.zoznamUkonovIDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.zoznamUkonovIDDataGridViewTextBoxColumn.Name = "zoznamUkonovIDDataGridViewTextBoxColumn";
			this.zoznamUkonovIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nazovDataGridViewTextBoxColumn
			// 
			this.nazovDataGridViewTextBoxColumn.DataPropertyName = "Nazov";
			this.nazovDataGridViewTextBoxColumn.HeaderText = "Nazov";
			this.nazovDataGridViewTextBoxColumn.Name = "nazovDataGridViewTextBoxColumn";
			this.nazovDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// popisDataGridViewTextBoxColumn
			// 
			this.popisDataGridViewTextBoxColumn.DataPropertyName = "Popis";
			this.popisDataGridViewTextBoxColumn.HeaderText = "Popis";
			this.popisDataGridViewTextBoxColumn.Name = "popisDataGridViewTextBoxColumn";
			this.popisDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bodyDataGridViewTextBoxColumn
			// 
			this.bodyDataGridViewTextBoxColumn.DataPropertyName = "Body";
			this.bodyDataGridViewTextBoxColumn.HeaderText = "Body";
			this.bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
			this.bodyDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// zamestnanecDataGridViewTextBoxColumn
			// 
			this.zamestnanecDataGridViewTextBoxColumn.DataPropertyName = "Zamestnanec";
			this.zamestnanecDataGridViewTextBoxColumn.HeaderText = "Zamestnanec";
			this.zamestnanecDataGridViewTextBoxColumn.Name = "zamestnanecDataGridViewTextBoxColumn";
			this.zamestnanecDataGridViewTextBoxColumn.ReadOnly = true;
			this.zamestnanecDataGridViewTextBoxColumn.Visible = false;
			// 
			// ukonyPacientaDataGridViewTextBoxColumn
			// 
			this.ukonyPacientaDataGridViewTextBoxColumn.DataPropertyName = "UkonyPacienta";
			this.ukonyPacientaDataGridViewTextBoxColumn.HeaderText = "UkonyPacienta";
			this.ukonyPacientaDataGridViewTextBoxColumn.Name = "ukonyPacientaDataGridViewTextBoxColumn";
			this.ukonyPacientaDataGridViewTextBoxColumn.ReadOnly = true;
			this.ukonyPacientaDataGridViewTextBoxColumn.Visible = false;
			// 
			// UkonyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1045, 630);
			this.Controls.Add(this.vyhladajButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UkonyForm";
			this.Text = "UkonyForm";
			this.Load += new System.EventHandler(this.UkonyForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.zoznamUkonovBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kod_ukText;
        private System.Windows.Forms.Button vyhladajButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn zoznamUkonovIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nazovDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn popisDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn zamestnanecDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ukonyPacientaDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource zoznamUkonovBindingSource;
	}
}