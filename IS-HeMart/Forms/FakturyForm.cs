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
        public FakturyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			var frm = FormManager.Current.CreateForm<NovaFakturaForm>();
			frm.ShowDialog();
        }

        private void FakturyForm_Load(object sender, EventArgs e)
        {
			var data = (new DataManager()).GetFaktury().ToList();
			fakturaGrid.DataSource = data;
        }
    }
}
