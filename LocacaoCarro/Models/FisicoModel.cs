using System.ComponentModel.DataAnnotations;

namespace LocacaoCarro.Models
{
	public class FisicoModel : ClienteModel
	{
		[Key]
		public int codigo { get; set; }
		public string cpf { get; set; }
		public string rg { get; set; }
	}
}
