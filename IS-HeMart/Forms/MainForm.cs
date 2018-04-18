using Equin.ApplicationFramework;
using IS_HeMart.DataModel;
using IS_HeMart.Forms;
using IS_HeMart.Forms.NewForms;
using IS_HeMart.Forms.Parameters;
using IS_HeMart.ServiceManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_HeMart
{
	public partial class MainForm : BaseForm
	{
		private DataManager _dataManager = new DataManager();
		private BindingListView<Pacient> view;

		public MainForm()
		{
			InitializeComponent();
			LoadData();
		}

		public override bool LoginNeeded()
		{
			return true;
		}

		private void LoadData()
		{
			view = new BindingListView<Pacient>(_dataManager.GetPacientBindingSource());
			pacientBindingSource.DataSource = view;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void FrmMain_Shown(object sender, EventArgs e)
		{
			var user = LoginManager.Instance.LoggedUser;
			UserLabel.Text = user.Meno + " " + user.Priezvisko;
			PermisionLabel.Text = user.Opravnenie.ToString();
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pacientGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (pacientGrid.SelectedRows.Count < 1)
				return;
			var pacientId = (int)pacientGrid.SelectedRows[0].Cells[0].Value;
			var frm = FormManager.Current.CreateForm<PacientDetailForm>();
			frm.SetParameters(new PacientDetailParameters()
			{
				Operation = PacientDetailOperation.Detail,
				PacientID = pacientId
			});
			frm.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var pacientId = (int)pacientGrid.SelectedRows[0].Cells[0].Value;
			var frm = FormManager.Current.CreateForm<PacientDetailForm>();
			frm.SetParameters(new PacientDetailParameters()
			{
				Operation = PacientDetailOperation.Detail,
				PacientID = pacientId
			});
			frm.Show();
		}

        private void pacientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void zamestnancovToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = FormManager.Current.CreateForm<ZamestnanciForm>();
			frm.ShowDialog();
		}

		private void faktúrToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = FormManager.Current.CreateForm<FakturyForm>();
			frm.ShowDialog();
		}

		private void liekovToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = FormManager.Current.CreateForm<LiekyForm>();
			frm.ShowDialog();
		}

		private void úkonovToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = FormManager.Current.CreateForm<UkonyForm>();
			frm.ShowDialog();
		}

		private void receptovToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void koniecToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void informácieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = FormManager.Current.CreateForm<InfoForm>();
			frm.ShowDialog();
		}

		private void poisťovneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = FormManager.Current.CreateForm<PoistovneForm>();
			frm.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var frm = FormManager.Current.CreateForm<NovyPacientForm>();
			frm.ShowDialog();
		}

		private void findText_TextChanged(object sender, EventArgs e)
		{
			var searchTerm = findText.Text;
			if (!string.IsNullOrWhiteSpace(searchTerm))
			{
				view.ApplyFilter(delegate (Pacient pacient)
				{
					return pacient.RodneCislo.Contains(searchTerm)
						|| pacient.Priezvisko.ToLower().Contains(searchTerm.ToLower())
						|| pacient.Meno.ToLower().Contains(searchTerm.ToLower());
				});
			}
			else
			{
				view.RemoveFilter();
			}
		}
	}
}