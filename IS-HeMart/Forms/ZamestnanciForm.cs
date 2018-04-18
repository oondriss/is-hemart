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
        public ZamestnanciForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
			zamestnanecBindingSource.DataSource = _dataManager.GetZamestnanec();
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

 
    }
}
