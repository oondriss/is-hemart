using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class Pacient
	{
		[Key]
		public int PacientID { get; set; }
		public DateTime DatumNarodenia { get; set; }
		public DateTime DatumVytvorenia { get; set; }
		public DateTime DatumPoslednejZmeny { get; set; }
		public string Meno { get; set; }
		public string Priezvisko { get; set; }
		public string MobilneCislo { get; set; }
		public string PridruzenaDiagnoza { get; set; }
		public string RodneCislo { get; set; }
		public string Mesto { get; set; }
		public string Ulica { get; set; }
		public string Cislo { get; set; }
		public string PSC { get; set; }
		public bool Zmazany { get; set; }
		public virtual ZdravotnaPoistovna ZdravotnaPoistovna { get; set; }
		public virtual ICollection<Recepty> Recepty { get; set; }
		public virtual ICollection<UkonyPacienta> Ukony { get; set; }
		public virtual ICollection<Ziadanky> Ziadanky { get; set; }
		public virtual ICollection<VysledkyLaboratorneVysetrenie> VysledkyVysetreni { get; set; }
		public virtual ICollection<TerminVysetrenia> Vysetrenia { get; set; }
		public virtual Zamestnanec EvidujuciZamestnanec { get; set; }
	}
}
