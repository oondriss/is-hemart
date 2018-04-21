using Equin.ApplicationFramework;
using IS_HeMart.DataModel;
using IS_HeMart.ServiceManagers;
using System;
using System.Collections.Generic;
using IS_HeMart.Forms.Parameters;
using IS_HeMart.Utils;

namespace IS_HeMart.Forms.NewForms
{
	public partial class NovyReceptForm : BaseForm
    {
		private BindingListView<ZoznamLiekovDTO> _view;
		private BindingListView<ZoznamLiekovDTO> _view2;
		private DataManager _dataManager;
		private Pacient _pacient;

        public NovyReceptForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
			_view = new BindingListView<ZoznamLiekovDTO>(_dataManager.GetLiekyDescBindingSource());
			_view2 = new BindingListView<ZoznamLiekovDTO>(_dataManager.GetLiekyDescBindingSource());
			liek1Combo.DataSource = _view;
			liek1Combo.DisplayMember = "Nazov";
			liek1Combo.ValueMember = "ZoznamLiekovID";
			liek1Combo.SelectedIndex = -1;
			liek2Combo.DataSource = _view2;
			liek2Combo.DisplayMember = "Nazov";
			liek2Combo.ValueMember = "ZoznamLiekovID";
			liek2Combo.SelectedIndex = -1;
		}

		public override void SetParameters(Parameters.Parameters value)
		{
			_pacient = ((NovyReceptParameters)value).Pacient;
		}

		private void NovyReceptForm_Load(object sender, EventArgs e)
		{
			
		}

		private void predpisatButton_Click(object sender, EventArgs e)
		{
			var newRecept = new Recepty
			{
				Pacient = _pacient,
				Zamestnanec = LoginManager.Instance.LoggedUser,
				DatumVydania = DateTime.Now,
				DatumSplatnosti = DateTime.Now.AddDays(14),
				Cislo_receptu = RecipeNumberGenerator.GetNew()
			};
			var newReceptLieky = new List<LiekyNaRecepte>();
			if (liek1Combo.SelectedIndex != -1)
			{
				newReceptLieky.Add(new LiekyNaRecepte()
				{
					Liek = _dataManager.GetZoznamLiekovById((int)liek1Combo.SelectedValue),
					Mnozstvo = Convert.ToInt32(textBox1.Text)
				});
			}
			if (liek2Combo.SelectedIndex != -1)
			{
				newReceptLieky.Add(new LiekyNaRecepte()
				{
					Liek = _dataManager.GetZoznamLiekovById((int)liek2Combo.SelectedValue),
					Mnozstvo = Convert.ToInt32(textBox2.Text)
				});
			}
			newRecept.ObsiahnuteLieky = newReceptLieky;
			var ctx = (HemartContext)_dataManager.GetDbContext();
			ctx.Recepty.Add(newRecept);
			ctx.SaveChanges();
			Close();
		}
	}
}
