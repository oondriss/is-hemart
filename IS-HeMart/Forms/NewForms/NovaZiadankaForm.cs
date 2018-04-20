using IS_HeMart.DataModel;
using IS_HeMart.Forms.Parameters;
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

namespace IS_HeMart.Forms.NewForms
{
    public partial class NovaZiadankaForm : BaseForm
    {
		private DataManager _dataManager;
		private Pacient _pacient;
		private readonly Dictionary<int, string> ZiadankyTyp = new Dictionary<int, string>
		{
			{1, "CT" },
			{2, "MR" },
			{3, "GEN" },
			{4, "LAB" }
		};

        public NovaZiadankaForm()
        {
            InitializeComponent();
        }

		private void NovaZiadankaForm_Load(object sender, EventArgs e)
		{
			_dataManager = new DataManager();
			typCombo.DataSource = new BindingSource(ZiadankyTyp, null);
			typCombo.ValueMember = "Value";
			typCombo.DisplayMember = "Value";
		}
		public override void SetParameters(Parameters.Parameters value)
		{
			_pacient = ((NovyReceptParameters)value).Pacient;
		}
		private void vystavButton_Click(object sender, EventArgs e)
		{
			var newZiadanka = new Ziadanky()
			{
				DatumVystavenia = DateTime.Now,
				Pacient = _pacient,
				Popis = popisText.Text,
				Typ = typCombo.SelectedValue.ToString(),
				Zamestnanec = LoginManager.Instance.LoggedUser
			};
			var data = (HemartContext)_dataManager.GetDbContext();
			data.Ziadanky.Add(newZiadanka);
			data.SaveChanges();
			this.Close();
		}
	}
}