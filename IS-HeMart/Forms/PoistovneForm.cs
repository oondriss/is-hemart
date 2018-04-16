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
	}
}
