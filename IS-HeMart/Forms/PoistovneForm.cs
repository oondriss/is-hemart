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
        public PoistovneForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
			zdravotnaPoistovnaBindingSource.DataSource = _dataManager.GetPoistovne().ToList();
        }
    }
}
