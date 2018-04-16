using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class ZdravotnaPoistovna
	{
		[Key]
		public int ZdravotnaPoistovnaID { get; set; }
		public string Nazov { get; set; }
		public string Mesto { get; set; }
		public string Ulica { get; set; }
		public string Psc { get; set; }
		public string Cislo { get; set; }
		public string ICO { get; set; }
		public string DIC { get; set; }
		public string IC_DPH { get; set; }
		public string CisloUctu { get; set; }
		public string Kod_ZP { get; set; }
		public virtual Zamestnanec Zamestnanec { get; set; }
		public virtual ICollection<Pacient> Pacienti { get; set; }
		public virtual ICollection<Faktury> Faktury { get; set; }
	}
}
