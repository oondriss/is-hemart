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
            this.zoznamUkonovBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.zoznamUkonovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kod_ukText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zoznamUkonovBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zdravotnaPoistovnaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zoznamUkonovIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamestnanecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukonyPacientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoznamUkonovBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoznamUkonovBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoznamUkonovBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdravotnaPoistovnaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(359, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "Úkony";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zoznamUkonovIDDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.nazovDataGridViewTextBoxColumn,
            this.popisDataGridViewTextBoxColumn,
            this.bodyDataGridViewTextBoxColumn,
            this.zamestnanecDataGridViewTextBoxColumn,
            this.ukonyPacientaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zoznamUkonovBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(784, 401);
            this.dataGridView1.TabIndex = 25;
            // 
            // zoznamUkonovBindingSource2
            // 
            this.zoznamUkonovBindingSource2.DataSource = typeof(IS_HeMart.DataModel.ZoznamUkonov);
            // 
            // zoznamUkonovBindingSource
            // 
            this.zoznamUkonovBindingSource.DataSource = typeof(IS_HeMart.DataModel.ZoznamUkonov);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kod_ukText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(157, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 62);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vyhľadávanie ";
            // 
            // kod_ukText
            // 
            this.kod_ukText.Location = new System.Drawing.Point(216, 23);
            this.kod_ukText.Name = "kod_ukText";
            this.kod_ukText.Size = new System.Drawing.Size(187, 20);
            this.kod_ukText.TabIndex = 1;
            this.kod_ukText.TextChanged += new System.EventHandler(this.kod_ukText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Názov / Kód úkonu :";
            // 
            // zoznamUkonovBindingSource1
            // 
            this.zoznamUkonovBindingSource1.DataSource = typeof(IS_HeMart.DataModel.ZoznamUkonov);
            // 
            // zdravotnaPoistovnaBindingSource
            // 
            this.zdravotnaPoistovnaBindingSource.DataSource = typeof(IS_HeMart.DataModel.ZdravotnaPoistovna);
            // 
            // zoznamUkonovIDDataGridViewTextBoxColumn
            // 
            this.zoznamUkonovIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.zoznamUkonovIDDataGridViewTextBoxColumn.DataPropertyName = "ZoznamUkonovID";
            this.zoznamUkonovIDDataGridViewTextBoxColumn.FillWeight = 43.10569F;
            this.zoznamUkonovIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.zoznamUkonovIDDataGridViewTextBoxColumn.Name = "zoznamUkonovIDDataGridViewTextBoxColumn";
            this.zoznamUkonovIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.zoznamUkonovIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.FillWeight = 2.551907F;
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazovDataGridViewTextBoxColumn
            // 
            this.nazovDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nazovDataGridViewTextBoxColumn.DataPropertyName = "Nazov";
            this.nazovDataGridViewTextBoxColumn.FillWeight = 449.2386F;
            this.nazovDataGridViewTextBoxColumn.HeaderText = "Nazov";
            this.nazovDataGridViewTextBoxColumn.Name = "nazovDataGridViewTextBoxColumn";
            this.nazovDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazovDataGridViewTextBoxColumn.Width = 250;
            // 
            // popisDataGridViewTextBoxColumn
            // 
            this.popisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.popisDataGridViewTextBoxColumn.DataPropertyName = "Popis";
            this.popisDataGridViewTextBoxColumn.FillWeight = 2.551907F;
            this.popisDataGridViewTextBoxColumn.HeaderText = "Popis";
            this.popisDataGridViewTextBoxColumn.Name = "popisDataGridViewTextBoxColumn";
            this.popisDataGridViewTextBoxColumn.ReadOnly = true;
            this.popisDataGridViewTextBoxColumn.Width = 250;
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            this.bodyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bodyDataGridViewTextBoxColumn.DataPropertyName = "Body";
            this.bodyDataGridViewTextBoxColumn.FillWeight = 2.551907F;
            this.bodyDataGridViewTextBoxColumn.HeaderText = "Body";
            this.bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            this.bodyDataGridViewTextBoxColumn.ReadOnly = true;
            this.bodyDataGridViewTextBoxColumn.Width = 40;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UkonyForm";
            this.Text = "UkonyForm";
            this.Load += new System.EventHandler(this.UkonyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoznamUkonovBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoznamUkonovBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoznamUkonovBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdravotnaPoistovnaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kod_ukText;
		private System.Windows.Forms.BindingSource zoznamUkonovBindingSource;
		private System.Windows.Forms.BindingSource zoznamUkonovBindingSource2;
		private System.Windows.Forms.BindingSource zoznamUkonovBindingSource1;
		private System.Windows.Forms.BindingSource zdravotnaPoistovnaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoznamUkonovIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamestnanecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukonyPacientaDataGridViewTextBoxColumn;
    }
}