using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class EmprestimoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o campo do Recebedor")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Digite o campo do Fornecedor")]
        public string Fornecedor { get; set;}

        [Required(ErrorMessage = "Digite o nome do Livro")]
        public string LivroEmprestado { get; set; } 
        public DateTime DataEmprestimo { get; set; } = DateTime.Now;
    }
}
