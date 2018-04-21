using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IS_HeMart.DataModel
{
	public class ZoznamUkonov
	{
		[Key]
		public int ZoznamUkonovID { get; set; }
		public string Nazov { get; set; }
		public string Popis { get; set; }
		public int Body { get; set; }
		public string Kod { get; set; }
		public virtual Zamestnanec Zamestnanec { get; set; }
		public virtual ICollection<UkonyPacienta> UkonyPacienta { get; set; }
	}
}
