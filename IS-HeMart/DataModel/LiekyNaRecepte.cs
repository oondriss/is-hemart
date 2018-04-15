using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class LiekyNaRecepte
	{
		[Key]
		public int LiekyNaRecepteID { get; set; }
		public int Mnozstvo { get; set; }
		public virtual Recepty Recept { get; set; }
		public virtual ZoznamLiekov Liek { get; set; }
	}
}
