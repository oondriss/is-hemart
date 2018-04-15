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
    public partial class LiekyForm : BaseForm
    {
		private DataManager _dataManager;
        public LiekyForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
        }

		private void LiekyForm_Load(object sender, EventArgs e)
		{
			var data = _dataManager.GetZoznamLiekov();
			zoznamLiekovBindingSource.DataSource = data.ToList();
		}

		private void nazovText_KeyDown(object sender, KeyEventArgs e)
		{
			
		}

		private void nazovText_TextChanged(object sender, EventArgs e)
		{
			var filterString = nazovText.Text;
			if (!string.IsNullOrWhiteSpace(filterString))
			{
				zoznamLiekovBindingSource.Filter = $" Sukl_kod = '{filterString}' OR Nazov = '{filterString}'  OR Doplnok = '{filterString}'";
			}
			else
			{
				zoznamLiekovBindingSource.Filter = "";
			}
		}
	}
}
