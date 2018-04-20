using IS_HeMart.DataModel;
using IS_HeMart.ServiceManagers;
using IS_HeMart.Utils;
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
    public partial class NovyZamestnanec : BaseForm
    {
		private DataManager _dataManager;
		private BindingSource _comboOpravnenia;
        public NovyZamestnanec()
        {
            InitializeComponent();
			_dataManager = new DataManager();
			_comboOpravnenia = new BindingSource(EnumHelper.GetEnumItems<Opravnenie>(), null);
			comboBox1.DataSource = _comboOpravnenia;
			comboBox1.DisplayMember = "Value";
			comboBox1.ValueMember = "Key";
        }

		private bool CheckFields()
		{
			return string.IsNullOrWhiteSpace(cisloText.Text) ||
				   string.IsNullOrWhiteSpace(cislo_ucText.Text) ||
				   string.IsNullOrWhiteSpace(emailText.Text) ||
				   string.IsNullOrWhiteSpace(hesloText.Text) ||
				   string.IsNullOrWhiteSpace(kodText.Text) ||
				   string.IsNullOrWhiteSpace(loginText.Text) ||
				   string.IsNullOrWhiteSpace(menoText.Text) ||
				   string.IsNullOrWhiteSpace(mestoText.Text) ||
				   string.IsNullOrWhiteSpace(tel_cisText.Text) ||
				   string.IsNullOrWhiteSpace(priezviskoText.Text) ||
				   string.IsNullOrWhiteSpace(pscText.Text) ||
				   string.IsNullOrWhiteSpace(rod_cisText.Text) ||
				   string.IsNullOrWhiteSpace(titulText.Text) ||
				   string.IsNullOrWhiteSpace(ulicaText.Text);
		}

		private void pridatButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (CheckFields())
				{
					return;
				}
				var newZamestnanec = new Zamestnanec()
				{
					Cislo = cisloText.Text,
					Cislo_uctu = cislo_ucText.Text,
					Datum_narodenia = dateTimePicker1.Value,
					Email = emailText.Text,
					Heslo = ShaEncrypter.Hash(hesloText.Text),
					Kod = kodText.Text,
					Login = loginText.Text,
					Meno = menoText.Text,
					Mesto = mestoText.Text,
					Mobilne_cislo = tel_cisText.Text,
					Opravnenie = (Opravnenie)(int)comboBox1.SelectedValue,
					Priezvisko = priezviskoText.Text,
					Psc = pscText.Text,
					Rodne_cislo = rod_cisText.Text,
					Titul = titulText.Text,
					Ulica = ulicaText.Text
				};
				var data = (HemartContext)_dataManager.GetDbContext();
				data.Zamestnanec.Add(newZamestnanec);
				data.SaveChanges();
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Chyba", "Nastala chyba: \n" + ex.Message);
			}
		}
	}
}
