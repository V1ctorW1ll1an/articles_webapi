using System.ComponentModel.DataAnnotations;

namespace ArticlesData.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(70, MinimumLength = 1, ErrorMessage = "O Campo deve ter entre 1 e 70 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O Campo deve ter entre 1 e 100 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(70, MinimumLength = 8, ErrorMessage = "O Campo deve ter entre 8 e 70 caracteres")]
        public string Password { get; set; }
        public bool Admin { get; set; } = false;
        public string Role { get; set; }

    }
}
