using Equin.ApplicationFramework;
using IS_HeMart.DataModel;
using IS_HeMart.Forms.Parameters;
using IS_HeMart.Reports;
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

namespace IS_HeMart.Forms
{
	public partial class PacientDetailForm : BaseForm
	{
		private DataManager _dataManager = new DataManager();
		private int _pacientID;
		private Pacient pacient;
		private PacientDetailOperation _operation;

		private BindingListView<Ziadanky> _ziadankyView;
		private BindingListView<Recepty> _receptyView;
		private BindingListView<ZoznamUkonov> _ukonyView;
		private BindingListView<TerminVysetrenia> _terminyView;
		private BindingListView<VysledkyLaboratorneVysetrenie> _vysledkyView;
		private BindingListView<ZdravotnaPoistovna> _poistovnaView;

		public PacientDetailForm()
		{
			InitializeComponent();
		}

		public override void SetParameters(Parameters.Parameters value)
		{
			_pacientID = ((PacientDetailParameters)value).PacientID;
			_operation = ((PacientDetailParameters)value).Operation;
			pacient = _dataManager.GetPacient(_pacientID);
			ConfigureForm();
		}

		private void ConfigureForm()
		{
			_receptyView = new BindingListView<Recepty>(_dataManager.GetReceptyBindingSource());
			_receptyView.ApplyFilter(delegate(Recepty recept)
			{
					return recept.Pacient == pacient;
			});
			receptyBindingSource.DataSource = _receptyView;

			_ziadankyView = new BindingListView<Ziadanky>(_dataManager.GetZiadankyBindingSource());
			_ziadankyView.ApplyFilter(delegate (Ziadanky ziadanky)
			{
				return ziadanky.Pacient == pacient;
			});
			ziadankyBindingSource.DataSource = _ziadankyView;

			_ukonyView = new BindingListView<ZoznamUkonov>(_dataManager.GetZoznamUkonovBindingSource());
			_ukonyView.ApplyFilter(delegate (ZoznamUkonov ukony)
			{
				return ukony.UkonyPacienta.Any(i => i.Pacient == pacient);
			});
			zoznamUkonovBindingSource.DataSource = _ukonyView;

			_terminyView = new BindingListView<TerminVysetrenia>(_dataManager.GetTerminyBindingSource());
			_terminyView.ApplyFilter(delegate (TerminVysetrenia termin)
			{
				return termin.Pacient == pacient;
			});
			terminVysetreniaBindingSource.DataSource = _terminyView;

			_vysledkyView = new BindingListView<VysledkyLaboratorneVysetrenie>(_dataManager.GetVysledkyBindingSource());
			_vysledkyView.ApplyFilter(delegate (VysledkyLaboratorneVysetrenie vysledok)
			{
				return vysledok.Pacient == pacient;
			});
			vysledkyLaboratorneVysetrenieBindingSource.DataSource = _vysledkyView;

			_poistovnaView = new BindingListView<ZdravotnaPoistovna>(_dataManager.GetPoistovneBindingSource());
			zpCombo.DataSource = _poistovnaView;
			zpCombo.DisplayMember = "Nazov";
			zpCombo.ValueMember = "ZdravotnaPoistovnaID";

			menoText.Text = pacient.Meno;
			priezviskoText.Text = pacient.Priezvisko;
			rcText.Text = pacient.RodneCislo;
			telcText.Text = pacient.MobilneCislo;
			Dat_narText.Text = pacient.DatumNarodenia.ToString();
			dat_pos_zmText.Text = pacient.DatumPoslednejZmeny.ToString();
			dat_vytText.Text = pacient.DatumVytvorenia.ToString();
			mestoText.Text = pacient.Mesto;
			ulicaText.Text = pacient.Ulica;
			cisloText.Text = pacient.Cislo;
			pscText.Text = pacient.PSC;
			zmazanyCheck.Checked = pacient.Zmazany;
			zpCombo.SelectedValue = pacient.ZdravotnaPoistovna.ZdravotnaPoistovnaID;
		}

		public override Parameters.Parameters GetParameters()
		{
			return default(Parameters.Parameters);
		}

		public override bool LoginNeeded()
		{
			return true;
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

		private void PacientDetailForm_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var ziadanka = ((ObjectView<Ziadanky>)dataGridView3.SelectedRows[0].DataBoundItem).Object;
			var frm = FormManager.Current.CreateForm<ReportPreviewForm>();
			frm.SetParameters(new ReportPreviewParameter()
			{
				Parameters = new Dictionary<string, object>()
				{
					{"ziadankaID", ziadanka.ZiadankyID }
				},
				ReportPath = "Reports\\Ziadanka.rpt",
				ReportType = typeof(Ziadanka)
			});
			frm.ShowDialog();
		}

		private void receptButton_Click(object sender, EventArgs e)
		{
			var frm = FormManager.Current.CreateForm<NewForms.NovyReceptForm>();
			frm.SetParameters(null);
			frm.ShowDialog();
		}

		private void ziadankaButton_Click(object sender, EventArgs e)
		{
			var frm = FormManager.Current.CreateForm<NewForms.NovaZiadankaForm>();
			frm.SetParameters(null);
			frm.ShowDialog();
		}

		private void ukonButton_Click(object sender, EventArgs e)
		{
			var frm = FormManager.Current.CreateForm<NewForms.NovyUkonPacientForm>();
			frm.SetParameters(null);
			frm.ShowDialog();
		}

		private void terminButton_Click(object sender, EventArgs e)
		{
			var frm = FormManager.Current.CreateForm<NewForms.NovyTerminForm>();
			frm.SetParameters(null);
			frm.ShowDialog();
		}

		private void ulozitButton_Click(object sender, EventArgs e)
		{
			//pacient objekt mame
			//len mu nastavit hodnoty z textboxov
			//a dako vymysliet ako zavolat savechanges
			pacient.Cislo = cisloText.Text;
			pacient.DatumPoslednejZmeny = DateTime.Now;
			pacient.Meno = menoText.Text;
			pacient.Mesto = mestoText.Text;
			pacient.MobilneCislo = telcText.Text;
			pacient.Priezvisko = priezviskoText.Text;
			pacient.PSC = pscText.Text;
			pacient.Ulica = ulicaText.Text;
			pacient.ZdravotnaPoistovna = _dataManager.GetPoistovnaById((int)zpCombo.SelectedValue);
			pacient.Zmazany = zmazanyCheck.Checked;
			_dataManager.GetDbContext().SaveChanges();
		}
	}
}
