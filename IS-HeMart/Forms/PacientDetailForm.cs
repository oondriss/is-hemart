using Equin.ApplicationFramework;
using IS_HeMart.DataModel;
using IS_HeMart.Forms.Parameters;
using IS_HeMart.Reports;
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
	public partial class PacientDetailForm : BaseForm
	{
		private DataManager _dataManager = new DataManager();
		private int _pacientID;
		private Pacient pacient;
		private PacientDetailOperation _operation;

		private BindingListView<Ziadanky> _ziadankyView;



		public PacientDetailForm()
		{
			InitializeComponent();
		}

		public override void SetParameters(Parameters.Parameters value)
		{
			_pacientID = ((PacientDetailParameters)value).PacientID;
			_operation = ((PacientDetailParameters)value).Operation;
			pacient = _dataManager.GetPacient(_pacientID);
			ConfigureForm();
		}

		private void ConfigureForm()
		{
			//var pacientReceptyData = _dataManager.GetPacientRecept(pacient).ToList();
			//dataGridView1.DataSource = pacientReceptyData;

			_ziadankyView = new BindingListView<Ziadanky>(_dataManager.GetZiadankyBindingSource());
			_ziadankyView.ApplyFilter(delegate (Ziadanky ziadanky)
			{
				return ziadanky.Pacient == pacient;
			});
			ziadankyBindingSource.DataSource = _ziadankyView;

			//var pacientZiadankyData = _dataManager.GetPacientZiadanky(pacient).ToList();
			//dataGridView2.DataSource = pacientZiadankyData;

			//var pacientUkonyData = _dataManager.GetPacientUkony(pacient).ToList();
			//dataGridView3.DataSource = pacientUkonyData;
			//todo
			//nacitanie detailov o pacientovy, vykreslenie gridov o fakturach/receptoch atd
			//upravenie formy podla operacie = detail/edit
		}

		public override Parameters.Parameters GetParameters()
		{
			return default(Parameters.Parameters);
		}

		public override bool LoginNeeded()
		{
			return true;
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

		private void PacientDetailForm_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var ziadanka = ((ObjectView<Ziadanky>)dataGridView3.SelectedRows[0].DataBoundItem).Object;
			var frm = FormManager.Current.CreateForm<ReportPreviewForm>();
			frm.SetParameters(new ReportPreviewParameter()
			{
				Parameters = new Dictionary<string, object>()
				{
					{"ziadankaID", ziadanka.ZiadankyID }
				},
				ReportPath = "Reports\\Ziadanka.rpt",
				ReportType = typeof(Ziadanka)
			});
			frm.ShowDialog();
		}
	}
}
