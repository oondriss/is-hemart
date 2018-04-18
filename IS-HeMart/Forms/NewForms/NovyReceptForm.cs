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
using IS_HeMart.Forms.Parameters;

namespace IS_HeMart.Forms.NewForms
{
    public partial class NovyReceptForm : BaseForm
    {
		private BindingListView<ZoznamLiekov> _view;
		private DataManager _dataManager;

        public NovyReceptForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
			_view = new BindingListView<ZoznamLiekov>(_dataManager.GetLiekyDescBindingSource());
			liek1Combo.DataSource = _view;
			liek1Combo.DisplayMember = "Nazov";
			liek1Combo.ValueMember = "ZoznamLiekovID";
			liek2Combo.DataSource = _view;
			liek2Combo.DisplayMember = "Nazov";
			liek2Combo.ValueMember = "ZoznamLiekovID";
		}

		public override void SetParameters(Parameters.Parameters value)
		{
			
		}

		private void NovyReceptForm_Load(object sender, EventArgs e)
		{
			
		}

		private void predpisatButton_Click(object sender, EventArgs e)
		{
			var newRecept = new Recepty();

		}
	}
}
