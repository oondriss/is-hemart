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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientGrid)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
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
            this.zamestnancovToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zamestnancovToolStripMenuItem.Text = "Zamestnancov";
            this.zamestnancovToolStripMenuItem.Click += new System.EventHandler(this.zamestnancovToolStripMenuItem_Click);
            // 
            // faktúrToolStripMenuItem
            // 
            this.faktúrToolStripMenuItem.Name = "faktúrToolStripMenuItem";
            this.faktúrToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faktúrToolStripMenuItem.Text = "Faktúr";
            this.faktúrToolStripMenuItem.Click += new System.EventHandler(this.faktúrToolStripMenuItem_Click);
            // 
            // liekovToolStripMenuItem
            // 
            this.liekovToolStripMenuItem.Name = "liekovToolStripMenuItem";
            this.liekovToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.liekovToolStripMenuItem.Text = "Liekov";
            this.liekovToolStripMenuItem.Click += new System.EventHandler(this.liekovToolStripMenuItem_Click);
            // 
            // úkonovToolStripMenuItem
            // 
            this.úkonovToolStripMenuItem.Name = "úkonovToolStripMenuItem";
            this.úkonovToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.úkonovToolStripMenuItem.Text = "Úkonov";
            this.úkonovToolStripMenuItem.Click += new System.EventHandler(this.úkonovToolStripMenuItem_Click);
            // 
            // poisťovneToolStripMenuItem
            // 
            this.poisťovneToolStripMenuItem.Name = "poisťovneToolStripMenuItem";
            this.poisťovneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poisťovneToolStripMenuItem.Text = "Poisťovne";
            this.poisťovneToolStripMenuItem.Click += new System.EventHandler(this.poisťovneToolStripMenuItem_Click);
            // 
            // termínyToolStripMenuItem
            // 
            this.termínyToolStripMenuItem.Name = "termínyToolStripMenuItem";
            this.termínyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 498);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.UserLabel);
            this.flowLayoutPanel1.Controls.Add(this.PermisionLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(720, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(76, 45);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(2, 0);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(55, 13);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "UserLabel";
            // 
            // PermisionLabel
            // 
            this.PermisionLabel.AutoSize = true;
            this.PermisionLabel.Location = new System.Drawing.Point(2, 13);
            this.PermisionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PermisionLabel.Name = "PermisionLabel";
            this.PermisionLabel.Size = new System.Drawing.Size(70, 26);
            this.PermisionLabel.TabIndex = 1;
            this.PermisionLabel.Text = "PermisionLabel";
            // 
            // pacientGrid
            // 
            this.pacientGrid.AllowUserToAddRows = false;
            this.pacientGrid.AllowUserToDeleteRows = false;
            this.pacientGrid.AllowUserToResizeRows = false;
            this.pacientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.pacientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.pacientGrid.Size = new System.Drawing.Size(714, 494);
            this.pacientGrid.TabIndex = 1;
            this.pacientGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientGrid_CellContentClick);
            this.pacientGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientGrid_CellContentDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(720, 51);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(76, 344);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(2, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nový pacient";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(2, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Detail pacienta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "vyhladavanie";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(702, 558);
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
		private System.Windows.Forms.Label PermisionLabel;
		private CustomDataGridView pacientGrid;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolStripMenuItem poisťovneToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem termínyToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

