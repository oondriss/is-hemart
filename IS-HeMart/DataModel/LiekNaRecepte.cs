using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class LiekNaRecepte
	{
		[Key]
		public int ID { get; set; }
		public int Mnozstvo { get; set; }
		public virtual Recept Recept { get; set; }
		public virtual Liek Liek { get; set; }
	}
}
