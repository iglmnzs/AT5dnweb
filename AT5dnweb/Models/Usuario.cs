using System.ComponentModel.DataAnnotations;

namespace AT5dnweb.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail deve ser válido")]
        public string Email { get; set; }

        //OBS: Para essa funcionalidade funcionar, precisei utilizar o ChatGPT para fazer consultas,
        //pois não sabia como manipular datas.

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [CustomDateValidation(ErrorMessage = "Data de nascimento inválida.")]
        public DateTime DataNascimento { get; set; }

    }
}
