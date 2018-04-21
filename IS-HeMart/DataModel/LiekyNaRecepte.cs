using System.ComponentModel.DataAnnotations;

namespace IS_HeMart.DataModel
{
	public class LiekyNaRecepte
	{
		[Key]
		public int LiekyNaRecepteID { get; set; }
		public int Mnozstvo { get; set; }
		public virtual Recepty Recept { get; set; }
		public virtual ZoznamLiekov Liek { get; set; }
	}
}
