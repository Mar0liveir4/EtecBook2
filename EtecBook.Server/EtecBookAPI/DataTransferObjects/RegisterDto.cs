using System.ComponentModel.DataAnnotations;

namespace EtecBookAPI.DataTransferObjects;

 public class RegisterDto
{
    [Required(ErrorMessage ="Informe o Nome do usuário")]
    [StringLength(60, ErrorMessage ="O nome deve possuir no máximo 60 caracteres")]
    public string Name {get; set; }

    [Required(ErrorMessage ="Informe o Email do usuário")]
    [EmailAddress(ErrorMessage ="Informe um Email válido")]
    [StringLength(100, ErrorMessage ="O email deve possuir no máximo 100 caracteres")]
    public string Email { get; set; }

    [Required(ErrorMessage ="Informe a senha de acesso")]
    [StringLength(20, MinimumLength = 6, ErrorMessage ="A senha deve possuir no mínimo 6 e no máximo 20 caracteres")]
    public string Password{get; set; }
}
