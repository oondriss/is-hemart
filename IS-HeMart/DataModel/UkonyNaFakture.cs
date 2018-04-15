using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class UkonyNaFakture
	{
		[Key]
		public int UkonyNaFaktureID { get; set; }
		public virtual UkonyPacienta UkonPaciet { get; set; }
		public virtual Faktury Faktura { get; set; }
	}
}
