using IS_HeMart.ServiceManagers;
using IS_HeMart.Forms.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_HeMart.Forms
{
	public class BaseForm : Form
	{
		private LoginManager _loginManager = LoginManager.Instance;
		public BaseForm()
		{
			
		}

		public virtual bool LoginNeeded()
		{
			return false;
		}

		public virtual void SetParameters(Parameters.Parameters value) 
		{
		}

		public virtual Parameters.Parameters GetParameters()
		{
			return default(Parameters.Parameters);
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// BaseForm
			// 
			this.ClientSize = new System.Drawing.Size(282, 253);
			this.Name = "BaseForm";
			this.ResumeLayout(false);

		}
	}
}