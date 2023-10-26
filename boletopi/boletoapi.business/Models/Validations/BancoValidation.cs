using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boletoapi.business.Models.Validations
{
    public class BancoValidation : AbstractValidator<Banco>
    {
        public BancoValidation() 
        {
            RuleFor(f => f.Nome)
               .NotEmpty().WithMessage("O campo {Nome} precisa ser fornecido")
               .Length(2, 100)
               .WithMessage("O campo {Nome} precisa ter entre {MinLength} e {MaxLength} caracteres");

        }
    }
}
