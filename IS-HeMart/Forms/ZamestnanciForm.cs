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

		}
	}
}
