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
    public partial class UkonyForm : BaseForm
    {
		private DataManager _dataManager;
		private BindingListView<ZoznamUkonov> view;
        public UkonyForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
			view = new BindingListView<ZoznamUkonov>(_dataManager.GetUkonyBindingSource());
			zoznamUkonovBindingSource2.DataSource =  view;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

		private void UkonyForm_Load(object sender, EventArgs e)
		{
			//var data = (new DataManager()).GetZoznamUkonov().ToList();
			//dataGridView1.DataSource = data;
		}

		private void kod_ukText_TextChanged(object sender, EventArgs e)
		{
			var filterString = kod_ukText.Text;
			if (!string.IsNullOrWhiteSpace(filterString))
			{
				view.ApplyFilter(delegate (ZoznamUkonov zoznamUkonov)
				{
					return zoznamUkonov.Nazov.ToLower().Contains(filterString.ToLower())
						|| zoznamUkonov.Popis.ToLower().Contains(filterString.ToLower())
						|| zoznamUkonov.Kod.ToLower().Contains(filterString.ToLower());
				});
			}
			else
			{
				view.RemoveFilter();
				//zoznamLiekovBindingSource.RemoveFilter();
			}
		}
	}
}
