using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel.DTO
{
	public class ZamestnanecDTO
	{
		public int ZamestnanecID { get; set; }
		public string Meno { get; set; }
		public string Priezvisko { get; set; }
		public string Ulica { get; set; }
		public string Cislo { get; set; }
		public string PSC { get; set; }
		public string Mesto { get; set; }
		public bool Zmazany { get; set; }
		public DateTime DatumNarodenia { get; set; }
		public DateTime DatumNastupu { get; set; }
		public virtual ICollection<Pacient> ZaevidovanyPacienti { get; set; }
		public virtual ICollection<Recepty> ZaevidovaneRecepty { get; set; }
		public virtual ICollection<ZoznamLiekov> ZaevidovaneLieky { get; set; }
		public virtual ICollection<Faktury> ZaevidovaneFaktury { get; set; }
		public virtual ICollection<ZoznamUkonov> ZaevidovaneUkony { get; set; }
		public virtual ICollection<UkonyPacienta> ZaevidovaneUkonyPacientov { get; set; }
	}
}
