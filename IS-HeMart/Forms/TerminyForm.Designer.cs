namespace IS_HeMart.Forms
{
    partial class TerminyForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.terminVysetreniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.terminVysetreniaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.casVysetreniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.poznamkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.zamestnanecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.terminVysetreniaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.terminVysetreniaIDDataGridViewTextBoxColumn,
            this.casVysetreniaDataGridViewTextBoxColumn,
            this.poznamkaDataGridViewTextBoxColumn,
            this.pacientDataGridViewTextBoxColumn,
            this.zamestnanecDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.terminVysetreniaBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 57);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(1019, 499);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(396, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Termíny vyšetrení";
			// 
			// terminVysetreniaBindingSource
			// 
			this.terminVysetreniaBindingSource.DataSource = typeof(IS_HeMart.DataModel.TerminVysetrenia);
			// 
			// terminVysetreniaIDDataGridViewTextBoxColumn
			// 
			this.terminVysetreniaIDDataGridViewTextBoxColumn.DataPropertyName = "TerminVysetreniaID";
			this.terminVysetreniaIDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.terminVysetreniaIDDataGridViewTextBoxColumn.Name = "terminVysetreniaIDDataGridViewTextBoxColumn";
			this.terminVysetreniaIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// casVysetreniaDataGridViewTextBoxColumn
			// 
			this.casVysetreniaDataGridViewTextBoxColumn.DataPropertyName = "CasVysetrenia";
			this.casVysetreniaDataGridViewTextBoxColumn.HeaderText = "CasVysetrenia";
			this.casVysetreniaDataGridViewTextBoxColumn.Name = "casVysetreniaDataGridViewTextBoxColumn";
			this.casVysetreniaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// poznamkaDataGridViewTextBoxColumn
			// 
			this.poznamkaDataGridViewTextBoxColumn.DataPropertyName = "Poznamka";
			this.poznamkaDataGridViewTextBoxColumn.HeaderText = "Poznamka";
			this.poznamkaDataGridViewTextBoxColumn.Name = "poznamkaDataGridViewTextBoxColumn";
			this.poznamkaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pacientDataGridViewTextBoxColumn
			// 
			this.pacientDataGridViewTextBoxColumn.DataPropertyName = "Pacient";
			this.pacientDataGridViewTextBoxColumn.HeaderText = "Pacient";
			this.pacientDataGridViewTextBoxColumn.Name = "pacientDataGridViewTextBoxColumn";
			this.pacientDataGridViewTextBoxColumn.ReadOnly = true;
			this.pacientDataGridViewTextBoxColumn.Visible = false;
			// 
			// zamestnanecDataGridViewTextBoxColumn
			// 
			this.zamestnanecDataGridViewTextBoxColumn.DataPropertyName = "Zamestnanec";
			this.zamestnanecDataGridViewTextBoxColumn.HeaderText = "Zamestnanec";
			this.zamestnanecDataGridViewTextBoxColumn.Name = "zamestnanecDataGridViewTextBoxColumn";
			this.zamestnanecDataGridViewTextBoxColumn.ReadOnly = true;
			this.zamestnanecDataGridViewTextBoxColumn.Visible = false;
			// 
			// TerminyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1045, 569);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "TerminyForm";
			this.Text = "TerminyForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.terminVysetreniaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn terminVysetreniaIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn casVysetreniaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn poznamkaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pacientDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn zamestnanecDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource terminVysetreniaBindingSource;
	}
}