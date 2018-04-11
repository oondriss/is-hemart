using IS_HeMart.DataModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.Forms.Parameters
{
	public class LoginParameters : Parameters
	{
		public LoginParameters(ZamestnanecDTO user)
		{
			User = user;
		}
		
		public ZamestnanecDTO User { get; set; }
	}
}
