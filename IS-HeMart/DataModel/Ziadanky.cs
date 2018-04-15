using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class Ziadanky
	{
		[Key]
		public int ZiadankyID { get; set; }
		public DateTime DatumVystavenia { get; set; }
		public string Popis { get; set; }
		public string Typ { get; set; }
		public virtual Pacient Pacient { get; set; }
		public virtual Zamestnanec Zamestnanec { get; set; }
	}
}
