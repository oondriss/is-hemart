using IS_HeMart.Utils;

namespace IS_HeMart
{
	partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prehľadyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamestnancovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faktúrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liekovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.úkonovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poisťovneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termínyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplikáciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informácieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PermisionLabel = new System.Windows.Forms.Label();
            this.pacientGrid = new IS_HeMart.Utils.CustomDataGridView();
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.findText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pacientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priezviskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodneCisloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumNarodeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVytvoreniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPoslednejZmenyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilneCisloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pridruzenaDiagnozaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cisloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zmazanyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.zdravotnaPoistovnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukonyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ziadankyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vysledkyVysetreniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vysetreniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidujuciZamestnanecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prehľadyToolStripMenuItem,
            this.aplikáciaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prehľadyToolStripMenuItem
            // 
            this.prehľadyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamestnancovToolStripMenuItem,
            this.faktúrToolStripMenuItem,
            this.liekovToolStripMenuItem,
            this.úkonovToolStripMenuItem,
            this.poisťovneToolStripMenuItem,
            this.termínyToolStripMenuItem});
            this.prehľadyToolStripMenuItem.Name = "prehľadyToolStripMenuItem";
            this.prehľadyToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.prehľadyToolStripMenuItem.Text = "Prehľady";
            // 
            // zamestnancovToolStripMenuItem
            // 
            this.zamestnancovToolStripMenuItem.Name = "zamestnancovToolStripMenuItem";
            this.zamestnancovToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zamestnancovToolStripMenuItem.Text = "Zamestnancov";
            this.zamestnancovToolStripMenuItem.Click += new System.EventHandler(this.zamestnancovToolStripMenuItem_Click);
            // 
            // faktúrToolStripMenuItem
            // 
            this.faktúrToolStripMenuItem.Name = "faktúrToolStripMenuItem";
            this.faktúrToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.faktúrToolStripMenuItem.Text = "Faktúr";
            this.faktúrToolStripMenuItem.Click += new System.EventHandler(this.faktúrToolStripMenuItem_Click);
            // 
            // liekovToolStripMenuItem
            // 
            this.liekovToolStripMenuItem.Name = "liekovToolStripMenuItem";
            this.liekovToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.liekovToolStripMenuItem.Text = "Liekov";
            this.liekovToolStripMenuItem.Click += new System.EventHandler(this.liekovToolStripMenuItem_Click);
            // 
            // úkonovToolStripMenuItem
            // 
            this.úkonovToolStripMenuItem.Name = "úkonovToolStripMenuItem";
            this.úkonovToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.úkonovToolStripMenuItem.Text = "Úkonov";
            this.úkonovToolStripMenuItem.Click += new System.EventHandler(this.úkonovToolStripMenuItem_Click);
            // 
            // poisťovneToolStripMenuItem
            // 
            this.poisťovneToolStripMenuItem.Name = "poisťovneToolStripMenuItem";
            this.poisťovneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.poisťovneToolStripMenuItem.Text = "Poisťovne";
            this.poisťovneToolStripMenuItem.Click += new System.EventHandler(this.poisťovneToolStripMenuItem_Click);
            // 
            // termínyToolStripMenuItem
            // 
            this.termínyToolStripMenuItem.Name = "termínyToolStripMenuItem";
            this.termínyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.termínyToolStripMenuItem.Text = "Termíny";
            this.termínyToolStripMenuItem.Click += new System.EventHandler(this.termínyToolStripMenuItem_Click);
            // 
            // aplikáciaToolStripMenuItem
            // 
            this.aplikáciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.koniecToolStripMenuItem1,
            this.informácieToolStripMenuItem});
            this.aplikáciaToolStripMenuItem.Name = "aplikáciaToolStripMenuItem";
            this.aplikáciaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aplikáciaToolStripMenuItem.Text = "Aplikácia";
            // 
            // koniecToolStripMenuItem1
            // 
            this.koniecToolStripMenuItem1.Name = "koniecToolStripMenuItem1";
            this.koniecToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.koniecToolStripMenuItem1.Text = "Koniec";
            this.koniecToolStripMenuItem1.Click += new System.EventHandler(this.koniecToolStripMenuItem1_Click);
            // 
            // informácieToolStripMenuItem
            // 
            this.informácieToolStripMenuItem.Name = "informácieToolStripMenuItem";
            this.informácieToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.informácieToolStripMenuItem.Text = "Informácie";
            this.informácieToolStripMenuItem.Click += new System.EventHandler(this.informácieToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.93613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.06387F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pacientGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 498);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.UserLabel);
            this.flowLayoutPanel1.Controls.Add(this.PermisionLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(651, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 45);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserLabel.Location = new System.Drawing.Point(2, 0);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(82, 20);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "UserLabel";
            // 
            // PermisionLabel
            // 
            this.PermisionLabel.AutoSize = true;
            this.PermisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PermisionLabel.Location = new System.Drawing.Point(2, 20);
            this.PermisionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PermisionLabel.Name = "PermisionLabel";
            this.PermisionLabel.Size = new System.Drawing.Size(102, 16);
            this.PermisionLabel.TabIndex = 1;
            this.PermisionLabel.Text = "PermisionLabel";
            // 
            // pacientGrid
            // 
            this.pacientGrid.AllowUserToAddRows = false;
            this.pacientGrid.AllowUserToDeleteRows = false;
            this.pacientGrid.AllowUserToResizeRows = false;
            this.pacientGrid.AutoGenerateColumns = false;
            this.pacientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pacientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacientIDDataGridViewTextBoxColumn,
            this.menoDataGridViewTextBoxColumn,
            this.priezviskoDataGridViewTextBoxColumn,
            this.rodneCisloDataGridViewTextBoxColumn,
            this.datumNarodeniaDataGridViewTextBoxColumn,
            this.datumVytvoreniaDataGridViewTextBoxColumn,
            this.datumPoslednejZmenyDataGridViewTextBoxColumn,
            this.mobilneCisloDataGridViewTextBoxColumn,
            this.pridruzenaDiagnozaDataGridViewTextBoxColumn,
            this.mestoDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.cisloDataGridViewTextBoxColumn,
            this.pSCDataGridViewTextBoxColumn,
            this.zmazanyDataGridViewCheckBoxColumn,
            this.zdravotnaPoistovnaDataGridViewTextBoxColumn,
            this.receptyDataGridViewTextBoxColumn,
            this.ukonyDataGridViewTextBoxColumn,
            this.ziadankyDataGridViewTextBoxColumn,
            this.vysledkyVysetreniDataGridViewTextBoxColumn,
            this.vysetreniaDataGridViewTextBoxColumn,
            this.evidujuciZamestnanecDataGridViewTextBoxColumn});
            this.pacientGrid.DataSource = this.pacientBindingSource;
            this.pacientGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pacientGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.pacientGrid.Location = new System.Drawing.Point(2, 2);
            this.pacientGrid.Margin = new System.Windows.Forms.Padding(2);
            this.pacientGrid.MultiSelect = false;
            this.pacientGrid.Name = "pacientGrid";
            this.pacientGrid.ReadOnly = true;
            this.pacientGrid.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.pacientGrid, 3);
            this.pacientGrid.RowTemplate.Height = 24;
            this.pacientGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pacientGrid.Size = new System.Drawing.Size(645, 494);
            this.pacientGrid.TabIndex = 1;
            this.pacientGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientGrid_CellContentClick);
            this.pacientGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientGrid_CellContentDoubleClick);
            // 
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataSource = typeof(IS_HeMart.DataModel.Pacient);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.findText, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(651, 51);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(140, 344);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(2, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nový pacient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(2, 131);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Detail pacienta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // findText
            // 
            this.findText.Location = new System.Drawing.Point(2, 37);
            this.findText.Margin = new System.Windows.Forms.Padding(2);
            this.findText.Name = "findText";
            this.findText.Size = new System.Drawing.Size(133, 20);
            this.findText.TabIndex = 3;
            this.findText.TextChanged += new System.EventHandler(this.findText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "   Vyhľadávanie";
            // 
            // pacientIDDataGridViewTextBoxColumn
            // 
            this.pacientIDDataGridViewTextBoxColumn.DataPropertyName = "PacientID";
            this.pacientIDDataGridViewTextBoxColumn.FillWeight = 53.2995F;
            this.pacientIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.pacientIDDataGridViewTextBoxColumn.Name = "pacientIDDataGridViewTextBoxColumn";
            this.pacientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menoDataGridViewTextBoxColumn
            // 
            this.menoDataGridViewTextBoxColumn.DataPropertyName = "Meno";
            this.menoDataGridViewTextBoxColumn.FillWeight = 107.7834F;
            this.menoDataGridViewTextBoxColumn.HeaderText = "Meno";
            this.menoDataGridViewTextBoxColumn.Name = "menoDataGridViewTextBoxColumn";
            this.menoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priezviskoDataGridViewTextBoxColumn
            // 
            this.priezviskoDataGridViewTextBoxColumn.DataPropertyName = "Priezvisko";
            this.priezviskoDataGridViewTextBoxColumn.FillWeight = 107.7834F;
            this.priezviskoDataGridViewTextBoxColumn.HeaderText = "Priezvisko";
            this.priezviskoDataGridViewTextBoxColumn.Name = "priezviskoDataGridViewTextBoxColumn";
            this.priezviskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rodneCisloDataGridViewTextBoxColumn
            // 
            this.rodneCisloDataGridViewTextBoxColumn.DataPropertyName = "RodneCislo";
            this.rodneCisloDataGridViewTextBoxColumn.FillWeight = 107.7834F;
            this.rodneCisloDataGridViewTextBoxColumn.HeaderText = "RodneCislo";
            this.rodneCisloDataGridViewTextBoxColumn.Name = "rodneCisloDataGridViewTextBoxColumn";
            this.rodneCisloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumNarodeniaDataGridViewTextBoxColumn
            // 
            this.datumNarodeniaDataGridViewTextBoxColumn.DataPropertyName = "DatumNarodenia";
            this.datumNarodeniaDataGridViewTextBoxColumn.FillWeight = 107.7834F;
            this.datumNarodeniaDataGridViewTextBoxColumn.HeaderText = "DatumNarodenia";
            this.datumNarodeniaDataGridViewTextBoxColumn.Name = "datumNarodeniaDataGridViewTextBoxColumn";
            this.datumNarodeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumVytvoreniaDataGridViewTextBoxColumn
            // 
            this.datumVytvoreniaDataGridViewTextBoxColumn.DataPropertyName = "DatumVytvorenia";
            this.datumVytvoreniaDataGridViewTextBoxColumn.HeaderText = "DatumVytvorenia";
            this.datumVytvoreniaDataGridViewTextBoxColumn.Name = "datumVytvoreniaDataGridViewTextBoxColumn";
            this.datumVytvoreniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumVytvoreniaDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumPoslednejZmenyDataGridViewTextBoxColumn
            // 
            this.datumPoslednejZmenyDataGridViewTextBoxColumn.DataPropertyName = "DatumPoslednejZmeny";
            this.datumPoslednejZmenyDataGridViewTextBoxColumn.HeaderText = "DatumPoslednejZmeny";
            this.datumPoslednejZmenyDataGridViewTextBoxColumn.Name = "datumPoslednejZmenyDataGridViewTextBoxColumn";
            this.datumPoslednejZmenyDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumPoslednejZmenyDataGridViewTextBoxColumn.Visible = false;
            // 
            // mobilneCisloDataGridViewTextBoxColumn
            // 
            this.mobilneCisloDataGridViewTextBoxColumn.DataPropertyName = "MobilneCislo";
            this.mobilneCisloDataGridViewTextBoxColumn.FillWeight = 107.7834F;
            this.mobilneCisloDataGridViewTextBoxColumn.HeaderText = "MobilneCislo";
            this.mobilneCisloDataGridViewTextBoxColumn.Name = "mobilneCisloDataGridViewTextBoxColumn";
            this.mobilneCisloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pridruzenaDiagnozaDataGridViewTextBoxColumn
            // 
            this.pridruzenaDiagnozaDataGridViewTextBoxColumn.DataPropertyName = "PridruzenaDiagnoza";
            this.pridruzenaDiagnozaDataGridViewTextBoxColumn.HeaderText = "PridruzenaDiagnoza";
            this.pridruzenaDiagnozaDataGridViewTextBoxColumn.Name = "pridruzenaDiagnozaDataGridViewTextBoxColumn";
            this.pridruzenaDiagnozaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pridruzenaDiagnozaDataGridViewTextBoxColumn.Visible = false;
            // 
            // mestoDataGridViewTextBoxColumn
            // 
            this.mestoDataGridViewTextBoxColumn.DataPropertyName = "Mesto";
            this.mestoDataGridViewTextBoxColumn.FillWeight = 107.7834F;
            this.mestoDataGridViewTextBoxColumn.HeaderText = "Mesto";
            this.mestoDataGridViewTextBoxColumn.Name = "mestoDataGridViewTextBoxColumn";
            this.mestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ulicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cisloDataGridViewTextBoxColumn
            // 
            this.cisloDataGridViewTextBoxColumn.DataPropertyName = "Cislo";
            this.cisloDataGridViewTextBoxColumn.HeaderText = "Cislo";
            this.cisloDataGridViewTextBoxColumn.Name = "cisloDataGridViewTextBoxColumn";
            this.cisloDataGridViewTextBoxColumn.ReadOnly = true;
            this.cisloDataGridViewTextBoxColumn.Visible = false;
            // 
            // pSCDataGridViewTextBoxColumn
            // 
            this.pSCDataGridViewTextBoxColumn.DataPropertyName = "PSC";
            this.pSCDataGridViewTextBoxColumn.HeaderText = "PSC";
            this.pSCDataGridViewTextBoxColumn.Name = "pSCDataGridViewTextBoxColumn";
            this.pSCDataGridViewTextBoxColumn.ReadOnly = true;
            this.pSCDataGridViewTextBoxColumn.Visible = false;
            // 
            // zmazanyDataGridViewCheckBoxColumn
            // 
            this.zmazanyDataGridViewCheckBoxColumn.DataPropertyName = "Zmazany";
            this.zmazanyDataGridViewCheckBoxColumn.HeaderText = "Zmazany";
            this.zmazanyDataGridViewCheckBoxColumn.Name = "zmazanyDataGridViewCheckBoxColumn";
            this.zmazanyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.zmazanyDataGridViewCheckBoxColumn.Visible = false;
            // 
            // zdravotnaPoistovnaDataGridViewTextBoxColumn
            // 
            this.zdravotnaPoistovnaDataGridViewTextBoxColumn.DataPropertyName = "ZdravotnaPoistovna";
            this.zdravotnaPoistovnaDataGridViewTextBoxColumn.HeaderText = "ZdravotnaPoistovna";
            this.zdravotnaPoistovnaDataGridViewTextBoxColumn.Name = "zdravotnaPoistovnaDataGridViewTextBoxColumn";
            this.zdravotnaPoistovnaDataGridViewTextBoxColumn.ReadOnly = true;
            this.zdravotnaPoistovnaDataGridViewTextBoxColumn.Visible = false;
            // 
            // receptyDataGridViewTextBoxColumn
            // 
            this.receptyDataGridViewTextBoxColumn.DataPropertyName = "Recepty";
            this.receptyDataGridViewTextBoxColumn.HeaderText = "Recepty";
            this.receptyDataGridViewTextBoxColumn.Name = "receptyDataGridViewTextBoxColumn";
            this.receptyDataGridViewTextBoxColumn.ReadOnly = true;
            this.receptyDataGridViewTextBoxColumn.Visible = false;
            // 
            // ukonyDataGridViewTextBoxColumn
            // 
            this.ukonyDataGridViewTextBoxColumn.DataPropertyName = "Ukony";
            this.ukonyDataGridViewTextBoxColumn.HeaderText = "Ukony";
            this.ukonyDataGridViewTextBoxColumn.Name = "ukonyDataGridViewTextBoxColumn";
            this.ukonyDataGridViewTextBoxColumn.ReadOnly = true;
            this.ukonyDataGridViewTextBoxColumn.Visible = false;
            // 
            // ziadankyDataGridViewTextBoxColumn
            // 
            this.ziadankyDataGridViewTextBoxColumn.DataPropertyName = "Ziadanky";
            this.ziadankyDataGridViewTextBoxColumn.HeaderText = "Ziadanky";
            this.ziadankyDataGridViewTextBoxColumn.Name = "ziadankyDataGridViewTextBoxColumn";
            this.ziadankyDataGridViewTextBoxColumn.ReadOnly = true;
            this.ziadankyDataGridViewTextBoxColumn.Visible = false;
            // 
            // vysledkyVysetreniDataGridViewTextBoxColumn
            // 
            this.vysledkyVysetreniDataGridViewTextBoxColumn.DataPropertyName = "VysledkyVysetreni";
            this.vysledkyVysetreniDataGridViewTextBoxColumn.HeaderText = "VysledkyVysetreni";
            this.vysledkyVysetreniDataGridViewTextBoxColumn.Name = "vysledkyVysetreniDataGridViewTextBoxColumn";
            this.vysledkyVysetreniDataGridViewTextBoxColumn.ReadOnly = true;
            this.vysledkyVysetreniDataGridViewTextBoxColumn.Visible = false;
            // 
            // vysetreniaDataGridViewTextBoxColumn
            // 
            this.vysetreniaDataGridViewTextBoxColumn.DataPropertyName = "Vysetrenia";
            this.vysetreniaDataGridViewTextBoxColumn.HeaderText = "Vysetrenia";
            this.vysetreniaDataGridViewTextBoxColumn.Name = "vysetreniaDataGridViewTextBoxColumn";
            this.vysetreniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vysetreniaDataGridViewTextBoxColumn.Visible = false;
            // 
            // evidujuciZamestnanecDataGridViewTextBoxColumn
            // 
            this.evidujuciZamestnanecDataGridViewTextBoxColumn.DataPropertyName = "EvidujuciZamestnanec";
            this.evidujuciZamestnanecDataGridViewTextBoxColumn.HeaderText = "EvidujuciZamestnanec";
            this.evidujuciZamestnanecDataGridViewTextBoxColumn.Name = "evidujuciZamestnanecDataGridViewTextBoxColumn";
            this.evidujuciZamestnanecDataGridViewTextBoxColumn.ReadOnly = true;
            this.evidujuciZamestnanecDataGridViewTextBoxColumn.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(776, 556);
            this.Name = "MainForm";
            this.Text = "IS-HeMart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem prehľadyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zamestnancovToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem faktúrToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem liekovToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem úkonovToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aplikáciaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem informácieToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label UserLabel;
		private CustomDataGridView pacientGrid;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolStripMenuItem poisťovneToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem termínyToolStripMenuItem;
		private System.Windows.Forms.BindingSource pacientBindingSource;
		private System.Windows.Forms.Label PermisionLabel;
		private System.Windows.Forms.TextBox findText;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priezviskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodneCisloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumNarodeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVytvoreniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPoslednejZmenyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilneCisloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pridruzenaDiagnozaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cisloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn zmazanyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdravotnaPoistovnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukonyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ziadankyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vysledkyVysetreniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vysetreniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evidujuciZamestnanecDataGridViewTextBoxColumn;
    }
}

