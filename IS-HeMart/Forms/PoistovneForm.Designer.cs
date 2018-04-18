namespace IS_HeMart.Forms
{
    partial class PoistovneForm
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
            this.zdravotnaPoistovnaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.zdravotnaPoistovnaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nazovText = new System.Windows.Forms.TextBox();
            this.mestoText = new System.Windows.Forms.TextBox();
            this.ulicaText = new System.Windows.Forms.TextBox();
            this.cisloText = new System.Windows.Forms.TextBox();
            this.pscText = new System.Windows.Forms.TextBox();
            this.kod_zpText = new System.Windows.Forms.TextBox();
            this.icoText = new System.Windows.Forms.TextBox();
            this.dicText = new System.Windows.Forms.TextBox();
            this.ic_dphText = new System.Windows.Forms.TextBox();
            this.cislo_ucText = new System.Windows.Forms.TextBox();
            this.ulozitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pridatButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.zdravotnaPoistovnaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zdravotnaPoistovnaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cisloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCDPHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cisloUctuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodZPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamestnanecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakturyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdravotnaPoistovnaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdravotnaPoistovnaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zdravotnaPoistovnaBindingSource1)).BeginInit();
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
            this.zdravotnaPoistovnaIDDataGridViewTextBoxColumn,
            this.nazovDataGridViewTextBoxColumn,
            this.mestoDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.pscDataGridViewTextBoxColumn,
            this.cisloDataGridViewTextBoxColumn,
            this.iCODataGridViewTextBoxColumn,
            this.dICDataGridViewTextBoxColumn,
            this.iCDPHDataGridViewTextBoxColumn,
            this.cisloUctuDataGridViewTextBoxColumn,
            this.kodZPDataGridViewTextBoxColumn,
            this.zamestnanecDataGridViewTextBoxColumn,
            this.pacientiDataGridViewTextBoxColumn,
            this.fakturyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zdravotnaPoistovnaBindingSource2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(7, 51);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(781, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // zdravotnaPoistovnaBindingSource2
            // 
            this.zdravotnaPoistovnaBindingSource2.DataSource = typeof(IS_HeMart.DataModel.ZdravotnaPoistovna);
            // 
            // zdravotnaPoistovnaBindingSource
            // 
            this.zdravotnaPoistovnaBindingSource.DataSource = typeof(IS_HeMart.DataModel.ZdravotnaPoistovna);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Názov :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mesto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ulica :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Číslo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Psč : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kód ZP : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "IČO : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "DIČ :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "IČ_DPH :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Číslo účtu :";
            // 
            // nazovText
            // 
            this.nazovText.Location = new System.Drawing.Point(91, 34);
            this.nazovText.Name = "nazovText";
            this.nazovText.Size = new System.Drawing.Size(238, 20);
            this.nazovText.TabIndex = 11;
            // 
            // mestoText
            // 
            this.mestoText.Location = new System.Drawing.Point(91, 66);
            this.mestoText.Name = "mestoText";
            this.mestoText.Size = new System.Drawing.Size(238, 20);
            this.mestoText.TabIndex = 12;
            // 
            // ulicaText
            // 
            this.ulicaText.Location = new System.Drawing.Point(91, 99);
            this.ulicaText.Name = "ulicaText";
            this.ulicaText.Size = new System.Drawing.Size(238, 20);
            this.ulicaText.TabIndex = 13;
            // 
            // cisloText
            // 
            this.cisloText.Location = new System.Drawing.Point(91, 132);
            this.cisloText.Name = "cisloText";
            this.cisloText.Size = new System.Drawing.Size(238, 20);
            this.cisloText.TabIndex = 14;
            // 
            // pscText
            // 
            this.pscText.Location = new System.Drawing.Point(91, 162);
            this.pscText.Name = "pscText";
            this.pscText.Size = new System.Drawing.Size(238, 20);
            this.pscText.TabIndex = 15;
            // 
            // kod_zpText
            // 
            this.kod_zpText.Location = new System.Drawing.Point(416, 33);
            this.kod_zpText.Name = "kod_zpText";
            this.kod_zpText.Size = new System.Drawing.Size(234, 20);
            this.kod_zpText.TabIndex = 16;
            // 
            // icoText
            // 
            this.icoText.Location = new System.Drawing.Point(416, 66);
            this.icoText.Name = "icoText";
            this.icoText.Size = new System.Drawing.Size(234, 20);
            this.icoText.TabIndex = 17;
            // 
            // dicText
            // 
            this.dicText.Location = new System.Drawing.Point(416, 99);
            this.dicText.Name = "dicText";
            this.dicText.Size = new System.Drawing.Size(234, 20);
            this.dicText.TabIndex = 18;
            this.dicText.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // ic_dphText
            // 
            this.ic_dphText.Location = new System.Drawing.Point(416, 132);
            this.ic_dphText.Name = "ic_dphText";
            this.ic_dphText.Size = new System.Drawing.Size(234, 20);
            this.ic_dphText.TabIndex = 19;
            // 
            // cislo_ucText
            // 
            this.cislo_ucText.Location = new System.Drawing.Point(416, 162);
            this.cislo_ucText.Name = "cislo_ucText";
            this.cislo_ucText.Size = new System.Drawing.Size(234, 20);
            this.cislo_ucText.TabIndex = 20;
            // 
            // ulozitButton
            // 
            this.ulozitButton.Location = new System.Drawing.Point(713, 397);
            this.ulozitButton.Name = "ulozitButton";
            this.ulozitButton.Size = new System.Drawing.Size(75, 46);
            this.ulozitButton.TabIndex = 21;
            this.ulozitButton.Text = "Uložiť zmeny";
            this.ulozitButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cislo_ucText);
            this.groupBox1.Controls.Add(this.ic_dphText);
            this.groupBox1.Controls.Add(this.dicText);
            this.groupBox1.Controls.Add(this.icoText);
            this.groupBox1.Controls.Add(this.kod_zpText);
            this.groupBox1.Controls.Add(this.pscText);
            this.groupBox1.Controls.Add(this.cisloText);
            this.groupBox1.Controls.Add(this.ulicaText);
            this.groupBox1.Controls.Add(this.mestoText);
            this.groupBox1.Controls.Add(this.nazovText);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 203);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detaily";
            // 
            // pridatButton
            // 
            this.pridatButton.Location = new System.Drawing.Point(713, 343);
            this.pridatButton.Name = "pridatButton";
            this.pridatButton.Size = new System.Drawing.Size(75, 38);
            this.pridatButton.TabIndex = 23;
            this.pridatButton.Text = "Pridať poisťovňu";
            this.pridatButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(334, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Poisťovne";
            // 
            // zdravotnaPoistovnaBindingSource1
            // 
            this.zdravotnaPoistovnaBindingSource1.DataSource = typeof(IS_HeMart.DataModel.ZdravotnaPoistovna);
            // 
            // zdravotnaPoistovnaIDDataGridViewTextBoxColumn
            // 
            this.zdravotnaPoistovnaIDDataGridViewTextBoxColumn.DataPropertyName = "ZdravotnaPoistovnaID";
            this.zdravotnaPoistovnaIDDataGridViewTextBoxColumn.FillWeight = 20.90317F;
            this.zdravotnaPoistovnaIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.zdravotnaPoistovnaIDDataGridViewTextBoxColumn.Name = "zdravotnaPoistovnaIDDataGridViewTextBoxColumn";
            this.zdravotnaPoistovnaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazovDataGridViewTextBoxColumn
            // 
            this.nazovDataGridViewTextBoxColumn.DataPropertyName = "Nazov";
            this.nazovDataGridViewTextBoxColumn.FillWeight = 152.2843F;
            this.nazovDataGridViewTextBoxColumn.HeaderText = "Nazov";
            this.nazovDataGridViewTextBoxColumn.Name = "nazovDataGridViewTextBoxColumn";
            this.nazovDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mestoDataGridViewTextBoxColumn
            // 
            this.mestoDataGridViewTextBoxColumn.DataPropertyName = "Mesto";
            this.mestoDataGridViewTextBoxColumn.HeaderText = "Mesto";
            this.mestoDataGridViewTextBoxColumn.Name = "mestoDataGridViewTextBoxColumn";
            this.mestoDataGridViewTextBoxColumn.ReadOnly = true;
            this.mestoDataGridViewTextBoxColumn.Visible = false;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ulicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // pscDataGridViewTextBoxColumn
            // 
            this.pscDataGridViewTextBoxColumn.DataPropertyName = "Psc";
            this.pscDataGridViewTextBoxColumn.HeaderText = "Psc";
            this.pscDataGridViewTextBoxColumn.Name = "pscDataGridViewTextBoxColumn";
            this.pscDataGridViewTextBoxColumn.ReadOnly = true;
            this.pscDataGridViewTextBoxColumn.Visible = false;
            // 
            // cisloDataGridViewTextBoxColumn
            // 
            this.cisloDataGridViewTextBoxColumn.DataPropertyName = "Cislo";
            this.cisloDataGridViewTextBoxColumn.HeaderText = "Cislo";
            this.cisloDataGridViewTextBoxColumn.Name = "cisloDataGridViewTextBoxColumn";
            this.cisloDataGridViewTextBoxColumn.ReadOnly = true;
            this.cisloDataGridViewTextBoxColumn.Visible = false;
            // 
            // iCODataGridViewTextBoxColumn
            // 
            this.iCODataGridViewTextBoxColumn.DataPropertyName = "ICO";
            this.iCODataGridViewTextBoxColumn.HeaderText = "ICO";
            this.iCODataGridViewTextBoxColumn.Name = "iCODataGridViewTextBoxColumn";
            this.iCODataGridViewTextBoxColumn.ReadOnly = true;
            this.iCODataGridViewTextBoxColumn.Visible = false;
            // 
            // dICDataGridViewTextBoxColumn
            // 
            this.dICDataGridViewTextBoxColumn.DataPropertyName = "DIC";
            this.dICDataGridViewTextBoxColumn.HeaderText = "DIC";
            this.dICDataGridViewTextBoxColumn.Name = "dICDataGridViewTextBoxColumn";
            this.dICDataGridViewTextBoxColumn.ReadOnly = true;
            this.dICDataGridViewTextBoxColumn.Visible = false;
            // 
            // iCDPHDataGridViewTextBoxColumn
            // 
            this.iCDPHDataGridViewTextBoxColumn.DataPropertyName = "IC_DPH";
            this.iCDPHDataGridViewTextBoxColumn.HeaderText = "IC_DPH";
            this.iCDPHDataGridViewTextBoxColumn.Name = "iCDPHDataGridViewTextBoxColumn";
            this.iCDPHDataGridViewTextBoxColumn.ReadOnly = true;
            this.iCDPHDataGridViewTextBoxColumn.Visible = false;
            // 
            // cisloUctuDataGridViewTextBoxColumn
            // 
            this.cisloUctuDataGridViewTextBoxColumn.DataPropertyName = "CisloUctu";
            this.cisloUctuDataGridViewTextBoxColumn.HeaderText = "CisloUctu";
            this.cisloUctuDataGridViewTextBoxColumn.Name = "cisloUctuDataGridViewTextBoxColumn";
            this.cisloUctuDataGridViewTextBoxColumn.ReadOnly = true;
            this.cisloUctuDataGridViewTextBoxColumn.Visible = false;
            // 
            // kodZPDataGridViewTextBoxColumn
            // 
            this.kodZPDataGridViewTextBoxColumn.DataPropertyName = "Kod_ZP";
            this.kodZPDataGridViewTextBoxColumn.FillWeight = 126.8126F;
            this.kodZPDataGridViewTextBoxColumn.HeaderText = "Kod_ZP";
            this.kodZPDataGridViewTextBoxColumn.Name = "kodZPDataGridViewTextBoxColumn";
            this.kodZPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zamestnanecDataGridViewTextBoxColumn
            // 
            this.zamestnanecDataGridViewTextBoxColumn.DataPropertyName = "Zamestnanec";
            this.zamestnanecDataGridViewTextBoxColumn.HeaderText = "Zamestnanec";
            this.zamestnanecDataGridViewTextBoxColumn.Name = "zamestnanecDataGridViewTextBoxColumn";
            this.zamestnanecDataGridViewTextBoxColumn.ReadOnly = true;
            this.zamestnanecDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacientiDataGridViewTextBoxColumn
            // 
            this.pacientiDataGridViewTextBoxColumn.DataPropertyName = "Pacienti";
            this.pacientiDataGridViewTextBoxColumn.HeaderText = "Pacienti";
            this.pacientiDataGridViewTextBoxColumn.Name = "pacientiDataGridViewTextBoxColumn";
            this.pacientiDataGridViewTextBoxColumn.ReadOnly = true;
            this.pacientiDataGridViewTextBoxColumn.Visible = false;
            // 
            // fakturyDataGridViewTextBoxColumn
            // 
            this.fakturyDataGridViewTextBoxColumn.DataPropertyName = "Faktury";
            this.fakturyDataGridViewTextBoxColumn.HeaderText = "Faktury";
            this.fakturyDataGridViewTextBoxColumn.Name = "fakturyDataGridViewTextBoxColumn";
            this.fakturyDataGridViewTextBoxColumn.ReadOnly = true;
            this.fakturyDataGridViewTextBoxColumn.Visible = false;
            // 
            // PoistovneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pridatButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ulozitButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PoistovneForm";
            this.Text = "PoistovneForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdravotnaPoistovnaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdravotnaPoistovnaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zdravotnaPoistovnaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nazovText;
        private System.Windows.Forms.TextBox mestoText;
        private System.Windows.Forms.TextBox ulicaText;
        private System.Windows.Forms.TextBox cisloText;
        private System.Windows.Forms.TextBox pscText;
        private System.Windows.Forms.TextBox kod_zpText;
        private System.Windows.Forms.TextBox icoText;
        private System.Windows.Forms.TextBox dicText;
        private System.Windows.Forms.TextBox ic_dphText;
        private System.Windows.Forms.TextBox cislo_ucText;
        private System.Windows.Forms.Button ulozitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pridatButton;
        private System.Windows.Forms.Label label11;
		private System.Windows.Forms.BindingSource zdravotnaPoistovnaBindingSource;
		private System.Windows.Forms.BindingSource zdravotnaPoistovnaBindingSource1;
		private System.Windows.Forms.BindingSource zdravotnaPoistovnaBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdravotnaPoistovnaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cisloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCDPHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cisloUctuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodZPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamestnanecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakturyDataGridViewTextBoxColumn;
    }
}