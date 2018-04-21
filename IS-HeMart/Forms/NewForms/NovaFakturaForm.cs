using Equin.ApplicationFramework;
using IS_HeMart.DataModel;
using IS_HeMart.ServiceManagers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace IS_HeMart.Forms.NewForms
{
	public partial class NovaFakturaForm : BaseForm
    {
		private DataManager _dataManager;
		private BindingListView<ZdravotnaPoistovna> _poistovnaView;
		private BindingListView<int> _rokyView;

		public NovaFakturaForm()
        {
            InitializeComponent();

			_dataManager = new DataManager();
			_poistovnaView = new BindingListView<ZdravotnaPoistovna>(_dataManager.GetPoistovneBindingSource());
			_rokyView = new BindingListView<int>(_dataManager.GetRokyUkony());
			rokCombo.DataSource = _rokyView;
			zpCombo.DataSource = _poistovnaView;
			zpCombo.DisplayMember = "Nazov";
			zpCombo.ValueMember = "ZdravotnaPoistovnaID";
			var months = Enumerable
							.Range(1, 12)
							.Select(i => new
							{
								I = i,
								M = DateTimeFormatInfo.CurrentInfo.GetMonthName(i)
							}).ToList();
			mesiacCombo.DataSource = months;
			mesiacCombo.DisplayMember = "M";
			mesiacCombo.ValueMember = "I";
		}

		private void vystavButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				//potrebujem nacitat vsetky UkonyPacient od danej poistovne
				//ktore este nemaju zaznam v UkonyNaFakture
				var poistovnaId = (int)zpCombo.SelectedValue;
				var mesiac = (int)mesiacCombo.SelectedValue;
				var rok = Convert.ToInt32(rokCombo.SelectedItem.ToString());
				var nefakturovaneUkony = _dataManager.GetNefakturovaneUkony(poistovnaId, mesiac, rok);
				var newFaktura = new Faktury
				{
					DatumVystavenia = DateTime.Now,
					DatumSplatnosti = DateTime.Now.AddDays(30),
					KonSymbol = kon_symText.Text,
					Poistovna = _dataManager.GetPoistovnaById(poistovnaId),
					VarSymbol = var_symText.Text,
					Vystavil = LoginManager.Instance.LoggedUser,
					Ukony = new List<UkonyNaFakture>()
				};
				foreach (var ukon in nefakturovaneUkony)
				{
					var newUkonyNaFakture = new UkonyNaFakture
					{
						Faktura = newFaktura,
						UkonPaciet = ukon
					};
					newFaktura.Ukony.Add(newUkonyNaFakture);
				}

				var data = (HemartContext)_dataManager.GetDbContext();
				data.Faktury.Add(newFaktura);
				data.SaveChanges();
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Chyba", "Nastala chyba:\n" + ex.Message);
			}
		}
	}
}
