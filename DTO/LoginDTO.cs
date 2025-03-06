using System.ComponentModel.DataAnnotations;

namespace api_filmes_senai.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "O campo não pode ser nulo")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo não pode ser nulo")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "A senha deve conter no mínimo 6 caracteres")]
        public string? Senha { get; set; }
    }
}
