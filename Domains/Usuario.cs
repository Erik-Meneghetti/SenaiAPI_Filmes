using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace api_filmes_senai.Domains.StringLenght
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O campo não pode ser nulo")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "O campo não pode ser nulo")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "O campo não pode ser nulo")]
        [StringLength(60,MinimumLength = 6, ErrorMessage = "A senha deve conter no mínimo 6 caracteres")]
        public string? Senha { get; set; }










    }
}
