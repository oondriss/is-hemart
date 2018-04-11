using IS_HeMart.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_HeMart.ServiceManagers
{
	public class FormManager : ApplicationContext
	{
		private List<BaseForm> forms = new List<BaseForm>();
		private BaseForm mainForm = null;
		private LoginManager _loginManager = LoginManager.Instance;
		//When each form closes, close the application if no other open forms
		private void onFormClosed(object sender, EventArgs e)
		{
			forms.Remove((BaseForm)sender);
			if (!forms.Any())
			{
				ExitThread();
			}
		}

		public void RegisterForm(BaseForm frm)
		{
			frm.FormClosed += onFormClosed;
			forms.Add(frm);
		}
		
		public T CreateForm<T>() where T : BaseForm, new()
		{
			var ret = new T();
			if (ret.LoginNeeded() && !_loginManager.IsUserLogged())
			{
				_loginManager.CheckLogin();
			}
			RegisterForm(ret);
			return ret;
		}
		
		private static Lazy<FormManager> _current = new Lazy<FormManager>();
		public static FormManager Current => _current.Value;
		
		public FormManager()
		{
			mainForm = CreateForm<MainForm>();
			mainForm.Show();
		}
	}
}