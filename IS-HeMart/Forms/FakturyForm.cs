using Equin.ApplicationFramework;
using IS_HeMart.DataModel;
using IS_HeMart.Forms.NewForms;
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
    }
}
