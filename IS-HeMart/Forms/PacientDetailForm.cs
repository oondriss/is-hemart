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

namespace IS_HeMart.Forms
{
	public partial class PacientDetailForm : BaseForm
	{
		private DataManager _dataManager = new DataManager();
		private int _pacientID;
		private PacientDetailOperation _operation;
		public PacientDetailForm()
		{
			InitializeComponent();
		}

		public override void SetParameters(Parameters.Parameters value)
		{
			_pacientID = ((PacientDetailParameters)value).PacientID;
			_operation = ((PacientDetailParameters)value).Operation;

			ConfigureForm();
		}

		private void ConfigureForm()
		{
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
    }
}
