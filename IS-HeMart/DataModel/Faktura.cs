using IS_HeMart.DataModel.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class Faktury
	{
		[Key]
		public int FakturyID { get; set; }
		public DateTime DatumVystavenia { get; set; }
		public DateTime DatumSplatnosti { get; set; }
		public string VarSymbol { get; set; }
		public string KonSymbol { get; set; }
		public virtual ZdravotnaPoistovna Poistovna { get; set; }
		public virtual Zamestnanec Vystavil { get; set; }
		public virtual ICollection<UkonyNaFakture> Ukony { get; set; }
		public static implicit operator Faktury(FakturaDTO v)
		{
			return new Faktury()
			{
				DatumSplatnosti = v.DatumSplatnosti,
				DatumVystavenia = v.DatumVystavenia,
				FakturyID = v.FakturaID,
				

				Vystavil = v.Vystavil

			};
		}
	}
}
