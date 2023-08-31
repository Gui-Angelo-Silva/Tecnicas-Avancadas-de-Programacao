using System.ComponentModel.DataAnnotations;

namespace AtividadeCRUDCsharp.Models
{
    public class MunicipeModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe seu nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe seu endereço")]
        public string? Endereco { get; set; }

        [Required(ErrorMessage = "Informe seu telefone")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "Informe seu email")]
        public string? Email { get; set; }

    }
}
