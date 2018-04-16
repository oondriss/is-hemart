using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.Forms.Parameters
{
	public class ReportPreviewParameter : Parameters
	{
		public Dictionary<string, object> Parameters { get; set; }
		public string ReportPath { get; set; }
		public Type ReportType { get; set; }
	}
}
