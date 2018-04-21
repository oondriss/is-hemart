using IS_HeMart.DataModel;
using IS_HeMart.Forms;
using IS_HeMart.Forms.Parameters;

namespace IS_HeMart.ServiceManagers
{
	public class LoginManager
	{
		private DataManager _dataManager = new DataManager();
		private static readonly LoginManager instance = new LoginManager();
		public Zamestnanec LoggedUser { get; set; } = null;

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

		public Zamestnanec CheckLogin()
		{
			do
			{
				var logForm = new LoginForm();// FormManager.Current.CreateForm<LoginForm>();
				if (logForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					var param = (LoginParameters)logForm.GetParameters();
					LoggedUser = param.User;
					logForm.Close();
				}
				else
				{
					//MessageBox.Show("")
					logForm.Close();
					//logForm.Dispose();
					//FormManager.Current.ExitThread();
				}
			} while (LoggedUser == null);

			return LoggedUser;
		}

		public Zamestnanec GetLoggedUser()
		{
			return  LoggedUser;
		}
	}
}