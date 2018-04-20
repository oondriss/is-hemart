using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
	public partial class ReportPreviewForm : BaseForm
	{
		private string _reportPath;
		private ReportDocument _document;
		private Dictionary<string, object> _parameters;

		public ReportPreviewForm()
		{
			InitializeComponent();
		}

		public override void SetParameters(Parameters.Parameters value)
		{
			var parameters = (ReportPreviewParameter)value;
			_reportPath = parameters.ReportPath;
			_parameters = parameters.Parameters;
			_document = new ReportDocument();
			_document.Load(_reportPath);
			_document.DataSourceConnections[0].SetConnection(ConfigManager.GetDbServer(), ConfigManager.GetDbName(), true);

			ParameterFields paramFields = new ParameterFields();

			foreach (KeyValuePair<string, object> item in _parameters)
			{


				ParameterField pfItemYr = new ParameterField
				{
					ParameterFieldName = item.Key //Employee ID is Crystal Report Parameter name.
				};

				ParameterDiscreteValue dcItemYr = new ParameterDiscreteValue
				{
					Value = item.Value
				};

				pfItemYr.CurrentValues.Add(dcItemYr);

				paramFields.Add(pfItemYr);

				

				//_document.SetParameterValue(item.Key, item.Value);
			}
			crystalReportViewer1.ParameterFieldInfo = paramFields;
			crystalReportViewer1.ReportSource = _document;
			//crystalReportViewer1.RefreshReport();
			//crystalReportViewer1.Refresh();
		}
	}
}
