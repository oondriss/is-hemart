using IS_HeMart.DataModel.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class Faktura
	{
		[Key]
		public int FakturaID { get; set; }
		public DateTime DatumVystavenia { get; set; }
		public DateTime DatumSplatnosti { get; set; }
		public Decimal Suma { get; set; }
		public bool Zmazana { get; set; }
		public virtual Zamestnanec Vystavil { get; set; }
		public virtual Pacient Pacient { get; set; }
		//public virtual ICollection<UkonPacient> Ukony { get; set; }
		public static implicit operator Faktura(FakturaDTO v)
		{
			return new Faktura()
			{
				DatumSplatnosti = v.DatumSplatnosti,
				DatumVystavenia = v.DatumVystavenia,
				FakturaID = v.FakturaID,
				Pacient = v.Pacient,
				Suma = v.Suma,
				Vystavil = v.Vystavil,
				Zmazana = v.Zmazana
			};
		}
	}
}
