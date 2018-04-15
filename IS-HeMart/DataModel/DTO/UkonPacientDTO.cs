using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel.DTO
{
	public class UkonPacientDTO
	{
		public int ID { get; set; }
		public DateTime DatumVytvorenia { get; set; }
		public double Pocetnost { get; set; }
		public string Popis { get; set; }
		public virtual Zamestnanec Zamestnanec { get; set; }
		public virtual Pacient Pacient { get; set; }
		public virtual ZoznamUkonov Ukon { get; set; }

	}
}
