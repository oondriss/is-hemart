using IS_HeMart.DataModel;
using IS_HeMart.ServiceManagers;
using System;
using System.Windows.Forms;

namespace IS_HeMart.Forms.NewForms
{
	public partial class NovaPoistovnaForm : BaseForm
    {
		private DataManager _dataManager;
        public NovaPoistovnaForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
        }

		private void pridatButton_Click(object sender, EventArgs e)
		{
			try
			{
				var newPoistovna = new ZdravotnaPoistovna();
				newPoistovna.Cislo = cisloText.Text;
				newPoistovna.CisloUctu = cislo_ucText.Text;
				newPoistovna.DIC = dicText.Text;
				newPoistovna.ICO = icoText.Text;
				newPoistovna.IC_DPH = ic_dphText.Text;
				newPoistovna.Kod_ZP = kod_zpText.Text;
				newPoistovna.Mesto = mestoText.Text;
				newPoistovna.Nazov = nazovText.Text;
				newPoistovna.Psc = pscText.Text;
				newPoistovna.Ulica = ulicaText.Text;
				newPoistovna.Zamestnanec = LoginManager.Instance.LoggedUser;
				var data = (HemartContext)_dataManager.GetDbContext();
				data.ZdravotnaPoistovna.Add(newPoistovna);
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
