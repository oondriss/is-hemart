using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
