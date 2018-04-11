using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel.DTO
{
	public class ReceptDTO
	{
		public int ReceptID { get; set; }
		public DateTime DatumVytvorenia { get; set; }
		public DateTime DatumPlatnosti { get; set; }
		public bool Zmazany { get; set; }
		public virtual Pacient Pacient { get; set; }
		public virtual Zamestnanec Zamestnanec { get; set; }
		public virtual ICollection<LiekNaRecepte> ObsiahnuteLieky { get; set; }
	}
}
