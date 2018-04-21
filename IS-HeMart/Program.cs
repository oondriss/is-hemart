using IS_HeMart.ServiceManagers;
using System;
using System.Windows.Forms;

namespace IS_HeMart
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Startup.Automapper.Configure();
			Application.Run(FormManager.Current);
		}
	}
}