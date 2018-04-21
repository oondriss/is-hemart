using System.ComponentModel.DataAnnotations;

namespace IS_HeMart.DataModel
{
	public class UkonyNaFakture
	{
		[Key]
		public int UkonyNaFaktureID { get; set; }
		public virtual UkonyPacienta UkonPaciet { get; set; }
		public virtual Faktury Faktura { get; set; }
	}
}
