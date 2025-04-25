using System.ComponentModel.DataAnnotations;

namespace sistation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O e-mail � obrigat�rio")]
        [EmailAddress(ErrorMessage = "Digite um e-mail v�lido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha � obrigat�ria")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
