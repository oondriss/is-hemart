using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel.DTO
{
	public class PacientDTO
	{
		public int PacientID { get; set; }
		public string Meno { get; set; }
		public string Priezvisko { get; set; }
		public string Ulica { get; set; }
		public string Cislo { get; set; }
		public string PSC { get; set; }
		public string Mesto { get; set; }
		public string RodneCislo { get; set; }
		public DateTime DatumNarodenia { get; set; }
		public DateTime DatumVytvorenia { get; set; }
		public bool Zmazany { get; set; }
		public virtual ICollection<Recept> Recepty { get; set; }
		public virtual ICollection<Ukon> Ukony { get; set; }
		public virtual ICollection<Faktura> Faktury { get; set; }
		public virtual Zamestnanec EvidujuciZamestnanec { get; set; }
	}
}
