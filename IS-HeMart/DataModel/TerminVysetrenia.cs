using System;
using System.ComponentModel.DataAnnotations;

namespace IS_HeMart.DataModel
{
	public class TerminVysetrenia
	{
		[Key]
		public int TerminVysetreniaID { get; set; }
		public DateTime CasVysetrenia { get; set; }
		public string Poznamka { get; set; }
		public virtual Pacient Pacient { get; set; }
		public virtual Zamestnanec Zamestnanec { get; set; }
	}
}
