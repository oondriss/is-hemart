using System;
using System.ComponentModel.DataAnnotations;

namespace IS_HeMart.DataModel
{
	public class VysledkyLaboratorneVysetrenie
	{
		[Key]
		public int VysledkyLaboratorneVysetrenieID { get; set; }
		public DateTime DatumVysledkov { get; set; }
		public string Popis { get; set; }
		public Pacient Pacient { get; set; }
	}
}
