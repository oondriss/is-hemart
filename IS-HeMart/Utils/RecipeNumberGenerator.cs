using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.Utils
{
	public class RecipeNumberGenerator
	{
		static Random r = new Random();
		
		public static int GetNew()
		{
			var date = DateTime.Today;
			var numberString = $"{r.Next()}";
			return Convert.ToInt32(numberString);
		}
	}
}
