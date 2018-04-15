using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class ZoznamLiekov
	{
		[Key]
		public int ZoznamLiekovID { get; set; }
		public string Sukl_kod { get; set; }
		public string Nazov { get; set; }
		public string Doplnok { get; set; }
		public virtual Zamestnanec Zamestnanec { get; set; }
		public virtual ICollection<LiekyNaRecepte> Recepty { get; set; }
	}
}
