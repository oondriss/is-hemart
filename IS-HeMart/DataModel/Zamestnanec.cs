using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IS_HeMart.DataModel.DTO;

namespace IS_HeMart.DataModel
{
	public class Zamestnanec
	{
		public int ZamestnanecID { get; set; }
		public string Meno { get; set; }
		public string Priezvisko { get; set; }
		public string Ulica { get; set; }
		public string Cislo { get; set; }
		public string PSC { get; set; }
		public string Mesto { get; set; }
		public bool Zmazany { get; set; }
		public virtual ICollection<Pacient> ZaevidovanyPacienti { get; set; }
		public virtual ICollection<Recept> ZaevidovaneRecepty { get; set; }
		public virtual ICollection<Liek> ZaevidovaneLieky { get; set; }
		public virtual ICollection<Faktura> ZaevidovaneFaktury { get; set; }
		public virtual ICollection<Ukon> ZaevidovaneUkony { get; set; }
		public virtual ICollection<UkonPacient> ZaevidovaneUkonyPacientov { get; set; }

		public static implicit operator Zamestnanec(ZamestnanecDTO v)
		{
			return new Zamestnanec()
			{
				Meno = v.Meno,
				Priezvisko = v.Priezvisko,
				Ulica = v.Ulica,
				Cislo = v.Cislo,
				Mesto = v.Mesto,
				PSC = v.PSC,
				Zmazany = v.Zmazany,
				ZamestnanecID = v.ZamestnanecID,
				ZaevidovaneFaktury = v.ZaevidovaneFaktury,
				ZaevidovaneLieky = v.ZaevidovaneLieky,
				ZaevidovaneRecepty = v.ZaevidovaneRecepty,
				ZaevidovaneUkony = v.ZaevidovaneUkony,
				ZaevidovaneUkonyPacientov = v.ZaevidovaneUkonyPacientov,
				ZaevidovanyPacienti = v.ZaevidovanyPacienti
			};
		}
	}
}
