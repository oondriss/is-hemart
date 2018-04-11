using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.Utils
{
	public static class DbLogger
	{
		const string LogFileName = "DbLog.txt";
		public static void Log(string message)
		{
			File.AppendAllText(LogFileName, $"{DateTime.Now.ToShortDateString()}-{DateTime.Now.ToShortTimeString()}---{message}{Environment.NewLine}");
		}
	}
}
