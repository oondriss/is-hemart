using Equin.ApplicationFramework;
using IS_HeMart.DataModel;
using IS_HeMart.Forms.NewForms;
using IS_HeMart.ServiceManagers;
using System;

namespace IS_HeMart.Forms
{
	public partial class PoistovneForm : BaseForm
    {
		private DataManager _dataManager;
		private BindingListView<ZdravotnaPoistovna> view;
        public PoistovneForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
			view = new BindingListView<ZdravotnaPoistovna>(_dataManager.GetPoistovneBindingSource());
			zdravotnaPoistovnaBindingSource2.DataSource = view;
		}

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
			
        }

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			//ziskat objekt vyznaceneho riadku
			//naplnit jeho informacie do textboxov
			//DataGridViewRow.DataBoundItem
			if (dataGridView1.SelectedRows.Count > 0)
			{
				var rowObject = ((ObjectView<ZdravotnaPoistovna>)dataGridView1.SelectedRows[0].DataBoundItem).Object;
				nazovText.Text = rowObject.Nazov;
				ulicaText.Text = rowObject.Ulica;
				mestoText.Text = rowObject.Mesto;
				cisloText.Text = rowObject.Cislo;
				pscText.Text = rowObject.Psc;
				kod_zpText.Text = rowObject.Kod_ZP;
				icoText.Text = rowObject.ICO;
				dicText.Text = rowObject.DIC;
				ic_dphText.Text = rowObject.IC_DPH;
				cislo_ucText.Text = rowObject.CisloUctu;
			}


		}

		private void pridatButton_Click(object sender, EventArgs e)
		{
			var frm = FormManager.Current.CreateForm<NovaPoistovnaForm>();
			frm.SetParameters(null);
			frm.ShowDialog();
		}

		private void ulozitButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count < 1)
			{
				return;
			}
			var result = DateTime.Today;
			var poistovna = _dataManager.GetZdravotnaPoistovna((int)dataGridView1.SelectedRows[0].Cells[0].Value);
			poistovna.DIC = dicText.Text;
			poistovna.ICO = icoText.Text;
			poistovna.IC_DPH = ic_dphText.Text;
			poistovna.Kod_ZP = kod_zpText.Text;
			poistovna.Nazov = nazovText.Text;
			poistovna.Cislo = cisloText.Text;
			poistovna.Mesto = mestoText.Text;
			poistovna.Psc = pscText.Text;
			poistovna.Ulica = ulicaText.Text;
			poistovna.CisloUctu = cislo_ucText.Text;
			_dataManager.GetDbContext().SaveChanges();
		}
	}
}
