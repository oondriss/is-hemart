using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class Recepty
	{
		public int ReceptyID { get; set; }
		public int Cislo_receptu { get; set; }
		public DateTime DatumVydania { get; set; }
		public DateTime DatumSplatnosti { get; set; }
		public virtual Pacient Pacient { get; set; }
		public virtual Zamestnanec Zamestnanec { get; set; }
		public virtual ICollection<LiekyNaRecepte> ObsiahnuteLieky { get; set; }
	}
}
