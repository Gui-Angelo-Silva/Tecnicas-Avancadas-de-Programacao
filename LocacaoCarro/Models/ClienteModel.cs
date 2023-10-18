using System.ComponentModel.DataAnnotations;

namespace LocacaoCarro.Models
{
	public class ClienteModel
	{
		[Key]
		public int codigo { get; set; }
		public string nome { get; set; }
		public int idade { get; set; }
	}
}
