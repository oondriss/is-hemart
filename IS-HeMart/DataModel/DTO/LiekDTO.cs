using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel.DTO
{
	public class LiekDTO
	{
		public int LiekID { get; set; }
		public string Sukl { get; set; }
		public string Nazov { get; set; }
		public string Poznamka { get; set; }
		public string Davkovanie { get; set; }
		public bool Zmazany { get; set; }
		public virtual Zamestnanec Zamestnanec { get; set; }
		public virtual ICollection<LiekNaRecepte> Recepty { get; set; }
	}
}
