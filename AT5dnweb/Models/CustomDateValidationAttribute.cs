using System.ComponentModel.DataAnnotations;

//OBS: Para a construção dessa funcionalidade, precisei recorrer a ferramenta ChatGPT, pois não
//Aprendemos a manipular Datas

public class CustomDateValidation : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime date && date > DateTime.Now)
        {
            return new ValidationResult(ErrorMessage);
        }
        return ValidationResult.Success;
    }
}