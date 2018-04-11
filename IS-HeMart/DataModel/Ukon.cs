using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class Ukon
	{
		[Key]
		public int UkonID { get; set; }
		public string Nazov { get; set; }
		public string Popis { get; set; }
		public Decimal Cena { get; set; }
		public bool Zmazany { get; set; }
		public virtual Zamestnanec Vytvoril { get; set; }
	}
}
