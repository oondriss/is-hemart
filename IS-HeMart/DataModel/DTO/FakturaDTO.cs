using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel.DTO
{
	public class FakturaDTO
	{
		public int FakturaID { get; set; }
		public DateTime DatumVystavenia { get; set; }
		public DateTime DatumSplatnosti { get; set; }
		public Decimal Suma { get; set; }
		public bool Zmazana { get; set; }
		public virtual Zamestnanec Vystavil { get; set; }
		public virtual Pacient Pacient { get; set; }
		//public virtual ICollection<UkonPacient> Ukony { get; set; }
	}
}
