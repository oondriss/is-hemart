using Equin.ApplicationFramework;
using IS_HeMart.DataModel;
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

namespace IS_HeMart.Forms.NewForms
{
    public partial class NovyPacientForm : BaseForm
    {
		private DataManager _dataManager;
		private BindingListView<ZdravotnaPoistovna> _poistovnaView;

        public NovyPacientForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

		private void NovyPacientForm_Load(object sender, EventArgs e)
		{
			_poistovnaView = new BindingListView<ZdravotnaPoistovna>(_dataManager.GetPoistovneBindingSource());
			zpCombo.DataSource = _poistovnaView;
			zpCombo.DisplayMember = "Nazov";
			zpCombo.ValueMember = "ZdravotnaPoistovnaID";
		}

		private void pridatButton_Click(object sender, EventArgs e)
		{
			if (!CheckInput())
			{
				MessageBox.Show("Nie su vyplnene vsetky povinne polia!!");
				return;
			}
			var newPacient = new Pacient();
			newPacient.Meno = menoText.Text;
			newPacient.Priezvisko = priezviskoText.Text;
			newPacient.Ulica = ulicaText.Text;
			newPacient.Mesto = mestoText.Text;
			newPacient.Cislo = cisloText.Text;
			newPacient.PSC = pscText.Text;
			newPacient.RodneCislo = rod_cisText.Text;
			newPacient.MobilneCislo = tel_cisText.Text;
			newPacient.EvidujuciZamestnanec = LoginManager.Instance.LoggedUser;
			newPacient.DatumNarodenia = dat_narDateTimePicker.Value;
			newPacient.DatumPoslednejZmeny = DateTime.Now;
			newPacient.DatumVytvorenia = DateTime.Now;
			newPacient.ZdravotnaPoistovna = _dataManager.GetPoistovnaById((int)zpCombo.SelectedValue);
			_dataManager.AddNewPacient(newPacient);
			this.Close();
		}

		private bool CheckInput()
		{
			var result = true;

			if ( string.IsNullOrWhiteSpace(menoText.Text)
			  || string.IsNullOrWhiteSpace(priezviskoText.Text)
			  || string.IsNullOrWhiteSpace(ulicaText.Text)
			  || string.IsNullOrWhiteSpace(cisloText.Text)
			  || string.IsNullOrWhiteSpace(pscText.Text)
			  || string.IsNullOrWhiteSpace(mestoText.Text)
			  || string.IsNullOrWhiteSpace(rod_cisText.Text)
			  || string.IsNullOrWhiteSpace(tel_cisText.Text))
			{
				result = false;
			}

			return result;
		}
	}
}
