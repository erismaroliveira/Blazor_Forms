using System.ComponentModel.DataAnnotations;

namespace Blazor_Forms.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome precisa ser informado")]
        [StringLength(10, ErrorMessage = "O nome deve está entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email deve ser informado")]
        [EmailAddress(ErrorMessage = "O email informado é inválido")]
        public string Email { get; set; }

        [Range(18, 80, ErrorMessage = "A idade deve está entre 18 e 80")]
        public int Idade { get; set; }
    }
}
