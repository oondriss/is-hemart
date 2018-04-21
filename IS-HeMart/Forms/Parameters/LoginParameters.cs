using IS_HeMart.DataModel;

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
