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

namespace IS_HeMart.Forms
{
	public partial class LoginForm : BaseForm
	{
		private DataManager _dataManager = new DataManager();
		private LoginManager _loginManager = LoginManager.Instance;
		private Zamestnanec _loggedUser = null;

		public LoginForm()
		{
			InitializeComponent();
		}

		public override bool LoginNeeded()
		{
			return false;
		}

		public override Parameters.Parameters GetParameters() 
		{
			return new LoginParameters(_loggedUser);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_loggedUser = _dataManager.AuthorizeNamePass(NameText.Text, PassText.Text);
			if (_loggedUser == null)
			{
				MessageBox.Show("Nesprávne meno alebo heslo!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Close();
			}
		}
	}
}
