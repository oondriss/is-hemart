using Equin.ApplicationFramework;
using IS_HeMart.DataModel;
using IS_HeMart.ServiceManagers;
using System;
using System.Windows.Forms;

namespace IS_HeMart.Forms
{
	public partial class LiekyForm : BaseForm
    {
		private DataManager _dataManager;
		private BindingListView<ZoznamLiekov> view;

		public LiekyForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
        }

		private void LiekyForm_Load(object sender, EventArgs e)
		{
			//zoznamLiekovBindingSource.DataSource = ;
			view = new BindingListView<ZoznamLiekov>(_dataManager.GetZoznamLiekovBindingSource());
			zoznamLiekovBindingSource.DataSource = view;

		}

		private void nazovText_KeyDown(object sender, KeyEventArgs e)
		{
			
		}

		private void nazovText_TextChanged(object sender, EventArgs e)
		{
			var filterString = nazovText.Text;
			if (!string.IsNullOrWhiteSpace(filterString))
			{
				view.ApplyFilter(delegate (ZoznamLiekov zoznamLiekov)
				{
					return zoznamLiekov.Doplnok.ToLower().Contains(filterString.ToLower())
						|| zoznamLiekov.Nazov.ToLower().Contains(filterString.ToLower())
						|| zoznamLiekov.Sukl_kod.ToLower().Contains(filterString.ToLower());
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
