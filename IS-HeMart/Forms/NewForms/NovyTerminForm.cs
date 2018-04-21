using IS_HeMart.DataModel;
using IS_HeMart.Forms.Parameters;
using IS_HeMart.ServiceManagers;
using System;
using System.Windows.Forms;

namespace IS_HeMart.Forms.NewForms
{
	public partial class NovyTerminForm : BaseForm
    {
		private DataManager _dataManager;
		private Pacient _pacient;
        public NovyTerminForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
        }

		public override void SetParameters(Parameters.Parameters value)
		{
			_pacient = ((NovyReceptParameters)value).Pacient;
		}

		private void pridatButton_Click(object sender, EventArgs e)
		{
			try
			{
				var newTermin = new TerminVysetrenia();
				newTermin.CasVysetrenia = datumDateTimePicker.Value.Date.Add(dateTimePicker1.Value.TimeOfDay);
				newTermin.Pacient = _pacient;
				newTermin.Poznamka = popisText.Text;
				newTermin.Zamestnanec = LoginManager.Instance.LoggedUser;
				var data = (HemartContext)_dataManager.GetDbContext();
				data.TerminVysetrenia.Add(newTermin);
				data.SaveChanges();
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Chyba", "Nastala chyba:\n" + ex.Message);
			}
		}
	}
}
