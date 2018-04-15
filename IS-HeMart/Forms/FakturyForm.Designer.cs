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
			this.components = new System.ComponentModel.Container();
			this.fakturaGrid = new System.Windows.Forms.DataGridView();
			this.fakturyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.vytvorButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.fakturyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datumVystaveniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datumSplatnostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.varSymbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.konSymbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.poistovnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vystavilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ukonyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.fakturaGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fakturyBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// fakturaGrid
			// 
			this.fakturaGrid.AllowUserToAddRows = false;
			this.fakturaGrid.AllowUserToDeleteRows = false;
			this.fakturaGrid.AutoGenerateColumns = false;
			this.fakturaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.fakturaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.fakturaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fakturyIDDataGridViewTextBoxColumn,
            this.datumVystaveniaDataGridViewTextBoxColumn,
            this.datumSplatnostiDataGridViewTextBoxColumn,
            this.varSymbolDataGridViewTextBoxColumn,
            this.konSymbolDataGridViewTextBoxColumn,
            this.poistovnaDataGridViewTextBoxColumn,
            this.vystavilDataGridViewTextBoxColumn,
            this.ukonyDataGridViewTextBoxColumn});
			this.fakturaGrid.DataSource = this.fakturyBindingSource;
			this.fakturaGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.fakturaGrid.Location = new System.Drawing.Point(-1, 58);
			this.fakturaGrid.Margin = new System.Windows.Forms.Padding(4);
			this.fakturaGrid.MultiSelect = false;
			this.fakturaGrid.Name = "fakturaGrid";
			this.fakturaGrid.ReadOnly = true;
			this.fakturaGrid.RowHeadersVisible = false;
			this.fakturaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.fakturaGrid.Size = new System.Drawing.Size(867, 519);
			this.fakturaGrid.TabIndex = 0;
			// 
			// fakturyBindingSource
			// 
			this.fakturyBindingSource.DataSource = typeof(IS_HeMart.DataModel.Faktury);
			// 
			// vytvorButton
			// 
			this.vytvorButton.Location = new System.Drawing.Point(337, 585);
			this.vytvorButton.Margin = new System.Windows.Forms.Padding(4);
			this.vytvorButton.Name = "vytvorButton";
			this.vytvorButton.Size = new System.Drawing.Size(160, 53);
			this.vytvorButton.TabIndex = 1;
			this.vytvorButton.Text = "Vytvor faktúru";
			this.vytvorButton.UseVisualStyleBackColor = true;
			this.vytvorButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(349, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "Faktúry";
			// 
			// fakturyIDDataGridViewTextBoxColumn
			// 
			this.fakturyIDDataGridViewTextBoxColumn.DataPropertyName = "FakturyID";
			this.fakturyIDDataGridViewTextBoxColumn.HeaderText = "FakturyID";
			this.fakturyIDDataGridViewTextBoxColumn.Name = "fakturyIDDataGridViewTextBoxColumn";
			this.fakturyIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// datumVystaveniaDataGridViewTextBoxColumn
			// 
			this.datumVystaveniaDataGridViewTextBoxColumn.DataPropertyName = "DatumVystavenia";
			this.datumVystaveniaDataGridViewTextBoxColumn.HeaderText = "DatumVystavenia";
			this.datumVystaveniaDataGridViewTextBoxColumn.Name = "datumVystaveniaDataGridViewTextBoxColumn";
			this.datumVystaveniaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// datumSplatnostiDataGridViewTextBoxColumn
			// 
			this.datumSplatnostiDataGridViewTextBoxColumn.DataPropertyName = "DatumSplatnosti";
			this.datumSplatnostiDataGridViewTextBoxColumn.HeaderText = "DatumSplatnosti";
			this.datumSplatnostiDataGridViewTextBoxColumn.Name = "datumSplatnostiDataGridViewTextBoxColumn";
			this.datumSplatnostiDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// varSymbolDataGridViewTextBoxColumn
			// 
			this.varSymbolDataGridViewTextBoxColumn.DataPropertyName = "VarSymbol";
			this.varSymbolDataGridViewTextBoxColumn.HeaderText = "VarSymbol";
			this.varSymbolDataGridViewTextBoxColumn.Name = "varSymbolDataGridViewTextBoxColumn";
			this.varSymbolDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// konSymbolDataGridViewTextBoxColumn
			// 
			this.konSymbolDataGridViewTextBoxColumn.DataPropertyName = "KonSymbol";
			this.konSymbolDataGridViewTextBoxColumn.HeaderText = "KonSymbol";
			this.konSymbolDataGridViewTextBoxColumn.Name = "konSymbolDataGridViewTextBoxColumn";
			this.konSymbolDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// poistovnaDataGridViewTextBoxColumn
			// 
			this.poistovnaDataGridViewTextBoxColumn.DataPropertyName = "Poistovna";
			this.poistovnaDataGridViewTextBoxColumn.HeaderText = "Poistovna";
			this.poistovnaDataGridViewTextBoxColumn.Name = "poistovnaDataGridViewTextBoxColumn";
			this.poistovnaDataGridViewTextBoxColumn.ReadOnly = true;
			this.poistovnaDataGridViewTextBoxColumn.Visible = false;
			// 
			// vystavilDataGridViewTextBoxColumn
			// 
			this.vystavilDataGridViewTextBoxColumn.DataPropertyName = "Vystavil";
			this.vystavilDataGridViewTextBoxColumn.HeaderText = "Vystavil";
			this.vystavilDataGridViewTextBoxColumn.Name = "vystavilDataGridViewTextBoxColumn";
			this.vystavilDataGridViewTextBoxColumn.ReadOnly = true;
			this.vystavilDataGridViewTextBoxColumn.Visible = false;
			// 
			// ukonyDataGridViewTextBoxColumn
			// 
			this.ukonyDataGridViewTextBoxColumn.DataPropertyName = "Ukony";
			this.ukonyDataGridViewTextBoxColumn.HeaderText = "Ukony";
			this.ukonyDataGridViewTextBoxColumn.Name = "ukonyDataGridViewTextBoxColumn";
			this.ukonyDataGridViewTextBoxColumn.ReadOnly = true;
			this.ukonyDataGridViewTextBoxColumn.Visible = false;
			// 
			// FakturyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 642);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.vytvorButton);
			this.Controls.Add(this.fakturaGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FakturyForm";
			this.Text = "FakturyForm";
			this.Load += new System.EventHandler(this.FakturyForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.fakturaGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fakturyBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fakturaGrid;
        private System.Windows.Forms.Button vytvorButton;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource fakturyBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn fakturyIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datumVystaveniaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datumSplatnostiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn varSymbolDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn konSymbolDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn poistovnaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn vystavilDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ukonyDataGridViewTextBoxColumn;
	}
}