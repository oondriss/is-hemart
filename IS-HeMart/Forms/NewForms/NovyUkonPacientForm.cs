using System;
using System.Windows.Forms;
using IS_HeMart.Forms.Parameters;
using IS_HeMart.DataModel;
using Equin.ApplicationFramework;
using IS_HeMart.ServiceManagers;

namespace IS_HeMart.Forms.NewForms
{
	public partial class NovyUkonPacientForm : BaseForm
    {
		private Pacient _pacient;
		private BindingListView<ZoznamUkonov> _view;
		private DataManager _dataManager;

		public NovyUkonPacientForm()
        {
            InitializeComponent();
        }

		public override void SetParameters(Parameters.Parameters value)
		{
			_pacient = ((NovyReceptParameters)value).Pacient;
		}

		private void pridatButton_Click(object sender, EventArgs e)
		{
			try
			{
				var result = 0.0;
				var newUkon = new UkonyPacienta()
				{
					Datum = DateTime.Now,
					Pacient = _pacient,
					Pocetnost = Double.TryParse(textBox1.Text, out result) ? result : 1.0,
					Poznamka = popisText.Text,
					Ukon = _dataManager.GetZoznamUkonovById((int)kodCombo.SelectedValue),
					Zamestnanec = LoginManager.Instance.LoggedUser
				};
				var data = (HemartContext)_dataManager.GetDbContext();
				data.UkonyPacienta.Add(newUkon);
				data.SaveChanges();
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Nastala chyba: \n" + ex.Message);
			}
		}

		private void NovyUkonPacientForm_Load(object sender, EventArgs e)
		{
			_dataManager = new DataManager();
			_view = new BindingListView<ZoznamUkonov>(_dataManager.GetUkonyBindingSource());
			kodCombo.DataSource = _view;
			kodCombo.ValueMember = "ZoznamUkonovID";
			kodCombo.DisplayMember = "Nazov";
		}
	}
}
