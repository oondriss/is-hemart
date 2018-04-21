using Equin.ApplicationFramework;
using IS_HeMart.DataModel;
using IS_HeMart.ServiceManagers;
using System;

namespace IS_HeMart.Forms
{
	public partial class ZamestnanciForm : BaseForm
    {
		private DataManager _dataManager;
		private BindingListView<Zamestnanec> _view;
        public ZamestnanciForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
			_view = new BindingListView<Zamestnanec>(_dataManager.GetZamestnanecBindingSource());

			zamestnanecBindingSource.DataSource = _view;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				var rowObject = ((ObjectView<Zamestnanec>)dataGridView1.SelectedRows[0].DataBoundItem).Object;

				titulText.Text = rowObject.Titul;
				menoText.Text = rowObject.Meno;
				priezviskoText.Text = rowObject.Priezvisko;
				textBox4.Text = rowObject.Datum_narodenia.ToString();
				rod_cisText.Text = rowObject.Rodne_cislo;
				loginText.Text = rowObject.Login;
				opravnenieText.Text = rowObject.Opravnenie.ToString();
				kodText.Text = rowObject.Kod;
				emailText.Text = rowObject.Email;
				ulicaText.Text = rowObject.Ulica;
				mestoText.Text = rowObject.Mesto;
				cisloText.Text = rowObject.Cislo;
				pscText.Text = rowObject.Psc;
				cislo_ucText.Text = rowObject.Cislo_uctu;
				tel_cisText.Text = rowObject.Mobilne_cislo;
				zmazanyCheck.Checked = rowObject.Zmazany;
			}
		}

		private void ulozitButton_Click(object sender, EventArgs e)
		{
			var result = DateTime.Today;
			var zam = _dataManager.GetZamestnanec((int)dataGridView1.SelectedRows[0].Cells[0].Value);
			zam.Titul = titulText.Text;
			zam.Meno = menoText.Text;
			zam.Priezvisko = priezviskoText.Text;
			zam.Datum_narodenia = DateTime.TryParse(textBox4.Text, out result) ? result : result;
			zam.Rodne_cislo = rod_cisText.Text;
			zam.Login = loginText.Text;
			zam.Kod = kodText.Text;
			zam.Email = emailText.Text;
			zam.Cislo = cisloText.Text;
			zam.Mesto = mestoText.Text;
			zam.Psc = pscText.Text;
			zam.Ulica = ulicaText.Text;
			zam.Cislo_uctu = cislo_ucText.Text;
			zam.Mobilne_cislo = tel_cisText.Text;
			zam.Zmazany = zmazanyCheck.Checked;
			_dataManager.GetDbContext().SaveChanges();
			_view = new BindingListView<Zamestnanec>(_dataManager.GetZamestnanecBindingSource());
		}
	}
}
