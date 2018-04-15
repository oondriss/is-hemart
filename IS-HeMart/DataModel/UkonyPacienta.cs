using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class UkonyPacienta
	{
		[Key]
		public int UkonyPacientID { get; set; }
		public DateTime Datum { get; set; }
		public double Pocetnost { get; set; }
		public string Poznamka { get; set; }
		public virtual Zamestnanec Zamestnanec { get; set; }
		public virtual Pacient Pacient { get; set; }
		public virtual ZoznamUkonov Ukon { get; set; }

	}
}
