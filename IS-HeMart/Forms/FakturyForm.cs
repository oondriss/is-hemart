using Equin.ApplicationFramework;
using IS_HeMart.DataModel;
using IS_HeMart.Forms.NewForms;
using IS_HeMart.Forms.Parameters;
using IS_HeMart.Reports;
using IS_HeMart.ServiceManagers;
using System;
using System.Collections.Generic;

namespace IS_HeMart.Forms
{
	public partial class FakturyForm : BaseForm
    {
		private DataManager _dataManager;
		private BindingListView<Faktury> view;

		public FakturyForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			var frm = FormManager.Current.CreateForm<NovaFakturaForm>();
			frm.ShowDialog();
        }

        private void FakturyForm_Load(object sender, EventArgs e)
        {
			view = new BindingListView<Faktury>(_dataManager.GetFakturyBindingList());

			fakturyBindingSource.DataSource = view;
		}

		private void fakturaGrid_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			var faktura = ((ObjectView<Faktury>)fakturaGrid.SelectedRows[0].DataBoundItem).Object;
			var frm = FormManager.Current.CreateForm<ReportPreviewForm>();
			frm.SetParameters(new ReportPreviewParameter()
			{
				Parameters = new Dictionary<string, object>()
				{
					{"FakturaId", faktura.FakturyID },
					{"mesiac", faktura.DatumVystavenia.Date.Month },
					{"rok", faktura.DatumVystavenia.Date.Year }
				},
				ReportPath = "Reports\\Faktura.rpt",
				ReportType = typeof(Faktura)
			});
			frm.ShowDialog();
		}
	}
}
