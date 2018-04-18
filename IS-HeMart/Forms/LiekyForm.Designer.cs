using IS_HeMart.Utils;

namespace IS_HeMart.Forms
{
    partial class LiekyForm
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
            this.dataGridView1 = new IS_HeMart.Utils.CustomDataGridView();
            this.zoznamLiekovIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suklkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doplnokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamestnanecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoznamLiekovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nazovText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoznamLiekovBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.zoznamLiekovIDDataGridViewTextBoxColumn,
            this.suklkodDataGridViewTextBoxColumn,
            this.nazovDataGridViewTextBoxColumn,
            this.doplnokDataGridViewTextBoxColumn,
            this.zamestnanecDataGridViewTextBoxColumn,
            this.receptyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zoznamLiekovBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(784, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // zoznamLiekovIDDataGridViewTextBoxColumn
            // 
            this.zoznamLiekovIDDataGridViewTextBoxColumn.DataPropertyName = "ZoznamLiekovID";
            this.zoznamLiekovIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.zoznamLiekovIDDataGridViewTextBoxColumn.Name = "zoznamLiekovIDDataGridViewTextBoxColumn";
            this.zoznamLiekovIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suklkodDataGridViewTextBoxColumn
            // 
            this.suklkodDataGridViewTextBoxColumn.DataPropertyName = "Sukl_kod";
            this.suklkodDataGridViewTextBoxColumn.HeaderText = "Sukl_kod";
            this.suklkodDataGridViewTextBoxColumn.Name = "suklkodDataGridViewTextBoxColumn";
            this.suklkodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazovDataGridViewTextBoxColumn
            // 
            this.nazovDataGridViewTextBoxColumn.DataPropertyName = "Nazov";
            this.nazovDataGridViewTextBoxColumn.HeaderText = "Nazov";
            this.nazovDataGridViewTextBoxColumn.Name = "nazovDataGridViewTextBoxColumn";
            this.nazovDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doplnokDataGridViewTextBoxColumn
            // 
            this.doplnokDataGridViewTextBoxColumn.DataPropertyName = "Doplnok";
            this.doplnokDataGridViewTextBoxColumn.HeaderText = "Doplnok";
            this.doplnokDataGridViewTextBoxColumn.Name = "doplnokDataGridViewTextBoxColumn";
            this.doplnokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zamestnanecDataGridViewTextBoxColumn
            // 
            this.zamestnanecDataGridViewTextBoxColumn.DataPropertyName = "Zamestnanec";
            this.zamestnanecDataGridViewTextBoxColumn.HeaderText = "Zamestnanec";
            this.zamestnanecDataGridViewTextBoxColumn.Name = "zamestnanecDataGridViewTextBoxColumn";
            this.zamestnanecDataGridViewTextBoxColumn.ReadOnly = true;
            this.zamestnanecDataGridViewTextBoxColumn.Visible = false;
            // 
            // receptyDataGridViewTextBoxColumn
            // 
            this.receptyDataGridViewTextBoxColumn.DataPropertyName = "Recepty";
            this.receptyDataGridViewTextBoxColumn.HeaderText = "Recepty";
            this.receptyDataGridViewTextBoxColumn.Name = "receptyDataGridViewTextBoxColumn";
            this.receptyDataGridViewTextBoxColumn.ReadOnly = true;
            this.receptyDataGridViewTextBoxColumn.Visible = false;
            // 
            // zoznamLiekovBindingSource
            // 
            this.zoznamLiekovBindingSource.DataSource = typeof(IS_HeMart.DataModel.ZoznamLiekov);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zoznam liekov";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nazovText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 452);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 62);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vyhľadávanie ";
            // 
            // nazovText
            // 
            this.nazovText.Location = new System.Drawing.Point(184, 23);
            this.nazovText.Name = "nazovText";
            this.nazovText.Size = new System.Drawing.Size(187, 20);
            this.nazovText.TabIndex = 1;
            this.nazovText.TextChanged += new System.EventHandler(this.nazovText_TextChanged);
            this.nazovText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nazovText_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Názov lieku :";
            // 
            // LiekyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LiekyForm";
            this.Text = "LiekyForm";
            this.Load += new System.EventHandler(this.LiekyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoznamLiekovBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nazovText;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn zoznamLiekovIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn suklkodDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nazovDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn doplnokDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn zamestnanecDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn receptyDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource zoznamLiekovBindingSource;
	}
}