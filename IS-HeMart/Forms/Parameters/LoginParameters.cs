using IS_HeMart.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.Forms.Parameters
{
	public class LoginParameters : Parameters
	{
		public LoginParameters(Zamestnanec user)
		{
			User = user;
		}
		
		public Zamestnanec User { get; set; }
	}
}
