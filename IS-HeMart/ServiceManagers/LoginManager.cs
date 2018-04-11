using IS_HeMart.DataModel.DTO;
using IS_HeMart.Forms;
using IS_HeMart.Forms.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.ServiceManagers
{
	public class LoginManager
	{
		private DataManager _dataManager = new DataManager();
		private static readonly LoginManager instance = new LoginManager();
		public ZamestnanecDTO LoggedUser { get; set; } = null;

		public static LoginManager Instance
		{
			get
			{
				return instance;
			}
		}

		// Explicit static constructor to tell C# compiler
		// not to mark type as beforefieldinit
		static LoginManager()
		{
		}

		private LoginManager()
		{
		}
		
		public bool IsUserLogged()
		{
			return LoggedUser != null;
		}

		public ZamestnanecDTO CheckLogin()
		{
			if (LoggedUser != null)
			{
				return LoggedUser;
			}
			else
			{
				var logForm = new LoginForm();// FormManager.Current.CreateForm<LoginForm>();
				if (logForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					var param = (LoginParameters)logForm.GetParameters();
					LoggedUser = param.User;
				}
				else
				{
					FormManager.Current.ExitThread();
				}
			}
			return LoggedUser;
		}

		public ZamestnanecDTO GetLoggedUser()
		{
			return  LoggedUser;
		}
	}
}