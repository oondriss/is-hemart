using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.Forms.Parameters
{
	public class PacientDetailParameters : Parameters
	{
		public int PacientID { get; set; }
		public PacientDetailOperation Operation { get; set; }
	}

	public enum PacientDetailOperation
	{
		Detail = 0,
		New
	}
}
